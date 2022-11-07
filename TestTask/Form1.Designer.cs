
namespace TestTask
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Sorting sorting2 = new DevExpress.DataAccess.Sql.Sorting();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNazwaEksportyu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataEksportu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzinaEksportu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazwaUzytkownika = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazwaLokalu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(230, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(526, 291);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(5, 10);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(516, 276);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "TestDB.mdf";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression7.ColumnName = "NazwaEksportyu";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"183\" />";
            table2.Name = "Table";
            columnExpression7.Table = table2;
            column6.Expression = columnExpression7;
            columnExpression8.ColumnName = "DataEksportu";
            columnExpression8.Table = table2;
            column7.Expression = columnExpression8;
            columnExpression9.ColumnName = "GodzinaEksportu";
            columnExpression9.Table = table2;
            column8.Expression = columnExpression9;
            columnExpression10.ColumnName = "NazwaUzytkownika";
            columnExpression10.Table = table2;
            column9.Expression = columnExpression10;
            columnExpression11.ColumnName = "NazwaLokalu";
            columnExpression11.Table = table2;
            column10.Expression = columnExpression11;
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.FilterString = "";
            selectQuery2.Name = "Query";
            columnExpression12.ColumnName = "DataEksportu";
            columnExpression12.Table = table2;
            sorting2.Expression = columnExpression12;
            selectQuery2.Sorting.Add(sorting2);
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNazwaEksportyu,
            this.colDataEksportu,
            this.colGodzinaEksportu,
            this.colNazwaUzytkownika,
            this.colNazwaLokalu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colNazwaEksportyu
            // 
            this.colNazwaEksportyu.Caption = "Nazwa";
            this.colNazwaEksportyu.FieldName = "NazwaEksportyu";
            this.colNazwaEksportyu.Name = "colNazwaEksportyu";
            this.colNazwaEksportyu.Visible = true;
            this.colNazwaEksportyu.VisibleIndex = 0;
            // 
            // colDataEksportu
            // 
            this.colDataEksportu.Caption = "Data";
            this.colDataEksportu.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colDataEksportu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataEksportu.FieldName = "DataEksportu";
            this.colDataEksportu.Name = "colDataEksportu";
            this.colDataEksportu.Visible = true;
            this.colDataEksportu.VisibleIndex = 1;
            // 
            // colGodzinaEksportu
            // 
            this.colGodzinaEksportu.Caption = "Godzina";
            this.colGodzinaEksportu.FieldName = "GodzinaEksportu";
            this.colGodzinaEksportu.Name = "colGodzinaEksportu";
            this.colGodzinaEksportu.Visible = true;
            this.colGodzinaEksportu.VisibleIndex = 2;
            // 
            // colNazwaUzytkownika
            // 
            this.colNazwaUzytkownika.Caption = "Użytkownik";
            this.colNazwaUzytkownika.FieldName = "NazwaUzytkownika";
            this.colNazwaUzytkownika.Name = "colNazwaUzytkownika";
            this.colNazwaUzytkownika.Visible = true;
            this.colNazwaUzytkownika.VisibleIndex = 3;
            // 
            // colNazwaLokalu
            // 
            this.colNazwaLokalu.Caption = "Lokal";
            this.colNazwaLokalu.FieldName = "NazwaLokalu";
            this.colNazwaLokalu.Name = "colNazwaLokalu";
            this.colNazwaLokalu.Visible = true;
            this.colNazwaLokalu.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelControl2.Controls.Add(this.comboBoxEdit1);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.comboBoxEdit2);
            this.panelControl2.Controls.Add(this.comboBoxEdit3);
            this.panelControl2.Location = new System.Drawing.Point(12, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(212, 291);
            this.panelControl2.TabIndex = 1;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(17, 20);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Lokal 1",
            "Lokal 2",
            "Lokal 3"});
            this.comboBoxEdit1.Properties.NullText = "Lokal:";
            this.comboBoxEdit1.Size = new System.Drawing.Size(179, 20);
            this.comboBoxEdit1.TabIndex = 1;
            this.comboBoxEdit1.SelectedValueChanged += new System.EventHandler(this.comboBoxEdit1_SelectedValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(5, 263);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(202, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Zatwierdź";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = null;
            this.comboBoxEdit2.Location = new System.Drawing.Point(17, 46);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.comboBoxEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.comboBoxEdit2.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.comboBoxEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.comboBoxEdit2.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.comboBoxEdit2.Properties.NullText = "Od:";
            this.comboBoxEdit2.Size = new System.Drawing.Size(179, 20);
            this.comboBoxEdit2.TabIndex = 2;
            this.comboBoxEdit2.EditValueChanged += new System.EventHandler(this.comboBoxEdit2_EditValueChanged);
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.EditValue = null;
            this.comboBoxEdit3.Location = new System.Drawing.Point(17, 72);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.comboBoxEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.comboBoxEdit3.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.comboBoxEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.comboBoxEdit3.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.comboBoxEdit3.Properties.NullText = "Do:";
            this.comboBoxEdit3.Size = new System.Drawing.Size(179, 20);
            this.comboBoxEdit3.TabIndex = 3;
            this.comboBoxEdit3.EditValueChanged += new System.EventHandler(this.comboBoxEdit3_EditValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 305);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwaEksportyu;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEksportu;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwaUzytkownika;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwaLokalu;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.DateEdit comboBoxEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzinaEksportu;
        private DevExpress.XtraEditors.DateEdit comboBoxEdit3;
    }
}

