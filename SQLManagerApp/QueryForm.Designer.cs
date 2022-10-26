namespace SQLManagerApp
{
    partial class QueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbQueryInput = new System.Windows.Forms.TextBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabQueryResultsAndMessages = new System.Windows.Forms.TabControl();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.lblDB = new System.Windows.Forms.Label();
            this.cbQueryDatabases = new System.Windows.Forms.ComboBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabQueryResultsAndMessages.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQueryInput
            // 
            this.tbQueryInput.Location = new System.Drawing.Point(12, 37);
            this.tbQueryInput.Multiline = true;
            this.tbQueryInput.Name = "tbQueryInput";
            this.tbQueryInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQueryInput.Size = new System.Drawing.Size(1163, 299);
            this.tbQueryInput.TabIndex = 0;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(13, 342);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(75, 23);
            this.btnRunQuery.TabIndex = 1;
            this.btnRunQuery.Text = "Run query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabQueryResultsAndMessages);
            this.panel1.Location = new System.Drawing.Point(13, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 245);
            this.panel1.TabIndex = 2;
            // 
            // tabQueryResultsAndMessages
            // 
            this.tabQueryResultsAndMessages.Controls.Add(this.tabPageResults);
            this.tabQueryResultsAndMessages.Controls.Add(this.tabPageMessages);
            this.tabQueryResultsAndMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQueryResultsAndMessages.Location = new System.Drawing.Point(0, 0);
            this.tabQueryResultsAndMessages.Name = "tabQueryResultsAndMessages";
            this.tabQueryResultsAndMessages.SelectedIndex = 0;
            this.tabQueryResultsAndMessages.Size = new System.Drawing.Size(1162, 245);
            this.tabQueryResultsAndMessages.TabIndex = 0;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.dgResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(1154, 219);
            this.tabPageResults.TabIndex = 0;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.tbMessages);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(1154, 219);
            this.tabPageMessages.TabIndex = 1;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // tbMessages
            // 
            this.tbMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessages.Location = new System.Drawing.Point(3, 3);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(1148, 213);
            this.tbMessages.TabIndex = 0;
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(13, 13);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(61, 13);
            this.lblDB.TabIndex = 3;
            this.lblDB.Text = "Databases:";
            // 
            // cbQueryDatabases
            // 
            this.cbQueryDatabases.FormattingEnabled = true;
            this.cbQueryDatabases.Location = new System.Drawing.Point(80, 10);
            this.cbQueryDatabases.Name = "cbQueryDatabases";
            this.cbQueryDatabases.Size = new System.Drawing.Size(173, 21);
            this.cbQueryDatabases.TabIndex = 4;
            // 
            // dgResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(3, 3);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.Size = new System.Drawing.Size(1148, 213);
            this.dgResults.TabIndex = 0;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 637);
            this.Controls.Add(this.cbQueryDatabases);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.tbQueryInput);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabQueryResultsAndMessages.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            this.tabPageMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQueryInput;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabQueryResultsAndMessages;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.ComboBox cbQueryDatabases;
        private System.Windows.Forms.DataGridView dgResults;
    }
}