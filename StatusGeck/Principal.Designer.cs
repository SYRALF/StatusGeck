
namespace StatusGeck
{
    partial class Principal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGastos = new FontAwesome.Sharp.IconButton();
            this.btnContabilidad = new FontAwesome.Sharp.IconButton();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.btnEmpleado = new FontAwesome.Sharp.IconButton();
            this.btnCliente = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Orchid;
            this.panelMenu.Controls.Add(this.btnGastos);
            this.panelMenu.Controls.Add(this.btnContabilidad);
            this.panelMenu.Controls.Add(this.btnFactura);
            this.panelMenu.Controls.Add(this.btnEmpleado);
            this.panelMenu.Controls.Add(this.btnCliente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.DimGray;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 446);
            this.panelMenu.TabIndex = 0;
            // 
            // btnGastos
            // 
            this.btnGastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGastos.FlatAppearance.BorderSize = 0;
            this.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastos.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.ForeColor = System.Drawing.Color.LightGray;
            this.btnGastos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnGastos.IconColor = System.Drawing.Color.LightGray;
            this.btnGastos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGastos.IconSize = 35;
            this.btnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.Location = new System.Drawing.Point(0, 345);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGastos.Size = new System.Drawing.Size(179, 50);
            this.btnGastos.TabIndex = 6;
            this.btnGastos.Text = "GASTOS";
            this.btnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnContabilidad
            // 
            this.btnContabilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContabilidad.FlatAppearance.BorderSize = 0;
            this.btnContabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContabilidad.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContabilidad.ForeColor = System.Drawing.Color.LightGray;
            this.btnContabilidad.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnContabilidad.IconColor = System.Drawing.Color.LightGray;
            this.btnContabilidad.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnContabilidad.IconSize = 35;
            this.btnContabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContabilidad.Location = new System.Drawing.Point(0, 295);
            this.btnContabilidad.Name = "btnContabilidad";
            this.btnContabilidad.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnContabilidad.Size = new System.Drawing.Size(179, 50);
            this.btnContabilidad.TabIndex = 5;
            this.btnContabilidad.Text = "CONTABILIDAD";
            this.btnContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContabilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContabilidad.UseVisualStyleBackColor = true;
            this.btnContabilidad.Click += new System.EventHandler(this.btnContabilidad_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.LightGray;
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnFactura.IconColor = System.Drawing.Color.LightGray;
            this.btnFactura.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFactura.IconSize = 35;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 245);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFactura.Size = new System.Drawing.Size(179, 50);
            this.btnFactura.TabIndex = 4;
            this.btnFactura.Text = "FACTURA";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnEmpleado.IconColor = System.Drawing.Color.LightGray;
            this.btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEmpleado.IconSize = 35;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 195);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleado.Size = new System.Drawing.Size(179, 50);
            this.btnEmpleado.TabIndex = 3;
            this.btnEmpleado.Text = "EMPLEADO";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Felix Titling", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.LightGray;
            this.btnCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCliente.IconColor = System.Drawing.Color.LightGray;
            this.btnCliente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCliente.IconSize = 35;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 145);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCliente.Size = new System.Drawing.Size(179, 50);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(179, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(877, 446);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Opacity = 0.9D;
            this.Text = "Principal";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnCliente;
        private FontAwesome.Sharp.IconButton btnGastos;
        private FontAwesome.Sharp.IconButton btnContabilidad;
        private FontAwesome.Sharp.IconButton btnFactura;
        private FontAwesome.Sharp.IconButton btnEmpleado;
    }
}