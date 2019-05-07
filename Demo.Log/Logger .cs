using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Log
{
    public class Logger 
    {
        private TelemetryClient _appInsightsClient;

        public Logger()
        {
            _appInsightsClient = new TelemetryClient();
            _appInsightsClient.InstrumentationKey = "134e3f7f-b853-4764-a21c-f961f612b539";
        }

        public void Info(string message)
        {
            var properties = new Dictionary<string, string> { { "message", message } };
            _appInsightsClient.TrackEvent("Info", properties);
        }

        public void Warn(string message)
        {
            var properties = new Dictionary<string, string> { { "message", message } };
            _appInsightsClient.TrackEvent("Warn", properties);
        }

        public void Debug(string message)
        {
            var properties = new Dictionary<string, string> { { "message", message } };
            _appInsightsClient.TrackEvent("Debug", properties);
        }

        public void Error(string message, Exception ex)
        {
            var properties = new Dictionary<string, string> { { "message", message } };
            _appInsightsClient.TrackException(ex, properties);
        }

        public void Error(string message)
        {
            var properties = new Dictionary<string, string> { { "message", message } };
            Exception ex = new Exception(message);
            _appInsightsClient.TrackException(ex, properties);
        }

        public void Error(Exception ex)
        {
            _appInsightsClient.TrackException(ex);
        }
    }
}
