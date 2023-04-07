
namespace StatusGeck.Cliente
{
    partial class FormCliente
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
            this.lbltext1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltext1
            // 
            this.lbltext1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltext1.AutoSize = true;
            this.lbltext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext1.Location = new System.Drawing.Point(328, 173);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(303, 73);
            this.lbltext1.TabIndex = 0;
            this.lbltext1.Text = "CLIENTE";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltext1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltext1;
    }
}