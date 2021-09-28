'Ez a "Form"-hoz tartozó Visual Basic kód. Amikor a Formon létrehozol egy elemet és duplán rákattintasz, akkor készíteni fog neked egy objektumot Subrutinként.
'Amikor a Form-On rákattintasz egy elemre és rányomsz a properties-re, akkor ott be tudod állítani a "Name" rublika mellett a változó nevét, amin keresztül aztán tudsz adatot manipulálni ezen a fülön.
'Ezen a form-On leginkább csak Button, Label, ComboBox, DataGrid, Chart és PictureBox típusú elemek vannak. Ezeket a ToolBox-ból éred el.
'Button: csak a már említett "Name" és "Text" változó rublika fontos. A Text-en azt tudod beállítani, hogy mi jelenjen meg a gombon magán.
'Label: ugyanaz mint As Button, csak nem tudsz kattintani vele.
'DataGrid: csak a "Name" a "Text" az oszlop és sorindexek amik fontosak. Ezeket a jobb felső sarokban megjelenő háromszögekkel tudod megnyitni. 
'ComboBox: Name és Collection ami fontos. A Collection-ben tudod beállítani, hogy milyen elemek legyenek elérhetőek a legördülő menüben. A "DropDownStyle"-t állíts be "DropDownLIst"-re.
'Chart: Csak a "Name" és a Properties --> Chart menüpontban lévő dolgok érdekesek. (Itt tudod beállítani, hogy milyen legyen a diagram megjelenése, collection-ként van feltűntetve)
'PictureBox: InkScape-el megszerkesztett .png képeket tudsz importálni, HandledMouseEventArgs ha a kis háromszögre kattintasz.
'Add hozzá még a SerialPort, TimerSerial, TimerDataLogRecord, SaveFileDialog objektumokat is. 

'Táblázatkezelésehez szükséges könyvtár fájlok. 
Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Threading


Public Class Form1

    'Azokat a változókat amit több subrutin is használ azt globális változóként kell deklarálni a ArduinoDataLogger publikus osztályon. 

    Dim StrParse As String
    Dim p1, T1, bit1p, bit1T, U1T, U1p As String 'A soros porton így címkéztem fel a különböző változókat. Ha a .net progi belefut valamelyik címkébe, akkor a "_L" végződésű változóban tárolja az utána következő számot.

    Dim p1_L, T1_L, bit1p_L, bit1T_L, U1T_L, U1p_L As Integer 'Változó amiben az adott mérési adat számértékét tárolja. Valamiért integerként is két tizedes jegyre tárolja amikor használtam. (Why tho?) Ha gondolod írd át float-ra vagy double-ra.

    Dim Limit As Integer = 1000 'Hány mérési adat férjen el a grafikonon. 
    Dim FilePathAndName As String

    Dim Again As String
    Dim stopclick As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'Globális változók és a program megnyitásakkor jelenlévő alapbeállítások.


        'Enabled --> rá tudsz kattintani
        'Disabled --> nem engedi, hogy rákattints

        Button_Stop_Recording.Enabled = False
        Button_Start_Recording.Enabled = False
        Button_Start_Recording.Enabled = False
        Button_Stop_Recording.Enabled = False
        ComboBox_BaudRate.SelectedIndex = 3


        'Chart dimenzióit adja meg, magasság, szélesség. 
        For i = 0 To 30 Step 1
            Chart_Temperature.Series("Temperature").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart_Temperature.Series(0).Points.Count = Limit Then
                Chart_Temperature.Series(0).Points.RemoveAt(0)
            End If
            Chart_Temperature.ChartAreas(0).AxisY.Maximum = 100
        Next
        Chart_Temperature.ChartAreas(0).AxisY.Maximum = 100

        For i = 0 To 30 Step 1
            Chart_Pressure.Series("Pressure").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart_Pressure.Series(0).Points.Count = Limit Then
                Chart_Pressure.Series(0).Points.RemoveAt(0)
            End If
            Chart_Pressure.ChartAreas(0).AxisY.Maximum = 400
        Next
        Chart_Pressure.ChartAreas(0).AxisY.Maximum = 400

    End Sub
    Private Sub Button_ScanPort_Click(sender As Object, e As EventArgs) Handles Button_ScanPort.Click
        'ScanPort gombhoz tartozó parancsok.


        'Beolvassa az elérhető portokat amin kerszetül tud az Arduinoval kommunikálni. 
        CB_ScanPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        CB_ScanPort.Items.AddRange(myPort)
        i = CB_ScanPort.Items.Count
        i = i - i
        Try
            CB_ScanPort.SelectedIndex = i
            Button_Start_Recording.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            CB_ScanPort.Text = ""
            CB_ScanPort.Items.Clear()
            Button_Start_Recording.Enabled = False
            Button_Start_Recording.Enabled = False
            Return
        End Try
        CB_ScanPort.DroppedDown = True

    End Sub

    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        'Connect gombhoz tartozó parancsok. 

        SerialPort1.BaudRate = ComboBox_BaudRate.SelectedItem
        SerialPort1.PortName = CB_ScanPort.SelectedItem
        SerialPort1.Open() 'A kiválasztott COM port és BaudRate melletti soros porttal a kommunkációt megnyitja
        TimerSerial.Start() 'Elkezdi mérni az időt. 

        CB_ScanPort.Enabled = False
        Label_BaudRate.Enabled = False
        ComboBox_BaudRate.Enabled = False
        Button_ScanPort.Enabled = False
        Button_Connect.Enabled = False
        Button_Disconnect.Enabled = True
        Button_Start_Recording.Enabled = True

        PictureBox_ConnectionInd.Image = My.Resources.green_button_cropped 'Ha létrejött a kapcsolat akkor a piros gombbol zöld lesz. 
        Label_Connection_Status.Text = "Status : Connected"
    End Sub

    Protected Sub Button_Disconnect_Click(sender As Object, e As EventArgs) Handles Button_Disconnect.Click
        'Disconnect gombhoz történő parancsok. 

        PictureBox_ConnectionInd.Image = My.Resources.red_button_cropped
        PictureBox_ConnectionInd.Visible = True
        Label_Connection_Status.Text = "Status : Disconnect"

        CB_ScanPort.Enabled = True
        Label_BaudRate.Enabled = True
        ComboBox_BaudRate.Enabled = True
        Button_ScanPort.Enabled = True
        Button_Connect.Enabled = True
        Button_Disconnect.Enabled = False

        TimerSerial.Stop()
        TimerDataLogRecord.Stop()

        Button_Stop_Recording.Enabled = False

        SerialPort1.Close()
    End Sub
    Private Sub Button_Start_Recording_Click(sender As Object, e As EventArgs) Handles Button_Start_Recording.Click

        Button_Start_Recording.Enabled = False
        Button_Stop_Recording.Enabled = True
        Button_Start_Recording.Enabled = True

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer = 0
        Dim j As Integer
        Dim DT As DateTime = Now
        Dim StrSerialIn As String = SerialPort1.ReadExisting
        Dim TB As New TextBox

        Dim T1_Log As String
        Dim p1_Log As String
        Dim bit1p_Log As String
        Dim bit1T_Log As String
        Dim U1T_Log As String
        Dim U1p_Log As String

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Munka1")

        xlApp.DisplayAlerts = False

 
        Dim savePath As String = Nothing
        Using sd As New SaveFileDialog
            With sd
                .RestoreDirectory = True
                .Filter = "Excel 97-2003-as munkafüzet(.xls)|*.xls| Excel munkafüzet(.xlsx)|*.xlsx| Makróbarát Excel-munkafüzet(*.xlsm)|*.xlsm"
                .FilterIndex = 2
                If .ShowDialog = DialogResult.OK Then
                    savePath = .FileName
                End If
            End With
        End Using

        TimerDataLogRecord.Start()
        For k As Integer = 1 To DataGridView1.Columns.Count
            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        Next


        While stopclick = False

            Application.DoEvents()
            'A T1 string fájlt a soros portról (pl.: T11200.92) 3. elemétől kezdve tárold egy string típusú változóba. (T1120.92 --> 120.92)

            T1_Log = (Mid(T1, 3, T1_L))
            p1_Log = (Mid(p1, 3, p1_L))
            bit1p_Log = (Mid(bit1p, 6, bit1p_L))
            bit1T_Log = (Mid(bit1T, 6, bit1T_L))
            U1T_Log = (Mid(U1T, 4, U1T_L))
            U1p_Log = (Mid(U1p, 4, U1p_L))

            DT = Now

            DataGridView1.Rows.Add(New String() {DT, T1_Log, p1_Log, bit1T_Log, bit1p_Log, U1T_Log, U1p_Log, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy")})
            Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1

            Chart_Temperature.Series("Temperature").Points.AddXY(DateTime.Now.ToLongTimeString, T1_Log)
            If Chart_Temperature.Series(0).Points.Count = Limit Then
                Chart_Temperature.Series(0).Points.RemoveAt(0)
            End If

            Chart_Pressure.Series("Pressure").Points.AddXY(DateTime.Now.ToLongTimeString, p1_Log)
            If Chart_Pressure.Series(0).Points.Count = Limit Then
                Chart_Pressure.Series(0).Points.RemoveAt(0)
            End If


            If PictureBox_RecordingInd.Visible = True Then
                PictureBox_RecordingInd.Visible = False
            ElseIf PictureBox_RecordingInd.Visible = False Then
                PictureBox_RecordingInd.Visible = True
            End If

            i = i + 1
            If i > 0 Then

                For j = 0 To DataGridView1.ColumnCount - 1
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i - 1).Value.ToString()
                Next

                xlWorkSheet.SaveAs(savePath)

            End If


            If stopclick Then
                stopclick = False
                Exit While
            End If

            Threading.Thread.Sleep(667)

        End While


        xlWorkBook.Close(savePath)
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)


        MsgBox("Successfully saved" & vbCrLf & "Files are saved at : " & savePath, MsgBoxStyle.Information, "Information")

        Process.Start(savePath)

    End Sub

    Private Sub Button_Stop_Recording_Click(sender As Object, e As EventArgs) Handles Button_Stop_Recording.Click

        Button_Start_Recording.Enabled = True
        Button_Stop_Recording.Enabled = False
        TimerDataLogRecord.Stop()
        PictureBox_RecordingInd.Visible = True
        stopclick = True

    End Sub
    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        'Clear gomhoz tartozó parancsok. Letisztítja a DataGridView elemeit.

        For i = 0 To 30 Step 1
            Chart_Temperature.Series("Temperature").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart_Temperature.Series(0).Points.Count = Limit Then
                Chart_Temperature.Series(0).Points.RemoveAt(0)
            End If
            Chart_Temperature.ChartAreas(0).AxisY.Maximum = 100
        Next

        For i = 0 To 30 Step 1
            Chart_Pressure.Series("Pressure").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart_Pressure.Series(0).Points.Count = Limit Then
                Chart_Pressure.Series(0).Points.RemoveAt(0)
            End If
            Chart_Pressure.ChartAreas(0).AxisY.Maximum = 100
        Next

        DataGridView1.Rows.Clear()

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        'ReleasObject sub még nincs használva --> majd az excelbe történő kiíráshoz kell majd. 

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TimerDataLogRecord_Tick(sender As Object, e As EventArgs) Handles TimerDataLogRecord.Tick

        ''Log változók deklarálása amibe a beolvasott számértékeket szövegként tárolja majd a progi. 

        'Dim T1_Log As String
        'Dim p1_Log As String
        'Dim bit1p_Log As String
        'Dim bit1T_Log As String
        'Dim U1T_Log As String
        'Dim U1p_Log As String

        'Dim DT As DateTime = Now


        ''A T1 string fájlt a soros portról (pl.: T11200.92) 3. elemétől kezdve tárold egy string típusú változóba. (T1120.92 --> 120.92)

        'T1_Log = (Mid(T1, 3, T1_L))
        'p1_Log = (Mid(p1, 3, p1_L))
        'bit1p_Log = (Mid(bit1p, 6, bit1p_L))
        'bit1T_Log = (Mid(bit1T, 6, bit1T_L))
        'U1T_Log = (Mid(U1T, 4, U1T_L))
        'U1p_Log = (Mid(U1p, 4, U1p_L))



        'DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, T1_Log, p1_Log, bit1T_Log, bit1p_Log, U1T_Log, U1p_Log, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy")})
        'Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1

        'Chart_Temperature.Series("Temperature").Points.AddXY(DateTime.Now.ToLongTimeString, T1_Log)
        'If Chart_Temperature.Series(0).Points.Count = Limit Then
        '    Chart_Temperature.Series(0).Points.RemoveAt(0)
        'End If

        'Chart_Pressure.Series("Pressure").Points.AddXY(DateTime.Now.ToLongTimeString, p1_Log)
        'If Chart_Pressure.Series(0).Points.Count = Limit Then
        '    Chart_Pressure.Series(0).Points.RemoveAt(0)
        'End If


        'If PictureBox_RecordingInd.Visible = True Then
        '    PictureBox_RecordingInd.Visible = False
        'ElseIf PictureBox_RecordingInd.Visible = False Then
        '    PictureBox_RecordingInd.Visible = True
        'End If
    End Sub

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        'A soros port-ról beérkező adatokat feldolgozza és kiiratja az Incoming Data felületre. 

        Try
            Dim StrSerialIn As String = SerialPort1.ReadExisting
            Dim StrSerialInRam As String

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            'A soros port nulladik során ha látja a T1 címkét, akkor a T1 változóban tárolja a soros port 0. sorát stringként (pl.: T1120.90) felveszi, és a T1_L változóban rögzíti a T1 hosszát is. 
            StrSerialInRam = TB.Lines(0).Substring(0, 2) 'Ez csak annyit ad meg, hogy a string 0. elemétől egy 2 hosszú stringrészletet olvasson be és annak az egyezését vizsgálja.
            If StrSerialInRam = "T1" Then
                T1 = TB.Lines(0)
                T1_L = T1.Length
            Else
                T1 = T1
            End If

            'A többi ugyanaz
            StrSerialInRam = TB.Lines(1).Substring(0, 2)
            If StrSerialInRam = "p1" Then
                p1 = TB.Lines(1)
                p1_L = p1.Length
            Else
                p1 = p1
            End If

            StrSerialInRam = TB.Lines(2).Substring(0, 3)
            If StrSerialInRam = "U1T" Then
                U1T = TB.Lines(2)
                U1T_L = U1T.Length
            Else
                U1T = U1T
            End If

            StrSerialInRam = TB.Lines(3).Substring(0, 3)
            If StrSerialInRam = "U1p" Then
                U1p = TB.Lines(3)
                U1p_L = U1p.Length
            Else
                U1p = U1p
            End If

            StrSerialInRam = TB.Lines(4).Substring(0, 5)
            If StrSerialInRam = "bit1T" Then
                bit1T = TB.Lines(4)
                bit1T_L = bit1T.Length
            Else
                bit1T = bit1T
            End If

            StrSerialInRam = TB.Lines(5).Substring(0, 5)
            If StrSerialInRam = "bit1p" Then

                bit1p = TB.Lines(5)
                bit1p_L = bit1p.Length
            Else
                bit1p = bit1p
            End If


            If PictureBox_ConnectionInd.Visible = True Then
                PictureBox_ConnectionInd.Visible = False
            ElseIf PictureBox_ConnectionInd.Visible = False Then
                PictureBox_ConnectionInd.Visible = True
            End If


            Label_TemperatureIncoming.Text = Mid(T1, 3, T1_L) & "°C" 'T1 string típusú változót a harmadik elemétől kezdve tárolja egy T1_L típusú integer változóban, amit aztán irasson ki az Incoming Data helyére + mértékegység
            Label_PressureIncoming.Text = Mid(p1, 3, p1_L) & "bar" 'Ugyanaz
            Label_BitsInc_T.Text = Mid(bit1T, 6, bit1T_L) & "/1023"
            Label_BitsInc_p.Text = Mid(bit1p, 6, bit1p_L) & "/1023"
            Label_VoltageInc_T.Text = Mid(U1T, 4, U1T_L) & "V"
            LabelVoltageInc_p.Text = Mid(U1p, 4, U1p_L) & "V"

        Catch ex As Exception

        End Try
    End Sub

End Class


