namespace InkPos
{
    partial class Form_Gestion_Productos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion_Productos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel_GP = new Panel();
            dgv_Productos = new DataGridView();
            codigoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            productoBindingSource = new BindingSource(components);
            txtbox_buscar = new MaterialSkin.Controls.MaterialTextBox2();
            button_añadir_producto = new Button();
            button_salir = new Button();
            lbl_GP = new Label();
            panel_GP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel_GP
            // 
            panel_GP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_GP.BackgroundImage = (Image)resources.GetObject("panel_GP.BackgroundImage");
            panel_GP.Controls.Add(dgv_Productos);
            panel_GP.Controls.Add(txtbox_buscar);
            panel_GP.Controls.Add(button_añadir_producto);
            panel_GP.Controls.Add(button_salir);
            panel_GP.Controls.Add(lbl_GP);
            panel_GP.Location = new Point(5, 2);
            panel_GP.Name = "panel_GP";
            panel_GP.Size = new Size(1513, 1171);
            panel_GP.TabIndex = 0;
            panel_GP.MouseDown += panelFondo_MouseDown;
            // 
            // dgv_Productos
            // 
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.AllowUserToResizeColumns = false;
            dgv_Productos.AllowUserToResizeRows = false;
            dgv_Productos.Anchor = AnchorStyles.None;
            dgv_Productos.AutoGenerateColumns = false;
            dgv_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Columns.AddRange(new DataGridViewColumn[] { codigoDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgv_Productos.DataSource = productoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Productos.Location = new Point(124, 372);
            dgv_Productos.MultiSelect = false;
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.RowHeadersVisible = false;
            dgv_Productos.RowHeadersWidth = 51;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Productos.Size = new Size(1270, 654);
            dgv_Productos.TabIndex = 6;
            dgv_Productos.CellClick += dgv_Productos_CellClick;
            dgv_Productos.Leave += dgv_Productos_Leave;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Precio";
            dataGridViewTextBoxColumn1.HeaderText = "Precio";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Stock";
            dataGridViewTextBoxColumn2.HeaderText = "Stock";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(Producto);
            // 
            // txtbox_buscar
            // 
            txtbox_buscar.Anchor = AnchorStyles.None;
            txtbox_buscar.AnimateReadOnly = false;
            txtbox_buscar.BackgroundImageLayout = ImageLayout.None;
            txtbox_buscar.CharacterCasing = CharacterCasing.Normal;
            txtbox_buscar.Depth = 0;
            txtbox_buscar.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtbox_buscar.HideSelection = true;
            txtbox_buscar.Hint = "Ingrese el código o nombre del producto";
            txtbox_buscar.LeadingIcon = null;
            txtbox_buscar.Location = new Point(611, 245);
            txtbox_buscar.MaxLength = 32767;
            txtbox_buscar.MouseState = MaterialSkin.MouseState.OUT;
            txtbox_buscar.Name = "txtbox_buscar";
            txtbox_buscar.PasswordChar = '\0';
            txtbox_buscar.PrefixSuffixText = null;
            txtbox_buscar.ReadOnly = false;
            txtbox_buscar.RightToLeft = RightToLeft.No;
            txtbox_buscar.SelectedText = "";
            txtbox_buscar.SelectionLength = 0;
            txtbox_buscar.SelectionStart = 0;
            txtbox_buscar.ShortcutsEnabled = true;
            txtbox_buscar.Size = new Size(332, 48);
            txtbox_buscar.TabIndex = 5;
            txtbox_buscar.TabStop = false;
            txtbox_buscar.TextAlign = HorizontalAlignment.Left;
            txtbox_buscar.TrailingIcon = null;
            txtbox_buscar.UseSystemPasswordChar = false;
            txtbox_buscar.TextChanged += txtbox_buscar_TextChanged;
            // 
            // button_añadir_producto
            // 
            button_añadir_producto.Anchor = AnchorStyles.None;
            button_añadir_producto.Image = (Image)resources.GetObject("button_añadir_producto.Image");
            button_añadir_producto.Location = new Point(1250, 233);
            button_añadir_producto.Name = "button_añadir_producto";
            button_añadir_producto.Size = new Size(69, 48);
            button_añadir_producto.TabIndex = 4;
            button_añadir_producto.UseVisualStyleBackColor = true;
            button_añadir_producto.Click += button_añadir_producto_Click;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(171, 233);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 3;
            button_salir.UseVisualStyleBackColor = true;
            button_salir.Click += button_salir_Click;
            // 
            // lbl_GP
            // 
            lbl_GP.Anchor = AnchorStyles.None;
            lbl_GP.AutoSize = true;
            lbl_GP.BackColor = Color.Transparent;
            lbl_GP.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GP.ForeColor = Color.White;
            lbl_GP.Location = new Point(561, 120);
            lbl_GP.Name = "lbl_GP";
            lbl_GP.Size = new Size(440, 46);
            lbl_GP.TabIndex = 0;
            lbl_GP.Text = "Gestión de productos";
            // 
            // Form_Gestion_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_GP);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Gestion_Productos";
            Text = "InkPOS - Gestión de productos";
            WindowState = FormWindowState.Maximized;
            Load += Form_Gestion_Productos_Load;
            MouseDown += Form_Gestion_Productos_MouseDown;
            panel_GP.ResumeLayout(false);
            panel_GP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_GP;
        private Label lbl_GP;
        private Button button_añadir_producto;
        private Button button_salir;
        private MaterialSkin.Controls.MaterialTextBox2 txtbox_buscar;
        private DataGridView dgv_Productos;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreItemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource productoBindingSource;
    }
}