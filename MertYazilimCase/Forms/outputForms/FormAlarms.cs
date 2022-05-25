using MertYazilimCase.Data.BusinessLayer;
using MertYazilimCase.Data.DataLayer;
using MertYazilimCase.Data.Models;
using MertYazilimCase.Forms.inputForms;
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
    public partial class FormAlarms : Form
    {
        public readonly FormMain formMain;
        private GenericRepository<Alarm> alarmRepository;

        public DataGridViewRow _selectedRow { get; set; }
        public FormAlarms(FormMain frm)
        {
            InitializeComponent();
            formMain = frm;
            DatabaseContext context = new DatabaseContext();
            this.alarmRepository = new GenericRepository<Alarm>(context);
        }

        private void FormAlarms_Load(object sender, EventArgs e)
        {
            RefreshDBGrid();
        }

        public void RefreshDBGrid()
        {
            dataGridViewAlarms.AllowUserToAddRows = false;
            dataGridViewAlarms.AllowUserToDeleteRows = false;
            dataGridViewAlarms.ReadOnly = true;

            dataGridViewAlarms.DataSource = alarmRepository.GetEntity();
            formMain.RefreshDBGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAlarm formAlarm = new FormAlarm(this);
            formAlarm.Show();
        }

        private void dataGridViewAlarms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dataGridViewAlarms.Rows[e.RowIndex];
                FormAlarm formAlarm = new FormAlarm(this);
                formAlarm.Show();
            }
        }
        private void FormAlarms_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.alarmRepository.Dispose();
        }
    }
}
