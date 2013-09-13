using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_9;
using System.Diagnostics;
namespace CustomException
{
    public class IsCarDeadException:Exception
    {
        public IsCarDeadException(string message):base(message)
        {
            Console.Write(message);   
        }
        public static void LogException(string ErrorDescription)
        {
            // The name of our log in the event logs
            string Log = "AspNetError";
 
            // Check to see if the log for AspNetError exists on the machine
            //          If not, create it
            if ((!(EventLog.SourceExists(Log))))
            {
               EventLog.CreateEventSource(Log, Log);
            }
 
            // Now insert our customized exception information into the AspNetError event log
            EventLog logEntry = new EventLog();
            logEntry.Source = Log;
            logEntry.WriteEntry(ErrorDescription, EventLogEntryType.Error);
}
    }
}