using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NeuroNetWorkExperiment
{
    class RegularNeuron : Neuron, INeuron ,IObserver
    {
       // List<double>  ListOfInputWeights;// weights that come from neuron that connect to this current neuron 
       // List<double> ListOfOutPutWeights;//this is the list of the weight this neuron has with other neuron 
        double OutputSignal;// weight from the the current to the the neurons its connect to 
        double netInputSignal; // the input number that consist of  each neuron input val  * its weight all together that connect to this current neuron 
        //List<IObserver> OutPutNeuron;
       public int Id; // for debugging purpose 

       //Dictionary<IObserver, double> OutPutNeuron;
        public RegularNeuron()
        {
            //intialize neuron 
            OutPutNeuron = new   Dictionary<IObserver,double>();
            netInputSignal = 0;          
        }


        public void SigmoidFunc(double netinputSignal)// for now this neuron would have a sigmoid function rather than a threshold func
        {
            OutputSignal= (1 / (1 + Math.Exp(netinputSignal)));
        }


        //public void AddNeuron(IObserver newNeuron,double ConnectionWeight)
        //{
        //    OutPutNeuron.Add(newNeuron, ConnectionWeight);
        //}

        //public void RemoveNeuron(IObserver SelectedNeuron)
        //{
        //    OutPutNeuron.Remove(SelectedNeuron);
        //}


        public override void Fire()
        {
            //we call the sigmoid function when firing the neuron 
            SigmoidFunc(netInputSignal);
            
            foreach (KeyValuePair<IObserver,double> Neuron in OutPutNeuron)
            {
                Neuron.Key.update(OutputSignal,Neuron.Value );// this 0.1 should be the result of the sigmoid function 
                // we need to cast the key , value to the Regular neuroclass
                Console.WriteLine("neuron id " + Id.ToString() + " with input signal  " + ((RegularNeuron)Neuron.Key).netInputSignal.ToString() + "and  value of  :  " + Neuron.Value.ToString() + " is connecting to  neuron id " + ((RegularNeuron)Neuron.Key).Id.ToString());// for debugging purpose  
            }
            //  netInputSignal = 0.0;//reset neuron netinputSignal 
           // OutPutNeuron.Clear();
        }

        public void update(double InputVal, double ConnectionWeight)
        {
            netInputSignal += InputVal * ConnectionWeight;
        }
        
    }
}
