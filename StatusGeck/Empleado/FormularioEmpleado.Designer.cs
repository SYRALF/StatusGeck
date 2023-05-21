
namespace StatusGeck.Empleado
{
    partial class FormularioEmpleado
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
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxConfirmar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCedula.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxCedula.ForeColor = System.Drawing.Color.Black;
            this.textBoxCedula.Location = new System.Drawing.Point(187, 26);
            this.textBoxCedula.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(239, 25);
            this.textBoxCedula.TabIndex = 110;
            this.textBoxCedula.Text = "Escribir...";
            this.textBoxCedula.Enter += new System.EventHandler(this.textBoxCedula_Enter);
            this.textBoxCedula.Leave += new System.EventHandler(this.textBoxCedula_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(60, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 109;
            this.label7.Text = "Cedula";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxNombre.ForeColor = System.Drawing.Color.Black;
            this.textBoxNombre.Location = new System.Drawing.Point(187, 80);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(239, 25);
            this.textBoxNombre.TabIndex = 108;
            this.textBoxNombre.Text = "Escribir...";
            this.textBoxNombre.Enter += new System.EventHandler(this.textBoxNombre_Enter);
            this.textBoxNombre.Leave += new System.EventHandler(this.textBoxNombre_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(485, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 107;
            this.label6.Text = "Direccion";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxTelefono.ForeColor = System.Drawing.Color.Black;
            this.textBoxTelefono.Location = new System.Drawing.Point(629, 30);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(239, 25);
            this.textBoxTelefono.TabIndex = 106;
            this.textBoxTelefono.Text = "Escribir...";
            this.textBoxTelefono.Enter += new System.EventHandler(this.textBoxTelefono_Enter);
            this.textBoxTelefono.Leave += new System.EventHandler(this.textBoxTelefono_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(485, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 30);
            this.label5.TabIndex = 105;
            this.label5.Text = "Telefono";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCorreo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxCorreo.ForeColor = System.Drawing.Color.Black;
            this.textBoxCorreo.Location = new System.Drawing.Point(189, 127);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(239, 25);
            this.textBoxCorreo.TabIndex = 104;
            this.textBoxCorreo.Text = "Escribir...";
            this.textBoxCorreo.Enter += new System.EventHandler(this.textBoxCorreo_Enter);
            this.textBoxCorreo.Leave += new System.EventHandler(this.textBoxCorreo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(60, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 103;
            this.label4.Text = "Correo";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDireccion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxDireccion.ForeColor = System.Drawing.Color.Black;
            this.textBoxDireccion.Location = new System.Drawing.Point(629, 78);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(239, 25);
            this.textBoxDireccion.TabIndex = 101;
            this.textBoxDireccion.Text = "Escribir...";
            this.textBoxDireccion.Enter += new System.EventHandler(this.textBoxDireccion_Enter);
            this.textBoxDireccion.Leave += new System.EventHandler(this.textBoxDireccion_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 100;
            this.label1.Text = "Nombre";
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 137;
            this.lineShape2.X2 = 316;
            this.lineShape2.Y1 = 43;
            this.lineShape2.Y2 = 43;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 468;
            this.lineShape6.X2 = 647;
            this.lineShape6.Y1 = 44;
            this.lineShape6.Y2 = 44;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 467;
            this.lineShape1.X2 = 646;
            this.lineShape1.Y1 = 83;
            this.lineShape1.Y2 = 83;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 139;
            this.lineShape5.X2 = 318;
            this.lineShape5.Y1 = 123;
            this.lineShape5.Y2 = 123;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 138;
            this.lineShape7.X2 = 317;
            this.lineShape7.Y1 = 85;
            this.lineShape7.Y2 = 85;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7,
            this.lineShape5,
            this.lineShape1,
            this.lineShape6,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1025, 492);
            this.shapeContainer1.TabIndex = 111;
            this.shapeContainer1.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(67, 167);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(324, 26);
            this.textBoxBuscar.TabIndex = 113;
            this.textBoxBuscar.Text = "Escribir...";
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 32;
            this.btnAgregar.Location = new System.Drawing.Point(823, 201);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 68);
            this.btnAgregar.TabIndex = 135;
            this.btnAgregar.Text = "Agregar Empleado";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 32;
            this.btnEliminar.Location = new System.Drawing.Point(823, 351);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 68);
            this.btnEliminar.TabIndex = 134;
            this.btnEliminar.Text = "Eliminar Empleado";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(823, 276);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(183, 68);
            this.btnEditar.TabIndex = 133;
            this.btnEditar.Text = "Editar Empleado";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(731, 239);
            this.dataGridView2.TabIndex = 136;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(485, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 137;
            this.label2.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxApellido.ForeColor = System.Drawing.Color.Black;
            this.textBoxApellido.Location = new System.Drawing.Point(610, 130);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(239, 25);
            this.textBoxApellido.TabIndex = 138;
            this.textBoxApellido.Text = "Escribir...";
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxApellido.Enter += new System.EventHandler(this.textBoxApellido_Enter);
            this.textBoxApellido.Leave += new System.EventHandler(this.textBoxApellido_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(490, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 139;
            this.label3.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(132, 453);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 30);
            this.label8.TabIndex = 140;
            this.label8.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxUsuario.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsuario.Location = new System.Drawing.Point(597, 168);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(239, 25);
            this.textBoxUsuario.TabIndex = 141;
            this.textBoxUsuario.Text = "Escribir...";
            this.textBoxUsuario.Enter += new System.EventHandler(this.textBoxUsuario_Enter);
            this.textBoxUsuario.Leave += new System.EventHandler(this.textBoxUsuario_Leave);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxContraseña.ForeColor = System.Drawing.Color.Black;
            this.textBoxContraseña.Location = new System.Drawing.Point(292, 454);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(239, 25);
            this.textBoxContraseña.TabIndex = 142;
            this.textBoxContraseña.Text = "Escribir...";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            this.textBoxContraseña.Enter += new System.EventHandler(this.textBoxContraseña_Enter);
            this.textBoxContraseña.Leave += new System.EventHandler(this.textBoxContraseña_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(539, 449);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 30);
            this.label9.TabIndex = 143;
            this.label9.Text = "Confirmar Contraseña";
            // 
            // textBoxConfirmar
            // 
            this.textBoxConfirmar.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxConfirmar.ForeColor = System.Drawing.Color.Black;
            this.textBoxConfirmar.Location = new System.Drawing.Point(823, 458);
            this.textBoxConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmar.Name = "textBoxConfirmar";
            this.textBoxConfirmar.Size = new System.Drawing.Size(239, 25);
            this.textBoxConfirmar.TabIndex = 144;
            this.textBoxConfirmar.Text = "Escribir...";
            this.textBoxConfirmar.Enter += new System.EventHandler(this.textBoxConfirmar_Enter);
            this.textBoxConfirmar.Leave += new System.EventHandler(this.textBoxConfirmar_Leave);
            // 
            // FormularioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1025, 492);
            this.Controls.Add(this.textBoxConfirmar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioEmpleado";
            this.Text = "FormularioEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxConfirmar;
    }
}