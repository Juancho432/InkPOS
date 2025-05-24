namespace InkPos
{
    partial class Form_Reporte_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Reporte_Venta));
            panel_reporte_ventas = new Panel();
            CB_filtro = new MaterialSkin.Controls.MaterialComboBox();
            lbl_dual_hasta = new Label();
            lbl_dual_fechadesde = new Label();
            timepicker_dual_FechaFin = new DateTimePicker();
            timepicker_dual_FechaInicio = new DateTimePicker();
            TxtDual_buscar_producto = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_fecha_fin = new Label();
            lbl_fecha_inicio = new Label();
            timepicker_fecha_fin = new DateTimePicker();
            timepicker_fecha_inicio = new DateTimePicker();
            dgv_Facturas = new DataGridView();
            reporteVentaBindingSource = new BindingSource(components);
            txtbox_buscar_producto = new MaterialSkin.Controls.MaterialTextBox2();
            button_salir = new Button();
            lbl_RF = new Label();
            facturaBindingSource = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadvendidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalGanadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel_reporte_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reporteVentaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_reporte_ventas
            // 
            panel_reporte_ventas.Controls.Add(CB_filtro);
            panel_reporte_ventas.Controls.Add(lbl_dual_hasta);
            panel_reporte_ventas.Controls.Add(lbl_dual_fechadesde);
            panel_reporte_ventas.Controls.Add(timepicker_dual_FechaFin);
            panel_reporte_ventas.Controls.Add(timepicker_dual_FechaInicio);
            panel_reporte_ventas.Controls.Add(TxtDual_buscar_producto);
            panel_reporte_ventas.Controls.Add(lbl_fecha_fin);
            panel_reporte_ventas.Controls.Add(lbl_fecha_inicio);
            panel_reporte_ventas.Controls.Add(timepicker_fecha_fin);
            panel_reporte_ventas.Controls.Add(timepicker_fecha_inicio);
            panel_reporte_ventas.Controls.Add(dgv_Facturas);
            panel_reporte_ventas.Controls.Add(txtbox_buscar_producto);
            panel_reporte_ventas.Controls.Add(button_salir);
            panel_reporte_ventas.Controls.Add(lbl_RF);
            panel_reporte_ventas.Location = new Point(5, 2);
            panel_reporte_ventas.Name = "panel_reporte_ventas";
            panel_reporte_ventas.Size = new Size(1513, 1171);
            panel_reporte_ventas.TabIndex = 0;
            panel_reporte_ventas.Paint += panel_reporte_ventas_Paint;
            // 
            // CB_filtro
            // 
            CB_filtro.AutoResize = false;
            CB_filtro.BackColor = Color.FromArgb(255, 255, 255);
            CB_filtro.Depth = 0;
            CB_filtro.DrawMode = DrawMode.OwnerDrawVariable;
            CB_filtro.DropDownHeight = 174;
            CB_filtro.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_filtro.DropDownWidth = 121;
            CB_filtro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CB_filtro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CB_filtro.FormattingEnabled = true;
            CB_filtro.Hint = "Filtros";
            CB_filtro.IntegralHeight = false;
            CB_filtro.ItemHeight = 43;
            CB_filtro.Items.AddRange(new object[] { "Escoge una opción", "Nombre/Código producto", "Fecha", "Nombre/Código y Fecha" });
            CB_filtro.Location = new Point(688, 121);
            CB_filtro.MaxDropDownItems = 4;
            CB_filtro.MouseState = MaterialSkin.MouseState.OUT;
            CB_filtro.Name = "CB_filtro";
            CB_filtro.Size = new Size(202, 49);
            CB_filtro.StartIndex = 0;
            CB_filtro.TabIndex = 35;
            CB_filtro.SelectedIndexChanged += CB_filtro_SelectedIndexChanged;
            // 
            // lbl_dual_hasta
            // 
            lbl_dual_hasta.Anchor = AnchorStyles.None;
            lbl_dual_hasta.AutoSize = true;
            lbl_dual_hasta.Location = new Point(898, 271);
            lbl_dual_hasta.Name = "lbl_dual_hasta";
            lbl_dual_hasta.Size = new Size(50, 20);
            lbl_dual_hasta.TabIndex = 33;
            lbl_dual_hasta.Text = "Hasta:";
            // 
            // lbl_dual_fechadesde
            // 
            lbl_dual_fechadesde.Anchor = AnchorStyles.None;
            lbl_dual_fechadesde.AutoSize = true;
            lbl_dual_fechadesde.Location = new Point(894, 187);
            lbl_dual_fechadesde.Name = "lbl_dual_fechadesde";
            lbl_dual_fechadesde.Size = new Size(54, 20);
            lbl_dual_fechadesde.TabIndex = 32;
            lbl_dual_fechadesde.Text = "Desde:";
            // 
            // timepicker_dual_FechaFin
            // 
            timepicker_dual_FechaFin.Anchor = AnchorStyles.None;
            timepicker_dual_FechaFin.Location = new Point(780, 306);
            timepicker_dual_FechaFin.Name = "timepicker_dual_FechaFin";
            timepicker_dual_FechaFin.Size = new Size(291, 27);
            timepicker_dual_FechaFin.TabIndex = 31;
            // 
            // timepicker_dual_FechaInicio
            // 
            timepicker_dual_FechaInicio.Anchor = AnchorStyles.None;
            timepicker_dual_FechaInicio.Location = new Point(780, 219);
            timepicker_dual_FechaInicio.Name = "timepicker_dual_FechaInicio";
            timepicker_dual_FechaInicio.Size = new Size(291, 27);
            timepicker_dual_FechaInicio.TabIndex = 30;
            // 
            // TxtDual_buscar_producto
            // 
            TxtDual_buscar_producto.Anchor = AnchorStyles.None;
            TxtDual_buscar_producto.AnimateReadOnly = false;
            TxtDual_buscar_producto.BackgroundImageLayout = ImageLayout.None;
            TxtDual_buscar_producto.CharacterCasing = CharacterCasing.Normal;
            TxtDual_buscar_producto.Depth = 0;
            TxtDual_buscar_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtDual_buscar_producto.HideSelection = true;
            TxtDual_buscar_producto.Hint = "Ingrese Nombre/Codigo de producto";
            TxtDual_buscar_producto.LeadingIcon = null;
            TxtDual_buscar_producto.Location = new Point(452, 252);
            TxtDual_buscar_producto.MaxLength = 32767;
            TxtDual_buscar_producto.MouseState = MaterialSkin.MouseState.OUT;
            TxtDual_buscar_producto.Name = "TxtDual_buscar_producto";
            TxtDual_buscar_producto.PasswordChar = '\0';
            TxtDual_buscar_producto.PrefixSuffixText = null;
            TxtDual_buscar_producto.ReadOnly = false;
            TxtDual_buscar_producto.RightToLeft = RightToLeft.No;
            TxtDual_buscar_producto.SelectedText = "";
            TxtDual_buscar_producto.SelectionLength = 0;
            TxtDual_buscar_producto.SelectionStart = 0;
            TxtDual_buscar_producto.ShortcutsEnabled = true;
            TxtDual_buscar_producto.Size = new Size(294, 48);
            TxtDual_buscar_producto.TabIndex = 29;
            TxtDual_buscar_producto.TabStop = false;
            TxtDual_buscar_producto.TextAlign = HorizontalAlignment.Left;
            TxtDual_buscar_producto.TrailingIcon = null;
            TxtDual_buscar_producto.UseSystemPasswordChar = false;
            // 
            // lbl_fecha_fin
            // 
            lbl_fecha_fin.Anchor = AnchorStyles.None;
            lbl_fecha_fin.AutoSize = true;
            lbl_fecha_fin.Location = new Point(766, 260);
            lbl_fecha_fin.Name = "lbl_fecha_fin";
            lbl_fecha_fin.Size = new Size(50, 20);
            lbl_fecha_fin.TabIndex = 28;
            lbl_fecha_fin.Text = "Hasta:";
            // 
            // lbl_fecha_inicio
            // 
            lbl_fecha_inicio.Anchor = AnchorStyles.None;
            lbl_fecha_inicio.AutoSize = true;
            lbl_fecha_inicio.Location = new Point(762, 187);
            lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            lbl_fecha_inicio.Size = new Size(54, 20);
            lbl_fecha_inicio.TabIndex = 27;
            lbl_fecha_inicio.Text = "Desde:";
            // 
            // timepicker_fecha_fin
            // 
            timepicker_fecha_fin.Anchor = AnchorStyles.None;
            timepicker_fecha_fin.Location = new Point(648, 281);
            timepicker_fecha_fin.Name = "timepicker_fecha_fin";
            timepicker_fecha_fin.Size = new Size(291, 27);
            timepicker_fecha_fin.TabIndex = 26;
            // 
            // timepicker_fecha_inicio
            // 
            timepicker_fecha_inicio.Anchor = AnchorStyles.None;
            timepicker_fecha_inicio.Location = new Point(648, 219);
            timepicker_fecha_inicio.Name = "timepicker_fecha_inicio";
            timepicker_fecha_inicio.Size = new Size(291, 27);
            timepicker_fecha_inicio.TabIndex = 25;
            // 
            // dgv_Facturas
            // 
            dgv_Facturas.AllowUserToAddRows = false;
            dgv_Facturas.AllowUserToDeleteRows = false;
            dgv_Facturas.AllowUserToResizeColumns = false;
            dgv_Facturas.AllowUserToResizeRows = false;
            dgv_Facturas.Anchor = AnchorStyles.None;
            dgv_Facturas.AutoGenerateColumns = false;
            dgv_Facturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Facturas.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, cantidadvendidaDataGridViewTextBoxColumn, totalGanadoDataGridViewTextBoxColumn });
            dgv_Facturas.DataSource = reporteVentaBindingSource;
            dgv_Facturas.Location = new Point(46, 379);
            dgv_Facturas.MultiSelect = false;
            dgv_Facturas.Name = "dgv_Facturas";
            dgv_Facturas.ReadOnly = true;
            dgv_Facturas.RowHeadersVisible = false;
            dgv_Facturas.RowHeadersWidth = 51;
            dgv_Facturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Facturas.Size = new Size(1431, 643);
            dgv_Facturas.TabIndex = 24;
            // 
            // reporteVentaBindingSource
            // 
            reporteVentaBindingSource.DataSource = typeof(ReporteVenta);
            // 
            // txtbox_buscar_producto
            // 
            txtbox_buscar_producto.Anchor = AnchorStyles.None;
            txtbox_buscar_producto.AnimateReadOnly = false;
            txtbox_buscar_producto.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar_producto.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar_producto.Depth = 0;
            txtbox_buscar_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar_producto.HideSelection = true;
            txtbox_buscar_producto.Hint = "Ingrese Nombre/Codigo de producto";
            txtbox_buscar_producto.LeadingIcon = null;
            txtbox_buscar_producto.Location = new Point(668, 227);
            txtbox_buscar_producto.MaxLength = 32767;
            txtbox_buscar_producto.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar_producto.Name = "txtbox_buscar_producto";
            txtbox_buscar_producto.PasswordChar = '\0';
            txtbox_buscar_producto.PrefixSuffixText = null;
            txtbox_buscar_producto.ReadOnly = false;
            txtbox_buscar_producto.RightToLeft = RightToLeft.No;
            txtbox_buscar_producto.SelectedText = "";
            txtbox_buscar_producto.SelectionLength = 0;
            txtbox_buscar_producto.SelectionStart = 0;
            txtbox_buscar_producto.ShortcutsEnabled = true;
            txtbox_buscar_producto.Size = new Size(294, 48);
            txtbox_buscar_producto.TabIndex = 23;
            txtbox_buscar_producto.TabStop = false;
            txtbox_buscar_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_producto.TrailingIcon = null;
            txtbox_buscar_producto.UseSystemPasswordChar = false;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(118, 187);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 21;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // lbl_RF
            // 
            lbl_RF.Anchor = AnchorStyles.None;
            lbl_RF.AutoSize = true;
            lbl_RF.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RF.Location = new Point(654, 30);
            lbl_RF.Name = "lbl_RF";
            lbl_RF.Size = new Size(344, 54);
            lbl_RF.TabIndex = 20;
            lbl_RF.Text = "Reporte de ventas";
            // 
            // facturaBindingSource
            // 
            facturaBindingSource.DataSource = typeof(Factura);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadvendidaDataGridViewTextBoxColumn
            // 
            cantidadvendidaDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_vendida";
            cantidadvendidaDataGridViewTextBoxColumn.HeaderText = "Cantidad vendida";
            cantidadvendidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cantidadvendidaDataGridViewTextBoxColumn.Name = "cantidadvendidaDataGridViewTextBoxColumn";
            cantidadvendidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalGanadoDataGridViewTextBoxColumn
            // 
            totalGanadoDataGridViewTextBoxColumn.DataPropertyName = "TotalGanado";
            totalGanadoDataGridViewTextBoxColumn.HeaderText = "Total Ganado";
            totalGanadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalGanadoDataGridViewTextBoxColumn.Name = "totalGanadoDataGridViewTextBoxColumn";
            totalGanadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form_Reporte_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_reporte_ventas);
            Name = "Form_Reporte_Venta";
            Text = "InkPOS - Reporte de ventas";
            WindowState = FormWindowState.Maximized;
            Load += Form_Reporte_Venta_Load;
            panel_reporte_ventas.ResumeLayout(false);
            panel_reporte_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)reporteVentaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_reporte_ventas;
        private Label lbl_fecha_fin;
        private Label lbl_fecha_inicio;
        private DateTimePicker timepicker_fecha_fin;
        private DateTimePicker timepicker_fecha_inicio;
        private DataGridView dgv_Facturas;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_producto;
        private Button button_salir;
        private Label lbl_RF;
        private BindingSource productoBindingSource;
        private Label lbl_dual_hasta;
        private Label lbl_dual_fechadesde;
        private DateTimePicker timepicker_dual_FechaFin;
        private DateTimePicker timepicker_dual_FechaInicio;
        private MaterialSkin.Controls.MaterialTextBox2 TxtDual_buscar_producto;
        private MaterialSkin.Controls.MaterialComboBox CB_filtro;
        private BindingSource facturaBindingSource;
        private BindingSource reporteVentaBindingSource;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadvendidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalGanadoDataGridViewTextBoxColumn;
    }
}