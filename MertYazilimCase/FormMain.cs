using MertYazilimCase.Business;
using MertYazilimCase.Data.DataLayer;
using MertYazilimCase.Data.Models;
using MertYazilimCase.Forms.inputForms;
using MertYazilimCase.Forms.outputForms;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace MertYazilimCase
{
    public partial class FormMain : Form
    {
        public ILogger _logger;
        public DataGridViewRow _selectedRow { get; set; }
        private GenericRepository<Sensor> sensorRepository;
        private GenericRepository<WorkStation> workStationRepository;
        private GenericRepository<Alarm> alarmRepository;
        private GenericRepository<Personel> personelRepository;

        public FormMain(ILogger<FormMain> logger)
        {
            _logger = logger;
            _logger.LogInformation("FormMain {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
            InitializeComponent();
            DatabaseContext context = new DatabaseContext();
            this.sensorRepository = new GenericRepository<Sensor>(context);
            this.workStationRepository = new GenericRepository<WorkStation>(context);
            this.alarmRepository = new GenericRepository<Alarm>(context);
            this.personelRepository = new GenericRepository<Personel>(context);
            Repaint();
        }
        private void Repaint()
        {
            radioButtonProductLines.Checked = true;
            labelFilter.Text = "Product Line:";
            textBoxFilter2.Visible = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshDBGrid();
        }
        public void RefreshDBGrid()
        {
            dataGridViewSensors.AllowUserToAddRows = false;
            dataGridViewSensors.AllowUserToDeleteRows = false;
            dataGridViewSensors.ReadOnly = true;

            dataGridViewSensors.DataSource = sensorRepository.GetEntity(); ;
            _logger.LogInformation("dataGridViewFormSensors {BusinessLayerEvent} at {dateTime}", "Gathered", DateTime.UtcNow);
        }
        private void productLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductLines formProductLines = new FormProductLines(this);
            _logger.LogInformation("FormProductLines {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
            formProductLines.Show();
        }
        private void workStationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkStations formWorkStations = new FormWorkStations(this);
            _logger.LogInformation("FormWorkStations {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
            formWorkStations.Show();
        }
        private void personelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonels formPersonels = new FormPersonels(this);
            _logger.LogInformation("FormPersonels {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
            formPersonels.Show();
        }
        private void alarmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlarms formAlarms = new FormAlarms(this);
            _logger.LogInformation("FormAlarms {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
            formAlarms.Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("FormMain {BusinessLayerEvent} at {dateTime}", "Ended", DateTime.UtcNow);
                this.Close();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new NotImplementedException();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSensor formSensor = new FormSensor(this);
            _logger.LogInformation("FormSensor {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
            formSensor.Show();

        }
        private void dataGridViewFormSensors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dataGridViewSensors.Rows[e.RowIndex];
                FormSensor formSensor = new FormSensor(this);
                formSensor.Show();
            }
        }
        private void radioButtonProductLines_CheckedChanged(object sender, EventArgs e)
        {
            labelFilter.Text = "Product Line:";
            textBoxFilter2.Visible = false;
        }
        private void radioButtonWorkStations_CheckedChanged(object sender, EventArgs e)
        {
            labelFilter.Text = "Work Station:";
            textBoxFilter2.Visible = false;
        }
        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            labelFilter.Text = "Date Between:";
            textBoxFilter2.Visible = true;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (buttonFilter.Text == "Filter")
            {
                if (labelFilter.Text == "Product Line:")
                {
                    if (textBoxFilter1.Text != "")
                    {
                        var workStations = workStationRepository.GetEntity(b => b.ProductLineId == int.Parse(textBoxFilter1.Text));
                        List<Sensor> sensors = new List<Sensor>();

                        foreach (var workStation in workStations)
                        {
                            var filteredSensors = sensorRepository.GetEntity(b => b.WorkStationId == workStation.WorkStationId).ToList();
                            sensors.Add(new Sensor(filteredSensors));
                        }
                        dataGridViewSensors.DataSource = sensors;
                        _logger.LogInformation("dataGridViewFormSensors {BusinessLayerEvent} at {dateTime}", "Filtered by Product Line", DateTime.UtcNow);
                    buttonFilter.Text = "Go Back";
                    }
                }
                else if (labelFilter.Text == "Work Station:")
                {
                    if (textBoxFilter1.Text != "")
                    {
                        var filteredSensors = workStationRepository.GetEntity(b => b.WorkStationId == int.Parse(textBoxFilter1.Text));
                        dataGridViewSensors.DataSource = filteredSensors;
                        _logger.LogInformation("dataGridViewFormSensors {BusinessLayerEvent} at {dateTime}", "Filtered by Work Station", DateTime.UtcNow);
                    buttonFilter.Text = "Go Back";
                    }
                }
                else if (labelFilter.Text == "Date Between:")
                {
                    if (textBoxFilter1.Text != "" && textBoxFilter2.Text != "")
                    {
                        using (var context = new DatabaseContext())
                        {
                            var filteredSensors = sensorRepository.GetEntity(b => b.Date >= DateTime.Parse(textBoxFilter1.Text)
                                                                && b.Date <= DateTime.Parse(textBoxFilter2.Text)
                                                                );
                            dataGridViewSensors.DataSource = filteredSensors;
                            _logger.LogInformation("dataGridViewFormSensors {BusinessLayerEvent} at {dateTime}", "Filtered by Date", DateTime.UtcNow);
                        }
                        buttonFilter.Text = "Go Back";
                    }
                }
            }
            else if(buttonFilter.Text == "Go Back")
            {
                RefreshDBGrid();
                buttonFilter.Text = "Filter";
                textBoxFilter1.Clear();
                textBoxFilter2.Clear();
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.sensorRepository.Dispose();
            this.workStationRepository.Dispose();
            this.alarmRepository.Dispose();
            this.personelRepository.Dispose();
        }
    }
}