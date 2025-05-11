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
            panel_mod = new Panel();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            button_confirmar = new MaterialSkin.Controls.MaterialButton();
            lbl_ingresevalor = new Label();
            CB_valor_a_modificar = new MaterialSkin.Controls.MaterialComboBox();
            lbl_mod = new Label();
            txtbox_nuevo_valor = new MaterialSkin.Controls.MaterialTextBox2();
            panel_mod.SuspendLayout();
            SuspendLayout();
            // 
            // panel_mod
            // 
            panel_mod.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_mod.Controls.Add(button_cancelar);
            panel_mod.Controls.Add(button_limpiar);
            panel_mod.Controls.Add(button_confirmar);
            panel_mod.Controls.Add(lbl_ingresevalor);
            panel_mod.Controls.Add(CB_valor_a_modificar);
            panel_mod.Controls.Add(lbl_mod);
            panel_mod.Controls.Add(txtbox_nuevo_valor);
            panel_mod.Location = new Point(5, 2);
            panel_mod.Name = "panel_mod";
            panel_mod.Size = new Size(1513, 1051);
            panel_mod.TabIndex = 0;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(909, 520);
            button_cancelar.Margin = new Padding(4, 6, 4, 6);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(96, 36);
            button_cancelar.TabIndex = 6;
            button_cancelar.Text = "Cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(727, 511);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(79, 36);
            button_limpiar.TabIndex = 5;
            button_limpiar.Text = "Limpiar";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = true;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_confirmar.Depth = 0;
            button_confirmar.HighEmphasis = true;
            button_confirmar.Icon = null;
            button_confirmar.Location = new Point(529, 511);
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
            button_confirmar.Click += button_confirmar_Click;
            // 
            // lbl_ingresevalor
            // 
            lbl_ingresevalor.Anchor = AnchorStyles.None;
            lbl_ingresevalor.AutoSize = true;
            lbl_ingresevalor.Location = new Point(539, 345);
            lbl_ingresevalor.Name = "lbl_ingresevalor";
            lbl_ingresevalor.Size = new Size(157, 20);
            lbl_ingresevalor.TabIndex = 3;
            lbl_ingresevalor.Text = "Ingrese el nuevo valor:";
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
            CB_valor_a_modificar.Hint = "¿Qué campo desea modificar?";
            CB_valor_a_modificar.IntegralHeight = false;
            CB_valor_a_modificar.ItemHeight = 43;
            CB_valor_a_modificar.Items.AddRange(new object[] { "Nombre", "Precio", "Stock" });
            CB_valor_a_modificar.Location = new Point(622, 162);
            CB_valor_a_modificar.MaxDropDownItems = 4;
            CB_valor_a_modificar.MouseState = MaterialSkin.MouseState.OUT;
            CB_valor_a_modificar.Name = "CB_valor_a_modificar";
            CB_valor_a_modificar.Size = new Size(264, 49);
            CB_valor_a_modificar.StartIndex = 0;
            CB_valor_a_modificar.TabIndex = 2;
            // 
            // lbl_mod
            // 
            lbl_mod.Anchor = AnchorStyles.None;
            lbl_mod.AutoSize = true;
            lbl_mod.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mod.Location = new Point(562, 9);
            lbl_mod.Name = "lbl_mod";
            lbl_mod.Size = new Size(400, 60);
            lbl_mod.TabIndex = 1;
            lbl_mod.Text = "Modificar Producto";
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
            txtbox_nuevo_valor.Location = new Point(745, 327);
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
            txtbox_nuevo_valor.Size = new Size(243, 48);
            txtbox_nuevo_valor.TabIndex = 0;
            txtbox_nuevo_valor.TabStop = false;
            txtbox_nuevo_valor.TextAlign = HorizontalAlignment.Left;
            txtbox_nuevo_valor.TrailingIcon = null;
            txtbox_nuevo_valor.UseSystemPasswordChar = false;
            // 
            // Form_Modificar_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_mod);
            Name = "Form_Modificar_Producto";
            Text = "InkPOS - Modificar producto";
            WindowState = FormWindowState.Maximized;
            panel_mod.ResumeLayout(false);
            panel_mod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_mod;
        private Label lbl_mod;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nuevo_valor;
        private MaterialSkin.Controls.MaterialComboBox CB_valor_a_modificar;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
        private MaterialSkin.Controls.MaterialButton button_confirmar;
        private Label lbl_ingresevalor;
    }
}