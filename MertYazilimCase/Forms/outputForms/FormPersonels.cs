using MertYazilimCase.Data.BusinessLayer;
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
    public partial class FormPersonels : Form
    {
        public readonly FormMain formMain;
        private GenericRepository<Personel> personelRepository;
        public DataGridViewRow _selectedRow { get; set; }
        public FormPersonels(FormMain frm)
        {
            InitializeComponent();
            formMain = frm;
            DatabaseContext context = new DatabaseContext();
            this.personelRepository = new GenericRepository<Personel>(context);
        }

        private void FormPersonels_Load(object sender, EventArgs e)
        {
            RefreshDBGrid();
        }

        public void RefreshDBGrid()
        {
            dataGridViewPersonels.AllowUserToAddRows = false;
            dataGridViewPersonels.AllowUserToDeleteRows = false;
            dataGridViewPersonels.ReadOnly = true;

            dataGridViewPersonels.DataSource = personelRepository.GetEntity();
            formMain.RefreshDBGrid();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormPersonel formPersonel = new FormPersonel(this);
            formPersonel.Show();
        }

        private void dataGridViewPersonels_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dataGridViewPersonels.Rows[e.RowIndex];
                FormPersonel formPersonel = new FormPersonel(this);
                formPersonel.Show();
            }
        }

        private void FormPersonels_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.personelRepository.Dispose();

        }
    }
}
