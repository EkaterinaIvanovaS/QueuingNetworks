using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeMO1
{
    public partial class StartForm : Form
    {
        public static double L;
        public static double N;
        public static int theoremNumb;
        public static double[] mu = { 0.85, 1, 0.9, 1.1, 1.15 };

        public StartForm()
        {
            InitializeComponent();
        }

        private void createGrid_Click(object sender, EventArgs e)
        {
            L = (int)countSystems.Value;
            N = (int)countRequirements.Value;
            GridForm formGrid = new GridForm();
            formGrid.ShowDialog();
        }

        private void theorem1_Click(object sender, EventArgs e)
        {
            theoremNumb = 1;
        }

        private void theorem2_Click(object sender, EventArgs e)
        {
            theoremNumb = 2;
        }

        private void theorem3_Click(object sender, EventArgs e)
        {
            theoremNumb = 3;
        }
    }
}
