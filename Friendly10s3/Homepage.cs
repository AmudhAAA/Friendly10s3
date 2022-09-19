using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly10s3
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 10;
            this.progressBar1.Value = Friendly10s3.Game1.successCount;
            this.progressBar2.Value = Friendly10s3.Game2.successCount;
            this.progressBar3.Value = Friendly10s3.Game3.successCount;
            this.progressBar4.Value = Friendly10s3.Game4.successCount;
            button1.Text = Globals.currentlevel.ToString();//dislays most recent level accessed by user at the top of the homepage
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Globals.currentlevel == "Game1")
            {
                Friendly10s3.Game1 f90 = new Friendly10s3.Game1();
                f90.ShowDialog();
            }
            if (Globals.currentlevel == "Game2")
            {
                Friendly10s3.Game2 f80 = new Friendly10s3.Game2();
                f80.ShowDialog();
            }
            if (Globals.currentlevel == "Game3")
            {
                Friendly10s3.Game3 f70 = new Friendly10s3.Game3();
                f70.ShowDialog();
            }
            if (Globals.currentlevel == "Game4")
            {
                Friendly10s3.Game4 f60 = new Friendly10s3.Game4();
                f60.ShowDialog();

            }
            if (Globals.currentlevel == "Game5")
            {
                Friendly10s3.Game5 f50 = new Friendly10s3.Game5();
                f50.ShowDialog();
            }
            if (Globals.currentlevel == "Game6")
            {
                Friendly10s3.Game6 f40 = new Friendly10s3.Game6();
                f40.ShowDialog();

            }
            if (Globals.currentlevel == "Game7")
            {
                Friendly10s3.Game7 f30 = new Friendly10s3.Game7();
                f30.ShowDialog();
            }
            if (Globals.currentlevel == "Game8")
            {
                Friendly10s3.Game8 f20 = new Friendly10s3.Game8();
                f20.ShowDialog();
            }
            if (Globals.currentlevel == "Game9")
            {
                Friendly10s3.Game9 f11 = new Friendly10s3.Game9();
                f11.ShowDialog();

            }
            if (Globals.currentlevel == "Game10")
            {
                Friendly10s3.Game10 f13 = new Friendly10s3.Game10();
                f13.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ignore, button functions the same as a textbox but is used as a button for design purposes

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Game 1
            Friendly10s3.Globals.currentlevel = "Game1";
            Friendly10s3.Game1 f90 = new Friendly10s3.Game1();
            f90.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Game 2
            Friendly10s3.Globals.currentlevel = "Game2";
            Friendly10s3.Game2 f80 = new Friendly10s3.Game2();
            f80.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Game 3
            Friendly10s3.Globals.currentlevel = "Game3";
            Friendly10s3.Game3 f70 = new Friendly10s3.Game3();
            f70.ShowDialog();
        }
    }
}
