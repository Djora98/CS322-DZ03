namespace CS322_DZ03
{
    partial class frmForma
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
            this.lblLabela = new System.Windows.Forms.Label();
            this.btnZuto = new System.Windows.Forms.Button();
            this.btnPlavo = new System.Windows.Forms.Button();
            this.btnCrveno = new System.Windows.Forms.Button();
            this.btnKlikni = new System.Windows.Forms.Button();
            this.txbLabela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLabela
            // 
            this.lblLabela.AutoSize = true;
            this.lblLabela.Location = new System.Drawing.Point(206, 147);
            this.lblLabela.Name = "lblLabela";
            this.lblLabela.Size = new System.Drawing.Size(39, 13);
            this.lblLabela.TabIndex = 0;
            this.lblLabela.Text = "Labela";
            // 
            // btnZuto
            // 
            this.btnZuto.Location = new System.Drawing.Point(90, 81);
            this.btnZuto.Name = "btnZuto";
            this.btnZuto.Size = new System.Drawing.Size(75, 23);
            this.btnZuto.TabIndex = 1;
            this.btnZuto.Text = "Zuto";
            this.btnZuto.UseVisualStyleBackColor = true;
            this.btnZuto.Click += new System.EventHandler(this.btnZuto_Click);
            // 
            // btnPlavo
            // 
            this.btnPlavo.Location = new System.Drawing.Point(281, 81);
            this.btnPlavo.Name = "btnPlavo";
            this.btnPlavo.Size = new System.Drawing.Size(75, 23);
            this.btnPlavo.TabIndex = 2;
            this.btnPlavo.Text = "Plavo";
            this.btnPlavo.UseVisualStyleBackColor = true;
            this.btnPlavo.Click += new System.EventHandler(this.btnPlavo_Click);
            // 
            // btnCrveno
            // 
            this.btnCrveno.Location = new System.Drawing.Point(90, 193);
            this.btnCrveno.Name = "btnCrveno";
            this.btnCrveno.Size = new System.Drawing.Size(75, 23);
            this.btnCrveno.TabIndex = 3;
            this.btnCrveno.Text = "Crveno";
            this.btnCrveno.UseVisualStyleBackColor = true;
            this.btnCrveno.Click += new System.EventHandler(this.btnCrveno_Click);
            // 
            // btnKlikni
            // 
            this.btnKlikni.Location = new System.Drawing.Point(281, 193);
            this.btnKlikni.Name = "btnKlikni";
            this.btnKlikni.Size = new System.Drawing.Size(75, 23);
            this.btnKlikni.TabIndex = 4;
            this.btnKlikni.Text = "Klikni";
            this.btnKlikni.UseVisualStyleBackColor = true;
            this.btnKlikni.Click += new System.EventHandler(this.btnKlikni_Click);
            // 
            // txbLabela
            // 
            this.txbLabela.Location = new System.Drawing.Point(269, 222);
            this.txbLabela.Name = "txbLabela";
            this.txbLabela.Size = new System.Drawing.Size(100, 20);
            this.txbLabela.TabIndex = 5;
            // 
            // frmForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 354);
            this.Controls.Add(this.txbLabela);
            this.Controls.Add(this.btnKlikni);
            this.Controls.Add(this.btnCrveno);
            this.Controls.Add(this.btnPlavo);
            this.Controls.Add(this.btnZuto);
            this.Controls.Add(this.lblLabela);
            this.Name = "frmForma";
            this.Text = "CS322-DZ03-LukaDjoric3363";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabela;
        private System.Windows.Forms.Button btnZuto;
        private System.Windows.Forms.Button btnPlavo;
        private System.Windows.Forms.Button btnCrveno;
        private System.Windows.Forms.Button btnKlikni;
        private System.Windows.Forms.TextBox txbLabela;
    }
}

