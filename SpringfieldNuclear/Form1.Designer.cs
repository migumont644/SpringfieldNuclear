namespace SpringfieldNuclear
{
    partial class Form1
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.rector1label = new System.Windows.Forms.Label();
            this.rector2label = new System.Windows.Forms.Label();
            this.reactor1State = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.reactor2State = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(256, 22);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(272, 25);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Nuclear Reactor Control ";            
            // 
            // rector1label
            // 
            this.rector1label.AutoSize = true;
            this.rector1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rector1label.Location = new System.Drawing.Point(162, 89);
            this.rector1label.Name = "rector1label";
            this.rector1label.Size = new System.Drawing.Size(99, 24);
            this.rector1label.TabIndex = 1;
            this.rector1label.Text = "Reactor 1";          
            // 
            // rector2label
            // 
            this.rector2label.AutoSize = true;
            this.rector2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rector2label.Location = new System.Drawing.Point(493, 89);
            this.rector2label.Name = "rector2label";
            this.rector2label.Size = new System.Drawing.Size(99, 24);
            this.rector2label.TabIndex = 2;
            this.rector2label.Text = "Reactor 2";
            // 
            // reactor1State
            // 
            this.reactor1State.BackColor = System.Drawing.Color.Green;
            this.reactor1State.Location = new System.Drawing.Point(147, 141);
            this.reactor1State.Name = "reactor1State";
            this.reactor1State.Size = new System.Drawing.Size(138, 119);
            this.reactor1State.TabIndex = 3;         
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Ivory;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(224, 339);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(315, 75);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(336, 273);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 34);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // reactor2State
            // 
            this.reactor2State.BackColor = System.Drawing.Color.Green;
            this.reactor2State.Location = new System.Drawing.Point(475, 141);
            this.reactor2State.Name = "reactor2State";
            this.reactor2State.Size = new System.Drawing.Size(138, 119);
            this.reactor2State.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reactor2State);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor1State);
            this.Controls.Add(this.rector2label);
            this.Controls.Add(this.rector1label);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = " Springfield Nuclear Power Plant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label rector1label;
        private System.Windows.Forms.Label rector2label;
        private System.Windows.Forms.Label reactor1State;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label reactor2State;
    }
}

