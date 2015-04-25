using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuralWorks
{
    public partial class NeuralWorks : Form
    {
        public NeuralWorks()
        {
            InitializeComponent();
        }

        private Bitmap NetworkImage;
        private Graphics NetworkGraphics;
        private Network Net;

        private int mouseX;
        private int mouseY;

        private void NeuralWorks_Load(object sender, EventArgs e)
        {
            Net = new Network();
            NetworkImage = new Bitmap(imgNetwork.Width, imgNetwork.Height);
            imgNetwork.Image = NetworkImage;
            NetworkGraphics = Graphics.FromImage(imgNetwork.Image);

            Input_KeyDown(Input, new KeyEventArgs(Keys.Enter));
            Hidden_KeyDown(Hidden, new KeyEventArgs(Keys.Enter));
            Output_KeyDown(Output, new KeyEventArgs(Keys.Enter));
        }

        private void RefreshLists(object sender)
        {
            if (sender.Equals(Input))
            {
                InputNodes.Items.Clear();
                for (int i = 0; i < GetValue(sender); i++)
                    InputNodes.Items.Add("Input " + (i + 1).ToString());
            }
            
            if (sender.Equals(Output))
            {
                OutputNodes.Items.Clear();
                for (int i = 0; i < GetValue(sender); i++)
                    OutputNodes.Items.Add("Output " + (i + 1).ToString());
            }
        }

        private void DrawNeurons()
        {
            NetworkImage = new Bitmap(imgNetwork.Width, imgNetwork.Height);
            imgNetwork.Image = NetworkImage;
            NetworkGraphics = Graphics.FromImage(imgNetwork.Image);

            int radius = 10;
            int step = radius * 4;

            for (int i = 0; i <= Net.NumLayers; i++)
            {
                int j = 1;
                foreach (Neuron n in Net.Neurons.Where(n => n.layerNum == i))
                {
                    n.x = (n.layerNum + 1) * (imgNetwork.Width / 4);
                    n.x -= ((imgNetwork.Width / 2) - n.x) / 2 + radius;
                    n.y = j * (imgNetwork.Height / (Net.Neurons.Where(nn => nn.layerNum == n.layerNum).Count() + 1)) - radius;
                    j++;
                }
            }
            
            NetworkGraphics.Clear(Color.Transparent);

            foreach (Neuron n in Net.Neurons)
                foreach (Dendrite d in n.Input)
                    NetworkGraphics.DrawLine(new Pen(d.Colour, (float)d.Weight),
                                             d.InputNeuron.x + radius,
                                             d.InputNeuron.y + radius,
                                             n.x + radius,
                                             n.y + radius);

            foreach (Neuron n in Net.Neurons)
                NetworkGraphics.FillEllipse(new SolidBrush(n.Colour), n.x, n.y, 2 * n.radius, 2 * n.radius);

            imgNetwork.Image = NetworkImage;
        }

        private void SelectNumber(object sender)
        {
            ((TextBoxBase)sender).SelectionStart = 0;
            ((TextBoxBase)sender).SelectionLength = ((TextBoxBase)sender).Text.Substring(0, ((TextBoxBase)sender).Text.IndexOf(" neurons")).Length;
        }

        private void ChangeValue(object sender, KeyEventArgs e)
        {
            int value = GetValue(sender);

            if (e.KeyCode.Equals(Keys.Up))
            {
                value++;
                ((TextBoxBase)sender).Text = value.ToString() + " neurons";
            }
            else if (e.KeyCode.Equals(Keys.Down))
            {
                value--;
                ((TextBoxBase)sender).Text = value.ToString() + " neurons";
            }

            Application.DoEvents();
        }

        private int GetValue(object sender)
        {
            try
            {
                return Int32.Parse(((TextBoxBase)sender).Text.Substring(0, ((TextBoxBase)sender).Text.IndexOf(" neurons")));
            }
            catch { return -1; }
        }

        private void NeuralWorks_SizeChanged(object sender, EventArgs e)
        {
            InputNodes.Height = OutputNodes.Height = Height - (38 + 15 + 25);
            OutputNodes.Left = Width - (OutputNodes.Width + 15);

            imgNetwork.Height = Height - (38 + 15 + 25);
            imgNetwork.Width = Width - InputNodes.Width - OutputNodes.Width - (4 * 15);

            DrawNeurons();
        }

        private void Input_Click(object sender, EventArgs e)
        {
            SelectNumber(sender);
        }


        private void Input_Enter(object sender, EventArgs e)
        {
            SelectNumber(sender);
        }
        
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeValue(sender, e);

            if (e.KeyData == Keys.Enter)
            {
                RefreshLists(sender);
                Net.GenerateNeurons(Network.Layer.Input, 0, GetValue(sender));
                DrawNeurons();
            }
        }
        
        private void Hidden_Click(object sender, EventArgs e)
        {
            SelectNumber(sender);
        }

        private void Hidden_Enter(object sender, EventArgs e)
        {
            SelectNumber(sender);
        }

        private void Hidden_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeValue(sender, e);

            if (e.KeyData == Keys.Enter)
            {
                Net.GenerateNeurons(Network.Layer.Hidden, 1, GetValue(sender));
                DrawNeurons();
            }
        }

        private void Output_Click(object sender, EventArgs e)
        {
            SelectNumber(sender);
        }
        
        private void Output_Enter(object sender, EventArgs e)
        {
            SelectNumber(sender);
        }

        private void OutputNodes_DoubleClick(object sender, EventArgs e)
        {
            ValuePrompt.SetBounds(mouseX, mouseY, Width - ValuePrompt.Location.X - 20, ValuePrompt.Height);
            ValuePrompt.Visible = true;
        }

        private void Output_KeyDown(object sender, KeyEventArgs e)
        {
            ChangeValue(sender, e);

            if (e.KeyData == Keys.Enter)
            {
                RefreshLists(sender);
                Net.GenerateNeurons(Network.Layer.Output, 2, GetValue(sender));
                DrawNeurons();
            }
        }

        private void OutputNodes_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = OutputNodes.Location.X + e.X;
            mouseY = OutputNodes.Location.Y + e.Y;
        }

        private void ValuePrompt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
                ValuePrompt.Visible = false;
        }
    }
}
