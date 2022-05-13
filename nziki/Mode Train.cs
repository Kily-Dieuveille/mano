using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nziki
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string val1 = txbx1.Text;
            string val2 = txbx2.Text;
            string val3 = txbx3.Text;
            string val4 = txbx4.Text;
            string val5 = txbx5.Text;

            if (val1.Equals("Phalange Distale"))
                {txbx1.BackColor = Color.FromArgb(144, 238, 144);
                txbx1.Enabled = false;
            }
            else {txbx1.BackColor = Color.FromArgb(255,160, 122);
                  }

            if(val2.Equals("Phalange Moyenne"))
                {txbx2.BackColor = Color.FromArgb(144, 238, 144);
                txbx2.Enabled = false;
            }
            else {txbx2.BackColor = Color.FromArgb(255, 160, 122);
                  }

            if (val3.Equals("Phalange Proximale"))
                {txbx3.BackColor = Color.FromArgb(144, 238, 144);
                txbx3.Enabled = false;
            }
            else{txbx3.BackColor = Color.FromArgb(255, 160, 122);
                 }

            if (val4.Equals("Métacarpe"))
                {txbx4.BackColor = Color.FromArgb(144, 238, 144);
                txbx4.Enabled = false;
            }
            else{txbx4.BackColor = Color.FromArgb(255, 160, 122);
                 }

            if (val5.Equals("Carpe"))
                { txbx5.BackColor = Color.FromArgb(144, 238, 144);
                txbx5.Enabled = false;
            }
            else {txbx5.BackColor = Color.FromArgb(255, 160, 122);
                  }
        }

    }
}
