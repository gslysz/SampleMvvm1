using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public class RecordingMenuVm : MenuVm
    {
        private bool _isContinuousImpedanceAvailable;

        public RecordingMenuVm(ISubAppDataService dataService) : base(dataService)
        {

            ShowContinuousImpedanceCommand = new RelayCommand(ShowContinuousImpedance);

        }

        private void ShowContinuousImpedance()
        {
            var handler = ContinuousImpedanceEventHandler;

            if (handler != null)
            {
                handler(this,new ContinuousImpedanceMessage());
            }
        }


        public bool IsContinuousImpedanceAvailable
        {
            get { return _isContinuousImpedanceAvailable; }
            set
            {
                _isContinuousImpedanceAvailable = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ShowContinuousImpedanceCommand { get; set; }

        protected override void Initialize()
        {
            throw new NotImplementedException();
        }


        public EventHandler<ContinuousImpedanceMessage> ContinuousImpedanceEventHandler;
    }
}