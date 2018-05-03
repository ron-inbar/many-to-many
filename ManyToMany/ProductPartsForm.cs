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
        public ProductPartsForm(DataSet1 data, DataRowView productRowView)
        {
            _data = data;
            var productRow = (DataSet1.ProductRow)productRowView.Row;
            _productID = productRow.ID;
            InitializeComponent();
            productBindingSource.DataSource = productRowView;
            assignedPartBindingSource.DataSource = productBindingSource;
            assignedPartBindingSource.DataMember = "FK_Product_ProductPart";
            unassignedPartBindingSource.DataSource = _data;
            unassignedPartBindingSource.DataMember = "Part";
            unassignedPartBindingSource.Filter = "0 = Count(Child.ProductID)";
        }

        private int _productID;
        private DataSet1 _data;

        private void assignButton_Click(object sender, EventArgs e)
        {
            var partRowView = (DataRowView)unassignedPartBindingSource.Current;
            var partRow = (DataSet1.PartRow)partRowView.Row;
            var productRowView = (DataRowView)productBindingSource.Current;
            var productRow = (DataSet1.ProductRow)productRowView.Row;
            _data.ProductPart.AddProductPartRow(productRow, partRow);
            UpdateUI();
        }

        private void UpdateUI()
        {
            unassignedPartBindingSource.ResetBindings(false);
            assignedPartBindingSource.ResetBindings(false);
            assignedPartsListBox.Refresh();
            unassignedPartsListBox.Refresh();
            assignButton.Enabled = unassignedPartsListBox.Items.Count > 0;
            unassignButton.Enabled = assignedPartsListBox.Items.Count > 0;
        }

        private void unassignButton_Click(object sender, EventArgs e)
        {
            var partRowView = (DataRowView)unassignedPartBindingSource.Current;
            var partRow = (DataSet1.PartRow)partRowView.Row;
            var productPartRow = _data.ProductPart.Single(row => row.ProductID == _productID && row.PartID == partRow.ID);
            _data.ProductPart.Rows.Remove(productPartRow);
            UpdateUI();
        }
    }
}
