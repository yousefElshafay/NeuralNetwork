using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetWorkExperiment
{
    interface INeuron
    {
        void AddNeuron(IObserver newNeuron,double connectionweight);// the attach  method 
        void RemoveNeuron(IObserver SelectedNeuron);// the dettach  method
        void Fire();// fire the next set of neurons
    }
}
