namespace MertYazilimCase
{
    partial class FormProductLines
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
            this.dataGridViewProductLines = new System.Windows.Forms.DataGridView();
            this.productLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.productLineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductLines
            // 
            this.dataGridViewProductLines.AutoGenerateColumns = false;
            this.dataGridViewProductLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productLineNameDataGridViewTextBoxColumn,
            this.productLineIdDataGridViewTextBoxColumn});
            this.dataGridViewProductLines.DataSource = this.productLineBindingSource;
            this.dataGridViewProductLines.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewProductLines.Name = "dataGridViewProductLines";
            this.dataGridViewProductLines.RowHeadersWidth = 51;
            this.dataGridViewProductLines.RowTemplate.Height = 29;
            this.dataGridViewProductLines.Size = new System.Drawing.Size(274, 181);
            this.dataGridViewProductLines.TabIndex = 0;
            this.dataGridViewProductLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductLines_CellContentClick);
            this.dataGridViewProductLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductLines_CellDoubleClick);
            // 
            // productLineBindingSource
            // 
            this.productLineBindingSource.DataSource = typeof(MertYazilimCase.Data.Models.ProductLine);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 202);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // productLineNameDataGridViewTextBoxColumn
            // 
            this.productLineNameDataGridViewTextBoxColumn.DataPropertyName = "ProductLineName";
            this.productLineNameDataGridViewTextBoxColumn.HeaderText = "Product Line Name";
            this.productLineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productLineNameDataGridViewTextBoxColumn.Name = "productLineNameDataGridViewTextBoxColumn";
            // 
            // productLineIdDataGridViewTextBoxColumn
            // 
            this.productLineIdDataGridViewTextBoxColumn.DataPropertyName = "ProductLineId";
            this.productLineIdDataGridViewTextBoxColumn.HeaderText = "ProductLineId";
            this.productLineIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productLineIdDataGridViewTextBoxColumn.Name = "productLineIdDataGridViewTextBoxColumn";
            this.productLineIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormProductLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(298, 243);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewProductLines);
            this.Name = "FormProductLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Lines";
            this.Load += new System.EventHandler(this.FormProductLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewProductLines;
        private Button buttonAdd;
        private BindingSource productLineBindingSource;
        private DataGridViewTextBoxColumn productLineNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productLineIdDataGridViewTextBoxColumn;
    }
}