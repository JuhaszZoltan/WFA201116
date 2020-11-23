namespace WFA201116
{
    partial class FrmUjTurazo
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
            this.tbVNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.tbKNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbVNev
            // 
            this.tbVNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVNev.Location = new System.Drawing.Point(220, 26);
            this.tbVNev.Name = "tbVNev";
            this.tbVNev.Size = new System.Drawing.Size(192, 34);
            this.tbVNev.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vezetéknév:";
            // 
            // btnRogzit
            // 
            this.btnRogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRogzit.Location = new System.Drawing.Point(20, 254);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(392, 64);
            this.btnRogzit.TabIndex = 2;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.BtnRogzit_Click);
            // 
            // tbKNev
            // 
            this.tbKNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKNev.Location = new System.Drawing.Point(220, 82);
            this.tbKNev.Name = "tbKNev";
            this.tbKNev.Size = new System.Drawing.Size(192, 34);
            this.tbKNev.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresznév:";
            // 
            // tbVaros
            // 
            this.tbVaros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVaros.Location = new System.Drawing.Point(220, 140);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(192, 34);
            this.tbVaros.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(92, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Város:";
            // 
            // tbTel
            // 
            this.tbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTel.Location = new System.Drawing.Point(220, 197);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(192, 34);
            this.tbTel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefonszám:";
            // 
            // UjTurazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 339);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbVaros);
            this.Controls.Add(this.tbKNev);
            this.Controls.Add(this.tbVNev);
            this.Name = "UjTurazo";
            this.Text = "UjTurazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.TextBox tbKNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label4;
    }
}