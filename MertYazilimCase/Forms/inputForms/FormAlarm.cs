using MertYazilimCase.Business;
using MertYazilimCase.Data.DataLayer;
using MertYazilimCase.Data.Models;
using MertYazilimCase.Forms.outputForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertYazilimCase.Forms.inputForms
{

    public partial class FormAlarm : Form
    {
        public readonly FormAlarms formAlarms;
        private GenericRepository<Alarm> alarmRepository;
        private GenericRepository<WorkStation> workStationRepository;
        public FormAlarm(FormAlarms frm)
        {
            InitializeComponent();
            formAlarms = frm;
            DatabaseContext context = new DatabaseContext();
            this.alarmRepository = new GenericRepository<Alarm>(context);
            this.workStationRepository = new GenericRepository<WorkStation>(context);
        }
        private void FormAlarm_Load(object sender, EventArgs e)
        {
            comboBoxWorkStations.DataSource = workStationRepository.GetEntity();
            comboBoxWorkStations.ValueMember = "WorkStationId";
            comboBoxWorkStations.DisplayMember = "WorkStationName";
            comboBoxWorkStations.DropDownStyle = ComboBoxStyle.DropDownList;

            if (formAlarms._selectedRow != null)
            {
                buttonDelete.Visible = true;
                buttonSubmit.Text = "Edit";

                comboBoxWorkStations.Enabled = false;
                textBoxMinimumTemperature.Enabled = false;
                textBoxMaximumTemperature.Enabled = false;
                textBoxMinimumPressure.Enabled = false;
                textBoxMaximumPressure.Enabled = false;

                comboBoxWorkStations.SelectedValue = formAlarms._selectedRow.Cells[1].Value;
                textBoxMinimumTemperature.Text = formAlarms._selectedRow.Cells[2].Value.ToString();
                textBoxMaximumTemperature.Text = formAlarms._selectedRow.Cells[3].Value.ToString();
                textBoxMinimumPressure.Text = formAlarms._selectedRow.Cells[4].Value.ToString();
                textBoxMaximumPressure.Text = formAlarms._selectedRow.Cells[5].Value.ToString();
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (buttonSubmit.Text == "Add")
            {
                var alarm = new Alarm()
                {
                    WorkStationId = int.Parse(comboBoxWorkStations.SelectedValue.ToString()),
                    MinimumTemperature = double.Parse(textBoxMinimumTemperature.Text),
                    MaximumTemperature = double.Parse(textBoxMaximumTemperature.Text),
                    MinimumPressure = double.Parse(textBoxMinimumPressure.Text),
                    MaximumPressure = double.Parse(textBoxMaximumPressure.Text)
                };
                alarmRepository.Insert(alarm);
                alarmRepository.Save();
                formAlarms.RefreshDBGrid();

                this.alarmRepository.Dispose();
                this.workStationRepository.Dispose(); 
                this.Close();
            }
            else if (buttonSubmit.Text == "Edit")
            {
                comboBoxWorkStations.Enabled = true;
                textBoxMinimumTemperature.Enabled = true;
                textBoxMaximumTemperature.Enabled = true;
                textBoxMinimumPressure.Enabled = true;
                textBoxMaximumPressure.Enabled = true;
                buttonSubmit.Text = "Update";
            }
            else if (buttonSubmit.Text == "Update")
            {
                var result = alarmRepository.GetEntityByID((int)formAlarms._selectedRow.Cells[0].Value);
                if (result != null)
                {
                    result.WorkStationId = int.Parse(comboBoxWorkStations.SelectedValue.ToString());
                    result.MinimumTemperature = double.Parse(textBoxMinimumTemperature.Text);
                    result.MaximumTemperature = double.Parse(textBoxMaximumTemperature.Text);
                    result.MinimumPressure = double.Parse(textBoxMinimumPressure.Text);
                    result.MaximumPressure = double.Parse(textBoxMaximumPressure.Text);

                    alarmRepository.Update(result);
                    alarmRepository.Save();
                    
                    formAlarms.RefreshDBGrid();
                    formAlarms._selectedRow = null;

                    this.alarmRepository.Dispose();
                    this.workStationRepository.Dispose();
                    this.Close();
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected entry from the database?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow row = formAlarms._selectedRow;
                alarmRepository.Delete((int)row.Cells[0].Value);
                alarmRepository.Save();
          
                formAlarms.RefreshDBGrid();
                formAlarms._selectedRow = null;

                this.alarmRepository.Dispose();
                this.workStationRepository.Dispose();
                this.Close();
            }
        }
        private void FormAlarm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAlarms._selectedRow = null;
            this.alarmRepository.Dispose();
            this.workStationRepository.Dispose();
        }
        private void textBoxMinimumTemperature_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl) && textBoxMinimumTemperature.Text != "")
            {
                textBoxMinimumTemperature.Clear();
                MessageBox.Show("Enter only Numerical Values");
            }
        }
        private void textBoxMaximumTemperature_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl) && textBoxMaximumTemperature.Text != "")
            {
                textBoxMaximumTemperature.Clear();
                MessageBox.Show("Enter only Numerical Values");
            }
        }
        private void textBoxMinimumPressure_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl) && textBoxMinimumPressure.Text != "")
            {
                textBoxMinimumPressure.Clear();
                MessageBox.Show("Enter only Numerical Values");
            }
        }
        private void textBoxMaximumPressure_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl) && textBoxMaximumPressure.Text != "")
            {
                textBoxMaximumPressure.Clear();
                MessageBox.Show("Enter only Numerical Values");
            }
        }
    }
}
