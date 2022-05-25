namespace MertYazilimCase.Forms.inputForms
{
    partial class FormWorkStation
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProductLines = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWorkStationName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(22, 127);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 29);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Add";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Line:";
            // 
            // comboBoxProductLines
            // 
            this.comboBoxProductLines.FormattingEnabled = true;
            this.comboBoxProductLines.Location = new System.Drawing.Point(169, 34);
            this.comboBoxProductLines.Name = "comboBoxProductLines";
            this.comboBoxProductLines.Size = new System.Drawing.Size(182, 28);
            this.comboBoxProductLines.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Work Station Name:";
            // 
            // textBoxWorkStationName
            // 
            this.textBoxWorkStationName.Location = new System.Drawing.Point(169, 68);
            this.textBoxWorkStationName.Name = "textBoxWorkStationName";
            this.textBoxWorkStationName.Size = new System.Drawing.Size(182, 27);
            this.textBoxWorkStationName.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(257, 127);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(363, 175);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxWorkStationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProductLines);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSubmit);
            this.Name = "FormWorkStation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Work Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWorkStation_FormClosed);
            this.Load += new System.EventHandler(this.formWorkStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonSubmit;
        private Label label5;
        private ComboBox comboBoxProductLines;
        private Label label1;
        private TextBox textBoxWorkStationName;
        private Button buttonDelete;
    }
}