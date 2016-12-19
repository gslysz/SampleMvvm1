using System;
using System.Windows;
using System.Windows.Controls;

namespace SampleMvvm1.ViewModel
{
    public sealed class ReviewVm : SubAppVm
    {
        public ReviewVm(ISubAppDataService dataService) : base(dataService)
        {
            Title = "Review";
        }


        public override void InitializeMenu()
        {
            var reviewMenuVm = new ReviewMenuVm(DataService);
            reviewMenuVm.ShowHighlightsEventHandler += ShowHighlightsEventHandler;
            reviewMenuVm.ShowVideoEventHandler += ShowVideoEventHandler;


            MenuVm = reviewMenuVm;
        }

        private void ShowHighlightsEventHandler(object sender, EventArgs eventArgs)
        {
            var hightlightsTool = new HighlightsToolItemViewModel {DefaultDock = Dock.Bottom};
            ToolItems.Add(hightlightsTool);
        }

        private void ShowVideoEventHandler(object sender, VideoMessage e)
        {
            
            var reviewVideoTool = new ReviewVideoToolItemViewModel
            {
                Name = "ReviewVideo",
                DefaultDock = Dock.Right,
            };

            ToolItems.Add(reviewVideoTool);
        }
    }
}