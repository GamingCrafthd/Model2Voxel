using System;
using System.Windows.Forms;

namespace TrainCalc
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "1:32 (Spur 1)":
                    Program.Gauge = 32;
                    break;

                case "1:87 (Spur H0)":
                    Program.Gauge = 87;
                        break;

                case "1:120 (Spur TT)":
                    Program.Gauge = 120;
                    break;

                case "1:160 (Spur N Europa)":
                    Program.Gauge = 160;
                    break;

                case "1:150 (Spur N Japan)":
                    Program.Gauge = 150;
                    break;

                case "1:148 (Spur N GB)":
                    Program.Gauge = 148;
                    break;

                case "1:220 (Spur Z)":
                    Program.Gauge = 220;
                    break;

                default:
                    break;
            }

            Program.Form.label1.Text = "Zentimeter (1:"+Program.Gauge+")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Program.Form.Enabled = true;
            Program.Form.Focus();
        }
    }
}
