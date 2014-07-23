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
    public partial class FindStudentForm : Form
    {
        rosterEntities context = new rosterEntities();
        public FindStudentForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var query =
                from student in context.Students.ToList()
                where (student.first_name.Contains(findtext.Text) || student.last_name.Contains(findtext.Text) || student.id == int.Parse(findtext.Text))
                select student;


            studentBindingSource.DataSource = query.ToList();
        }
    }
}
