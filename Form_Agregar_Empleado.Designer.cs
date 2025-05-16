namespace InkPos
{
    partial class Form_Agregar_Empleado
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
            panel_agregar_empleado = new Panel();
            CB_cargo = new MaterialSkin.Controls.MaterialComboBox();
            lbl_salario = new Label();
            lbl_cargo = new Label();
            lbl_telefono = new Label();
            button_agregar_empleado = new MaterialSkin.Controls.MaterialButton();
            txtbox_cedula = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_telefono = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_salario = new MaterialSkin.Controls.MaterialTextBox2();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            lbl_cedula = new Label();
            txtbox_nombre_empleado = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_nombre = new Label();
            lbl_GestionEmpleados = new Label();
            lbl_contraseña = new Label();
            lbl_usuario = new Label();
            txtbox_usuario = new MaterialSkin.Controls.MaterialTextBox2();
            txtbox_contraseña = new MaterialSkin.Controls.MaterialTextBox2();
            panel_agregar_empleado.SuspendLayout();
            SuspendLayout();
            // 
            // panel_agregar_empleado
            // 
            panel_agregar_empleado.Controls.Add(txtbox_contraseña);
            panel_agregar_empleado.Controls.Add(txtbox_usuario);
            panel_agregar_empleado.Controls.Add(lbl_usuario);
            panel_agregar_empleado.Controls.Add(lbl_contraseña);
            panel_agregar_empleado.Controls.Add(CB_cargo);
            panel_agregar_empleado.Controls.Add(lbl_salario);
            panel_agregar_empleado.Controls.Add(lbl_cargo);
            panel_agregar_empleado.Controls.Add(lbl_telefono);
            panel_agregar_empleado.Controls.Add(button_agregar_empleado);
            panel_agregar_empleado.Controls.Add(txtbox_cedula);
            panel_agregar_empleado.Controls.Add(txtbox_telefono);
            panel_agregar_empleado.Controls.Add(txtbox_salario);
            panel_agregar_empleado.Controls.Add(button_salir);
            panel_agregar_empleado.Controls.Add(button_limpiar);
            panel_agregar_empleado.Controls.Add(lbl_cedula);
            panel_agregar_empleado.Controls.Add(txtbox_nombre_empleado);
            panel_agregar_empleado.Controls.Add(lbl_nombre);
            panel_agregar_empleado.Controls.Add(lbl_GestionEmpleados);
            panel_agregar_empleado.Location = new Point(5, 2);
            panel_agregar_empleado.Name = "panel_agregar_empleado";
            panel_agregar_empleado.Size = new Size(1513, 1171);
            panel_agregar_empleado.TabIndex = 0;
            // 
            // CB_cargo
            // 
            CB_cargo.Anchor = AnchorStyles.None;
            CB_cargo.AutoResize = false;
            CB_cargo.BackColor = Color.FromArgb(255, 255, 255);
            CB_cargo.Depth = 0;
            CB_cargo.DrawMode = DrawMode.OwnerDrawVariable;
            CB_cargo.DropDownHeight = 174;
            CB_cargo.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_cargo.DropDownWidth = 121;
            CB_cargo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CB_cargo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CB_cargo.FormattingEnabled = true;
            CB_cargo.Hint = "Escoja una opción";
            CB_cargo.IntegralHeight = false;
            CB_cargo.ItemHeight = 43;
            CB_cargo.Items.AddRange(new object[] { "Empleado", "Admin" });
            CB_cargo.Location = new Point(648, 497);
            CB_cargo.MaxDropDownItems = 4;
            CB_cargo.MouseState = MaterialSkin.MouseState.OUT;
            CB_cargo.Name = "CB_cargo";
            CB_cargo.Size = new Size(312, 49);
            CB_cargo.StartIndex = 0;
            CB_cargo.TabIndex = 43;
            // 
            // lbl_salario
            // 
            lbl_salario.Anchor = AnchorStyles.None;
            lbl_salario.AutoSize = true;
            lbl_salario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_salario.ForeColor = SystemColors.ControlText;
            lbl_salario.Location = new Point(531, 597);
            lbl_salario.Name = "lbl_salario";
            lbl_salario.Size = new Size(76, 28);
            lbl_salario.TabIndex = 42;
            lbl_salario.Text = "Salario:";
            // 
            // lbl_cargo
            // 
            lbl_cargo.Anchor = AnchorStyles.None;
            lbl_cargo.AutoSize = true;
            lbl_cargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cargo.ForeColor = SystemColors.ControlText;
            lbl_cargo.Location = new Point(551, 518);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(69, 28);
            lbl_cargo.TabIndex = 41;
            lbl_cargo.Text = "Cargo:";
            // 
            // lbl_telefono
            // 
            lbl_telefono.Anchor = AnchorStyles.None;
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_telefono.ForeColor = SystemColors.ControlText;
            lbl_telefono.Location = new Point(531, 441);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(90, 28);
            lbl_telefono.TabIndex = 40;
            lbl_telefono.Text = "Teléfono:";
            // 
            // button_agregar_empleado
            // 
            button_agregar_empleado.Anchor = AnchorStyles.None;
            button_agregar_empleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_agregar_empleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_agregar_empleado.Depth = 0;
            button_agregar_empleado.HighEmphasis = true;
            button_agregar_empleado.Icon = null;
            button_agregar_empleado.Location = new Point(693, 848);
            button_agregar_empleado.Margin = new Padding(4, 6, 4, 6);
            button_agregar_empleado.MouseState = MaterialSkin.MouseState.HOVER;
            button_agregar_empleado.Name = "button_agregar_empleado";
            button_agregar_empleado.NoAccentTextColor = Color.Empty;
            button_agregar_empleado.Size = new Size(220, 36);
            button_agregar_empleado.TabIndex = 39;
            button_agregar_empleado.Text = "AGREGAR NUEVO EMPLEADO";
            button_agregar_empleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_agregar_empleado.UseAccentColor = false;
            button_agregar_empleado.UseVisualStyleBackColor = true;
            button_agregar_empleado.Click += Boton_Agregar_Empleado_Click;
            // 
            // txtbox_cedula
            // 
            txtbox_cedula.Anchor = AnchorStyles.None;
            txtbox_cedula.AnimateReadOnly = false;
            txtbox_cedula.BackgroundImageLayout = ImageLayout.None;
            txtbox_cedula.CharacterCasing = CharacterCasing.Normal;
            txtbox_cedula.Depth = 0;
            txtbox_cedula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_cedula.HideSelection = true;
            txtbox_cedula.LeadingIcon = null;
            txtbox_cedula.Location = new Point(648, 343);
            txtbox_cedula.MaxLength = 32767;
            txtbox_cedula.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_cedula.Name = "txtbox_cedula";
            txtbox_cedula.PasswordChar = '\0';
            txtbox_cedula.PrefixSuffixText = null;
            txtbox_cedula.ReadOnly = false;
            txtbox_cedula.RightToLeft = RightToLeft.No;
            txtbox_cedula.SelectedText = "";
            txtbox_cedula.SelectionLength = 0;
            txtbox_cedula.SelectionStart = 0;
            txtbox_cedula.ShortcutsEnabled = true;
            txtbox_cedula.Size = new Size(312, 48);
            txtbox_cedula.TabIndex = 37;
            txtbox_cedula.TabStop = false;
            txtbox_cedula.TextAlign = HorizontalAlignment.Left;
            txtbox_cedula.TrailingIcon = null;
            txtbox_cedula.UseSystemPasswordChar = false;
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
            txtbox_telefono.LeadingIcon = null;
            txtbox_telefono.Location = new Point(648, 421);
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
            txtbox_telefono.TabIndex = 36;
            txtbox_telefono.TabStop = false;
            txtbox_telefono.TextAlign = HorizontalAlignment.Left;
            txtbox_telefono.TrailingIcon = null;
            txtbox_telefono.UseSystemPasswordChar = false;
            // 
            // txtbox_salario
            // 
            txtbox_salario.Anchor = AnchorStyles.None;
            txtbox_salario.AnimateReadOnly = false;
            txtbox_salario.BackgroundImageLayout = ImageLayout.None;
            txtbox_salario.CharacterCasing = CharacterCasing.Normal;
            txtbox_salario.Depth = 0;
            txtbox_salario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_salario.HideSelection = true;
            txtbox_salario.LeadingIcon = null;
            txtbox_salario.Location = new Point(648, 577);
            txtbox_salario.MaxLength = 32767;
            txtbox_salario.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_salario.Name = "txtbox_salario";
            txtbox_salario.PasswordChar = '\0';
            txtbox_salario.PrefixSuffixText = null;
            txtbox_salario.ReadOnly = false;
            txtbox_salario.RightToLeft = RightToLeft.No;
            txtbox_salario.SelectedText = "";
            txtbox_salario.SelectionLength = 0;
            txtbox_salario.SelectionStart = 0;
            txtbox_salario.ShortcutsEnabled = true;
            txtbox_salario.Size = new Size(312, 48);
            txtbox_salario.TabIndex = 35;
            txtbox_salario.TabStop = false;
            txtbox_salario.TextAlign = HorizontalAlignment.Left;
            txtbox_salario.TrailingIcon = null;
            txtbox_salario.UseSystemPasswordChar = false;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(928, 954);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 33;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += Boton_Salir_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(615, 954);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(79, 36);
            button_limpiar.TabIndex = 32;
            button_limpiar.Text = "LIMPIAR";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += Boton_Limpiar_Click;
            // 
            // lbl_cedula
            // 
            lbl_cedula.Anchor = AnchorStyles.None;
            lbl_cedula.AutoSize = true;
            lbl_cedula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cedula.ForeColor = SystemColors.ControlText;
            lbl_cedula.Location = new Point(544, 363);
            lbl_cedula.Name = "lbl_cedula";
            lbl_cedula.Size = new Size(76, 28);
            lbl_cedula.TabIndex = 30;
            lbl_cedula.Tag = "";
            lbl_cedula.Text = "Cédula:";
            // 
            // txtbox_nombre_empleado
            // 
            txtbox_nombre_empleado.Anchor = AnchorStyles.None;
            txtbox_nombre_empleado.AnimateReadOnly = false;
            txtbox_nombre_empleado.BackgroundImageLayout = ImageLayout.None;
            txtbox_nombre_empleado.CharacterCasing = CharacterCasing.Normal;
            txtbox_nombre_empleado.Depth = 0;
            txtbox_nombre_empleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_nombre_empleado.HideSelection = true;
            txtbox_nombre_empleado.LeadingIcon = null;
            txtbox_nombre_empleado.Location = new Point(648, 259);
            txtbox_nombre_empleado.MaxLength = 32767;
            txtbox_nombre_empleado.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_nombre_empleado.Name = "txtbox_nombre_empleado";
            txtbox_nombre_empleado.PasswordChar = '\0';
            txtbox_nombre_empleado.PrefixSuffixText = null;
            txtbox_nombre_empleado.ReadOnly = false;
            txtbox_nombre_empleado.RightToLeft = RightToLeft.No;
            txtbox_nombre_empleado.SelectedText = "";
            txtbox_nombre_empleado.SelectionLength = 0;
            txtbox_nombre_empleado.SelectionStart = 0;
            txtbox_nombre_empleado.ShortcutsEnabled = true;
            txtbox_nombre_empleado.Size = new Size(312, 48);
            txtbox_nombre_empleado.TabIndex = 29;
            txtbox_nombre_empleado.TabStop = false;
            txtbox_nombre_empleado.TextAlign = HorizontalAlignment.Left;
            txtbox_nombre_empleado.TrailingIcon = null;
            txtbox_nombre_empleado.UseSystemPasswordChar = false;
            // 
            // lbl_nombre
            // 
            lbl_nombre.Anchor = AnchorStyles.None;
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = SystemColors.ControlText;
            lbl_nombre.Location = new Point(531, 279);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(89, 28);
            lbl_nombre.TabIndex = 28;
            lbl_nombre.Text = "Nombre:";
            // 
            // lbl_GestionEmpleados
            // 
            lbl_GestionEmpleados.Anchor = AnchorStyles.None;
            lbl_GestionEmpleados.AutoSize = true;
            lbl_GestionEmpleados.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GestionEmpleados.Location = new Point(575, 131);
            lbl_GestionEmpleados.Name = "lbl_GestionEmpleados";
            lbl_GestionEmpleados.Size = new Size(428, 62);
            lbl_GestionEmpleados.TabIndex = 27;
            lbl_GestionEmpleados.Text = "Gestión empleados";
            // 
            // lbl_contraseña
            // 
            lbl_contraseña.Anchor = AnchorStyles.None;
            lbl_contraseña.AutoSize = true;
            lbl_contraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_contraseña.ForeColor = SystemColors.ControlText;
            lbl_contraseña.Location = new Point(507, 749);
            lbl_contraseña.Name = "lbl_contraseña";
            lbl_contraseña.Size = new Size(114, 28);
            lbl_contraseña.TabIndex = 44;
            lbl_contraseña.Text = "Contraseña:";
            // 
            // lbl_usuario
            // 
            lbl_usuario.Anchor = AnchorStyles.None;
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = SystemColors.ControlText;
            lbl_usuario.Location = new Point(518, 672);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(83, 28);
            lbl_usuario.TabIndex = 45;
            lbl_usuario.Text = "Usuario:";
            // 
            // txtbox_usuario
            // 
            txtbox_usuario.Anchor = AnchorStyles.None;
            txtbox_usuario.AnimateReadOnly = false;
            txtbox_usuario.BackgroundImageLayout = ImageLayout.None;
            txtbox_usuario.CharacterCasing = CharacterCasing.Normal;
            txtbox_usuario.Depth = 0;
            txtbox_usuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_usuario.HideSelection = true;
            txtbox_usuario.LeadingIcon = null;
            txtbox_usuario.Location = new Point(648, 652);
            txtbox_usuario.MaxLength = 32767;
            txtbox_usuario.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_usuario.Name = "txtbox_usuario";
            txtbox_usuario.PasswordChar = '\0';
            txtbox_usuario.PrefixSuffixText = null;
            txtbox_usuario.ReadOnly = false;
            txtbox_usuario.RightToLeft = RightToLeft.No;
            txtbox_usuario.SelectedText = "";
            txtbox_usuario.SelectionLength = 0;
            txtbox_usuario.SelectionStart = 0;
            txtbox_usuario.ShortcutsEnabled = true;
            txtbox_usuario.Size = new Size(312, 48);
            txtbox_usuario.TabIndex = 46;
            txtbox_usuario.TabStop = false;
            txtbox_usuario.TextAlign = HorizontalAlignment.Left;
            txtbox_usuario.TrailingIcon = null;
            txtbox_usuario.UseSystemPasswordChar = false;
            // 
            // txtbox_contraseña
            // 
            txtbox_contraseña.Anchor = AnchorStyles.None;
            txtbox_contraseña.AnimateReadOnly = false;
            txtbox_contraseña.BackgroundImageLayout = ImageLayout.None;
            txtbox_contraseña.CharacterCasing = CharacterCasing.Normal;
            txtbox_contraseña.Depth = 0;
            txtbox_contraseña.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_contraseña.HideSelection = true;
            txtbox_contraseña.LeadingIcon = null;
            txtbox_contraseña.Location = new Point(648, 729);
            txtbox_contraseña.MaxLength = 32767;
            txtbox_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_contraseña.Name = "txtbox_contraseña";
            txtbox_contraseña.PasswordChar = '\0';
            txtbox_contraseña.PrefixSuffixText = null;
            txtbox_contraseña.ReadOnly = false;
            txtbox_contraseña.RightToLeft = RightToLeft.No;
            txtbox_contraseña.SelectedText = "";
            txtbox_contraseña.SelectionLength = 0;
            txtbox_contraseña.SelectionStart = 0;
            txtbox_contraseña.ShortcutsEnabled = true;
            txtbox_contraseña.Size = new Size(312, 48);
            txtbox_contraseña.TabIndex = 47;
            txtbox_contraseña.TabStop = false;
            txtbox_contraseña.TextAlign = HorizontalAlignment.Left;
            txtbox_contraseña.TrailingIcon = null;
            txtbox_contraseña.UseSystemPasswordChar = false;
            // 
            // Form_Agregar_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_agregar_empleado);
            Name = "Form_Agregar_Empleado";
            Text = "InkPOS - Agregar empleado";
            WindowState = FormWindowState.Maximized;
            panel_agregar_empleado.ResumeLayout(false);
            panel_agregar_empleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_agregar_empleado;
        private Label lbl_salario;
        private Label lbl_cargo;
        private Label lbl_telefono;
        private MaterialSkin.Controls.MaterialButton button_agregar_empleado;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_cedula;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_telefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_salario;
        private MaterialSkin.Controls.MaterialButton button_salir;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
        private Label lbl_cedula;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nombre_empleado;
        private Label lbl_nombre;
        private Label lbl_GestionEmpleados;
        private MaterialSkin.Controls.MaterialComboBox CB_cargo;
        private Label lbl_usuario;
        private Label lbl_contraseña;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_contraseña;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_usuario;
    }
}