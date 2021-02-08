using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr
{
    public partial class GraphEditor : Form
    {
        Color Currentcolor = Color.Black;
        bool Drow = false;
        Point Currentpoint;
        Point Prevpoint;
        Graphics g;
        float width = 1;
        public GraphEditor()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }
        private void GraphEditor_Load(object sender, EventArgs e)
        {

            Pen p = new Pen(Currentcolor, width);
        }
        private void for_paint()
        {
            Pen p = new Pen(Currentcolor, width);
            g.DrawLine(p, Prevpoint, Currentpoint);
            int val = (int)numericUpDown1.Value;
            width = val;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drow = true;
            Currentpoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Drow = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drow)
            {

                Prevpoint = Currentpoint;
                Currentpoint = e.Location;
                for_paint();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                Currentcolor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics Graph = pictureBox1.CreateGraphics();
            Graph.Clear(SystemColors.Window);
        }




    }
}
