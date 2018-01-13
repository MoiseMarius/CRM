namespace CRM
{
    partial class Contact
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
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonAcasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informatiiCompleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.structuriDeDate = new CRM.StructuriDeDate();
            this.informatiiCompleteTableAdapter = new CRM.StructuriDeDateTableAdapters.InformatiiCompleteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informatiiCompleteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuriDeDate)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(345, 474);
            this.Back.Margin = new System.Windows.Forms.Padding(5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(200, 65);
            this.Back.TabIndex = 13;
            this.Back.Text = "Inapoi";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.dataNasteriiDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.ocupatieDataGridViewTextBoxColumn,
            this.emailuriDataGridViewTextBoxColumn,
            this.telefonMobilDataGridViewTextBoxColumn,
            this.telefonAcasaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.informatiiCompleteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(875, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNasteriiDataGridViewTextBoxColumn
            // 
            this.dataNasteriiDataGridViewTextBoxColumn.DataPropertyName = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.HeaderText = "DataNasterii";
            this.dataNasteriiDataGridViewTextBoxColumn.Name = "dataNasteriiDataGridViewTextBoxColumn";
            this.dataNasteriiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocupatieDataGridViewTextBoxColumn
            // 
            this.ocupatieDataGridViewTextBoxColumn.DataPropertyName = "Ocupatie";
            this.ocupatieDataGridViewTextBoxColumn.HeaderText = "Ocupatie";
            this.ocupatieDataGridViewTextBoxColumn.Name = "ocupatieDataGridViewTextBoxColumn";
            this.ocupatieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailuriDataGridViewTextBoxColumn
            // 
            this.emailuriDataGridViewTextBoxColumn.DataPropertyName = "Emailuri";
            this.emailuriDataGridViewTextBoxColumn.HeaderText = "Emailuri";
            this.emailuriDataGridViewTextBoxColumn.Name = "emailuriDataGridViewTextBoxColumn";
            this.emailuriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonMobilDataGridViewTextBoxColumn
            // 
            this.telefonMobilDataGridViewTextBoxColumn.DataPropertyName = "TelefonMobil";
            this.telefonMobilDataGridViewTextBoxColumn.HeaderText = "TelefonMobil";
            this.telefonMobilDataGridViewTextBoxColumn.Name = "telefonMobilDataGridViewTextBoxColumn";
            this.telefonMobilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonAcasaDataGridViewTextBoxColumn
            // 
            this.telefonAcasaDataGridViewTextBoxColumn.DataPropertyName = "TelefonAcasa";
            this.telefonAcasaDataGridViewTextBoxColumn.HeaderText = "TelefonAcasa";
            this.telefonAcasaDataGridViewTextBoxColumn.Name = "telefonAcasaDataGridViewTextBoxColumn";
            this.telefonAcasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // informatiiCompleteBindingSource
            // 
            this.informatiiCompleteBindingSource.DataMember = "InformatiiComplete";
            this.informatiiCompleteBindingSource.DataSource = this.structuriDeDate;
            // 
            // structuriDeDate
            // 
            this.structuriDeDate.DataSetName = "StructuriDeDate";
            this.structuriDeDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informatiiCompleteTableAdapter
            // 
            this.informatiiCompleteTableAdapter.ClearBeforeFill = true;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Name = "Contact";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.Contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informatiiCompleteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuriDeDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StructuriDeDate structuriDeDate;
        private System.Windows.Forms.BindingSource informatiiCompleteBindingSource;
        private StructuriDeDateTableAdapters.InformatiiCompleteTableAdapter informatiiCompleteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonAcasaDataGridViewTextBoxColumn;
    }
}