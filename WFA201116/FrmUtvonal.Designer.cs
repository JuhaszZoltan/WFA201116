namespace WFA201116
{
    partial class FrmUtvonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUtvonalak = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOsszKm = new System.Windows.Forms.TextBox();
            this.tbOsszPont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtvonalak)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "A kiválasztott túrázó kirándulásai:";
            // 
            // dgvUtvonalak
            // 
            this.dgvUtvonalak.AllowUserToAddRows = false;
            this.dgvUtvonalak.AllowUserToDeleteRows = false;
            this.dgvUtvonalak.AllowUserToResizeColumns = false;
            this.dgvUtvonalak.AllowUserToResizeRows = false;
            this.dgvUtvonalak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtvonalak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtvonalak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvUtvonalak.Location = new System.Drawing.Point(39, 118);
            this.dgvUtvonalak.Name = "dgvUtvonalak";
            this.dgvUtvonalak.RowHeadersVisible = false;
            this.dgvUtvonalak.RowHeadersWidth = 51;
            this.dgvUtvonalak.RowTemplate.Height = 24;
            this.dgvUtvonalak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtvonalak.Size = new System.Drawing.Size(626, 201);
            this.dgvUtvonalak.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Indulás";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Érkezés";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Megtett út";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Túrázó összes megtett km-e:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(61, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jutalomponto összege:";
            // 
            // tbOsszKm
            // 
            this.tbOsszKm.Enabled = false;
            this.tbOsszKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOsszKm.Location = new System.Drawing.Point(441, 360);
            this.tbOsszKm.Name = "tbOsszKm";
            this.tbOsszKm.Size = new System.Drawing.Size(162, 34);
            this.tbOsszKm.TabIndex = 4;
            // 
            // tbOsszPont
            // 
            this.tbOsszPont.Enabled = false;
            this.tbOsszPont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOsszPont.Location = new System.Drawing.Point(441, 430);
            this.tbOsszPont.Name = "tbOsszPont";
            this.tbOsszPont.Size = new System.Drawing.Size(162, 34);
            this.tbOsszPont.TabIndex = 4;
            // 
            // FrmUtvonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 543);
            this.Controls.Add(this.tbOsszPont);
            this.Controls.Add(this.tbOsszKm);
            this.Controls.Add(this.dgvUtvonalak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUtvonal";
            this.Text = "FrmUtvonal";
            this.Load += new System.EventHandler(this.FrmUtvonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtvonalak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUtvonalak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOsszKm;
        private System.Windows.Forms.TextBox tbOsszPont;
    }
}