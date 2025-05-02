namespace InkPos
{
    partial class busqueda_productos
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
            f4_search = new TextBox();
            Button_search = new Button();
            coindienci = new ListBox();
            dgvDetalleVenta = new DataGridView();
            column_codigo = new DataGridViewTextBoxColumn();
            column_NombreP = new DataGridViewTextBoxColumn();
            column_cantidad = new DataGridViewTextBoxColumn();
            column_valor = new DataGridViewTextBoxColumn();
            lbl_detalleVenta = new Label();
            txtbox_cantidadProducto = new TextBox();
            txtbox_valorTotal = new TextBox();
            lbl_cantidad_productos = new Label();
            lbl_valorTotal = new Label();
            button_finalizarVenta = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // f4_search
            // 
            f4_search.Anchor = AnchorStyles.None;
            f4_search.Location = new Point(105, 92);
            f4_search.Name = "f4_search";
            f4_search.Size = new Size(233, 27);
            f4_search.TabIndex = 0;
            f4_search.Text = "(F4) Código/nombre del producto";
            // 
            // Button_search
            // 
            Button_search.Anchor = AnchorStyles.None;
            Button_search.Location = new Point(176, 154);
            Button_search.Name = "Button_search";
            Button_search.Size = new Size(94, 29);
            Button_search.TabIndex = 1;
            Button_search.Text = "Buscar";
            Button_search.UseVisualStyleBackColor = true;
            // 
            // coindienci
            // 
            coindienci.Anchor = AnchorStyles.None;
            coindienci.FormattingEnabled = true;
            coindienci.Location = new Point(105, 220);
            coindienci.Name = "coindienci";
            coindienci.Size = new Size(233, 224);
            coindienci.TabIndex = 2;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.Anchor = AnchorStyles.None;
            dgvDetalleVenta.BackgroundColor = SystemColors.ControlLight;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { column_codigo, column_NombreP, column_cantidad, column_valor });
            dgvDetalleVenta.Location = new Point(490, 63);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(853, 396);
            dgvDetalleVenta.TabIndex = 7;
            // 
            // column_codigo
            // 
            column_codigo.HeaderText = "Código";
            column_codigo.MinimumWidth = 6;
            column_codigo.Name = "column_codigo";
            column_codigo.Width = 200;
            // 
            // column_NombreP
            // 
            column_NombreP.HeaderText = "Producto";
            column_NombreP.MinimumWidth = 6;
            column_NombreP.Name = "column_NombreP";
            column_NombreP.Width = 200;
            // 
            // column_cantidad
            // 
            column_cantidad.HeaderText = "Cantidad";
            column_cantidad.MinimumWidth = 6;
            column_cantidad.Name = "column_cantidad";
            column_cantidad.Width = 200;
            // 
            // column_valor
            // 
            column_valor.HeaderText = "Valor";
            column_valor.MinimumWidth = 6;
            column_valor.Name = "column_valor";
            column_valor.Width = 200;
            // 
            // lbl_detalleVenta
            // 
            lbl_detalleVenta.Anchor = AnchorStyles.None;
            lbl_detalleVenta.AutoSize = true;
            lbl_detalleVenta.Location = new Point(490, 40);
            lbl_detalleVenta.Name = "lbl_detalleVenta";
            lbl_detalleVenta.Size = new Size(118, 20);
            lbl_detalleVenta.TabIndex = 8;
            lbl_detalleVenta.Text = "Detalle de venta";
            // 
            // txtbox_cantidadProducto
            // 
            txtbox_cantidadProducto.Anchor = AnchorStyles.None;
            txtbox_cantidadProducto.Location = new Point(703, 506);
            txtbox_cantidadProducto.Name = "txtbox_cantidadProducto";
            txtbox_cantidadProducto.Size = new Size(160, 27);
            txtbox_cantidadProducto.TabIndex = 9;
            txtbox_cantidadProducto.TextChanged += textBox1_TextChanged;
            // 
            // txtbox_valorTotal
            // 
            txtbox_valorTotal.Anchor = AnchorStyles.None;
            txtbox_valorTotal.Location = new Point(930, 506);
            txtbox_valorTotal.Name = "txtbox_valorTotal";
            txtbox_valorTotal.Size = new Size(154, 27);
            txtbox_valorTotal.TabIndex = 10;
            txtbox_valorTotal.TextChanged += txtbox_valorTotal_TextChanged;
            // 
            // lbl_cantidad_productos
            // 
            lbl_cantidad_productos.Anchor = AnchorStyles.None;
            lbl_cantidad_productos.AutoSize = true;
            lbl_cantidad_productos.Location = new Point(703, 483);
            lbl_cantidad_productos.Name = "lbl_cantidad_productos";
            lbl_cantidad_productos.Size = new Size(164, 20);
            lbl_cantidad_productos.TabIndex = 11;
            lbl_cantidad_productos.Text = "Cantidad de productos:";
            // 
            // lbl_valorTotal
            // 
            lbl_valorTotal.Anchor = AnchorStyles.None;
            lbl_valorTotal.AutoSize = true;
            lbl_valorTotal.Location = new Point(930, 483);
            lbl_valorTotal.Name = "lbl_valorTotal";
            lbl_valorTotal.Size = new Size(81, 20);
            lbl_valorTotal.TabIndex = 12;
            lbl_valorTotal.Text = "Valor total:";
            // 
            // button_finalizarVenta
            // 
            button_finalizarVenta.Anchor = AnchorStyles.None;
            button_finalizarVenta.Location = new Point(837, 572);
            button_finalizarVenta.Name = "button_finalizarVenta";
            button_finalizarVenta.Size = new Size(94, 29);
            button_finalizarVenta.TabIndex = 13;
            button_finalizarVenta.Text = "Finalizar venta";
            button_finalizarVenta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(coindienci);
            groupBox1.Controls.Add(lbl_valorTotal);
            groupBox1.Controls.Add(button_finalizarVenta);
            groupBox1.Controls.Add(lbl_cantidad_productos);
            groupBox1.Controls.Add(Button_search);
            groupBox1.Controls.Add(txtbox_valorTotal);
            groupBox1.Controls.Add(f4_search);
            groupBox1.Controls.Add(txtbox_cantidadProducto);
            groupBox1.Controls.Add(lbl_detalleVenta);
            groupBox1.Controls.Add(dgvDetalleVenta);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1387, 617);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // busqueda_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1439, 651);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "busqueda_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InkPos - Venta";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox f4_search;
        private Button Button_search;
        private ListBox coindienci;
        private DataGridView dgvDetalleVenta;
        private Label lbl_detalleVenta;
        private TextBox txtbox_cantidadProducto;
        private TextBox txtbox_valorTotal;
        private Label lbl_cantidad_productos;
        private Label lbl_valorTotal;
        private DataGridViewTextBoxColumn column_codigo;
        private DataGridViewTextBoxColumn column_NombreP;
        private DataGridViewTextBoxColumn column_cantidad;
        private DataGridViewTextBoxColumn column_valor;
        private Button button_finalizarVenta;
        private GroupBox groupBox1;
    }
}