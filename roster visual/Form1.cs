using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace roster_visual
{
    public partial class Form1 : Form
    {
        Program Program = new Program();
        Schedule Schedule = new Schedule();
        RosterMysqlDataContext Context = new RosterMysqlDataContext();

        public Form1()
        {
            InitializeComponent();

            studentBindingSource.DataSource = Context.Students;

            //--- Load Program/Schedule Defaults ---
            programBindingSource.DataSource = Context.Programs.ToList();
            Program = Context.Programs.First();
            scheduleBindingSource.DataSource = Program.Schedules.ToList();
            Schedule = Program.Schedules.First();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturePictureBox.Load(openFileDialog1.FileName);

            /*try
            {
                Bitmap image1 = (Bitmap)Image.FromFile(@"C:\Documents and Settings\" +
                    @"All Users\Documents\error.png", true);

                TextureBrush texture = new TextureBrush(image1);
                texture.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                Graphics formGraphics = this.CreateGraphics();
                formGraphics.FillEllipse(texture,
                    new RectangleF(90.0F, 110.0F, 100, 100));
                formGraphics.Dispose();

            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error opening the bitmap." +
                    "Please check the path.");
            }*/


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                label5.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label5.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void picturePictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picturePictureBox.Load(openFileDialog1.FileName);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void jOB_TITLELabel_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void program_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program = Context.Programs.First(c => c.Id == (int)program_cmb.SelectedValue);
                Schedule = Program.Schedules.First();
                scheduleBindingSource.DataSource = Program.Schedules.ToList();
            }
            catch (Exception)
            {

            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            Context.SubmitChanges();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
