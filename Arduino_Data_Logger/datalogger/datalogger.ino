
float const aVCC = 3.346;                                                 // Az AVCC pin-en mért feszültség. Az Arduino az 3.3 V-os tápfeszültséget használja referenciának a mérések során. (Névleges érték = 3,3 V, Valódi érték 3,292 V)
                                                                    
                                        
const int AnalogInPin_T1 = A0;                                            // A0 analóg pinről olvassa be az 1. reaktor hőmérséklet távadójának értékét.
int SensorValue_T1[10];                                                   // A távadóró beolvasott hőmérsékletértéket tárolja már digitális formában (0-1023).
float Temperature_1;                                                      // Kalibráció szerinti hőmérséklet adatot tárolja.
float Voltage_T1;                                                         // A hőmérséklet távadón eső feszültséget tároló változó.
int AvarageBits_T1;                                                       // 10 mintázás eredményének értékét tartalmazó változó (digitális érték).

const int AnalogInPin_p1 = A1;                                            // ugyanez csak az 1. reaktor nyomás távadójára.
int SensorValue_p1[10];                                                
float Pressure_1;                                                       
float Voltage_p1;
int AvarageBits_p1;


void setup ()
  {
    Serial.begin(9600);                                                   // Soros kommunikáció megnyitása.  
  }


void loop()
  {
    analogReference(EXTERNAL);                                            // Az ADC referencia a lap 3.3 V-os tápfeszültséget használja referenciának a feszültségméréshez. --> ehhez az kell, hogy a a 3.3V pin össze legyen kötve az AREF pin-nel.
                                                                          // NAGYON FONTOS! Az analogReference() parancs semmiképpen sem lehet default beállításon, mert akkor megsüti az Arduino-t.
    burn8readings(A0);                                                      // Az Analóg/Digitál konverter nem lehet folyamatosan bekapcsolva, mert akkor nagyon sok hő diszcipálódik rajta --> Tűzveszélyes és a változó ellenállások miatt a mérést is meghamisítja.
                                                                          // Az fejlesztőkörnyezetbe táplált analogRead() parancsot miután végrehajtotta a board, az ADC-t kikapcsolja. Az újabb mérés során való bekapcsolásakkor, azonban magának az ADC-nek a bekapcsolása viszonylag nagy zajforrás lehet.
                                                                          // Emiatt nagyon fontos, hogy pár "vakmintát" csináltassunk az Arduinoval, hogy amely mintázásoknak viszonylag nagy lesz a zajtartalma. Azt javasolták, hogy ez kb. 4-5 mérés. Én azért ráküldtem nyolcat. Ezen már ne múljon...

    for(int i = 0; i < 10; i++)                                           // 10-szer egymás után mintázza az egyes analóg bemeneteket, amiket 10-10 tagú tömbökben tárol el. 
    {
      SensorValue_T1[i] = analogRead(AnalogInPin_T1);
      SensorValue_p1[i] = analogRead(AnalogInPin_p1);
    }
   
    AvarageBits_T1 = Avarage_Bits(SensorValue_T1, 10);                    // A tíz beolvasott digitális mérést átlagolja (jobb jel-zaj viszony), amely értékekből számoljuk majd ki a hőmérséklet és nyomás értékeket a kalibrációs egyenes segítségével.
    AvarageBits_p1 = Avarage_Bits(SensorValue_p1, 10);
    
    Temperature_1 = 0.1648 * AvarageBits_T1 - 65,198;                     // Kalibrációs egyenesek. !!!444!!! A végső vezetékelés kialaításánál a vezetékek hossza és minősége (lásd ellenállása) elméletileg megváltoztathatja a kalibrációs egyenes metszetét. 
    Pressure_1 = 0.3418 * AvarageBits_p1 - 74,013;                        // A minél pontosabb értékek elérésének érdekében a kalibrációt érdemes a végső kialakításnál elvégezni.
    
    Voltage_T1 = (((float)AvarageBits_T1)/(1023)) * aVCC;                        // Feszültség értékek számolt értéke a felhasznált referencia pontos értékének ismeretében. 
    Voltage_p1 = ((float)(AvarageBits_p1)/(1023)) * aVCC;

    Serial.print("T1");Serial.println(Temperature_1 , 2);
    Serial.print("p1");Serial.println(Pressure_1 , 2);
    Serial.print("U1T");Serial.println(Voltage_T1 , 2);
    Serial.print("U1p");Serial.println(Voltage_p1 , 2);
    Serial.print("bit1T");Serial.println(AvarageBits_T1);
    Serial.print("bit1p");Serial.println(AvarageBits_p1);    
    delay (1000);                                                         // 1 másodpercet vár minden mérés között
  } 


float Avarage_Bits (int * array, int len)                                 // bit-ek átlagát kiszámoló függvény.
{
  long sum = 0L ;  
  for (int i = 0 ; i < len ; i++)
    sum += array [i] ;
  return  ((float) sum) / len ;
}

int burn8readings(const int CurrentAnalogPin)                                                       // 8 vakmérést végző függvény.
{
  int TemporaryRead[8];

  for(int i = 0; i < 8; i++)
  {
    TemporaryRead[i] = analogRead(CurrentAnalogPin);
  }  
  memset(TemporaryRead, 0, 8);
}
                                             
