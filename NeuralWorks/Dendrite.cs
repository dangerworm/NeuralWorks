using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NeuralWorks
{
    class Dendrite
    {
        public Color Colour { get; set; }
        public Neuron InputNeuron { get; set; }
        public double Weight { get; set; }

        public Dendrite(Color colour, Neuron input, double weight)
        {
            this.Colour = colour;
            this.InputNeuron = input;
            this.Weight = weight;
        }
    }
}
