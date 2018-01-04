using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetWorkExperiment
{
    interface IObserver
    {
        void update(double InputVal, double ConnectionWeight);
    }
}
