namespace InkPos
{
    partial class Form_Gestion_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Empleados));
            panel_GE = new Panel();
            dgv_Empleados = new DataGridView();
            txtbox_buscar_empleado = new MaterialSkin.Controls.MaterialTextBox2();
            button_añadir_producto = new Button();
            button_salir = new Button();
            lbl_GE = new Label();
            Column_IDempleado = new DataGridViewTextBoxColumn();
            Column_Nombre = new DataGridViewTextBoxColumn();
            Column_Telefono = new DataGridViewTextBoxColumn();
            Column_Usuario = new DataGridViewTextBoxColumn();
            Column_Es_admin = new DataGridViewTextBoxColumn();
            Column_salario = new DataGridViewTextBoxColumn();
            panel_GE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).BeginInit();
            SuspendLayout();
            // 
            // panel_GE
            // 
            panel_GE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GE.Controls.Add(dgv_Empleados);
            panel_GE.Controls.Add(txtbox_buscar_empleado);
            panel_GE.Controls.Add(button_añadir_producto);
            panel_GE.Controls.Add(button_salir);
            panel_GE.Controls.Add(lbl_GE);
            panel_GE.Location = new Point(5, 2);
            panel_GE.Name = "panel_GE";
            panel_GE.Size = new Size(1513, 1171);
            panel_GE.TabIndex = 0;
            // 
            // dgv_Empleados
            // 
            dgv_Empleados.Anchor = AnchorStyles.None;
            dgv_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Empleados.Columns.AddRange(new DataGridViewColumn[] { Column_IDempleado, Column_Nombre, Column_Telefono, Column_Usuario, Column_Es_admin, Column_salario });
            dgv_Empleados.Location = new Point(105, 364);
            dgv_Empleados.Name = "dgv_Empleados";
            dgv_Empleados.RowHeadersVisible = false;
            dgv_Empleados.RowHeadersWidth = 51;
            dgv_Empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Empleados.Size = new Size(1322, 670);
            dgv_Empleados.TabIndex = 10;
            // 
            // txtbox_buscar_empleado
            // 
            txtbox_buscar_empleado.Anchor = AnchorStyles.None;
            txtbox_buscar_empleado.AnimateReadOnly = false;
            txtbox_buscar_empleado.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar_empleado.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar_empleado.Depth = 0;
            txtbox_buscar_empleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar_empleado.HideSelection = true;
            txtbox_buscar_empleado.Hint = "Ingrese la cédula del empleado";
            txtbox_buscar_empleado.LeadingIcon = null;
            txtbox_buscar_empleado.Location = new Point(649, 217);
            txtbox_buscar_empleado.MaxLength = 32767;
            txtbox_buscar_empleado.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar_empleado.Name = "txtbox_buscar_empleado";
            txtbox_buscar_empleado.PasswordChar = '\0';
            txtbox_buscar_empleado.PrefixSuffixText = null;
            txtbox_buscar_empleado.ReadOnly = false;
            txtbox_buscar_empleado.RightToLeft = RightToLeft.No;
            txtbox_buscar_empleado.SelectedText = "";
            txtbox_buscar_empleado.SelectionLength = 0;
            txtbox_buscar_empleado.SelectionStart = 0;
            txtbox_buscar_empleado.ShortcutsEnabled = true;
            txtbox_buscar_empleado.Size = new Size(332, 48);
            txtbox_buscar_empleado.TabIndex = 9;
            txtbox_buscar_empleado.TabStop = false;
            txtbox_buscar_empleado.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_empleado.TrailingIcon = null;
            txtbox_buscar_empleado.UseSystemPasswordChar = false;
            // 
            // button_añadir_producto
            // 
            button_añadir_producto.Anchor = AnchorStyles.None;
            button_añadir_producto.Image = (Image)resources.GetObject("button_añadir_producto.Image");
            button_añadir_producto.Location = new Point(1293, 217);
            button_añadir_producto.Name = "button_añadir_producto";
            button_añadir_producto.Size = new Size(69, 48);
            button_añadir_producto.TabIndex = 8;
            button_añadir_producto.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(214, 217);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 7;
            button_salir.UseVisualStyleBackColor = true;
            // 
            // lbl_GE
            // 
            lbl_GE.Anchor = AnchorStyles.None;
            lbl_GE.AutoSize = true;
            lbl_GE.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GE.Location = new Point(604, 104);
            lbl_GE.Name = "lbl_GE";
            lbl_GE.Size = new Size(419, 54);
            lbl_GE.TabIndex = 6;
            lbl_GE.Text = "Gestión de empleados";
            // 
            // Column_IDempleado
            // 
            Column_IDempleado.HeaderText = "Cédula";
            Column_IDempleado.MinimumWidth = 6;
            Column_IDempleado.Name = "Column_IDempleado";
            // 
            // Column_Nombre
            // 
            Column_Nombre.HeaderText = "Nombre";
            Column_Nombre.MinimumWidth = 6;
            Column_Nombre.Name = "Column_Nombre";
            // 
            // Column_Telefono
            // 
            Column_Telefono.HeaderText = "Teléfono";
            Column_Telefono.MinimumWidth = 6;
            Column_Telefono.Name = "Column_Telefono";
            // 
            // Column_Usuario
            // 
            Column_Usuario.HeaderText = "Usuario";
            Column_Usuario.MinimumWidth = 6;
            Column_Usuario.Name = "Column_Usuario";
            // 
            // Column_Es_admin
            // 
            Column_Es_admin.HeaderText = "Rol";
            Column_Es_admin.MinimumWidth = 6;
            Column_Es_admin.Name = "Column_Es_admin";
            // 
            // Column_salario
            // 
            Column_salario.HeaderText = "Salario";
            Column_salario.MinimumWidth = 6;
            Column_salario.Name = "Column_salario";
            // 
            // Form_Gestion_Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_GE);
            Name = "Form_Gestion_Empleados";
            Text = "InkPOS _ Gestion de empleados";
            WindowState = FormWindowState.Maximized;
            panel_GE.ResumeLayout(false);
            panel_GE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GE;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_empleado;
        private Button button_añadir_producto;
        private Button button_salir;
        private Label lbl_GE;
        private DataGridView dgv_Empleados;
        private DataGridViewTextBoxColumn Column_IDempleado;
        private DataGridViewTextBoxColumn Column_Nombre;
        private DataGridViewTextBoxColumn Column_Telefono;
        private DataGridViewTextBoxColumn Column_Usuario;
        private DataGridViewTextBoxColumn Column_Es_admin;
        private DataGridViewTextBoxColumn Column_salario;
    }
}