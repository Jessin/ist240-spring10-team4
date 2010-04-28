using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;
using System.Xml.Serialization;
using System.Xml;
using HUD;
namespace library_dll.Entities
{



    public class utility 
    {
        static String filename;
        public static int MonErrorCode;
        public static int DirectCode;

       
        public static int Weather;

        public static String Filename
        {
            get { return utility.filename; }
            set { utility.filename = value; }
        }
       

        public static void LogFile()
        {
            try
            {
                library_dll.Entities.TestingSystem TSX = new library_dll.Entities.TestingSystem();
                XmlReader reader = new XmlTextReader("../../../../CarTestingInfo.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(library_dll.Entities.TestingSystem));
                TSX = (library_dll.Entities.TestingSystem)serializer.Deserialize(reader);
                HUD.DisplayHUD.CarHud.Light = TSX.Light;
                 Weather = Convert.ToInt16(TSX.WeatherCode);
                 HUD.DisplayHUD.CarErrorCode = Convert.ToInt16(TSX. ErrorCode);
                 MonErrorCode = Convert.ToInt16(TSX.ErrorCode);
                 DirectCode = Convert.ToInt16(TSX.DirectionCode);
                
                HUD.DisplayHUD.trafficcode = Convert.ToInt16(TSX.TrafficCode);
                reader.Close();



            }
            catch (FileNotFoundException ex)
            {
                Console.Out.WriteLine("File Not found" + ex);
            }
            //utility.DeleteFile();


        }

        public static void Timer(int TimeToWait)
        {
            //5000 would be 5 seconds
            Timer myTimer = new Timer(TimeToWait);
            myTimer.Elapsed += new ElapsedEventHandler(ElapsedEvent);
            myTimer.Enabled = true;

            
       

        }

        public static void ElapsedEvent(object source, ElapsedEventArgs e)
        {

            utility.LogFile();
            //HUD.Program.targetreader();
 
        }

        public static int RandomNumber(int min, int max)
        {
            //Random(seed) uses the DateTime ticks to make it unique
            Random random = new Random((int)DateTime.Now.Ticks);
            return random.Next(min, max);
        }

        public static bool NumberRangeValidator(int min, int max, string strNumberToCheck)
        {
            try
            {
                int numberEntered = int.Parse(strNumberToCheck);
                if (numberEntered < min || numberEntered > max)
                    return true;
            }
            catch (FormatException)
            {
                return true;
            }
            return false;

        }
        public static void DeleteFile()
        {
            try
            {
                if (File.Exists("CarTestingInfo.xml"))
                {
                    File.Delete("CarTestingInfo.xml");
                    
                }
                else
                    utility.Loger("File not found");

                    
            }
            catch (Exception ex)
            {
                // Log the exception
                utility.Loger(ex.ToString());
                
            }
        
        }

        public static void Loger(string strLogText)
        {
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }

            // Write to the file:
            log.WriteLine(DateTime.Now);
            log.WriteLine(strLogText);
            log.WriteLine();

            // Close the stream:
            log.Close();

        }


    }
}


    