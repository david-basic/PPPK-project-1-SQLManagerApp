using SQLManagerApp.Dal;
using SQLManagerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLManagerApp
{
    public partial class MainForm : Form
    {
        private const string FileFilter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        private const string FileName = "{0}.xml";

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

        private void BtnXML_Click(object sender, EventArgs e)
        {
            DBEntity dBEntity;
            switch ((sender as Button).Name)
            {
                case nameof(BtnXMLTables):
                    dBEntity = lbTables.SelectedItem as DBEntity;
                    break;
                case nameof(BtnXMLViews):
                    dBEntity = lbViews.SelectedItem as DBEntity;
                    break;
                default:
                    throw new Exception("Error!");
            }
            var dialog = new SaveFileDialog()
            {
                FileName = string.Format(FileName, dBEntity.Name),
                Filter = FileFilter
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(dBEntity);
                ds.WriteXml(dialog.FileName, XmlWriteMode.WriteSchema);
            }

        }

        private void BtnSELECT_Click(object sender, EventArgs e)
        {
            DBEntity dBEntity;
            switch ((sender as Button).Name)
            {
                case nameof(btnSelectTables):
                    dBEntity = lbTables.SelectedItem as DBEntity;
                    break;
                case nameof(btnSelectViews):
                    dBEntity = lbViews.SelectedItem as DBEntity;
                    break;
                default:
                    throw new Exception("Error!");
            }
            DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(dBEntity);
            new SelectForm(ds.Tables[0]).ShowDialog();
        }

        private void BtnOpenQueryForm_Click(object sender, EventArgs e)
        {

        }
    }
}
