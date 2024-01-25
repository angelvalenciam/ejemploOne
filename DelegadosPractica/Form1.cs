using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegadosPractica
{
    public partial class Form1 : Form
    {
        public delegate void Midel(string text);
        public Midel midel;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDelegate objDelegate = new PrintDelegate();
            objDelegate.print += PrintDelegetes;
            objDelegate.GenerateCard();
            objDelegate.GenerateCard2();
        }

        private void PrintDelegetes(string text, int opt)
        {
            switch (opt)
            {
                case 0: listBox1.Items.Add(text); ; break;
                case 1: listBox2.Items.Add(text); ; break;
            }
            
        }

        private void printDel(string text)
        {
           
        }
    }
}
