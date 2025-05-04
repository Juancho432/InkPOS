namespace InkPos
{
    partial class busqueda_factura
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(busqueda_factura));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            lbl_busqueda_factura = new Label();
            txtbox_num_factura = new Guna.UI2.WinForms.Guna2TextBox();
            txtbox_resultado_factura = new TextBox();
            linkLabel_ver = new LinkLabel();
            button_imprimir = new Button();
            button_salir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_salir);
            groupBox1.Controls.Add(button_imprimir);
            groupBox1.Controls.Add(linkLabel_ver);
            groupBox1.Controls.Add(txtbox_num_factura);
            groupBox1.Controls.Add(txtbox_resultado_factura);
            groupBox1.Controls.Add(lbl_busqueda_factura);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1499, 711);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lbl_busqueda_factura
            // 
            lbl_busqueda_factura.Anchor = AnchorStyles.None;
            lbl_busqueda_factura.AutoSize = true;
            lbl_busqueda_factura.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_busqueda_factura.Location = new Point(487, 79);
            lbl_busqueda_factura.Name = "lbl_busqueda_factura";
            lbl_busqueda_factura.Size = new Size(456, 48);
            lbl_busqueda_factura.TabIndex = 0;
            lbl_busqueda_factura.Text = "Búsqueda de facturas";
            // 
            // txtbox_num_factura
            // 
            txtbox_num_factura.Anchor = AnchorStyles.None;
            txtbox_num_factura.BorderRadius = 20;
            txtbox_num_factura.CustomizableEdges = customizableEdges3;
            txtbox_num_factura.DefaultText = "";
            txtbox_num_factura.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtbox_num_factura.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtbox_num_factura.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtbox_num_factura.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtbox_num_factura.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_num_factura.Font = new Font("Segoe UI", 9F);
            txtbox_num_factura.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtbox_num_factura.IconRight = (Image)resources.GetObject("txtbox_num_factura.IconRight");
            txtbox_num_factura.IconRightSize = new Size(24, 24);
            txtbox_num_factura.Location = new Point(591, 185);
            txtbox_num_factura.Margin = new Padding(3, 4, 3, 4);
            txtbox_num_factura.Name = "txtbox_num_factura";
            txtbox_num_factura.PlaceholderText = "Ingrese en N° de factura";
            txtbox_num_factura.SelectedText = "";
            txtbox_num_factura.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtbox_num_factura.Size = new Size(237, 60);
            txtbox_num_factura.TabIndex = 2;
            // 
            // txtbox_resultado_factura
            // 
            txtbox_resultado_factura.Anchor = AnchorStyles.None;
            txtbox_resultado_factura.Location = new Point(487, 350);
            txtbox_resultado_factura.Multiline = true;
            txtbox_resultado_factura.Name = "txtbox_resultado_factura";
            txtbox_resultado_factura.PlaceholderText = "0000";
            txtbox_resultado_factura.Size = new Size(176, 46);
            txtbox_resultado_factura.TabIndex = 1;
            // 
            // linkLabel_ver
            // 
            linkLabel_ver.Anchor = AnchorStyles.None;
            linkLabel_ver.AutoSize = true;
            linkLabel_ver.Location = new Point(727, 359);
            linkLabel_ver.Name = "linkLabel_ver";
            linkLabel_ver.Size = new Size(49, 31);
            linkLabel_ver.TabIndex = 3;
            linkLabel_ver.TabStop = true;
            linkLabel_ver.Text = "Ver";
            // 
            // button_imprimir
            // 
            button_imprimir.Anchor = AnchorStyles.None;
            button_imprimir.Image = (Image)resources.GetObject("button_imprimir.Image");
            button_imprimir.Location = new Point(836, 350);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new Size(69, 48);
            button_imprimir.TabIndex = 4;
            button_imprimir.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_salir.Location = new Point(669, 599);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(94, 44);
            button_salir.TabIndex = 17;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            // 
            // busqueda_factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1523, 735);
            Controls.Add(groupBox1);
            Name = "busqueda_factura";
            Text = "InkPOS - Búsquda de facturas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_busqueda_factura;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_num_factura;
        private TextBox txtbox_resultado_factura;
        private LinkLabel linkLabel_ver;
        private Button button_imprimir;
        private Button button_salir;
    }
}