using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetWorkExperiment
{
    class Neuron : INeuron  // each neuron regards of its type has a list of neurons it connect to and a set of weights for that connection 
    {
        protected  Dictionary<IObserver, double> OutPutNeuron;

        public void AddNeuron(IObserver newNeuron, double ConnectionWeight) 
        {
            OutPutNeuron.Add(newNeuron, ConnectionWeight);
        }


        public void RemoveNeuron(IObserver SelectedNeuron)
        {
            OutPutNeuron.Remove(SelectedNeuron);
        }


       virtual public void Fire()
        {
            // this method will be overridden by each individual neuron 
        }
    }
}
