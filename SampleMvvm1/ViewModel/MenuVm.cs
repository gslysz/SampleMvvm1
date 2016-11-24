using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public abstract class MenuVm:ViewModelBase
    {
        private ISubAppDataService _dataService;
        private bool _isVideoAvailable;

        protected MenuVm(ISubAppDataService dataService)
        {
            _dataService = dataService;
            ShowVideoCommand = new RelayCommand(ShowVideo);
            
        }
        
        protected abstract void Initialize();


        public bool IsVideoAvailable
        {
            get { return _isVideoAvailable; }
            set
            {
                _isVideoAvailable = value;
                RaisePropertyChanged();
            }
        }

        private void ShowVideo()
        {
             
        }


        public ICommand ShowVideoCommand { get; set; }


    }
}