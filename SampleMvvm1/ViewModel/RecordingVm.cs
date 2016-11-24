using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvm1.ViewModel
{
    public class RecordingVm:SubAppVm
    {
        public override void InitializeMenu()
        {
            MenuVm = new RecordingMenuVm(DataService);
        }

        public RecordingVm(ISubAppDataService dataService) : base(dataService)
        {
        }
    }
}
