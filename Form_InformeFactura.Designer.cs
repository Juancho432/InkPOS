namespace InkPos
{
    partial class Form_InformeFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InformeFactura));
            pictureBox1 = new PictureBox();
            button_imprimir = new Button();
            lbl_PapeleríaAJ = new Label();
            tlb_info_cliente = new TableLayoutPanel();
            lbl_fve = new Label();
            lbl_telefono = new Label();
            lbl_ciudad = new Label();
            lbl_nit = new Label();
            lbl_dirección = new Label();
            label4 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label5 = new Label();
            lbl_señor_es = new Label();
            label14 = new Label();
            tbl_fecha_metodo = new TableLayoutPanel();
            lbl_metodo_pago = new Label();
            label21 = new Label();
            label24 = new Label();
            lbl_fecha_expedicion = new Label();
            dgvDetalleVenta = new DataGridView();
            column_codigo = new DataGridViewTextBoxColumn();
            column_NombreP = new DataGridViewTextBoxColumn();
            column_cantidad = new DataGridViewTextBoxColumn();
            column_valor = new DataGridViewTextBoxColumn();
            label15 = new Label();
            label20 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label17 = new Label();
            lbl_valor_total = new Label();
            lbl_total_cantidad = new Label();
            lbl_generación = new Label();
            lbl_fecha_generacion = new Label();
            lbl_hora_generacion = new Label();
            button_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlb_info_cliente.SuspendLayout();
            tbl_fecha_metodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button_imprimir
            // 
            button_imprimir.Image = (Image)resources.GetObject("button_imprimir.Image");
            button_imprimir.Location = new Point(37, 12);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new Size(69, 48);
            button_imprimir.TabIndex = 2;
            button_imprimir.UseVisualStyleBackColor = true;
            // 
            // lbl_PapeleríaAJ
            // 
            lbl_PapeleríaAJ.Anchor = AnchorStyles.None;
            lbl_PapeleríaAJ.AutoSize = true;
            lbl_PapeleríaAJ.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PapeleríaAJ.Location = new Point(818, 6);
            lbl_PapeleríaAJ.Name = "lbl_PapeleríaAJ";
            lbl_PapeleríaAJ.Size = new Size(316, 57);
            lbl_PapeleríaAJ.TabIndex = 3;
            lbl_PapeleríaAJ.Text = "Papelería AJ";
            // 
            // tlb_info_cliente
            // 
            tlb_info_cliente.Anchor = AnchorStyles.None;
            tlb_info_cliente.BackColor = SystemColors.ButtonFace;
            tlb_info_cliente.ColumnCount = 6;
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4444427F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.55556F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 197F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlb_info_cliente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 172F));
            tlb_info_cliente.Controls.Add(lbl_fve, 5, 1);
            tlb_info_cliente.Controls.Add(lbl_telefono, 5, 0);
            tlb_info_cliente.Controls.Add(lbl_ciudad, 3, 1);
            tlb_info_cliente.Controls.Add(lbl_nit, 3, 0);
            tlb_info_cliente.Controls.Add(lbl_dirección, 1, 1);
            tlb_info_cliente.Controls.Add(label4, 0, 1);
            tlb_info_cliente.Controls.Add(label2, 0, 0);
            tlb_info_cliente.Controls.Add(label6, 4, 0);
            tlb_info_cliente.Controls.Add(label7, 4, 1);
            tlb_info_cliente.Controls.Add(label3, 2, 0);
            tlb_info_cliente.Controls.Add(label5, 2, 1);
            tlb_info_cliente.Controls.Add(lbl_señor_es, 1, 0);
            tlb_info_cliente.Location = new Point(575, 105);
            tlb_info_cliente.Name = "tlb_info_cliente";
            tlb_info_cliente.RowCount = 2;
            tlb_info_cliente.RowStyles.Add(new RowStyle(SizeType.Percent, 53.75F));
            tlb_info_cliente.RowStyles.Add(new RowStyle(SizeType.Percent, 46.25F));
            tlb_info_cliente.Size = new Size(836, 80);
            tlb_info_cliente.TabIndex = 4;
            // 
            // lbl_fve
            // 
            lbl_fve.Anchor = AnchorStyles.Left;
            lbl_fve.AutoSize = true;
            lbl_fve.Location = new Point(666, 51);
            lbl_fve.Name = "lbl_fve";
            lbl_fve.Size = new Size(73, 20);
            lbl_fve.TabIndex = 6;
            lbl_fve.Text = "__________ ";
            lbl_fve.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_telefono
            // 
            lbl_telefono.Anchor = AnchorStyles.Left;
            lbl_telefono.AutoSize = true;
            lbl_telefono.Location = new Point(666, 11);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(73, 20);
            lbl_telefono.TabIndex = 6;
            lbl_telefono.Text = "__________ ";
            lbl_telefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_ciudad
            // 
            lbl_ciudad.Anchor = AnchorStyles.Left;
            lbl_ciudad.AutoSize = true;
            lbl_ciudad.Location = new Point(381, 51);
            lbl_ciudad.Name = "lbl_ciudad";
            lbl_ciudad.Size = new Size(73, 20);
            lbl_ciudad.TabIndex = 6;
            lbl_ciudad.Text = "__________ ";
            lbl_ciudad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_nit
            // 
            lbl_nit.Anchor = AnchorStyles.Left;
            lbl_nit.AutoSize = true;
            lbl_nit.Location = new Point(381, 11);
            lbl_nit.Name = "lbl_nit";
            lbl_nit.Size = new Size(73, 20);
            lbl_nit.TabIndex = 6;
            lbl_nit.Text = "__________ ";
            lbl_nit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_dirección
            // 
            lbl_dirección.Anchor = AnchorStyles.Left;
            lbl_dirección.AutoSize = true;
            lbl_dirección.Location = new Point(109, 51);
            lbl_dirección.Name = "lbl_dirección";
            lbl_dirección.Size = new Size(73, 20);
            lbl_dirección.TabIndex = 5;
            lbl_dirección.Text = "__________ ";
            lbl_dirección.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 51);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 5;
            label4.Text = "Dirección:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Señor (es): ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(578, 11);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 6;
            label6.Text = "Teléfono:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(578, 51);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 5;
            label7.Text = "FVE: ";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(312, 11);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "NIT: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(312, 51);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 5;
            label5.Text = "Ciudad:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_señor_es
            // 
            lbl_señor_es.Anchor = AnchorStyles.Left;
            lbl_señor_es.AutoSize = true;
            lbl_señor_es.Location = new Point(109, 11);
            lbl_señor_es.Name = "lbl_señor_es";
            lbl_señor_es.Size = new Size(73, 20);
            lbl_señor_es.TabIndex = 6;
            lbl_señor_es.Text = "__________ ";
            lbl_señor_es.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(921, 517);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 5;
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbl_fecha_metodo
            // 
            tbl_fecha_metodo.Anchor = AnchorStyles.None;
            tbl_fecha_metodo.BackColor = SystemColors.ButtonFace;
            tbl_fecha_metodo.ColumnCount = 4;
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.60194F));
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.39806F));
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tbl_fecha_metodo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 281F));
            tbl_fecha_metodo.Controls.Add(lbl_metodo_pago, 3, 0);
            tbl_fecha_metodo.Controls.Add(label21, 0, 0);
            tbl_fecha_metodo.Controls.Add(label24, 2, 0);
            tbl_fecha_metodo.Controls.Add(lbl_fecha_expedicion, 1, 0);
            tbl_fecha_metodo.Location = new Point(575, 206);
            tbl_fecha_metodo.Name = "tbl_fecha_metodo";
            tbl_fecha_metodo.RowCount = 1;
            tbl_fecha_metodo.RowStyles.Add(new RowStyle(SizeType.Percent, 53.75F));
            tbl_fecha_metodo.Size = new Size(836, 54);
            tbl_fecha_metodo.TabIndex = 6;
            // 
            // lbl_metodo_pago
            // 
            lbl_metodo_pago.Anchor = AnchorStyles.Left;
            lbl_metodo_pago.AutoSize = true;
            lbl_metodo_pago.Location = new Point(557, 17);
            lbl_metodo_pago.Name = "lbl_metodo_pago";
            lbl_metodo_pago.Size = new Size(73, 20);
            lbl_metodo_pago.TabIndex = 6;
            lbl_metodo_pago.Text = "__________ ";
            lbl_metodo_pago.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Location = new Point(3, 17);
            label21.Name = "label21";
            label21.Size = new Size(134, 20);
            label21.TabIndex = 0;
            label21.Text = "Fecha expedicción:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            label21.Click += label21_Click;
            // 
            // label24
            // 
            label24.Anchor = AnchorStyles.Left;
            label24.AutoSize = true;
            label24.Location = new Point(427, 17);
            label24.Name = "label24";
            label24.Size = new Size(114, 20);
            label24.TabIndex = 5;
            label24.Text = "Forma de pago:";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_fecha_expedicion
            // 
            lbl_fecha_expedicion.Anchor = AnchorStyles.Left;
            lbl_fecha_expedicion.AutoSize = true;
            lbl_fecha_expedicion.Location = new Point(201, 17);
            lbl_fecha_expedicion.Name = "lbl_fecha_expedicion";
            lbl_fecha_expedicion.Size = new Size(73, 20);
            lbl_fecha_expedicion.TabIndex = 6;
            lbl_fecha_expedicion.Text = "__________ ";
            lbl_fecha_expedicion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.Anchor = AnchorStyles.None;
            dgvDetalleVenta.BackgroundColor = SystemColors.ControlLight;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { column_codigo, column_NombreP, column_cantidad, column_valor });
            dgvDetalleVenta.Location = new Point(575, 279);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(836, 396);
            dgvDetalleVenta.TabIndex = 8;
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
            // label15
            // 
            label15.Anchor = AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(964, 778);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 10;
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Left;
            label20.AutoSize = true;
            label20.Location = new Point(1134, 791);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 11;
            label20.TextAlign = ContentAlignment.MiddleLeft;
            label20.Click += label20_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.9876556F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0123463F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tableLayoutPanel3.Controls.Add(label17, 0, 0);
            tableLayoutPanel3.Controls.Add(lbl_valor_total, 2, 0);
            tableLayoutPanel3.Controls.Add(lbl_total_cantidad, 1, 0);
            tableLayoutPanel3.Location = new Point(575, 671);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 53.75F));
            tableLayoutPanel3.Size = new Size(836, 54);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new Point(3, 17);
            label17.Name = "label17";
            label17.Size = new Size(45, 20);
            label17.TabIndex = 0;
            label17.Text = "Total:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_valor_total
            // 
            lbl_valor_total.Anchor = AnchorStyles.Left;
            lbl_valor_total.AutoSize = true;
            lbl_valor_total.Location = new Point(651, 17);
            lbl_valor_total.Name = "lbl_valor_total";
            lbl_valor_total.Size = new Size(73, 20);
            lbl_valor_total.TabIndex = 6;
            lbl_valor_total.Text = "__________ ";
            lbl_valor_total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_total_cantidad
            // 
            lbl_total_cantidad.Anchor = AnchorStyles.Left;
            lbl_total_cantidad.AutoSize = true;
            lbl_total_cantidad.Location = new Point(463, 17);
            lbl_total_cantidad.Name = "lbl_total_cantidad";
            lbl_total_cantidad.Size = new Size(73, 20);
            lbl_total_cantidad.TabIndex = 6;
            lbl_total_cantidad.Text = "__________ ";
            lbl_total_cantidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_generación
            // 
            lbl_generación.Anchor = AnchorStyles.None;
            lbl_generación.AutoSize = true;
            lbl_generación.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_generación.Location = new Point(650, 791);
            lbl_generación.Name = "lbl_generación";
            lbl_generación.Size = new Size(346, 28);
            lbl_generación.TabIndex = 13;
            lbl_generación.Text = "Fecha y hora de generación: ";
            // 
            // lbl_fecha_generacion
            // 
            lbl_fecha_generacion.Anchor = AnchorStyles.None;
            lbl_fecha_generacion.AutoSize = true;
            lbl_fecha_generacion.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_fecha_generacion.Location = new Point(1002, 791);
            lbl_fecha_generacion.Name = "lbl_fecha_generacion";
            lbl_fecha_generacion.Size = new Size(144, 28);
            lbl_fecha_generacion.TabIndex = 14;
            lbl_fecha_generacion.Text = "xxxx-xx-xx";
            // 
            // lbl_hora_generacion
            // 
            lbl_hora_generacion.Anchor = AnchorStyles.None;
            lbl_hora_generacion.AutoSize = true;
            lbl_hora_generacion.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hora_generacion.Location = new Point(1176, 791);
            lbl_hora_generacion.Name = "lbl_hora_generacion";
            lbl_hora_generacion.Size = new Size(80, 28);
            lbl_hora_generacion.TabIndex = 15;
            lbl_hora_generacion.Text = "00:00";
            // 
            // button_salir
            // 
            button_salir.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_salir.Location = new Point(935, 986);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(94, 44);
            button_salir.TabIndex = 16;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = true;
            // 
            // InformeFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1924, 1055);
            Controls.Add(button_salir);
            Controls.Add(lbl_hora_generacion);
            Controls.Add(lbl_fecha_generacion);
            Controls.Add(lbl_generación);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(label20);
            Controls.Add(label15);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(tbl_fecha_metodo);
            Controls.Add(label14);
            Controls.Add(tlb_info_cliente);
            Controls.Add(lbl_PapeleríaAJ);
            Controls.Add(button_imprimir);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InformeFactura";
            RightToLeft = RightToLeft.No;
            Text = "InformeFactura";
            WindowState = FormWindowState.Maximized;
            Load += InformeFactura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlb_info_cliente.ResumeLayout(false);
            tlb_info_cliente.PerformLayout();
            tbl_fecha_metodo.ResumeLayout(false);
            tbl_fecha_metodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button_imprimir;
        private Label lbl_PapeleríaAJ;
        private TableLayoutPanel tlb_info_cliente;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbl_dirección;
        private Label lbl_fve;
        private Label lbl_telefono;
        private Label lbl_ciudad;
        private Label lbl_nit;
        private Label lbl_señor_es;
        private Label label14;
        private TableLayoutPanel tbl_fecha_metodo;
        private Label lbl_metodo_pago;
        private Label label21;
        private Label label24;
        private Label lbl_fecha_expedicion;
        private DataGridView dgvDetalleVenta;
        private DataGridViewTextBoxColumn column_codigo;
        private DataGridViewTextBoxColumn column_NombreP;
        private DataGridViewTextBoxColumn column_cantidad;
        private DataGridViewTextBoxColumn column_valor;
        private Label label15;
        private Label label20;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label17;
        private Label lbl_valor_total;
        private Label lbl_total_cantidad;
        private Label lbl_generación;
        private Label lbl_fecha_generacion;
        private Label lbl_hora_generacion;
        private Button button_salir;
    }
}