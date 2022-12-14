namespace SQLManagerApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTables = new System.Windows.Forms.ListBox();
            this.lbTableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbViews = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProcedureParams = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbProcedures = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbProcedureDefinition = new System.Windows.Forms.TextBox();
            this.BtnXMLTables = new System.Windows.Forms.Button();
            this.btnSelectTables = new System.Windows.Forms.Button();
            this.btnSelectViews = new System.Windows.Forms.Button();
            this.BtnXMLViews = new System.Windows.Forms.Button();
            this.btnOpenQueryForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(64, 30);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(166, 21);
            this.cbDatabases.TabIndex = 1;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables";
            // 
            // lbTables
            // 
            this.lbTables.FormattingEnabled = true;
            this.lbTables.Location = new System.Drawing.Point(64, 108);
            this.lbTables.Name = "lbTables";
            this.lbTables.Size = new System.Drawing.Size(166, 160);
            this.lbTables.TabIndex = 3;
            this.lbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // lbTableColumns
            // 
            this.lbTableColumns.FormattingEnabled = true;
            this.lbTableColumns.Location = new System.Drawing.Point(327, 108);
            this.lbTableColumns.Name = "lbTableColumns";
            this.lbTableColumns.Size = new System.Drawing.Size(166, 160);
            this.lbTableColumns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table columns";
            // 
            // lbViews
            // 
            this.lbViews.FormattingEnabled = true;
            this.lbViews.Location = new System.Drawing.Point(590, 108);
            this.lbViews.Name = "lbViews";
            this.lbViews.Size = new System.Drawing.Size(166, 160);
            this.lbViews.TabIndex = 7;
            this.lbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Views";
            // 
            // lbViewColumns
            // 
            this.lbViewColumns.FormattingEnabled = true;
            this.lbViewColumns.Location = new System.Drawing.Point(853, 108);
            this.lbViewColumns.Name = "lbViewColumns";
            this.lbViewColumns.Size = new System.Drawing.Size(166, 160);
            this.lbViewColumns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "View columns";
            // 
            // lbProcedureParams
            // 
            this.lbProcedureParams.FormattingEnabled = true;
            this.lbProcedureParams.Location = new System.Drawing.Point(853, 334);
            this.lbProcedureParams.Name = "lbProcedureParams";
            this.lbProcedureParams.Size = new System.Drawing.Size(166, 160);
            this.lbProcedureParams.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Procedure params";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Procedure definition";
            // 
            // lbProcedures
            // 
            this.lbProcedures.FormattingEnabled = true;
            this.lbProcedures.Location = new System.Drawing.Point(64, 334);
            this.lbProcedures.Name = "lbProcedures";
            this.lbProcedures.Size = new System.Drawing.Size(166, 160);
            this.lbProcedures.TabIndex = 11;
            this.lbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Procedures";
            // 
            // tbProcedureDefinition
            // 
            this.tbProcedureDefinition.Location = new System.Drawing.Point(327, 334);
            this.tbProcedureDefinition.Multiline = true;
            this.tbProcedureDefinition.Name = "tbProcedureDefinition";
            this.tbProcedureDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProcedureDefinition.Size = new System.Drawing.Size(429, 160);
            this.tbProcedureDefinition.TabIndex = 18;
            // 
            // BtnXMLTables
            // 
            this.BtnXMLTables.Location = new System.Drawing.Point(236, 186);
            this.BtnXMLTables.Name = "BtnXMLTables";
            this.BtnXMLTables.Size = new System.Drawing.Size(85, 38);
            this.BtnXMLTables.TabIndex = 19;
            this.BtnXMLTables.Text = "XML";
            this.BtnXMLTables.UseVisualStyleBackColor = true;
            this.BtnXMLTables.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // btnSelectTables
            // 
            this.btnSelectTables.Location = new System.Drawing.Point(236, 230);
            this.btnSelectTables.Name = "btnSelectTables";
            this.btnSelectTables.Size = new System.Drawing.Size(85, 38);
            this.btnSelectTables.TabIndex = 20;
            this.btnSelectTables.Text = "SELECT";
            this.btnSelectTables.UseVisualStyleBackColor = true;
            this.btnSelectTables.Click += new System.EventHandler(this.BtnSELECT_Click);
            // 
            // btnSelectViews
            // 
            this.btnSelectViews.Location = new System.Drawing.Point(762, 230);
            this.btnSelectViews.Name = "btnSelectViews";
            this.btnSelectViews.Size = new System.Drawing.Size(85, 38);
            this.btnSelectViews.TabIndex = 22;
            this.btnSelectViews.Text = "SELECT";
            this.btnSelectViews.UseVisualStyleBackColor = true;
            this.btnSelectViews.Click += new System.EventHandler(this.BtnSELECT_Click);
            // 
            // BtnXMLViews
            // 
            this.BtnXMLViews.Location = new System.Drawing.Point(762, 186);
            this.BtnXMLViews.Name = "BtnXMLViews";
            this.BtnXMLViews.Size = new System.Drawing.Size(85, 38);
            this.BtnXMLViews.TabIndex = 21;
            this.BtnXMLViews.Text = "XML";
            this.BtnXMLViews.UseVisualStyleBackColor = true;
            this.BtnXMLViews.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // btnOpenQueryForm
            // 
            this.btnOpenQueryForm.Location = new System.Drawing.Point(64, 536);
            this.btnOpenQueryForm.Name = "btnOpenQueryForm";
            this.btnOpenQueryForm.Size = new System.Drawing.Size(97, 48);
            this.btnOpenQueryForm.TabIndex = 23;
            this.btnOpenQueryForm.Text = "Make a query";
            this.btnOpenQueryForm.UseVisualStyleBackColor = true;
            this.btnOpenQueryForm.Click += new System.EventHandler(this.BtnOpenQueryForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1081, 682);
            this.Controls.Add(this.btnOpenQueryForm);
            this.Controls.Add(this.btnSelectViews);
            this.Controls.Add(this.BtnXMLViews);
            this.Controls.Add(this.btnSelectTables);
            this.Controls.Add(this.BtnXMLTables);
            this.Controls.Add(this.tbProcedureDefinition);
            this.Controls.Add(this.lbProcedureParams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbProcedures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbViews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTableColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTables;
        private System.Windows.Forms.ListBox lbTableColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbViews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbProcedureParams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbProcedures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbProcedureDefinition;
        private System.Windows.Forms.Button BtnXMLTables;
        private System.Windows.Forms.Button btnSelectTables;
        private System.Windows.Forms.Button btnSelectViews;
        private System.Windows.Forms.Button BtnXMLViews;
        private System.Windows.Forms.Button btnOpenQueryForm;
    }
}

