using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.pdfclown.documents;
using org.pdfclown.documents.contents.composition;
using org.pdfclown.documents.contents.fonts;
using org.pdfclown.documents.contents.objects;
using org.pdfclown.files;
using File = org.pdfclown.files.File;
using Image = org.pdfclown.documents.contents.entities.Image;

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
            if (rB1_correct.Checked == true)
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
            if (checkQ1Filled() == false) { MessageBox.Show("Please Fill In Question 1"); }
            else if (checkQ2Filled() == false) { MessageBox.Show("Please Fill In Question 2"); }
            else if (checkQ3Filled() == false) { MessageBox.Show("Please Fill In Question 3"); }
            else if (checkQ4Filled() == false) { MessageBox.Show("Please Fill In Question 4"); }
            else if (checkQ5Filled() == false) { MessageBox.Show("Please Fill In Question 5"); }
            else if (checkQ6Filled() == false) { MessageBox.Show("Please Fill In Question 6"); }
            else
            {
                score = calculate();
                // MessageBox.Show("Score = " + score);

                if (Home.isFullTest == true)
                {
                    createPDF();
                    var newHome = new Home();
                    newHome.Show();
                    isControlClosingForm = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Quick Test Complete, Score: " + score);
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
            if (rb1_incorrect.Checked == true)
            {
                q1 = 4;
            }

            //Question 2
            if (rb2_incorrect.Checked == true)
            {
                q2 = 3;
            }

            //Question 3
            if (rb4_incorrect.Checked == true)
            {
                q3 = 3;
            }

            //Question 4
            if (cb_q4.Text == "1 Error")
            {
                q4 = 2;
            }

            else if (cb_q4.Text == "More Than 1 Error")
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

            if (rB1_correct.Checked == false && rb1_incorrect.Checked == false)
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

        private void createPDF()
        {
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "PDF File|*.pdf";
            saveFileDialog2.Title = "Save as PDF";
            saveFileDialog2.FileName = "" + profile.fname + " " + profile.sname + " 6CIT Results";

            File file = new File();
            Document document = file.Document;
            Page page = new Page(document);

            document.Pages.Add(page);

            PrimitiveComposer Composer = new PrimitiveComposer(page);
            Composer.SetLineWidth(200);

            /*Image
            Image image = Image.Get("brain.jpg");
            org.pdfclown.documents.contents.xObjects.XObject imageXObject = image.ToXObject(document);
            Composer.ShowXObject(imageXObject, new PointF(450, 40));
            Composer.Flush();*/
            Composer.Flush();

            //Title
            Composer.SetFont(new StandardType1Font(document, StandardType1Font.FamilyEnum.Helvetica, true, false), 32);
            Composer.ShowText("6CIT Results", new PointF(32, 40));

            //Heading 1
            Composer.SetFont(new StandardType1Font(document, StandardType1Font.FamilyEnum.Helvetica, true, false), 24);
            Composer.ShowText("Patient Details", new PointF(32, 100));

            //Heading 1 - Body
            Composer.SetFont(new StandardType1Font(document, StandardType1Font.FamilyEnum.Helvetica, true, false), 12);
            Composer.ShowText("NHS ID: " + profile.ID, new PointF(32, 140));
            Composer.ShowText("Name: " + profile.fname + " " + profile.sname, new PointF(32, 160));
            Composer.ShowText("Sex: " + profile.sex, new PointF(32, 180));
            Composer.ShowText("DOB: " + profile.DOB, new PointF(32, 200));
            Composer.ShowText("Address: " + profile.al1 + " " + profile.al2, new PointF(32, 220));
            Composer.ShowText("Postcode: " + profile.postcode, new PointF(32, 240));
            Composer.ShowText("Occupation: " + profile.occupation, new PointF(32, 260));
            Composer.ShowText("Test Score: " + score, new PointF(32, 300));


            //Patient Notes
            BlockComposer bc = new BlockComposer(Composer);
            bc.Hyphenation = false;
            bc.LineSpace = new Length(1.0, Length.UnitModeEnum.Relative);

            int notesLength = profile.notes.Length;
            int notesHeight = 40;
            int notesY = 320;

            if (notesLength < 300) { notesHeight = 150; }
            else if (notesLength > 300 && notesLength < 600) { notesHeight = 200; }
            else if (notesLength > 600 && notesLength <= 1000) { notesHeight = 350; }

            RectangleF area = new RectangleF(new PointF(32, notesY), new SizeF(400, notesHeight));
            bc.Begin(area, XAlignmentEnum.Left, YAlignmentEnum.Top);
            bc.ShowText("Notes: " + "\n" + profile.notes);
            bc.End();

            Composer.Flush();

            var date = DateTime.Now;

            //Add Page 2
            Page page2 = new Page(document);
            document.Pages.Add(page2);
            Composer = new PrimitiveComposer(page2);

            //Heading 2
            Composer.SetFont(new StandardType1Font(document, StandardType1Font.FamilyEnum.Helvetica, true, false), 24);
            Composer.ShowText("6CIT Score: " + score, new PointF(32, 40));

            Composer.SetFont(new StandardType1Font(document, StandardType1Font.FamilyEnum.Helvetica, true, false), 12);
            Composer.ShowText("Test Carried out on: " /*+ Clinician Details Input Get*/ + " on: " + date, new PointF(32, 80));

            //Convert Question Answers to Temporary Text
            string six_q1_txt = "Incorrect";
            string six_q2_txt = "Incorrect";
            string six_q3_txt = "Incorrect";
            string six_q4_txt = "Incorrect";
            string six_q5_txt = "Incorrect";
            string six_q6_txt;

            if (q1 == 0) { six_q1_txt = "Correct"; }
            if (q2 == 0) { six_q2_txt = "Correct"; }
            if (q3 == 0) { six_q3_txt = "Correct"; }

            //Q4
            if (q4 == 0) { six_q4_txt = "Correct"; }
            else if (q4 == 4) { six_q4_txt = "More Than One Incorrect"; }

            //Q5
            if (q5 == 0) { six_q5_txt = "Correct"; }
            else if (q5 == 2) { six_q5_txt = "One Incorrect"; }
            else if (q5 == 4) { six_q5_txt = "More Than One Incorrect"; }

            //Q6
            if (q6 == 0) { six_q6_txt = "Correct"; }
            else if (q6 == 2) { six_q6_txt = "One Incorrect"; }
            else if (q6 == 4) { six_q6_txt = "More Than One Incorrect"; }
            else if (q6 == 6) { six_q6_txt = "More Than Two Incorrect"; }
            else if (q6 == 8) { six_q6_txt = "More Than Three Incorrect"; }
            else if (q6 == 10) { six_q6_txt = "More Than Four Incorrect"; }
            else { six_q6_txt = "All Incorrect"; }

            Composer.ShowText("Question 1: What Year Is It? : ", new PointF(32, 120));
            Composer.ShowText(six_q1_txt, new PointF(32, 140));

            Composer.ShowText("Question 2: What Month Is It? : ", new PointF(32, 180));
            Composer.ShowText(six_q2_txt, new PointF(32, 200));

            Composer.ShowText("Question 3: What Time Is It? : ", new PointF(32, 240));
            Composer.ShowText(six_q3_txt, new PointF(32, 260));

            Composer.ShowText("Question 4: Count Backwards From 20 to 1: ", new PointF(32, 300));
            Composer.ShowText(six_q4_txt, new PointF(32, 320));

            Composer.ShowText("Question 5: Say The Months of the Year Backwards: ", new PointF(32, 360));
            Composer.ShowText(six_q5_txt, new PointF(32, 380));

            Composer.ShowText("Question 6: Repeat the Memory Phrase: ", new PointF(32, 420));
            Composer.ShowText(six_q6_txt, new PointF(32, 440));

            Composer.ShowText("Test Result was:  " + score, new PointF(32, 480));
            //Composer.ShowText(six_notes, new PointF(32, 500));

            Composer.Flush();

            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file.Save(saveFileDialog2.FileName, SerializationModeEnum.Incremental);
                }
                catch (IOException)
                {
                    MessageBox.Show("File is open somewhere else; Cannot Save to PDF.");
                }
            }
        }
    }
}

