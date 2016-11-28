namespace SampleMvvm1.ViewModel
{
    public class SubAppDataService : ISubAppDataService
    {
        public bool IsVideoAvailable()
        {
            return true;
        }

        public bool IsHighlightsAvailable()
        {
            return true;
        }

        public bool IsContinuousImpedanceAvailable()
        {
            return false;
        }
    }
}