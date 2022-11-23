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
        bool konecHry = false;
        char[] pole = new pole[3,3];
        
        private void Tah(int radek, int sloupec)
        {
            if(!konecHry)
            {
                if(hracNaRade)
                {
                    pole[sloupec,radek]="X";
                }
                else
                {
                    pole[sloupec,radek]="O";
                }
                if(pole[0,0]==pole[1,0]&&pole[1,0]==pole[2,0])konecHry=true;
                if(pole[0,1]==pole[1,1]&&pole[1,1]==pole[2,1])konecHry=true;
                if(pole[0,2]==pole[1,2]&&pole[1,2]==pole[2,2])konecHry=true;
                
                if(pole[0,0]==pole[0,1]&&pole[0,1]==pole[0,2])konecHry=true;
                if(pole[1,0]==pole[1,1]&&pole[1,1]==pole[1,2])konecHry=true;
                if(pole[2,0]==pole[2,1]&&pole[2,1]==pole[2,2])konecHry=true;
                
                if(pole[0,0]==pole[1,1]&&pole[1,1]==pole[2,2])konecHry=true;
                if(pole[0,2]==pole[1,1]&&pole[1,1]==pole[2,0])konecHry=true;
            }
        }
/*
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
        */
    }
}
