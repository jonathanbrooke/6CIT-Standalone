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
        }

        //Variables
        private int q1, q2, q3, q4, q5, q6;
        private int score;
        private bool isControlClosingForm = false;

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
            score = calculate();
            MessageBox.Show("Score = " + score);
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
    }
}
