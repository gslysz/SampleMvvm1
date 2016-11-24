using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvm1.ViewModel
{
    public class RecordingMenuVm : MenuVm
    {
        public RecordingMenuVm(ISubAppDataService dataService) : base(dataService)
        {   
        }
    }
}
