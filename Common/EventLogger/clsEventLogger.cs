using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class clsEventLogger
    {
        public static void Event_Logger(EventLogEntryType EventLogType, string Msg, string LogName)
        {
            // Specify the source name for the event log
            string SourceName = "Bank System";

            // Create the event source if it does not exist
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, LogName);
            }


            // Log an information event
            EventLog.WriteEntry(SourceName, Msg, EventLogType);
        }

    }

}
