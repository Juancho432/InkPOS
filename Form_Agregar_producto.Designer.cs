namespace InkPos
{
    partial class Form_Agregar_producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agregar_producto));
            groupBox1 = new GroupBox();
            txtbox_precio = new TextBox();
            txtbox_cantidad = new TextBox();
            lbl_precio = new Label();
            label3 = new Label();
            lbl_stock = new Label();
            button_salir = new Button();
            button_agregar = new Button();
            button_limpiar = new Button();
            lbl_codigoproducto = new Label();
            lbl_nombreproducto = new Label();
            txtbox_codigoproducto = new TextBox();
            txtbox_nombreproducto = new TextBox();
            lbl_agregarproducto = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtbox_precio);
            groupBox1.Controls.Add(txtbox_cantidad);
            groupBox1.Controls.Add(lbl_precio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_stock);
            groupBox1.Controls.Add(button_salir);
            groupBox1.Controls.Add(button_agregar);
            groupBox1.Controls.Add(button_limpiar);
            groupBox1.Controls.Add(lbl_codigoproducto);
            groupBox1.Controls.Add(lbl_nombreproducto);
            groupBox1.Controls.Add(txtbox_codigoproducto);
            groupBox1.Controls.Add(txtbox_nombreproducto);
            groupBox1.Controls.Add(lbl_agregarproducto);
            groupBox1.Location = new Point(21, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1220, 503);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtbox_precio
            // 
            txtbox_precio.Anchor = AnchorStyles.None;
            txtbox_precio.Location = new Point(592, 308);
            txtbox_precio.Margin = new Padding(3, 2, 3, 2);
            txtbox_precio.Name = "txtbox_precio";
            txtbox_precio.Size = new Size(183, 23);
            txtbox_precio.TabIndex = 13;
            // 
            // txtbox_cantidad
            // 
            txtbox_cantidad.Anchor = AnchorStyles.None;
            txtbox_cantidad.Location = new Point(592, 260);
            txtbox_cantidad.Margin = new Padding(3, 2, 3, 2);
            txtbox_cantidad.Name = "txtbox_cantidad";
            txtbox_cantidad.Size = new Size(183, 23);
            txtbox_cantidad.TabIndex = 12;
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.None;
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_precio.Location = new Point(510, 308);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(56, 19);
            lbl_precio.TabIndex = 11;
            lbl_precio.Text = "Precio:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(491, 260);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 10;
            label3.Text = "Cantidad:";
            // 
            // lbl_stock
            // 
            lbl_stock.Anchor = AnchorStyles.None;
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_stock.Location = new Point(453, 225);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(57, 19);
            lbl_stock.TabIndex = 9;
            lbl_stock.Text = "(Stock)";
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_salir.Location = new Point(485, 423);
            button_salir.Margin = new Padding(3, 2, 3, 2);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(88, 28);
            button_salir.TabIndex = 8;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            // 
            // button_agregar
            // 
            button_agregar.Anchor = AnchorStyles.None;
            button_agregar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_agregar.Location = new Point(878, 199);
            button_agregar.Margin = new Padding(3, 2, 3, 2);
            button_agregar.Name = "button_agregar";
            button_agregar.Size = new Size(141, 54);
            button_agregar.TabIndex = 7;
            button_agregar.Text = "Agregar";
            button_agregar.UseVisualStyleBackColor = true;
            button_agregar.Click += button_agregar_Click;
            // 
            // button_limpiar
            // 
            button_limpiar.Anchor = AnchorStyles.None;
            button_limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_limpiar.Location = new Point(646, 423);
            button_limpiar.Margin = new Padding(3, 2, 3, 2);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(88, 28);
            button_limpiar.TabIndex = 6;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = true;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // lbl_codigoproducto
            // 
            lbl_codigoproducto.Anchor = AnchorStyles.None;
            lbl_codigoproducto.AutoSize = true;
            lbl_codigoproducto.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_codigoproducto.Location = new Point(410, 171);
            lbl_codigoproducto.Name = "lbl_codigoproducto";
            lbl_codigoproducto.Size = new Size(147, 19);
            lbl_codigoproducto.TabIndex = 5;
            lbl_codigoproducto.Text = "Código del producto:";
            // 
            // lbl_nombreproducto
            // 
            lbl_nombreproducto.Anchor = AnchorStyles.None;
            lbl_nombreproducto.AutoSize = true;
            lbl_nombreproducto.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nombreproducto.Location = new Point(403, 134);
            lbl_nombreproducto.Name = "lbl_nombreproducto";
            lbl_nombreproducto.Size = new Size(154, 19);
            lbl_nombreproducto.TabIndex = 4;
            lbl_nombreproducto.Text = "Nombre del producto:";
            // 
            // txtbox_codigoproducto
            // 
            txtbox_codigoproducto.AcceptsReturn = true;
            txtbox_codigoproducto.Anchor = AnchorStyles.None;
            txtbox_codigoproducto.Location = new Point(592, 168);
            txtbox_codigoproducto.Margin = new Padding(3, 2, 3, 2);
            txtbox_codigoproducto.Name = "txtbox_codigoproducto";
            txtbox_codigoproducto.Size = new Size(183, 23);
            txtbox_codigoproducto.TabIndex = 3;
 
            // 
            // txtbox_nombreproducto
            // 
            txtbox_nombreproducto.Anchor = AnchorStyles.None;
            txtbox_nombreproducto.Location = new Point(592, 134);
            txtbox_nombreproducto.Margin = new Padding(3, 2, 3, 2);
            txtbox_nombreproducto.Name = "txtbox_nombreproducto";
            txtbox_nombreproducto.Size = new Size(183, 23);
            txtbox_nombreproducto.TabIndex = 2;
            // 
            // lbl_agregarproducto
            // 
            lbl_agregarproducto.Anchor = AnchorStyles.None;
            lbl_agregarproducto.AutoSize = true;
            lbl_agregarproducto.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_agregarproducto.Location = new Point(430, 34);
            lbl_agregarproducto.Name = "lbl_agregarproducto";
            lbl_agregarproducto.Size = new Size(307, 43);
            lbl_agregarproducto.TabIndex = 1;
            lbl_agregarproducto.Text = "Agregar producto";
            // 
            // agregar_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1267, 541);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "agregar_producto";
            Text = "InkPOS - Agregar producto";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_salir;
        private Button button_agregar;
        private Button button_limpiar;
        private Label lbl_codigoproducto;
        private Label lbl_nombreproducto;
        private TextBox txtbox_codigoproducto;
        private TextBox txtbox_nombreproducto;
        private Label lbl_agregarproducto;
        private TextBox txtbox_precio;
        private TextBox txtbox_cantidad;
        private Label lbl_precio;
        private Label label3;
        private Label lbl_stock;
    }
}