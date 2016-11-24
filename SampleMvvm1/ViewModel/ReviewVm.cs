using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMvvm1.ViewModel
{
    public class ReviewVm : SubAppVm
    {


        public override void InitializeMenu()
        {
            MenuVm = new ReviewMenuVm(DataService);

        }

        public ReviewVm(ISubAppDataService dataService) : base(dataService)
        {
        }
    }
}
