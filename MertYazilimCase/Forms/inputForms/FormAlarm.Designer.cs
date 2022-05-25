namespace MertYazilimCase.Forms.inputForms
{
    partial class FormAlarm
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxWorkStations = new System.Windows.Forms.ComboBox();
            this.textBoxMinimumTemperature = new System.Windows.Forms.TextBox();
            this.textBoxMaximumTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxMinimumPressure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaximumPressure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work Station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum Temperature:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 226);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 29);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Add";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxWorkStations
            // 
            this.comboBoxWorkStations.FormattingEnabled = true;
            this.comboBoxWorkStations.Location = new System.Drawing.Point(180, 31);
            this.comboBoxWorkStations.Name = "comboBoxWorkStations";
            this.comboBoxWorkStations.Size = new System.Drawing.Size(151, 28);
            this.comboBoxWorkStations.TabIndex = 0;
            // 
            // textBoxMinimumTemperature
            // 
            this.textBoxMinimumTemperature.Location = new System.Drawing.Point(180, 64);
            this.textBoxMinimumTemperature.Name = "textBoxMinimumTemperature";
            this.textBoxMinimumTemperature.Size = new System.Drawing.Size(151, 27);
            this.textBoxMinimumTemperature.TabIndex = 1;
            this.textBoxMinimumTemperature.TextChanged += new System.EventHandler(this.textBoxMinimumTemperature_TextChanged);
            // 
            // textBoxMaximumTemperature
            // 
            this.textBoxMaximumTemperature.Location = new System.Drawing.Point(180, 97);
            this.textBoxMaximumTemperature.Name = "textBoxMaximumTemperature";
            this.textBoxMaximumTemperature.Size = new System.Drawing.Size(151, 27);
            this.textBoxMaximumTemperature.TabIndex = 2;
            this.textBoxMaximumTemperature.TextChanged += new System.EventHandler(this.textBoxMaximumTemperature_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maximum Temperature:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(238, 226);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxMinimumPressure
            // 
            this.textBoxMinimumPressure.Location = new System.Drawing.Point(180, 130);
            this.textBoxMinimumPressure.Name = "textBoxMinimumPressure";
            this.textBoxMinimumPressure.Size = new System.Drawing.Size(151, 27);
            this.textBoxMinimumPressure.TabIndex = 3;
            this.textBoxMinimumPressure.TextChanged += new System.EventHandler(this.textBoxMinimumPressure_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minimum Pressure:";
            // 
            // textBoxMaximumPressure
            // 
            this.textBoxMaximumPressure.Location = new System.Drawing.Point(180, 163);
            this.textBoxMaximumPressure.Name = "textBoxMaximumPressure";
            this.textBoxMaximumPressure.Size = new System.Drawing.Size(151, 27);
            this.textBoxMaximumPressure.TabIndex = 4;
            this.textBoxMaximumPressure.TextChanged += new System.EventHandler(this.textBoxMaximumPressure_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximum Pressure:";
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(344, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaximumPressure);
            this.Controls.Add(this.textBoxMinimumPressure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxMaximumTemperature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMinimumTemperature);
            this.Controls.Add(this.comboBoxWorkStations);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Alarm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAlarm_FormClosed);
            this.Load += new System.EventHandler(this.FormAlarm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonSubmit;
        private ComboBox comboBoxWorkStations;
        private TextBox textBoxMinimumTemperature;
        private TextBox textBoxMaximumTemperature;
        private Label label3;
        private Button buttonDelete;
        private TextBox textBoxMinimumPressure;
        private Label label4;
        private TextBox textBoxMaximumPressure;
        private Label label5;
    }
}