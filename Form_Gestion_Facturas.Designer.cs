namespace InkPos
{
    partial class Form_Gestion_Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Facturas));
            panel_GF = new Panel();
            lbl_fecha_fin = new Label();
            lbl_fecha_inicio = new Label();
            timepicker_fecha_fin = new DateTimePicker();
            timepicker_fecha_inicio = new DateTimePicker();
            dgv_Facturas = new DataGridView();
            txtbox_buscar_factura = new MaterialSkin.Controls.MaterialTextBox2();
            button_añadir_producto = new Button();
            button_salir = new Button();
            lbl_GF = new Label();
            panel_GF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).BeginInit();
            SuspendLayout();
            // 
            // panel_GF
            // 
            panel_GF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GF.Controls.Add(lbl_fecha_fin);
            panel_GF.Controls.Add(lbl_fecha_inicio);
            panel_GF.Controls.Add(timepicker_fecha_fin);
            panel_GF.Controls.Add(timepicker_fecha_inicio);
            panel_GF.Controls.Add(dgv_Facturas);
            panel_GF.Controls.Add(txtbox_buscar_factura);
            panel_GF.Controls.Add(button_añadir_producto);
            panel_GF.Controls.Add(button_salir);
            panel_GF.Controls.Add(lbl_GF);
            panel_GF.Location = new Point(5, 2);
            panel_GF.Name = "panel_GF";
            panel_GF.Size = new Size(1513, 1171);
            panel_GF.TabIndex = 0;
            // 
            // lbl_fecha_fin
            // 
            lbl_fecha_fin.Anchor = AnchorStyles.None;
            lbl_fecha_fin.AutoSize = true;
            lbl_fecha_fin.Location = new Point(1045, 235);
            lbl_fecha_fin.Name = "lbl_fecha_fin";
            lbl_fecha_fin.Size = new Size(50, 20);
            lbl_fecha_fin.TabIndex = 19;
            lbl_fecha_fin.Text = "Hasta:";
            // 
            // lbl_fecha_inicio
            // 
            lbl_fecha_inicio.Anchor = AnchorStyles.None;
            lbl_fecha_inicio.AutoSize = true;
            lbl_fecha_inicio.Location = new Point(706, 235);
            lbl_fecha_inicio.Name = "lbl_fecha_inicio";
            lbl_fecha_inicio.Size = new Size(54, 20);
            lbl_fecha_inicio.TabIndex = 18;
            lbl_fecha_inicio.Text = "Desde:";
            // 
            // timepicker_fecha_fin
            // 
            timepicker_fecha_fin.Anchor = AnchorStyles.None;
            timepicker_fecha_fin.Location = new Point(929, 267);
            timepicker_fecha_fin.Name = "timepicker_fecha_fin";
            timepicker_fecha_fin.Size = new Size(291, 27);
            timepicker_fecha_fin.TabIndex = 17;
            // 
            // timepicker_fecha_inicio
            // 
            timepicker_fecha_inicio.Anchor = AnchorStyles.None;
            timepicker_fecha_inicio.Location = new Point(592, 267);
            timepicker_fecha_inicio.Name = "timepicker_fecha_inicio";
            timepicker_fecha_inicio.Size = new Size(291, 27);
            timepicker_fecha_inicio.TabIndex = 16;
            // 
            // dgv_Facturas
            // 
            dgv_Facturas.AllowUserToAddRows = false;
            dgv_Facturas.AllowUserToDeleteRows = false;
            dgv_Facturas.AllowUserToResizeColumns = false;
            dgv_Facturas.AllowUserToResizeRows = false;
            dgv_Facturas.Anchor = AnchorStyles.None;
            dgv_Facturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Facturas.Location = new Point(43, 345);
            dgv_Facturas.MultiSelect = false;
            dgv_Facturas.Name = "dgv_Facturas";
            dgv_Facturas.ReadOnly = true;
            dgv_Facturas.RowHeadersVisible = false;
            dgv_Facturas.RowHeadersWidth = 51;
            dgv_Facturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Facturas.Size = new Size(1431, 724);
            dgv_Facturas.TabIndex = 15;
            // 
            // txtbox_buscar_factura
            // 
            txtbox_buscar_factura.Anchor = AnchorStyles.None;
            txtbox_buscar_factura.AnimateReadOnly = false;
            txtbox_buscar_factura.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar_factura.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar_factura.Depth = 0;
            txtbox_buscar_factura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar_factura.HideSelection = true;
            txtbox_buscar_factura.Hint = "Ingrese el N° de factura";
            txtbox_buscar_factura.LeadingIcon = null;
            txtbox_buscar_factura.Location = new Point(348, 246);
            txtbox_buscar_factura.MaxLength = 32767;
            txtbox_buscar_factura.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar_factura.Name = "txtbox_buscar_factura";
            txtbox_buscar_factura.PasswordChar = '\0';
            txtbox_buscar_factura.PrefixSuffixText = null;
            txtbox_buscar_factura.ReadOnly = false;
            txtbox_buscar_factura.RightToLeft = RightToLeft.No;
            txtbox_buscar_factura.SelectedText = "";
            txtbox_buscar_factura.SelectionLength = 0;
            txtbox_buscar_factura.SelectionStart = 0;
            txtbox_buscar_factura.ShortcutsEnabled = true;
            txtbox_buscar_factura.Size = new Size(192, 48);
            txtbox_buscar_factura.TabIndex = 14;
            txtbox_buscar_factura.TabStop = false;
            txtbox_buscar_factura.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar_factura.TrailingIcon = null;
            txtbox_buscar_factura.UseSystemPasswordChar = false;
            // 
            // button_añadir_producto
            // 
            button_añadir_producto.Anchor = AnchorStyles.None;
            button_añadir_producto.Image = (Image)resources.GetObject("button_añadir_producto.Image");
            button_añadir_producto.Location = new Point(1291, 246);
            button_añadir_producto.Name = "button_añadir_producto";
            button_añadir_producto.Size = new Size(69, 48);
            button_añadir_producto.TabIndex = 13;
            button_añadir_producto.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(212, 246);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 12;
            button_salir.UseVisualStyleBackColor = true;
            // 
            // lbl_GF
            // 
            lbl_GF.Anchor = AnchorStyles.None;
            lbl_GF.AutoSize = true;
            lbl_GF.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GF.Location = new Point(602, 133);
            lbl_GF.Name = "lbl_GF";
            lbl_GF.Size = new Size(364, 54);
            lbl_GF.TabIndex = 11;
            lbl_GF.Text = "Gestión de facturas";
            // 
            // Form_Gestion_Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_GF);
            Name = "Form_Gestion_Facturas";
            Text = "InkPOS - Gestion de facturas";
            WindowState = FormWindowState.Maximized;
            panel_GF.ResumeLayout(false);
            panel_GF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GF;
        private DataGridView dgv_Facturas;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar_factura;
        private Button button_añadir_producto;
        private Button button_salir;
        private Label lbl_GF;
        private Label lbl_fecha_fin;
        private Label lbl_fecha_inicio;
        private DateTimePicker timepicker_fecha_fin;
        private DateTimePicker timepicker_fecha_inicio;
    }
}