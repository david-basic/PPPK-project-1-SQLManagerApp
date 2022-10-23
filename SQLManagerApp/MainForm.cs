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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearForm();

            lbTables.DataSource = (cbDatabases.SelectedItem as Database).Tables;
            lbViews .DataSource = (cbDatabases.SelectedItem as Database).Views;
            lbProcedures .DataSource = (cbDatabases.SelectedItem as Database).Procedures;
        }

        private void LbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTableColumns.DataSource = (lbTables.SelectedItem as DBEntity).Columns;
        }

        private void LbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbViewColumns.DataSource = (lbViews.SelectedItem as DBEntity).Columns;
        }

        private void LbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbProcedureDefinition.Text = (lbProcedures.SelectedItem as Procedure).Definition;
            lbProcedureParams.DataSource = (lbProcedures.SelectedItem as Procedure).ProcedureParams;
        }

        private void ClearForm()
        {
            lbTableColumns.DataSource = null;
            lbViewColumns.DataSource = null;
            lbProcedureParams.DataSource = null;
            tbProcedureDefinition.Text = string.Empty;
        }
    }
}
