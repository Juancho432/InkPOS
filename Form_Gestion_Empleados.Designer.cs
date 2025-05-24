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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Empleados));
            panel_GE = new Panel();
            dgv_Empleados = new DataGridView();
            idEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            esAdminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            salarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoBindingSource = new BindingSource(components);
            txtbox_buscar_empleado = new MaterialSkin.Controls.MaterialTextBox2();
            button_añadir_empleado = new Button();
            button_salir = new Button();
            lbl_GE = new Label();
            panel_GE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_GE
            // 
            panel_GE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GE.Controls.Add(dgv_Empleados);
            panel_GE.Controls.Add(txtbox_buscar_empleado);
            panel_GE.Controls.Add(button_añadir_empleado);
            panel_GE.Controls.Add(button_salir);
            panel_GE.Controls.Add(lbl_GE);
            panel_GE.Location = new Point(5, 2);
            panel_GE.Name = "panel_GE";
            panel_GE.Size = new Size(1513, 1051);
            panel_GE.TabIndex = 0;
            // 
            // dgv_Empleados
            // 
            dgv_Empleados.AllowUserToAddRows = false;
            dgv_Empleados.AllowUserToDeleteRows = false;
            dgv_Empleados.AllowUserToResizeColumns = false;
            dgv_Empleados.AllowUserToResizeRows = false;
            dgv_Empleados.Anchor = AnchorStyles.None;
            dgv_Empleados.AutoGenerateColumns = false;
            dgv_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Empleados.Columns.AddRange(new DataGridViewColumn[] { idEmpleadoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, esAdminDataGridViewCheckBoxColumn, salarioDataGridViewTextBoxColumn });
            dgv_Empleados.DataSource = empleadoBindingSource;
            dgv_Empleados.Location = new Point(105, 304);
            dgv_Empleados.MultiSelect = false;
            dgv_Empleados.Name = "dgv_Empleados";
            dgv_Empleados.ReadOnly = true;
            dgv_Empleados.RowHeadersVisible = false;
            dgv_Empleados.RowHeadersWidth = 51;
            dgv_Empleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Empleados.Size = new Size(1322, 670);
            dgv_Empleados.TabIndex = 10;
            dgv_Empleados.CellClick += dgv_Empleados_CellClick;
            dgv_Empleados.Leave += dgv_Empleados_Leave;
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Id_Empleado";
            idEmpleadoDataGridViewTextBoxColumn.HeaderText = "Id_Empleado";
            idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // esAdminDataGridViewCheckBoxColumn
            // 
            esAdminDataGridViewCheckBoxColumn.DataPropertyName = "Es_Admin";
            esAdminDataGridViewCheckBoxColumn.HeaderText = "Es_Admin";
            esAdminDataGridViewCheckBoxColumn.MinimumWidth = 6;
            esAdminDataGridViewCheckBoxColumn.Name = "esAdminDataGridViewCheckBoxColumn";
            esAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            salarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Empleado);
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
            txtbox_buscar_empleado.Location = new Point(649, 157);
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
            txtbox_buscar_empleado.TextChanged += txtbox_buscar_empleado_TextChanged;
            // 
            // button_añadir_empleado
            // 
            button_añadir_empleado.Anchor = AnchorStyles.None;
            button_añadir_empleado.Image = (Image)resources.GetObject("button_añadir_empleado.Image");
            button_añadir_empleado.Location = new Point(1293, 157);
            button_añadir_empleado.Name = "button_añadir_empleado";
            button_añadir_empleado.Size = new Size(69, 48);
            button_añadir_empleado.TabIndex = 8;
            button_añadir_empleado.UseVisualStyleBackColor = true;
            button_añadir_empleado.Click += button_añadir_empleado_Click;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(214, 157);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 7;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // lbl_GE
            // 
            lbl_GE.Anchor = AnchorStyles.None;
            lbl_GE.AutoSize = true;
            lbl_GE.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GE.Location = new Point(604, 44);
            lbl_GE.Name = "lbl_GE";
            lbl_GE.Size = new Size(419, 54);
            lbl_GE.TabIndex = 6;
            lbl_GE.Text = "Gestión de empleados";
            // 
            // Form_Gestion_Empleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_GE);
            Name = "Form_Gestion_Empleados";
            Text = "InkPOS _ Gestion de empleados";
            WindowState = FormWindowState.Maximized;
            Load += Form_Gestion_Empleados_Load;
            MouseDown += Form_Gestion_Empleados_MouseDown;
            panel_GE.ResumeLayout(false);
            panel_GE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GE;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_empleado;
        private Button button_añadir_empleado;
        private Button button_salir;
        private Label lbl_GE;
        private DataGridView dgv_Empleados;
        private DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn esAdminDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private BindingSource empleadoBindingSource;
    }
}