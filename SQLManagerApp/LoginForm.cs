using SQLManagerApp.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLManagerApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                RepositoryFactory.GetRepository().Login(
                       tbServer.Text.Trim(),
                       tbUsername.Text.Trim(),
                       tbPassword.Text.Trim()
                       );
                txtError.Visible = false;
                new MainForm().Show();
                Hide();
            }
            catch (Exception ex)
            {
                txtError.Visible = true;
                txtError.Text = ex.Message;
            }
        }
    }
}
