using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public abstract class MenuVm : ViewModelBase
    {
        private bool _isVideoAvailable;
        protected ISubAppDataService DataService;

        public EventHandler<VideoMessage> ShowVideoEventHandler;

        protected MenuVm(ISubAppDataService dataService)
        {
            DataService = dataService;

            InitializeCommonMenu();

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

        private void InitializeCommonMenu()
        {
            IsVideoAvailable = DataService.IsVideoAvailable();
        }

        protected abstract void Initialize();


        private void ShowVideo()
        {
            var handler = ShowVideoEventHandler;
            if (handler != null)
            {
                handler(this, new VideoMessage());
            }
        }
    }
}