using GalaSoft.MvvmLight;

namespace SampleMvvm1.ViewModel
{
    public abstract class SubAppVm : ViewModelBase
    {
        private MenuVm _menuVm;
        protected ISubAppDataService DataService;

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
                }

                return _menuVm;
            }
            set
            {
                _menuVm = value;
                RaisePropertyChanged();
            }
        }

        public abstract void InitializeMenu();
    }
}