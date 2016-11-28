using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public sealed class ReviewMenuVm : MenuVm
    {
        private bool _isHighlightsAvailable;


        public EventHandler ShowHighlightsEventHandler;

        public ReviewMenuVm(ISubAppDataService dataService) : base(dataService)
        {
            ShowHighlightsCommand = new RelayCommand(ShowHighlights);
            Initialize();
        }


        public bool IsHighlightsAvailable
        {
            get { return _isHighlightsAvailable; }
            set
            {
                _isHighlightsAvailable = value;
                RaisePropertyChanged();
            }
        }


        public ICommand ShowHighlightsCommand { get; set; }

        private void ShowHighlights()
        {
            var handler = ShowHighlightsEventHandler;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }


        protected override void Initialize()
        {
            IsHighlightsAvailable = DataService.IsHighlightsAvailable();
        }
    }
}