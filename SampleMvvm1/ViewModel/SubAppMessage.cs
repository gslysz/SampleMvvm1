using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace SampleMvvm1.ViewModel
{
    public class SubAppMessage:MessageBase
    {
    }

    public class VideoMessage : SubAppMessage
    {
    }

    public class ContinuousImpedanceMessage : SubAppMessage
    {
    }
}
