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
    public partial class FormWorkStation : Form
    {
        public readonly FormWorkStations formWorkStations;
        private GenericRepository<ProductLine> productLineRepository;
        private GenericRepository<WorkStation> workStationRepository;

        public FormWorkStation(FormWorkStations frm)
        {
            InitializeComponent();
            formWorkStations = frm;
            buttonDelete.Visible = false;
            DatabaseContext context = new DatabaseContext();
            this.productLineRepository = new GenericRepository<ProductLine>(context);
            this.workStationRepository = new GenericRepository<WorkStation>(context);
        }
        private void formWorkStation_Load(object sender, EventArgs e)
        {
            comboBoxProductLines.DataSource = productLineRepository.GetEntity();
            comboBoxProductLines.ValueMember = "ProductLineId";
            comboBoxProductLines.DisplayMember = "ProductLineName";
            comboBoxProductLines.DropDownStyle = ComboBoxStyle.DropDownList;

            if (formWorkStations._selectedRow != null)
            {
                buttonDelete.Visible = true;
                buttonSubmit.Text = "Edit";

                comboBoxProductLines.Enabled = false;
                textBoxWorkStationName.Enabled = false;

                comboBoxProductLines.SelectedValue = formWorkStations._selectedRow.Cells[1].Value;
                textBoxWorkStationName.Text = formWorkStations._selectedRow.Cells[2].Value.ToString();
            }   
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (buttonSubmit.Text == "Add")
            {
                var workStation = new WorkStation()
                {
                    ProductLineId = int.Parse(comboBoxProductLines.SelectedValue.ToString()),
                    WorkStationName = textBoxWorkStationName.Text
                };
                workStationRepository.Insert(workStation);
                workStationRepository.Save();
                
                formWorkStations.RefreshDBGrid();
                
                this.productLineRepository.Dispose();
                this.workStationRepository.Dispose();
                this.Close();
            }
            else if (buttonSubmit.Text == "Edit")
            {
                comboBoxProductLines.Enabled = true;
                textBoxWorkStationName.Enabled = true;
                buttonSubmit.Text = "Update";
            }
            else if (buttonSubmit.Text == "Update")
            {
                var result = workStationRepository.GetEntityByID((int)formWorkStations._selectedRow.Cells[0].Value);
                if (result != null)
                {
                    result.ProductLineId = int.Parse(comboBoxProductLines.SelectedValue.ToString());
                    result.WorkStationName = textBoxWorkStationName.Text;
                    workStationRepository.Update(result);
                    workStationRepository.Save();

                    formWorkStations.RefreshDBGrid();
                    formWorkStations._selectedRow = null;
                    
                    this.productLineRepository.Dispose();
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
                DataGridViewRow row = formWorkStations._selectedRow;
                workStationRepository.Delete((int)row.Cells[0].Value);
                workStationRepository.Save();

                formWorkStations.RefreshDBGrid();
                formWorkStations._selectedRow = null;
                
                this.productLineRepository.Dispose();
                this.workStationRepository.Dispose();
                this.Close();
            }
        }
        private void FormWorkStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            formWorkStations._selectedRow = null;
            this.productLineRepository.Dispose();
            this.workStationRepository.Dispose();
        }
    }
}
