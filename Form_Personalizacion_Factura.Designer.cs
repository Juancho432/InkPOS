namespace InkPos
{
    partial class Form_Personalizacion_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Personalizacion_Factura));
            lbl_upload = new Label();
            lbl_ingresevalor = new Label();
            CB_valor_a_modificar = new MaterialSkin.Controls.MaterialComboBox();
            txtbox_nuevo_valor = new MaterialSkin.Controls.MaterialTextBox2();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            button_confirmar = new MaterialSkin.Controls.MaterialButton();
            lbl_Personalizacion = new Label();
            button_upload = new Button();
            SuspendLayout();
            // 
            // lbl_upload
            // 
            lbl_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_upload.AutoSize = true;
            lbl_upload.BackColor = Color.Transparent;
            lbl_upload.Font = new Font("Arial Rounded MT Bold", 9F);
            lbl_upload.ForeColor = Color.White;
            lbl_upload.Location = new Point(734, 610);
            lbl_upload.Name = "lbl_upload";
            lbl_upload.Size = new Size(168, 17);
            lbl_upload.TabIndex = 37;
            lbl_upload.Text = "Seleccione la imagen:";
            // 
            // lbl_ingresevalor
            // 
            lbl_ingresevalor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_ingresevalor.AutoSize = true;
            lbl_ingresevalor.BackColor = Color.Transparent;
            lbl_ingresevalor.Font = new Font("Arial Rounded MT Bold", 9F);
            lbl_ingresevalor.ForeColor = Color.White;
            lbl_ingresevalor.Location = new Point(727, 610);
            lbl_ingresevalor.Name = "lbl_ingresevalor";
            lbl_ingresevalor.Size = new Size(175, 17);
            lbl_ingresevalor.TabIndex = 35;
            lbl_ingresevalor.Text = "Ingrese el nuevo valor:";
            // 
            // CB_valor_a_modificar
            // 
            CB_valor_a_modificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CB_valor_a_modificar.AutoResize = false;
            CB_valor_a_modificar.BackColor = Color.FromArgb(255, 255, 255);
            CB_valor_a_modificar.Depth = 0;
            CB_valor_a_modificar.DrawMode = DrawMode.OwnerDrawVariable;
            CB_valor_a_modificar.DropDownHeight = 174;
            CB_valor_a_modificar.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_valor_a_modificar.DropDownWidth = 121;
            CB_valor_a_modificar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CB_valor_a_modificar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CB_valor_a_modificar.FormattingEnabled = true;
            CB_valor_a_modificar.Hint = "¿Qué atributo desea modificar?";
            CB_valor_a_modificar.IntegralHeight = false;
            CB_valor_a_modificar.ItemHeight = 43;
            CB_valor_a_modificar.Items.AddRange(new object[] { "Dirección\t", "Logo", "Nombre de la empresa", "Teléfono" });
            CB_valor_a_modificar.Location = new Point(830, 369);
            CB_valor_a_modificar.MaxDropDownItems = 4;
            CB_valor_a_modificar.MouseState = MaterialSkin.MouseState.OUT;
            CB_valor_a_modificar.Name = "CB_valor_a_modificar";
            CB_valor_a_modificar.Size = new Size(312, 49);
            CB_valor_a_modificar.StartIndex = 0;
            CB_valor_a_modificar.TabIndex = 34;
            CB_valor_a_modificar.SelectedIndexChanged += CB_valor_a_modificar_SelectedIndexChanged;
            // 
            // txtbox_nuevo_valor
            // 
            txtbox_nuevo_valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtbox_nuevo_valor.AnimateReadOnly = false;
            txtbox_nuevo_valor.BackgroundImageLayout = ImageLayout.None;
            txtbox_nuevo_valor.CharacterCasing = CharacterCasing.Normal;
            txtbox_nuevo_valor.Depth = 0;
            txtbox_nuevo_valor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_nuevo_valor.HideSelection = true;
            txtbox_nuevo_valor.LeadingIcon = null;
            txtbox_nuevo_valor.Location = new Point(977, 594);
            txtbox_nuevo_valor.MaxLength = 32767;
            txtbox_nuevo_valor.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_nuevo_valor.Name = "txtbox_nuevo_valor";
            txtbox_nuevo_valor.PasswordChar = '\0';
            txtbox_nuevo_valor.PrefixSuffixText = null;
            txtbox_nuevo_valor.ReadOnly = false;
            txtbox_nuevo_valor.RightToLeft = RightToLeft.No;
            txtbox_nuevo_valor.SelectedText = "";
            txtbox_nuevo_valor.SelectionLength = 0;
            txtbox_nuevo_valor.SelectionStart = 0;
            txtbox_nuevo_valor.ShortcutsEnabled = true;
            txtbox_nuevo_valor.Size = new Size(125, 48);
            txtbox_nuevo_valor.TabIndex = 33;
            txtbox_nuevo_valor.TabStop = false;
            txtbox_nuevo_valor.TextAlign = HorizontalAlignment.Left;
            txtbox_nuevo_valor.TrailingIcon = null;
            txtbox_nuevo_valor.UseSystemPasswordChar = false;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_salir.AutoSize = false;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.BackColor = Color.Transparent;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(1103, 871);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(126, 36);
            button_salir.TabIndex = 31;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = false;
            button_salir.Click += button_salir_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_limpiar.AutoSize = false;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.BackColor = Color.Transparent;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(906, 871);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(126, 36);
            button_limpiar.TabIndex = 30;
            button_limpiar.Text = "LIMPIAR";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = false;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_confirmar.AutoSize = false;
            button_confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_confirmar.BackColor = Color.Transparent;
            button_confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_confirmar.Depth = 0;
            button_confirmar.HighEmphasis = true;
            button_confirmar.Icon = null;
            button_confirmar.Location = new Point(717, 871);
            button_confirmar.Margin = new Padding(4, 6, 4, 6);
            button_confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            button_confirmar.Name = "button_confirmar";
            button_confirmar.NoAccentTextColor = Color.Empty;
            button_confirmar.Size = new Size(126, 36);
            button_confirmar.TabIndex = 29;
            button_confirmar.Text = "confirmar";
            button_confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_confirmar.UseAccentColor = false;
            button_confirmar.UseVisualStyleBackColor = false;
            // 
            // lbl_Personalizacion
            // 
            lbl_Personalizacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Personalizacion.AutoSize = true;
            lbl_Personalizacion.BackColor = Color.Transparent;
            lbl_Personalizacion.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Personalizacion.ForeColor = Color.White;
            lbl_Personalizacion.Location = new Point(668, 194);
            lbl_Personalizacion.Name = "lbl_Personalizacion";
            lbl_Personalizacion.Size = new Size(634, 54);
            lbl_Personalizacion.TabIndex = 28;
            lbl_Personalizacion.Text = "Personalización de factura";
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_upload.Image = (Image)resources.GetObject("button_upload.Image");
            button_upload.Location = new Point(977, 595);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(125, 47);
            button_upload.TabIndex = 38;
            button_upload.UseVisualStyleBackColor = true;
            // 
            // Form_Personalizacion_Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1175);
            Controls.Add(button_upload);
            Controls.Add(lbl_upload);
            Controls.Add(lbl_ingresevalor);
            Controls.Add(CB_valor_a_modificar);
            Controls.Add(txtbox_nuevo_valor);
            Controls.Add(button_salir);
            Controls.Add(button_limpiar);
            Controls.Add(button_confirmar);
            Controls.Add(lbl_Personalizacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Personalizacion_Factura";
            Text = "InkPOS - Personalización de factura";
            WindowState = FormWindowState.Maximized;
            Load += Form_Personalizacion_Factura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_upload;
        private Label lbl_ingresevalor;
        private MaterialSkin.Controls.MaterialComboBox CB_valor_a_modificar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nuevo_valor;
        private MaterialSkin.Controls.MaterialButton button_salir;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
        private MaterialSkin.Controls.MaterialButton button_confirmar;
        private Label lbl_Personalizacion;
        private Button button_upload;
    }
}