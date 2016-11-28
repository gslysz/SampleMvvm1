using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public class HyperVentilationControlVm : ViewModelBase
    {
        private bool _isAvailable;
        private bool _isHyperventilationStarted;
        private bool _isPostHyperventilationStarted;
        private bool _isStopped;


        public HyperVentilationControlVm()
        {
            DoNextHyperventilationActionCommand = new RelayCommand(DoNextHyperventilationAction);
        }

        public bool IsHyperventilationStarted
        {
            get { return _isHyperventilationStarted; }
            set
            {
                _isHyperventilationStarted = value;
                RaisePropertyChanged();
            }
        }


        public ICommand DoNextHyperventilationActionCommand { get; set; }


        public bool IsPostHyperventilationStarted
        {
            get { return _isPostHyperventilationStarted; }
            set
            {
                _isPostHyperventilationStarted = value;
                RaisePropertyChanged();
            }
        }


        public bool IsStopped
        {
            get { return _isStopped; }
            set
            {
                _isStopped = value;
                RaisePropertyChanged();
            }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set
            {
                _isAvailable = value;
                RaisePropertyChanged();
            }
        }

        private void DoNextHyperventilationAction()
        {
            var isStopped = !IsHyperventilationStarted && !IsPostHyperventilationStarted;
            if (isStopped)
            {
                IsHyperventilationStarted = true;
            }
            else
            {
                if (IsHyperventilationStarted)
                {
                    IsHyperventilationStarted = false;
                    IsPostHyperventilationStarted = true;
                }
                else
                {
                    IsPostHyperventilationStarted = false;
                }
            }
        }
    }
}