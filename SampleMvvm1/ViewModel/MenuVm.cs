using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public abstract class MenuVm : ViewModelBase
    {
        private ISubAppDataService _dataService;
        private bool _isVideoAvailable;

        protected MenuVm(ISubAppDataService dataService)
        {
            _dataService = dataService;
            ShowVideoCommand = new RelayCommand(ShowVideo);
        }


        public bool IsVideoAvailable
        {
            get { return _isVideoAvailable; }
            set
            {
                _isVideoAvailable = value;
                RaisePropertyChanged();
            }
        }


        public ICommand ShowVideoCommand { get; set; }

        protected abstract void Initialize();

        private void ShowVideo()
        {
        }
    }
}