
namespace Demo_ADO_Net_Data_Grid
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.freshers_Training2022DataSet = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet();
            this.ridhiOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ridhi_OrderTableAdapter = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSetTableAdapters.Ridhi_OrderTableAdapter();
            this.freshers_Training2022DataSet1 = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet1();
            this.ridhiPersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ridhi_PersonsTableAdapter = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet1TableAdapters.Ridhi_PersonsTableAdapter();
            this.freshers_Training2022DataSet2 = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet2();
            this.ridhiOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ridhi_OrderTableAdapter1 = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet2TableAdapters.Ridhi_OrderTableAdapter();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freshers_Training2022DataSet3 = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet3();
            this.rIDHIORDER5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rIDHI_ORDER5TableAdapter = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet3TableAdapters.RIDHI_ORDER5TableAdapter();
            this.freshers_Training2022DataSet4 = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet4();
            this.ridhiPersonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ridhi_PersonsTableAdapter1 = new Demo_ADO_Net_Data_Grid.Freshers_Training2022DataSet4TableAdapters.Ridhi_PersonsTableAdapter();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiPersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIDHIORDER5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiPersonsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fill Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ridhiPersonsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rIDHIORDER5BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(401, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(378, 283);
            this.dataGridView2.TabIndex = 2;
            // 
            // freshers_Training2022DataSet
            // 
            this.freshers_Training2022DataSet.DataSetName = "Freshers_Training2022DataSet";
            this.freshers_Training2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ridhiOrderBindingSource
            // 
            this.ridhiOrderBindingSource.DataMember = "Ridhi_Order";
            this.ridhiOrderBindingSource.DataSource = this.freshers_Training2022DataSet;
            // 
            // ridhi_OrderTableAdapter
            // 
            this.ridhi_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // freshers_Training2022DataSet1
            // 
            this.freshers_Training2022DataSet1.DataSetName = "Freshers_Training2022DataSet1";
            this.freshers_Training2022DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ridhiPersonsBindingSource
            // 
            this.ridhiPersonsBindingSource.DataMember = "Ridhi_Persons";
            this.ridhiPersonsBindingSource.DataSource = this.freshers_Training2022DataSet1;
            // 
            // ridhi_PersonsTableAdapter
            // 
            this.ridhi_PersonsTableAdapter.ClearBeforeFill = true;
            // 
            // freshers_Training2022DataSet2
            // 
            this.freshers_Training2022DataSet2.DataSetName = "Freshers_Training2022DataSet2";
            this.freshers_Training2022DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ridhiOrderBindingSource1
            // 
            this.ridhiOrderBindingSource1.DataMember = "Ridhi_Order";
            this.ridhiOrderBindingSource1.DataSource = this.freshers_Training2022DataSet2;
            // 
            // ridhi_OrderTableAdapter1
            // 
            this.ridhi_OrderTableAdapter1.ClearBeforeFill = true;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // freshers_Training2022DataSet3
            // 
            this.freshers_Training2022DataSet3.DataSetName = "Freshers_Training2022DataSet3";
            this.freshers_Training2022DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rIDHIORDER5BindingSource
            // 
            this.rIDHIORDER5BindingSource.DataMember = "RIDHI_ORDER5";
            this.rIDHIORDER5BindingSource.DataSource = this.freshers_Training2022DataSet3;
            // 
            // rIDHI_ORDER5TableAdapter
            // 
            this.rIDHI_ORDER5TableAdapter.ClearBeforeFill = true;
            // 
            // freshers_Training2022DataSet4
            // 
            this.freshers_Training2022DataSet4.DataSetName = "Freshers_Training2022DataSet4";
            this.freshers_Training2022DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ridhiPersonsBindingSource1
            // 
            this.ridhiPersonsBindingSource1.DataMember = "Ridhi_Persons";
            this.ridhiPersonsBindingSource1.DataSource = this.freshers_Training2022DataSet4;
            // 
            // ridhi_PersonsTableAdapter1
            // 
            this.ridhi_PersonsTableAdapter1.ClearBeforeFill = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 403);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiPersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rIDHIORDER5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freshers_Training2022DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridhiPersonsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Freshers_Training2022DataSet freshers_Training2022DataSet;
        private System.Windows.Forms.BindingSource ridhiOrderBindingSource;
        private Freshers_Training2022DataSetTableAdapters.Ridhi_OrderTableAdapter ridhi_OrderTableAdapter;
        private Freshers_Training2022DataSet1 freshers_Training2022DataSet1;
        private System.Windows.Forms.BindingSource ridhiPersonsBindingSource;
        private Freshers_Training2022DataSet1TableAdapters.Ridhi_PersonsTableAdapter ridhi_PersonsTableAdapter;
        private Freshers_Training2022DataSet2 freshers_Training2022DataSet2;
        private System.Windows.Forms.BindingSource ridhiOrderBindingSource1;
        private Freshers_Training2022DataSet2TableAdapters.Ridhi_OrderTableAdapter ridhi_OrderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private Freshers_Training2022DataSet3 freshers_Training2022DataSet3;
        private System.Windows.Forms.BindingSource rIDHIORDER5BindingSource;
        private Freshers_Training2022DataSet3TableAdapters.RIDHI_ORDER5TableAdapter rIDHI_ORDER5TableAdapter;
        private Freshers_Training2022DataSet4 freshers_Training2022DataSet4;
        private System.Windows.Forms.BindingSource ridhiPersonsBindingSource1;
        private Freshers_Training2022DataSet4TableAdapters.Ridhi_PersonsTableAdapter ridhi_PersonsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

