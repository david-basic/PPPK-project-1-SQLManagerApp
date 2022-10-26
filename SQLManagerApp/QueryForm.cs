using SQLManagerApp.Dal;
using SQLManagerApp.Models;
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
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            cbQueryDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            ClearForm();

            
        }

        private void ClearForm()
        {
            tbResults.Text = string.Empty;
            tbMessages.Text = string.Empty;
        }
    }
}
