using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roster_visual.Reports
{
    public partial class StudentCardForm : Form
    {
        public StudentCardForm()
        {
            InitializeComponent();
        }

        private void StudentCardForm_Load(object sender, EventArgs e)
        {

            this.StudentCardReport.RefreshReport();
        }

        public void ShowDialog(RosterMysqlDataContext _context, int student_id)
        {

            StudentviewBindingSource.DataSource = from student_view in _context.Studentviews
                                                  where student_view.Id == student_id
                                                  select student_view;
            this.ShowDialog();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
