using MertYazilimCase.Data.BusinessLayer;
using MertYazilimCase.Data.DataLayer;
using MertYazilimCase.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertYazilimCase.Forms.inputForms
{
    public partial class FormSensor : Form
    {
        public readonly FormMain formMain;
        private GenericRepository<Sensor> sensorRepository;
        private GenericRepository<WorkStation> workStationRepository;
        public FormSensor(FormMain frm)
        {
            InitializeComponent();
            formMain = frm;
            DatabaseContext context = new DatabaseContext();
            this.sensorRepository = new GenericRepository<Sensor>(context);
            this.workStationRepository = new GenericRepository<WorkStation>(context);
        }
        private void FormSensor_Load(object sender, EventArgs e)
        {
            comboBoxWorkStations.DataSource = sensorRepository.GetEntity();
            comboBoxWorkStations.ValueMember = "WorkStationId";
            comboBoxWorkStations.DisplayMember = "WorkStationName";
            comboBoxWorkStations.DropDownStyle = ComboBoxStyle.DropDownList;

            if (formMain._selectedRow != null)
            {
                buttonDelete.Visible = true;
                buttonSubmit.Text = "Edit";

                comboBoxWorkStations.Enabled = false;
                textBoxTemperature.Enabled = false;
                textBoxPressure.Enabled = false;
                checkBoxStatus.Enabled = false;

                comboBoxWorkStations.SelectedValue = formMain._selectedRow.Cells[1].Value;
                textBoxTemperature.Text = formMain._selectedRow.Cells[2].Value.ToString();
                textBoxPressure.Text = formMain._selectedRow.Cells[3].Value.ToString();
                checkBoxStatus.Checked = (bool)formMain._selectedRow.Cells[4].Value;
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (buttonSubmit.Text == "Add")
            {
                var sensor = new Sensor()
                {
                    WorkStationId = int.Parse(comboBoxWorkStations.SelectedValue.ToString()),
                    Temperature = double.Parse(textBoxTemperature.Text),
                    Pressure = double.Parse(textBoxPressure.Text),
                    Status = checkBoxStatus.Checked,
                    Date = DateTime.UtcNow
                };
                sensorRepository.Insert(sensor);
                sensorRepository.Save();
                checkSensorValues();

                formMain.RefreshDBGrid();
                this.Close();
            }
            else if (buttonSubmit.Text == "Edit")
            {
                comboBoxWorkStations.Enabled = true;
                textBoxTemperature.Enabled = true;
                textBoxPressure.Enabled = true;
                checkBoxStatus.Enabled = true;
                buttonSubmit.Text = "Update";
            }
            else if (buttonSubmit.Text == "Update")
            {
                var result = sensorRepository.GetEntityByID((int)formMain._selectedRow.Cells[0].Value);
                if (result != null)
                {
                    result.WorkStationId = int.Parse(comboBoxWorkStations.SelectedValue.ToString());
                    result.Temperature = double.Parse(textBoxPressure.Text);
                    result.Pressure = double.Parse(textBoxPressure.Text);
                    result.Status = checkBoxStatus.Checked;
                    result.Date = DateTime.UtcNow;

                    sensorRepository.Update(result);
                    sensorRepository.Save();
                    formMain.RefreshDBGrid();
                    formMain._selectedRow = null;
                    this.Close();
                }
            }
        }
        private void checkSensorValues()
        {
            using (var context = new DatabaseContext())
            {
                var result = context.Alarms.SingleOrDefault(b => b.WorkStationId == int.Parse(comboBoxWorkStations.SelectedValue.ToString())
                                                            && (b.MinimumTemperature > double.Parse(textBoxTemperature.Text)
                                                            || b.MaximumTemperature < double.Parse(textBoxTemperature.Text)
                                                            || b.MinimumPressure > double.Parse(textBoxPressure.Text)
                                                            || b.MaximumPressure < double.Parse(textBoxPressure.Text))
                                                            );
                if (result != null)
                {
                    var personelList = context.Personels.Where(b => b.WorkStationId == int.Parse(comboBoxWorkStations.SelectedValue.ToString()));
                    if (personelList != null)
                    {
                        SmtpClient client = new SmtpClient()
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential()
                            {
                                UserName = "huseyinhamaddemo@gmail.com",
                                Password = "MertCase123+"
                            }
                        };
                        try
                        {
                            foreach (var personel in personelList)
                            {

                                MailAddress fromEmail = new MailAddress("huseyinhamaddemo@gmail.com", "Hüseyin Hamad");
                                MailAddress toMail = new MailAddress(personel.PersonelMail.ToString(), personel.PersonelName.ToString());
                                MailMessage Message = new MailMessage()
                                {
                                    From = fromEmail,
                                    Subject = "Warning!!",
                                    Body = "Sensor Values for Work Station ID: " + result.WorkStationId.ToString() + " are not optimal"
                                };
                                Message.To.Add(toMail);
                                client.Send(Message);
                            }
                            MessageBox.Show("Warnings Sent Successfully");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected entry from the database?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow row = formMain._selectedRow;
                sensorRepository.Delete((int)row.Cells[0].Value);
                sensorRepository.Save();

                formMain.RefreshDBGrid();
                formMain._selectedRow = null;
                this.Close();
            }
        }
        private void FormSensor_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain._selectedRow = null;
        }
        private void textBoxTemperature_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl) && textBoxTemperature.Text != "")
            {
                textBoxTemperature.Clear();
                MessageBox.Show("Enter only Numerical Values");
            }
        }
        private void textBoxPressure_TextChanged(object sender, EventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            double tstDbl;
            if (!double.TryParse(tBox.Text, out tstDbl) && textBoxPressure.Text != "")
            {
                textBoxPressure.Clear();
                MessageBox.Show("Enter only Numerical Values");
            }
        }
    }
}
