
namespace StatusGeck.Factura
{
    partial class FormFactura
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
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxcantidadtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxpreciototal = new System.Windows.Forms.TextBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiardetalles = new FontAwesome.Sharp.IconButton();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnnuevaFactura = new FontAwesome.Sharp.IconButton();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCedula.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxCedula.ForeColor = System.Drawing.Color.Black;
            this.textBoxCedula.Location = new System.Drawing.Point(140, 16);
            this.textBoxCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(191, 25);
            this.textBoxCedula.TabIndex = 135;
            this.textBoxCedula.Text = "Escribir...";
            this.textBoxCedula.Enter += new System.EventHandler(this.textBoxCedula_Enter);
            this.textBoxCedula.Leave += new System.EventHandler(this.textBoxCedula_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 134;
            this.label7.Text = "Cedula";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxNombre.ForeColor = System.Drawing.Color.Black;
            this.textBoxNombre.Location = new System.Drawing.Point(140, 69);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(239, 25);
            this.textBoxNombre.TabIndex = 133;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(439, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 30);
            this.label6.TabIndex = 132;
            this.label6.Text = "Cantidad";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxDescripcion.ForeColor = System.Drawing.Color.Black;
            this.textBoxDescripcion.Location = new System.Drawing.Point(604, 15);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(239, 25);
            this.textBoxDescripcion.TabIndex = 131;
            this.textBoxDescripcion.Text = "Escribir...";
            this.textBoxDescripcion.Enter += new System.EventHandler(this.textBoxDescripcion_Enter);
            this.textBoxDescripcion.Leave += new System.EventHandler(this.textBoxDescripcion_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(439, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 30);
            this.label5.TabIndex = 130;
            this.label5.Text = "Descripción";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCantidad.Enabled = false;
            this.textBoxCantidad.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxCantidad.ForeColor = System.Drawing.Color.Black;
            this.textBoxCantidad.Location = new System.Drawing.Point(604, 69);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(239, 25);
            this.textBoxCantidad.TabIndex = 129;
            this.textBoxCantidad.Text = "Escribir...";
            this.textBoxCantidad.Enter += new System.EventHandler(this.textBoxCantidad_Enter);
            this.textBoxCantidad.Leave += new System.EventHandler(this.textBoxCantidad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 128;
            this.label1.Text = "Nombre";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCodigo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxCodigo.ForeColor = System.Drawing.Color.Black;
            this.textBoxCodigo.Location = new System.Drawing.Point(172, 124);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(224, 25);
            this.textBoxCodigo.TabIndex = 137;
            this.textBoxCodigo.Text = "Escribir...";
            this.textBoxCodigo.Enter += new System.EventHandler(this.textBoxCodigo_Enter);
            this.textBoxCodigo.Leave += new System.EventHandler(this.textBoxCodigo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 136;
            this.label2.Text = "No.Factura";
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 140;
            this.lineShape7.X2 = 319;
            this.lineShape7.Y1 = 101;
            this.lineShape7.Y2 = 101;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 602;
            this.lineShape1.X2 = 781;
            this.lineShape1.Y1 = 96;
            this.lineShape1.Y2 = 96;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 604;
            this.lineShape6.X2 = 783;
            this.lineShape6.Y1 = 44;
            this.lineShape6.Y2 = 44;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 141;
            this.lineShape2.X2 = 320;
            this.lineShape2.Y1 = 43;
            this.lineShape2.Y2 = 43;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 162;
            this.lineShape5.X2 = 318;
            this.lineShape5.Y1 = 150;
            this.lineShape5.Y2 = 150;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape4,
            this.lineShape3,
            this.lineShape5,
            this.lineShape2,
            this.lineShape6,
            this.lineShape1,
            this.lineShape7});
            this.shapeContainer1.Size = new System.Drawing.Size(1025, 492);
            this.shapeContainer1.TabIndex = 138;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 606;
            this.lineShape3.X2 = 790;
            this.lineShape3.Y1 = 153;
            this.lineShape3.Y2 = 153;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(381, 12);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.TabIndex = 139;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(439, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 142;
            this.label3.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxPrecio.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrecio.Location = new System.Drawing.Point(601, 124);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(239, 25);
            this.textBoxPrecio.TabIndex = 141;
            this.textBoxPrecio.Text = "Escribir...";
            this.textBoxPrecio.Enter += new System.EventHandler(this.textBoxPrecio_Enter);
            this.textBoxPrecio.Leave += new System.EventHandler(this.textBoxPrecio_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 185);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker1.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 144;
            this.label4.Text = "Fecha";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 32;
            this.btnAgregar.Location = new System.Drawing.Point(848, 69);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 41);
            this.btnAgregar.TabIndex = 147;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 32;
            this.btnEliminar.Location = new System.Drawing.Point(885, 263);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 41);
            this.btnEliminar.TabIndex = 146;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 32;
            this.btnEditar.Location = new System.Drawing.Point(848, 140);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 41);
            this.btnEditar.TabIndex = 148;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(849, 191);
            this.dataGridView1.TabIndex = 149;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 30);
            this.label8.TabIndex = 150;
            this.label8.Text = "Cantidad total";
            // 
            // textBoxcantidadtotal
            // 
            this.textBoxcantidadtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxcantidadtotal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxcantidadtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxcantidadtotal.Enabled = false;
            this.textBoxcantidadtotal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxcantidadtotal.ForeColor = System.Drawing.Color.Black;
            this.textBoxcantidadtotal.Location = new System.Drawing.Point(235, 450);
            this.textBoxcantidadtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxcantidadtotal.Name = "textBoxcantidadtotal";
            this.textBoxcantidadtotal.Size = new System.Drawing.Size(124, 25);
            this.textBoxcantidadtotal.TabIndex = 151;
            this.textBoxcantidadtotal.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(519, 450);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 30);
            this.label9.TabIndex = 152;
            this.label9.Text = "Precio Total";
            // 
            // textBoxpreciototal
            // 
            this.textBoxpreciototal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxpreciototal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxpreciototal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpreciototal.Enabled = false;
            this.textBoxpreciototal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxpreciototal.ForeColor = System.Drawing.Color.Black;
            this.textBoxpreciototal.Location = new System.Drawing.Point(679, 450);
            this.textBoxpreciototal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxpreciototal.Name = "textBoxpreciototal";
            this.textBoxpreciototal.Size = new System.Drawing.Size(154, 25);
            this.textBoxpreciototal.TabIndex = 153;
            this.textBoxpreciototal.Text = "0";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Transparent;
            this.btnguardar.Enabled = false;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 32;
            this.btnguardar.Location = new System.Drawing.Point(888, 321);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(124, 81);
            this.btnguardar.TabIndex = 154;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiardetalles
            // 
            this.btnlimpiardetalles.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiardetalles.Enabled = false;
            this.btnlimpiardetalles.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnlimpiardetalles.IconColor = System.Drawing.Color.Black;
            this.btnlimpiardetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiardetalles.IconSize = 32;
            this.btnlimpiardetalles.Location = new System.Drawing.Point(848, 15);
            this.btnlimpiardetalles.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiardetalles.Name = "btnlimpiardetalles";
            this.btnlimpiardetalles.Size = new System.Drawing.Size(124, 41);
            this.btnlimpiardetalles.TabIndex = 155;
            this.btnlimpiardetalles.Text = "Limpiar Detalles";
            this.btnlimpiardetalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlimpiardetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiardetalles.UseVisualStyleBackColor = false;
            this.btnlimpiardetalles.Click += new System.EventHandler(this.btnlimpiardetalles_Click);
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 235;
            this.lineShape4.X2 = 446;
            this.lineShape4.Y1 = 479;
            this.lineShape4.Y2 = 479;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 678;
            this.lineShape8.X2 = 846;
            this.lineShape8.Y1 = 477;
            this.lineShape8.Y2 = 477;
            // 
            // btnnuevaFactura
            // 
            this.btnnuevaFactura.Enabled = false;
            this.btnnuevaFactura.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnnuevaFactura.IconColor = System.Drawing.Color.Black;
            this.btnnuevaFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnuevaFactura.IconSize = 32;
            this.btnnuevaFactura.Location = new System.Drawing.Point(876, 439);
            this.btnnuevaFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevaFactura.Name = "btnnuevaFactura";
            this.btnnuevaFactura.Size = new System.Drawing.Size(124, 41);
            this.btnnuevaFactura.TabIndex = 156;
            this.btnnuevaFactura.Text = "Nueva Factura";
            this.btnnuevaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevaFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevaFactura.UseVisualStyleBackColor = true;
            this.btnnuevaFactura.Click += new System.EventHandler(this.btnnuevaFactura_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnFactura.IconColor = System.Drawing.Color.Black;
            this.btnFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFactura.IconSize = 32;
            this.btnFactura.Location = new System.Drawing.Point(340, 124);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(84, 41);
            this.btnFactura.TabIndex = 157;
            this.btnFactura.Text = "Listo";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 492);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnnuevaFactura);
            this.Controls.Add(this.btnlimpiardetalles);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.textBoxpreciototal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxcantidadtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFactura";
            this.Text = "FormFactura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrecio;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxcantidadtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxpreciototal;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiardetalles;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private FontAwesome.Sharp.IconButton btnnuevaFactura;
        private FontAwesome.Sharp.IconButton btnFactura;
    }
}