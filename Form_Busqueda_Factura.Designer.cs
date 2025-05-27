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
            panel_busqueda_factura = new Panel();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_imprimir = new Button();
            link_label_Ver = new LinkLabel();
            txtbox_ingresar_N_factura = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_busquda_facturas = new Label();
            panel_busqueda_factura.SuspendLayout();
            SuspendLayout();
            // 
            // panel_busqueda_factura
            // 
            panel_busqueda_factura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_busqueda_factura.BackgroundImage = (Image)resources.GetObject("panel_busqueda_factura.BackgroundImage");
            panel_busqueda_factura.Controls.Add(button_cancelar);
            panel_busqueda_factura.Controls.Add(button_imprimir);
            panel_busqueda_factura.Controls.Add(link_label_Ver);
            panel_busqueda_factura.Controls.Add(txtbox_ingresar_N_factura);
            panel_busqueda_factura.Controls.Add(lbl_busquda_facturas);
            panel_busqueda_factura.Location = new Point(3, 3);
            panel_busqueda_factura.Name = "panel_busqueda_factura";
            panel_busqueda_factura.Size = new Size(1909, 1160);
            panel_busqueda_factura.TabIndex = 0;
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
            button_cancelar.Location = new Point(925, 676);
            button_cancelar.Margin = new Padding(5);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(136, 36);
            button_cancelar.TabIndex = 27;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += Boton_Cancelar_Click;
            // 
            // button_imprimir
            // 
            button_imprimir.Anchor = AnchorStyles.None;
            button_imprimir.Image = (Image)resources.GetObject("button_imprimir.Image");
            button_imprimir.Location = new Point(1042, 454);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new Size(69, 48);
            button_imprimir.TabIndex = 10;
            button_imprimir.UseVisualStyleBackColor = true;
            button_imprimir.Click += Boton_Imprimir_Click;
            // 
            // link_label_Ver
            // 
            link_label_Ver.Anchor = AnchorStyles.None;
            link_label_Ver.AutoSize = true;
            link_label_Ver.BackColor = Color.Transparent;
            link_label_Ver.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_label_Ver.LinkColor = Color.White;
            link_label_Ver.Location = new Point(841, 464);
            link_label_Ver.Name = "link_label_Ver";
            link_label_Ver.Size = new Size(62, 32);
            link_label_Ver.TabIndex = 9;
            link_label_Ver.TabStop = true;
            link_label_Ver.Text = "Ver";
            link_label_Ver.Click += Link_Label_Ver_Click;
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
            txtbox_ingresar_N_factura.Location = new Point(841, 294);
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
            txtbox_ingresar_N_factura.Size = new Size(270, 48);
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
            lbl_busquda_facturas.BackColor = Color.Transparent;
            lbl_busquda_facturas.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_busquda_facturas.ForeColor = Color.White;
            lbl_busquda_facturas.Location = new Point(718, 134);
            lbl_busquda_facturas.Name = "lbl_busquda_facturas";
            lbl_busquda_facturas.Size = new Size(524, 54);
            lbl_busquda_facturas.TabIndex = 4;
            lbl_busquda_facturas.Text = "Búsqueda de facturas";
            // 
            // Form_Busqueda_factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1175);
            Controls.Add(panel_busqueda_factura);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Busqueda_factura";
            Text = "InkPOS - Búsqueda facturas";
            WindowState = FormWindowState.Maximized;
            panel_busqueda_factura.ResumeLayout(false);
            panel_busqueda_factura.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_busqueda_factura;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_ingresar_N_factura;
        private Label lbl_busquda_facturas;
        private LinkLabel link_label_Ver;
        private Button button_imprimir;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
    }
}