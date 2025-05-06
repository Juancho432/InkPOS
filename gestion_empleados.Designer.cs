namespace InkPos
{
    partial class gestion_empleados
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_empleados));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtbox_cargo = new TextBox();
            txtbox_salario = new TextBox();
            txtbox_telefono = new TextBox();
            txtbox_cedula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lbl_nuevovalor = new Label();
            button_agregar_empleado = new Button();
            button_confirmar = new Button();
            button_limpiar = new Button();
            button_salir = new Button();
            linkLabel_ver = new LinkLabel();
            txtbox_buscar_cedula_empleado = new Guna.UI2.WinForms.Guna2TextBox();
            txtbox_nombre = new TextBox();
            lbl_gestion_empleados = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtbox_cargo);
            groupBox1.Controls.Add(txtbox_salario);
            groupBox1.Controls.Add(txtbox_telefono);
            groupBox1.Controls.Add(txtbox_cedula);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_nuevovalor);
            groupBox1.Controls.Add(button_agregar_empleado);
            groupBox1.Controls.Add(button_confirmar);
            groupBox1.Controls.Add(button_limpiar);
            groupBox1.Controls.Add(button_salir);
            groupBox1.Controls.Add(linkLabel_ver);
            groupBox1.Controls.Add(txtbox_buscar_cedula_empleado);
            groupBox1.Controls.Add(txtbox_nombre);
            groupBox1.Controls.Add(lbl_gestion_empleados);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 8);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1312, 790);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(516, 392);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 29;
            label4.Text = "Salario:";
            // 
            // txtbox_cargo
            // 
            txtbox_cargo.Anchor = AnchorStyles.None;
            txtbox_cargo.Location = new Point(624, 347);
            txtbox_cargo.Margin = new Padding(3, 2, 3, 2);
            txtbox_cargo.Multiline = true;
            txtbox_cargo.Name = "txtbox_cargo";
            txtbox_cargo.Size = new Size(154, 26);
            txtbox_cargo.TabIndex = 28;
            txtbox_cargo.TextChanged += txtbox_cargo_TextChanged;
            // 
            // txtbox_salario
            // 
            txtbox_salario.Anchor = AnchorStyles.None;
            txtbox_salario.Location = new Point(624, 386);
            txtbox_salario.Margin = new Padding(3, 2, 3, 2);
            txtbox_salario.Multiline = true;
            txtbox_salario.Name = "txtbox_salario";
            txtbox_salario.Size = new Size(154, 26);
            txtbox_salario.TabIndex = 27;
            txtbox_salario.TextChanged += txtbox_salario_TextChanged;
            // 
            // txtbox_telefono
            // 
            txtbox_telefono.Anchor = AnchorStyles.None;
            txtbox_telefono.Location = new Point(624, 302);
            txtbox_telefono.Margin = new Padding(3, 2, 3, 2);
            txtbox_telefono.Multiline = true;
            txtbox_telefono.Name = "txtbox_telefono";
            txtbox_telefono.Size = new Size(154, 26);
            txtbox_telefono.TabIndex = 26;
            txtbox_telefono.TextChanged += txtbox_telefono_TextChanged;
            // 
            // txtbox_cedula
            // 
            txtbox_cedula.Anchor = AnchorStyles.None;
            txtbox_cedula.Location = new Point(624, 259);
            txtbox_cedula.Margin = new Padding(3, 2, 3, 2);
            txtbox_cedula.Multiline = true;
            txtbox_cedula.Name = "txtbox_cedula";
            txtbox_cedula.Size = new Size(154, 26);
            txtbox_cedula.TabIndex = 25;
            txtbox_cedula.TextChanged += txtbox_cedula_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(522, 345);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 24;
            label3.Text = "Cargo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(503, 302);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 23;
            label2.Text = "Teléfono:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(515, 265);
            label1.Name = "label1";
            label1.Size = new Size(73, 22);
            label1.TabIndex = 22;
            label1.Text = "Cédula:";
            // 
            // lbl_nuevovalor
            // 
            lbl_nuevovalor.Anchor = AnchorStyles.None;
            lbl_nuevovalor.AutoSize = true;
            lbl_nuevovalor.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nuevovalor.Location = new Point(505, 227);
            lbl_nuevovalor.Name = "lbl_nuevovalor";
            lbl_nuevovalor.Size = new Size(81, 22);
            lbl_nuevovalor.TabIndex = 21;
            lbl_nuevovalor.Text = "Nombre:";
            lbl_nuevovalor.Click += lbl_nuevovalor_Click;
            // 
            // button_agregar_empleado
            // 
            button_agregar_empleado.Anchor = AnchorStyles.None;
            button_agregar_empleado.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_agregar_empleado.Location = new Point(732, 137);
            button_agregar_empleado.Margin = new Padding(3, 2, 3, 2);
            button_agregar_empleado.Name = "button_agregar_empleado";
            button_agregar_empleado.Size = new Size(229, 45);
            button_agregar_empleado.TabIndex = 20;
            button_agregar_empleado.Text = "Agregar nuevo empleado";
            button_agregar_empleado.UseVisualStyleBackColor = true;
            button_agregar_empleado.Click += button_agregar_empleado_Click;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_confirmar.Location = new Point(425, 461);
            button_confirmar.Margin = new Padding(3, 2, 3, 2);
            button_confirmar.Name = "button_confirmar";
            button_confirmar.Size = new Size(112, 33);
            button_confirmar.TabIndex = 19;
            button_confirmar.Text = "Confirmar";
            button_confirmar.UseVisualStyleBackColor = true;
            button_confirmar.Click += button_confirmar_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_limpiar.Location = new Point(607, 461);
            button_limpiar.Margin = new Padding(3, 2, 3, 2);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(82, 33);
            button_limpiar.TabIndex = 18;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_salir.Location = new Point(765, 461);
            button_salir.Margin = new Padding(3, 2, 3, 2);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(82, 33);
            button_salir.TabIndex = 17;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // linkLabel_ver
            // 
            linkLabel_ver.Anchor = AnchorStyles.None;
            linkLabel_ver.AutoSize = true;
            linkLabel_ver.Location = new Point(494, 347);
            linkLabel_ver.Name = "linkLabel_ver";
            linkLabel_ver.Size = new Size(0, 25);
            linkLabel_ver.TabIndex = 3;
            // 
            // txtbox_buscar_cedula_empleado
            // 
            txtbox_buscar_cedula_empleado.Anchor = AnchorStyles.None;
            txtbox_buscar_cedula_empleado.BorderRadius = 20;
            txtbox_buscar_cedula_empleado.CustomizableEdges = customizableEdges17;
            txtbox_buscar_cedula_empleado.DefaultText = "";
            txtbox_buscar_cedula_empleado.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbox_buscar_cedula_empleado.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbox_buscar_cedula_empleado.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbox_buscar_cedula_empleado.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbox_buscar_cedula_empleado.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_buscar_cedula_empleado.Font = new Font("Segoe UI", 9F);
            txtbox_buscar_cedula_empleado.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_buscar_cedula_empleado.IconRight = (Image)resources.GetObject("txtbox_buscar_cedula_empleado.IconRight");
            txtbox_buscar_cedula_empleado.IconRightSize = new Size(24, 24);
            txtbox_buscar_cedula_empleado.Location = new Point(331, 137);
            txtbox_buscar_cedula_empleado.Name = "txtbox_buscar_cedula_empleado";
            txtbox_buscar_cedula_empleado.PlaceholderText = "Ingrese la cédula del empleado";
            txtbox_buscar_cedula_empleado.SelectedText = "";
            txtbox_buscar_cedula_empleado.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtbox_buscar_cedula_empleado.Size = new Size(228, 45);
            txtbox_buscar_cedula_empleado.TabIndex = 2;
            // 
            // txtbox_nombre
            // 
            txtbox_nombre.Anchor = AnchorStyles.None;
            txtbox_nombre.Location = new Point(624, 221);
            txtbox_nombre.Margin = new Padding(3, 2, 3, 2);
            txtbox_nombre.Multiline = true;
            txtbox_nombre.Name = "txtbox_nombre";
            txtbox_nombre.Size = new Size(154, 26);
            txtbox_nombre.TabIndex = 1;
            txtbox_nombre.TextChanged += txtbox_nombre_TextChanged;
            // 
            // lbl_gestion_empleados
            // 
            lbl_gestion_empleados.Anchor = AnchorStyles.None;
            lbl_gestion_empleados.AutoSize = true;
            lbl_gestion_empleados.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_gestion_empleados.Location = new Point(439, 56);
            lbl_gestion_empleados.Name = "lbl_gestion_empleados";
            lbl_gestion_empleados.Size = new Size(370, 39);
            lbl_gestion_empleados.TabIndex = 0;
            lbl_gestion_empleados.Text = "Gestión de empleados";
            // 
            // gestion_empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1338, 553);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "gestion_empleados";
            Text = "InkPOS - Gestión de empleados";
            WindowState = FormWindowState.Maximized;
            Load += gestion_empleados_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_salir;
        private LinkLabel linkLabel_ver;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_buscar_cedula_empleado;
        private TextBox txtbox_nombre;
        private Label lbl_gestion_empleados;
        private Button button_agregar_empleado;
        private Button button_confirmar;
        private Button button_limpiar;
        private Label label1;
        private Label lbl_nuevovalor;
        private Label label4;
        private TextBox txtbox_cargo;
        private TextBox txtbox_salario;
        private TextBox txtbox_telefono;
        private TextBox txtbox_cedula;
        private Label label3;
        private Label label2;
    }
}