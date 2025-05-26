namespace InkPos
{
    partial class Form_InformeFactura
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InformeFactura));
            pictureBox1 = new PictureBox();
            button_imprimir = new Button();
            lbl_PapeleríaAJ = new Label();
            tlb_info_cliente = new TableLayoutPanel();
            lbl_Telefono = new Label();
            lbl_Nit = new Label();
            lbl_Direccion = new Label();
            lbl_Titulo_Direccion = new Label();
            lbl_titulo_Señor = new Label();
            lbl_Titulo_Nit = new Label();
            lbl_Señor = new Label();
            lbl_Titulo_Num = new Label();
            lbl_Num = new Label();
            lbl_Titulo_Telefono = new Label();
            lbl_Titulo_Empleado = new Label();
            lbl_Empleado = new Label();
            label14 = new Label();
            tbl_fecha_metodo = new TableLayoutPanel();
            lbl_Metodo = new Label();
            lbl_Titulo_Fecha = new Label();
            lbl_Titulo_Metodo = new Label();
            lbl_Fecha = new Label();
            DG_Detalle = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detalleVentaBindingSource = new BindingSource(components);
            label15 = new Label();
            label20 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lbl_Total_Cantidad = new Label();
            lbl_Valor_Total = new Label();
            lbl_Titulo_Total_Cantidad = new Label();
            lbl_Titulo_Valor_Total = new Label();
            Btn_Salir = new MaterialSkin.Controls.MaterialButton();
            txtbox_Señor = new TextBox();
            txtbox_NIT = new TextBox();
            txtbox_Telefono = new TextBox();
            txtbox_Direccion = new TextBox();
            txtbox_Num = new TextBox();
            txtbox_Empleado = new TextBox();
            txtbox_Fecha = new TextBox();
            txtbox_Total_Cantidad = new TextBox();
            txtbox_Valor_Total = new TextBox();
            txtbox_Metodo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlb_info_cliente.SuspendLayout();
            tbl_fecha_metodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DG_Detalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detalleVentaBindingSource).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_imprimir
            // 
            button_imprimir.Image = (Image)resources.GetObject("button_imprimir.Image");
            button_imprimir.Location = new Point(37, 12);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new Size(69, 48);
            button_imprimir.TabIndex = 2;
            button_imprimir.UseVisualStyleBackColor = true;
            button_imprimir.Click += Boton_Imprimir_Click;
            // 
            // lbl_PapeleríaAJ
            // 
            lbl_PapeleríaAJ.Anchor = AnchorStyles.None;
            lbl_PapeleríaAJ.AutoSize = true;
            lbl_PapeleríaAJ.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PapeleríaAJ.Location = new Point(818, 6);
            lbl_PapeleríaAJ.Name = "lbl_PapeleríaAJ";
            lbl_PapeleríaAJ.Size = new Size(316, 57);
            lbl_PapeleríaAJ.TabIndex = 3;
            lbl_PapeleríaAJ.Text = "Papelería AJ";
            // 
            // tlb_info_cliente
            // 
            tlb_info_cliente.Anchor = AnchorStyles.None;
            tlb_info_cliente.BackColor = SystemColors.ButtonFace;
            tlb_info_cliente.ColumnCount = 6;
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4444427F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.55556F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 197F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tlb_info_cliente.Controls.Add(lbl_Telefono, 5, 0);
            tlb_info_cliente.Controls.Add(lbl_Nit, 3, 0);
            tlb_info_cliente.Controls.Add(lbl_Direccion, 1, 1);
            tlb_info_cliente.Controls.Add(lbl_Titulo_Direccion, 0, 1);
            tlb_info_cliente.Controls.Add(lbl_titulo_Señor, 0, 0);
            tlb_info_cliente.Controls.Add(lbl_Titulo_Nit, 2, 0);
            tlb_info_cliente.Controls.Add(lbl_Señor, 1, 0);
            tlb_info_cliente.Controls.Add(lbl_Titulo_Num, 2, 1);
            tlb_info_cliente.Controls.Add(lbl_Num, 3, 1);
            tlb_info_cliente.Controls.Add(lbl_Titulo_Telefono, 4, 0);
            tlb_info_cliente.Controls.Add(lbl_Titulo_Empleado, 4, 1);
            tlb_info_cliente.Controls.Add(lbl_Empleado, 5, 1);
            tlb_info_cliente.Location = new Point(575, 105);
            tlb_info_cliente.Name = "tlb_info_cliente";
            tlb_info_cliente.RowCount = 2;
            tlb_info_cliente.RowStyles.Add(new RowStyle(SizeType.Percent, 53.75F));
            tlb_info_cliente.RowStyles.Add(new RowStyle(SizeType.Percent, 46.25F));
            tlb_info_cliente.Size = new Size(836, 80);
            tlb_info_cliente.TabIndex = 4;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.Anchor = AnchorStyles.Left;
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Cursor = Cursors.Hand;
            lbl_Telefono.Location = new Point(666, 11);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(165, 20);
            lbl_Telefono.TabIndex = 6;
            lbl_Telefono.Text = "__________________________";
            lbl_Telefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Nit
            // 
            lbl_Nit.Anchor = AnchorStyles.Left;
            lbl_Nit.AutoSize = true;
            lbl_Nit.Cursor = Cursors.Hand;
            lbl_Nit.Location = new Point(381, 11);
            lbl_Nit.Name = "lbl_Nit";
            lbl_Nit.Size = new Size(189, 20);
            lbl_Nit.TabIndex = 6;
            lbl_Nit.Text = "______________________________";
            lbl_Nit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.Anchor = AnchorStyles.Left;
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Cursor = Cursors.Hand;
            lbl_Direccion.Location = new Point(109, 51);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(189, 20);
            lbl_Direccion.TabIndex = 5;
            lbl_Direccion.Text = "______________________________";
            lbl_Direccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Direccion
            // 
            lbl_Titulo_Direccion.Anchor = AnchorStyles.Left;
            lbl_Titulo_Direccion.AutoSize = true;
            lbl_Titulo_Direccion.Location = new Point(3, 51);
            lbl_Titulo_Direccion.Name = "lbl_Titulo_Direccion";
            lbl_Titulo_Direccion.Size = new Size(75, 20);
            lbl_Titulo_Direccion.TabIndex = 5;
            lbl_Titulo_Direccion.Text = "Dirección:";
            lbl_Titulo_Direccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_titulo_Señor
            // 
            lbl_titulo_Señor.Anchor = AnchorStyles.Left;
            lbl_titulo_Señor.AutoSize = true;
            lbl_titulo_Señor.Location = new Point(3, 11);
            lbl_titulo_Señor.Name = "lbl_titulo_Señor";
            lbl_titulo_Señor.Size = new Size(82, 20);
            lbl_titulo_Señor.TabIndex = 0;
            lbl_titulo_Señor.Text = "Señor (es): ";
            lbl_titulo_Señor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Nit
            // 
            lbl_Titulo_Nit.Anchor = AnchorStyles.Left;
            lbl_Titulo_Nit.AutoSize = true;
            lbl_Titulo_Nit.Location = new Point(312, 11);
            lbl_Titulo_Nit.Name = "lbl_Titulo_Nit";
            lbl_Titulo_Nit.Size = new Size(39, 20);
            lbl_Titulo_Nit.TabIndex = 5;
            lbl_Titulo_Nit.Text = "NIT: ";
            lbl_Titulo_Nit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Señor
            // 
            lbl_Señor.Anchor = AnchorStyles.Left;
            lbl_Señor.AutoSize = true;
            lbl_Señor.Cursor = Cursors.Hand;
            lbl_Señor.Location = new Point(109, 11);
            lbl_Señor.Name = "lbl_Señor";
            lbl_Señor.Size = new Size(189, 20);
            lbl_Señor.TabIndex = 6;
            lbl_Señor.Text = "______________________________";
            lbl_Señor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Num
            // 
            lbl_Titulo_Num.Anchor = AnchorStyles.Left;
            lbl_Titulo_Num.AutoSize = true;
            lbl_Titulo_Num.Location = new Point(312, 51);
            lbl_Titulo_Num.Name = "lbl_Titulo_Num";
            lbl_Titulo_Num.Size = new Size(44, 20);
            lbl_Titulo_Num.TabIndex = 5;
            lbl_Titulo_Num.Text = "Num:";
            lbl_Titulo_Num.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Num
            // 
            lbl_Num.Anchor = AnchorStyles.Left;
            lbl_Num.AutoSize = true;
            lbl_Num.Cursor = Cursors.Hand;
            lbl_Num.Location = new Point(381, 51);
            lbl_Num.Name = "lbl_Num";
            lbl_Num.Size = new Size(189, 20);
            lbl_Num.TabIndex = 6;
            lbl_Num.Text = "______________________________";
            lbl_Num.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Telefono
            // 
            lbl_Titulo_Telefono.Anchor = AnchorStyles.Left;
            lbl_Titulo_Telefono.AutoSize = true;
            lbl_Titulo_Telefono.Location = new Point(578, 11);
            lbl_Titulo_Telefono.Name = "lbl_Titulo_Telefono";
            lbl_Titulo_Telefono.Size = new Size(70, 20);
            lbl_Titulo_Telefono.TabIndex = 6;
            lbl_Titulo_Telefono.Text = "Teléfono:";
            lbl_Titulo_Telefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Empleado
            // 
            lbl_Titulo_Empleado.Anchor = AnchorStyles.Left;
            lbl_Titulo_Empleado.AutoSize = true;
            lbl_Titulo_Empleado.Location = new Point(578, 51);
            lbl_Titulo_Empleado.Name = "lbl_Titulo_Empleado";
            lbl_Titulo_Empleado.Size = new Size(80, 20);
            lbl_Titulo_Empleado.TabIndex = 7;
            lbl_Titulo_Empleado.Text = "Empleado:";
            lbl_Titulo_Empleado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Empleado
            // 
            lbl_Empleado.Anchor = AnchorStyles.Left;
            lbl_Empleado.AutoSize = true;
            lbl_Empleado.Cursor = Cursors.Hand;
            lbl_Empleado.Location = new Point(666, 51);
            lbl_Empleado.Name = "lbl_Empleado";
            lbl_Empleado.Size = new Size(165, 20);
            lbl_Empleado.TabIndex = 8;
            lbl_Empleado.Text = "__________________________";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(921, 517);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 5;
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbl_fecha_metodo
            // 
            tbl_fecha_metodo.Anchor = AnchorStyles.None;
            tbl_fecha_metodo.BackColor = SystemColors.ButtonFace;
            tbl_fecha_metodo.ColumnCount = 4;
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.60194F));
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.39806F));
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 281F));
            tbl_fecha_metodo.Controls.Add(lbl_Metodo, 3, 0);
            tbl_fecha_metodo.Controls.Add(lbl_Titulo_Fecha, 0, 0);
            tbl_fecha_metodo.Controls.Add(lbl_Titulo_Metodo, 2, 0);
            tbl_fecha_metodo.Controls.Add(lbl_Fecha, 1, 0);
            tbl_fecha_metodo.Location = new Point(575, 206);
            tbl_fecha_metodo.Name = "tbl_fecha_metodo";
            tbl_fecha_metodo.RowCount = 1;
            tbl_fecha_metodo.RowStyles.Add(new RowStyle(SizeType.Percent, 53.75F));
            tbl_fecha_metodo.Size = new Size(836, 54);
            tbl_fecha_metodo.TabIndex = 6;
            // 
            // lbl_Metodo
            // 
            lbl_Metodo.Anchor = AnchorStyles.Left;
            lbl_Metodo.AutoSize = true;
            lbl_Metodo.Cursor = Cursors.Hand;
            lbl_Metodo.Location = new Point(557, 17);
            lbl_Metodo.Name = "lbl_Metodo";
            lbl_Metodo.Size = new Size(189, 20);
            lbl_Metodo.TabIndex = 6;
            lbl_Metodo.Text = "______________________________";
            lbl_Metodo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Fecha
            // 
            lbl_Titulo_Fecha.Anchor = AnchorStyles.Left;
            lbl_Titulo_Fecha.AutoSize = true;
            lbl_Titulo_Fecha.Location = new Point(3, 17);
            lbl_Titulo_Fecha.Name = "lbl_Titulo_Fecha";
            lbl_Titulo_Fecha.Size = new Size(134, 20);
            lbl_Titulo_Fecha.TabIndex = 0;
            lbl_Titulo_Fecha.Text = "Fecha expedicción:";
            lbl_Titulo_Fecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Metodo
            // 
            lbl_Titulo_Metodo.Anchor = AnchorStyles.Left;
            lbl_Titulo_Metodo.AutoSize = true;
            lbl_Titulo_Metodo.Location = new Point(427, 17);
            lbl_Titulo_Metodo.Name = "lbl_Titulo_Metodo";
            lbl_Titulo_Metodo.Size = new Size(114, 20);
            lbl_Titulo_Metodo.TabIndex = 5;
            lbl_Titulo_Metodo.Text = "Forma de pago:";
            lbl_Titulo_Metodo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.Anchor = AnchorStyles.Left;
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Cursor = Cursors.Hand;
            lbl_Fecha.Location = new Point(201, 17);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(189, 20);
            lbl_Fecha.TabIndex = 6;
            lbl_Fecha.Text = "______________________________";
            lbl_Fecha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DG_Detalle
            // 
            DG_Detalle.AllowUserToAddRows = false;
            DG_Detalle.AllowUserToDeleteRows = false;
            DG_Detalle.AllowUserToResizeColumns = false;
            DG_Detalle.AllowUserToResizeRows = false;
            DG_Detalle.Anchor = AnchorStyles.None;
            DG_Detalle.AutoGenerateColumns = false;
            DG_Detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Detalle.BackgroundColor = SystemColors.ControlLight;
            DG_Detalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Detalle.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, subtotalDataGridViewTextBoxColumn });
            DG_Detalle.DataSource = detalleVentaBindingSource;
            DG_Detalle.Location = new Point(575, 279);
            DG_Detalle.Name = "DG_Detalle";
            DG_Detalle.RowHeadersVisible = false;
            DG_Detalle.RowHeadersWidth = 51;
            DG_Detalle.Size = new Size(836, 396);
            DG_Detalle.TabIndex = 8;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.FillWeight = 10F;
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.FillWeight = 65F;
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.FillWeight = 10F;
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            subtotalDataGridViewTextBoxColumn.FillWeight = 15F;
            subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            subtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleVentaBindingSource
            // 
            detalleVentaBindingSource.DataSource = typeof(DetalleVenta);
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(964, 778);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 10;
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Location = new Point(1134, 791);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 11;
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(lbl_Total_Cantidad, 1, 0);
            tableLayoutPanel3.Controls.Add(lbl_Valor_Total, 3, 0);
            tableLayoutPanel3.Controls.Add(lbl_Titulo_Total_Cantidad, 0, 0);
            tableLayoutPanel3.Controls.Add(lbl_Titulo_Valor_Total, 2, 0);
            tableLayoutPanel3.Location = new Point(575, 671);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(836, 54);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // lbl_Total_Cantidad
            // 
            lbl_Total_Cantidad.Anchor = AnchorStyles.Left;
            lbl_Total_Cantidad.AutoSize = true;
            lbl_Total_Cantidad.Cursor = Cursors.Hand;
            lbl_Total_Cantidad.Location = new Point(212, 17);
            lbl_Total_Cantidad.Name = "lbl_Total_Cantidad";
            lbl_Total_Cantidad.Size = new Size(189, 20);
            lbl_Total_Cantidad.TabIndex = 6;
            lbl_Total_Cantidad.Text = "______________________________";
            lbl_Total_Cantidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Valor_Total
            // 
            lbl_Valor_Total.Anchor = AnchorStyles.Left;
            lbl_Valor_Total.AutoSize = true;
            lbl_Valor_Total.Cursor = Cursors.Hand;
            lbl_Valor_Total.Location = new Point(630, 17);
            lbl_Valor_Total.Name = "lbl_Valor_Total";
            lbl_Valor_Total.Size = new Size(189, 20);
            lbl_Valor_Total.TabIndex = 6;
            lbl_Valor_Total.Text = "______________________________";
            lbl_Valor_Total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Titulo_Total_Cantidad
            // 
            lbl_Titulo_Total_Cantidad.Anchor = AnchorStyles.Left;
            lbl_Titulo_Total_Cantidad.AutoSize = true;
            lbl_Titulo_Total_Cantidad.Location = new Point(3, 17);
            lbl_Titulo_Total_Cantidad.Name = "lbl_Titulo_Total_Cantidad";
            lbl_Titulo_Total_Cantidad.Size = new Size(127, 20);
            lbl_Titulo_Total_Cantidad.TabIndex = 7;
            lbl_Titulo_Total_Cantidad.Text = "Numero de Items:";
            // 
            // lbl_Titulo_Valor_Total
            // 
            lbl_Titulo_Valor_Total.Anchor = AnchorStyles.Left;
            lbl_Titulo_Valor_Total.AutoSize = true;
            lbl_Titulo_Valor_Total.Location = new Point(421, 17);
            lbl_Titulo_Valor_Total.Name = "lbl_Titulo_Valor_Total";
            lbl_Titulo_Valor_Total.Size = new Size(81, 20);
            lbl_Titulo_Valor_Total.TabIndex = 8;
            lbl_Titulo_Valor_Total.Text = "Valor total:";
            // 
            // Btn_Salir
            // 
            Btn_Salir.Anchor = AnchorStyles.None;
            Btn_Salir.AutoSize = false;
            Btn_Salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_Salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn_Salir.Depth = 0;
            Btn_Salir.HighEmphasis = true;
            Btn_Salir.Icon = null;
            Btn_Salir.Location = new Point(930, 791);
            Btn_Salir.Margin = new Padding(4, 6, 4, 6);
            Btn_Salir.MouseState = MaterialSkin.MouseState.HOVER;
            Btn_Salir.Name = "Btn_Salir";
            Btn_Salir.NoAccentTextColor = Color.Empty;
            Btn_Salir.Size = new Size(108, 50);
            Btn_Salir.TabIndex = 13;
            Btn_Salir.Text = "Salir";
            Btn_Salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn_Salir.UseAccentColor = false;
            Btn_Salir.UseVisualStyleBackColor = true;
            Btn_Salir.Click += Btn_Salir_Click;
            // 
            // txtbox_Señor
            // 
            txtbox_Señor.Location = new Point(202, 116);
            txtbox_Señor.Multiline = true;
            txtbox_Señor.Name = "txtbox_Señor";
            txtbox_Señor.Size = new Size(125, 34);
            txtbox_Señor.TabIndex = 14;
            // 
            // txtbox_NIT
            // 
            txtbox_NIT.Location = new Point(202, 169);
            txtbox_NIT.Multiline = true;
            txtbox_NIT.Name = "txtbox_NIT";
            txtbox_NIT.Size = new Size(125, 34);
            txtbox_NIT.TabIndex = 15;
            // 
            // txtbox_Telefono
            // 
            txtbox_Telefono.Location = new Point(202, 226);
            txtbox_Telefono.Multiline = true;
            txtbox_Telefono.Name = "txtbox_Telefono";
            txtbox_Telefono.Size = new Size(125, 34);
            txtbox_Telefono.TabIndex = 16;
            // 
            // txtbox_Direccion
            // 
            txtbox_Direccion.Location = new Point(202, 279);
            txtbox_Direccion.Multiline = true;
            txtbox_Direccion.Name = "txtbox_Direccion";
            txtbox_Direccion.Size = new Size(125, 34);
            txtbox_Direccion.TabIndex = 17;
            // 
            // txtbox_Num
            // 
            txtbox_Num.Location = new Point(202, 338);
            txtbox_Num.Multiline = true;
            txtbox_Num.Name = "txtbox_Num";
            txtbox_Num.Size = new Size(125, 34);
            txtbox_Num.TabIndex = 18;
            // 
            // txtbox_Empleado
            // 
            txtbox_Empleado.Location = new Point(202, 397);
            txtbox_Empleado.Multiline = true;
            txtbox_Empleado.Name = "txtbox_Empleado";
            txtbox_Empleado.Size = new Size(125, 34);
            txtbox_Empleado.TabIndex = 19;
            // 
            // txtbox_Fecha
            // 
            txtbox_Fecha.Location = new Point(202, 453);
            txtbox_Fecha.Multiline = true;
            txtbox_Fecha.Name = "txtbox_Fecha";
            txtbox_Fecha.Size = new Size(156, 34);
            txtbox_Fecha.TabIndex = 20;
            // 
            // txtbox_Total_Cantidad
            // 
            txtbox_Total_Cantidad.Location = new Point(202, 580);
            txtbox_Total_Cantidad.Multiline = true;
            txtbox_Total_Cantidad.Name = "txtbox_Total_Cantidad";
            txtbox_Total_Cantidad.Size = new Size(125, 34);
            txtbox_Total_Cantidad.TabIndex = 21;
            // 
            // txtbox_Valor_Total
            // 
            txtbox_Valor_Total.Location = new Point(202, 641);
            txtbox_Valor_Total.Multiline = true;
            txtbox_Valor_Total.Name = "txtbox_Valor_Total";
            txtbox_Valor_Total.Size = new Size(125, 34);
            txtbox_Valor_Total.TabIndex = 22;
            // 
            // txtbox_Metodo
            // 
            txtbox_Metodo.Location = new Point(202, 514);
            txtbox_Metodo.Multiline = true;
            txtbox_Metodo.Name = "txtbox_Metodo";
            txtbox_Metodo.Size = new Size(125, 34);
            txtbox_Metodo.TabIndex = 23;
            // 
            // Form_InformeFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1924, 1055);
            Controls.Add(txtbox_Metodo);
            Controls.Add(txtbox_Valor_Total);
            Controls.Add(txtbox_Total_Cantidad);
            Controls.Add(txtbox_Fecha);
            Controls.Add(txtbox_Empleado);
            Controls.Add(txtbox_Num);
            Controls.Add(txtbox_Direccion);
            Controls.Add(txtbox_Telefono);
            Controls.Add(txtbox_NIT);
            Controls.Add(txtbox_Señor);
            Controls.Add(Btn_Salir);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label20);
            Controls.Add(label15);
            Controls.Add(DG_Detalle);
            Controls.Add(tbl_fecha_metodo);
            Controls.Add(label14);
            Controls.Add(tlb_info_cliente);
            Controls.Add(lbl_PapeleríaAJ);
            Controls.Add(button_imprimir);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_InformeFactura";
            RightToLeft = RightToLeft.No;
            Text = "InformeFactura";
            WindowState = FormWindowState.Maximized;
            Load += InformeFactura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlb_info_cliente.ResumeLayout(false);
            tlb_info_cliente.PerformLayout();
            tbl_fecha_metodo.ResumeLayout(false);
            tbl_fecha_metodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DG_Detalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)detalleVentaBindingSource).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button_imprimir;
        private Label lbl_PapeleríaAJ;
        private TableLayoutPanel tlb_info_cliente;
        private Label lbl_titulo_Señor;
        private Label lbl_Titulo_Num;
        private Label lbl_Titulo_Telefono;
        private Label lbl_Titulo_Direccion;
        private Label lbl_Titulo_Nit;
        private Label lbl_Direccion;
        private Label lbl_Num;
        private Label lbl_Telefono;
        private Label lbl_Nit;
        private Label lbl_Señor;
        private Label label14;
        private TableLayoutPanel tbl_fecha_metodo;
        private Label lbl_Metodo;
        private Label lbl_Titulo_Fecha;
        private Label lbl_Titulo_Metodo;
        private Label lbl_Fecha;
        private DataGridView DG_Detalle;
        private Label label15;
        private Label label20;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbl_Valor_Total;
        private Label lbl_Total_Cantidad;
        private BindingSource detalleVentaBindingSource;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialButton Btn_Salir;
        private Label lbl_Titulo_Empleado;
        private Label lbl_Empleado;
        private Label lbl_Titulo_Total_Cantidad;
        private Label lbl_Titulo_Valor_Total;
        private TextBox txtbox_Señor;
        private TextBox txtbox_NIT;
        private TextBox txtbox_Telefono;
        private TextBox txtbox_Direccion;
        private TextBox txtbox_Num;
        private TextBox txtbox_Empleado;
        private TextBox txtbox_Fecha;
        private TextBox txtbox_Total_Cantidad;
        private TextBox txtbox_Valor_Total;
        private TextBox txtbox_Metodo;
    }
}