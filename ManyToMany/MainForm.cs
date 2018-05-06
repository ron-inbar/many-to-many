using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToMany
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditCurrentProduct();
        }

        private void EditCurrentProduct()
        {
            dataSet1.AcceptChanges();
            EditProduct((DataRowView)productBindingSource.Current);
        }

        private void EditProduct(DataRowView productRowView)
        {
            var dlg = new ProductPartsForm(dataSet1, productRowView);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                productBindingSource.ResetCurrentItem();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit and save changes?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch (result)
            {
            case DialogResult.Yes:
                dataSet1.WriteXml("data.xml");
                break;
            case DialogResult.No:
                // Allow the form to close without saving.
                break;
            case DialogResult.Cancel:
                e.Cancel = true;
                return;
            default:
                throw new ArgumentException($"Unexpected dialog result {result}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
            {
                dataSet1.ReadXml("data.xml");
            }
        }
    }
}
