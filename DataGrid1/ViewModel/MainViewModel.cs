using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace DataGrid1.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Records=new ObservableCollection<EegRecord>();

            Records.Add(new EegRecord
            {
                StartTime = new DateTime(2014,01,05,11,4,4),
                EndTime = new DateTime(2015,1,1,4,5,3),
                IsSelected = true,
                PatientFirstName = "H",
                PatientLastName = "Hoojigotadudu"

            });

            Records.Add(new EegRecord
            {
                StartTime = new DateTime(2015, 01, 05, 11, 4, 4),
                EndTime = new DateTime(2016, 1, 1, 4, 5, 3),
                IsSelected = false,
                PatientFirstName = "D",
                PatientLastName = "Dingly"

            });

            Records.Add(new EegRecord
            {
                StartTime = new DateTime(2015, 01, 05, 11, 4, 4),
                EndTime = new DateTime(2016, 1, 1, 4, 5, 3),
                IsSelected = true,
                PatientFirstName = "D",
                PatientLastName = "Dingly"

            });



        }


        public ObservableCollection<EegRecord> Records { get; set; }
    }
}