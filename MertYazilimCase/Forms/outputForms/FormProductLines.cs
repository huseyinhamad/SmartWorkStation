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

namespace MertYazilimCase
{
    public partial class FormProductLines : Form
    {
        public readonly FormMain formMain;
        public DataGridViewRow _selectedRow { get; set; }
        private GenericRepository<ProductLine> productLineRepository;
        public FormProductLines(FormMain frm)
        {
            InitializeComponent();
            formMain = frm;
            DatabaseContext context = new DatabaseContext();
            this.productLineRepository = new GenericRepository<ProductLine>(context);
        }
        private void FormProductLines_Load(object sender, EventArgs e)
        {
           RefreshDBGrid();
        }
        public void RefreshDBGrid()
        {
            dataGridViewProductLines.AllowUserToAddRows = false;
            dataGridViewProductLines.AllowUserToDeleteRows = false;
            dataGridViewProductLines.ReadOnly = true;

            dataGridViewProductLines.DataSource = productLineRepository.GetEntity();
            formMain.RefreshDBGrid();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormProductLine formProductLine = new FormProductLine(this);
            formProductLine.Show();
        }
        private void dataGridViewProductLines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dataGridViewProductLines.Rows[e.RowIndex];
                FormProductLine formProductLine = new FormProductLine(this);
                formProductLine.Show();
            }
        }

        private void dataGridViewProductLines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
