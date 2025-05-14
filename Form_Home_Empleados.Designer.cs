namespace InkPos
{
    partial class Form_Home_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Empleados));
            panel_home_empleado = new Panel();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            panel_ventas = new Panel();
            button_venta = new MaterialSkin.Controls.MaterialButton();
            PB_venta = new PictureBox();
            panel_facturas = new Panel();
            button_facturas = new MaterialSkin.Controls.MaterialButton();
            PB_facturas = new PictureBox();
            lbl_nombreUsuario = new Label();
            lbl_welcome = new Label();
            panel_home_empleado.SuspendLayout();
            panel_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_venta).BeginInit();
            panel_facturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_facturas).BeginInit();
            SuspendLayout();
            // 
            // panel_home_empleado
            // 
            panel_home_empleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_home_empleado.Controls.Add(button_salir);
            panel_home_empleado.Controls.Add(panel_ventas);
            panel_home_empleado.Controls.Add(panel_facturas);
            panel_home_empleado.Controls.Add(lbl_nombreUsuario);
            panel_home_empleado.Controls.Add(lbl_welcome);
            panel_home_empleado.Location = new Point(4, 2);
            panel_home_empleado.Margin = new Padding(3, 2, 3, 2);
            panel_home_empleado.Name = "panel_home_empleado";
            panel_home_empleado.Size = new Size(1324, 878);
            panel_home_empleado.TabIndex = 0;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(594, 634);
            button_salir.Margin = new Padding(4);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 10;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // panel_ventas
            // 
            panel_ventas.Anchor = AnchorStyles.None;
            panel_ventas.Controls.Add(button_venta);
            panel_ventas.Controls.Add(PB_venta);
            panel_ventas.Location = new Point(406, 310);
            panel_ventas.Margin = new Padding(3, 2, 3, 2);
            panel_ventas.Name = "panel_ventas";
            panel_ventas.Size = new Size(179, 143);
            panel_ventas.TabIndex = 9;
            // 
            // button_venta
            // 
            button_venta.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_venta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_venta.Depth = 0;
            button_venta.HighEmphasis = true;
            button_venta.Icon = null;
            button_venta.Location = new Point(60, 110);
            button_venta.Margin = new Padding(4);
            button_venta.MouseState = MaterialSkin.MouseState.HOVER;
            button_venta.Name = "button_venta";
            button_venta.NoAccentTextColor = Color.Empty;
            button_venta.Size = new Size(68, 36);
            button_venta.TabIndex = 1;
            button_venta.Text = "Venta";
            button_venta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_venta.UseAccentColor = false;
            button_venta.UseVisualStyleBackColor = true;
            button_venta.Click += button_venta_Click;
            // 
            // PB_venta
            // 
            PB_venta.Image = (Image)resources.GetObject("PB_venta.Image");
            PB_venta.Location = new Point(35, 2);
            PB_venta.Margin = new Padding(3, 2, 3, 2);
            PB_venta.Name = "PB_venta";
            PB_venta.Size = new Size(110, 100);
            PB_venta.TabIndex = 0;
            PB_venta.TabStop = false;
            // 
            // panel_facturas
            // 
            panel_facturas.Anchor = AnchorStyles.None;
            panel_facturas.Controls.Add(button_facturas);
            panel_facturas.Controls.Add(PB_facturas);
            panel_facturas.Location = new Point(670, 310);
            panel_facturas.Margin = new Padding(3, 2, 3, 2);
            panel_facturas.Name = "panel_facturas";
            panel_facturas.Size = new Size(179, 143);
            panel_facturas.TabIndex = 8;
            // 
            // button_facturas
            // 
            button_facturas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_facturas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_facturas.Depth = 0;
            button_facturas.HighEmphasis = true;
            button_facturas.Icon = null;
            button_facturas.Location = new Point(50, 110);
            button_facturas.Margin = new Padding(4);
            button_facturas.MouseState = MaterialSkin.MouseState.HOVER;
            button_facturas.Name = "button_facturas";
            button_facturas.NoAccentTextColor = Color.Empty;
            button_facturas.Size = new Size(95, 36);
            button_facturas.TabIndex = 1;
            button_facturas.Text = "Facturas";
            button_facturas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_facturas.UseAccentColor = false;
            button_facturas.UseVisualStyleBackColor = true;
            button_facturas.Click += button_facturas_Click;
            // 
            // PB_facturas
            // 
            PB_facturas.Image = (Image)resources.GetObject("PB_facturas.Image");
            PB_facturas.Location = new Point(35, 2);
            PB_facturas.Margin = new Padding(3, 2, 3, 2);
            PB_facturas.Name = "PB_facturas";
            PB_facturas.Size = new Size(110, 100);
            PB_facturas.TabIndex = 0;
            PB_facturas.TabStop = false;
            // 
            // lbl_nombreUsuario
            // 
            lbl_nombreUsuario.Anchor = AnchorStyles.None;
            lbl_nombreUsuario.AutoSize = true;
            lbl_nombreUsuario.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombreUsuario.Location = new Point(651, 137);
            lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            lbl_nombreUsuario.Size = new Size(182, 51);
            lbl_nombreUsuario.TabIndex = 6;
            lbl_nombreUsuario.Text = "__________";
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(406, 137);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(208, 51);
            lbl_welcome.TabIndex = 5;
            lbl_welcome.Text = "Bienvenido";
            // 
            // Form_Home_Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 796);
            Controls.Add(panel_home_empleado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Home_Empleados";
            Text = "InkPOS - Home Empleado";
            WindowState = FormWindowState.Maximized;
            panel_home_empleado.ResumeLayout(false);
            panel_home_empleado.PerformLayout();
            panel_ventas.ResumeLayout(false);
            panel_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_venta).EndInit();
            panel_facturas.ResumeLayout(false);
            panel_facturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_facturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home_empleado;
        private Panel panel_facturas;
        private MaterialSkin.Controls.MaterialButton button_facturas;
        private PictureBox PB_facturas;
        private Label lbl_nombreUsuario;
        private Label lbl_welcome;
        private Panel panel_ventas;
        private MaterialSkin.Controls.MaterialButton button_venta;
        private PictureBox PB_venta;
        private MaterialSkin.Controls.MaterialButton button_salir;
    }
}