using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6CIT
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
            if (Home.isFullTest == false)
            {
                btn_back.Hide();
                btn_back.Enabled = false;
            }
            else if (Home.isFullTest == true)
            {
                btn_Cancel.Hide();
                btn_Cancel.Enabled = false;
            }
        }

        //Variables
        private int q1, q2, q3, q4, q5, q6;
        private int score;
        private bool isControlClosingForm = false;


        private void btn_back_Click(object sender, EventArgs e)
        {
            var newProfile = new profile();
            newProfile.Show();
            isControlClosingForm = true;
            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            rB1_correct.Checked = false;
            rb1_incorrect.Checked = false;
            rb2_correct.Checked = false;
            rb2_incorrect.Checked = false;
            rb3_correct.Checked = false;
            rb4_incorrect.Checked = false;
            cb_q4.SelectedIndex = 0;
            cb_q5.SelectedIndex = 0;
            cb_q6.SelectedIndex = 0;
        }

        private void rB1_correct_CheckedChanged(object sender, EventArgs e)
        {
            if(rB1_correct.Checked == true)
            {
                rb1_incorrect.Checked = false;
            }
        }

        private void rb1_incorrect_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1_incorrect.Checked == true)
            {
                rB1_correct.Checked = false;
            }
        }

        private void rb2_correct_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2_correct.Checked == true)
            {
                rb2_incorrect.Checked = false;
            }
        }

        private void rb2_incorrect_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2_incorrect.Checked == true)
            {
                rb2_correct.Checked = false;
            }
        }

        private void rb3_correct_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3_correct.Checked == true)
            {
                rb4_incorrect.Checked = false;
            }
        }

        private void rb4_incorrect_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4_incorrect.Checked == true)
            {
                rb3_correct.Checked = false;
            }
        }


        private void test_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isControlClosingForm)
            {
                var newHome = new Home();
                newHome.Show();
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(checkQ1Filled() == false){MessageBox.Show("Please Fill In Question 1");}
            else if(checkQ2Filled() == false){MessageBox.Show("Please Fill In Question 2");}
            else if (checkQ3Filled() == false){MessageBox.Show("Please Fill In Question 3");}
            else if (checkQ4Filled() == false){MessageBox.Show("Please Fill In Question 4");}
            else if (checkQ5Filled() == false){MessageBox.Show("Please Fill In Question 5");}
            else if (checkQ6Filled() == false){MessageBox.Show("Please Fill In Question 6");}
            else
            {
                score = calculate();
                MessageBox.Show("Score = " + score);

                if (Home.isFullTest == true)
                {
                    //PDF Save Dialog --> Here
                    var newHome = new Home();
                    newHome.Show();
                    isControlClosingForm = true;
                    Close();
                }
                else
                {
                    var newHome = new Home();
                    newHome.Show();
                    isControlClosingForm = true;
                    Close();
                }

                Home.profileStarted = false;
                Home.isFullTest = false;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var newHome = new Home();
            newHome.Show();
            isControlClosingForm = true;
            Close();
        }

        private int calculate()
        {
            int score = 0;

            //Insert Calculation Here
            //Question 1
            if(rb1_incorrect.Checked == true)
            {
                q1 = 4;
            }

            //Question 2
            if (rb2_incorrect.Checked == true)
            {
                q2 = 3;
            }

            //Question 3
            if(rb4_incorrect.Checked == true)
            {
                q3 = 3;
            }

            //Question 4
            if(cb_q4.Text == "1 Error")
            {
                q4 = 2;
            }

            else if(cb_q4.Text == "More Than 1 Error")
            {
                q4 = 4;
            }

            //Question 5
            if (cb_q5.Text == "1 Error")
            {
                q5 = 2;
            }

            else if (cb_q5.Text == "More Than 1 Error")
            {
                q5 = 4;
            }

            //Question 6
            if (cb_q6.Text == "1 Error")
            {
                q6 = 2;
            }

            else if (cb_q6.Text == "2 Errors")
            {
                q6 = 4;
            }

            else if (cb_q6.Text == "3 Errors")
            {
                q6 = 6;
            }

            else if (cb_q6.Text == "4 Errors")
            {
                q6 = 8;
            }

            else if (cb_q6.Text == "All Incorrect")
            {
                q6 = 10;
            }

            //Calculation

            score = q1 + q2 + q3 + q4 + q5 + q6;

            //
            return score;
        }

        private bool checkQ1Filled()
        {
            bool allAnsFilled = true;

            if(rB1_correct.Checked == false && rb1_incorrect.Checked == false)
            {
                allAnsFilled = false;
            }

            return allAnsFilled;
        }

        private bool checkQ2Filled()
        {
            bool allAnsFilled = true;

            if (rb2_correct.Checked == false && rb2_incorrect.Checked == false)
            {
                allAnsFilled = false;
            }

            return allAnsFilled;
        }

        private bool checkQ3Filled()
        {
            bool allAnsFilled = true;

            if (rb3_correct.Checked == false && rb4_incorrect.Checked == false)
            {
                allAnsFilled = false;
            }

            return allAnsFilled;
        }

        private bool checkQ4Filled()
        {
            bool allAnsFilled = true;

            if (cb_q4.Text == "")
            {
                allAnsFilled = false;
            }

            return allAnsFilled;
        }

        private bool checkQ5Filled()
        {
            bool allAnsFilled = true;

            if (cb_q5.Text == "")
            {
                allAnsFilled = false;
            }

            return allAnsFilled;
        }

        private bool checkQ6Filled()
        {
            bool allAnsFilled = true;

            if (cb_q6.Text == "")
            {
                allAnsFilled = false;
            }

            return allAnsFilled;
        }
    }
}
