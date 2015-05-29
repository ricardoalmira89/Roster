using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roster_visual
{
    public partial class DropForm : Form
    {
        RosterMysqlDataContext Context;
        Student _Student;

        public DropForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(RosterMysqlDataContext _context, Student _student)
        {
            Context = _context;
            _Student = _student;

            studentBindingSource.DataSource = _student;

            if (_student.DropInfo != null)
            dropInfoBindingSource.DataSource = _student.DropInfo;
            

            ShowDialog();
           
        }

        private void refundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Name == "refundRadioButton") dateLabel.Text = "To be refunded by:";
            else dateLabel.Text = "To be paid by:";
        }

        private void Drop_btn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you really want to Drop "+_Student.FirstName+" "+_Student.LastName, "Drop Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _Student.DropInfo = new DropInfo()
                {
                    Refund = refundRadioButton.Checked,
                    Paid = paidCheckBox.Checked,
                    Amount = int.Parse(amountTextBox.Text),
                    Check = null,
                    Date = dateDateTimePicker.Value
                };

                Validate();
                Context.SubmitChanges();
                this.Close();
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
