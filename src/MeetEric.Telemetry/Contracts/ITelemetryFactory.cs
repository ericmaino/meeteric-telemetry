namespace MeetEric.Telemetry.Contracts
{
    public interface ITelemetryFactory
    {
        ITelemetryClient Create(ITelemetryContext context);
    }
}
