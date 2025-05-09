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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Admin));
            panel_home_admin = new Panel();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            panel_MProductos = new Panel();
            button_maestro_productos = new MaterialSkin.Controls.MaterialButton();
            PB_MProductos = new PictureBox();
            panel_facturas = new Panel();
            button_facturas = new MaterialSkin.Controls.MaterialButton();
            PB_facturas = new PictureBox();
            panel_button_GEmpleados = new Panel();
            button_GEmpleados = new MaterialSkin.Controls.MaterialButton();
            PB_GEmpleados = new PictureBox();
            lbl_nombreUsuario = new Label();
            lbl_welcome = new Label();
            panel_home_admin.SuspendLayout();
            panel_MProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_MProductos).BeginInit();
            panel_facturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_facturas).BeginInit();
            panel_button_GEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_GEmpleados).BeginInit();
            SuspendLayout();
            // 
            // panel_home_admin
            // 
            panel_home_admin.Anchor = AnchorStyles.None;
            panel_home_admin.Controls.Add(button_salir);
            panel_home_admin.Controls.Add(panel_MProductos);
            panel_home_admin.Controls.Add(panel_facturas);
            panel_home_admin.Controls.Add(panel_button_GEmpleados);
            panel_home_admin.Controls.Add(lbl_nombreUsuario);
            panel_home_admin.Controls.Add(lbl_welcome);
            panel_home_admin.Location = new Point(5, -58);
            panel_home_admin.Name = "panel_home_admin";
            panel_home_admin.Size = new Size(1513, 1171);
            panel_home_admin.TabIndex = 0;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(734, 869);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 9;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            // 
            // panel_MProductos
            // 
            panel_MProductos.Anchor = AnchorStyles.None;
            panel_MProductos.Controls.Add(button_maestro_productos);
            panel_MProductos.Controls.Add(PB_MProductos);
            panel_MProductos.Location = new Point(674, 423);
            panel_MProductos.Name = "panel_MProductos";
            panel_MProductos.Size = new Size(205, 191);
            panel_MProductos.TabIndex = 4;
            // 
            // button_maestro_productos
            // 
            button_maestro_productos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_maestro_productos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_maestro_productos.Depth = 0;
            button_maestro_productos.HighEmphasis = true;
            button_maestro_productos.Icon = null;
            button_maestro_productos.Location = new Point(4, 146);
            button_maestro_productos.Margin = new Padding(4, 6, 4, 6);
            button_maestro_productos.MouseState = MaterialSkin.MouseState.HOVER;
            button_maestro_productos.Name = "button_maestro_productos";
            button_maestro_productos.NoAccentTextColor = Color.Empty;
            button_maestro_productos.Size = new Size(200, 36);
            button_maestro_productos.TabIndex = 1;
            button_maestro_productos.Text = "Maestro de productos";
            button_maestro_productos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_maestro_productos.UseAccentColor = false;
            button_maestro_productos.UseVisualStyleBackColor = true;
            // 
            // PB_MProductos
            // 
            PB_MProductos.Image = (Image)resources.GetObject("PB_MProductos.Image");
            PB_MProductos.Location = new Point(40, 3);
            PB_MProductos.Name = "PB_MProductos";
            PB_MProductos.Size = new Size(126, 134);
            PB_MProductos.TabIndex = 0;
            PB_MProductos.TabStop = false;
            // 
            // panel_facturas
            // 
            panel_facturas.Anchor = AnchorStyles.None;
            panel_facturas.Controls.Add(button_facturas);
            panel_facturas.Controls.Add(PB_facturas);
            panel_facturas.Location = new Point(989, 414);
            panel_facturas.Name = "panel_facturas";
            panel_facturas.Size = new Size(205, 191);
            panel_facturas.TabIndex = 3;
            // 
            // button_facturas
            // 
            button_facturas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_facturas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_facturas.Depth = 0;
            button_facturas.HighEmphasis = true;
            button_facturas.Icon = null;
            button_facturas.Location = new Point(57, 146);
            button_facturas.Margin = new Padding(4, 6, 4, 6);
            button_facturas.MouseState = MaterialSkin.MouseState.HOVER;
            button_facturas.Name = "button_facturas";
            button_facturas.NoAccentTextColor = Color.Empty;
            button_facturas.Size = new Size(95, 36);
            button_facturas.TabIndex = 1;
            button_facturas.Text = "Facturas";
            button_facturas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_facturas.UseAccentColor = false;
            button_facturas.UseVisualStyleBackColor = true;
            // 
            // PB_facturas
            // 
            PB_facturas.Image = (Image)resources.GetObject("PB_facturas.Image");
            PB_facturas.Location = new Point(40, 3);
            PB_facturas.Name = "PB_facturas";
            PB_facturas.Size = new Size(126, 134);
            PB_facturas.TabIndex = 0;
            PB_facturas.TabStop = false;
            // 
            // panel_button_GEmpleados
            // 
            panel_button_GEmpleados.Anchor = AnchorStyles.None;
            panel_button_GEmpleados.Controls.Add(button_GEmpleados);
            panel_button_GEmpleados.Controls.Add(PB_GEmpleados);
            panel_button_GEmpleados.Location = new Point(376, 420);
            panel_button_GEmpleados.Name = "panel_button_GEmpleados";
            panel_button_GEmpleados.Size = new Size(205, 191);
            panel_button_GEmpleados.TabIndex = 2;
            // 
            // button_GEmpleados
            // 
            button_GEmpleados.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_GEmpleados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_GEmpleados.Depth = 0;
            button_GEmpleados.HighEmphasis = true;
            button_GEmpleados.Icon = null;
            button_GEmpleados.Location = new Point(4, 146);
            button_GEmpleados.Margin = new Padding(4, 6, 4, 6);
            button_GEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            button_GEmpleados.Name = "button_GEmpleados";
            button_GEmpleados.NoAccentTextColor = Color.Empty;
            button_GEmpleados.Size = new Size(194, 36);
            button_GEmpleados.TabIndex = 1;
            button_GEmpleados.Text = "Gestión de empleados";
            button_GEmpleados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_GEmpleados.UseAccentColor = false;
            button_GEmpleados.UseVisualStyleBackColor = true;
            // 
            // PB_GEmpleados
            // 
            PB_GEmpleados.Image = (Image)resources.GetObject("PB_GEmpleados.Image");
            PB_GEmpleados.Location = new Point(40, 3);
            PB_GEmpleados.Name = "PB_GEmpleados";
            PB_GEmpleados.Size = new Size(126, 134);
            PB_GEmpleados.TabIndex = 0;
            PB_GEmpleados.TabStop = false;
            // 
            // lbl_nombreUsuario
            // 
            lbl_nombreUsuario.Anchor = AnchorStyles.None;
            lbl_nombreUsuario.AutoSize = true;
            lbl_nombreUsuario.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombreUsuario.Location = new Point(748, 149);
            lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            lbl_nombreUsuario.Size = new Size(227, 62);
            lbl_nombreUsuario.TabIndex = 1;
            lbl_nombreUsuario.Text = "__________";
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(468, 149);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(259, 62);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Bienvenido";
            // 
            // Form_Home_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_home_admin);
            Name = "Form_Home_Admin";
            Text = "InkPOS - Home Admin";
            WindowState = FormWindowState.Maximized;
            panel_home_admin.ResumeLayout(false);
            panel_home_admin.PerformLayout();
            panel_MProductos.ResumeLayout(false);
            panel_MProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_MProductos).EndInit();
            panel_facturas.ResumeLayout(false);
            panel_facturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_facturas).EndInit();
            panel_button_GEmpleados.ResumeLayout(false);
            panel_button_GEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_GEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home_admin;
        private Label lbl_nombreUsuario;
        private Label lbl_welcome;
        private Panel panel_button_GEmpleados;
        private MaterialSkin.Controls.MaterialButton button_GEmpleados;
        private PictureBox PB_GEmpleados;
        private Panel panel_facturas;
        private MaterialSkin.Controls.MaterialButton button_facturas;
        private PictureBox PB_facturas;
        private Panel panel_MProductos;
        private MaterialSkin.Controls.MaterialButton button_maestro_productos;
        private PictureBox PB_MProductos;
        private MaterialSkin.Controls.MaterialButton button_salir;
    }
}