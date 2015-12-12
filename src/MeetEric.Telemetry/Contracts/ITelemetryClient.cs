using System;
using System.Collections.Generic;

namespace MeetEric.Telemetry.Contracts
{
    public interface ITelemetryClient
    {
        void TrackException(Exception ex, IDictionary<string, string> metadata = null, IDictionary<string, double> metrics = null);
        void TrackEvent(string eventName, IDictionary<string, string> metadata = null, IDictionary<string, double> metrics = null);
        void TrackMetric(string metricName, double value, IDictionary<string, string> metadata = null);
        void TrackDependency(string dependencyName, string commandName, DateTimeOffset startTime, TimeSpan duration, bool success, IDictionary<string, string> metadata = null);
    }
}
