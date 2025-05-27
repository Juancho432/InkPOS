namespace InkPos
{
    partial class Form_Agregar_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar_Producto));
            panel_agregar_producto = new Panel();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            button_agregar = new MaterialSkin.Controls.MaterialButton();
            txtbox_add_precio = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_add_codigo_producto = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_add_cantidad = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_add_nombre_producto = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_precio = new Label();
            label3 = new Label();
            lbl_stock = new Label();
            lbl_codigoproducto = new Label();
            lbl_nombreproducto = new Label();
            lbl_agregarproducto = new Label();
            panel_agregar_producto.SuspendLayout();
            SuspendLayout();
            // 
            // panel_agregar_producto
            // 
            panel_agregar_producto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_agregar_producto.BackgroundImage = (Image)resources.GetObject("panel_agregar_producto.BackgroundImage");
            panel_agregar_producto.Controls.Add(button_cancelar);
            panel_agregar_producto.Controls.Add(button_limpiar);
            panel_agregar_producto.Controls.Add(button_agregar);
            panel_agregar_producto.Controls.Add(txtbox_add_precio);
            panel_agregar_producto.Controls.Add(txtbox_add_codigo_producto);
            panel_agregar_producto.Controls.Add(txtbox_add_cantidad);
            panel_agregar_producto.Controls.Add(txtbox_add_nombre_producto);
            panel_agregar_producto.Controls.Add(lbl_precio);
            panel_agregar_producto.Controls.Add(label3);
            panel_agregar_producto.Controls.Add(lbl_stock);
            panel_agregar_producto.Controls.Add(lbl_codigoproducto);
            panel_agregar_producto.Controls.Add(lbl_nombreproducto);
            panel_agregar_producto.Controls.Add(lbl_agregarproducto);
            panel_agregar_producto.Location = new Point(5, 2);
            panel_agregar_producto.Name = "panel_agregar_producto";
            panel_agregar_producto.Size = new Size(1513, 1051);
            panel_agregar_producto.TabIndex = 0;
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
            button_cancelar.Location = new Point(780, 797);
            button_cancelar.Margin = new Padding(4, 6, 4, 6);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(134, 45);
            button_cancelar.TabIndex = 35;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.AutoSize = false;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(918, 683);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(134, 45);
            button_limpiar.TabIndex = 34;
            button_limpiar.Text = "limpiar";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // button_agregar
            // 
            button_agregar.Anchor = AnchorStyles.None;
            button_agregar.AutoSize = false;
            button_agregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_agregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_agregar.Depth = 0;
            button_agregar.HighEmphasis = true;
            button_agregar.Icon = null;
            button_agregar.Location = new Point(665, 683);
            button_agregar.Margin = new Padding(4, 6, 4, 6);
            button_agregar.MouseState = MaterialSkin.MouseState.HOVER;
            button_agregar.Name = "button_agregar";
            button_agregar.NoAccentTextColor = Color.Empty;
            button_agregar.Size = new Size(134, 45);
            button_agregar.TabIndex = 33;
            button_agregar.Text = "agregar";
            button_agregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_agregar.UseAccentColor = false;
            button_agregar.UseVisualStyleBackColor = true;
            button_agregar.Click += button_agregar_Click;
            // 
            // txtbox_add_precio
            // 
            txtbox_add_precio.Anchor = AnchorStyles.None;
            txtbox_add_precio.AnimateReadOnly = false;
            txtbox_add_precio.BackgroundImageLayout = ImageLayout.None;
            txtbox_add_precio.CharacterCasing = CharacterCasing.Normal;
            txtbox_add_precio.Depth = 0;
            txtbox_add_precio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_add_precio.HideSelection = true;
            txtbox_add_precio.LeadingIcon = null;
            txtbox_add_precio.Location = new Point(750, 538);
            txtbox_add_precio.MaxLength = 32767;
            txtbox_add_precio.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_add_precio.Name = "txtbox_add_precio";
            txtbox_add_precio.PasswordChar = '\0';
            txtbox_add_precio.PrefixSuffixText = null;
            txtbox_add_precio.ReadOnly = false;
            txtbox_add_precio.RightToLeft = RightToLeft.No;
            txtbox_add_precio.SelectedText = "";
            txtbox_add_precio.SelectionLength = 0;
            txtbox_add_precio.SelectionStart = 0;
            txtbox_add_precio.ShortcutsEnabled = true;
            txtbox_add_precio.Size = new Size(220, 48);
            txtbox_add_precio.TabIndex = 32;
            txtbox_add_precio.TabStop = false;
            txtbox_add_precio.TextAlign = HorizontalAlignment.Left;
            txtbox_add_precio.TrailingIcon = null;
            txtbox_add_precio.UseSystemPasswordChar = false;
            // 
            // txtbox_add_codigo_producto
            // 
            txtbox_add_codigo_producto.Anchor = AnchorStyles.None;
            txtbox_add_codigo_producto.AnimateReadOnly = false;
            txtbox_add_codigo_producto.BackgroundImageLayout = ImageLayout.None;
            txtbox_add_codigo_producto.CharacterCasing = CharacterCasing.Normal;
            txtbox_add_codigo_producto.Depth = 0;
            txtbox_add_codigo_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_add_codigo_producto.HideSelection = true;
            txtbox_add_codigo_producto.LeadingIcon = null;
            txtbox_add_codigo_producto.Location = new Point(750, 312);
            txtbox_add_codigo_producto.MaxLength = 32767;
            txtbox_add_codigo_producto.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_add_codigo_producto.Name = "txtbox_add_codigo_producto";
            txtbox_add_codigo_producto.PasswordChar = '\0';
            txtbox_add_codigo_producto.PrefixSuffixText = null;
            txtbox_add_codigo_producto.ReadOnly = false;
            txtbox_add_codigo_producto.RightToLeft = RightToLeft.No;
            txtbox_add_codigo_producto.SelectedText = "";
            txtbox_add_codigo_producto.SelectionLength = 0;
            txtbox_add_codigo_producto.SelectionStart = 0;
            txtbox_add_codigo_producto.ShortcutsEnabled = true;
            txtbox_add_codigo_producto.Size = new Size(220, 48);
            txtbox_add_codigo_producto.TabIndex = 31;
            txtbox_add_codigo_producto.TabStop = false;
            txtbox_add_codigo_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_add_codigo_producto.TrailingIcon = null;
            txtbox_add_codigo_producto.UseSystemPasswordChar = false;
            // 
            // txtbox_add_cantidad
            // 
            txtbox_add_cantidad.Anchor = AnchorStyles.None;
            txtbox_add_cantidad.AnimateReadOnly = false;
            txtbox_add_cantidad.BackgroundImageLayout = ImageLayout.None;
            txtbox_add_cantidad.CharacterCasing = CharacterCasing.Normal;
            txtbox_add_cantidad.Depth = 0;
            txtbox_add_cantidad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_add_cantidad.HideSelection = true;
            txtbox_add_cantidad.LeadingIcon = null;
            txtbox_add_cantidad.Location = new Point(750, 464);
            txtbox_add_cantidad.MaxLength = 32767;
            txtbox_add_cantidad.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_add_cantidad.Name = "txtbox_add_cantidad";
            txtbox_add_cantidad.PasswordChar = '\0';
            txtbox_add_cantidad.PrefixSuffixText = null;
            txtbox_add_cantidad.ReadOnly = false;
            txtbox_add_cantidad.RightToLeft = RightToLeft.No;
            txtbox_add_cantidad.SelectedText = "";
            txtbox_add_cantidad.SelectionLength = 0;
            txtbox_add_cantidad.SelectionStart = 0;
            txtbox_add_cantidad.ShortcutsEnabled = true;
            txtbox_add_cantidad.Size = new Size(220, 48);
            txtbox_add_cantidad.TabIndex = 30;
            txtbox_add_cantidad.TabStop = false;
            txtbox_add_cantidad.TextAlign = HorizontalAlignment.Left;
            txtbox_add_cantidad.TrailingIcon = null;
            txtbox_add_cantidad.UseSystemPasswordChar = false;
            // 
            // txtbox_add_nombre_producto
            // 
            txtbox_add_nombre_producto.Anchor = AnchorStyles.None;
            txtbox_add_nombre_producto.AnimateReadOnly = false;
            txtbox_add_nombre_producto.BackgroundImageLayout = ImageLayout.None;
            txtbox_add_nombre_producto.CharacterCasing = CharacterCasing.Normal;
            txtbox_add_nombre_producto.Depth = 0;
            txtbox_add_nombre_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_add_nombre_producto.HideSelection = true;
            txtbox_add_nombre_producto.LeadingIcon = null;
            txtbox_add_nombre_producto.Location = new Point(750, 224);
            txtbox_add_nombre_producto.MaxLength = 32767;
            txtbox_add_nombre_producto.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_add_nombre_producto.Name = "txtbox_add_nombre_producto";
            txtbox_add_nombre_producto.PasswordChar = '\0';
            txtbox_add_nombre_producto.PrefixSuffixText = null;
            txtbox_add_nombre_producto.ReadOnly = false;
            txtbox_add_nombre_producto.RightToLeft = RightToLeft.No;
            txtbox_add_nombre_producto.SelectedText = "";
            txtbox_add_nombre_producto.SelectionLength = 0;
            txtbox_add_nombre_producto.SelectionStart = 0;
            txtbox_add_nombre_producto.ShortcutsEnabled = true;
            txtbox_add_nombre_producto.Size = new Size(220, 48);
            txtbox_add_nombre_producto.TabIndex = 29;
            txtbox_add_nombre_producto.TabStop = false;
            txtbox_add_nombre_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_add_nombre_producto.TrailingIcon = null;
            txtbox_add_nombre_producto.UseSystemPasswordChar = false;
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.None;
            lbl_precio.AutoSize = true;
            lbl_precio.BackColor = Color.Transparent;
            lbl_precio.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_precio.ForeColor = Color.White;
            lbl_precio.Location = new Point(665, 550);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(79, 23);
            lbl_precio.TabIndex = 21;
            lbl_precio.Text = "Precio:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(639, 476);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 20;
            label3.Text = "Cantidad:";
            // 
            // lbl_stock
            // 
            lbl_stock.Anchor = AnchorStyles.None;
            lbl_stock.AutoSize = true;
            lbl_stock.BackColor = Color.Transparent;
            lbl_stock.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_stock.ForeColor = Color.White;
            lbl_stock.Location = new Point(665, 413);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(79, 23);
            lbl_stock.TabIndex = 19;
            lbl_stock.Text = "(Stock)";
            // 
            // lbl_codigoproducto
            // 
            lbl_codigoproducto.Anchor = AnchorStyles.None;
            lbl_codigoproducto.AutoSize = true;
            lbl_codigoproducto.BackColor = Color.Transparent;
            lbl_codigoproducto.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_codigoproducto.ForeColor = Color.White;
            lbl_codigoproducto.Location = new Point(528, 323);
            lbl_codigoproducto.Name = "lbl_codigoproducto";
            lbl_codigoproducto.Size = new Size(216, 23);
            lbl_codigoproducto.TabIndex = 18;
            lbl_codigoproducto.Text = "Código del producto:";
            // 
            // lbl_nombreproducto
            // 
            lbl_nombreproducto.Anchor = AnchorStyles.None;
            lbl_nombreproducto.AutoSize = true;
            lbl_nombreproducto.BackColor = Color.Transparent;
            lbl_nombreproducto.Font = new Font("Arial Rounded MT Bold", 12F);
            lbl_nombreproducto.ForeColor = Color.White;
            lbl_nombreproducto.Location = new Point(519, 239);
            lbl_nombreproducto.Name = "lbl_nombreproducto";
            lbl_nombreproducto.Size = new Size(225, 23);
            lbl_nombreproducto.TabIndex = 17;
            lbl_nombreproducto.Text = "Nombre del producto:";
            // 
            // lbl_agregarproducto
            // 
            lbl_agregarproducto.Anchor = AnchorStyles.None;
            lbl_agregarproducto.AutoSize = true;
            lbl_agregarproducto.BackColor = Color.Transparent;
            lbl_agregarproducto.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_agregarproducto.ForeColor = Color.White;
            lbl_agregarproducto.Location = new Point(585, 78);
            lbl_agregarproducto.Name = "lbl_agregarproducto";
            lbl_agregarproducto.Size = new Size(433, 54);
            lbl_agregarproducto.TabIndex = 14;
            lbl_agregarproducto.Text = "Agregar producto";
            // 
            // Form_Agregar_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_agregar_producto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Agregar_Producto";
            Text = "InkPOS _ Agregar Producto";
            WindowState = FormWindowState.Maximized;
            panel_agregar_producto.ResumeLayout(false);
            panel_agregar_producto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_agregar_producto;
        private Label lbl_precio;
        private Label label3;
        private Label lbl_stock;
        private Label lbl_codigoproducto;
        private Label lbl_nombreproducto;
        private Label lbl_agregarproducto;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_add_precio;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_add_codigo_producto;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_add_cantidad;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_add_nombre_producto;
        private MaterialSkin.Controls.MaterialButton button_agregar;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
    }
}