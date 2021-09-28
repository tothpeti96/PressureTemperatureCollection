<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox_ConnectionInd = New System.Windows.Forms.PictureBox()
        Me.Label_Connection_Status = New System.Windows.Forms.Label()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.ComboBox_BaudRate = New System.Windows.Forms.ComboBox()
        Me.Label_BaudRate = New System.Windows.Forms.Label()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.CB_ScanPort = New System.Windows.Forms.ComboBox()
        Me.Button_ScanPort = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox_RecordingInd = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Stop_Recording = New System.Windows.Forms.Button()
        Me.Button_Start_Recording = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelVoltageInc_p = New System.Windows.Forms.Label()
        Me.Label_VoltageInc_T = New System.Windows.Forms.Label()
        Me.Label_BitsInc_p = New System.Windows.Forms.Label()
        Me.Label_BitsInc_T = New System.Windows.Forms.Label()
        Me.Label_PressureIncoming = New System.Windows.Forms.Label()
        Me.Label_TemperatureIncoming = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temperature = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Pressure = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_bitT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_bits_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_VoltageT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Voltage_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Chart_Temperature = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart_Pressure = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox_ConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox_RecordingInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Chart_Temperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart_Pressure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox_ConnectionInd)
        Me.GroupBox1.Controls.Add(Me.Label_Connection_Status)
        Me.GroupBox1.Controls.Add(Me.Button_Disconnect)
        Me.GroupBox1.Controls.Add(Me.ComboBox_BaudRate)
        Me.GroupBox1.Controls.Add(Me.Label_BaudRate)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.CB_ScanPort)
        Me.GroupBox1.Controls.Add(Me.Button_ScanPort)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'PictureBox_ConnectionInd
        '
        Me.PictureBox_ConnectionInd.Image = Global.DataRecorder_new.My.Resources.Resources.red_button_cropped
        Me.PictureBox_ConnectionInd.Location = New System.Drawing.Point(435, 2)
        Me.PictureBox_ConnectionInd.Name = "PictureBox_ConnectionInd"
        Me.PictureBox_ConnectionInd.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox_ConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_ConnectionInd.TabIndex = 1
        Me.PictureBox_ConnectionInd.TabStop = False
        '
        'Label_Connection_Status
        '
        Me.Label_Connection_Status.AutoSize = True
        Me.Label_Connection_Status.Location = New System.Drawing.Point(287, 0)
        Me.Label_Connection_Status.Name = "Label_Connection_Status"
        Me.Label_Connection_Status.Size = New System.Drawing.Size(142, 17)
        Me.Label_Connection_Status.TabIndex = 1
        Me.Label_Connection_Status.Text = "Status: Disconnected"
        '
        'Button_Disconnect
        '
        Me.Button_Disconnect.Location = New System.Drawing.Point(290, 58)
        Me.Button_Disconnect.Name = "Button_Disconnect"
        Me.Button_Disconnect.Size = New System.Drawing.Size(244, 40)
        Me.Button_Disconnect.TabIndex = 5
        Me.Button_Disconnect.Text = "Disconnect"
        Me.Button_Disconnect.UseVisualStyleBackColor = True
        '
        'ComboBox_BaudRate
        '
        Me.ComboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_BaudRate.FormattingEnabled = True
        Me.ComboBox_BaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBox_BaudRate.Location = New System.Drawing.Point(376, 24)
        Me.ComboBox_BaudRate.Name = "ComboBox_BaudRate"
        Me.ComboBox_BaudRate.Size = New System.Drawing.Size(157, 24)
        Me.ComboBox_BaudRate.TabIndex = 4
        '
        'Label_BaudRate
        '
        Me.Label_BaudRate.AutoSize = True
        Me.Label_BaudRate.Location = New System.Drawing.Point(287, 27)
        Me.Label_BaudRate.Name = "Label_BaudRate"
        Me.Label_BaudRate.Size = New System.Drawing.Size(83, 17)
        Me.Label_BaudRate.TabIndex = 3
        Me.Label_BaudRate.Text = "Baud Rate :"
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(7, 58)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(246, 40)
        Me.Button_Connect.TabIndex = 2
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'CB_ScanPort
        '
        Me.CB_ScanPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ScanPort.FormattingEnabled = True
        Me.CB_ScanPort.Location = New System.Drawing.Point(132, 24)
        Me.CB_ScanPort.Name = "CB_ScanPort"
        Me.CB_ScanPort.Size = New System.Drawing.Size(121, 24)
        Me.CB_ScanPort.TabIndex = 1
        '
        'Button_ScanPort
        '
        Me.Button_ScanPort.Location = New System.Drawing.Point(7, 18)
        Me.Button_ScanPort.Name = "Button_ScanPort"
        Me.Button_ScanPort.Size = New System.Drawing.Size(119, 34)
        Me.Button_ScanPort.TabIndex = 0
        Me.Button_ScanPort.Text = "Scan Port"
        Me.Button_ScanPort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox_RecordingInd)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button_Clear)
        Me.GroupBox2.Controls.Add(Me.Button_Stop_Recording)
        Me.GroupBox2.Controls.Add(Me.Button_Start_Recording)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 119)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Controll"
        '
        'PictureBox_RecordingInd
        '
        Me.PictureBox_RecordingInd.Image = Global.DataRecorder_new.My.Resources.Resources.red_button_cropped1
        Me.PictureBox_RecordingInd.Location = New System.Drawing.Point(371, 1)
        Me.PictureBox_RecordingInd.Name = "PictureBox_RecordingInd"
        Me.PictureBox_RecordingInd.Size = New System.Drawing.Size(13, 13)
        Me.PictureBox_RecordingInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_RecordingInd.TabIndex = 4
        Me.PictureBox_RecordingInd.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Recording :"
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(7, 67)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(526, 44)
        Me.Button_Clear.TabIndex = 2
        Me.Button_Clear.Text = "Clear Graph"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Stop_Recording
        '
        Me.Button_Stop_Recording.Location = New System.Drawing.Point(290, 21)
        Me.Button_Stop_Recording.Name = "Button_Stop_Recording"
        Me.Button_Stop_Recording.Size = New System.Drawing.Size(243, 40)
        Me.Button_Stop_Recording.TabIndex = 1
        Me.Button_Stop_Recording.Text = "Stop Recording"
        Me.Button_Stop_Recording.UseVisualStyleBackColor = True
        '
        'Button_Start_Recording
        '
        Me.Button_Start_Recording.Location = New System.Drawing.Point(7, 21)
        Me.Button_Start_Recording.Name = "Button_Start_Recording"
        Me.Button_Start_Recording.Size = New System.Drawing.Size(246, 40)
        Me.Button_Start_Recording.TabIndex = 0
        Me.Button_Start_Recording.Text = "Start Recording"
        Me.Button_Start_Recording.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelVoltageInc_p)
        Me.GroupBox3.Controls.Add(Me.Label_VoltageInc_T)
        Me.GroupBox3.Controls.Add(Me.Label_BitsInc_p)
        Me.GroupBox3.Controls.Add(Me.Label_BitsInc_T)
        Me.GroupBox3.Controls.Add(Me.Label_PressureIncoming)
        Me.GroupBox3.Controls.Add(Me.Label_TemperatureIncoming)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(561, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 230)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Incoming Data"
        '
        'LabelVoltageInc_p
        '
        Me.LabelVoltageInc_p.AutoSize = True
        Me.LabelVoltageInc_p.Location = New System.Drawing.Point(223, 186)
        Me.LabelVoltageInc_p.Name = "LabelVoltageInc_p"
        Me.LabelVoltageInc_p.Size = New System.Drawing.Size(67, 17)
        Me.LabelVoltageInc_p.TabIndex = 11
        Me.LabelVoltageInc_p.Text = "Waiting..."
        '
        'Label_VoltageInc_T
        '
        Me.Label_VoltageInc_T.AutoSize = True
        Me.Label_VoltageInc_T.Location = New System.Drawing.Point(99, 186)
        Me.Label_VoltageInc_T.Name = "Label_VoltageInc_T"
        Me.Label_VoltageInc_T.Size = New System.Drawing.Size(67, 17)
        Me.Label_VoltageInc_T.TabIndex = 10
        Me.Label_VoltageInc_T.Text = "Waiting..."
        '
        'Label_BitsInc_p
        '
        Me.Label_BitsInc_p.AutoSize = True
        Me.Label_BitsInc_p.Location = New System.Drawing.Point(223, 129)
        Me.Label_BitsInc_p.Name = "Label_BitsInc_p"
        Me.Label_BitsInc_p.Size = New System.Drawing.Size(67, 17)
        Me.Label_BitsInc_p.TabIndex = 9
        Me.Label_BitsInc_p.Text = "Waiting..."
        '
        'Label_BitsInc_T
        '
        Me.Label_BitsInc_T.AutoSize = True
        Me.Label_BitsInc_T.Location = New System.Drawing.Point(99, 129)
        Me.Label_BitsInc_T.Name = "Label_BitsInc_T"
        Me.Label_BitsInc_T.Size = New System.Drawing.Size(67, 17)
        Me.Label_BitsInc_T.TabIndex = 8
        Me.Label_BitsInc_T.Text = "Waiting..."
        '
        'Label_PressureIncoming
        '
        Me.Label_PressureIncoming.AutoSize = True
        Me.Label_PressureIncoming.Location = New System.Drawing.Point(223, 80)
        Me.Label_PressureIncoming.Name = "Label_PressureIncoming"
        Me.Label_PressureIncoming.Size = New System.Drawing.Size(67, 17)
        Me.Label_PressureIncoming.TabIndex = 3
        Me.Label_PressureIncoming.Text = "Waiting..."
        '
        'Label_TemperatureIncoming
        '
        Me.Label_TemperatureIncoming.AutoSize = True
        Me.Label_TemperatureIncoming.Location = New System.Drawing.Point(99, 80)
        Me.Label_TemperatureIncoming.Name = "Label_TemperatureIncoming"
        Me.Label_TemperatureIncoming.Size = New System.Drawing.Size(67, 17)
        Me.Label_TemperatureIncoming.TabIndex = 3
        Me.Label_TemperatureIncoming.Text = "Waiting..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Voltage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Bits"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pressure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Temperature"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Temperature, Me.Column_Pressure, Me.Column_bitT, Me.Column_bits_p, Me.Column_VoltageT, Me.Column_Voltage_p})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(880, 467)
        Me.DataGridView1.TabIndex = 3
        '
        'No
        '
        Me.No.HeaderText = "Date"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.Width = 125
        '
        'Temperature
        '
        Me.Temperature.HeaderText = "Temperature [°C]"
        Me.Temperature.MinimumWidth = 6
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Width = 125
        '
        'Column_Pressure
        '
        Me.Column_Pressure.HeaderText = "Pressure [bar]"
        Me.Column_Pressure.MinimumWidth = 6
        Me.Column_Pressure.Name = "Column_Pressure"
        Me.Column_Pressure.Width = 125
        '
        'Column_bitT
        '
        Me.Column_bitT.HeaderText = "bit_T [/1023]"
        Me.Column_bitT.MinimumWidth = 6
        Me.Column_bitT.Name = "Column_bitT"
        Me.Column_bitT.Width = 125
        '
        'Column_bits_p
        '
        Me.Column_bits_p.HeaderText = "bit_p [/1023]"
        Me.Column_bits_p.MinimumWidth = 6
        Me.Column_bits_p.Name = "Column_bits_p"
        Me.Column_bits_p.Width = 125
        '
        'Column_VoltageT
        '
        Me.Column_VoltageT.HeaderText = "Voltage T [V]"
        Me.Column_VoltageT.MinimumWidth = 6
        Me.Column_VoltageT.Name = "Column_VoltageT"
        Me.Column_VoltageT.Width = 125
        '
        'Column_Voltage_p
        '
        Me.Column_Voltage_p.HeaderText = "Voltage p [V]"
        Me.Column_Voltage_p.MinimumWidth = 6
        Me.Column_Voltage_p.Name = "Column_Voltage_p"
        Me.Column_Voltage_p.Width = 125
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 254)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(893, 495)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Grid View"
        '
        'Chart_Temperature
        '
        CustomLabel1.Text = "Time"
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel1)
        ChartArea1.AxisX.Title = "Time"
        ChartArea1.AxisY.Title = "Temperature [°C]"
        ChartArea1.Name = "ChartArea1"
        Me.Chart_Temperature.ChartAreas.Add(ChartArea1)
        Me.Chart_Temperature.Location = New System.Drawing.Point(915, 25)
        Me.Chart_Temperature.Name = "Chart_Temperature"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Red
        Series1.Name = "Temperature"
        Me.Chart_Temperature.Series.Add(Series1)
        Me.Chart_Temperature.Size = New System.Drawing.Size(462, 359)
        Me.Chart_Temperature.TabIndex = 4
        Me.Chart_Temperature.Text = "Chart1"
        '
        'Chart_Pressure
        '
        ChartArea2.AxisX.Title = "Time "
        ChartArea2.AxisY.Title = "Pressure [bar]"
        ChartArea2.Name = "ChartArea1"
        Me.Chart_Pressure.ChartAreas.Add(ChartArea2)
        Me.Chart_Pressure.Location = New System.Drawing.Point(915, 390)
        Me.Chart_Pressure.Name = "Chart_Pressure"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series2.Name = "Pressure"
        Me.Chart_Pressure.Series.Add(Series2)
        Me.Chart_Pressure.Size = New System.Drawing.Size(462, 359)
        Me.Chart_Pressure.TabIndex = 5
        Me.Chart_Pressure.Text = "Chart2"
        '
        'TimerSerial
        '
        '
        'TimerDataLogRecord
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 754)
        Me.Controls.Add(Me.Chart_Pressure)
        Me.Controls.Add(Me.Chart_Temperature)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox_ConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox_RecordingInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Chart_Temperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart_Pressure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox_ConnectionInd As PictureBox
    Friend WithEvents Label_Connection_Status As Label
    Friend WithEvents Button_Disconnect As Button
    Friend WithEvents ComboBox_BaudRate As ComboBox
    Friend WithEvents Label_BaudRate As Label
    Friend WithEvents Button_Connect As Button
    Friend WithEvents CB_ScanPort As ComboBox
    Friend WithEvents Button_ScanPort As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Stop_Recording As Button
    Friend WithEvents Button_Start_Recording As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LabelVoltageInc_p As Label
    Friend WithEvents Label_VoltageInc_T As Label
    Friend WithEvents Label_BitsInc_p As Label
    Friend WithEvents Label_BitsInc_T As Label
    Friend WithEvents Label_PressureIncoming As Label
    Friend WithEvents Label_TemperatureIncoming As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Chart_Temperature As DataVisualization.Charting.Chart
    Friend WithEvents Chart_Pressure As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox_RecordingInd As PictureBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TimerDataLogRecord As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Temperature As DataGridViewTextBoxColumn
    Friend WithEvents Column_Pressure As DataGridViewTextBoxColumn
    Friend WithEvents Column_bitT As DataGridViewTextBoxColumn
    Friend WithEvents Column_bits_p As DataGridViewTextBoxColumn
    Friend WithEvents Column_VoltageT As DataGridViewTextBoxColumn
    Friend WithEvents Column_Voltage_p As DataGridViewTextBoxColumn
End Class
