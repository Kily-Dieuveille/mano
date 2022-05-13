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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //annulaire

            Point pt = new Point(240, 80);
            Panel pa = new Panel();
            pa.Width = 20;
            pa.Height = 55;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Moyenne");

            pt = new Point(250, 25);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 45;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Distale");

            pt = new Point(230, 145);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 85;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Proximale");

            pt = new Point(220, 235);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 105;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Métacarpe");

            //index

            pt = new Point(100, 90);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 55;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Moyenne");

            pt = new Point(90, 40);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 45;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Distale");

            pt = new Point(115, 145);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 85;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Proximale");

            pt = new Point(135, 235);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 105;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Métacarpe");

            //Majeur

            pt = new Point(175, 135);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 85;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange proximale");

            pt = new Point(165, 15);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 50;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Distale");

            pt = new Point(170, 70);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 55;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Moyenne");

            pt = new Point(175, 230);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 115;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Métacarpe");

            //Pouce

            pt = new Point(15, 185);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 55;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Distale");

            pt = new Point(37, 245);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 65;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Proximale");

            pt = new Point(61, 302);
            pa = new Panel();
            pa.Width = 70;
            pa.Height = 65;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Métacarpe");

            //oriculaire
            pt = new Point(311, 93);
            pa = new Panel();
            pa.Width = 15;
            pa.Height = 35;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Distale");

            pt = new Point(300, 138);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 50;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Moyenne");

            pt = new Point(280, 195);
            pa = new Panel();
            pa.Width = 20;
            pa.Height = 75;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Phalange Proximale");

            pt = new Point(250, 270);
            pa = new Panel();
            pa.Width = 25;
            pa.Height = 90;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Métacarpe");

            pt = new Point(130, 360);
            pa = new Panel();
            pa.Width = 120;
            pa.Height = 60;
            pa.Location = pt;
            pa.BorderStyle = BorderStyle.None;
            pa.BackColor = Color.Transparent;
            pa.Name = "panel";
            pbImage.Controls.Add(pa);
            tt = new ToolTip();
            tt.AutoPopDelay = 1000;
            tt.InitialDelay = 10;
            tt.ReshowDelay = 500;
            tt.ShowAlways = false;
            tt.SetToolTip(pa, "Carpe");


            // MENU ITEM

            

        }
    }


    }
