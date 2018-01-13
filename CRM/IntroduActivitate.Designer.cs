namespace CRM
{
    partial class IntroduActivitate
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Punctaj = new System.Windows.Forms.TextBox();
            this.NumeActivitate = new System.Windows.Forms.TextBox();
            this.Salveaza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IDCategorie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Introdu Punctajul";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introdu Numele Activitatii";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Punctaj
            // 
            this.Punctaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punctaj.Location = new System.Drawing.Point(94, 418);
            this.Punctaj.Margin = new System.Windows.Forms.Padding(5);
            this.Punctaj.Name = "Punctaj";
            this.Punctaj.Size = new System.Drawing.Size(400, 38);
            this.Punctaj.TabIndex = 7;
            this.Punctaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumeActivitate
            // 
            this.NumeActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeActivitate.Location = new System.Drawing.Point(94, 122);
            this.NumeActivitate.Margin = new System.Windows.Forms.Padding(5);
            this.NumeActivitate.Name = "NumeActivitate";
            this.NumeActivitate.Size = new System.Drawing.Size(400, 38);
            this.NumeActivitate.TabIndex = 6;
            this.NumeActivitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Salveaza
            // 
            this.Salveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salveaza.Location = new System.Drawing.Point(189, 552);
            this.Salveaza.Margin = new System.Windows.Forms.Padding(5);
            this.Salveaza.Name = "Salveaza";
            this.Salveaza.Size = new System.Drawing.Size(200, 65);
            this.Salveaza.TabIndex = 5;
            this.Salveaza.Text = "Salveaza";
            this.Salveaza.UseVisualStyleBackColor = true;
            this.Salveaza.Click += new System.EventHandler(this.Salveaza_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(484, 49);
            this.label3.TabIndex = 10;
            this.label3.Text = "Introdu Categoria Activitatii";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDCategorie
            // 
            this.IDCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCategorie.Location = new System.Drawing.Point(89, 275);
            this.IDCategorie.Margin = new System.Windows.Forms.Padding(5);
            this.IDCategorie.Name = "IDCategorie";
            this.IDCategorie.Size = new System.Drawing.Size(400, 38);
            this.IDCategorie.TabIndex = 11;
            this.IDCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntroduActivitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 682);
            this.Controls.Add(this.IDCategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Punctaj);
            this.Controls.Add(this.NumeActivitate);
            this.Controls.Add(this.Salveaza);
            this.Name = "IntroduActivitate";
            this.Text = "IntroduActivitate";
            this.Load += new System.EventHandler(this.IntroduActivitate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Punctaj;
        private System.Windows.Forms.TextBox NumeActivitate;
        private System.Windows.Forms.Button Salveaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDCategorie;
    }
}