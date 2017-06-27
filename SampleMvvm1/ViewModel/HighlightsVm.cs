using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace SampleMvvm1.ViewModel
{
    public class HighlightsVm:ViewModelBase
    {
        private DateTime _startTime;
        private string _highlightsText;


        public DateTime StartTime
        {
            get { return _startTime; }
            set
            {
                _startTime = value;
                RaisePropertyChanged();
            }
        }

        public string HighlightsText
        {
            get { return _highlightsText; }
            set
            {
                _highlightsText = value;
                RaisePropertyChanged();
            }
        }
    }
}
