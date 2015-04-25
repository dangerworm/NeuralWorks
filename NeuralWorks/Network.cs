using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NeuralWorks
{
    class Network
    {
        public List<Neuron> Neurons;
        public enum Layer
        {
            Input = 0,
            Output = 1,
            Hidden = 2
        };
        public int NumLayers;
        
        private int NodeRadius;

        public Network()
        {
            Neurons = new List<Neuron>();
            NodeRadius = 8;
            NumLayers = 3;
        }

        public Network(int nodeRadius)
        {
            Neurons = new List<Neuron>();
            NodeRadius = nodeRadius;
            NumLayers = 3;
        }

        public Network(int nodeRadius, int numLayers)
        {
            Neurons = new List<Neuron>();
            NodeRadius = nodeRadius;
            NumLayers = numLayers;
        }

        public void GenerateNeurons(Layer layerType, int layerNum, int desiredNeurons)
        {
            Color connectionColour = Color.Gray;
            Color nodeColour = Color.Gray;

            if (layerType == Layer.Input)
            {
                nodeColour = Color.Red;
                layerNum = 0;
            }
            else if (layerType == Layer.Hidden)
            {
                connectionColour = Color.PaleGreen;
                nodeColour = Color.Green;
                layerNum = 1;
            }
            else if (layerType == Layer.Output)
            {
                connectionColour = Color.SkyBlue;
                nodeColour = Color.Blue;
                layerNum = 2;
            }

            List<Neuron> tmpNeurons = Neurons.ToList();
            int currentNeurons = tmpNeurons.Where(n => n.layerNum == layerNum).Count();

            foreach (Neuron n in Neurons)
                if (n.layerNum > NumLayers)
                    NumLayers = n.layerNum;

            Random rand = new Random();
            if (currentNeurons > desiredNeurons)
            {
                // Crop neurons
                int neuronsRemoved = 0;
                tmpNeurons.Reverse();

                foreach (Neuron n in tmpNeurons)
                    if (n.layerNum == layerNum && neuronsRemoved < currentNeurons - desiredNeurons)
                    {
                        Neurons.Remove(n);
                        foreach (Neuron nn in Neurons)
                        {
                            List<Dendrite> tmpInput = nn.Input.ToList();
                            foreach (Dendrite d in tmpInput)
                                if (d.InputNeuron.Equals(n))
                                    nn.Input.Remove(d);
                        }

                        neuronsRemoved++;
                    }
            }
            else if (currentNeurons < desiredNeurons)
            {
                // Add neurons
                for (int i = currentNeurons; i < desiredNeurons; i++)
                {
                    Neuron n;
                    if (layerNum == 0)
                        n = new Neuron(nodeColour, layerType, layerNum, NodeRadius, 1.5);
                    else
                        n = new Neuron(nodeColour, connectionColour, layerType, layerNum, NodeRadius, 1.5);

                    if (layerNum > 0)
                        foreach (Neuron nn in Neurons.Where(neuron => neuron.layerNum == layerNum - 1))
                            n.Input.Add(new Dendrite(n.ConnectionColour, nn, (NodeRadius / 2) * rand.NextDouble()));
                    Neurons.Add(n);

                    if (layerNum < NumLayers)
                        foreach (Neuron nn in Neurons.Where(neuron => neuron.layerNum == layerNum + 1))
                            nn.Input.Add(new Dendrite(nn.ConnectionColour, n, (NodeRadius / 2) * rand.NextDouble()));
                }
            }
        }
    }
}
