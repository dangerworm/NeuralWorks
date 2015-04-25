namespace NeuralWorks
{
    partial class NeuralWorks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Hidden = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.ValuePrompt = new System.Windows.Forms.TextBox();
            this.grpNeuronCount = new System.Windows.Forms.GroupBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.grpNetwork = new System.Windows.Forms.GroupBox();
            this.OutputNodes = new System.Windows.Forms.ListBox();
            this.imgNetwork = new System.Windows.Forms.PictureBox();
            this.InputNodes = new System.Windows.Forms.ListBox();
            this.grpNeuronCount.SuspendLayout();
            this.grpNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNetwork)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(75, 19);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(48, 20);
            this.Input.TabIndex = 3;
            this.Input.Text = "3";
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_KeyDown);
            // 
            // Hidden
            // 
            this.Hidden.Location = new System.Drawing.Point(208, 19);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(48, 20);
            this.Hidden.TabIndex = 4;
            this.Hidden.Text = "4";
            this.Hidden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_KeyDown);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(339, 19);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(48, 20);
            this.Output.TabIndex = 5;
            this.Output.Text = "3";
            this.Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Count_KeyDown);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Location = new System.Drawing.Point(129, 22);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(73, 13);
            this.lblHidden.TabIndex = 7;
            this.lblHidden.Text = "Hidden Layer:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(262, 22);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output Layer:";
            // 
            // ValuePrompt
            // 
            this.ValuePrompt.Location = new System.Drawing.Point(457, 265);
            this.ValuePrompt.Name = "ValuePrompt";
            this.ValuePrompt.Size = new System.Drawing.Size(120, 20);
            this.ValuePrompt.TabIndex = 9;
            this.ValuePrompt.Visible = false;
            this.ValuePrompt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValuePrompt_KeyUp);
            // 
            // grpNeuronCount
            // 
            this.grpNeuronCount.Controls.Add(this.lblInput);
            this.grpNeuronCount.Controls.Add(this.Input);
            this.grpNeuronCount.Controls.Add(this.Output);
            this.grpNeuronCount.Controls.Add(this.lblOutput);
            this.grpNeuronCount.Controls.Add(this.lblHidden);
            this.grpNeuronCount.Controls.Add(this.Hidden);
            this.grpNeuronCount.Location = new System.Drawing.Point(12, 12);
            this.grpNeuronCount.Name = "grpNeuronCount";
            this.grpNeuronCount.Size = new System.Drawing.Size(398, 51);
            this.grpNeuronCount.TabIndex = 10;
            this.grpNeuronCount.TabStop = false;
            this.grpNeuronCount.Text = "Neuron Count";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(6, 22);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(63, 13);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "Input Layer:";
            // 
            // grpNetwork
            // 
            this.grpNetwork.Controls.Add(this.OutputNodes);
            this.grpNetwork.Controls.Add(this.imgNetwork);
            this.grpNetwork.Controls.Add(this.ValuePrompt);
            this.grpNetwork.Controls.Add(this.InputNodes);
            this.grpNetwork.Location = new System.Drawing.Point(12, 69);
            this.grpNetwork.Name = "grpNetwork";
            this.grpNetwork.Size = new System.Drawing.Size(568, 276);
            this.grpNetwork.TabIndex = 11;
            this.grpNetwork.TabStop = false;
            this.grpNetwork.Text = "Network";
            // 
            // OutputNodes
            // 
            this.OutputNodes.FormattingEnabled = true;
            this.OutputNodes.Location = new System.Drawing.Point(442, 19);
            this.OutputNodes.Name = "OutputNodes";
            this.OutputNodes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.OutputNodes.Size = new System.Drawing.Size(120, 251);
            this.OutputNodes.TabIndex = 4;
            // 
            // imgNetwork
            // 
            this.imgNetwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgNetwork.Location = new System.Drawing.Point(132, 19);
            this.imgNetwork.Name = "imgNetwork";
            this.imgNetwork.Size = new System.Drawing.Size(304, 251);
            this.imgNetwork.TabIndex = 3;
            this.imgNetwork.TabStop = false;
            // 
            // InputNodes
            // 
            this.InputNodes.FormattingEnabled = true;
            this.InputNodes.Location = new System.Drawing.Point(6, 19);
            this.InputNodes.Name = "InputNodes";
            this.InputNodes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.InputNodes.Size = new System.Drawing.Size(120, 251);
            this.InputNodes.TabIndex = 2;
            // 
            // NeuralWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 355);
            this.Controls.Add(this.grpNetwork);
            this.Controls.Add(this.grpNeuronCount);
            this.Name = "NeuralWorks";
            this.Text = "NeuralWorks";
            this.Load += new System.EventHandler(this.NeuralWorks_Load);
            this.SizeChanged += new System.EventHandler(this.NeuralWorks_SizeChanged);
            this.grpNeuronCount.ResumeLayout(false);
            this.grpNeuronCount.PerformLayout();
            this.grpNetwork.ResumeLayout(false);
            this.grpNetwork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgNetwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Hidden;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox ValuePrompt;
        private System.Windows.Forms.GroupBox grpNeuronCount;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.GroupBox grpNetwork;
        private System.Windows.Forms.ListBox OutputNodes;
        private System.Windows.Forms.PictureBox imgNetwork;
        private System.Windows.Forms.ListBox InputNodes;
    }
}

