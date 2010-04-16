using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Timers;

namespace library_dll.Entities
{
    public class utility : Equipment
    {

        public static bool DeleteFile(string fileToDelete)
        {
            try
            {
                if (File.Exists("logfile.txt"))
                {
                    File.Delete("logfile.txt");
                    return true;
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                // Log the exception
                utility.LogFile(ex.ToString());
                return false;
            }
        }

        public static void LogFile(string strLogText)
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

        public static void Timer(int TimeToWait)
        {
            //5000 would be 5 seconds
            Timer myTimer = new Timer(TimeToWait);
            myTimer.Elapsed += new ElapsedEventHandler(ElapsedEvent);
            myTimer.Enabled = true;            

        }

        public static void ElapsedEvent(object source, ElapsedEventArgs e)
        {
            utility.LogFile("Hello World!");
        }

    }
}

    