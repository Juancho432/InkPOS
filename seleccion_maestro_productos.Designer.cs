namespace InkPos
{
    partial class seleccion_maestro_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seleccion_maestro_productos));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            button_mod = new Guna.UI2.WinForms.Guna2Button();
            button_add = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(461, 123);
            label1.Name = "label1";
            label1.Size = new Size(516, 57);
            label1.TabIndex = 0;
            label1.Text = "¿Qué desea realizar?";
            // 
            // button_mod
            // 
            button_mod.Anchor = AnchorStyles.None;
            button_mod.BorderRadius = 90;
            button_mod.CustomizableEdges = customizableEdges1;
            button_mod.DisabledState.BorderColor = Color.DarkGray;
            button_mod.DisabledState.CustomBorderColor = Color.DarkGray;
            button_mod.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_mod.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_mod.FillColor = Color.Purple;
            button_mod.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_mod.ForeColor = Color.White;
            button_mod.Image = (Image)resources.GetObject("button_mod.Image");
            button_mod.ImageOffset = new Point(20, -10);
            button_mod.ImageSize = new Size(90, 90);
            button_mod.Location = new Point(755, 248);
            button_mod.Name = "button_mod";
            button_mod.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button_mod.Size = new Size(180, 180);
            button_mod.TabIndex = 4;
            button_mod.Text = "Modificar";
            button_mod.TextOffset = new Point(-22, 60);
            button_mod.Click += button_mod_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.None;
            button_add.BorderRadius = 90;
            button_add.CustomizableEdges = customizableEdges3;
            button_add.DisabledState.BorderColor = Color.DarkGray;
            button_add.DisabledState.CustomBorderColor = Color.DarkGray;
            button_add.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_add.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_add.FillColor = Color.Purple;
            button_add.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add.ForeColor = Color.White;
            button_add.Image = (Image)resources.GetObject("button_add.Image");
            button_add.ImageOffset = new Point(17, -10);
            button_add.ImageSize = new Size(90, 90);
            button_add.Location = new Point(514, 248);
            button_add.Name = "button_add";
            button_add.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button_add.Size = new Size(180, 180);
            button_add.TabIndex = 5;
            button_add.Text = "Agregar";
            button_add.TextOffset = new Point(-24, 60);
            button_add.Click += button_add_Click;
            // 
            // seleccion_maestro_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1515, 639);
            Controls.Add(button_add);
            Controls.Add(button_mod);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "seleccion_maestro_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InkPOS - Maestro de productos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        Form menuPrincipal;

        public seleccion_maestro_productos(Form menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
        }


        private Label label1;
        private Guna.UI2.WinForms.Guna2Button button_mod;
        private Guna.UI2.WinForms.Guna2Button button_add;
    }
}