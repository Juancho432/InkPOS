namespace InkPos
{
    partial class Form_Busqueda_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Busqueda_factura));
            panel1 = new Panel();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_imprimir = new Button();
            link_label_Ver = new LinkLabel();
            txtbox_mostrar_N_factura = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_ingresar_N_factura = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_busquda_facturas = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button_cancelar);
            panel1.Controls.Add(button_imprimir);
            panel1.Controls.Add(link_label_Ver);
            panel1.Controls.Add(txtbox_mostrar_N_factura);
            panel1.Controls.Add(txtbox_ingresar_N_factura);
            panel1.Controls.Add(lbl_busquda_facturas);
            panel1.Location = new Point(4, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1324, 878);
            panel1.TabIndex = 0;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(618, 464);
            button_cancelar.Margin = new Padding(4, 4, 4, 4);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(96, 36);
            button_cancelar.TabIndex = 27;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_imprimir
            // 
            button_imprimir.Image = (Image)resources.GetObject("button_imprimir.Image");
            button_imprimir.Location = new Point(760, 307);
            button_imprimir.Margin = new Padding(3, 2, 3, 2);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new Size(60, 36);
            button_imprimir.TabIndex = 10;
            button_imprimir.UseVisualStyleBackColor = true;
            // 
            // link_label_Ver
            // 
            link_label_Ver.AutoSize = true;
            link_label_Ver.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_label_Ver.Location = new Point(652, 314);
            link_label_Ver.Name = "link_label_Ver";
            link_label_Ver.Size = new Size(46, 30);
            link_label_Ver.TabIndex = 9;
            link_label_Ver.TabStop = true;
            link_label_Ver.Text = "Ver";
            // 
            // txtbox_mostrar_N_factura
            // 
            txtbox_mostrar_N_factura.Anchor = AnchorStyles.None;
            txtbox_mostrar_N_factura.AnimateReadOnly = false;
            txtbox_mostrar_N_factura.BackgroundImageLayout = ImageLayout.None;
            txtbox_mostrar_N_factura.CharacterCasing = CharacterCasing.Normal;
            txtbox_mostrar_N_factura.Depth = 0;
            txtbox_mostrar_N_factura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_mostrar_N_factura.HideSelection = true;
            txtbox_mostrar_N_factura.LeadingIcon = null;
            txtbox_mostrar_N_factura.Location = new Point(360, 307);
            txtbox_mostrar_N_factura.Margin = new Padding(3, 2, 3, 2);
            txtbox_mostrar_N_factura.MaxLength = 32767;
            txtbox_mostrar_N_factura.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_mostrar_N_factura.Name = "txtbox_mostrar_N_factura";
            txtbox_mostrar_N_factura.PasswordChar = '\0';
            txtbox_mostrar_N_factura.PrefixSuffixText = null;
            txtbox_mostrar_N_factura.ReadOnly = true;
            txtbox_mostrar_N_factura.RightToLeft = RightToLeft.No;
            txtbox_mostrar_N_factura.SelectedText = "";
            txtbox_mostrar_N_factura.SelectionLength = 0;
            txtbox_mostrar_N_factura.SelectionStart = 0;
            txtbox_mostrar_N_factura.ShortcutsEnabled = true;
            txtbox_mostrar_N_factura.Size = new Size(236, 48);
            txtbox_mostrar_N_factura.TabIndex = 8;
            txtbox_mostrar_N_factura.TabStop = false;
            txtbox_mostrar_N_factura.TextAlign = HorizontalAlignment.Center;
            txtbox_mostrar_N_factura.TrailingIcon = null;
            txtbox_mostrar_N_factura.UseSystemPasswordChar = false;
            // 
            // txtbox_ingresar_N_factura
            // 
            txtbox_ingresar_N_factura.Anchor = AnchorStyles.None;
            txtbox_ingresar_N_factura.AnimateReadOnly = false;
            txtbox_ingresar_N_factura.BackgroundImageLayout = ImageLayout.None;
            txtbox_ingresar_N_factura.CharacterCasing = CharacterCasing.Normal;
            txtbox_ingresar_N_factura.Depth = 0;
            txtbox_ingresar_N_factura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_ingresar_N_factura.HideSelection = true;
            txtbox_ingresar_N_factura.Hint = "Ingrese el N° de factura";
            txtbox_ingresar_N_factura.LeadingIcon = null;
            txtbox_ingresar_N_factura.Location = new Point(541, 190);
            txtbox_ingresar_N_factura.Margin = new Padding(3, 2, 3, 2);
            txtbox_ingresar_N_factura.MaxLength = 32767;
            txtbox_ingresar_N_factura.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_ingresar_N_factura.Name = "txtbox_ingresar_N_factura";
            txtbox_ingresar_N_factura.PasswordChar = '\0';
            txtbox_ingresar_N_factura.PrefixSuffixText = null;
            txtbox_ingresar_N_factura.ReadOnly = false;
            txtbox_ingresar_N_factura.RightToLeft = RightToLeft.No;
            txtbox_ingresar_N_factura.SelectedText = "";
            txtbox_ingresar_N_factura.SelectionLength = 0;
            txtbox_ingresar_N_factura.SelectionStart = 0;
            txtbox_ingresar_N_factura.ShortcutsEnabled = true;
            txtbox_ingresar_N_factura.Size = new Size(236, 48);
            txtbox_ingresar_N_factura.TabIndex = 7;
            txtbox_ingresar_N_factura.TabStop = false;
            txtbox_ingresar_N_factura.TextAlign = HorizontalAlignment.Center;
            txtbox_ingresar_N_factura.TrailingIcon = null;
            txtbox_ingresar_N_factura.UseSystemPasswordChar = false;
            // 
            // lbl_busquda_facturas
            // 
            lbl_busquda_facturas.Anchor = AnchorStyles.None;
            lbl_busquda_facturas.AutoSize = true;
            lbl_busquda_facturas.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_busquda_facturas.Location = new Point(450, 70);
            lbl_busquda_facturas.Name = "lbl_busquda_facturas";
            lbl_busquda_facturas.Size = new Size(381, 51);
            lbl_busquda_facturas.TabIndex = 4;
            lbl_busquda_facturas.Text = "Búsqueda de facturas";
            // 
            // Form_Busqueda_factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 796);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Busqueda_factura";
            Text = "InkPOS - Búsqueda facturas";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_ingresar_N_factura;
        private Label lbl_busquda_facturas;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_mostrar_N_factura;
        private LinkLabel link_label_Ver;
        private Button button_imprimir;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
    }
}