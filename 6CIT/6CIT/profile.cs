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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();

            if(Home.profileStarted == true)
            {
                fill();
            }
            else
            {
                clear();
            }

            Home.profileStarted = true;
        }

        private bool isControlClosingForm = false;
        public static string DOB;
        public static string ID;
        public static string fname, sname, sex, al1, al2, postcode, occupation;
        public static string notes;
        

        private void btn_back_Click(object sender, EventArgs e)
        {
            var newHome = new Home();
            newHome.Show();
            isControlClosingForm = true;
            Close();
        }

        private void profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isControlClosingForm)
            {
                var newHome = new Home();
                newHome.Show();
            }
        }

        private void collect()
        {
            ID = txt_patient_id.Text;
            fname = txt_patient_fname.Text;
            sname = txt_patient_sname.Text;
            DOB = Convert.ToString(dtp_patient_DOB.Value);
            al1 = txt_patient_adl1.Text;
            al2 = txt_patient_adl2.Text;
            postcode = txt_patient_postcode.Text;
            occupation = txt_patient_occupation.Text;
            notes = rtb_patient_notes.Text;
        }

        private void fill()
        {
            txt_patient_id.Text = ID;
            txt_patient_fname.Text = fname;
            txt_patient_sname.Text = sname;
            dtp_patient_DOB.Value = Convert.ToDateTime(DOB);
            txt_patient_adl1.Text = al1;
            txt_patient_adl2.Text = al2;
            txt_patient_postcode.Text = postcode;
            txt_patient_occupation.Text = occupation;
            rtb_patient_notes.Text = notes;
        }

        private void clear()
        {
            txt_patient_id.Clear();
            txt_patient_fname.Clear();
            txt_patient_sname.Clear();
            dtp_patient_DOB.ResetText();
            txt_patient_adl1.Clear();
            txt_patient_adl2.Clear();
            txt_patient_postcode.Clear();
            txt_patient_occupation.Clear();
            rtb_patient_notes.Clear();
        }

        private void btn_begintest_Click(object sender, EventArgs e)
        {
            collect();
            this.Hide();
            this.Dispose();
            var test = new test();
            test.Show();
        }

    }
}
