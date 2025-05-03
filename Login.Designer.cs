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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            lbl_contraseña = new Label();
            lbl_IDusuario = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            lbl_InkPOS = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lbl_contraseña);
            groupBox1.Controls.Add(lbl_IDusuario);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_InkPOS);
            groupBox1.Location = new Point(21, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1367, 674);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(708, 487);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 7;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(518, 487);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 6;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(567, 385);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(567, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 2;
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
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(617, 572);
            button3.Name = "button3";
            button3.Size = new Size(100, 38);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1416, 721);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "InkPOS - Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label lbl_InkPOS;
        private Label lbl_IDusuario;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lbl_contraseña;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}