namespace InnerNet
{
    public enum ReportOutcome : int
    {
        NotReportedUnknown = 0,
        NotReportedNoAccount = 1,
        NotReportedNotFound = 2,
        NotReportedRateLimit = 3,
        Reported = 4,
    }
}
