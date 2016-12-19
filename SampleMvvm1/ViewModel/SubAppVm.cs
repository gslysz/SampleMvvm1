using System.Collections.ObjectModel;
using ActiproSoftware.Windows;
using GalaSoft.MvvmLight;

namespace SampleMvvm1.ViewModel
{
    public abstract class SubAppVm : ViewModelBase
    {
        private MenuVm _menuVm;
        private string _title;
        protected ISubAppDataService DataService;


        public SubAppVm()
        {
            ToolItems = new DeferrableObservableCollection<ToolItemViewModel>();
        }

        public SubAppVm(ISubAppDataService dataService):this()
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

        public ObservableCollection<ToolItemViewModel> ToolItems { get; set; }

        private void HookUpCommonEventHandlers()
        {
        }


        public abstract void InitializeMenu();
    }
}