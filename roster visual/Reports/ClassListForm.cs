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
    public partial class ClassListForm : Form
    {
        public ClassListForm()
        {
            InitializeComponent();
        }

        private void ClassListForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void ShowDialog(IQueryable _student_view)
        {
            StudentviewBindingSource.DataSource = _student_view;
            this.ShowDialog();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
