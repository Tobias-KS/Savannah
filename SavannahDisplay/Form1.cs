using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Savannah;

namespace SavannahDisplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Savannah.Program.Main();
            Savannah.Program.runSavannah();
            InitializeComponent();
            InitializeBoard();
        }
        public void InitializeBoard()
        {
            int x = 120;
            int y = 5;
            int count = 0;
            Size s = new Size(45, 45);
            foreach (var Field in Savannah.Initialize.SavannaGrid)
            {
                if (count > 20)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = s;
                    pb.Location = new Point(x, y);
                    x = x + 45;
                    count++;
                    pb.Visible = true;
                    if (Field.lionCheck() == true)
                    {
                        pb.Image = Properties.Resources.Lion;
                        Controls.Add(pb);
                    }
                    if (Field.grassCheck() == true)
                    {
                        pb.Image = Properties.Resources.Grass;
                        Controls.Add(pb);
                    }
                    if (Field.grassCheck() == true)
                    {
                        pb.Image = Properties.Resources.Grass;
                        Controls.Add(pb);
                    }
                    else
                    {
                        pb.Image = Properties.Resources.Savannah;
                        Controls.Add(pb);
                    }
                }
                else
                {
                    count = 0;
                    x = 120;
                    y = y + 45;
                }
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Initialize.LionList.Count.ToString();
            textBox2.Text = Initialize.RabbitList.Count.ToString();
            Savannah.Program.runSavannah();
            InitializeBoard(); 
        }
    }
}
