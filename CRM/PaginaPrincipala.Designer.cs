namespace CRM
{
    partial class PaginaPrincipala
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
            this.butonActivitate = new System.Windows.Forms.Button();
            this.butonClasament = new System.Windows.Forms.Button();
            this.buttonUtilizatori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butonActivitate
            // 
            this.butonActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonActivitate.Location = new System.Drawing.Point(110, 83);
            this.butonActivitate.Margin = new System.Windows.Forms.Padding(5);
            this.butonActivitate.Name = "butonActivitate";
            this.butonActivitate.Size = new System.Drawing.Size(260, 40);
            this.butonActivitate.TabIndex = 0;
            this.butonActivitate.Text = "Introdu Activitate";
            this.butonActivitate.UseVisualStyleBackColor = true;
            this.butonActivitate.Click += new System.EventHandler(this.ButonActivitate_Click);
            // 
            // butonClasament
            // 
            this.butonClasament.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonClasament.Location = new System.Drawing.Point(111, 256);
            this.butonClasament.Margin = new System.Windows.Forms.Padding(5);
            this.butonClasament.Name = "butonClasament";
            this.butonClasament.Size = new System.Drawing.Size(260, 40);
            this.butonClasament.TabIndex = 1;
            this.butonClasament.Text = "Vezi Clasament";
            this.butonClasament.UseVisualStyleBackColor = true;
            this.butonClasament.Click += new System.EventHandler(this.ButonClasament_Click);
            // 
            // buttonUtilizatori
            // 
            this.buttonUtilizatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatori.Location = new System.Drawing.Point(95, 450);
            this.buttonUtilizatori.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUtilizatori.Name = "buttonUtilizatori";
            this.buttonUtilizatori.Size = new System.Drawing.Size(300, 40);
            this.buttonUtilizatori.TabIndex = 2;
            this.buttonUtilizatori.Text = "Vezi Toti Utilizatorii";
            this.buttonUtilizatori.UseVisualStyleBackColor = true;
            this.buttonUtilizatori.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PaginaPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.buttonUtilizatori);
            this.Controls.Add(this.butonClasament);
            this.Controls.Add(this.butonActivitate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PaginaPrincipala";
            this.Text = "Pagina Principala";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonActivitate;
        private System.Windows.Forms.Button butonClasament;
        private System.Windows.Forms.Button buttonUtilizatori;
    }
}