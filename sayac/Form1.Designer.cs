namespace sayac
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
            this.btnArttir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnArttir
            // 
            this.btnArttir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArttir.Location = new System.Drawing.Point(-1, 124);
            this.btnArttir.Name = "btnArttir";
            this.btnArttir.Size = new System.Drawing.Size(296, 150);
            this.btnArttir.TabIndex = 0;
            this.btnArttir.Text = "+";
            this.btnArttir.UseVisualStyleBackColor = true;
            this.btnArttir.Click += new System.EventHandler(this.btnArttir_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAzalt.Location = new System.Drawing.Point(506, 124);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(292, 150);
            this.btnAzalt.TabIndex = 1;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(381, 172);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(152, 55);
            this.lblSayac.TabIndex = 2;
            this.lblSayac.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArttir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArttir;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Label lblSayac;
    }
}

