namespace InkPos
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            panel_login = new Panel();
            PB_ocultar = new PictureBox();
            PB_ver = new PictureBox();
            button_salir = new MaterialSkin.Controls.MaterialButton();
            button_limpiar = new MaterialSkin.Controls.MaterialButton();
            button_ingresar = new MaterialSkin.Controls.MaterialButton();
            txtbox_contraseña = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_password = new Label();
            txtbox_ID_usuario = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_ID_usuario = new Label();
            lbl_login = new Label();
            lbl_InkPOS = new Label();
            panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_ocultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_ver).BeginInit();
            SuspendLayout();
            // 
            // panel_login
            // 
            panel_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_login.Controls.Add(PB_ocultar);
            panel_login.Controls.Add(PB_ver);
            panel_login.Controls.Add(button_salir);
            panel_login.Controls.Add(button_limpiar);
            panel_login.Controls.Add(button_ingresar);
            panel_login.Controls.Add(txtbox_contraseña);
            panel_login.Controls.Add(lbl_password);
            panel_login.Controls.Add(txtbox_ID_usuario);
            panel_login.Controls.Add(lbl_ID_usuario);
            panel_login.Controls.Add(lbl_login);
            panel_login.Controls.Add(lbl_InkPOS);
            panel_login.Location = new Point(5, 2);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(1513, 1051);
            panel_login.TabIndex = 0;
            // 
            // PB_ocultar
            // 
            PB_ocultar.Anchor = AnchorStyles.None;
            PB_ocultar.Cursor = Cursors.Hand;
            PB_ocultar.Image = (Image)resources.GetObject("PB_ocultar.Image");
            PB_ocultar.Location = new Point(959, 573);
            PB_ocultar.Name = "PB_ocultar";
            PB_ocultar.Size = new Size(51, 48);
            PB_ocultar.TabIndex = 10;
            PB_ocultar.TabStop = false;
            // 
            // PB_ver
            // 
            PB_ver.Anchor = AnchorStyles.None;
            PB_ver.Cursor = Cursors.Hand;
            PB_ver.Image = (Image)resources.GetObject("PB_ver.Image");
            PB_ver.Location = new Point(959, 573);
            PB_ver.Name = "PB_ver";
            PB_ver.Size = new Size(51, 48);
            PB_ver.TabIndex = 9;
            PB_ver.TabStop = false;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_salir.Depth = 0;
            button_salir.HighEmphasis = true;
            button_salir.Icon = null;
            button_salir.Location = new Point(781, 882);
            button_salir.Margin = new Padding(4, 6, 4, 6);
            button_salir.MouseState = MaterialSkin.MouseState.HOVER;
            button_salir.Name = "button_salir";
            button_salir.NoAccentTextColor = Color.Empty;
            button_salir.Size = new Size(64, 36);
            button_salir.TabIndex = 8;
            button_salir.Text = "SALIR";
            button_salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_salir.UseAccentColor = false;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += Boton_Salir_click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_limpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_limpiar.Depth = 0;
            button_limpiar.HighEmphasis = true;
            button_limpiar.Icon = null;
            button_limpiar.Location = new Point(874, 791);
            button_limpiar.Margin = new Padding(4, 6, 4, 6);
            button_limpiar.MouseState = MaterialSkin.MouseState.HOVER;
            button_limpiar.Name = "button_limpiar";
            button_limpiar.NoAccentTextColor = Color.Empty;
            button_limpiar.Size = new Size(79, 36);
            button_limpiar.TabIndex = 7;
            button_limpiar.Text = "LIMPIAR";
            button_limpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_limpiar.UseAccentColor = false;
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += Boton_Limpiar_Click;
            // 
            // button_ingresar
            // 
            button_ingresar.Anchor = AnchorStyles.None;
            button_ingresar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_ingresar.Depth = 0;
            button_ingresar.HighEmphasis = true;
            button_ingresar.Icon = null;
            button_ingresar.Location = new Point(641, 791);
            button_ingresar.Margin = new Padding(4, 6, 4, 6);
            button_ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            button_ingresar.Name = "button_ingresar";
            button_ingresar.NoAccentTextColor = Color.Empty;
            button_ingresar.Size = new Size(91, 36);
            button_ingresar.TabIndex = 6;
            button_ingresar.Text = "INGRESAR";
            button_ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            button_ingresar.UseAccentColor = false;
            button_ingresar.UseVisualStyleBackColor = true;
            button_ingresar.Click += Boton_Ingresar_Click;
            // 
            // txtbox_contraseña
            // 
            txtbox_contraseña.Anchor = AnchorStyles.None;
            txtbox_contraseña.AnimateReadOnly = false;
            txtbox_contraseña.BackgroundImageLayout = ImageLayout.None;
            txtbox_contraseña.CharacterCasing = CharacterCasing.Normal;
            txtbox_contraseña.Depth = 0;
            txtbox_contraseña.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_contraseña.HideSelection = true;
            txtbox_contraseña.LeadingIcon = null;
            txtbox_contraseña.Location = new Point(641, 573);
            txtbox_contraseña.MaxLength = 32767;
            txtbox_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_contraseña.Name = "txtbox_contraseña";
            txtbox_contraseña.PasswordChar = '*';
            txtbox_contraseña.PrefixSuffixText = null;
            txtbox_contraseña.ReadOnly = false;
            txtbox_contraseña.RightToLeft = RightToLeft.No;
            txtbox_contraseña.SelectedText = "";
            txtbox_contraseña.SelectionLength = 0;
            txtbox_contraseña.SelectionStart = 0;
            txtbox_contraseña.ShortcutsEnabled = true;
            txtbox_contraseña.Size = new Size(312, 48);
            txtbox_contraseña.TabIndex = 5;
            txtbox_contraseña.TabStop = false;
            txtbox_contraseña.TextAlign = HorizontalAlignment.Left;
            txtbox_contraseña.TrailingIcon = null;
            txtbox_contraseña.UseSystemPasswordChar = false;
            // 
            // lbl_password
            // 
            lbl_password.Anchor = AnchorStyles.None;
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.ForeColor = SystemColors.ControlText;
            lbl_password.Location = new Point(641, 505);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(114, 28);
            lbl_password.TabIndex = 4;
            lbl_password.Tag = "";
            lbl_password.Text = "Contraseña:";
            // 
            // txtbox_ID_usuario
            // 
            txtbox_ID_usuario.Anchor = AnchorStyles.None;
            txtbox_ID_usuario.AnimateReadOnly = false;
            txtbox_ID_usuario.BackgroundImageLayout = ImageLayout.None;
            txtbox_ID_usuario.CharacterCasing = CharacterCasing.Normal;
            txtbox_ID_usuario.Depth = 0;
            txtbox_ID_usuario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_ID_usuario.HideSelection = true;
            txtbox_ID_usuario.LeadingIcon = null;
            txtbox_ID_usuario.Location = new Point(641, 400);
            txtbox_ID_usuario.MaxLength = 32767;
            txtbox_ID_usuario.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_ID_usuario.Name = "txtbox_ID_usuario";
            txtbox_ID_usuario.PasswordChar = '\0';
            txtbox_ID_usuario.PrefixSuffixText = null;
            txtbox_ID_usuario.ReadOnly = false;
            txtbox_ID_usuario.RightToLeft = RightToLeft.No;
            txtbox_ID_usuario.SelectedText = "";
            txtbox_ID_usuario.SelectionLength = 0;
            txtbox_ID_usuario.SelectionStart = 0;
            txtbox_ID_usuario.ShortcutsEnabled = true;
            txtbox_ID_usuario.Size = new Size(312, 48);
            txtbox_ID_usuario.TabIndex = 3;
            txtbox_ID_usuario.TabStop = false;
            txtbox_ID_usuario.TextAlign = HorizontalAlignment.Left;
            txtbox_ID_usuario.TrailingIcon = null;
            txtbox_ID_usuario.UseSystemPasswordChar = false;
            // 
            // lbl_ID_usuario
            // 
            lbl_ID_usuario.Anchor = AnchorStyles.None;
            lbl_ID_usuario.AutoSize = true;
            lbl_ID_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ID_usuario.ForeColor = SystemColors.ControlText;
            lbl_ID_usuario.Location = new Point(641, 353);
            lbl_ID_usuario.Name = "lbl_ID_usuario";
            lbl_ID_usuario.Size = new Size(104, 28);
            lbl_ID_usuario.TabIndex = 2;
            lbl_ID_usuario.Text = "ID usuario:";
            // 
            // lbl_login
            // 
            lbl_login.Anchor = AnchorStyles.None;
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(714, 236);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(121, 50);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "Login:";
            // 
            // lbl_InkPOS
            // 
            lbl_InkPOS.Anchor = AnchorStyles.None;
            lbl_InkPOS.AutoSize = true;
            lbl_InkPOS.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_InkPOS.Location = new Point(689, 94);
            lbl_InkPOS.Name = "lbl_InkPOS";
            lbl_InkPOS.Size = new Size(176, 62);
            lbl_InkPOS.TabIndex = 0;
            lbl_InkPOS.Text = "InkPOS";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1055);
            Controls.Add(panel_login);
            Name = "Form_Login";
            Text = "InkPOS - Login";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form_Login_FormClosed;
            panel_login.ResumeLayout(false);
            panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_ocultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_ver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_login;
        private Label lbl_InkPOS;
        private Label lbl_login;
        private MaterialSkin.Controls.MaterialButton button_ingresar;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_contraseña;
        private Label lbl_password;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_ID_usuario;
        private Label lbl_ID_usuario;
        private MaterialSkin.Controls.MaterialButton button_limpiar;
        private MaterialSkin.Controls.MaterialButton button_salir;
        private PictureBox PB_ocultar;
        private PictureBox PB_ver;
    }
}