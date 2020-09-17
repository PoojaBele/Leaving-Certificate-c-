using System;
using System.Drawing;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms;


namespace Leaving_Ckft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             
            OpenFileDialog open = new OpenFileDialog();
            
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif;  *.png;)|*.jpg; *.jpeg; *.gif;  *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                 
                pictureBox3.Image = new Bitmap(open.FileName);
               
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the PRN field";
                MessageBox.Show(message1);

            }
            else if (textBox2.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Name of student field";
                MessageBox.Show(message1);

            }
            else if (textBox3.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Father's Name  field";
                MessageBox.Show(message1);

            }
            else if (textBox4.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Mother's Name field";
                MessageBox.Show(message1);

            }
            else if (textBox5.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Race/caste/religion field";
                MessageBox.Show(message1);

            }


            else if (textBox6.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Place of Birth field";
                MessageBox.Show(message1);

            }
            else if (textBox7.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Nationality field";
                MessageBox.Show(message1);

            }
            else if (textBox8.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Conduct field";
                MessageBox.Show(message1);

            }
            else if (textBox9.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Reason of leaving field";
                MessageBox.Show(message1);

            }
            else if (textBox10.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Remark field";
                MessageBox.Show(message1);

            }

            else if (pictureBox3.Image == null)
            {
                string message1 = "please upload profile image";
                MessageBox.Show(message1);

            }

            else if (comboBox1.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Branch field";
                MessageBox.Show(message1);

            }
            else if (comboBox2.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Course field";
                MessageBox.Show(message1);

            }
            else if (comboBox3.Text.Trim() == String.Empty)
            {
                string message1 = "please fill the Year field";
                MessageBox.Show(message1);

            }
            else if (pictureBox3.Image== null)
            {
                string message1 = "please upload profile photo";
                MessageBox.Show(message1);

            }
            else {
                DialogResult dialogResult = MessageBox.Show("Are you sure", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                
                SaveFileDialog save = new SaveFileDialog();
            
            save.Filter = "PDF Files(*.pdf;)|*.pdf; ";
                if (save.ShowDialog() == DialogResult.OK)
                {

                    Document document = new Document(PageSize.LETTER, 20, 01, 10, 35);

                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(save.FileName, FileMode.Create));
                    document.Open();

                    iTextSharp.text.Image PNG1 = iTextSharp.text.Image.GetInstance(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png);
                    PNG1.ScalePercent(0.5f * 100);
                    PNG1.SetAbsolutePosition(10f, 700f);
                    document.Add(PNG1);

                    iTextSharp.text.Image PNG2 = iTextSharp.text.Image.GetInstance(pictureBox2.Image, System.Drawing.Imaging.ImageFormat.Png);
                    PNG2.ScalePercent(0.4f * 100);
                    PNG2.SetAbsolutePosition(480f, 700f);
                    document.Add(PNG2);

                    iTextSharp.text.Image jpeg = iTextSharp.text.Image.GetInstance(pictureBox3.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    jpeg.ScalePercent(0.4f * 100);

                    jpeg.SetAbsolutePosition(480f, 560f);
                    document.Add(jpeg);

                    PdfContentByte cb = writer.DirectContent;
                    BaseFont bsf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

                    //heading
                    cb.BeginText();
                    cb.SetFontAndSize(bsf, 22);
                    cb.SetTextMatrix(95, 750);
                    cb.ShowText(label1.Text);
                    cb.SetTextMatrix(230, 725);
                    cb.ShowText(label1_0.Text);
                    cb.SetTextMatrix(180, 700);
                    cb.ShowText(label2.Text);
                    cb.EndText();

                    //enter data
                    cb.BeginText();
                    cb.SetFontAndSize(bsf, 8);

                    cb.SetTextMatrix(10, 690);
                    cb.ShowText(label3.Text);

                    cb.SetTextMatrix(90, 170);
                    cb.ShowText(label20.Text);
                    cb.EndText();

                    //labels
                    cb.BeginText();
                    cb.SetFontAndSize(bsf, 15);

                    cb.SetTextMatrix(90, 650);
                    cb.ShowText(label4.Text);

                    cb.SetTextMatrix(90, 620);
                    cb.ShowText(label5.Text);

                    cb.SetTextMatrix(90, 590);
                    cb.ShowText(label6.Text);

                    cb.SetTextMatrix(90, 560);
                    cb.ShowText(label7.Text);

                    cb.SetTextMatrix(90, 530);
                    cb.ShowText(label8.Text);

                    cb.SetTextMatrix(90, 500);
                    cb.ShowText(label9.Text);

                    cb.SetTextMatrix(90, 470);
                    cb.ShowText(label10.Text);

                    cb.SetTextMatrix(90, 440);
                    cb.ShowText(label11.Text);

                    cb.SetTextMatrix(90, 410);
                    cb.ShowText(label12.Text);

                    cb.SetTextMatrix(90, 380);
                    cb.ShowText(label13.Text);

                    cb.SetTextMatrix(90, 350);
                    cb.ShowText(label14.Text);

                    cb.SetTextMatrix(90, 320);
                    cb.ShowText(label15.Text);

                    cb.SetTextMatrix(90, 290);
                    cb.ShowText(label16.Text);

                    cb.SetTextMatrix(90, 260);
                    cb.ShowText(label17.Text);

                    cb.SetTextMatrix(90, 230);
                    cb.ShowText(label18.Text);

                    cb.SetTextMatrix(90, 200);
                    cb.ShowText(label19.Text);

                    cb.SetTextMatrix(90, 140);
                    cb.ShowText(label21.Text);

                    cb.SetTextMatrix(480, 120);
                    cb.ShowText(label22.Text);
                    cb.EndText();


                    //textBoxes,dateTimePikers & Combo Boxes
                    cb.BeginText();
                    cb.SetFontAndSize(bsf, 15);

                    cb.SetTextMatrix(250, 650);
                    cb.ShowText(textBox1.Text);

                    cb.SetTextMatrix(250, 620);
                    cb.ShowText(textBox2.Text);

                    cb.SetTextMatrix(250, 590);
                    cb.ShowText(textBox3.Text);

                    cb.SetTextMatrix(250, 560);
                    cb.ShowText(textBox4.Text);

                    cb.SetTextMatrix(250, 530);
                    cb.ShowText(textBox5.Text);

                    cb.SetTextMatrix(250, 500);
                    cb.ShowText(textBox6.Text);

                    cb.SetTextMatrix(250, 470);
                    cb.ShowText(textBox7.Text);

                    cb.SetTextMatrix(250, 440);
                    cb.ShowText(dateTimePicker1.Text);

                    cb.SetTextMatrix(250, 410);
                    cb.ShowText(dateTimePicker2.Text);

                    cb.SetTextMatrix(250, 380);
                    cb.ShowText(dateTimePicker3.Text);

                    cb.SetTextMatrix(250, 350);
                    cb.ShowText(textBox8.Text);

                    cb.SetTextMatrix(250, 320);
                    cb.ShowText(textBox9.Text);

                    cb.SetTextMatrix(250, 290);
                    cb.ShowText(comboBox1.Text);

                    cb.SetTextMatrix(250, 260);
                    cb.ShowText(comboBox2.Text);

                    cb.SetTextMatrix(250, 230);
                    cb.ShowText(comboBox3.Text);

                    cb.SetTextMatrix(250, 200);
                    cb.ShowText(textBox10.Text);

                    cb.SetTextMatrix(130, 140);
                    cb.ShowText(dateTimePicker4.Text);
                    cb.EndText();



                    

                    document.Close();
                        string message = "Saved Successfully";
                        MessageBox.Show(message);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                   
                }
                
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox8.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
            dateTimePicker2.Text = String.Empty;
            dateTimePicker3.Text = String.Empty;
            dateTimePicker4.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox1.Text = String.Empty;
            pictureBox3.Image = null;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }
    }
}
