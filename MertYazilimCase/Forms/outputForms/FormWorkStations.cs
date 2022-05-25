using MertYazilimCase.Business;
using MertYazilimCase.Forms.inputForms;
using MertYazilimCase.Data.Models;
using MertYazilimCase.Data.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MertYazilimCase.Forms.outputForms
{
    public partial class FormWorkStations : Form
    {
        public readonly FormMain formMain;
        public DataGridViewRow _selectedRow { get; set; }
        private GenericRepository<WorkStation> workStationRepository;
        public FormWorkStations(FormMain frm)
        {
            InitializeComponent();
            formMain = frm;
            DatabaseContext context = new DatabaseContext();
            this.workStationRepository = new GenericRepository<WorkStation>(context);
        }
        private void FormWorkStations_Load(object sender, EventArgs e)
        {
            RefreshDBGrid();
        }
        public void RefreshDBGrid()
        {
            dataGridViewWorkStations.AllowUserToAddRows = false;
            dataGridViewWorkStations.AllowUserToDeleteRows = false;
            dataGridViewWorkStations.ReadOnly = true;

             dataGridViewWorkStations.DataSource = workStationRepository.GetEntity(); 
            formMain.RefreshDBGrid();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkStation formWorkStation = new FormWorkStation(this);
            formWorkStation.Show();
        }
        private void dataGridViewWorkStations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dataGridViewWorkStations.Rows[e.RowIndex];
                FormWorkStation formWorkStation = new FormWorkStation(this);
                formWorkStation.Show();
            }
        }
        private void FormWorkStations_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.workStationRepository.Dispose();
        }
    }
}
