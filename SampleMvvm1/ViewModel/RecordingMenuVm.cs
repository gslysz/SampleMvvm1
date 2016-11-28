using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public sealed class RecordingMenuVm : MenuVm
    {
        private bool _isContinuousImpedanceAvailable;


        public EventHandler<ContinuousImpedanceMessage> ContinuousImpedanceEventHandler;

        public RecordingMenuVm(ISubAppDataService dataService) : base(dataService)
        {
            ShowContinuousImpedanceCommand = new RelayCommand(ShowContinuousImpedance);

            DoHyperventilationCommand = new RelayCommand(DoHyperVentilation);


            Initialize();
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

        public ICommand DoHyperventilationCommand { get; set; }

        private void DoHyperVentilation()
        {
        }


        private void ShowContinuousImpedance()
        {
            var handler = ContinuousImpedanceEventHandler;

            if (handler != null)
            {
                handler(this, new ContinuousImpedanceMessage());
            }
        }

        protected override void Initialize()
        {
            IsContinuousImpedanceAvailable = DataService.IsContinuousImpedanceAvailable();
        }
    }
}