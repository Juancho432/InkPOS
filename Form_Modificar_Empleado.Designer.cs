namespace InkPos
{
    partial class Form_Modificar_Empleado
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
            panel_gestion_empleados = new Panel();
            txtbox_cedula = new MaterialSkin.Controls.MaterialTextBox2();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            button_confirmar = new MaterialSkin.Controls.MaterialButton();
            lbl_GestionEmpleados = new Label();
            lbl_ingresevalor = new Label();
            CB_valor_a_modificar = new MaterialSkin.Controls.MaterialComboBox();
            txtbox_nuevo_valor = new MaterialSkin.Controls.MaterialTextBox2();
            CB_cargo = new MaterialSkin.Controls.MaterialComboBox();
            lbl_cargo = new Label();
            panel_gestion_empleados.SuspendLayout();
            SuspendLayout();
            // 
            // panel_gestion_empleados
            // 
            panel_gestion_empleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_gestion_empleados.Controls.Add(lbl_cargo);
            panel_gestion_empleados.Controls.Add(CB_cargo);
            panel_gestion_empleados.Controls.Add(lbl_ingresevalor);
            panel_gestion_empleados.Controls.Add(CB_valor_a_modificar);
            panel_gestion_empleados.Controls.Add(txtbox_nuevo_valor);
            panel_gestion_empleados.Controls.Add(txtbox_cedula);
            panel_gestion_empleados.Controls.Add(button_salir);
            panel_gestion_empleados.Controls.Add(button_limpiar);
            panel_gestion_empleados.Controls.Add(button_confirmar);
            panel_gestion_empleados.Controls.Add(lbl_GestionEmpleados);
            panel_gestion_empleados.Location = new Point(5, 2);
            panel_gestion_empleados.Name = "panel_gestion_empleados";
            panel_gestion_empleados.Size = new Size(1513, 1051);
            panel_gestion_empleados.TabIndex = 0;
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
            txtbox_cedula.Hint = "Ingrese la cédula del empleado";
            txtbox_cedula.LeadingIcon = null;
            txtbox_cedula.Location = new Point(600, 141);
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
            txtbox_cedula.TabIndex = 22;
            txtbox_cedula.TabStop = false;
            txtbox_cedula.TextAlign = HorizontalAlignment.Left;
            txtbox_cedula.TrailingIcon = null;
            txtbox_cedula.UseSystemPasswordChar = false;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(905, 683);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 17;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(735, 683);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(79, 36);
            button_limpiar.TabIndex = 16;
            button_limpiar.Text = "LIMPIAR";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_confirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_confirmar.Depth = 0;
            button_confirmar.HighEmphasis = true;
            button_confirmar.Icon = null;
            button_confirmar.Location = new Point(527, 683);
            button_confirmar.Margin = new Padding(4, 6, 4, 6);
            button_confirmar.MouseState = MaterialSkin.MouseState.HOVER;
            button_confirmar.Name = "button_confirmar";
            button_confirmar.NoAccentTextColor = Color.Empty;
            button_confirmar.Size = new Size(105, 36);
            button_confirmar.TabIndex = 15;
            button_confirmar.Text = "confirmar";
            button_confirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_confirmar.UseAccentColor = false;
            button_confirmar.UseVisualStyleBackColor = true;
            button_confirmar.Click += button_confirmar_Click;
            // 
            // lbl_GestionEmpleados
            // 
            lbl_GestionEmpleados.Anchor = AnchorStyles.None;
            lbl_GestionEmpleados.AutoSize = true;
            lbl_GestionEmpleados.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GestionEmpleados.Location = new Point(527, 25);
            lbl_GestionEmpleados.Name = "lbl_GestionEmpleados";
            lbl_GestionEmpleados.Size = new Size(428, 62);
            lbl_GestionEmpleados.TabIndex = 9;
            lbl_GestionEmpleados.Text = "Gestión empleados";
            // 
            // lbl_ingresevalor
            // 
            lbl_ingresevalor.Anchor = AnchorStyles.None;
            lbl_ingresevalor.AutoSize = true;
            lbl_ingresevalor.Location = new Point(537, 378);
            lbl_ingresevalor.Name = "lbl_ingresevalor";
            lbl_ingresevalor.Size = new Size(157, 20);
            lbl_ingresevalor.TabIndex = 25;
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
            CB_valor_a_modificar.Items.AddRange(new object[] { "Nombre", "Télefono", "Salario" });
            CB_valor_a_modificar.Location = new Point(621, 264);
            CB_valor_a_modificar.MaxDropDownItems = 4;
            CB_valor_a_modificar.MouseState = MaterialSkin.MouseState.OUT;
            CB_valor_a_modificar.Name = "CB_valor_a_modificar";
            CB_valor_a_modificar.Size = new Size(264, 49);
            CB_valor_a_modificar.StartIndex = 0;
            CB_valor_a_modificar.TabIndex = 24;
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
            txtbox_nuevo_valor.Location = new Point(726, 364);
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
            txtbox_nuevo_valor.TabIndex = 23;
            txtbox_nuevo_valor.TabStop = false;
            txtbox_nuevo_valor.TextAlign = HorizontalAlignment.Left;
            txtbox_nuevo_valor.TrailingIcon = null;
            txtbox_nuevo_valor.UseSystemPasswordChar = false;
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
            CB_cargo.IntegralHeight = false;
            CB_cargo.ItemHeight = 43;
            CB_cargo.Items.AddRange(new object[] { "Empleado", "Administrador" });
            CB_cargo.Location = new Point(726, 467);
            CB_cargo.MaxDropDownItems = 4;
            CB_cargo.MouseState = MaterialSkin.MouseState.OUT;
            CB_cargo.Name = "CB_cargo";
            CB_cargo.Size = new Size(243, 49);
            CB_cargo.StartIndex = 0;
            CB_cargo.TabIndex = 26;
            // 
            // lbl_cargo
            // 
            lbl_cargo.Anchor = AnchorStyles.None;
            lbl_cargo.AutoSize = true;
            lbl_cargo.Location = new Point(642, 487);
            lbl_cargo.Name = "lbl_cargo";
            lbl_cargo.Size = new Size(52, 20);
            lbl_cargo.TabIndex = 27;
            lbl_cargo.Text = "Cargo:";
            // 
            // Form_Modificar_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_gestion_empleados);
            Name = "Form_Modificar_Empleado";
            Text = "InkPOS - Gestión de empleados";
            WindowState = FormWindowState.Maximized;
            panel_gestion_empleados.ResumeLayout(false);
            panel_gestion_empleados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_gestion_empleados;
        private MaterialSkin.Controls.MaterialButton button_salir;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
        private MaterialSkin.Controls.MaterialButton button_confirmar;
        private Label lbl_GestionEmpleados;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_cedula;
        private MaterialSkin.Controls.MaterialComboBox CB_cargo;
        private Label lbl_ingresevalor;
        private MaterialSkin.Controls.MaterialComboBox CB_valor_a_modificar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_nuevo_valor;
        private Label lbl_cargo;
    }
}