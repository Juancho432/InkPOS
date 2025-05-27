namespace InkPos
{
    partial class Form_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Devolucion));
            panel_devolucion = new Panel();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_confirmar = new MaterialSkin.Controls.MaterialButton();
            txtbox_codigo_producto = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_cantidad_producto = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_ID_factura = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_NombreCodigo_Producto = new Label();
            lbl_cantidad = new Label();
            lbl_fve = new Label();
            lbl_devolucion = new Label();
            panel_devolucion.SuspendLayout();
            SuspendLayout();
            // 
            // panel_devolucion
            // 
            panel_devolucion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_devolucion.BackgroundImage = (Image)resources.GetObject("panel_devolucion.BackgroundImage");
            panel_devolucion.Controls.Add(button_cancelar);
            panel_devolucion.Controls.Add(button_confirmar);
            panel_devolucion.Controls.Add(txtbox_codigo_producto);
            panel_devolucion.Controls.Add(txtbox_cantidad_producto);
            panel_devolucion.Controls.Add(txtbox_ID_factura);
            panel_devolucion.Controls.Add(lbl_NombreCodigo_Producto);
            panel_devolucion.Controls.Add(lbl_cantidad);
            panel_devolucion.Controls.Add(lbl_fve);
            panel_devolucion.Controls.Add(lbl_devolucion);
            panel_devolucion.Location = new Point(5, 2);
            panel_devolucion.Name = "panel_devolucion";
            panel_devolucion.Size = new Size(1513, 1051);
            panel_devolucion.TabIndex = 0;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSize = false;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.ForeColor = Color.Transparent;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(858, 630);
            button_cancelar.Margin = new Padding(4, 6, 4, 6);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(134, 45);
            button_cancelar.TabIndex = 14;
            button_cancelar.Text = "Cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.AutoSize = false;
            button_confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_confirmar.Depth = 0;
            button_confirmar.ForeColor = Color.Transparent;
            button_confirmar.HighEmphasis = true;
            button_confirmar.Icon = null;
            button_confirmar.Location = new Point(613, 630);
            button_confirmar.Margin = new Padding(4, 6, 4, 6);
            button_confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            button_confirmar.Name = "button_confirmar";
            button_confirmar.NoAccentTextColor = Color.Empty;
            button_confirmar.Size = new Size(134, 45);
            button_confirmar.TabIndex = 13;
            button_confirmar.Text = "Confirmar";
            button_confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_confirmar.UseAccentColor = false;
            button_confirmar.UseVisualStyleBackColor = true;
            button_confirmar.Click += button_confirmar_Click;
            // 
            // txtbox_codigo_producto
            // 
            txtbox_codigo_producto.Anchor = AnchorStyles.None;
            txtbox_codigo_producto.AnimateReadOnly = false;
            txtbox_codigo_producto.BackgroundImageLayout = ImageLayout.None;
            txtbox_codigo_producto.CharacterCasing = CharacterCasing.Normal;
            txtbox_codigo_producto.Depth = 0;
            txtbox_codigo_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_codigo_producto.HideSelection = true;
            txtbox_codigo_producto.LeadingIcon = null;
            txtbox_codigo_producto.Location = new Point(678, 374);
            txtbox_codigo_producto.MaxLength = 32767;
            txtbox_codigo_producto.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_codigo_producto.Name = "txtbox_codigo_producto";
            txtbox_codigo_producto.PasswordChar = '\0';
            txtbox_codigo_producto.PrefixSuffixText = null;
            txtbox_codigo_producto.ReadOnly = false;
            txtbox_codigo_producto.RightToLeft = RightToLeft.No;
            txtbox_codigo_producto.SelectedText = "";
            txtbox_codigo_producto.SelectionLength = 0;
            txtbox_codigo_producto.SelectionStart = 0;
            txtbox_codigo_producto.ShortcutsEnabled = true;
            txtbox_codigo_producto.Size = new Size(312, 48);
            txtbox_codigo_producto.TabIndex = 12;
            txtbox_codigo_producto.TabStop = false;
            txtbox_codigo_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_codigo_producto.TrailingIcon = null;
            txtbox_codigo_producto.UseSystemPasswordChar = false;
            // 
            // txtbox_cantidad_producto
            // 
            txtbox_cantidad_producto.Anchor = AnchorStyles.None;
            txtbox_cantidad_producto.AnimateReadOnly = false;
            txtbox_cantidad_producto.BackgroundImageLayout = ImageLayout.None;
            txtbox_cantidad_producto.CharacterCasing = CharacterCasing.Normal;
            txtbox_cantidad_producto.Depth = 0;
            txtbox_cantidad_producto.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_cantidad_producto.HideSelection = true;
            txtbox_cantidad_producto.LeadingIcon = null;
            txtbox_cantidad_producto.Location = new Point(678, 451);
            txtbox_cantidad_producto.MaxLength = 32767;
            txtbox_cantidad_producto.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_cantidad_producto.Name = "txtbox_cantidad_producto";
            txtbox_cantidad_producto.PasswordChar = '\0';
            txtbox_cantidad_producto.PrefixSuffixText = null;
            txtbox_cantidad_producto.ReadOnly = false;
            txtbox_cantidad_producto.RightToLeft = RightToLeft.No;
            txtbox_cantidad_producto.SelectedText = "";
            txtbox_cantidad_producto.SelectionLength = 0;
            txtbox_cantidad_producto.SelectionStart = 0;
            txtbox_cantidad_producto.ShortcutsEnabled = true;
            txtbox_cantidad_producto.Size = new Size(312, 48);
            txtbox_cantidad_producto.TabIndex = 11;
            txtbox_cantidad_producto.TabStop = false;
            txtbox_cantidad_producto.TextAlign = HorizontalAlignment.Left;
            txtbox_cantidad_producto.TrailingIcon = null;
            txtbox_cantidad_producto.UseSystemPasswordChar = false;
            // 
            // txtbox_ID_factura
            // 
            txtbox_ID_factura.Anchor = AnchorStyles.None;
            txtbox_ID_factura.AnimateReadOnly = false;
            txtbox_ID_factura.BackgroundImageLayout = ImageLayout.None;
            txtbox_ID_factura.CharacterCasing = CharacterCasing.Normal;
            txtbox_ID_factura.Depth = 0;
            txtbox_ID_factura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_ID_factura.HideSelection = true;
            txtbox_ID_factura.LeadingIcon = null;
            txtbox_ID_factura.Location = new Point(678, 297);
            txtbox_ID_factura.MaxLength = 32767;
            txtbox_ID_factura.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_ID_factura.Name = "txtbox_ID_factura";
            txtbox_ID_factura.PasswordChar = '\0';
            txtbox_ID_factura.PrefixSuffixText = null;
            txtbox_ID_factura.ReadOnly = false;
            txtbox_ID_factura.RightToLeft = RightToLeft.No;
            txtbox_ID_factura.SelectedText = "";
            txtbox_ID_factura.SelectionLength = 0;
            txtbox_ID_factura.SelectionStart = 0;
            txtbox_ID_factura.ShortcutsEnabled = true;
            txtbox_ID_factura.Size = new Size(312, 48);
            txtbox_ID_factura.TabIndex = 10;
            txtbox_ID_factura.TabStop = false;
            txtbox_ID_factura.TextAlign = HorizontalAlignment.Left;
            txtbox_ID_factura.TrailingIcon = null;
            txtbox_ID_factura.UseSystemPasswordChar = false;
            // 
            // lbl_NombreCodigo_Producto
            // 
            lbl_NombreCodigo_Producto.Anchor = AnchorStyles.None;
            lbl_NombreCodigo_Producto.AutoSize = true;
            lbl_NombreCodigo_Producto.BackColor = Color.Transparent;
            lbl_NombreCodigo_Producto.Font = new Font("Arial Rounded MT Bold", 13.8F);
            lbl_NombreCodigo_Producto.ForeColor = Color.White;
            lbl_NombreCodigo_Producto.Location = new Point(401, 391);
            lbl_NombreCodigo_Producto.Name = "lbl_NombreCodigo_Producto";
            lbl_NombreCodigo_Producto.Size = new Size(246, 27);
            lbl_NombreCodigo_Producto.TabIndex = 9;
            lbl_NombreCodigo_Producto.Text = "Código del producto:";
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.Anchor = AnchorStyles.None;
            lbl_cantidad.AutoSize = true;
            lbl_cantidad.BackColor = Color.Transparent;
            lbl_cantidad.Font = new Font("Arial Rounded MT Bold", 13.8F);
            lbl_cantidad.ForeColor = Color.White;
            lbl_cantidad.Location = new Point(514, 468);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(126, 27);
            lbl_cantidad.TabIndex = 8;
            lbl_cantidad.Text = "Cantidad: ";
            // 
            // lbl_fve
            // 
            lbl_fve.Anchor = AnchorStyles.None;
            lbl_fve.AutoSize = true;
            lbl_fve.BackColor = Color.Transparent;
            lbl_fve.Font = new Font("Arial Rounded MT Bold", 13.8F);
            lbl_fve.ForeColor = Color.White;
            lbl_fve.Location = new Point(478, 314);
            lbl_fve.Name = "lbl_fve";
            lbl_fve.Size = new Size(167, 27);
            lbl_fve.TabIndex = 7;
            lbl_fve.Text = "N° de factura:";
            // 
            // lbl_devolucion
            // 
            lbl_devolucion.Anchor = AnchorStyles.None;
            lbl_devolucion.AutoSize = true;
            lbl_devolucion.BackColor = Color.Transparent;
            lbl_devolucion.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_devolucion.ForeColor = Color.White;
            lbl_devolucion.Location = new Point(669, 126);
            lbl_devolucion.Name = "lbl_devolucion";
            lbl_devolucion.Size = new Size(277, 54);
            lbl_devolucion.TabIndex = 6;
            lbl_devolucion.Text = "Devolución";
            // 
            // Form_Devolucion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_devolucion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Devolucion";
            Text = "InkPOS - Devolución";
            WindowState = FormWindowState.Maximized;
            panel_devolucion.ResumeLayout(false);
            panel_devolucion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_devolucion;
        private Label lbl_devolucion;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_codigo_producto;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_cantidad_producto;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_ID_factura;
        private Label lbl_NombreCodigo_Producto;
        private Label lbl_cantidad;
        private Label lbl_fve;
        private MaterialSkin.Controls.MaterialButton button_confirmar;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
    }
}