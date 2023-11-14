namespace PresentacionGeoloca
{
    partial class frmPrueba
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
            this.lblidgps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidtienda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblidgps
            // 
            this.lblidgps.AutoSize = true;
            this.lblidgps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidgps.Location = new System.Drawing.Point(343, 194);
            this.lblidgps.Name = "lblidgps";
            this.lblidgps.Size = new System.Drawing.Size(92, 32);
            this.lblidgps.TabIndex = 0;
            this.lblidgps.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "id tienda";
            // 
            // lblidtienda
            // 
            this.lblidtienda.AutoSize = true;
            this.lblidtienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidtienda.Location = new System.Drawing.Point(343, 138);
            this.lblidtienda.Name = "lblidtienda";
            this.lblidtienda.Size = new System.Drawing.Size(92, 32);
            this.lblidtienda.TabIndex = 2;
            this.lblidtienda.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "id gps";
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblidtienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblidgps);
            this.Name = "frmPrueba";
            this.Text = "frmPrueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidgps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidtienda;
        private System.Windows.Forms.Label label3;
    }
}