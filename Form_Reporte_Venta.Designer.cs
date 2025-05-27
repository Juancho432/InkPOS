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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel_reporte_ventas = new Panel();
            dgv_ReporteVenta = new DataGridView();
            lbl_fecha_fin = new Label();
            lbl_fecha_inicio = new Label();
            timepicker_fecha_fin = new DateTimePicker();
            timepicker_fecha_inicio = new DateTimePicker();
            txtbox_buscar_producto = new MaterialSkin.Controls.MaterialTextBox2();
            button_salir = new Button();
            lbl_RF = new Label();
            reporteVentaBindingSource = new BindingSource(components);
            facturaBindingSource = new BindingSource(components);
            productoBindingSource = new BindingSource(components);
            panel_reporte_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ReporteVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reporteVentaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facturaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_reporte_ventas
            // 
            panel_reporte_ventas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_reporte_ventas.BackgroundImage = (Image)resources.GetObject("panel_reporte_ventas.BackgroundImage");
            panel_reporte_ventas.Controls.Add(dgv_ReporteVenta);
            panel_reporte_ventas.Controls.Add(lbl_fecha_fin);
            panel_reporte_ventas.Controls.Add(lbl_fecha_inicio);
            panel_reporte_ventas.Controls.Add(timepicker_fecha_fin);
            panel_reporte_ventas.Controls.Add(timepicker_fecha_inicio);
            panel_reporte_ventas.Controls.Add(txtbox_buscar_producto);
            panel_reporte_ventas.Controls.Add(button_salir);
            panel_reporte_ventas.Controls.Add(lbl_RF);
            panel_reporte_ventas.Location = new Point(5, 2);
            panel_reporte_ventas.Name = "panel_reporte_ventas";
            panel_reporte_ventas.Size = new Size(1513, 1171);
            panel_reporte_ventas.TabIndex = 0;
            panel_reporte_ventas.Click += panel_reporte_ventas_Click;
            panel_reporte_ventas.Paint += panel_reporte_ventas_Paint;
            // 
            // dgv_ReporteVenta
            // 
            dgv_ReporteVenta.AllowUserToAddRows = false;
            dgv_ReporteVenta.AllowUserToDeleteRows = false;
            dgv_ReporteVenta.AllowUserToResizeColumns = false;
            dgv_ReporteVenta.AllowUserToResizeRows = false;
            dgv_ReporteVenta.Anchor = AnchorStyles.None;
            dgv_ReporteVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_ReporteVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ReporteVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_ReporteVenta.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_ReporteVenta.Enabled = false;
            dgv_ReporteVenta.Location = new Point(182, 397);
            dgv_ReporteVenta.MultiSelect = false;
            dgv_ReporteVenta.Name = "dgv_ReporteVenta";
            dgv_ReporteVenta.ReadOnly = true;
            dgv_ReporteVenta.RowHeadersVisible = false;
            dgv_ReporteVenta.RowHeadersWidth = 51;
            dgv_ReporteVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ReporteVenta.Size = new Size(1153, 522);
            dgv_ReporteVenta.TabIndex = 29;
            // 
            // lbl_fecha_fin
            // 
            lbl_fecha_fin.Anchor = AnchorStyles.None;
            lbl_fecha_fin.AutoSize = true;
            lbl_fecha_fin.BackColor = Color.Transparent;
            lbl_fecha_fin.Font = new Font("Arial Rounded MT Bold", 9F);
            lbl_fecha_fin.ForeColor = Color.Transparent;
            lbl_fecha_fin.Location = new Point(970, 244);
            lbl_fecha_fin.Name = "lbl_fecha_fin";
            lbl_fecha_fin.Size = new Size(55, 17);
            lbl_fecha_fin.TabIndex = 28;
            lbl_fecha_fin.Text = "Hasta:";
            // 
            // lbl_fecha_inicio
            // 
            lbl_fecha_inicio.Anchor = AnchorStyles.None;
            lbl_fecha_inicio.AutoSize = true;
            lbl_fecha_inicio.BackColor = Color.Transparent;
            lbl_fecha_inicio.Font = new Font("Arial Rounded MT Bold", 9F);
            lbl_fecha_inicio.ForeColor = Color.White;
            lbl_fecha_inicio.Location = new Point(966, 171);
            lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            lbl_fecha_inicio.Size = new Size(59, 17);
            lbl_fecha_inicio.TabIndex = 27;
            lbl_fecha_inicio.Text = "Desde:";
            // 
            // timepicker_fecha_fin
            // 
            timepicker_fecha_fin.Anchor = AnchorStyles.None;
            timepicker_fecha_fin.Font = new Font("Arial Rounded MT Bold", 9F);
            timepicker_fecha_fin.Location = new Point(852, 265);
            timepicker_fecha_fin.Name = "timepicker_fecha_fin";
            timepicker_fecha_fin.Size = new Size(291, 25);
            timepicker_fecha_fin.TabIndex = 26;
            // 
            // timepicker_fecha_inicio
            // 
            timepicker_fecha_inicio.Anchor = AnchorStyles.None;
            timepicker_fecha_inicio.Font = new Font("Arial Rounded MT Bold", 9F);
            timepicker_fecha_inicio.Location = new Point(852, 203);
            timepicker_fecha_inicio.Name = "timepicker_fecha_inicio";
            timepicker_fecha_inicio.Size = new Size(291, 25);
            timepicker_fecha_inicio.TabIndex = 25;
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
            txtbox_buscar_producto.Location = new Point(424, 242);
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
            lbl_RF.BackColor = Color.Transparent;
            lbl_RF.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RF.ForeColor = Color.White;
            lbl_RF.Location = new Point(581, 80);
            lbl_RF.Name = "lbl_RF";
            lbl_RF.Size = new Size(377, 46);
            lbl_RF.TabIndex = 20;
            lbl_RF.Text = "Reporte de ventas";
            // 
            // reporteVentaBindingSource
            // 
            reporteVentaBindingSource.DataSource = typeof(ReporteVenta);
            // 
            // facturaBindingSource
            // 
            facturaBindingSource.DataSource = typeof(Factura);
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // Form_Reporte_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_reporte_ventas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Reporte_Venta";
            Text = "InkPOS - Reporte de ventas";
            WindowState = FormWindowState.Maximized;
            Load += Form_Reporte_Venta_Load;
            panel_reporte_ventas.ResumeLayout(false);
            panel_reporte_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ReporteVenta).EndInit();
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
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_producto;
        private Button button_salir;
        private Label lbl_RF;
        private BindingSource productoBindingSource;
        private BindingSource facturaBindingSource;
        private BindingSource reporteVentaBindingSource;
        private DataGridView dgv_ReporteVenta;
    }
}