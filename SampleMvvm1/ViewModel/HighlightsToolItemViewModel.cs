using System;

namespace SampleMvvm1.ViewModel
{
    public class HighlightsToolItemViewModel : ToolItemViewModel
    {
        private HighlightsVm _highlightsVm;

        public HighlightsToolItemViewModel()
        {
            Name = "Highlights";

            HighlightsVm = new HighlightsVm
            {
                HighlightsText = "Highlight1",
                StartTime = DateTime.Now
            };
        }


        public HighlightsVm HighlightsVm
        {
            get { return _highlightsVm; }
            set
            {
                _highlightsVm = value;
                RaisePropertyChanged();
            }
        }
    }
}