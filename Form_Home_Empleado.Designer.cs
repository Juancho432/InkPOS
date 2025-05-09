namespace InkPos
{
    partial class Form_Home_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Empleado));
            panel_home_empleado = new Panel();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            panel_MProductos = new Panel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            PB_Venta = new PictureBox();
            panel_facturas = new Panel();
            button_facturas = new MaterialSkin.Controls.MaterialButton();
            PB_facturas = new PictureBox();
            lbl_nombreEmpleado = new Label();
            lbl_welcome = new Label();
            panel_home_empleado.SuspendLayout();
            panel_MProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Venta).BeginInit();
            panel_facturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_facturas).BeginInit();
            SuspendLayout();
            // 
            // panel_home_empleado
            // 
            panel_home_empleado.Controls.Add(button_salir);
            panel_home_empleado.Controls.Add(panel_MProductos);
            panel_home_empleado.Controls.Add(panel_facturas);
            panel_home_empleado.Controls.Add(lbl_nombreEmpleado);
            panel_home_empleado.Controls.Add(lbl_welcome);
            panel_home_empleado.Location = new Point(5, 2);
            panel_home_empleado.Name = "panel_home_empleado";
            panel_home_empleado.Size = new Size(1513, 1171);
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
            button_salir.Location = new Point(705, 927);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 15;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            // 
            // panel_MProductos
            // 
            panel_MProductos.Anchor = AnchorStyles.None;
            panel_MProductos.Controls.Add(materialButton1);
            panel_MProductos.Controls.Add(PB_Venta);
            panel_MProductos.Location = new Point(478, 434);
            panel_MProductos.Name = "panel_MProductos";
            panel_MProductos.Size = new Size(205, 191);
            panel_MProductos.TabIndex = 14;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(71, 146);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(68, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Venta";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // PB_Venta
            // 
            PB_Venta.Image = (Image)resources.GetObject("PB_Venta.Image");
            PB_Venta.Location = new Point(40, 3);
            PB_Venta.Name = "PB_Venta";
            PB_Venta.Size = new Size(126, 134);
            PB_Venta.TabIndex = 0;
            PB_Venta.TabStop = false;
            // 
            // panel_facturas
            // 
            panel_facturas.Anchor = AnchorStyles.None;
            panel_facturas.Controls.Add(button_facturas);
            panel_facturas.Controls.Add(PB_facturas);
            panel_facturas.Location = new Point(949, 437);
            panel_facturas.Name = "panel_facturas";
            panel_facturas.Size = new Size(205, 191);
            panel_facturas.TabIndex = 13;
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
            // lbl_nombreEmpleado
            // 
            lbl_nombreEmpleado.Anchor = AnchorStyles.None;
            lbl_nombreEmpleado.AutoSize = true;
            lbl_nombreEmpleado.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombreEmpleado.Location = new Point(719, 207);
            lbl_nombreEmpleado.Name = "lbl_nombreEmpleado";
            lbl_nombreEmpleado.Size = new Size(227, 62);
            lbl_nombreEmpleado.TabIndex = 11;
            lbl_nombreEmpleado.Text = "__________";
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(439, 207);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(259, 62);
            lbl_welcome.TabIndex = 10;
            lbl_welcome.Text = "Bienvenido";
            // 
            // Form_Home_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_home_empleado);
            Name = "Form_Home_Empleado";
            Text = "InkPOS - Home Empleado";
            WindowState = FormWindowState.Maximized;
            panel_home_empleado.ResumeLayout(false);
            panel_home_empleado.PerformLayout();
            panel_MProductos.ResumeLayout(false);
            panel_MProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Venta).EndInit();
            panel_facturas.ResumeLayout(false);
            panel_facturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_facturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_home_empleado;
        private MaterialSkin.Controls.MaterialButton button_salir;
        private Panel panel_MProductos;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox PB_Venta;
        private Panel panel_facturas;
        private MaterialSkin.Controls.MaterialButton button_facturas;
        private PictureBox PB_facturas;
        private Label lbl_nombreEmpleado;
        private Label lbl_welcome;
    }
}