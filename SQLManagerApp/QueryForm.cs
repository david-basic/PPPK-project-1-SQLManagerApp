using SQLManagerApp.Dal;
using SQLManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            cbQueryDatabases.SelectedItem = 0;
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            ClearTabs();
            DBEntity dBEntity = (cbQueryDatabases.SelectedItem as DBEntity);
            IList<DBEntity> tables = (cbQueryDatabases.SelectedItem as DBEntity).Database.Tables;

            foreach (var t in tables)
            {
                if (t.ToString() == "Kupac")
                {
                    Console.WriteLine(t.ToString());
                }
            }

            string rawQuery = tbQueryInput.Text;

            try
            {
                DataSet ds = RepositoryFactory.GetRepository().CreateQueryDataSet(rawQuery);
                DataTable dt = ds.Tables[0];
                if (dt.HasErrors)
                {
                    tbMessages.ForeColor = Color.Red;
                    tbMessages.Text = dt.GetErrors().ToString();
                }
                else
                {
                    dgResults.DataSource = dt;
                    tbMessages.ForeColor = Color.Black;
                    tbMessages.Text = $"({dt.Rows.Count} rows affected)";
                }
            }
            catch (Exception ex)
            {
                tbMessages.Text = ex.Message;
                tbMessages.ForeColor = Color.Red;
            }


        }

        private void ClearTabs()
        {
            dgResults.DataSource = null;
            tbMessages.Text = string.Empty;
            tbMessages.ForeColor = Color.Black;
        }
    }
}
