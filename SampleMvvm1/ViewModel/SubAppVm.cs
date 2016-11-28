using System;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace SampleMvvm1.ViewModel
{
    public abstract class SubAppVm : ViewModelBase
    {
        private MenuVm _menuVm;
        protected ISubAppDataService DataService;
        private string _title;

        public SubAppVm(ISubAppDataService dataService)
        {
            DataService = dataService;

            
        }
        
        public MenuVm MenuVm
        {
            get
            {
                if (_menuVm == null)
                {
                    InitializeMenu();
                    HookUpCommonEventHandlers();
                }

                return _menuVm;
            }
            set
            {
                _menuVm = value;
                RaisePropertyChanged();
            }
        }

        public string Title
        {
            get { return _title; }
            protected set
            {
                _title = value; 
                RaisePropertyChanged();
            }
        }

        private void HookUpCommonEventHandlers()
        {
            
        }
        


        public abstract void InitializeMenu();
    }
}