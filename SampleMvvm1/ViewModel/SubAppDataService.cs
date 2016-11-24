using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvm1.ViewModel
{
    public class SubAppDataService: ISubAppDataService
    {
        public bool IsVideoAvailable()
        {
            return true;
        }
    }
}
