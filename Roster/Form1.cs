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
using Roster.Forms;

namespace Roster
{
    public partial class Form1 : Form
    {
        public AddStudentForm AddStudent = new AddStudentForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Student student = new Student();
            student.address = "calle 214a";
            student.attachment = "123";
            student.bussiness_phone = "8284350";
            student.C__home_phone = "123";
            student.city = "Lisa";
            student.comments = "123";
            student.company = "BNJM";
            student.country = "cuba";
            student.credit_trans = "0000";
            student.email = "aaaa@bb.cc";
            student.emergency_contact_name = "ec";
            student.emergency_contact_phone1 = "123";
            student.emergency_contact_phone2 = "123";
            student.emergency_contact_phone3 = "123";
            student.end_date = new DateTime(2014, 07, 01);
            student.EO = "eo";
            student.fax_number = "111";
            student.first_name = "Ricardo";
            //student.id = 1;
            student.last_name = "Almira";
            student.location = "location";
            student.locker = "loker";
            student.mobile_phone = "aaa";
            student.notes = "no";
            student.refered = "ref";
            student.start_date = new DateTime(2014, 06, 01);
            student.state = "state";
            student.status = "aaa";
            //student.Student_Schedule
            student.web_page = "www.aa.bb";
            student.ZIP = "qwe";

            using (var dbCtx = new rosterEntities())
            {
                
                //Add standard object into Standard DBset
                dbCtx.Students.Add(student);
                // call SaveChanges method to save standard into database
                dbCtx.SaveChanges();
            }
            */
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudent.ShowDialog();
        }
    }
}
