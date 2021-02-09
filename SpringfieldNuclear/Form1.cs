using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media; 

namespace SpringfieldNuclear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.alert);
            alertPlayer.Play();

            this.BackColor = Color.White;
            //change the message in the output label 
            outputLabel.Text = "Meltdown Imminent";

            // change the colours on the reactors
            reactor1State.BackColor = Color.Red;
            reactor2State.BackColor = Color.Red;
         
            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            
            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
        }
    }
}
