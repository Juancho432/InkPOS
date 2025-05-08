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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Empleado));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            button_facturas = new Guna.UI2.WinForms.Guna2Button();
            button_venta = new Guna.UI2.WinForms.Guna2Button();
            lbl_nombre_empleado = new Label();
            lbl_welcome = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button_facturas);
            groupBox1.Controls.Add(button_venta);
            groupBox1.Controls.Add(lbl_nombre_empleado);
            groupBox1.Controls.Add(lbl_welcome);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1315, 481);
            groupBox1.TabIndex = 1;
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
            button_facturas.Location = new Point(684, 173);
            button_facturas.Margin = new Padding(3, 2, 3, 2);
            button_facturas.Name = "button_facturas";
            button_facturas.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button_facturas.Size = new Size(158, 135);
            button_facturas.TabIndex = 5;
            button_facturas.Text = "Facturas";
            button_facturas.TextOffset = new Point(-22, 60);
            // 
            // button_venta
            // 
            button_venta.Anchor = AnchorStyles.None;
            button_venta.BorderRadius = 90;
            button_venta.CustomizableEdges = customizableEdges3;
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
            button_venta.Location = new Point(446, 173);
            button_venta.Margin = new Padding(3, 2, 3, 2);
            button_venta.Name = "button_venta";
            button_venta.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button_venta.Size = new Size(158, 135);
            button_venta.TabIndex = 2;
            button_venta.Text = "Venta";
            button_venta.TextOffset = new Point(-22, 60);
            button_venta.Click += button_venta_Click;
            // 
            // lbl_nombre_empleado
            // 
            lbl_nombre_empleado.Anchor = AnchorStyles.None;
            lbl_nombre_empleado.AutoSize = true;
            lbl_nombre_empleado.Font = new Font("Tahoma", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_nombre_empleado.Location = new Point(637, 17);
            lbl_nombre_empleado.Name = "lbl_nombre_empleado";
            lbl_nombre_empleado.Size = new Size(260, 46);
            lbl_nombre_empleado.TabIndex = 1;
            lbl_nombre_empleado.Text = "__________";
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Tahoma", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(381, 17);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(231, 46);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Bienvenido";
            // 
            // Form_Home_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1336, 500);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Home_Empleado";
            Text = "InkPOS - Menú de inicio";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button button_facturas;
        private Guna.UI2.WinForms.Guna2Button button_venta;
        private Label lbl_nombre_empleado;
        private Label lbl_welcome;
    }
}