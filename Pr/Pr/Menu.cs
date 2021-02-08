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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Calc newCalc = new Calc();
            newCalc.Show();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            GraphEditor newGraphEditor = new GraphEditor();
            newGraphEditor.Show();
        }
    }
}
