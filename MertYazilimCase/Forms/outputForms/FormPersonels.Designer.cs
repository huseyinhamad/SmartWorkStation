namespace MertYazilimCase.Forms.outputForms
{
    partial class FormPersonels
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
            this.dataGridViewPersonels = new System.Windows.Forms.DataGridView();
            this.personelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonels
            // 
            this.dataGridViewPersonels.AutoGenerateColumns = false;
            this.dataGridViewPersonels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIdDataGridViewTextBoxColumn,
            this.personelNameDataGridViewTextBoxColumn,
            this.personelMailDataGridViewTextBoxColumn,
            this.workStationIdDataGridViewTextBoxColumn,
            this.workStationsDataGridViewTextBoxColumn});
            this.dataGridViewPersonels.DataSource = this.personelBindingSource;
            this.dataGridViewPersonels.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPersonels.Name = "dataGridViewPersonels";
            this.dataGridViewPersonels.RowHeadersWidth = 51;
            this.dataGridViewPersonels.RowTemplate.Height = 29;
            this.dataGridViewPersonels.Size = new System.Drawing.Size(523, 291);
            this.dataGridViewPersonels.TabIndex = 0;
            this.dataGridViewPersonels.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersonels_CellDoubleClick);
            // 
            // personelIdDataGridViewTextBoxColumn
            // 
            this.personelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.HeaderText = "PersonelId";
            this.personelIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIdDataGridViewTextBoxColumn.Name = "personelIdDataGridViewTextBoxColumn";
            this.personelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelNameDataGridViewTextBoxColumn
            // 
            this.personelNameDataGridViewTextBoxColumn.DataPropertyName = "PersonelName";
            this.personelNameDataGridViewTextBoxColumn.HeaderText = "Personel Name";
            this.personelNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelNameDataGridViewTextBoxColumn.Name = "personelNameDataGridViewTextBoxColumn";
            // 
            // personelMailDataGridViewTextBoxColumn
            // 
            this.personelMailDataGridViewTextBoxColumn.DataPropertyName = "PersonelMail";
            this.personelMailDataGridViewTextBoxColumn.HeaderText = "Personel Mail";
            this.personelMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelMailDataGridViewTextBoxColumn.Name = "personelMailDataGridViewTextBoxColumn";
            // 
            // workStationIdDataGridViewTextBoxColumn
            // 
            this.workStationIdDataGridViewTextBoxColumn.DataPropertyName = "WorkStationId";
            this.workStationIdDataGridViewTextBoxColumn.HeaderText = "Work Station Id";
            this.workStationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workStationIdDataGridViewTextBoxColumn.Name = "workStationIdDataGridViewTextBoxColumn";
            // 
            // workStationsDataGridViewTextBoxColumn
            // 
            this.workStationsDataGridViewTextBoxColumn.DataPropertyName = "WorkStations";
            this.workStationsDataGridViewTextBoxColumn.HeaderText = "WorkStations";
            this.workStationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workStationsDataGridViewTextBoxColumn.Name = "workStationsDataGridViewTextBoxColumn";
            this.workStationsDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataSource = typeof(MertYazilimCase.Data.Models.Personel);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 309);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormPersonels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 346);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewPersonels);
            this.Name = "FormPersonels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personels";
            this.Load += new System.EventHandler(this.FormPersonels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewPersonels;
        private Button buttonAdd;
        private BindingSource personelBindingSource;
        private DataGridViewTextBoxColumn personelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelMailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workStationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workStationsDataGridViewTextBoxColumn;
    }
}