using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetWorkExperiment
{
    class BiasNeuron : Neuron, IObserver,INeuron
    {
        const double outputVal = 1.0;
        double connectionWeight;
       // Dictionary<IObserver, double> OutPutNeuron;

        public BiasNeuron()
        {  
            OutPutNeuron = new Dictionary<IObserver, double>();
        }
        
        public void update(double InputVal, double ConnectionWeight)//inputVal will be ignored since this is a biasNeuron
        {
            this.connectionWeight = ConnectionWeight;
        }

        //public void AddNeuron(IObserver newNeuron, double ConnectionWeight)
        //{
        //    OutPutNeuron.Add(newNeuron, ConnectionWeight);
        //}

        //public void RemoveNeuron(IObserver SelectedNeuron)
        //{
        //    OutPutNeuron.Remove(SelectedNeuron);
        //}

        public override void Fire()
        {
            foreach (KeyValuePair<IObserver, double> Neuron in OutPutNeuron)
            {
                Neuron.Key.update(outputVal, Neuron.Value);// this 0.1 should be the result of the sigmoid function 
                Console.WriteLine(Neuron.Key.ToString() + " bias neuron key //" + Neuron.Value.ToString());// for debugging purpose  
            }
        }
    }
}
