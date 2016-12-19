using System.Windows.Controls;
using GalaSoft.MvvmLight;

namespace SampleMvvm1.ViewModel
{
    public abstract class ToolItemViewModel:ViewModelBase
    {
        private Dock _defaultDock;
        private string _dockGroup;
        private bool _isInitiallyHidden;
        private string _name;

        public Dock DefaultDock 
        {
            get { return _defaultDock; }
            set
            {
                _defaultDock = value;
                RaisePropertyChanged();
            }
        }


        public string DockGroup
        {
            get { return _dockGroup; }
            set
            {
                _dockGroup = value;
                RaisePropertyChanged();
            }
        }


        public bool IsInitiallyHidden
        {
            get { return _isInitiallyHidden; }
            set
            {
                _isInitiallyHidden = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }
    }

    public class HighlightsToolItemViewModel : ToolItemViewModel
    {
        public HighlightsToolItemViewModel()
        {
            Name = "Highlights";
        }
    }
}