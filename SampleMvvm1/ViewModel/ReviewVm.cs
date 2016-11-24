namespace SampleMvvm1.ViewModel
{
    public class ReviewVm : SubAppVm
    {
        public ReviewVm(ISubAppDataService dataService) : base(dataService)
        {
        }


        public override void InitializeMenu()
        {
            MenuVm = new ReviewMenuVm(DataService);
        }
    }
}