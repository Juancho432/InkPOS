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
            lbl_welcome = new Label();
            lbl_nombre_empleado = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.Anchor = AnchorStyles.None;
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Tahoma", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_welcome.Location = new Point(432, 98);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(287, 57);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "Bienvenido";
            // 
            // lbl_nombre_empleado
            // 
            lbl_nombre_empleado.Anchor = AnchorStyles.None;
            lbl_nombre_empleado.AutoSize = true;
            lbl_nombre_empleado.Font = new Font("Tahoma", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_nombre_empleado.Location = new Point(725, 98);
            lbl_nombre_empleado.Name = "lbl_nombre_empleado";
            lbl_nombre_empleado.Size = new Size(325, 57);
            lbl_nombre_empleado.TabIndex = 1;
            lbl_nombre_empleado.Text = "__________";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lbl_nombre_empleado);
            groupBox1.Controls.Add(lbl_welcome);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1608, 740);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Form_Home_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1527, 735);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Home_Admin";
            Text = "InkPos - Menú de inicio";
            WindowState = FormWindowState.Maximized;
            Load += Form_Home_Admin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_welcome;
        private Label lbl_nombre_empleado;
        private GroupBox groupBox1;
    }
}