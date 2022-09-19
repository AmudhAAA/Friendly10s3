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
    public partial class Game4 : Form
    {
        public static int tally = 0; /// the value of the button the user presses on is added to the variable: tally, ensuring they make a pair that adds up to ten///
        public static int count = 0; /// this variable counts the number of times buttons are pressed, ensuring the user clicks on two buttons to add up to ten///
        public static int successCount = 0; /// after every successful pair, two is added to this tally until it exceeds 8 ( meaning four pairs have succesfully matched) ///
        public static int errorcount = 0;// counts the number of times the user's mistakes initiate the error() subroutine
        List<Button> btd = new List<Button>(); /// makes sure the right button dissapears when clicked on///
        public Game4()
        {
            InitializeComponent();
            label1.Text = "0";
            button1.Text = "4";
            button2.Text = "36";
            button3.Text = "8";
            button4.Text = "32";
            button5.Text = "12";
            button6.Text = "28";
            button7.Text = "16";
            button8.Text = "24";
            button9.Text = "20";
            button10.Text = "20";
        }

        public void button1_Click(object sender, EventArgs e)
        {

            tally = tally + 1; /// when this button is clicked, the value one is added to the tally///
            count = count + 1; /// when this button is clicked, the  value one is added to the count///
            btd.Add(button1); /// this adds the button to the list of buttons///
            checker(); //this runs checker//
            button1.BackColor = Color.LightYellow; //when clicked on, the button turns yellow to indicate the user has clicked on it///



        }
        public void button2_Click(object sender, EventArgs e)
        {
            tally = tally + 9;
            count = count + 1;
            btd.Add(button2);
            button2.BackColor = Color.LightYellow;
            checker();


        }
        public void button3_Click(object sender, EventArgs e)
        {
            tally = tally + 2;
            count = count + 1;
            button3.BackColor = Color.LightYellow;
            btd.Add(button3);
            checker();

        }
        public void button4_Click(object sender, EventArgs e)
        {
            tally = tally + 8;
            count = count + 1;
            button1.BackColor = Color.LightYellow;
            btd.Add(button4);
            checker();


        }
        public void checker() ///this subroutine checks if the uesr correctly matched a pair that adds up to ten///
        {

            if (count == 1) /// if the user has only clicked on one button, nothing should be done///
            {
                return;
            }


            if (count == 2)
            {
                if (tally == 10) /// if both requirements are fulfilled, it means the user has clicked on two buttons that add up to 10, succesfully matching that pair. Subroutine success then runs///
                {
                    success();


                }
                else
                {
                    error(); /// if the user chooses two buttons but they don't add up to ten, the error subroutine runs///

                }
            }
            string ec = errorcount.ToString(); /// converts the error count to a string so it can be displayed///
            label1.Text = ec; ///label1 displays the error count///
            Progress(); /// after each pair is matched, this subroutine runs in case the user is ready to progress to the next level///


        }
        public void error() /// As mentioned, if the user incorrectly matches a pair, this subroutine runs///
        {
            timer1.Enabled = true;
            pictureBox4.Visible = true; /// a previously hidden image appears, revealing a red "fail'///

            tally = 0; ///tally and count are reset back to zero, ready for the next pair the user makes///
            count = 0;
            errorcount = errorcount + 1; ///1 is added to the erorr count of the user which is used to see if they are allowed to progress to the next level///
            colourReset(); /// subroutine that makes buttons return to their original colour///
            btd.Clear(); ///all buttons are cleared from the list and do not become invisible as the user has failed///
        }
        public void success()
        {
            timer2.Enabled = true;
            pictureBox3.Visible = true; ///a previously hidden image appears, revealing a success image///

            tally = 0;
            count = 0;
            successCount = successCount + 2; ///2 is added to the success count which determines when the option to progress to the next level appears///


            foreach (Button x in btd) /// all the buttons added to the list which is all the buttons clicked on is made invisible///
            {
                x.Visible = false;

            }

            btd.Clear(); ///the list of buttons are cleared, allowing for the next pair the user will match///



        }
        public void colourReset() ///as mentioned, a subroutine that resets all buttons back to their original colour///
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tally = tally + 3;
            count = count + 1;
            button5.BackColor = Color.LightYellow;
            btd.Add(button5);
            checker();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tally = tally + 7;
            count = count + 1;
            button6.BackColor = Color.LightYellow;
            btd.Add(button6);
            checker();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tally = tally + 4;
            count = count + 1;
            button7.BackColor = Color.LightYellow;
            btd.Add(button7);
            checker();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            tally = tally + 5;
            count = count + 1;
            button9.BackColor = Color.LightYellow;
            btd.Add(button9);
            checker();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            tally = tally + 5;
            count = count + 1;
            button10.BackColor = Color.LightYellow;
            btd.Add(button10);
            checker();



        }

        private void button8_Click(object sender, EventArgs e)
        {
            tally = tally + 6;
            count = count + 1;
            button8.BackColor = Color.LightYellow;
            btd.Add(button8);
            checker();

        }




        public void button11_Click(object sender, EventArgs e) // takes to next level///
        {
            Friendly10s3.Globals.currentlevel = "Game5";
            Friendly10s3.Game5 f5 = new Friendly10s3.Game5();
            f5.ShowDialog();
        }
        public void Progress() /// this subroutine checks if the user is ready to progress to the next level which is when the success count is over 8 ( meaning they have matched four pairs) and when they have made less than two errors. If they have successfully matched four pairs but made more than two errors, only the option to retry that level is provided///
        {
            if (successCount >= 8)
            {
                button12.Visible = true;

                if (errorcount <= 2)
                {
                    button11.Visible = true;

                }

            }
            else
            {
                button11.Visible = false;

            }

        }
        public void Retry() ///the retry subroutine resets everything, allowing the uesr to retry the level//
        {
            errorcount = 0; ///errorcount is reset back to 0///
            successCount = 0; ///successcount is reset back to 0///
            tally = 0; ///tally and count is resent back to 0///
            count = 0;
            label1.Text = "0";

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;//all buttons are made visible///
            button11.Visible = false;
            button12.Visible = false; ///retry and next level buttons are made invisible///

            colourReset(); ///all buttons are reset to their original colour///
        }
        private void button12_Click(object sender, EventArgs e) ///this is the retry button which when clicked on, trigers the retry subroutine///
        {
            Retry();
        }
        private void Game4_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Friendly10s3.Homepage f0 = new Friendly10s3.Homepage();
            f0.ShowDialog();
        }
    }
}
