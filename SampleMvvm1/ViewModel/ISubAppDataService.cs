namespace SampleMvvm1.ViewModel
{
    public interface ISubAppDataService
    {
        bool IsVideoAvailable();
        bool IsHighlightsAvailable();
        bool IsContinuousImpedanceAvailable();
    }
}