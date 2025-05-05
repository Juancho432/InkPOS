namespace InkPos
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            button_salir = new Button();
            button_limpiar = new Button();
            button_ingresar = new Button();
            lbl_contraseña = new Label();
            lbl_IDusuario = new Label();
            txtbox_contraseña = new TextBox();
            txtbox_ID = new TextBox();
            label1 = new Label();
            lbl_InkPOS = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button_salir);
            groupBox1.Controls.Add(button_limpiar);
            groupBox1.Controls.Add(button_ingresar);
            groupBox1.Controls.Add(lbl_contraseña);
            groupBox1.Controls.Add(lbl_IDusuario);
            groupBox1.Controls.Add(txtbox_contraseña);
            groupBox1.Controls.Add(txtbox_ID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_InkPOS);
            groupBox1.Location = new Point(21, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1367, 674);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_salir.Location = new Point(617, 572);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(100, 38);
            button_salir.TabIndex = 8;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpiar.Location = new Point(708, 487);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(100, 38);
            button_limpiar.TabIndex = 7;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button2_Click;
            // 
            // button_ingresar
            // 
            button_ingresar.Anchor = AnchorStyles.None;
            button_ingresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ingresar.Location = new Point(518, 487);
            button_ingresar.Name = "button_ingresar";
            button_ingresar.Size = new Size(100, 38);
            button_ingresar.TabIndex = 6;
            button_ingresar.Text = "Ingresar";
            button_ingresar.UseVisualStyleBackColor = true;
            // 
            // lbl_contraseña
            // 
            lbl_contraseña.Anchor = AnchorStyles.None;
            lbl_contraseña.AutoSize = true;
            lbl_contraseña.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_contraseña.Location = new Point(567, 359);
            lbl_contraseña.Name = "lbl_contraseña";
            lbl_contraseña.Size = new Size(115, 23);
            lbl_contraseña.TabIndex = 5;
            lbl_contraseña.Text = "Contraseña:";
            lbl_contraseña.Click += label2_Click_1;
            // 
            // lbl_IDusuario
            // 
            lbl_IDusuario.Anchor = AnchorStyles.None;
            lbl_IDusuario.AutoSize = true;
            lbl_IDusuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_IDusuario.Location = new Point(567, 282);
            lbl_IDusuario.Name = "lbl_IDusuario";
            lbl_IDusuario.Size = new Size(129, 23);
            lbl_IDusuario.TabIndex = 4;
            lbl_IDusuario.Text = "ID de usuario:";
            lbl_IDusuario.Click += label2_Click;
            // 
            // txtbox_contraseña
            // 
            txtbox_contraseña.Anchor = AnchorStyles.None;
            txtbox_contraseña.Location = new Point(567, 385);
            txtbox_contraseña.Name = "txtbox_contraseña";
            txtbox_contraseña.Size = new Size(209, 27);
            txtbox_contraseña.TabIndex = 3;
            // 
            // txtbox_ID
            // 
            txtbox_ID.Anchor = AnchorStyles.None;
            txtbox_ID.Location = new Point(567, 308);
            txtbox_ID.Name = "txtbox_ID";
            txtbox_ID.Size = new Size(209, 27);
            txtbox_ID.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(600, 185);
            label1.Name = "label1";
            label1.Size = new Size(157, 53);
            label1.TabIndex = 1;
            label1.Text = "Login:";
            // 
            // lbl_InkPOS
            // 
            lbl_InkPOS.Anchor = AnchorStyles.None;
            lbl_InkPOS.AutoSize = true;
            lbl_InkPOS.Font = new Font("Times New Roman", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_InkPOS.Location = new Point(489, 54);
            lbl_InkPOS.Name = "lbl_InkPOS";
            lbl_InkPOS.Size = new Size(393, 114);
            lbl_InkPOS.TabIndex = 0;
            lbl_InkPOS.Text = "InkPOS";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1416, 721);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "InkPOS - Login";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lbl_InkPOS;
        private Label lbl_IDusuario;
        private TextBox txtbox_contraseña;
        private TextBox txtbox_ID;
        private Label lbl_contraseña;
        private Button button_limpiar;
        private Button button_ingresar;
        private Button button_salir;
    }
}