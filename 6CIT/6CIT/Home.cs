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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private bool isControlClosingForm;
        public static bool isFullTest = false;
        public static bool profileStarted = true;


        private void btn_start_Click(object sender, EventArgs e)
        {
            isFullTest = false;
            this.Hide();
            var test = new test();
            test.Show();
        }

        private void btn_fulltest_Click(object sender, EventArgs e)
        {
            profileStarted = false;
            isFullTest = true;
            this.Hide();
            var profile = new profile();
            profile.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        { 
                if (!isControlClosingForm)
                {
                    Dispose();
                    Close();
                    Application.Exit();

                    isControlClosingForm = false;
                } 
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6CIT Test - Written by Dr Patrick Brooke"
                + "\nSoftware - Written By Jonathan Brooke"
                + "\n\nQuick Test - 6CIT Test with Immediate Score"
                + "\nFull Test - 6CIT Test with PDF Output, Requires Patient Data");
        }
    }
}
