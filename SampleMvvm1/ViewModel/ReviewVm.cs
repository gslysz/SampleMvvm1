using System;
using System.Windows;

namespace SampleMvvm1.ViewModel
{
    public class ReviewVm : SubAppVm
    {
        public ReviewVm(ISubAppDataService dataService) : base(dataService)
        {
            Title = "Review";
        }


        public override void InitializeMenu()
        {
            var reviewMenuVm = new ReviewMenuVm(DataService);
            reviewMenuVm.ShowHighlightsEventHandler+= ShowHighlightsEventHandler;
            reviewMenuVm.ShowVideoEventHandler += ShowVideoEventHandler;

            MenuVm = reviewMenuVm;
        }

        private void ShowHighlightsEventHandler(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("Show hightlights window!!");
        }

        private void ShowVideoEventHandler(object sender, VideoMessage e)
        {
            MessageBox.Show("This is the review Video window!!");
        }
    }
}