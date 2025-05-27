namespace InkPos
{
    partial class Form_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Venta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel_venta = new Panel();
            DG_Busqueda_Productos = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            txtbox_nombre_cliente = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_name_cliente = new Label();
            txtbox_buscar_cliente = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_Valor_total = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_Cantidad_productos = new MaterialSkin.Controls.MaterialTextBox2();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_finalizar = new MaterialSkin.Controls.MaterialButton();
            txtbox_busqueda_producto = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_valorTotal = new Label();
            lbl_cantidad_productos = new Label();
            lbl_detalleVenta = new Label();
            DG_Detalle = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            detalleVentaBindingSource = new BindingSource(components);
            panel_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DG_Busqueda_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DG_Detalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detalleVentaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_venta
            // 
            panel_venta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_venta.BackgroundImage = (Image)resources.GetObject("panel_venta.BackgroundImage");
            panel_venta.Controls.Add(DG_Busqueda_Productos);
            panel_venta.Controls.Add(txtbox_nombre_cliente);
            panel_venta.Controls.Add(lbl_name_cliente);
            panel_venta.Controls.Add(txtbox_buscar_cliente);
            panel_venta.Controls.Add(txtbox_Valor_total);
            panel_venta.Controls.Add(txtbox_Cantidad_productos);
            panel_venta.Controls.Add(button_cancelar);
            panel_venta.Controls.Add(button_finalizar);
            panel_venta.Controls.Add(txtbox_busqueda_producto);
            panel_venta.Controls.Add(lbl_valorTotal);
            panel_venta.Controls.Add(lbl_cantidad_productos);
            panel_venta.Controls.Add(lbl_detalleVenta);
            panel_venta.Controls.Add(DG_Detalle);
            panel_venta.Location = new Point(5, 3);
            panel_venta.Name = "panel_venta";
            panel_venta.Size = new Size(1513, 1171);
            panel_venta.TabIndex = 0;
            // 
            // DG_Busqueda_Productos
            // 
            DG_Busqueda_Productos.AllowUserToAddRows = false;
            DG_Busqueda_Productos.AllowUserToDeleteRows = false;
            DG_Busqueda_Productos.AllowUserToResizeColumns = false;
            DG_Busqueda_Productos.AllowUserToResizeRows = false;
            DG_Busqueda_Productos.Anchor = AnchorStyles.None;
            DG_Busqueda_Productos.AutoGenerateColumns = false;
            DG_Busqueda_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DG_Busqueda_Productos.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DG_Busqueda_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DG_Busqueda_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Busqueda_Productos.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            DG_Busqueda_Productos.DataSource = productoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DG_Busqueda_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            DG_Busqueda_Productos.EditMode = DataGridViewEditMode.EditProgrammatically;
            DG_Busqueda_Productos.Location = new Point(22, 264);
            DG_Busqueda_Productos.MultiSelect = false;
            DG_Busqueda_Productos.Name = "DG_Busqueda_Productos";
            DG_Busqueda_Productos.ReadOnly = true;
            DG_Busqueda_Productos.RowHeadersVisible = false;
            DG_Busqueda_Productos.RowHeadersWidth = 51;
            DG_Busqueda_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Busqueda_Productos.Size = new Size(482, 579);
            DG_Busqueda_Productos.TabIndex = 33;
            DG_Busqueda_Productos.CellDoubleClick += DG_Busqueda_Productos_CellDoubleClick;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.FillWeight = 15F;
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.FillWeight = 60F;
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.FillWeight = 15F;
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 10F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // txtbox_nombre_cliente
            // 
            txtbox_nombre_cliente.Anchor = AnchorStyles.None;
            txtbox_nombre_cliente.AnimateReadOnly = false;
            txtbox_nombre_cliente.BackgroundImageLayout = ImageLayout.None;
            txtbox_nombre_cliente.CharacterCasing = CharacterCasing.Normal;
            txtbox_nombre_cliente.Depth = 0;
            txtbox_nombre_cliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_nombre_cliente.HideSelection = true;
            txtbox_nombre_cliente.LeadingIcon = null;
            txtbox_nombre_cliente.Location = new Point(744, 107);
            txtbox_nombre_cliente.MaxLength = 32767;
            txtbox_nombre_cliente.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_nombre_cliente.Name = "txtbox_nombre_cliente";
            txtbox_nombre_cliente.PasswordChar = '\0';
            txtbox_nombre_cliente.PrefixSuffixText = null;
            txtbox_nombre_cliente.ReadOnly = true;
            txtbox_nombre_cliente.RightToLeft = RightToLeft.No;
            txtbox_nombre_cliente.SelectedText = "";
            txtbox_nombre_cliente.SelectionLength = 0;
            txtbox_nombre_cliente.SelectionStart = 0;
            txtbox_nombre_cliente.ShortcutsEnabled = true;
            txtbox_nombre_cliente.Size = new Size(467, 48);
            txtbox_nombre_cliente.TabIndex = 32;
            txtbox_nombre_cliente.TabStop = false;
            txtbox_nombre_cliente.TextAlign = HorizontalAlignment.Left;
            txtbox_nombre_cliente.TrailingIcon = null;
            txtbox_nombre_cliente.UseSystemPasswordChar = false;
            // 
            // lbl_name_cliente
            // 
            lbl_name_cliente.Anchor = AnchorStyles.None;
            lbl_name_cliente.AutoSize = true;
            lbl_name_cliente.BackColor = Color.Transparent;
            lbl_name_cliente.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lbl_name_cliente.ForeColor = Color.White;
            lbl_name_cliente.Location = new Point(619, 117);
            lbl_name_cliente.Name = "lbl_name_cliente";
            lbl_name_cliente.Size = new Size(58, 15);
            lbl_name_cliente.TabIndex = 30;
            lbl_name_cliente.Text = "Cliente:";
            // 
            // txtbox_buscar_cliente
            // 
            txtbox_buscar_cliente.Anchor = AnchorStyles.None;
            txtbox_buscar_cliente.AnimateReadOnly = false;
            txtbox_buscar_cliente.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar_cliente.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar_cliente.Depth = 0;
            txtbox_buscar_cliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar_cliente.HideSelection = true;
            txtbox_buscar_cliente.Hint = "Ingrese Nombre o ID del Cliente";
            txtbox_buscar_cliente.LeadingIcon = null;
            txtbox_buscar_cliente.Location = new Point(744, 26);
            txtbox_buscar_cliente.MaxLength = 32767;
            txtbox_buscar_cliente.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar_cliente.Name = "txtbox_buscar_cliente";
            txtbox_buscar_cliente.PasswordChar = '\0';
            txtbox_buscar_cliente.PrefixSuffixText = null;
            txtbox_buscar_cliente.ReadOnly = false;
            txtbox_buscar_cliente.RightToLeft = RightToLeft.No;
            txtbox_buscar_cliente.SelectedText = "";
            txtbox_buscar_cliente.SelectionLength = 0;
            txtbox_buscar_cliente.SelectionStart = 0;
            txtbox_buscar_cliente.ShortcutsEnabled = true;
            txtbox_buscar_cliente.Size = new Size(312, 48);
            txtbox_buscar_cliente.TabIndex = 29;
            txtbox_buscar_cliente.TabStop = false;
            txtbox_buscar_cliente.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_cliente.TrailingIcon = null;
            txtbox_buscar_cliente.UseSystemPasswordChar = false;
            txtbox_buscar_cliente.KeyPress += Txtbox_buscar_cliente_KeyPress;
            // 
            // txtbox_Valor_total
            // 
            txtbox_Valor_total.Anchor = AnchorStyles.None;
            txtbox_Valor_total.AnimateReadOnly = false;
            txtbox_Valor_total.BackgroundImageLayout = ImageLayout.None;
            txtbox_Valor_total.CharacterCasing = CharacterCasing.Normal;
            txtbox_Valor_total.Depth = 0;
            txtbox_Valor_total.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_Valor_total.HideSelection = true;
            txtbox_Valor_total.LeadingIcon = null;
            txtbox_Valor_total.Location = new Point(962, 880);
            txtbox_Valor_total.MaxLength = 32767;
            txtbox_Valor_total.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_Valor_total.Name = "txtbox_Valor_total";
            txtbox_Valor_total.PasswordChar = '\0';
            txtbox_Valor_total.PrefixSuffixText = null;
            txtbox_Valor_total.ReadOnly = true;
            txtbox_Valor_total.RightToLeft = RightToLeft.No;
            txtbox_Valor_total.SelectedText = "";
            txtbox_Valor_total.SelectionLength = 0;
            txtbox_Valor_total.SelectionStart = 0;
            txtbox_Valor_total.ShortcutsEnabled = true;
            txtbox_Valor_total.Size = new Size(219, 48);
            txtbox_Valor_total.TabIndex = 28;
            txtbox_Valor_total.TabStop = false;
            txtbox_Valor_total.TextAlign = HorizontalAlignment.Left;
            txtbox_Valor_total.TrailingIcon = null;
            txtbox_Valor_total.UseSystemPasswordChar = false;
            // 
            // txtbox_Cantidad_productos
            // 
            txtbox_Cantidad_productos.Anchor = AnchorStyles.None;
            txtbox_Cantidad_productos.AnimateReadOnly = false;
            txtbox_Cantidad_productos.BackgroundImageLayout = ImageLayout.None;
            txtbox_Cantidad_productos.CharacterCasing = CharacterCasing.Normal;
            txtbox_Cantidad_productos.Depth = 0;
            txtbox_Cantidad_productos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_Cantidad_productos.HideSelection = true;
            txtbox_Cantidad_productos.LeadingIcon = null;
            txtbox_Cantidad_productos.Location = new Point(722, 880);
            txtbox_Cantidad_productos.MaxLength = 32767;
            txtbox_Cantidad_productos.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_Cantidad_productos.Name = "txtbox_Cantidad_productos";
            txtbox_Cantidad_productos.PasswordChar = '\0';
            txtbox_Cantidad_productos.PrefixSuffixText = null;
            txtbox_Cantidad_productos.ReadOnly = true;
            txtbox_Cantidad_productos.RightToLeft = RightToLeft.No;
            txtbox_Cantidad_productos.SelectedText = "";
            txtbox_Cantidad_productos.SelectionLength = 0;
            txtbox_Cantidad_productos.SelectionStart = 0;
            txtbox_Cantidad_productos.ShortcutsEnabled = true;
            txtbox_Cantidad_productos.Size = new Size(178, 48);
            txtbox_Cantidad_productos.TabIndex = 27;
            txtbox_Cantidad_productos.TabStop = false;
            txtbox_Cantidad_productos.TextAlign = HorizontalAlignment.Left;
            txtbox_Cantidad_productos.TrailingIcon = null;
            txtbox_Cantidad_productos.UseSystemPasswordChar = false;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSize = false;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(962, 966);
            button_cancelar.Margin = new Padding(5);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(134, 45);
            button_cancelar.TabIndex = 26;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += Boton_Cancelar_Click;
            // 
            // button_finalizar
            // 
            button_finalizar.Anchor = AnchorStyles.None;
            button_finalizar.AutoSize = false;
            button_finalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_finalizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_finalizar.Depth = 0;
            button_finalizar.HighEmphasis = true;
            button_finalizar.Icon = null;
            button_finalizar.Location = new Point(766, 966);
            button_finalizar.Margin = new Padding(5);
            button_finalizar.MouseState = MaterialSkin.MouseState.HOVER;
            button_finalizar.Name = "button_finalizar";
            button_finalizar.NoAccentTextColor = Color.Empty;
            button_finalizar.Size = new Size(134, 45);
            button_finalizar.TabIndex = 25;
            button_finalizar.Text = "FINALIZAR";
            button_finalizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_finalizar.UseAccentColor = false;
            button_finalizar.UseVisualStyleBackColor = true;
            button_finalizar.Click += Boton_Finalizar_Click;
            // 
            // txtbox_busqueda_producto
            // 
            txtbox_busqueda_producto.Anchor = AnchorStyles.None;
            txtbox_busqueda_producto.AnimateReadOnly = false;
            txtbox_busqueda_producto.BackgroundImageLayout = ImageLayout.None;
            txtbox_busqueda_producto.CharacterCasing = CharacterCasing.Normal;
            txtbox_busqueda_producto.Depth = 0;
            txtbox_busqueda_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_busqueda_producto.HideSelection = true;
            txtbox_busqueda_producto.Hint = "Código o nombre del producto";
            txtbox_busqueda_producto.LeadingIcon = null;
            txtbox_busqueda_producto.Location = new Point(101, 168);
            txtbox_busqueda_producto.MaxLength = 32767;
            txtbox_busqueda_producto.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_busqueda_producto.Name = "txtbox_busqueda_producto";
            txtbox_busqueda_producto.PasswordChar = '\0';
            txtbox_busqueda_producto.PrefixSuffixText = null;
            txtbox_busqueda_producto.ReadOnly = false;
            txtbox_busqueda_producto.RightToLeft = RightToLeft.No;
            txtbox_busqueda_producto.SelectedText = "";
            txtbox_busqueda_producto.SelectionLength = 0;
            txtbox_busqueda_producto.SelectionStart = 0;
            txtbox_busqueda_producto.ShortcutsEnabled = true;
            txtbox_busqueda_producto.Size = new Size(312, 48);
            txtbox_busqueda_producto.TabIndex = 24;
            txtbox_busqueda_producto.TabStop = false;
            txtbox_busqueda_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_busqueda_producto.TrailingIcon = null;
            txtbox_busqueda_producto.UseSystemPasswordChar = false;
            txtbox_busqueda_producto.TextChanged += Txtbox_busqueda_producto_TextChanged;
            // 
            // lbl_valorTotal
            // 
            lbl_valorTotal.Anchor = AnchorStyles.None;
            lbl_valorTotal.AutoSize = true;
            lbl_valorTotal.BackColor = Color.Transparent;
            lbl_valorTotal.Font = new Font("Arial Rounded MT Bold", 9F);
            lbl_valorTotal.ForeColor = Color.White;
            lbl_valorTotal.Location = new Point(962, 860);
            lbl_valorTotal.Name = "lbl_valorTotal";
            lbl_valorTotal.Size = new Size(88, 17);
            lbl_valorTotal.TabIndex = 22;
            lbl_valorTotal.Text = "Valor total:";
            // 
            // lbl_cantidad_productos
            // 
            lbl_cantidad_productos.Anchor = AnchorStyles.None;
            lbl_cantidad_productos.AutoSize = true;
            lbl_cantidad_productos.BackColor = Color.Transparent;
            lbl_cantidad_productos.Font = new Font("Arial Rounded MT Bold", 9F);
            lbl_cantidad_productos.ForeColor = Color.White;
            lbl_cantidad_productos.Location = new Point(722, 860);
            lbl_cantidad_productos.Name = "lbl_cantidad_productos";
            lbl_cantidad_productos.Size = new Size(178, 17);
            lbl_cantidad_productos.TabIndex = 21;
            lbl_cantidad_productos.Text = "Cantidad de productos:";
            // 
            // lbl_detalleVenta
            // 
            lbl_detalleVenta.Anchor = AnchorStyles.None;
            lbl_detalleVenta.AutoSize = true;
            lbl_detalleVenta.BackColor = Color.Transparent;
            lbl_detalleVenta.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lbl_detalleVenta.ForeColor = Color.White;
            lbl_detalleVenta.Location = new Point(522, 201);
            lbl_detalleVenta.Name = "lbl_detalleVenta";
            lbl_detalleVenta.Size = new Size(112, 15);
            lbl_detalleVenta.TabIndex = 18;
            lbl_detalleVenta.Text = "Detalle de venta";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DG_Detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DG_Detalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Detalle.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Cantidad, Subtotal });
            DG_Detalle.DataSource = detalleVentaBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DG_Detalle.DefaultCellStyle = dataGridViewCellStyle4;
            DG_Detalle.Location = new Point(522, 224);
            DG_Detalle.MultiSelect = false;
            DG_Detalle.Name = "DG_Detalle";
            DG_Detalle.RowHeadersVisible = false;
            DG_Detalle.RowHeadersWidth = 51;
            DG_Detalle.Size = new Size(963, 619);
            DG_Detalle.TabIndex = 17;
            DG_Detalle.CellValidated += DG_Detalle_CellValidated;
            DG_Detalle.CellValidating += DG_Detalle_CellValidating;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.FillWeight = 10F;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.FillWeight = 65F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "Cantidad";
            Cantidad.FillWeight = 10F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.DataPropertyName = "Subtotal";
            Subtotal.FillWeight = 15F;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // detalleVentaBindingSource
            // 
            detalleVentaBindingSource.DataSource = typeof(DetalleVenta);
            // 
            // Form_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_venta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InkPOS - Venta";
            WindowState = FormWindowState.Maximized;
            Load += Form_Venta_Load;
            panel_venta.ResumeLayout(false);
            panel_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DG_Busqueda_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DG_Detalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)detalleVentaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_venta;
        private Label lbl_valorTotal;
        private Label lbl_cantidad_productos;
        private Label lbl_detalleVenta;
        private DataGridView DG_Detalle;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
        private MaterialSkin.Controls.MaterialButton button_finalizar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_busqueda_producto;
        private Label lbl_name_cliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_cliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_Valor_total;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_Cantidad_productos;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nombre_cliente;
        private DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private BindingSource detalleVentaBindingSource;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridView DG_Busqueda_Productos;
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}