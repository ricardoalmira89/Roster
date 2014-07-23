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
        rosterEntities context = new rosterEntities();
        Roster.Model.Program Program;
        Roster.Model.Schedule Schedule;
        //Roster.Model.Student_Schedule Student_Schedule;

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            programBindingSource.DataSource = context.Programs.ToList();
        }

        private void programComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = context.Schedules.ToList();
            Program = context.Programs.First(c => c.id == (int)programComboBox.SelectedValue);
            scheduleBindingSource.DataSource = Program.Schedules.ToList();
        }

        private void scheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schedule = Program.Schedules.First(s => s.id == (int)scheduleComboBox.SelectedValue);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            /*Student student = new Student();
            student.address = addressTextBox.Text;
            student.attachment = attachmentTextBox.Text;
            student.bussiness_phone = bussiness_phoneTextBox.Text;
            student.C__home_phone = c__home_phoneTextBox.Text;
            student.city = cityTextBox.Text;
            student.comments = commentsTextBox.Text;
            student.company = companyTextBox.Text;
            student.country = countryTextBox.Text;
            student.credit_trans = credit_transTextBox.Text;
            student.email = emailTextBox.Text;
            student.emergency_contact_name = emergency_contact_nameTextBox.Text;
            student.emergency_contact_phone1 = emergency_contact_phone1TextBox.Text;
            student.emergency_contact_phone2 = emergency_contact_phone2TextBox.Text;
            student.emergency_contact_phone3 = emergency_contact_phone3TextBox.Text;
            student.end_date = end_dateDateTimePicker.Value;
            student.start_date = start_dateDateTimePicker.Value;
            student.EO = eOTextBox.Text;
            student.fax_number = fax_numberTextBox.Text;
            student.first_name = first_nameTextBox.Text;
            student.last_name = last_nameTextBox.Text;
            student.location = locationTextBox.Text;
            student.locker = lockerTextBox.Text;
            student.mobile_phone = mobile_phoneTextBox.Text;
            student.notes = notesTextBox.Text;
            student.refered = referedTextBox.Text;
            student.state = stateTextBox.Text;
            student.status = stateTextBox.Text;
            student.web_page = web_pageTextBox.Text;
            student.ZIP = zIPTextBox.Text;*/

            //context.Students.Add(student);
            //context.SaveChanges();
            
        }



   }
}
