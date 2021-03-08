namespace Vize_Final
{
    partial class FormNot
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
            this.labelVize = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.textBoxVize = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVize
            // 
            this.labelVize.AutoSize = true;
            this.labelVize.Location = new System.Drawing.Point(37, 28);
            this.labelVize.Name = "labelVize";
            this.labelVize.Size = new System.Drawing.Size(56, 13);
            this.labelVize.TabIndex = 0;
            this.labelVize.Text = "Vize Notu:";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(37, 58);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(58, 13);
            this.labelFinal.TabIndex = 1;
            this.labelFinal.Text = "Final Notu:";
            // 
            // textBoxVize
            // 
            this.textBoxVize.Location = new System.Drawing.Point(134, 28);
            this.textBoxVize.Name = "textBoxVize";
            this.textBoxVize.Size = new System.Drawing.Size(100, 20);
            this.textBoxVize.TabIndex = 2;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(134, 55);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinal.TabIndex = 3;
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(259, 28);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(100, 73);
            this.buttonHesapla.TabIndex = 4;
            this.buttonHesapla.Text = "IF  ile HESAPLA";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // FormNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 142);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxVize);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.labelVize);
            this.Name = "FormNot";
            this.Text = "NOT HESAPLAMA EKRANI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVize;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.TextBox textBoxVize;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.Button buttonHesapla;
    }
}

