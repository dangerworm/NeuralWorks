using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NeuralWorks
{
    class Neuron
    {
        public List<Dendrite> Input;
        public Color Colour { get; set; }
        public Color ConnectionColour { get; set; }
        public Network.Layer layerType { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int layerNum { get; set; }
        public int radius { get; set; }
        public double threshold { get; set; }

        public Neuron(Network.Layer layerType, int layerNum)
        {
            this.Input = new List<Dendrite>();
            this.Colour = Color.Gray;
            this.ConnectionColour = Color.Gray;
            this.x = 5;
            this.y = 5;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = 10;
        }

        public Neuron(int x, int y, Network.Layer layerType, int layerNum)
        {
            this.Input = new List<Dendrite>();
            this.Colour = Color.Gray;
            this.ConnectionColour = Color.Gray;
            this.x = x;
            this.y = y;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = 10;
        }

        public Neuron(int x, int y, Network.Layer layerType, int layerNum, int radius)
        {
            this.Input = new List<Dendrite>();
            this.Colour = Color.Gray;
            this.ConnectionColour = Color.Gray;
            this.x = x;
            this.y = y;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = radius;
        }

        public Neuron(int x, int y, Network.Layer layerType, int layerNum, int radius, double threshold)
        {
            this.Input = new List<Dendrite>();
            this.Colour = Color.Gray;
            this.ConnectionColour = Color.Gray;
            this.x = x;
            this.y = y;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = radius;
            this.threshold = threshold;
        }

        public Neuron(Color colour, Network.Layer layerType, int layerNum, int radius, double threshold)
        {
            this.Input = new List<Dendrite>();
            this.Colour = colour;
            this.ConnectionColour = Color.Gray;
            this.x = x;
            this.y = y;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = radius;
            this.threshold = threshold;
        }

        public Neuron(Color colour, int x, int y, Network.Layer layerType, int layerNum, int radius, double threshold)
        {
            this.Input = new List<Dendrite>();
            this.Colour = colour;
            this.ConnectionColour = Color.Gray;
            this.x = x;
            this.y = y;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = radius;
            this.threshold = threshold;
        }

        public Neuron(Color colour, Color connectionColour, Network.Layer layerType, int layerNum, int radius, double threshold)
        {
            this.Input = new List<Dendrite>();
            this.Colour = colour;
            this.ConnectionColour = connectionColour;
            this.x = 0;
            this.y = 0;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = radius;
            this.threshold = threshold;
        }

        public Neuron(Color colour, Color connectionColour, int x, int y, Network.Layer layerType, int layerNum, int radius, double threshold)
        {
            this.Input = new List<Dendrite>();
            this.Colour = colour;
            this.ConnectionColour = connectionColour;
            this.x = x;
            this.y = y;
            this.layerNum = layerNum;
            this.layerType = layerType;
            this.radius = radius;
            this.threshold = threshold;
        }
    }
}
