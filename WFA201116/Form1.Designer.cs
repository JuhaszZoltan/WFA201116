﻿namespace WFA201116
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
            this.dgvTurazok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrissites = new System.Windows.Forms.Button();
            this.pbRetard = new System.Windows.Forms.PictureBox();
            this.btnUjSzemely = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurazok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurazok
            // 
            this.dgvTurazok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurazok.Location = new System.Drawing.Point(12, 198);
            this.dgvTurazok.Name = "dgvTurazok";
            this.dgvTurazok.RowHeadersWidth = 51;
            this.dgvTurazok.RowTemplate.Height = 24;
            this.dgvTurazok.Size = new System.Drawing.Size(776, 215);
            this.dgvTurazok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Természetjárók nyilvántartása";
            // 
            // btnFrissites
            // 
            this.btnFrissites.Location = new System.Drawing.Point(433, 434);
            this.btnFrissites.Name = "btnFrissites";
            this.btnFrissites.Size = new System.Drawing.Size(306, 47);
            this.btnFrissites.TabIndex = 2;
            this.btnFrissites.Text = "Adatok frissítése";
            this.btnFrissites.UseVisualStyleBackColor = true;
            // 
            // pbRetard
            // 
            this.pbRetard.Image = global::WFA201116.Properties.Resources.retard;
            this.pbRetard.Location = new System.Drawing.Point(547, 12);
            this.pbRetard.Name = "pbRetard";
            this.pbRetard.Size = new System.Drawing.Size(241, 180);
            this.pbRetard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRetard.TabIndex = 3;
            this.pbRetard.TabStop = false;
            // 
            // btnUjSzemely
            // 
            this.btnUjSzemely.Location = new System.Drawing.Point(51, 434);
            this.btnUjSzemely.Name = "btnUjSzemely";
            this.btnUjSzemely.Size = new System.Drawing.Size(306, 47);
            this.btnUjSzemely.TabIndex = 2;
            this.btnUjSzemely.Text = "Új személy felvétele";
            this.btnUjSzemely.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "A nyilvántartásban szereplők adatai:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.pbRetard);
            this.Controls.Add(this.btnUjSzemely);
            this.Controls.Add(this.btnFrissites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTurazok);
            this.Name = "Form1";
            this.Text = "Túrázok adatainak nyilvántartása";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurazok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRetard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurazok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrissites;
        private System.Windows.Forms.PictureBox pbRetard;
        private System.Windows.Forms.Button btnUjSzemely;
        private System.Windows.Forms.Label label2;
    }
}
