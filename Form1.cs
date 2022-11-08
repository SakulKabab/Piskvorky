using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piškvorky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool hracNaRade = true;

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (hracNaRade)
            {
                button.Text = "X";
                button.Enabled = false;
            }
            else
            {
                button.Text = "O";
                button.Enabled = false;
            }
            hracNaRade = !hracNaRade;
        }
    }
}