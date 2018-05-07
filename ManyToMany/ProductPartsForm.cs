using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyToMany
{
    public partial class ProductPartsForm : Form
    {
        private int _productID;
        private DataSet1 _data;

        public ProductPartsForm(DataSet1 data, DataRowView productRowView)
        {
            var productRow = (DataSet1.ProductRow)productRowView.Row;
            _productID = productRow.ID;
            _data = data;
            InitializeComponent();
            productBindingSource.DataSource = productRowView;
            assignedPartBindingSource.DataSource = productBindingSource;
            assignedPartBindingSource.DataMember = "FK_Product_Part";
            assignedPartsListBox.DisplayMember = "Name";
            unassignedPartBindingSource.DataSource = _data;
            unassignedPartBindingSource.DataMember = "Part";
            unassignedPartsListBox.DisplayMember = "Name";
            unassignedPartBindingSource.Filter = $"isnull(ProductID, 0) = 0";
        } 

        private void assignButton_Click(object sender, EventArgs e)
        {
            var partRowView = (DataRowView)unassignedPartBindingSource.Current;
            var partRow = (DataSet1.PartRow)partRowView.Row;
            var productRowView = (DataRowView)productBindingSource.Current;
            var productRow = (DataSet1.ProductRow)productRowView.Row;
            partRow.ProductRow = productRow;
            UpdateUI();
        }

        private void unassignButton_Click(object sender, EventArgs e)
        {
            var partRowView = (DataRowView)assignedPartBindingSource.Current;
            var partRow = (DataSet1.PartRow)partRowView.Row;
            partRow.SetProductIDNull();
            UpdateUI();
        }

        private void UpdateUI()
        {
            assignedPartsListBox.Refresh();
            unassignedPartsListBox.Refresh();
            assignButton.Enabled = unassignedPartsListBox.Items.Count > 0;
            unassignButton.Enabled = assignedPartsListBox.Items.Count > 0;
        }
    }
}
