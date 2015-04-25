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
            this.imgNetwork = new System.Windows.Forms.PictureBox();
            this.InputNodes = new System.Windows.Forms.ListBox();
            this.OutputNodes = new System.Windows.Forms.ListBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Hidden = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.ValuePrompt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgNetwork)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNetwork
            // 
            this.imgNetwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgNetwork.Location = new System.Drawing.Point(138, 38);
            this.imgNetwork.Name = "imgNetwork";
            this.imgNetwork.Size = new System.Drawing.Size(316, 316);
            this.imgNetwork.TabIndex = 0;
            this.imgNetwork.TabStop = false;
            // 
            // InputNodes
            // 
            this.InputNodes.FormattingEnabled = true;
            this.InputNodes.Location = new System.Drawing.Point(15, 38);
            this.InputNodes.Name = "InputNodes";
            this.InputNodes.Size = new System.Drawing.Size(120, 316);
            this.InputNodes.TabIndex = 1;
            // 
            // OutputNodes
            // 
            this.OutputNodes.FormattingEnabled = true;
            this.OutputNodes.Location = new System.Drawing.Point(460, 38);
            this.OutputNodes.Name = "OutputNodes";
            this.OutputNodes.Size = new System.Drawing.Size(120, 316);
            this.OutputNodes.TabIndex = 2;
            this.OutputNodes.DoubleClick += new System.EventHandler(this.OutputNodes_DoubleClick);
            this.OutputNodes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OutputNodes_MouseMove);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(81, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(100, 20);
            this.Input.TabIndex = 3;
            this.Input.Text = "3 neurons";
            this.Input.Click += new System.EventHandler(this.Input_Click);
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            this.Input.Enter += new System.EventHandler(this.Input_Enter);
            // 
            // Hidden
            // 
            this.Hidden.Location = new System.Drawing.Point(284, 12);
            this.Hidden.Name = "Hidden";
            this.Hidden.Size = new System.Drawing.Size(100, 20);
            this.Hidden.TabIndex = 4;
            this.Hidden.Text = "4 neurons";
            this.Hidden.Click += new System.EventHandler(this.Hidden_Click);
            this.Hidden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hidden_KeyDown);
            this.Hidden.Enter += new System.EventHandler(this.Hidden_Enter);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(480, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 20);
            this.Output.TabIndex = 5;
            this.Output.Text = "3 neurons";
            this.Output.Click += new System.EventHandler(this.Output_Click);
            this.Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Output_KeyDown);
            this.Output.Enter += new System.EventHandler(this.Output_Enter);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(63, 13);
            this.lblInput.TabIndex = 6;
            this.lblInput.Text = "Input Layer:";
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Location = new System.Drawing.Point(205, 15);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(73, 13);
            this.lblHidden.TabIndex = 7;
            this.lblHidden.Text = "Hidden Layer:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(403, 15);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 13);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "Output Layer:";
            // 
            // ValuePrompt
            // 
            this.ValuePrompt.Location = new System.Drawing.Point(460, 334);
            this.ValuePrompt.Name = "ValuePrompt";
            this.ValuePrompt.Size = new System.Drawing.Size(120, 20);
            this.ValuePrompt.TabIndex = 9;
            this.ValuePrompt.Visible = false;
            this.ValuePrompt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValuePrompt_KeyUp);
            // 
            // NeuralWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.ValuePrompt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Hidden);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.OutputNodes);
            this.Controls.Add(this.InputNodes);
            this.Controls.Add(this.imgNetwork);
            this.Name = "NeuralWorks";
            this.Text = "NeuralWorks";
            this.Load += new System.EventHandler(this.NeuralWorks_Load);
            this.SizeChanged += new System.EventHandler(this.NeuralWorks_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.imgNetwork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNetwork;
        private System.Windows.Forms.ListBox InputNodes;
        private System.Windows.Forms.ListBox OutputNodes;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Hidden;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox ValuePrompt;
    }
}

