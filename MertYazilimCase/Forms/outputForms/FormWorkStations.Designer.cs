namespace MertYazilimCase.Forms.outputForms
{
    partial class FormWorkStations
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
            this.dataGridViewWorkStations = new System.Windows.Forms.DataGridView();
            this.workStationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workStationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewWorkStations
            // 
            this.dataGridViewWorkStations.AutoGenerateColumns = false;
            this.dataGridViewWorkStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorkStations.ColumnHeadersHeight = 29;
            this.dataGridViewWorkStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workStationIdDataGridViewTextBoxColumn,
            this.productLineIdDataGridViewTextBoxColumn,
            this.workStationNameDataGridViewTextBoxColumn,
            this.personelsDataGridViewTextBoxColumn,
            this.sensorsDataGridViewTextBoxColumn});
            this.dataGridViewWorkStations.DataSource = this.workStationBindingSource;
            this.dataGridViewWorkStations.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWorkStations.Name = "dataGridViewWorkStations";
            this.dataGridViewWorkStations.RowHeadersWidth = 51;
            this.dataGridViewWorkStations.RowTemplate.Height = 29;
            this.dataGridViewWorkStations.Size = new System.Drawing.Size(320, 241);
            this.dataGridViewWorkStations.TabIndex = 1;
            this.dataGridViewWorkStations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkStations_CellDoubleClick);
            // 
            // workStationIdDataGridViewTextBoxColumn
            // 
            this.workStationIdDataGridViewTextBoxColumn.DataPropertyName = "WorkStationId";
            this.workStationIdDataGridViewTextBoxColumn.HeaderText = "WorkStationId";
            this.workStationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workStationIdDataGridViewTextBoxColumn.Name = "workStationIdDataGridViewTextBoxColumn";
            this.workStationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productLineIdDataGridViewTextBoxColumn
            // 
            this.productLineIdDataGridViewTextBoxColumn.DataPropertyName = "ProductLineId";
            this.productLineIdDataGridViewTextBoxColumn.HeaderText = "Product Line Id";
            this.productLineIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productLineIdDataGridViewTextBoxColumn.Name = "productLineIdDataGridViewTextBoxColumn";
            // 
            // workStationNameDataGridViewTextBoxColumn
            // 
            this.workStationNameDataGridViewTextBoxColumn.DataPropertyName = "WorkStationName";
            this.workStationNameDataGridViewTextBoxColumn.HeaderText = "Work Station Name";
            this.workStationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workStationNameDataGridViewTextBoxColumn.Name = "workStationNameDataGridViewTextBoxColumn";
            // 
            // personelsDataGridViewTextBoxColumn
            // 
            this.personelsDataGridViewTextBoxColumn.DataPropertyName = "Personels";
            this.personelsDataGridViewTextBoxColumn.HeaderText = "Personels";
            this.personelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsDataGridViewTextBoxColumn.Name = "personelsDataGridViewTextBoxColumn";
            this.personelsDataGridViewTextBoxColumn.Visible = false;
            // 
            // sensorsDataGridViewTextBoxColumn
            // 
            this.sensorsDataGridViewTextBoxColumn.DataPropertyName = "Sensors";
            this.sensorsDataGridViewTextBoxColumn.HeaderText = "Sensors";
            this.sensorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sensorsDataGridViewTextBoxColumn.Name = "sensorsDataGridViewTextBoxColumn";
            this.sensorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // workStationBindingSource
            // 
            this.workStationBindingSource.DataSource = typeof(MertYazilimCase.Data.Models.WorkStation);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 259);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormWorkStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 301);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewWorkStations);
            this.Name = "FormWorkStations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Stations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWorkStations_FormClosed);
            this.Load += new System.EventHandler(this.FormWorkStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workStationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewWorkStations;
        private Button buttonAdd;
        private BindingSource workStationBindingSource;
        private DataGridViewTextBoxColumn workStationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productLineIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workStationNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personelsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sensorsDataGridViewTextBoxColumn;
    }
}