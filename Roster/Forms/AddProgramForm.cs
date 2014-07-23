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
    public partial class AddProgramForm : Form
    {
        Program program;
        Context Context;

        public AddProgramForm()
        {
            InitializeComponent();
        }

        public void ShowDialog(Context context)
        {
            Context = context;
            programBindingSource.DataSource = context.Programs.ToList();

            this.ShowDialog();
        }

        private void add_program_btn_Click(object sender, EventArgs e)
        {
            Context.Programs.Add(new Program {name = nameTextBox.Text,slug = slugTextBox.Text });
            Context.SaveChanges();
            programBindingSource.DataSource = Context.Programs.ToList();
        }

        private void AddProgramForm_Load(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Context.Programs.Remove(program);
                Context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred while deleting \"" + program.name + "\" program.\nOne or many students may still linked with this program.\nIf you continue with this operation, students in this program will loose they programs.\nChoose YES to continue.","Program Deleting Error",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            }
            
            programBindingSource.DataSource = Context.Programs.ToList();
        }

        private void programsGridView_SelectionChanged(object sender, EventArgs e)
        {
            int idprog = (int)programsGridView.CurrentRow.Cells["id"].Value;
            program = Context.Programs.First(prog => prog.id == idprog );
        }
    }
}
