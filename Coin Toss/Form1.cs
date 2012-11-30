using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                string toss = "";
                switch (rnd.Next(1, 4))
                {
                    case 1:
                    case 2:
                        toss = "Heads";
                        break;
                    case 3:
                    case 4:
                        toss = "Tails";
                        break;
                }
                MessageBox.Show(toss + " won the coin toss!", "Coin Toss", MessageBoxButtons.OK);
                return;
            }
            catch { MessageBox.Show("An error occured with the coin toss.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }
    }
}
