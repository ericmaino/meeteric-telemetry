using MeetEric.Telemetry.Contracts;

namespace MeetEric.Telemetry
{
    public static class TelemetryFactory
    {
        private static readonly ITelemetryClient _noOpClient;
        private static ITelemetryFactory _factory;

        static TelemetryFactory()
        {
            _noOpClient = new NoOpTelemetryClient();
        }

        public static ITelemetryClient Create(ITelemetryContext context = null)
        {
            ITelemetryClient client = _factory?.Create(context);

            if (client == null)
            {
                client = _noOpClient;
            }

            return client;
        }

        public static void RegisterFactory(ITelemetryFactory factory)
        {
            _factory = factory;
        }
    }
}
