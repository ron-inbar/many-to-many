namespace ManyToMany
{
    partial class ProductPartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            this.dataSet1 = new ManyToMany.DataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.assignedPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignedPartsListBox = new System.Windows.Forms.ListBox();
            this.unassignedPartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unassignedPartsListBox = new System.Windows.Forms.ListBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.unassignButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedPartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unassignedPartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(29, 47);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(61, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "Product ID:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dataSet1;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(96, 44);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // assignedPartBindingSource
            // 
            this.assignedPartBindingSource.DataMember = "Part";
            this.assignedPartBindingSource.DataSource = this.dataSet1;
            this.assignedPartBindingSource.Sort = "";
            // 
            // assignedPartsListBox
            // 
            this.assignedPartsListBox.DataSource = this.assignedPartBindingSource;
            this.assignedPartsListBox.DisplayMember = "Name";
            this.assignedPartsListBox.FormattingEnabled = true;
            this.assignedPartsListBox.Location = new System.Drawing.Point(85, 137);
            this.assignedPartsListBox.Name = "assignedPartsListBox";
            this.assignedPartsListBox.Size = new System.Drawing.Size(300, 212);
            this.assignedPartsListBox.TabIndex = 3;
            this.assignedPartsListBox.ValueMember = "ID";
            // 
            // unassignedPartBindingSource
            // 
            this.unassignedPartBindingSource.DataMember = "Part";
            this.unassignedPartBindingSource.DataSource = this.dataSet1;
            this.unassignedPartBindingSource.Sort = "";
            // 
            // unassignedPartsListBox
            // 
            this.unassignedPartsListBox.DataSource = this.unassignedPartBindingSource;
            this.unassignedPartsListBox.DisplayMember = "Name";
            this.unassignedPartsListBox.FormattingEnabled = true;
            this.unassignedPartsListBox.Location = new System.Drawing.Point(472, 137);
            this.unassignedPartsListBox.Name = "unassignedPartsListBox";
            this.unassignedPartsListBox.Size = new System.Drawing.Size(300, 212);
            this.unassignedPartsListBox.TabIndex = 4;
            this.unassignedPartsListBox.ValueMember = "ID";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(391, 182);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 23);
            this.assignButton.TabIndex = 5;
            this.assignButton.Text = "<<";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // unassignButton
            // 
            this.unassignButton.Location = new System.Drawing.Point(391, 211);
            this.unassignButton.Name = "unassignButton";
            this.unassignButton.Size = new System.Drawing.Size(75, 23);
            this.unassignButton.TabIndex = 5;
            this.unassignButton.Text = ">>";
            this.unassignButton.UseVisualStyleBackColor = true;
            this.unassignButton.Click += new System.EventHandler(this.unassignButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parts in this Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available Parts";
            // 
            // ProductPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unassignButton);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.unassignedPartsListBox);
            this.Controls.Add(this.assignedPartsListBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "ProductPartsForm";
            this.Text = "ProductPartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedPartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unassignedPartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.BindingSource assignedPartBindingSource;
        private System.Windows.Forms.ListBox assignedPartsListBox;
        private System.Windows.Forms.BindingSource unassignedPartBindingSource;
        private System.Windows.Forms.ListBox unassignedPartsListBox;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button unassignButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}