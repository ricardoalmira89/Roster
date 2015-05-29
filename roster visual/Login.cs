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
    public partial class Login : Form
    {
        private Security Security = new Security();
        private RosterMysqlDataContext Context = new RosterMysqlDataContext();

        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            User user = Context.Users.FirstOrDefault(u => u.Username == txt_username.Text && u.Password == txt_password.Text);

            if (user != null)
            {
                MainForm mainform = new MainForm();
                this.Hide();
                mainform.ShowDialog(Context, user);
            }
            else
            {
                txt_password.Clear();
                MessageBox.Show("Bad Credentials", "Wrong User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_password.Focus();
            }
        }
    }
}
