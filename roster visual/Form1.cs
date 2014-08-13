﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace roster_visual
{
    public partial class Form1 : Form
    {
        Program Program = new Program();
        Schedule Schedule = new Schedule();
        Student Student = new Student();

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
            enrollmentOfficerBindingSource.DataSource = Context.EnrollmentOfficers;
            
           

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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string new_filepath = Application.StartupPath + @"\Student_Pictures\" + Path.GetFileName(openFileDialog.FileName);

                if (!File.Exists(new_filepath)) File.Copy(openFileDialog.FileName, new_filepath);
                else 
                {
                    Student.Picture = new_filepath;
                    studentImage.Load(new_filepath);
                }
            }

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

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Validate();
            Context.SubmitChanges();
        }

        private void studentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Student = (Student)studentBindingSource.Current;
            studentImage.Load(Student.Picture);
        }

      
    }
}
