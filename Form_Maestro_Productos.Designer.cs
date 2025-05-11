namespace InkPos
{
    partial class Form_Maestro_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Maestro_Productos));
            panel_maestro_productos = new Panel();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            panel_add = new Panel();
            button_añadir = new MaterialSkin.Controls.MaterialButton();
            PB_add = new PictureBox();
            panel_mod = new Panel();
            button_modificar = new MaterialSkin.Controls.MaterialButton();
            PB_mod = new PictureBox();
            lbl_QRealizar = new Label();
            panel_maestro_productos.SuspendLayout();
            panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_add).BeginInit();
            panel_mod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_mod).BeginInit();
            SuspendLayout();
            // 
            // panel_maestro_productos
            // 
            panel_maestro_productos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_maestro_productos.Controls.Add(button_salir);
            panel_maestro_productos.Controls.Add(panel_add);
            panel_maestro_productos.Controls.Add(panel_mod);
            panel_maestro_productos.Controls.Add(lbl_QRealizar);
            panel_maestro_productos.Location = new Point(5, 2);
            panel_maestro_productos.Name = "panel_maestro_productos";
            panel_maestro_productos.Size = new Size(1513, 1051);
            panel_maestro_productos.TabIndex = 0;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(710, 737);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 12;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // panel_add
            // 
            panel_add.Anchor = AnchorStyles.None;
            panel_add.Controls.Add(button_añadir);
            panel_add.Controls.Add(PB_add);
            panel_add.Location = new Point(482, 257);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(205, 191);
            panel_add.TabIndex = 11;
            // 
            // button_añadir
            // 
            button_añadir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_añadir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_añadir.Depth = 0;
            button_añadir.HighEmphasis = true;
            button_añadir.Icon = null;
            button_añadir.Location = new Point(69, 146);
            button_añadir.Margin = new Padding(4, 6, 4, 6);
            button_añadir.MouseState = MaterialSkin.MouseState.HOVER;
            button_añadir.Name = "button_añadir";
            button_añadir.NoAccentTextColor = Color.Empty;
            button_añadir.Size = new Size(74, 36);
            button_añadir.TabIndex = 1;
            button_añadir.Text = "Añadir";
            button_añadir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_añadir.UseAccentColor = false;
            button_añadir.UseVisualStyleBackColor = true;
            button_añadir.Click += button_añadir_Click;
            // 
            // PB_add
            // 
            PB_add.Image = (Image)resources.GetObject("PB_add.Image");
            PB_add.Location = new Point(40, 3);
            PB_add.Name = "PB_add";
            PB_add.Size = new Size(126, 134);
            PB_add.TabIndex = 0;
            PB_add.TabStop = false;
            // 
            // panel_mod
            // 
            panel_mod.Anchor = AnchorStyles.None;
            panel_mod.Controls.Add(button_modificar);
            panel_mod.Controls.Add(PB_mod);
            panel_mod.Location = new Point(784, 257);
            panel_mod.Name = "panel_mod";
            panel_mod.Size = new Size(205, 191);
            panel_mod.TabIndex = 10;
            // 
            // button_modificar
            // 
            button_modificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_modificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_modificar.Depth = 0;
            button_modificar.HighEmphasis = true;
            button_modificar.Icon = null;
            button_modificar.Location = new Point(57, 146);
            button_modificar.Margin = new Padding(4, 6, 4, 6);
            button_modificar.MouseState = MaterialSkin.MouseState.HOVER;
            button_modificar.Name = "button_modificar";
            button_modificar.NoAccentTextColor = Color.Empty;
            button_modificar.Size = new Size(99, 36);
            button_modificar.TabIndex = 1;
            button_modificar.Text = "Modificar";
            button_modificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_modificar.UseAccentColor = false;
            button_modificar.UseVisualStyleBackColor = true;
            button_modificar.Click += button_modificar_Click;
            // 
            // PB_mod
            // 
            PB_mod.Image = (Image)resources.GetObject("PB_mod.Image");
            PB_mod.Location = new Point(40, 3);
            PB_mod.Name = "PB_mod";
            PB_mod.Size = new Size(126, 134);
            PB_mod.TabIndex = 0;
            PB_mod.TabStop = false;
            // 
            // lbl_QRealizar
            // 
            lbl_QRealizar.Anchor = AnchorStyles.None;
            lbl_QRealizar.AutoSize = true;
            lbl_QRealizar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_QRealizar.Location = new Point(541, 34);
            lbl_QRealizar.Name = "lbl_QRealizar";
            lbl_QRealizar.Size = new Size(385, 54);
            lbl_QRealizar.TabIndex = 0;
            lbl_QRealizar.Text = "¿Qué desea realizar?";
            // 
            // Form_Maestro_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_maestro_productos);
            Name = "Form_Maestro_Productos";
            Text = "InkPOS - Maestro de productos";
            WindowState = FormWindowState.Maximized;
            panel_maestro_productos.ResumeLayout(false);
            panel_maestro_productos.PerformLayout();
            panel_add.ResumeLayout(false);
            panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_add).EndInit();
            panel_mod.ResumeLayout(false);
            panel_mod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_mod).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_maestro_productos;
        private Label lbl_QRealizar;
        private Panel panel_add;
        private MaterialSkin.Controls.MaterialButton button_añadir;
        private PictureBox PB_add;
        private Panel panel_mod;
        private MaterialSkin.Controls.MaterialButton button_modificar;
        private PictureBox PB_mod;
        private MaterialSkin.Controls.MaterialButton button_salir;
    }
}