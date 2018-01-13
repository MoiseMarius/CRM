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
            this.structuriDeDate = new CRM.StructuriDeDate();
            this.clasamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentTableAdapter = new CRM.StructuriDeDateTableAdapters.ClasamentTableAdapter();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupatieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeActivitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.punctajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuriDeDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(245, 474);
            this.Back.Margin = new System.Windows.Forms.Padding(5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(200, 65);
            this.Back.TabIndex = 13;
            this.Back.Text = "Inapoi";
            this.Back.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titluDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.ocupatieDataGridViewTextBoxColumn,
            this.numeActivitateDataGridViewTextBoxColumn,
            this.punctajDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasamentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 408);
            this.dataGridView1.TabIndex = 14;
            // 
            // structuriDeDate
            // 
            this.structuriDeDate.DataSetName = "StructuriDeDate";
            this.structuriDeDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasamentBindingSource
            // 
            this.clasamentBindingSource.DataMember = "Clasament";
            this.clasamentBindingSource.DataSource = this.structuriDeDate;
            // 
            // clasamentTableAdapter
            // 
            this.clasamentTableAdapter.ClearBeforeFill = true;
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
            // ocupatieDataGridViewTextBoxColumn
            // 
            this.ocupatieDataGridViewTextBoxColumn.DataPropertyName = "Ocupatie";
            this.ocupatieDataGridViewTextBoxColumn.HeaderText = "Ocupatie";
            this.ocupatieDataGridViewTextBoxColumn.Name = "ocupatieDataGridViewTextBoxColumn";
            this.ocupatieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeActivitateDataGridViewTextBoxColumn
            // 
            this.numeActivitateDataGridViewTextBoxColumn.DataPropertyName = "NumeActivitate";
            this.numeActivitateDataGridViewTextBoxColumn.HeaderText = "NumeActivitate";
            this.numeActivitateDataGridViewTextBoxColumn.Name = "numeActivitateDataGridViewTextBoxColumn";
            this.numeActivitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // punctajDataGridViewTextBoxColumn
            // 
            this.punctajDataGridViewTextBoxColumn.DataPropertyName = "Punctaj";
            this.punctajDataGridViewTextBoxColumn.HeaderText = "Punctaj";
            this.punctajDataGridViewTextBoxColumn.Name = "punctajDataGridViewTextBoxColumn";
            this.punctajDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Clasament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Name = "Clasament";
            this.Text = "Clasament";
            this.Load += new System.EventHandler(this.Clasament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structuriDeDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StructuriDeDate structuriDeDate;
        private System.Windows.Forms.BindingSource clasamentBindingSource;
        private StructuriDeDateTableAdapters.ClasamentTableAdapter clasamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupatieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeActivitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn punctajDataGridViewTextBoxColumn;
    }
}