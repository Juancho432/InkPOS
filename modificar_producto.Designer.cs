namespace InkPos
{
    partial class modificar_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificar_producto));
            groupBox1 = new GroupBox();
            box_campomodificar = new ComboBox();
            txtbox_nuevovalor = new TextBox();
            lbl_precio = new Label();
            button_confirmar = new Button();
            button_cancelar = new Button();
            lbl_nuevovalor = new Label();
            lbl_modificarproducto = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(box_campomodificar);
            groupBox1.Controls.Add(txtbox_nuevovalor);
            groupBox1.Controls.Add(lbl_precio);
            groupBox1.Controls.Add(button_confirmar);
            groupBox1.Controls.Add(button_cancelar);
            groupBox1.Controls.Add(lbl_nuevovalor);
            groupBox1.Controls.Add(lbl_modificarproducto);
            groupBox1.Location = new Point(24, 18);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1214, 513);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // box_campomodificar
            // 
            box_campomodificar.Anchor = AnchorStyles.None;
            box_campomodificar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box_campomodificar.FormattingEnabled = true;
            box_campomodificar.Location = new Point(497, 122);
            box_campomodificar.Margin = new Padding(3, 2, 3, 2);
            box_campomodificar.Name = "box_campomodificar";
            box_campomodificar.Size = new Size(237, 27);
            box_campomodificar.TabIndex = 14;
            box_campomodificar.Text = "¿Qué campo desea modificar?";
            // 
            // txtbox_nuevovalor
            // 
            txtbox_nuevovalor.Anchor = AnchorStyles.None;
            txtbox_nuevovalor.Location = new Point(583, 254);
            txtbox_nuevovalor.Margin = new Padding(3, 2, 3, 2);
            txtbox_nuevovalor.Name = "txtbox_nuevovalor";
            txtbox_nuevovalor.Size = new Size(183, 23);
            txtbox_nuevovalor.TabIndex = 13;
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.None;
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_precio.Location = new Point(657, 206);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(0, 19);
            lbl_precio.TabIndex = 11;
            // 
            // button_confirmar
            // 
            button_confirmar.Anchor = AnchorStyles.None;
            button_confirmar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_confirmar.Location = new Point(469, 442);
            button_confirmar.Margin = new Padding(3, 2, 3, 2);
            button_confirmar.Name = "button_confirmar";
            button_confirmar.Size = new Size(102, 28);
            button_confirmar.TabIndex = 8;
            button_confirmar.Text = "Confirmar ";
            button_confirmar.UseVisualStyleBackColor = true;
            button_confirmar.Click += button_confirmar_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.Anchor = AnchorStyles.None;
            button_cancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancelar.Location = new Point(658, 442);
            button_cancelar.Margin = new Padding(3, 2, 3, 2);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(88, 28);
            button_cancelar.TabIndex = 6;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = true;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // lbl_nuevovalor
            // 
            lbl_nuevovalor.Anchor = AnchorStyles.None;
            lbl_nuevovalor.AutoSize = true;
            lbl_nuevovalor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nuevovalor.Location = new Point(379, 254);
            lbl_nuevovalor.Name = "lbl_nuevovalor";
            lbl_nuevovalor.Size = new Size(163, 19);
            lbl_nuevovalor.TabIndex = 4;
            lbl_nuevovalor.Text = "Ingrese el nuevo valor:";
            // 
            // lbl_modificarproducto
            // 
            lbl_modificarproducto.Anchor = AnchorStyles.None;
            lbl_modificarproducto.AutoSize = true;
            lbl_modificarproducto.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_modificarproducto.Location = new Point(430, 26);
            lbl_modificarproducto.Name = "lbl_modificarproducto";
            lbl_modificarproducto.Size = new Size(336, 43);
            lbl_modificarproducto.TabIndex = 1;
            lbl_modificarproducto.Text = "Modificar producto";
            // 
            // modificar_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1256, 540);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "modificar_producto";
            Text = "InkPOS - Maestro de productos";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtbox_nuevovalor;
        private Label lbl_precio;
        private Button button_confirmar;
        private Button button_cancelar;
        private Label lbl_nuevovalor;
        private Label lbl_modificarproducto;
        private ComboBox box_campomodificar;
    }
}