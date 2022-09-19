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
            this.progressBar2.Maximum = 10;
            this.progressBar3.Maximum = 10;
            this.progressBar4.Maximum = 10;
            this.progressBar5.Maximum = 10;
            this.progressBar6.Maximum = 10;
            this.progressBar7.Maximum = 10;
            this.progressBar8.Maximum = 10;
            this.progressBar9.Maximum = 10;
            this.progressBar10.Maximum = 10;
            this.progressBar11.Maximum = 10;

            if (Globals.currentlevel == "Game1")
            {
                this.progressBar1.Value = Friendly10s3.Game1.successCount;
            }
            if (Globals.currentlevel == "Game2")
            {
                this.progressBar1.Value = Friendly10s3.Game2.successCount;
            }
            if (Globals.currentlevel == "Game3")
            {
                this.progressBar1.Value = Friendly10s3.Game3.successCount;
            }
            if (Globals.currentlevel == "Game4")
            {
                this.progressBar1.Value = Friendly10s3.Game4.successCount;

            }
            if (Globals.currentlevel == "Game5")
            {
                this.progressBar1.Value = Friendly10s3.Game5.successCount;
            }
            if (Globals.currentlevel == "Game6")
            {
                this.progressBar1.Value = Friendly10s3.Game6.successCount;

            }
            if (Globals.currentlevel == "Game7")
            {
                this.progressBar1.Value = Friendly10s3.Game7.successCount;
            }
            if (Globals.currentlevel == "Game8")
            {
                this.progressBar1.Value = Friendly10s3.Game8.successCount;
            }
            if (Globals.currentlevel == "Game9")
            {
                this.progressBar1.Value = Friendly10s3.Game9.successCount;

            }
            if (Globals.currentlevel == "Game10")
            {
                this.progressBar1.Value = Friendly10s3.Game10.successCount;
            }

            this.progressBar1.Value = Friendly10s3.Game1.successCount;
            this.progressBar2.Value = Friendly10s3.Game1.successCount;
            this.progressBar3.Value = Friendly10s3.Game2.successCount;
            this.progressBar4.Value = Friendly10s3.Game3.successCount;
            this.progressBar5.Value = Friendly10s3.Game4.successCount;
            this.progressBar6.Value = Friendly10s3.Game5.successCount;
            this.progressBar7.Value = Friendly10s3.Game6.successCount;
            this.progressBar8.Value = Friendly10s3.Game7.successCount;
            this.progressBar9.Value = Friendly10s3.Game8.successCount;
            this.progressBar10.Value = Friendly10s3.Game9.successCount;
            this.progressBar11.Value = Friendly10s3.Game10.successCount;    

            button1.Text = Globals.currentlevel.ToString();//dislays most recent level accessed by user at the top of the homepage
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        public void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };

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

        public void button14_Click(object sender, EventArgs e)
        {
            //Game 1
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),
                
            };
            Friendly10s3.Globals.currentlevel = "Game1";
            Friendly10s3.Game1 f90 = new Friendly10s3.Game1();
            f90.ShowDialog();
            
        }

        public void button15_Click(object sender, EventArgs e)
        {
            //Game 2
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game2";
            Friendly10s3.Game2 f80 = new Friendly10s3.Game2();
            f80.ShowDialog();
        }

        public void button16_Click(object sender, EventArgs e)
        {
            //Game 3
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game3";
            Friendly10s3.Game3 f70 = new Friendly10s3.Game3();
            f70.ShowDialog();
        }

        public void button17_Click(object sender, EventArgs e)
        {
            //Game 4
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game4";
            Friendly10s3.Game4 f60 = new Friendly10s3.Game4();
            f60.ShowDialog();

        }

        public void button18_Click(object sender, EventArgs e)
        {
            //Game 5
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game5";
            Friendly10s3.Game5 f50 = new Friendly10s3.Game5();
            f50.ShowDialog();
        }

        public void button19_Click(object sender, EventArgs e)
        {
            //Game 6
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game6";
            Friendly10s3.Game6 f40 = new Friendly10s3.Game6();
            f40.ShowDialog();

        }

        public void button20_Click(object sender, EventArgs e)
        {
            //Game7
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game7";
            Friendly10s3.Game7 f30 = new Friendly10s3.Game7();
            f30.ShowDialog();

        }

        public void button21_Click(object sender, EventArgs e)
        {
            // Game8
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game8";
            Friendly10s3.Game8 f20 = new Friendly10s3.Game8();
            f20.ShowDialog();

        }

        public void button22_Click(object sender, EventArgs e)
        {
            // Game8
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game9";
            Friendly10s3.Game9 f11 = new Friendly10s3.Game9();
            f11.ShowDialog();

        }

        public void button23_Click(object sender, EventArgs e)
        {
            // Game8
            monthCalendar1.BoldedDates = new DateTime[]
            {
                DateTime.Now.AddDays(0),

            };
            Friendly10s3.Globals.currentlevel = "Game10";
            Friendly10s3.Game10 f13 = new Friendly10s3.Game10();
            f13.ShowDialog();
        }
    }
}
