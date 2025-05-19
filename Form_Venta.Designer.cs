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
            panel_venta = new Panel();
            txtbox_nombre_cliente = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_name_cliente = new Label();
            txtbox_buscar_cliente = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_Valor_total = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_Cantidad_productos = new MaterialSkin.Controls.MaterialTextBox2();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_finalizar = new MaterialSkin.Controls.MaterialButton();
            txtbox_busqueda_producto = new MaterialSkin.Controls.MaterialTextBox2();
            lista_Coincidencias = new ListBox();
            lbl_valorTotal = new Label();
            lbl_cantidad_productos = new Label();
            lbl_detalleVenta = new Label();
            tabla_Productos = new DataGridView();
            column_codigo = new DataGridViewTextBoxColumn();
            column_NombreP = new DataGridViewTextBoxColumn();
            column_cantidad = new DataGridViewTextBoxColumn();
            column_valor = new DataGridViewTextBoxColumn();
            panel_venta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_Productos).BeginInit();
            SuspendLayout();
            // 
            // panel_venta
            // 
            panel_venta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_venta.Controls.Add(txtbox_nombre_cliente);
            panel_venta.Controls.Add(lbl_name_cliente);
            panel_venta.Controls.Add(txtbox_buscar_cliente);
            panel_venta.Controls.Add(txtbox_Valor_total);
            panel_venta.Controls.Add(txtbox_Cantidad_productos);
            panel_venta.Controls.Add(button_cancelar);
            panel_venta.Controls.Add(button_finalizar);
            panel_venta.Controls.Add(txtbox_busqueda_producto);
            panel_venta.Controls.Add(lista_Coincidencias);
            panel_venta.Controls.Add(lbl_valorTotal);
            panel_venta.Controls.Add(lbl_cantidad_productos);
            panel_venta.Controls.Add(lbl_detalleVenta);
            panel_venta.Controls.Add(tabla_Productos);
            panel_venta.Location = new Point(4, 2);
            panel_venta.Margin = new Padding(3, 2, 3, 2);
            panel_venta.Name = "panel_venta";
            panel_venta.Size = new Size(1324, 878);
            panel_venta.TabIndex = 0;
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
            txtbox_nombre_cliente.Location = new Point(651, 80);
            txtbox_nombre_cliente.Margin = new Padding(3, 2, 3, 2);
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
            txtbox_nombre_cliente.Size = new Size(409, 48);
            txtbox_nombre_cliente.TabIndex = 32;
            txtbox_nombre_cliente.TabStop = false;
            txtbox_nombre_cliente.TextAlign = HorizontalAlignment.Left;
            txtbox_nombre_cliente.TrailingIcon = null;
            txtbox_nombre_cliente.UseSystemPasswordChar = false;
            // 
            // lbl_name_cliente
            // 
            lbl_name_cliente.AutoSize = true;
            lbl_name_cliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_name_cliente.Location = new Point(542, 88);
            lbl_name_cliente.Name = "lbl_name_cliente";
            lbl_name_cliente.Size = new Size(85, 30);
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
            txtbox_buscar_cliente.Hint = "Ingrese el nombre o ID del cliente";
            txtbox_buscar_cliente.LeadingIcon = null;
            txtbox_buscar_cliente.Location = new Point(129, 80);
            txtbox_buscar_cliente.Margin = new Padding(3, 2, 3, 2);
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
            txtbox_buscar_cliente.Size = new Size(228, 48);
            txtbox_buscar_cliente.TabIndex = 29;
            txtbox_buscar_cliente.TabStop = false;
            txtbox_buscar_cliente.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_cliente.TrailingIcon = null;
            txtbox_buscar_cliente.UseSystemPasswordChar = false;
            txtbox_buscar_cliente.TextChanged += txtbox_buscar_cliente_TextChanged;
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
            txtbox_Valor_total.Location = new Point(842, 578);
            txtbox_Valor_total.Margin = new Padding(3, 2, 3, 2);
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
            txtbox_Valor_total.Size = new Size(192, 48);
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
            txtbox_Cantidad_productos.Location = new Point(643, 578);
            txtbox_Cantidad_productos.Margin = new Padding(3, 2, 3, 2);
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
            txtbox_Cantidad_productos.Size = new Size(144, 48);
            txtbox_Cantidad_productos.TabIndex = 27;
            txtbox_Cantidad_productos.TabStop = false;
            txtbox_Cantidad_productos.TextAlign = HorizontalAlignment.Left;
            txtbox_Cantidad_productos.TrailingIcon = null;
            txtbox_Cantidad_productos.UseSystemPasswordChar = false;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(858, 660);
            button_cancelar.Margin = new Padding(4);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(96, 36);
            button_cancelar.TabIndex = 26;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_finalizar
            // 
            button_finalizar.Anchor = AnchorStyles.None;
            button_finalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_finalizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_finalizar.Depth = 0;
            button_finalizar.HighEmphasis = true;
            button_finalizar.Icon = null;
            button_finalizar.Location = new Point(704, 660);
            button_finalizar.Margin = new Padding(4);
            button_finalizar.MouseState = MaterialSkin.MouseState.HOVER;
            button_finalizar.Name = "button_finalizar";
            button_finalizar.NoAccentTextColor = Color.Empty;
            button_finalizar.Size = new Size(94, 36);
            button_finalizar.TabIndex = 25;
            button_finalizar.Text = "FINALIZAR";
            button_finalizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_finalizar.UseAccentColor = false;
            button_finalizar.UseVisualStyleBackColor = true;
            button_finalizar.Click += button_finalizar_Click;
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
            txtbox_busqueda_producto.Hint = "(F4) Código/nombre del producto";
            txtbox_busqueda_producto.LeadingIcon = null;
            txtbox_busqueda_producto.Location = new Point(105, 246);
            txtbox_busqueda_producto.Margin = new Padding(3, 2, 3, 2);
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
            txtbox_busqueda_producto.Size = new Size(273, 48);
            txtbox_busqueda_producto.TabIndex = 24;
            txtbox_busqueda_producto.TabStop = false;
            txtbox_busqueda_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_busqueda_producto.TrailingIcon = null;
            txtbox_busqueda_producto.UseSystemPasswordChar = false;
            txtbox_busqueda_producto.TextChanged += txtbox_busqueda_producto_TextChanged;
            // 
            // lista_Coincidencias
            // 
            lista_Coincidencias.Anchor = AnchorStyles.None;
            lista_Coincidencias.FormattingEnabled = true;
            lista_Coincidencias.ItemHeight = 15;
            lista_Coincidencias.Location = new Point(105, 327);
            lista_Coincidencias.Margin = new Padding(3, 2, 3, 2);
            lista_Coincidencias.Name = "lista_Coincidencias";
            lista_Coincidencias.Size = new Size(274, 214);
            lista_Coincidencias.TabIndex = 16;
            lista_Coincidencias.DoubleClick += lista_Coincidencias_DoubleClick;
            lista_Coincidencias.KeyPress += lista_Coincidencias_KeyPress;
            // 
            // lbl_valorTotal
            // 
            lbl_valorTotal.Anchor = AnchorStyles.None;
            lbl_valorTotal.AutoSize = true;
            lbl_valorTotal.Location = new Point(842, 561);
            lbl_valorTotal.Name = "lbl_valorTotal";
            lbl_valorTotal.Size = new Size(63, 15);
            lbl_valorTotal.TabIndex = 22;
            lbl_valorTotal.Text = "Valor total:";
            // 
            // lbl_cantidad_productos
            // 
            lbl_cantidad_productos.Anchor = AnchorStyles.None;
            lbl_cantidad_productos.AutoSize = true;
            lbl_cantidad_productos.Location = new Point(643, 561);
            lbl_cantidad_productos.Name = "lbl_cantidad_productos";
            lbl_cantidad_productos.Size = new Size(131, 15);
            lbl_cantidad_productos.TabIndex = 21;
            lbl_cantidad_productos.Text = "Cantidad de productos:";
            // 
            // lbl_detalleVenta
            // 
            lbl_detalleVenta.Anchor = AnchorStyles.None;
            lbl_detalleVenta.AutoSize = true;
            lbl_detalleVenta.Location = new Point(457, 229);
            lbl_detalleVenta.Name = "lbl_detalleVenta";
            lbl_detalleVenta.Size = new Size(91, 15);
            lbl_detalleVenta.TabIndex = 18;
            lbl_detalleVenta.Text = "Detalle de venta";
            // 
            // tabla_Productos
            // 
            tabla_Productos.Anchor = AnchorStyles.None;
            tabla_Productos.BackgroundColor = SystemColors.ControlLight;
            tabla_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_Productos.Columns.AddRange(new DataGridViewColumn[] { column_codigo, column_NombreP, column_cantidad, column_valor });
            tabla_Productos.Location = new Point(457, 246);
            tabla_Productos.Margin = new Padding(3, 2, 3, 2);
            tabla_Productos.Name = "tabla_Productos";
            tabla_Productos.RowHeadersWidth = 51;
            tabla_Productos.Size = new Size(746, 297);
            tabla_Productos.TabIndex = 17;
            tabla_Productos.CellValidating += tabla_Productos_CellValidating;
            tabla_Productos.CellValueChanged += tabla_Productos_CellValueChanged;
            tabla_Productos.KeyDown += tabla_Productos_KeyDown;
            // 
            // column_codigo
            // 
            column_codigo.HeaderText = "Código";
            column_codigo.MinimumWidth = 6;
            column_codigo.Name = "column_codigo";
            column_codigo.ReadOnly = true;
            column_codigo.Width = 200;
            // 
            // column_NombreP
            // 
            column_NombreP.HeaderText = "Producto";
            column_NombreP.MinimumWidth = 6;
            column_NombreP.Name = "column_NombreP";
            column_NombreP.ReadOnly = true;
            column_NombreP.Width = 200;
            // 
            // column_cantidad
            // 
            column_cantidad.HeaderText = "Cantidad";
            column_cantidad.MinimumWidth = 6;
            column_cantidad.Name = "column_cantidad";
            column_cantidad.Width = 200;
            // 
            // column_valor
            // 
            column_valor.HeaderText = "Valor";
            column_valor.MinimumWidth = 6;
            column_valor.Name = "column_valor";
            column_valor.ReadOnly = true;
            column_valor.Width = 200;
            // 
            // Form_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 796);
            Controls.Add(panel_venta);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Venta";
            Text = "InkPOS - Venta";
            WindowState = FormWindowState.Maximized;
            panel_venta.ResumeLayout(false);
            panel_venta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_Productos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_venta;
        private ListBox lista_Coincidencias;
        private Label lbl_valorTotal;
        private Label lbl_cantidad_productos;
        private Label lbl_detalleVenta;
        private DataGridView tabla_Productos;
        private DataGridViewTextBoxColumn column_codigo;
        private DataGridViewTextBoxColumn column_NombreP;
        private DataGridViewTextBoxColumn column_cantidad;
        private DataGridViewTextBoxColumn column_valor;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
        private MaterialSkin.Controls.MaterialButton button_finalizar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_busqueda_producto;
        private Label lbl_name_cliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_cliente;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_Valor_total;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_Cantidad_productos;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nombre_cliente;
    }
}