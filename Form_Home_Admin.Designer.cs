namespace InkPos
{
    partial class Form_Home_Admin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Admin));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbl_welcome = new Label();
            lbl_nombre_empleado = new Label();
            groupBox1 = new GroupBox();
            button_facturas = new Guna.UI2.WinForms.Guna2Button();
            button_gestion_empleados = new Guna.UI2.WinForms.Guna2Button();
            button_maestro_productos = new Guna.UI2.WinForms.Guna2Button();
            button_venta = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Tahoma", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(432, 98);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(287, 57);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Bienvenido";
            // 
            // lbl_nombre_empleado
            // 
            lbl_nombre_empleado.Anchor = AnchorStyles.None;
            lbl_nombre_empleado.AutoSize = true;
            lbl_nombre_empleado.Font = new Font("Tahoma", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_nombre_empleado.Location = new Point(725, 98);
            lbl_nombre_empleado.Name = "lbl_nombre_empleado";
            lbl_nombre_empleado.Size = new Size(325, 57);
            lbl_nombre_empleado.TabIndex = 1;
            lbl_nombre_empleado.Text = "__________";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button_facturas);
            groupBox1.Controls.Add(button_gestion_empleados);
            groupBox1.Controls.Add(button_maestro_productos);
            groupBox1.Controls.Add(button_venta);
            groupBox1.Controls.Add(lbl_nombre_empleado);
            groupBox1.Controls.Add(lbl_welcome);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1608, 740);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button_facturas
            // 
            button_facturas.Anchor = AnchorStyles.None;
            button_facturas.BorderRadius = 90;
            button_facturas.CustomizableEdges = customizableEdges1;
            button_facturas.DisabledState.BorderColor = Color.DarkGray;
            button_facturas.DisabledState.CustomBorderColor = Color.DarkGray;
            button_facturas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_facturas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_facturas.FillColor = Color.Purple;
            button_facturas.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_facturas.ForeColor = Color.White;
            button_facturas.Image = (Image)resources.GetObject("button_facturas.Image");
            button_facturas.ImageOffset = new Point(20, -10);
            button_facturas.ImageSize = new Size(90, 90);
            button_facturas.Location = new Point(808, 442);
            button_facturas.Name = "button_facturas";
            button_facturas.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button_facturas.Size = new Size(180, 180);
            button_facturas.TabIndex = 5;
            button_facturas.Text = "Facturas";
            button_facturas.TextOffset = new Point(-22, 60);
            button_facturas.Click += button_facturas_Click;
            // 
            // button_gestion_empleados
            // 
            button_gestion_empleados.Anchor = AnchorStyles.None;
            button_gestion_empleados.BorderRadius = 90;
            button_gestion_empleados.CustomizableEdges = customizableEdges3;
            button_gestion_empleados.DisabledState.BorderColor = Color.DarkGray;
            button_gestion_empleados.DisabledState.CustomBorderColor = Color.DarkGray;
            button_gestion_empleados.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_gestion_empleados.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_gestion_empleados.FillColor = Color.Purple;
            button_gestion_empleados.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_gestion_empleados.ForeColor = Color.White;
            button_gestion_empleados.Image = (Image)resources.GetObject("button_gestion_empleados.Image");
            button_gestion_empleados.ImageOffset = new Point(43, -10);
            button_gestion_empleados.ImageSize = new Size(90, 90);
            button_gestion_empleados.Location = new Point(498, 442);
            button_gestion_empleados.Name = "button_gestion_empleados";
            button_gestion_empleados.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button_gestion_empleados.Size = new Size(180, 180);
            button_gestion_empleados.TabIndex = 4;
            button_gestion_empleados.Text = "Gestión de empleados";
            button_gestion_empleados.TextOffset = new Point(-24, 60);
            button_gestion_empleados.Click += button_gestion_empleados_Click;
            // 
            // button_maestro_productos
            // 
            button_maestro_productos.Anchor = AnchorStyles.None;
            button_maestro_productos.BorderRadius = 90;
            button_maestro_productos.CustomizableEdges = customizableEdges5;
            button_maestro_productos.DisabledState.BorderColor = Color.DarkGray;
            button_maestro_productos.DisabledState.CustomBorderColor = Color.DarkGray;
            button_maestro_productos.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_maestro_productos.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_maestro_productos.FillColor = Color.Purple;
            button_maestro_productos.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_maestro_productos.ForeColor = Color.White;
            button_maestro_productos.Image = (Image)resources.GetObject("button_maestro_productos.Image");
            button_maestro_productos.ImageOffset = new Point(43, -10);
            button_maestro_productos.ImageSize = new Size(90, 90);
            button_maestro_productos.Location = new Point(808, 213);
            button_maestro_productos.Name = "button_maestro_productos";
            button_maestro_productos.ShadowDecoration.CustomizableEdges = customizableEdges6;
            button_maestro_productos.Size = new Size(180, 180);
            button_maestro_productos.TabIndex = 3;
            button_maestro_productos.Text = "Maestro de productos";
            button_maestro_productos.TextOffset = new Point(-23, 60);
            button_maestro_productos.Click += button_maestro_productos_Click;
            // 
            // button_venta
            // 
            button_venta.Anchor = AnchorStyles.None;
            button_venta.BorderRadius = 90;
            button_venta.CustomizableEdges = customizableEdges7;
            button_venta.DisabledState.BorderColor = Color.DarkGray;
            button_venta.DisabledState.CustomBorderColor = Color.DarkGray;
            button_venta.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_venta.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_venta.FillColor = Color.Purple;
            button_venta.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_venta.ForeColor = Color.White;
            button_venta.Image = (Image)resources.GetObject("button_venta.Image");
            button_venta.ImageOffset = new Point(13, -10);
            button_venta.ImageSize = new Size(90, 90);
            button_venta.Location = new Point(498, 213);
            button_venta.Name = "button_venta";
            button_venta.ShadowDecoration.CustomizableEdges = customizableEdges8;
            button_venta.Size = new Size(180, 180);
            button_venta.TabIndex = 2;
            button_venta.Text = "Venta";
            button_venta.TextOffset = new Point(-22, 60);
            button_venta.Click += guna2Button1_Click;
            // 
            // menu_opciones_admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1527, 735);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "menu_opciones_admin";
            Text = "InkPos - Menú de inicio";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_welcome;
        private Label lbl_nombre_empleado;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button button_venta;
        private Guna.UI2.WinForms.Guna2Button button_gestion_empleados;
        private Guna.UI2.WinForms.Guna2Button button_maestro_productos;
        private Guna.UI2.WinForms.Guna2Button button_facturas;
    }
}