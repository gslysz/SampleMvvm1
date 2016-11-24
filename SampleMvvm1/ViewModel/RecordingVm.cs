namespace SampleMvvm1.ViewModel
{
    public class RecordingVm : SubAppVm
    {
        public RecordingVm(ISubAppDataService dataService) : base(dataService)
        {
        }

        public override void InitializeMenu()
        {
            MenuVm = new RecordingMenuVm(DataService);
        }
    }
}