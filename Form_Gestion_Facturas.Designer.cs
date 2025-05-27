namespace InkPos
{
    partial class Form_Gestion_Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Facturas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel_GF = new Panel();
            button_settings_factura = new Button();
            txtbox_buscar_factura_empleado = new MaterialSkin.Controls.MaterialTextBox2();
            DG_Facturas = new DataGridView();
            idFacturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idTransaccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewImageColumn();
            Imprimir = new DataGridViewImageColumn();
            facturaBindingSource = new BindingSource(components);
            lbl_fecha_fin = new Label();
            lbl_fecha_inicio = new Label();
            TP_Fecha_Fin = new DateTimePicker();
            TP_Fecha_Inicio = new DateTimePicker();
            txtbox_buscar_factura = new MaterialSkin.Controls.MaterialTextBox2();
            button_salir = new Button();
            lbl_GF = new Label();
            panel_GF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DG_Facturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_GF
            // 
            panel_GF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GF.BackColor = Color.Transparent;
            panel_GF.BackgroundImage = (Image)resources.GetObject("panel_GF.BackgroundImage");
            panel_GF.Controls.Add(button_settings_factura);
            panel_GF.Controls.Add(txtbox_buscar_factura_empleado);
            panel_GF.Controls.Add(DG_Facturas);
            panel_GF.Controls.Add(lbl_fecha_fin);
            panel_GF.Controls.Add(lbl_fecha_inicio);
            panel_GF.Controls.Add(TP_Fecha_Fin);
            panel_GF.Controls.Add(TP_Fecha_Inicio);
            panel_GF.Controls.Add(txtbox_buscar_factura);
            panel_GF.Controls.Add(button_salir);
            panel_GF.Controls.Add(lbl_GF);
            panel_GF.Location = new Point(2, 2);
            panel_GF.Name = "panel_GF";
            panel_GF.Size = new Size(1918, 1171);
            panel_GF.TabIndex = 0;
            // 
            // button_settings_factura
            // 
            button_settings_factura.Anchor = AnchorStyles.None;
            button_settings_factura.Image = (Image)resources.GetObject("button_settings_factura.Image");
            button_settings_factura.Location = new Point(1580, 187);
            button_settings_factura.Name = "button_settings_factura";
            button_settings_factura.Size = new Size(62, 47);
            button_settings_factura.TabIndex = 39;
            button_settings_factura.UseVisualStyleBackColor = true;
            button_settings_factura.Click += button_settings_factura_Click;
            // 
            // txtbox_buscar_factura_empleado
            // 
            txtbox_buscar_factura_empleado.Anchor = AnchorStyles.None;
            txtbox_buscar_factura_empleado.AnimateReadOnly = false;
            txtbox_buscar_factura_empleado.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar_factura_empleado.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar_factura_empleado.Depth = 0;
            txtbox_buscar_factura_empleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar_factura_empleado.HideSelection = true;
            txtbox_buscar_factura_empleado.Hint = "Ingrese el N° empleado";
            txtbox_buscar_factura_empleado.LeadingIcon = null;
            txtbox_buscar_factura_empleado.Location = new Point(622, 344);
            txtbox_buscar_factura_empleado.MaxLength = 32767;
            txtbox_buscar_factura_empleado.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar_factura_empleado.Name = "txtbox_buscar_factura_empleado";
            txtbox_buscar_factura_empleado.PasswordChar = '\0';
            txtbox_buscar_factura_empleado.PrefixSuffixText = null;
            txtbox_buscar_factura_empleado.ReadOnly = false;
            txtbox_buscar_factura_empleado.RightToLeft = RightToLeft.No;
            txtbox_buscar_factura_empleado.SelectedText = "";
            txtbox_buscar_factura_empleado.SelectionLength = 0;
            txtbox_buscar_factura_empleado.SelectionStart = 0;
            txtbox_buscar_factura_empleado.ShortcutsEnabled = true;
            txtbox_buscar_factura_empleado.Size = new Size(237, 48);
            txtbox_buscar_factura_empleado.TabIndex = 21;
            txtbox_buscar_factura_empleado.TabStop = false;
            txtbox_buscar_factura_empleado.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_factura_empleado.TrailingIcon = null;
            txtbox_buscar_factura_empleado.UseSystemPasswordChar = false;
            txtbox_buscar_factura_empleado.TextChanged += Filtro;
            // 
            // DG_Facturas
            // 
            DG_Facturas.AllowUserToAddRows = false;
            DG_Facturas.AllowUserToDeleteRows = false;
            DG_Facturas.AllowUserToResizeColumns = false;
            DG_Facturas.AllowUserToResizeRows = false;
            DG_Facturas.Anchor = AnchorStyles.None;
            DG_Facturas.AutoGenerateColumns = false;
            DG_Facturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DG_Facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DG_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Facturas.Columns.AddRange(new DataGridViewColumn[] { idFacturaDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, idEmpleadoDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, idTransaccionDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn, Ver, Imprimir });
            DG_Facturas.DataSource = facturaBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DG_Facturas.DefaultCellStyle = dataGridViewCellStyle2;
            DG_Facturas.Location = new Point(486, 492);
            DG_Facturas.Margin = new Padding(3, 4, 3, 4);
            DG_Facturas.MultiSelect = false;
            DG_Facturas.Name = "DG_Facturas";
            DG_Facturas.ReadOnly = true;
            DG_Facturas.RowHeadersVisible = false;
            DG_Facturas.RowHeadersWidth = 51;
            DG_Facturas.Size = new Size(1008, 466);
            DG_Facturas.TabIndex = 20;
            DG_Facturas.CellClick += DG_Facturas_CellClick;
            // 
            // idFacturaDataGridViewTextBoxColumn
            // 
            idFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdFactura";
            idFacturaDataGridViewTextBoxColumn.HeaderText = "Factura N°";
            idFacturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            idFacturaDataGridViewTextBoxColumn.Name = "idFacturaDataGridViewTextBoxColumn";
            idFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "Cliente N°";
            idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "Empleado N°";
            idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            horaDataGridViewTextBoxColumn.MinimumWidth = 6;
            horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTransaccionDataGridViewTextBoxColumn
            // 
            idTransaccionDataGridViewTextBoxColumn.DataPropertyName = "IdTransaccion";
            idTransaccionDataGridViewTextBoxColumn.HeaderText = "Transaccion";
            idTransaccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            idTransaccionDataGridViewTextBoxColumn.Name = "idTransaccionDataGridViewTextBoxColumn";
            idTransaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Ver
            // 
            Ver.FillWeight = 25F;
            Ver.HeaderText = "👁️";
            Ver.Image = Properties.Resources.overview;
            Ver.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Ver.MinimumWidth = 6;
            Ver.Name = "Ver";
            Ver.ReadOnly = true;
            Ver.Resizable = DataGridViewTriState.True;
            Ver.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Imprimir
            // 
            Imprimir.FillWeight = 25F;
            Imprimir.HeaderText = "🖨️";
            Imprimir.Image = Properties.Resources.print;
            Imprimir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imprimir.MinimumWidth = 6;
            Imprimir.Name = "Imprimir";
            Imprimir.ReadOnly = true;
            Imprimir.Resizable = DataGridViewTriState.True;
            Imprimir.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // facturaBindingSource
            // 
            facturaBindingSource.DataSource = typeof(Factura);
            // 
            // lbl_fecha_fin
            // 
            lbl_fecha_fin.Anchor = AnchorStyles.None;
            lbl_fecha_fin.AutoSize = true;
            lbl_fecha_fin.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_fecha_fin.ForeColor = Color.White;
            lbl_fecha_fin.Location = new Point(993, 301);
            lbl_fecha_fin.Name = "lbl_fecha_fin";
            lbl_fecha_fin.Size = new Size(73, 23);
            lbl_fecha_fin.TabIndex = 19;
            lbl_fecha_fin.Text = "Hasta:";
            // 
            // lbl_fecha_inicio
            // 
            lbl_fecha_inicio.Anchor = AnchorStyles.None;
            lbl_fecha_inicio.AutoSize = true;
            lbl_fecha_inicio.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_fecha_inicio.ForeColor = Color.White;
            lbl_fecha_inicio.Location = new Point(993, 253);
            lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            lbl_fecha_inicio.Size = new Size(79, 23);
            lbl_fecha_inicio.TabIndex = 18;
            lbl_fecha_inicio.Text = "Desde:";
            // 
            // TP_Fecha_Fin
            // 
            TP_Fecha_Fin.Anchor = AnchorStyles.None;
            TP_Fecha_Fin.Location = new Point(1078, 297);
            TP_Fecha_Fin.Name = "TP_Fecha_Fin";
            TP_Fecha_Fin.ShowCheckBox = true;
            TP_Fecha_Fin.Size = new Size(291, 27);
            TP_Fecha_Fin.TabIndex = 17;
            TP_Fecha_Fin.ValueChanged += Filtro;
            TP_Fecha_Fin.Validating += TP_Validating;
            // 
            // TP_Fecha_Inicio
            // 
            TP_Fecha_Inicio.Anchor = AnchorStyles.None;
            TP_Fecha_Inicio.Location = new Point(1078, 249);
            TP_Fecha_Inicio.Name = "TP_Fecha_Inicio";
            TP_Fecha_Inicio.ShowCheckBox = true;
            TP_Fecha_Inicio.Size = new Size(291, 27);
            TP_Fecha_Inicio.TabIndex = 16;
            TP_Fecha_Inicio.ValueChanged += Filtro;
            TP_Fecha_Inicio.Validating += TP_Validating;
            // 
            // txtbox_buscar_factura
            // 
            txtbox_buscar_factura.Anchor = AnchorStyles.None;
            txtbox_buscar_factura.AnimateReadOnly = false;
            txtbox_buscar_factura.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar_factura.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar_factura.Depth = 0;
            txtbox_buscar_factura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar_factura.HideSelection = true;
            txtbox_buscar_factura.Hint = "Ingrese el N° de factura";
            txtbox_buscar_factura.LeadingIcon = null;
            txtbox_buscar_factura.Location = new Point(622, 249);
            txtbox_buscar_factura.MaxLength = 32767;
            txtbox_buscar_factura.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar_factura.Name = "txtbox_buscar_factura";
            txtbox_buscar_factura.PasswordChar = '\0';
            txtbox_buscar_factura.PrefixSuffixText = null;
            txtbox_buscar_factura.ReadOnly = false;
            txtbox_buscar_factura.RightToLeft = RightToLeft.No;
            txtbox_buscar_factura.SelectedText = "";
            txtbox_buscar_factura.SelectionLength = 0;
            txtbox_buscar_factura.SelectionStart = 0;
            txtbox_buscar_factura.ShortcutsEnabled = true;
            txtbox_buscar_factura.Size = new Size(237, 48);
            txtbox_buscar_factura.TabIndex = 14;
            txtbox_buscar_factura.TabStop = false;
            txtbox_buscar_factura.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_factura.TrailingIcon = null;
            txtbox_buscar_factura.UseSystemPasswordChar = false;
            txtbox_buscar_factura.TextChanged += Filtro;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(417, 165);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 12;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // lbl_GF
            // 
            lbl_GF.Anchor = AnchorStyles.None;
            lbl_GF.AutoSize = true;
            lbl_GF.BackColor = Color.Transparent;
            lbl_GF.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GF.ForeColor = Color.White;
            lbl_GF.Location = new Point(812, 106);
            lbl_GF.Name = "lbl_GF";
            lbl_GF.Size = new Size(403, 46);
            lbl_GF.TabIndex = 11;
            lbl_GF.Text = "Gestión de facturas";
            // 
            // Form_Gestion_Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1175);
            Controls.Add(panel_GF);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Gestion_Facturas";
            Text = "InkPOS - Gestion de facturas";
            WindowState = FormWindowState.Maximized;
            Load += Form_Gestion_Facturas_Load;
            panel_GF.ResumeLayout(false);
            panel_GF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DG_Facturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GF;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_factura;
        private Button button_salir;
        private Label lbl_GF;
        private Label lbl_fecha_fin;
        private Label lbl_fecha_inicio;
        private DateTimePicker TP_Fecha_Fin;
        private DateTimePicker TP_Fecha_Inicio;
        private DataGridView DG_Facturas;
        private BindingSource facturaBindingSource;
        private DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTransaccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Ver;
        private DataGridViewImageColumn Imprimir;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_factura_empleado;
        private Button button_settings_factura;
    }
}