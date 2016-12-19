using System.Windows;
using System.Windows.Controls;

namespace SampleMvvm1.ViewModel
{
    public sealed class RecordingVm : SubAppVm
    {
        public RecordingVm(ISubAppDataService dataService) : base(dataService)
        {
            Title = "Recording";
            InitializeMenu();
        }

        public override void InitializeMenu()
        {
            var recordingMenuVm = new RecordingMenuVm(DataService);
            recordingMenuVm.ContinuousImpedanceEventHandler += ContinuousImpedanceEventHandler;
            recordingMenuVm.ShowVideoEventHandler += ShowVideoEventHandler;

            MenuVm = recordingMenuVm;
        }

        private void ShowVideoEventHandler(object sender, VideoMessage videoMessage)
        {
            var hightlightsTool = new LiveVideoToolItemViewModel { DefaultDock = Dock.Bottom, IsInitiallyHidden = true, DockGroup = "Group1"};
            ToolItems.Add(hightlightsTool);
        }

        private void ContinuousImpedanceEventHandler(object sender,
            ContinuousImpedanceMessage continuousImpedanceMessage)
        {
            var hightlightsTool = new ContinuousImpedanceToolItemViewModel { DefaultDock = Dock.Bottom, DockGroup = "Group1"};
            ToolItems.Add(hightlightsTool);
        }
    }
}