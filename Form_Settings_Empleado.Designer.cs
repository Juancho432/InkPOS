namespace InkPos
{
    partial class Form_Settings_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings_Empleado));
            panel_settings_empleado = new Panel();
            button_salir = new Button();
            PB_ocultar = new PictureBox();
            PB_ver = new PictureBox();
            lbl_motivos = new Label();
            lbl_info = new Label();
            lbl_NPassword = new Label();
            lbl_CActual = new Label();
            lbl_telefono = new Label();
            button_saveChanges = new MaterialSkin.Controls.MaterialButton();
            txtbox_new_password = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_actual_password = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_telefono = new MaterialSkin.Controls.MaterialTextBox2();
            panel_settings_empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_ocultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_ver).BeginInit();
            SuspendLayout();
            // 
            // panel_settings_empleado
            // 
            panel_settings_empleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_settings_empleado.Controls.Add(button_salir);
            panel_settings_empleado.Controls.Add(PB_ocultar);
            panel_settings_empleado.Controls.Add(PB_ver);
            panel_settings_empleado.Controls.Add(lbl_motivos);
            panel_settings_empleado.Controls.Add(lbl_info);
            panel_settings_empleado.Controls.Add(lbl_NPassword);
            panel_settings_empleado.Controls.Add(lbl_CActual);
            panel_settings_empleado.Controls.Add(lbl_telefono);
            panel_settings_empleado.Controls.Add(button_saveChanges);
            panel_settings_empleado.Controls.Add(txtbox_new_password);
            panel_settings_empleado.Controls.Add(txtbox_actual_password);
            panel_settings_empleado.Controls.Add(txtbox_telefono);
            panel_settings_empleado.Location = new Point(5, 2);
            panel_settings_empleado.Name = "panel_settings_empleado";
            panel_settings_empleado.Size = new Size(1907, 1141);
            panel_settings_empleado.TabIndex = 0;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(561, 185);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 13;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += Button_salir_Click;
            // 
            // PB_ocultar
            // 
            PB_ocultar.Anchor = AnchorStyles.None;
            PB_ocultar.Cursor = Cursors.Hand;
            PB_ocultar.Image = (Image)resources.GetObject("PB_ocultar.Image");
            PB_ocultar.Location = new Point(1128, 533);
            PB_ocultar.Name = "PB_ocultar";
            PB_ocultar.Size = new Size(51, 48);
            PB_ocultar.TabIndex = 12;
            PB_ocultar.TabStop = false;
            PB_ocultar.Click += PB_ocultar_Click;
            // 
            // PB_ver
            // 
            PB_ver.Anchor = AnchorStyles.None;
            PB_ver.Cursor = Cursors.Hand;
            PB_ver.Image = (Image)resources.GetObject("PB_ver.Image");
            PB_ver.Location = new Point(1129, 533);
            PB_ver.Name = "PB_ver";
            PB_ver.Size = new Size(51, 48);
            PB_ver.TabIndex = 11;
            PB_ver.TabStop = false;
            PB_ver.Click += PB_ver_Click;
            // 
            // lbl_motivos
            // 
            lbl_motivos.Anchor = AnchorStyles.None;
            lbl_motivos.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_motivos.Location = new Point(694, 253);
            lbl_motivos.Name = "lbl_motivos";
            lbl_motivos.Size = new Size(512, 60);
            lbl_motivos.TabIndex = 8;
            lbl_motivos.Text = "Para proteger tu información personal, únicamente puedes actualizar tu número de teléfono y contraseña. Si necesitas realizar otros cambios, por favor contacta a un administrador.";
            lbl_motivos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_info
            // 
            lbl_info.Anchor = AnchorStyles.None;
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_info.Location = new Point(694, 171);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(523, 54);
            lbl_info.TabIndex = 7;
            lbl_info.Text = "Modificar información";
            // 
            // lbl_NPassword
            // 
            lbl_NPassword.Anchor = AnchorStyles.None;
            lbl_NPassword.AutoSize = true;
            lbl_NPassword.Location = new Point(658, 552);
            lbl_NPassword.Name = "lbl_NPassword";
            lbl_NPassword.Size = new Size(130, 20);
            lbl_NPassword.TabIndex = 6;
            lbl_NPassword.Text = "Nueva contraseña:";
            // 
            // lbl_CActual
            // 
            lbl_CActual.Anchor = AnchorStyles.None;
            lbl_CActual.AutoSize = true;
            lbl_CActual.Location = new Point(590, 385);
            lbl_CActual.Name = "lbl_CActual";
            lbl_CActual.Size = new Size(198, 20);
            lbl_CActual.TabIndex = 5;
            lbl_CActual.Text = "Ingrese su contraseña actual:";
            // 
            // lbl_telefono
            // 
            lbl_telefono.Anchor = AnchorStyles.None;
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(718, 471);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(70, 20);
            lbl_telefono.TabIndex = 4;
            lbl_telefono.Text = "Teléfono:";
            // 
            // button_saveChanges
            // 
            button_saveChanges.Anchor = AnchorStyles.None;
            button_saveChanges.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_saveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_saveChanges.Depth = 0;
            button_saveChanges.HighEmphasis = true;
            button_saveChanges.Icon = null;
            button_saveChanges.Location = new Point(863, 699);
            button_saveChanges.Margin = new Padding(4, 6, 4, 6);
            button_saveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            button_saveChanges.Name = "button_saveChanges";
            button_saveChanges.NoAccentTextColor = Color.Empty;
            button_saveChanges.Size = new Size(157, 36);
            button_saveChanges.TabIndex = 3;
            button_saveChanges.Text = "Guardar cambios";
            button_saveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_saveChanges.UseAccentColor = false;
            button_saveChanges.UseVisualStyleBackColor = true;
            button_saveChanges.Click += Button_saveChanges_Click;
            // 
            // txtbox_new_password
            // 
            txtbox_new_password.Anchor = AnchorStyles.None;
            txtbox_new_password.AnimateReadOnly = false;
            txtbox_new_password.BackgroundImageLayout = ImageLayout.None;
            txtbox_new_password.CharacterCasing = CharacterCasing.Normal;
            txtbox_new_password.Depth = 0;
            txtbox_new_password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_new_password.HideSelection = true;
            txtbox_new_password.Hint = "Dejar en blanco si no desea modificar";
            txtbox_new_password.LeadingIcon = null;
            txtbox_new_password.Location = new Point(810, 533);
            txtbox_new_password.MaxLength = 32767;
            txtbox_new_password.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_new_password.Name = "txtbox_new_password";
            txtbox_new_password.PasswordChar = '\0';
            txtbox_new_password.PrefixSuffixText = null;
            txtbox_new_password.ReadOnly = false;
            txtbox_new_password.RightToLeft = RightToLeft.No;
            txtbox_new_password.SelectedText = "";
            txtbox_new_password.SelectionLength = 0;
            txtbox_new_password.SelectionStart = 0;
            txtbox_new_password.ShortcutsEnabled = true;
            txtbox_new_password.Size = new Size(312, 48);
            txtbox_new_password.TabIndex = 2;
            txtbox_new_password.TabStop = false;
            txtbox_new_password.TextAlign = HorizontalAlignment.Left;
            txtbox_new_password.TrailingIcon = null;
            txtbox_new_password.UseSystemPasswordChar = false;
            // 
            // txtbox_actual_password
            // 
            txtbox_actual_password.Anchor = AnchorStyles.None;
            txtbox_actual_password.AnimateReadOnly = false;
            txtbox_actual_password.BackgroundImageLayout = ImageLayout.None;
            txtbox_actual_password.CharacterCasing = CharacterCasing.Normal;
            txtbox_actual_password.Depth = 0;
            txtbox_actual_password.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_actual_password.HideSelection = true;
            txtbox_actual_password.Hint = "Obligatorio";
            txtbox_actual_password.LeadingIcon = null;
            txtbox_actual_password.Location = new Point(810, 357);
            txtbox_actual_password.MaxLength = 32767;
            txtbox_actual_password.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_actual_password.Name = "txtbox_actual_password";
            txtbox_actual_password.PasswordChar = '●';
            txtbox_actual_password.PrefixSuffixText = null;
            txtbox_actual_password.ReadOnly = false;
            txtbox_actual_password.RightToLeft = RightToLeft.No;
            txtbox_actual_password.SelectedText = "";
            txtbox_actual_password.SelectionLength = 0;
            txtbox_actual_password.SelectionStart = 0;
            txtbox_actual_password.ShortcutsEnabled = true;
            txtbox_actual_password.Size = new Size(312, 48);
            txtbox_actual_password.TabIndex = 1;
            txtbox_actual_password.TabStop = false;
            txtbox_actual_password.TextAlign = HorizontalAlignment.Left;
            txtbox_actual_password.TrailingIcon = null;
            txtbox_actual_password.UseSystemPasswordChar = false;
            // 
            // txtbox_telefono
            // 
            txtbox_telefono.Anchor = AnchorStyles.None;
            txtbox_telefono.AnimateReadOnly = false;
            txtbox_telefono.BackgroundImageLayout = ImageLayout.None;
            txtbox_telefono.CharacterCasing = CharacterCasing.Normal;
            txtbox_telefono.Depth = 0;
            txtbox_telefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_telefono.HideSelection = true;
            txtbox_telefono.Hint = "Dejar en blanco si no desea modificar";
            txtbox_telefono.LeadingIcon = null;
            txtbox_telefono.Location = new Point(810, 443);
            txtbox_telefono.MaxLength = 32767;
            txtbox_telefono.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_telefono.Name = "txtbox_telefono";
            txtbox_telefono.PasswordChar = '\0';
            txtbox_telefono.PrefixSuffixText = null;
            txtbox_telefono.ReadOnly = false;
            txtbox_telefono.RightToLeft = RightToLeft.No;
            txtbox_telefono.SelectedText = "";
            txtbox_telefono.SelectionLength = 0;
            txtbox_telefono.SelectionStart = 0;
            txtbox_telefono.ShortcutsEnabled = true;
            txtbox_telefono.Size = new Size(312, 48);
            txtbox_telefono.TabIndex = 0;
            txtbox_telefono.TabStop = false;
            txtbox_telefono.TextAlign = HorizontalAlignment.Left;
            txtbox_telefono.TrailingIcon = null;
            txtbox_telefono.UseSystemPasswordChar = false;
            // 
            // Form_Settings_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1150);
            Controls.Add(panel_settings_empleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Settings_Empleado";
            Text = "InkPOS - Configuraciones de empleado";
            WindowState = FormWindowState.Maximized;
            Load += Form_Settings_Empleado_Load;
            panel_settings_empleado.ResumeLayout(false);
            panel_settings_empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_ocultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_ver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_settings_empleado;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_new_password;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_actual_password;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_telefono;
        private MaterialSkin.Controls.MaterialButton button_saveChanges;
        private Label lbl_telefono;
        private Label lbl_CActual;
        private Label lbl_NPassword;
        private Label lbl_motivos;
        private Label lbl_info;
        private PictureBox PB_ocultar;
        private PictureBox PB_ver;
        private Button button_salir;
    }
}