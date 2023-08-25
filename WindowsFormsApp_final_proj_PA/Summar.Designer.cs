namespace WindowsFormsApp_final_proj_PA
{
    partial class Summar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rez2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApp_final_proj_PA.Database1DataSet1();
            this.rez2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp_final_proj_PA.Database1DataSet();
            this.rez2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rez2TableAdapter = new WindowsFormsApp_final_proj_PA.Database1DataSetTableAdapters.Rez2TableAdapter();
            this.rez2TableAdapter1 = new WindowsFormsApp_final_proj_PA.Database1DataSet1TableAdapters.Rez2TableAdapter();
            this.database1DataSet2 = new WindowsFormsApp_final_proj_PA.Database1DataSet2();
            this.rez2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.rez2TableAdapter2 = new WindowsFormsApp_final_proj_PA.Database1DataSet2TableAdapters.Rez2TableAdapter();
            this.IdRez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRez,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rez2BindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(90, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // rez2BindingSource2
            // 
            this.rez2BindingSource2.DataMember = "Rez2";
            this.rez2BindingSource2.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rez2BindingSource1
            // 
            this.rez2BindingSource1.DataMember = "Rez2";
            this.rez2BindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rez2BindingSource
            // 
            this.rez2BindingSource.DataMember = "Rez2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(426, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervari existente";
            // 
            // rez2TableAdapter
            // 
            this.rez2TableAdapter.ClearBeforeFill = true;
            // 
            // rez2TableAdapter1
            // 
            this.rez2TableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rez2BindingSource3
            // 
            this.rez2BindingSource3.DataMember = "Rez2";
            this.rez2BindingSource3.DataSource = this.database1DataSet2;
            // 
            // rez2TableAdapter2
            // 
            this.rez2TableAdapter2.ClearBeforeFill = true;
            // 
            // IdRez
            // 
            this.IdRez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdRez.DataPropertyName = "IdRez";
            this.IdRez.HeaderText = "IdRez";
            this.IdRez.MinimumWidth = 8;
            this.IdRez.Name = "IdRez";
            this.IdRez.Width = 88;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nume_Prenume";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nume_Prenume";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tip";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tip";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Denumire_Traseu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Denumire_Traseu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // Summar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Summar";
            this.Text = "Summar";
            this.Load += new System.EventHandler(this.Summar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rez2BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       /* private Database1DataSet database1DataSet;*/
        private System.Windows.Forms.BindingSource rez2BindingSource;
        /*private Database1DataSetTableAdapters.Rez2TableAdapter rez2TableAdapter;*/
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numePrenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireTraseuDataGridViewTextBoxColumn;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource rez2BindingSource1;
        private Database1DataSetTableAdapters.Rez2TableAdapter rez2TableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource rez2BindingSource2;
        private Database1DataSet1TableAdapters.Rez2TableAdapter rez2TableAdapter1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource rez2BindingSource3;
        private Database1DataSet2TableAdapters.Rez2TableAdapter rez2TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRez;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
    }
}