using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetWorkExperiment
{
    class NetWorkLayer // a network layer is just a holder for a set of neurons and a biasNeuron 
    {
       public int LayerNumber=0 ;// layer number 
        int NumberOfneuronsInlayer = 0 ; // the number of neuron that are in this layer
        BiasNeuron biasNeuron;// the layer bias neuron 

        List<RegularNeuron> layerNeurons ;
        public NetWorkLayer(List<RegularNeuron> LayerNeurons , int layernum)
        {
            layerNeurons = LayerNeurons;
            LayerNumber = layernum;
            biasNeuron = new BiasNeuron();
        }

        

        public void AddNeuronToLayer(RegularNeuron NextNeuron)
        {
            layerNeurons.Add(NextNeuron);
        
        }
        public void RemoveNeuronfromLayer(RegularNeuron SelectedNeuron)
        {
            layerNeurons.Remove(SelectedNeuron);
        
        }


        public int  GetLayerSizeInNeurons()
        {
            NumberOfneuronsInlayer = layerNeurons.Count;
            return NumberOfneuronsInlayer;
                                
        }
        public List<RegularNeuron> GetLayerNeuron()
        {
            return layerNeurons;
        }
        
    }
}
