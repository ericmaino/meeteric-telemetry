using System;
using System.Collections.Generic;
using MeetEric.Telemetry.Contracts;

namespace MeetEric.Telemetry
{
    class NoOpTelemetryClient : ITelemetryClient
    {
        public void TrackDependency(string dependencyName, string commandName, DateTimeOffset startTime, TimeSpan duration, bool success, IDictionary<string, string> metadata = null)
        {

        }

        public void TrackEvent(string eventName, IDictionary<string, string> metadata = null, IDictionary<string, double> metrics = null)
        {

        }

        public void TrackException(Exception ex, IDictionary<string, string> metadata = null, IDictionary<string, double> metrics = null)
        {

        }

        public void TrackMetric(string metricName, double value, IDictionary<string, string> metadata = null)
        {

        }
    }
}
