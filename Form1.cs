using System;
using System.Windows.Forms;

namespace TrainCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var y = numericUpDown1.Value;
            textBox1.Text = (y * Program.Gauge / 100 * 16) + " Voxel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enabled = false;  
            Program.Settings.Show();
        }
    }
}
