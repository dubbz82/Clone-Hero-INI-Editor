using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTimeCalculator : Form
    {
        public frmTimeCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double millis = 0;
            int i;
            if (int.TryParse(txtHours.Text, out i) == true)
            {
                millis = millis + (i * 3600000);
            }
            if (int.TryParse(txtMinutes.Text, out i) == true)
            {
                millis = millis + (i * 60000);
            }
            if (int.TryParse(txtSeconds.Text, out i ) == true)
            {
                millis = millis + (i * 1000);
            }
            if (int.TryParse(txtSeconds.Text, out i ) == true)
            {
                millis = millis + i;
            }

            txtOutput.Text = millis.ToString();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txtHours.Text, out i) == false)
            {
                txtHours.Text = "0";
            }
        }

        private void frmTimeCalculator_Load(object sender, EventArgs e)
        {
            txtHours.Text = "0";
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
            txtMilliseconds.Text = "0";
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txtMinutes.Text, out i ) == false)
            {
                txtMinutes.Text = "0";
            }
        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txtSeconds.Text, out i) == false)
            {
                txtSeconds.Text = "0";
            }
        }

        private void txtMilliseconds_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(txtMilliseconds.Text, out i) == false)
            {
                txtMilliseconds.Text = "0";
            }
        }
    }
}
