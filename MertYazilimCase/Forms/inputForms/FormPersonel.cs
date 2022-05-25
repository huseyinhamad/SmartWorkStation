using MertYazilimCase.Data.BusinessLayer;
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
    public partial class FormPersonel : Form
    {
        public readonly FormPersonels formPersonels;
        private GenericRepository<WorkStation> workStationRepository;
        private GenericRepository<Personel> personelRepository;
        public FormPersonel(FormPersonels frm)
        {
            InitializeComponent();
            DatabaseContext context = new DatabaseContext();
            this.workStationRepository = new GenericRepository<WorkStation>(context);
            this.personelRepository = new GenericRepository<Personel>(context);

            formPersonels = frm;
            buttonDelete.Visible = false;
        }
        private void FormPersonel_Load(object sender, EventArgs e)
        {
            comboBoxWorkStations.DataSource = workStationRepository.GetEntity();
            comboBoxWorkStations.ValueMember = "WorkStationId";
            comboBoxWorkStations.DisplayMember = "WorkStationName";
            comboBoxWorkStations.DropDownStyle = ComboBoxStyle.DropDownList;

            if (formPersonels._selectedRow != null)
            {
                buttonDelete.Visible = true;
                buttonSubmit.Text = "Edit";

                textBoxName.Enabled = false;
                textBoxMail.Enabled = false;
                comboBoxWorkStations.Enabled = false;

                textBoxName.Text = formPersonels._selectedRow.Cells[1].Value.ToString();
                textBoxMail.Text = formPersonels._selectedRow.Cells[2].Value.ToString();
                comboBoxWorkStations.SelectedValue = formPersonels._selectedRow.Cells[3].Value;
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (buttonSubmit.Text == "Add")
            {
                var personel = new Personel()
                {
                    PersonelName = textBoxName.Text,
                    PersonelMail = textBoxMail.Text,
                    WorkStationId = int.Parse(comboBoxWorkStations.SelectedValue.ToString())
                };
                personelRepository.Insert(personel);
                personelRepository.Save();
                formPersonels.RefreshDBGrid();

                this.workStationRepository.Dispose();
                this.personelRepository.Dispose();
                this.Close();
            }
            else if (buttonSubmit.Text == "Edit")
            {
                textBoxName.Enabled = true;
                textBoxMail.Enabled = true;
                comboBoxWorkStations.Enabled = true;
                buttonSubmit.Text = "Update";
            }
            else if (buttonSubmit.Text == "Update")
            {
                using (var context = new DatabaseContext())
                {
                    var result = personelRepository.GetEntityByID((int)formPersonels._selectedRow.Cells[0].Value);
                    if (result != null)
                    {
                        result.PersonelName = textBoxName.Text;
                        result.PersonelMail = textBoxMail.Text;
                        result.WorkStationId = int.Parse(comboBoxWorkStations.SelectedValue.ToString());
                        personelRepository.Update(result);
                        personelRepository.Save();

                        formPersonels.RefreshDBGrid();
                        formPersonels._selectedRow = null;

                        this.workStationRepository.Dispose();
                        this.personelRepository.Dispose();
                        this.Close();
                    }
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected entry from the database?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow row = formPersonels._selectedRow;
                personelRepository.Delete((int)row.Cells[0].Value);
                personelRepository.Save();

                formPersonels.RefreshDBGrid();
                formPersonels._selectedRow = null;

                this.workStationRepository.Dispose();
                this.personelRepository.Dispose();
                this.Close();
            }
        }

        private void FormPersonel_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPersonels._selectedRow = null;
            this.workStationRepository.Dispose();
            this.personelRepository.Dispose();
        }
    }
}
