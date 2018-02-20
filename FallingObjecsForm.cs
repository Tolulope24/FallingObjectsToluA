using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsToluA
{
    public partial class frmFallingobjects : Form
    {
        public frmFallingobjects()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            double number;
            number = double.Parse(txtNumbers.Text);
            lblAnswer.Text = "The Height of the object above the ground is :" + Convert.ToString(100-0.5*9.81*Math.Pow(number,2));
        }

        private void txtNumbers_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
