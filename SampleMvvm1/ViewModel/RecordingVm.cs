using System;
using System.Windows;

namespace SampleMvvm1.ViewModel
{
    public class RecordingVm : SubAppVm
    {
        public RecordingVm(ISubAppDataService dataService) : base(dataService)
        {
            Title = "Recording";
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
            MessageBox.Show("This is what happens when you click the Recording Video button");
        }

        private void ContinuousImpedanceEventHandler(object sender, ContinuousImpedanceMessage continuousImpedanceMessage)
        {
            MessageBox.Show("This is the continuous Impedance window!");
        }
    }
}