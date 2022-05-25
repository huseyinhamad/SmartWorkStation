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
    public partial class FormProductLine : Form
    {
        public FormProductLines formProductLines;
        private GenericRepository<ProductLine> productLineRepository;

        public FormProductLine(FormProductLines frm)
        {
            InitializeComponent();
            formProductLines = frm;
            DatabaseContext context = new DatabaseContext();
            this.productLineRepository = new GenericRepository<ProductLine>(context);
            buttonDelete.Visible = false;
        }
        private void FormProductLine_Load(object sender, EventArgs e)
        {
            if (formProductLines._selectedRow != null)
            {
                buttonDelete.Visible = true;
                buttonSubmit.Text = "Edit";
                textBoxProductLineName.Enabled = false;

                textBoxProductLineName.Text = formProductLines._selectedRow.Cells[1].Value.ToString();
            }
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (buttonSubmit.Text == "Add")
            {
                var productLine = new ProductLine() { ProductLineName = textBoxProductLineName.Text };
                productLineRepository.Insert(productLine);
                productLineRepository.Save();

                formProductLines.RefreshDBGrid();

                this.productLineRepository.Dispose();
                this.Close();
            }
            else if (buttonSubmit.Text == "Edit")
            {
                textBoxProductLineName.Enabled = true;
                buttonSubmit.Text = "Update";
            }
            else if (buttonSubmit.Text == "Update")
            {
                using (var context = new DatabaseContext())
{
                    var result = productLineRepository.GetEntityByID((int)formProductLines._selectedRow.Cells[0].Value);
                    if (result != null)
                    {
                        result.ProductLineName = textBoxProductLineName.Text;
                        productLineRepository.Update(result);
                        productLineRepository.Save();
                        
                        formProductLines.RefreshDBGrid();
                        formProductLines._selectedRow = null;

                        this.productLineRepository.Dispose();
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
                DataGridViewRow row = formProductLines._selectedRow;
                productLineRepository.Delete((int)row.Cells[0].Value);
                productLineRepository.Save();
                
                formProductLines.RefreshDBGrid();
                formProductLines._selectedRow = null;
                
                this.productLineRepository.Dispose();
                this.Close();
            }
        }

        private void FormProductLine_FormClosed(object sender, FormClosedEventArgs e)
        {
            formProductLines._selectedRow = null;
            this.productLineRepository.Dispose();
        }
    }
}
