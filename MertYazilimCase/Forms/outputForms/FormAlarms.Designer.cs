namespace MertYazilimCase.Forms.outputForms
{
    partial class FormAlarms
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
            this.dataGridViewAlarms = new System.Windows.Forms.DataGridView();
            this.alarmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workStationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimumPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumPressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlarms
            // 
            this.dataGridViewAlarms.AutoGenerateColumns = false;
            this.dataGridViewAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlarms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alarmIdDataGridViewTextBoxColumn,
            this.workStationIdDataGridViewTextBoxColumn,
            this.minimumTemperatureDataGridViewTextBoxColumn,
            this.maximumTemperatureDataGridViewTextBoxColumn,
            this.minimumPressureDataGridViewTextBoxColumn,
            this.maximumPressureDataGridViewTextBoxColumn});
            this.dataGridViewAlarms.DataSource = this.alarmBindingSource;
            this.dataGridViewAlarms.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAlarms.Name = "dataGridViewAlarms";
            this.dataGridViewAlarms.RowHeadersWidth = 51;
            this.dataGridViewAlarms.RowTemplate.Height = 29;
            this.dataGridViewAlarms.Size = new System.Drawing.Size(756, 313);
            this.dataGridViewAlarms.TabIndex = 0;
            this.dataGridViewAlarms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAlarms_CellDoubleClick);
            // 
            // alarmIdDataGridViewTextBoxColumn
            // 
            this.alarmIdDataGridViewTextBoxColumn.DataPropertyName = "AlarmId";
            this.alarmIdDataGridViewTextBoxColumn.HeaderText = "AlarmId";
            this.alarmIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alarmIdDataGridViewTextBoxColumn.Name = "alarmIdDataGridViewTextBoxColumn";
            this.alarmIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // workStationIdDataGridViewTextBoxColumn
            // 
            this.workStationIdDataGridViewTextBoxColumn.DataPropertyName = "WorkStationId";
            this.workStationIdDataGridViewTextBoxColumn.HeaderText = "WorkStation Id";
            this.workStationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workStationIdDataGridViewTextBoxColumn.Name = "workStationIdDataGridViewTextBoxColumn";
            // 
            // minimumTemperatureDataGridViewTextBoxColumn
            // 
            this.minimumTemperatureDataGridViewTextBoxColumn.DataPropertyName = "MinimumTemperature";
            this.minimumTemperatureDataGridViewTextBoxColumn.HeaderText = "Minimum Temperature";
            this.minimumTemperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minimumTemperatureDataGridViewTextBoxColumn.Name = "minimumTemperatureDataGridViewTextBoxColumn";
            // 
            // maximumTemperatureDataGridViewTextBoxColumn
            // 
            this.maximumTemperatureDataGridViewTextBoxColumn.DataPropertyName = "MaximumTemperature";
            this.maximumTemperatureDataGridViewTextBoxColumn.HeaderText = "Maximum Temperature";
            this.maximumTemperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maximumTemperatureDataGridViewTextBoxColumn.Name = "maximumTemperatureDataGridViewTextBoxColumn";
            // 
            // minimumPressureDataGridViewTextBoxColumn
            // 
            this.minimumPressureDataGridViewTextBoxColumn.DataPropertyName = "MinimumPressure";
            this.minimumPressureDataGridViewTextBoxColumn.HeaderText = "Minimum Pressure";
            this.minimumPressureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minimumPressureDataGridViewTextBoxColumn.Name = "minimumPressureDataGridViewTextBoxColumn";
            // 
            // maximumPressureDataGridViewTextBoxColumn
            // 
            this.maximumPressureDataGridViewTextBoxColumn.DataPropertyName = "MaximumPressure";
            this.maximumPressureDataGridViewTextBoxColumn.HeaderText = "Maximum Pressure";
            this.maximumPressureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maximumPressureDataGridViewTextBoxColumn.Name = "maximumPressureDataGridViewTextBoxColumn";
            // 
            // alarmBindingSource
            // 
            this.alarmBindingSource.DataSource = typeof(MertYazilimCase.Data.Models.Alarm);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 331);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAlarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 369);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewAlarms);
            this.Name = "FormAlarms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarms";
            this.Load += new System.EventHandler(this.FormAlarms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewAlarms;
        private Button buttonAdd;
        private BindingSource alarmBindingSource;
        private DataGridViewTextBoxColumn alarmIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workStationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minimumTemperatureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maximumTemperatureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minimumPressureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maximumPressureDataGridViewTextBoxColumn;
    }
}