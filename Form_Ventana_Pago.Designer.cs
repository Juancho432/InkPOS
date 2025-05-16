namespace InkPos
{
    partial class Form_Ventana_Pago
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
            panel_ventana_pago = new Panel();
            lbl_cambio = new Label();
            txtbox_valor_recibido = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_cambio = new MaterialSkin.Controls.MaterialTextBox2();
            button_GenerarPDF = new MaterialSkin.Controls.MaterialButton();
            button_cancelar = new MaterialSkin.Controls.MaterialButton();
            button_confirmar = new MaterialSkin.Controls.MaterialButton();
            txtbox_valor = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_valor_recibido = new Label();
            CB_transaccion = new MaterialSkin.Controls.MaterialComboBox();
            lbl_Valor = new Label();
            lbl_codigo_transferencia = new Label();
            txtbox_codigo_transferencia = new MaterialSkin.Controls.MaterialTextBox2();
            panel_ventana_pago.SuspendLayout();
            SuspendLayout();
            // 
            // panel_ventana_pago
            // 
            panel_ventana_pago.Controls.Add(txtbox_codigo_transferencia);
            panel_ventana_pago.Controls.Add(lbl_codigo_transferencia);
            panel_ventana_pago.Controls.Add(lbl_cambio);
            panel_ventana_pago.Controls.Add(txtbox_valor_recibido);
            panel_ventana_pago.Controls.Add(txtbox_cambio);
            panel_ventana_pago.Controls.Add(button_GenerarPDF);
            panel_ventana_pago.Controls.Add(button_cancelar);
            panel_ventana_pago.Controls.Add(button_confirmar);
            panel_ventana_pago.Controls.Add(txtbox_valor);
            panel_ventana_pago.Controls.Add(lbl_valor_recibido);
            panel_ventana_pago.Controls.Add(CB_transaccion);
            panel_ventana_pago.Controls.Add(lbl_Valor);
            panel_ventana_pago.Location = new Point(5, 3);
            panel_ventana_pago.Name = "panel_ventana_pago";
            panel_ventana_pago.Size = new Size(1513, 1171);
            panel_ventana_pago.TabIndex = 0;
            // 
            // lbl_cambio
            // 
            lbl_cambio.Anchor = AnchorStyles.None;
            lbl_cambio.AutoSize = true;
            lbl_cambio.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cambio.Location = new Point(563, 509);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(117, 38);
            lbl_cambio.TabIndex = 16;
            lbl_cambio.Text = "Cambio:";
            // 
            // txtbox_valor_recibido
            // 
            txtbox_valor_recibido.Anchor = AnchorStyles.None;
            txtbox_valor_recibido.AnimateReadOnly = false;
            txtbox_valor_recibido.BackgroundImageLayout = ImageLayout.None;
            txtbox_valor_recibido.CharacterCasing = CharacterCasing.Normal;
            txtbox_valor_recibido.Depth = 0;
            txtbox_valor_recibido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_valor_recibido.HideSelection = true;
            txtbox_valor_recibido.LeadingIcon = null;
            txtbox_valor_recibido.Location = new Point(746, 421);
            txtbox_valor_recibido.MaxLength = 32767;
            txtbox_valor_recibido.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_valor_recibido.Name = "txtbox_valor_recibido";
            txtbox_valor_recibido.PasswordChar = '\0';
            txtbox_valor_recibido.PrefixSuffixText = null;
            txtbox_valor_recibido.ReadOnly = false;
            txtbox_valor_recibido.RightToLeft = RightToLeft.No;
            txtbox_valor_recibido.SelectedText = "";
            txtbox_valor_recibido.SelectionLength = 0;
            txtbox_valor_recibido.SelectionStart = 0;
            txtbox_valor_recibido.ShortcutsEnabled = true;
            txtbox_valor_recibido.Size = new Size(312, 48);
            txtbox_valor_recibido.TabIndex = 15;
            txtbox_valor_recibido.TabStop = false;
            txtbox_valor_recibido.TextAlign = HorizontalAlignment.Left;
            txtbox_valor_recibido.TrailingIcon = null;
            txtbox_valor_recibido.UseSystemPasswordChar = false;
            txtbox_valor_recibido.KeyDown += txtbox_valor_recibido_KeyDown_1;
            // 
            // txtbox_cambio
            // 
            txtbox_cambio.Anchor = AnchorStyles.None;
            txtbox_cambio.AnimateReadOnly = false;
            txtbox_cambio.BackgroundImageLayout = ImageLayout.None;
            txtbox_cambio.CharacterCasing = CharacterCasing.Normal;
            txtbox_cambio.Depth = 0;
            txtbox_cambio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_cambio.HideSelection = true;
            txtbox_cambio.LeadingIcon = null;
            txtbox_cambio.Location = new Point(746, 509);
            txtbox_cambio.MaxLength = 32767;
            txtbox_cambio.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_cambio.Name = "txtbox_cambio";
            txtbox_cambio.PasswordChar = '\0';
            txtbox_cambio.PrefixSuffixText = null;
            txtbox_cambio.ReadOnly = true;
            txtbox_cambio.RightToLeft = RightToLeft.No;
            txtbox_cambio.SelectedText = "";
            txtbox_cambio.SelectionLength = 0;
            txtbox_cambio.SelectionStart = 0;
            txtbox_cambio.ShortcutsEnabled = true;
            txtbox_cambio.Size = new Size(312, 48);
            txtbox_cambio.TabIndex = 14;
            txtbox_cambio.TabStop = false;
            txtbox_cambio.TextAlign = HorizontalAlignment.Left;
            txtbox_cambio.TrailingIcon = null;
            txtbox_cambio.UseSystemPasswordChar = false;
            // 
            // button_GenerarPDF
            // 
            button_GenerarPDF.Anchor = AnchorStyles.None;
            button_GenerarPDF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_GenerarPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_GenerarPDF.Depth = 0;
            button_GenerarPDF.HighEmphasis = true;
            button_GenerarPDF.Icon = null;
            button_GenerarPDF.Location = new Point(704, 712);
            button_GenerarPDF.Margin = new Padding(5, 5, 5, 5);
            button_GenerarPDF.MouseState = MaterialSkin.MouseState.HOVER;
            button_GenerarPDF.Name = "button_GenerarPDF";
            button_GenerarPDF.NoAccentTextColor = Color.Empty;
            button_GenerarPDF.Size = new Size(118, 36);
            button_GenerarPDF.TabIndex = 13;
            button_GenerarPDF.Text = "Generar PDF";
            button_GenerarPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_GenerarPDF.UseAccentColor = false;
            button_GenerarPDF.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_cancelar.Depth = 0;
            button_cancelar.HighEmphasis = true;
            button_cancelar.Icon = null;
            button_cancelar.Location = new Point(897, 712);
            button_cancelar.Margin = new Padding(5, 5, 5, 5);
            button_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            button_cancelar.Name = "button_cancelar";
            button_cancelar.NoAccentTextColor = Color.Empty;
            button_cancelar.Size = new Size(96, 36);
            button_cancelar.TabIndex = 12;
            button_cancelar.Text = "cancelar";
            button_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_cancelar.UseAccentColor = false;
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_confirmar.Depth = 0;
            button_confirmar.HighEmphasis = true;
            button_confirmar.Icon = null;
            button_confirmar.Location = new Point(509, 712);
            button_confirmar.Margin = new Padding(5, 5, 5, 5);
            button_confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            button_confirmar.Name = "button_confirmar";
            button_confirmar.NoAccentTextColor = Color.Empty;
            button_confirmar.Size = new Size(105, 36);
            button_confirmar.TabIndex = 11;
            button_confirmar.Text = "Confirmar";
            button_confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_confirmar.UseAccentColor = false;
            button_confirmar.UseVisualStyleBackColor = true;
            button_confirmar.Click += button_confirmar_Click;
            // 
            // txtbox_valor
            // 
            txtbox_valor.Anchor = AnchorStyles.None;
            txtbox_valor.AnimateReadOnly = false;
            txtbox_valor.BackgroundImageLayout = ImageLayout.None;
            txtbox_valor.CharacterCasing = CharacterCasing.Normal;
            txtbox_valor.Depth = 0;
            txtbox_valor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_valor.HideSelection = true;
            txtbox_valor.LeadingIcon = null;
            txtbox_valor.Location = new Point(658, 141);
            txtbox_valor.MaxLength = 32767;
            txtbox_valor.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_valor.Name = "txtbox_valor";
            txtbox_valor.PasswordChar = '\0';
            txtbox_valor.PrefixSuffixText = null;
            txtbox_valor.ReadOnly = true;
            txtbox_valor.RightToLeft = RightToLeft.No;
            txtbox_valor.SelectedText = "";
            txtbox_valor.SelectionLength = 0;
            txtbox_valor.SelectionStart = 0;
            txtbox_valor.ShortcutsEnabled = true;
            txtbox_valor.Size = new Size(312, 48);
            txtbox_valor.TabIndex = 10;
            txtbox_valor.TabStop = false;
            txtbox_valor.TextAlign = HorizontalAlignment.Left;
            txtbox_valor.TrailingIcon = null;
            txtbox_valor.UseSystemPasswordChar = false;
            // 
            // lbl_valor_recibido
            // 
            lbl_valor_recibido.Anchor = AnchorStyles.None;
            lbl_valor_recibido.AutoSize = true;
            lbl_valor_recibido.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor_recibido.Location = new Point(487, 431);
            lbl_valor_recibido.Name = "lbl_valor_recibido";
            lbl_valor_recibido.Size = new Size(193, 38);
            lbl_valor_recibido.TabIndex = 9;
            lbl_valor_recibido.Text = "Valor recibido:";
            // 
            // CB_transaccion
            // 
            CB_transaccion.Anchor = AnchorStyles.None;
            CB_transaccion.AutoResize = false;
            CB_transaccion.BackColor = Color.FromArgb(255, 255, 255);
            CB_transaccion.Depth = 0;
            CB_transaccion.DrawMode = DrawMode.OwnerDrawVariable;
            CB_transaccion.DropDownHeight = 174;
            CB_transaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_transaccion.DropDownWidth = 121;
            CB_transaccion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CB_transaccion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CB_transaccion.FormattingEnabled = true;
            CB_transaccion.Hint = "Seleccione el valor a modificar";
            CB_transaccion.IntegralHeight = false;
            CB_transaccion.ItemHeight = 43;
            CB_transaccion.Items.AddRange(new object[] { "Efectivo", "Transferencia" });
            CB_transaccion.Location = new Point(621, 269);
            CB_transaccion.MaxDropDownItems = 4;
            CB_transaccion.MouseState = MaterialSkin.MouseState.OUT;
            CB_transaccion.Name = "CB_transaccion";
            CB_transaccion.Size = new Size(266, 49);
            CB_transaccion.StartIndex = 0;
            CB_transaccion.TabIndex = 8;
            // 
            // lbl_Valor
            // 
            lbl_Valor.Anchor = AnchorStyles.None;
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Valor.Location = new Point(522, 149);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(92, 41);
            lbl_Valor.TabIndex = 7;
            lbl_Valor.Text = "Valor:";
            // 
            // lbl_codigo_transferencia
            // 
            lbl_codigo_transferencia.Anchor = AnchorStyles.None;
            lbl_codigo_transferencia.AutoSize = true;
            lbl_codigo_transferencia.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_codigo_transferencia.Location = new Point(362, 431);
            lbl_codigo_transferencia.Name = "lbl_codigo_transferencia";
            lbl_codigo_transferencia.Size = new Size(318, 38);
            lbl_codigo_transferencia.TabIndex = 17;
            lbl_codigo_transferencia.Text = "Código de transferencia:";
            // 
            // txtbox_codigo_transferencia
            // 
            txtbox_codigo_transferencia.Anchor = AnchorStyles.None;
            txtbox_codigo_transferencia.AnimateReadOnly = false;
            txtbox_codigo_transferencia.BackgroundImageLayout = ImageLayout.None;
            txtbox_codigo_transferencia.CharacterCasing = CharacterCasing.Normal;
            txtbox_codigo_transferencia.Depth = 0;
            txtbox_codigo_transferencia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_codigo_transferencia.HideSelection = true;
            txtbox_codigo_transferencia.LeadingIcon = null;
            txtbox_codigo_transferencia.Location = new Point(746, 421);
            txtbox_codigo_transferencia.MaxLength = 32767;
            txtbox_codigo_transferencia.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_codigo_transferencia.Name = "txtbox_codigo_transferencia";
            txtbox_codigo_transferencia.PasswordChar = '\0';
            txtbox_codigo_transferencia.PrefixSuffixText = null;
            txtbox_codigo_transferencia.ReadOnly = false;
            txtbox_codigo_transferencia.RightToLeft = RightToLeft.No;
            txtbox_codigo_transferencia.SelectedText = "";
            txtbox_codigo_transferencia.SelectionLength = 0;
            txtbox_codigo_transferencia.SelectionStart = 0;
            txtbox_codigo_transferencia.ShortcutsEnabled = true;
            txtbox_codigo_transferencia.Size = new Size(300, 48);
            txtbox_codigo_transferencia.TabIndex = 18;
            txtbox_codigo_transferencia.TabStop = false;
            txtbox_codigo_transferencia.TextAlign = HorizontalAlignment.Left;
            txtbox_codigo_transferencia.TrailingIcon = null;
            txtbox_codigo_transferencia.UseSystemPasswordChar = false;
            // 
            // Form_Ventana_Pago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1061);
            Controls.Add(panel_ventana_pago);
            Name = "Form_Ventana_Pago";
            Text = "InkPOS - Pago";
            WindowState = FormWindowState.Maximized;
            panel_ventana_pago.ResumeLayout(false);
            panel_ventana_pago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_ventana_pago;
        private MaterialSkin.Controls.MaterialButton button_GenerarPDF;
        private MaterialSkin.Controls.MaterialButton button_cancelar;
        private MaterialSkin.Controls.MaterialButton button_confirmar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_valor;
        private Label lbl_valor_recibido;
        private MaterialSkin.Controls.MaterialComboBox CB_transaccion;
        private Label lbl_Valor;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_valor_recibido;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_cambio;
        private Label lbl_cambio;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_codigo_transferencia;
        private Label lbl_codigo_transferencia;
    }
}