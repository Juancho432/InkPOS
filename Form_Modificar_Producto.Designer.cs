namespace InkPos
{
    partial class Form_Modificar_Producto
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
            panel_modificar = new Panel();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_confirmar = new MaterialSkin.Controls.MaterialButton();
            txtbox_nuevo_valor = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_nuevo_valor = new Label();
            CB_valor_a_modificar = new MaterialSkin.Controls.MaterialComboBox();
            lbl_Modificar = new Label();
            panel_modificar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_modificar
            // 
            panel_modificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_modificar.Controls.Add(button_limpiar);
            panel_modificar.Controls.Add(button_cancelar);
            panel_modificar.Controls.Add(button_confirmar);
            panel_modificar.Controls.Add(txtbox_nuevo_valor);
            panel_modificar.Controls.Add(lbl_nuevo_valor);
            panel_modificar.Controls.Add(CB_valor_a_modificar);
            panel_modificar.Controls.Add(lbl_Modificar);
            panel_modificar.Location = new Point(5, 2);
            panel_modificar.Name = "panel_modificar";
            panel_modificar.Size = new Size(1513, 1171);
            panel_modificar.TabIndex = 0;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(702, 772);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(79, 36);
            button_limpiar.TabIndex = 6;
            button_limpiar.Text = "Limpiar";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(852, 772);
            button_cancelar.Margin = new Padding(4, 6, 4, 6);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(96, 36);
            button_cancelar.TabIndex = 5;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_confirmar.Depth = 0;
            button_confirmar.HighEmphasis = true;
            button_confirmar.Icon = null;
            button_confirmar.Location = new Point(531, 772);
            button_confirmar.Margin = new Padding(4, 6, 4, 6);
            button_confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            button_confirmar.Name = "button_confirmar";
            button_confirmar.NoAccentTextColor = Color.Empty;
            button_confirmar.Size = new Size(105, 36);
            button_confirmar.TabIndex = 4;
            button_confirmar.Text = "Confirmar";
            button_confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_confirmar.UseAccentColor = false;
            button_confirmar.UseVisualStyleBackColor = true;
            // 
            // txtbox_nuevo_valor
            // 
            txtbox_nuevo_valor.Anchor = AnchorStyles.None;
            txtbox_nuevo_valor.AnimateReadOnly = false;
            txtbox_nuevo_valor.BackgroundImageLayout = ImageLayout.None;
            txtbox_nuevo_valor.CharacterCasing = CharacterCasing.Normal;
            txtbox_nuevo_valor.Depth = 0;
            txtbox_nuevo_valor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_nuevo_valor.HideSelection = true;
            txtbox_nuevo_valor.LeadingIcon = null;
            txtbox_nuevo_valor.Location = new Point(725, 507);
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
            txtbox_nuevo_valor.Size = new Size(312, 48);
            txtbox_nuevo_valor.TabIndex = 3;
            txtbox_nuevo_valor.TabStop = false;
            txtbox_nuevo_valor.TextAlign = HorizontalAlignment.Left;
            txtbox_nuevo_valor.TrailingIcon = null;
            txtbox_nuevo_valor.UseSystemPasswordChar = false;
            // 
            // lbl_nuevo_valor
            // 
            lbl_nuevo_valor.Anchor = AnchorStyles.None;
            lbl_nuevo_valor.AutoSize = true;
            lbl_nuevo_valor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nuevo_valor.Location = new Point(399, 517);
            lbl_nuevo_valor.Name = "lbl_nuevo_valor";
            lbl_nuevo_valor.Size = new Size(296, 38);
            lbl_nuevo_valor.TabIndex = 2;
            lbl_nuevo_valor.Text = "Ingrese el nuevo valor:";
            // 
            // CB_valor_a_modificar
            // 
            CB_valor_a_modificar.Anchor = AnchorStyles.None;
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
            CB_valor_a_modificar.Hint = "Seleccione el valor a modificar";
            CB_valor_a_modificar.IntegralHeight = false;
            CB_valor_a_modificar.ItemHeight = 43;
            CB_valor_a_modificar.Items.AddRange(new object[] { "Nombre", "Precio", "Stock" });
            CB_valor_a_modificar.Location = new Point(592, 261);
            CB_valor_a_modificar.MaxDropDownItems = 4;
            CB_valor_a_modificar.MouseState = MaterialSkin.MouseState.OUT;
            CB_valor_a_modificar.Name = "CB_valor_a_modificar";
            CB_valor_a_modificar.Size = new Size(266, 49);
            CB_valor_a_modificar.StartIndex = 0;
            CB_valor_a_modificar.TabIndex = 1;
            // 
            // lbl_Modificar
            // 
            lbl_Modificar.Anchor = AnchorStyles.None;
            lbl_Modificar.AutoSize = true;
            lbl_Modificar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Modificar.Location = new Point(592, 147);
            lbl_Modificar.Name = "lbl_Modificar";
            lbl_Modificar.Size = new Size(273, 41);
            lbl_Modificar.TabIndex = 0;
            lbl_Modificar.Text = "Modificar Prodcuto";
            // 
            // Form_Modificar_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_modificar);
            Name = "Form_Modificar_Producto";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "InkPOS _ Modificar producto";
            WindowState = FormWindowState.Maximized;
            panel_modificar.ResumeLayout(false);
            panel_modificar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_modificar;
        private Label lbl_Modificar;
        private MaterialSkin.Controls.MaterialComboBox CB_valor_a_modificar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nuevo_valor;
        private Label lbl_nuevo_valor;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
        private MaterialSkin.Controls.MaterialButton button_confirmar;
    }
}