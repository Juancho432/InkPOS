namespace InkPos
{
    partial class Form_Busqueda_factura
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
            panel1 = new Panel();
            txtbox_ = new MaterialSkin.Controls.MaterialTextBox2();
            lbl_ID_usuario = new Label();
            lbl_login = new Label();
            lbl_busquda_facturas = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtbox_);
            panel1.Controls.Add(lbl_ID_usuario);
            panel1.Controls.Add(lbl_login);
            panel1.Controls.Add(lbl_busquda_facturas);
            panel1.Location = new Point(5, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1513, 1171);
            panel1.TabIndex = 0;
            // 
            // txtbox_
            // 
            txtbox_.Anchor = AnchorStyles.None;
            txtbox_.AnimateReadOnly = false;
            txtbox_.BackgroundImageLayout = ImageLayout.None;
            txtbox_.CharacterCasing = CharacterCasing.Normal;
            txtbox_.Depth = 0;
            txtbox_.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_.HideSelection = true;
            txtbox_.LeadingIcon = null;
            txtbox_.Location = new Point(617, 480);
            txtbox_.MaxLength = 32767;
            txtbox_.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_.Name = "txtbox_";
            txtbox_.PasswordChar = '\0';
            txtbox_.PrefixSuffixText = null;
            txtbox_.ReadOnly = false;
            txtbox_.RightToLeft = RightToLeft.No;
            txtbox_.SelectedText = "";
            txtbox_.SelectionLength = 0;
            txtbox_.SelectionStart = 0;
            txtbox_.ShortcutsEnabled = true;
            txtbox_.Size = new Size(312, 48);
            txtbox_.TabIndex = 7;
            txtbox_.TabStop = false;
            txtbox_.TextAlign = HorizontalAlignment.Left;
            txtbox_.TrailingIcon = null;
            txtbox_.UseSystemPasswordChar = false;
            // 
            // lbl_ID_usuario
            // 
            lbl_ID_usuario.Anchor = AnchorStyles.None;
            lbl_ID_usuario.AutoSize = true;
            lbl_ID_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ID_usuario.ForeColor = SystemColors.ControlText;
            lbl_ID_usuario.Location = new Point(617, 433);
            lbl_ID_usuario.Name = "lbl_ID_usuario";
            lbl_ID_usuario.Size = new Size(104, 28);
            lbl_ID_usuario.TabIndex = 6;
            lbl_ID_usuario.Text = "ID usuario:";
            // 
            // lbl_login
            // 
            lbl_login.Anchor = AnchorStyles.None;
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(690, 316);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(121, 50);
            lbl_login.TabIndex = 5;
            lbl_login.Text = "Login:";
            // 
            // lbl_busquda_facturas
            // 
            lbl_busquda_facturas.Anchor = AnchorStyles.None;
            lbl_busquda_facturas.AutoSize = true;
            lbl_busquda_facturas.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_busquda_facturas.Location = new Point(547, 171);
            lbl_busquda_facturas.Name = "lbl_busquda_facturas";
            lbl_busquda_facturas.Size = new Size(476, 62);
            lbl_busquda_facturas.TabIndex = 4;
            lbl_busquda_facturas.Text = "Búsqueda de facturas";
            // 
            // Form_Busqueda_factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel1);
            Name = "Form_Busqueda_factura";
            Text = "InkPOS - Búsqueda facturas";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_;
        private Label lbl_ID_usuario;
        private Label lbl_login;
        private Label lbl_busquda_facturas;
    }
}