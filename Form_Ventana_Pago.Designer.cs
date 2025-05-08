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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1422, 699);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // button_generarPDF
            // 
            button_generarPDF.Anchor = AnchorStyles.None;
            button_generarPDF.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_generarPDF.Location = new Point(678, 536);
            button_generarPDF.Name = "button_generarPDF";
            button_generarPDF.Size = new Size(144, 38);
            button_generarPDF.TabIndex = 12;
            button_generarPDF.Text = "Generar PDF";
            button_generarPDF.UseVisualStyleBackColor = true;
            button_generarPDF.Click += button_generarPDF_Click;
            // 
            // txtbox_cambio
            // 
            txtbox_cambio.Anchor = AnchorStyles.None;
            txtbox_cambio.Location = new Point(734, 362);
            txtbox_cambio.Multiline = true;
            txtbox_cambio.Name = "txtbox_cambio";
            txtbox_cambio.Size = new Size(260, 50);
            txtbox_cambio.TabIndex = 11;
            // 
            // txtbox_valorRecibido
            // 
            txtbox_valorRecibido.Anchor = AnchorStyles.None;
            txtbox_valorRecibido.Location = new Point(734, 290);
            txtbox_valorRecibido.Multiline = true;
            txtbox_valorRecibido.Name = "txtbox_valorRecibido";
            txtbox_valorRecibido.Size = new Size(260, 50);
            txtbox_valorRecibido.TabIndex = 10;
            // 
            // box_metodopago
            // 
            box_metodopago.FormattingEnabled = true;
            box_metodopago.Location = new Point(655, 215);
            box_metodopago.Name = "box_metodopago";
            box_metodopago.Size = new Size(151, 28);
            box_metodopago.TabIndex = 9;
            box_metodopago.Text = "Método de pago";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1228, 871);
            button3.Name = "button3";
            button3.Size = new Size(100, 38);
            button3.TabIndex = 8;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancelar.Location = new Point(894, 536);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(100, 38);
            button_cancelar.TabIndex = 7;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            // 
            // button_aceptar
            // 
            button_aceptar.Anchor = AnchorStyles.None;
            button_aceptar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_aceptar.Location = new Point(511, 536);
            button_aceptar.Name = "button_aceptar";
            button_aceptar.Size = new Size(100, 38);
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
            lbl_valorRecibido.Location = new Point(456, 298);
            lbl_valorRecibido.Name = "lbl_valorRecibido";
            lbl_valorRecibido.Size = new Size(252, 42);
            lbl_valorRecibido.TabIndex = 5;
            lbl_valorRecibido.Text = "Valor recibido:";
            // 
            // lbl_cambio
            // 
            lbl_cambio.Anchor = AnchorStyles.None;
            lbl_cambio.AutoSize = true;
            lbl_cambio.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cambio.Location = new Point(554, 370);
            lbl_cambio.Name = "lbl_cambio";
            lbl_cambio.Size = new Size(154, 42);
            lbl_cambio.TabIndex = 4;
            lbl_cambio.Text = "Cambio:";
            // 
            // txtbox_valor
            // 
            txtbox_valor.Anchor = AnchorStyles.None;
            txtbox_valor.Location = new Point(678, 83);
            txtbox_valor.Multiline = true;
            txtbox_valor.Name = "txtbox_valor";
            txtbox_valor.Size = new Size(477, 86);
            txtbox_valor.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 266);
            label1.Name = "label1";
            label1.Size = new Size(0, 53);
            label1.TabIndex = 1;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.None;
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Times New Roman", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_valor.Location = new Point(352, 64);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(341, 114);
            lbl_valor.TabIndex = 0;
            lbl_valor.Text = "Valor: ";
            // 
            // Ventana_Pago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1446, 723);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ventana_Pago";
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