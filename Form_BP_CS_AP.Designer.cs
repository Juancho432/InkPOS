namespace InkPos
{
    partial class Form_BP_CS_AP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BP_CS_AP));
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            lstCoincidencias = new ListBox();
            dgvProductos = new DataGridView();
            column_codigo = new DataGridViewTextBoxColumn();
            column_NombreP = new DataGridViewTextBoxColumn();
            column_cantidad = new DataGridViewTextBoxColumn();
            column_valor = new DataGridViewTextBoxColumn();
            lbl_detalleVenta = new Label();
            txtboxCantidadProducto = new TextBox();
            txtValorTotal = new TextBox();
            lbl_cantidad_productos = new Label();
            lbl_valorTotal = new Label();
            btnFinalizar = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.None;
            txtBusqueda.Location = new Point(105, 92);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "(F4) Código/nombre del producto";
            txtBusqueda.Size = new Size(233, 27);
            txtBusqueda.TabIndex = 0;
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
            // lstCoincidencias
            // 
            lstCoincidencias.Anchor = AnchorStyles.None;
            lstCoincidencias.FormattingEnabled = true;
            lstCoincidencias.Location = new Point(105, 220);
            lstCoincidencias.Name = "lstCoincidencias";
            lstCoincidencias.Size = new Size(233, 224);
            lstCoincidencias.TabIndex = 2;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = SystemColors.ControlLight;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { column_codigo, column_NombreP, column_cantidad, column_valor });
            dgvProductos.Location = new Point(490, 63);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(853, 396);
            dgvProductos.TabIndex = 7;
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
            // txtboxCantidadProducto
            // 
            txtboxCantidadProducto.Anchor = AnchorStyles.None;
            txtboxCantidadProducto.Location = new Point(703, 506);
            txtboxCantidadProducto.Name = "txtboxCantidadProducto";
            txtboxCantidadProducto.Size = new Size(160, 27);
            txtboxCantidadProducto.TabIndex = 9;
            txtboxCantidadProducto.TextChanged += textBox1_TextChanged;
            // 
            // txtValorTotal
            // 
            txtValorTotal.Anchor = AnchorStyles.None;
            txtValorTotal.Location = new Point(930, 506);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(154, 27);
            txtValorTotal.TabIndex = 10;
            txtValorTotal.TextChanged += txtbox_valorTotal_TextChanged;
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
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.None;
            btnFinalizar.Location = new Point(837, 572);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 13;
            btnFinalizar.Text = "Finalizar venta";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lstCoincidencias);
            groupBox1.Controls.Add(lbl_valorTotal);
            groupBox1.Controls.Add(btnFinalizar);
            groupBox1.Controls.Add(lbl_cantidad_productos);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtValorTotal);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Controls.Add(txtboxCantidadProducto);
            groupBox1.Controls.Add(lbl_detalleVenta);
            groupBox1.Controls.Add(dgvProductos);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "busqueda_productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InkPos - Venta";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtBusqueda;
        private Button btnBuscar;
        private ListBox lstCoincidencias;
        private DataGridView dgvProductos;
        private Label lbl_detalleVenta;
        private TextBox txtboxCantidadProducto;
        private TextBox txtValorTotal;
        private Label lbl_cantidad_productos;
        private Label lbl_valorTotal;
        private DataGridViewTextBoxColumn column_codigo;
        private DataGridViewTextBoxColumn column_NombreP;
        private DataGridViewTextBoxColumn column_cantidad;
        private DataGridViewTextBoxColumn column_valor;
        private Button btnFinalizar;
        private GroupBox groupBox1;
    }
}