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
        Context Context;
        Student student;
        UpdateStudentForm UpdateStudent = new UpdateStudentForm();
        int id = 0;

        public FindStudentForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Context context)
        {
            Context = context;
            this.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var query =
                from student in Context.Students.ToList()
                where (student.first_name.Contains(findtext.Text) || student.last_name.Contains(findtext.Text)|| student.id.ToString() == findtext.Text)
                select student;


            studentBindingSource.DataSource = query.ToList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Context.Students.Remove(student);
            Context.SaveChanges();
            studentBindingSource.DataSource = Context.Students.ToList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent.ShowDialog(student, Context);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Context.Students.Count() > 0)
            {
                id = (int)studentsGridView.CurrentRow.Cells[0].Value;
                student = Context.Students.First(s => s.id == id);
            }
        }

        private void FindStudentForm_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = Context.Students.ToList();
        }

        private void studentsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateStudent.ShowDialog(student, Context);
        }
    }
}
