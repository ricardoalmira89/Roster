using System;
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
        rosterEntities Context = new rosterEntities();
        Program program;
        Schedule schedule;
        List<Schedule> Schedules = new List<Schedule>();
        Student Student;

        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowDialog(Student student, rosterEntities context)
        {
            Context = context;
            programBindingSource.DataSource = Context.Programs.ToList();
            Student = student;

            

            studentBindingSource.DataSource = student;


            this.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
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
    }
}
