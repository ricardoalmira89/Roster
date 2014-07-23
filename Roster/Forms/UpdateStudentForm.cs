﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roster.Model;

namespace Roster.Forms
{
    public partial class UpdateStudentForm : Form
    {
        Context Context = new Context();
        Program program;
        Schedule schedule;
        Student Student;

        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowDialog(Student student, Context context)
        {
            Context = context;
            Student = student;

            studentBindingSource.DataSource = student;
            programBindingSource.DataSource = Context.Programs.ToList();
            CurrentProgramsBindingSource.DataSource = student.Schedules.ToList();
 
            this.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Context.SaveChanges();
        }

        private void programComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = Context.Schedules.ToList();
            program = Context.Programs.First(c => c.id == (int)programComboBox.SelectedValue);
            scheduleBindingSource.DataSource = program.Schedules.ToList();
        }

        private void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            schedule = program.Schedules.First(s => s.id == (int)scheduleComboBox.SelectedValue);
        }

        private void addProgram_btn_Click(object sender, EventArgs e)
        {
            if (!Student.Schedules.Exists(c => c.Program.id == program.id))
            {
                Context.Student_Schedule.Add(new Student_Schedule { Student = this.Student, Schedule = this.schedule });
                Context.Student_Program.Add(new Student_Program   { Student = this.Student, Program  = this.program  });
            }
            else MessageBox.Show("Current Program already exists for this student.\nPlease select another one.", "Program already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CurrentProgramsBindingSource.DataSource = Student.Schedules.ToList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context.Student_Schedule.Remove(Student.Student_Schedule.First(ssch => ssch.schedule_id == (int)ProgramsGridView.CurrentRow.Cells["id"].Value));
            CurrentProgramsBindingSource.DataSource = Student.Schedules.ToList();
        }
    }
}
