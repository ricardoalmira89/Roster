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
    public partial class AddStudentForm : Form
    {
        Context Context;
        Program program;
        Schedule schedule;
        List<Schedule> Schedules = new List<Schedule>();

        public AddStudentForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Context context)
        {
            Context = context;
            this.ShowDialog();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            programBindingSource.DataSource = Context.Programs.ToList();
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
            if (!Schedules.Exists(c => c.Program.id == program.id))
            {
                Schedules.Add(schedule);
                CurrentProgramsBindingSource.DataSource = Schedules.ToList();
            }
            else MessageBox.Show("Current Program already exists for this student.\nPlease select another one.", "Program already exists", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                address = addressTextBox.Text,
                attachment = attachmentTextBox.Text,
                bussiness_phone = bussiness_phoneTextBox.Text,
                home_phone = home_phoneTextBox.Text,
                city = cityTextBox.Text,
                comments = commentsTextBox.Text,
                company = companyTextBox.Text,
                country = countryTextBox.Text,
                credit_trans = credit_transTextBox.Text,
                email = emailTextBox.Text,
                emergency_contact_name = emergency_contact_nameTextBox.Text,
                emergency_contact_phone1 = emergency_contact_phone1TextBox.Text,
                emergency_contact_phone2 = emergency_contact_phone2TextBox.Text,
                emergency_contact_phone3 = emergency_contact_phone3TextBox.Text,
                end_date = end_dateDateTimePicker.Value,
                start_date = start_dateDateTimePicker.Value,
                EO = eOTextBox.Text,
                fax_number = fax_numberTextBox.Text,
                first_name = first_nameTextBox.Text,
                last_name = last_nameTextBox.Text,
                location = locationTextBox.Text,
                locker = lockerTextBox.Text,
                mobile_phone = mobile_phoneTextBox.Text,
                notes = notesTextBox.Text,
                refered = referedTextBox.Text,
                state = stateTextBox.Text,
                status = stateTextBox.Text,
                web_page = web_pageTextBox.Text,
                ZIP = zIPTextBox.Text
            };


            Context.Students.Add(student);

            foreach (Schedule schedule in Schedules)
            {
                Context.Student_Schedule.Add(new Student_Schedule { Student = student, Schedule = schedule });
                Context.Student_Program.Add( new Student_Program  { Student = student, Program  = program  });
            }

            try
            {
                Context.SaveChanges();
                MessageBox.Show("Student successfully added.", "Add Student OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred. Student could not be added.", "Add Student Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedules.RemoveAll(sch => sch.id == (int)ProgramsGridView.CurrentRow.Cells["id"].Value);
            CurrentProgramsBindingSource.DataSource = Schedules.ToList();
        }

    







   }
}
