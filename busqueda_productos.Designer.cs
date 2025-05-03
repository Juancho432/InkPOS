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
            txtBuscarProducto = new TextBox();
            btnBuscar = new Button();
            lstResultados = new ListBox();
            dgvDetallesProducto = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvDetallesProducto).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Anchor = AnchorStyles.None;
            txtBuscarProducto.Location = new Point(105, 92);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(233, 27);
            txtBuscarProducto.TabIndex = 0;
            txtBuscarProducto.Text = "(F4) Código/nombre del producto";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Location = new Point(176, 154);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lstResultados
            // 
            lstResultados.Anchor = AnchorStyles.None;
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(105, 220);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(233, 224);
            lstResultados.TabIndex = 2;
            // 
            // dgvDetallesProducto
            // 
            dgvDetallesProducto.Anchor = AnchorStyles.None;
            dgvDetallesProducto.BackgroundColor = SystemColors.ControlLight;
            dgvDetallesProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesProducto.Columns.AddRange(new DataGridViewColumn[] { column_codigo, column_NombreP, column_cantidad, column_valor });
            dgvDetallesProducto.Location = new Point(490, 63);
            dgvDetallesProducto.Name = "dgvDetallesProducto";
            dgvDetallesProducto.RowHeadersWidth = 51;
            dgvDetallesProducto.Size = new Size(853, 396);
            dgvDetallesProducto.TabIndex = 7;
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
            groupBox1.Controls.Add(lstResultados);
            groupBox1.Controls.Add(lbl_valorTotal);
            groupBox1.Controls.Add(button_finalizarVenta);
            groupBox1.Controls.Add(lbl_cantidad_productos);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtbox_valorTotal);
            groupBox1.Controls.Add(txtBuscarProducto);
            groupBox1.Controls.Add(txtbox_cantidadProducto);
            groupBox1.Controls.Add(lbl_detalleVenta);
            groupBox1.Controls.Add(dgvDetallesProducto);
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
            Load += busqueda_productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetallesProducto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBuscarProducto;
        private Button btnBuscar;
        private ListBox lstResultados;
        private DataGridView dgvDetallesProducto;
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