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
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // f4_search
            // 
            f4_search.Location = new Point(141, 89);
            f4_search.Name = "f4_search";
            f4_search.Size = new Size(233, 27);
            f4_search.TabIndex = 0;
            f4_search.Text = "(F4) Código/nombre del producto";
            // 
            // Button_search
            // 
            Button_search.Location = new Point(207, 172);
            Button_search.Name = "Button_search";
            Button_search.Size = new Size(94, 29);
            Button_search.TabIndex = 1;
            Button_search.Text = "Buscar";
            Button_search.UseVisualStyleBackColor = true;
            // 
            // coindienci
            // 
            coindienci.FormattingEnabled = true;
            coindienci.Location = new Point(141, 240);
            coindienci.Name = "coindienci";
            coindienci.Size = new Size(233, 224);
            coindienci.TabIndex = 2;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.BackgroundColor = SystemColors.ControlLight;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { column_codigo, column_NombreP, column_cantidad, column_valor });
            dgvDetalleVenta.Location = new Point(665, 153);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(556, 318);
            dgvDetalleVenta.TabIndex = 7;
            // 
            // column_codigo
            // 
            column_codigo.HeaderText = "Código";
            column_codigo.MinimumWidth = 6;
            column_codigo.Name = "column_codigo";
            column_codigo.Width = 125;
            // 
            // column_NombreP
            // 
            column_NombreP.HeaderText = "Producto";
            column_NombreP.MinimumWidth = 6;
            column_NombreP.Name = "column_NombreP";
            column_NombreP.Width = 125;
            // 
            // column_cantidad
            // 
            column_cantidad.HeaderText = "Cantidad";
            column_cantidad.MinimumWidth = 6;
            column_cantidad.Name = "column_cantidad";
            column_cantidad.Width = 125;
            // 
            // column_valor
            // 
            column_valor.HeaderText = "Valor";
            column_valor.MinimumWidth = 6;
            column_valor.Name = "column_valor";
            column_valor.Width = 125;
            // 
            // lbl_detalleVenta
            // 
            lbl_detalleVenta.AutoSize = true;
            lbl_detalleVenta.Location = new Point(680, 118);
            lbl_detalleVenta.Name = "lbl_detalleVenta";
            lbl_detalleVenta.Size = new Size(118, 20);
            lbl_detalleVenta.TabIndex = 8;
            lbl_detalleVenta.Text = "Detalle de venta";
            // 
            // txtbox_cantidadProducto
            // 
            txtbox_cantidadProducto.Location = new Point(733, 501);
            txtbox_cantidadProducto.Name = "txtbox_cantidadProducto";
            txtbox_cantidadProducto.Size = new Size(160, 27);
            txtbox_cantidadProducto.TabIndex = 9;
            txtbox_cantidadProducto.Text = "Cantidad de productos";
            txtbox_cantidadProducto.TextChanged += textBox1_TextChanged;
            // 
            // txtbox_valorTotal
            // 
            txtbox_valorTotal.Location = new Point(983, 501);
            txtbox_valorTotal.Name = "txtbox_valorTotal";
            txtbox_valorTotal.Size = new Size(154, 27);
            txtbox_valorTotal.TabIndex = 10;
            txtbox_valorTotal.Text = "Valor total";
            // 
            // busqueda_productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 623);
            Controls.Add(txtbox_valorTotal);
            Controls.Add(txtbox_cantidadProducto);
            Controls.Add(lbl_detalleVenta);
            Controls.Add(coindienci);
            Controls.Add(Button_search);
            Controls.Add(f4_search);
            Controls.Add(dgvDetalleVenta);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "busqueda_productos";
            Text = "InkPos - Venta";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox f4_search;
        private Button Button_search;
        private ListBox coindienci;
        private DataGridView dgvDetalleVenta;
        private DataGridViewTextBoxColumn column_codigo;
        private DataGridViewTextBoxColumn column_NombreP;
        private DataGridViewTextBoxColumn column_cantidad;
        private DataGridViewTextBoxColumn column_valor;
        private Label lbl_detalleVenta;
        private TextBox txtbox_cantidadProducto;
        private TextBox txtbox_valorTotal;
    }
}