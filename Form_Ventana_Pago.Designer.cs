namespace InkPos
{
    partial class Form_Ventana_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ventana_Pago));
            groupBox1 = new GroupBox();
            button_generarPDF = new Button();
            txtbox_cambio = new TextBox();
            txtbox_valorRecibido = new TextBox();
            box_metodopago = new ComboBox();
            button3 = new Button();
            button_cancelar = new Button();
            button_aceptar = new Button();
            lbl_valorRecibido = new Label();
            lbl_cambio = new Label();
            txtbox_valor = new TextBox();
            label1 = new Label();
            lbl_valor = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button_generarPDF);
            groupBox1.Controls.Add(txtbox_cambio);
            groupBox1.Controls.Add(txtbox_valorRecibido);
            groupBox1.Controls.Add(box_metodopago);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button_cancelar);
            groupBox1.Controls.Add(button_aceptar);
            groupBox1.Controls.Add(lbl_valorRecibido);
            groupBox1.Controls.Add(lbl_cambio);
            groupBox1.Controls.Add(txtbox_valor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lbl_valor);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1244, 524);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button_generarPDF
            // 
            button_generarPDF.Anchor = AnchorStyles.None;
            button_generarPDF.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_generarPDF.Location = new Point(593, 402);
            button_generarPDF.Margin = new Padding(3, 2, 3, 2);
            button_generarPDF.Name = "button_generarPDF";
            button_generarPDF.Size = new Size(126, 28);
            button_generarPDF.TabIndex = 12;
            button_generarPDF.Text = "Generar PDF";
            button_generarPDF.UseVisualStyleBackColor = true;
            button_generarPDF.Click += button_generarPDF_Click;
            // 
            // txtbox_cambio
            // 
            txtbox_cambio.Anchor = AnchorStyles.None;
            txtbox_cambio.Location = new Point(642, 272);
            txtbox_cambio.Margin = new Padding(3, 2, 3, 2);
            txtbox_cambio.Multiline = true;
            txtbox_cambio.Name = "txtbox_cambio";
            txtbox_cambio.Size = new Size(228, 38);
            txtbox_cambio.TabIndex = 11;
            txtbox_cambio.TextChanged += txtbox_cambio_TextChanged;
            // 
            // txtbox_valorRecibido
            // 
            txtbox_valorRecibido.Anchor = AnchorStyles.None;
            txtbox_valorRecibido.Location = new Point(642, 218);
            txtbox_valorRecibido.Margin = new Padding(3, 2, 3, 2);
            txtbox_valorRecibido.Multiline = true;
            txtbox_valorRecibido.Name = "txtbox_valorRecibido";
            txtbox_valorRecibido.Size = new Size(228, 38);
            txtbox_valorRecibido.TabIndex = 10;
            txtbox_valorRecibido.TextChanged += txtbox_valorRecibido_TextChanged;
            // 
            // box_metodopago
            // 
            box_metodopago.FormattingEnabled = true;
            box_metodopago.Location = new Point(573, 161);
            box_metodopago.Margin = new Padding(3, 2, 3, 2);
            box_metodopago.Name = "box_metodopago";
            box_metodopago.Size = new Size(133, 23);
            box_metodopago.TabIndex = 9;
            box_metodopago.Text = "Método de pago";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1074, 653);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(88, 28);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancelar.Location = new Point(782, 402);
            button_cancelar.Margin = new Padding(3, 2, 3, 2);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(88, 28);
            button_cancelar.TabIndex = 7;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // button_aceptar
            // 
            button_aceptar.Anchor = AnchorStyles.None;
            button_aceptar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_aceptar.Location = new Point(447, 402);
            button_aceptar.Margin = new Padding(3, 2, 3, 2);
            button_aceptar.Name = "button_aceptar";
            button_aceptar.Size = new Size(88, 28);
            button_aceptar.TabIndex = 6;
            button_aceptar.Text = "Aceptar";
            button_aceptar.UseVisualStyleBackColor = true;
            button_aceptar.Click += button_aceptar_Click;
            // 
            // lbl_valorRecibido
            // 
            lbl_valorRecibido.Anchor = AnchorStyles.None;
            lbl_valorRecibido.AutoSize = true;
            lbl_valorRecibido.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valorRecibido.Location = new Point(399, 224);
            lbl_valorRecibido.Name = "lbl_valorRecibido";
            lbl_valorRecibido.Size = new Size(201, 35);
            lbl_valorRecibido.TabIndex = 5;
            lbl_valorRecibido.Text = "Valor recibido:";
            // 
            // lbl_cambio
            // 
            lbl_cambio.Anchor = AnchorStyles.None;
            lbl_cambio.AutoSize = true;
            lbl_cambio.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cambio.Location = new Point(485, 278);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(125, 35);
            lbl_cambio.TabIndex = 4;
            lbl_cambio.Text = "Cambio:";
            // 
            // txtbox_valor
            // 
            txtbox_valor.Anchor = AnchorStyles.None;
            txtbox_valor.Location = new Point(593, 62);
            txtbox_valor.Margin = new Padding(3, 2, 3, 2);
            txtbox_valor.Multiline = true;
            txtbox_valor.Name = "txtbox_valor";
            txtbox_valor.Size = new Size(418, 66);
            txtbox_valor.TabIndex = 3;
            txtbox_valor.TextChanged += txtbox_valor_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 200);
            label1.Name = "label1";
            label1.Size = new Size(0, 43);
            label1.TabIndex = 1;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.None;
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Times New Roman", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valor.Location = new Point(308, 48);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(274, 90);
            lbl_valor.TabIndex = 0;
            lbl_valor.Text = "Valor: ";
            // 
            // Form_Ventana_Pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1265, 542);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Ventana_Pago";
            Text = "InkPOS - Pago";
            WindowState = FormWindowState.Maximized;
            Load += Ventana_Pago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button_cancelar;
        private Button button_aceptar;
        private Label lbl_valorRecibido;
        private Label lbl_cambio;
        private TextBox txtbox_valor;
        private Label label1;
        private Label lbl_valor;
        private ComboBox box_metodopago;
        private TextBox txtbox_valorRecibido;
        private Button button_generarPDF;
        private TextBox txtbox_cambio;
    }
}