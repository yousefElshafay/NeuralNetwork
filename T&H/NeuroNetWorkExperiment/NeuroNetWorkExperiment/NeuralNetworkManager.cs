using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetWorkExperiment
{
    class NeuralNetworkManager
    {
        int Id;
        List<NetWorkLayer> NeuralNetwork;
        List<RegularNeuron> LayerNeurons;
        NetWorkLayer newLayer;
        RegularNeuron regularNeuron;
        int NeuronsID;// for debuginng purpose 

        int NewLayernum ;

        public NeuralNetworkManager()
        {
            NeuralNetwork = new List<NetWorkLayer>();
        }

        public void addLayerToEndOfNetWork()// for now we can only add a layer at the end of this neural network 
        {
             NewLayernum=   NeuralNetwork.Count;
              newLayer = new NetWorkLayer(LayerNeurons, NewLayernum);
             NeuralNetwork.Add(newLayer);
        }
        // we should have a method that can add a layer in the beginning or in between the neural network 

        public List<NetWorkLayer> GetNetWorkLayers()
        {

            return NeuralNetwork;
        }

        public void CreateNetWork(int NumberOfLayer , int NumberOfNeuronsPerlayer) // takes number of layer and how many neurons perlayer 
        {
            for (int i = 0; i < NumberOfLayer; i++)// loops to create the layers
            {

                LayerNeurons = new List<RegularNeuron>();
                newLayer = new NetWorkLayer(  LayerNeurons, i);// creates a layer

                for (int J = 0; J < NumberOfNeuronsPerlayer; J++)// loop to create the number of neuron for the newly created layer 
                {
                    regularNeuron = new RegularNeuron();
                    regularNeuron.Id = NeuronsID++;
                    newLayer.AddNeuronToLayer(regularNeuron);             
                }
                
                NeuralNetwork.Add(newLayer);
            }

            //now we will connect the  neurons from each layer to the neuron in the next layer 
            Random rand = new Random();//we will use a random number to give unique weights 
            int temp1;
            int temp2;

            for (int i = 0; i < NeuralNetwork.Count - 1; i++)
            {
                temp1 = i;
                temp2 = i + 1;
                foreach (RegularNeuron Neuron in NeuralNetwork[temp1].GetLayerNeuron())
                {
                    // Neuron.Id = rand.Next(0, 100);            
                    foreach (RegularNeuron NeuronTObeConnectedWith in NeuralNetwork[temp2].GetLayerNeuron())// for now we will standradize the connection weight to be 0.5 
                    {
                        //NeuronTObeConnectedWith.Id = NeuronsID++;
                        Neuron.AddNeuron(NeuronTObeConnectedWith, (rand.Next(0, 100) / 10));// this connection weight is hard coded for now 
                    }                    
                }

                //for testing 

                foreach (RegularNeuron Neuron in NeuralNetwork[i].GetLayerNeuron())
                {
                    Neuron.Fire();
                }

                //foreach (RegularNeuron Neuron in NeuralNetwork[1].GetLayerNeuron())
                //{
                //    Neuron.Fire();
                //}
                //foreach (RegularNeuron Neuron in NeuralNetwork[2].GetLayerNeuron())
                //{
                //    Neuron.Fire();
                //}    
            }
        }
        public int GetNumberOfLayers()
        {
            return NeuralNetwork.Count;
        }
    }
}
