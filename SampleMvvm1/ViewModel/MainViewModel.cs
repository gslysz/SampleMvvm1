using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace SampleMvvm1.ViewModel
{
    /// <summary>
    ///     This class contains properties that the main View can data bind to.
    ///     <para>
    ///         Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    ///     </para>
    ///     <para>
    ///         You can also use Blend to data bind with the tool's support.
    ///     </para>
    ///     <para>
    ///         See http://www.galasoft.ch/mvvm
    ///     </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<SubAppVm> _subAppViewModels;

        /// <summary>
        ///     Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            ISubAppDataService dataService = new SubAppDataService();
            SubAppViewModels = new ObservableCollection<SubAppVm> {new ReviewVm(dataService), new RecordingVm(dataService) };


            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }


        public ObservableCollection<SubAppVm> SubAppViewModels
        {
            get { return _subAppViewModels; }
            set
            {
                _subAppViewModels = value; 
                RaisePropertyChanged();
            }
        }
    }
}