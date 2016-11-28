using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;

namespace SampleMvvm1.ViewModel
{
    public class ReviewMenuVm : MenuVm
    {
        public ReviewMenuVm(ISubAppDataService dataService) : base(dataService)
        {

           ShowHighlightsCommand = new RelayCommand(ShowHighlights);
        }

        private void ShowHighlights()
        {
            var handler = ShowHighlightsEventHandler;
            if (handler != null)
            {
                handler(this,new EventArgs());
            }
        }


        public ICommand ShowHighlightsCommand { get; set; }


        protected override void Initialize()
        {
            throw new System.NotImplementedException();
        }


        public EventHandler ShowHighlightsEventHandler;

    }
}