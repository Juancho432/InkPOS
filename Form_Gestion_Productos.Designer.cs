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
            panel_GP = new Panel();
            dgv_Productos = new DataGridView();
            Column_ID_producto = new DataGridViewTextBoxColumn();
            Column_Nombre_Item = new DataGridViewTextBoxColumn();
            Column_Precio_Producto = new DataGridViewTextBoxColumn();
            Column_Stock_Producto = new DataGridViewTextBoxColumn();
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
            panel_GP.Controls.Add(dgv_Productos);
            panel_GP.Controls.Add(txtbox_buscar);
            panel_GP.Controls.Add(button_añadir_producto);
            panel_GP.Controls.Add(button_salir);
            panel_GP.Controls.Add(lbl_GP);
            panel_GP.Location = new Point(5, 2);
            panel_GP.Name = "panel_GP";
            panel_GP.Size = new Size(1513, 1171);
            panel_GP.TabIndex = 0;
            // 
            // dgv_Productos
            // 
            dgv_Productos.Anchor = AnchorStyles.None;
            dgv_Productos.AutoGenerateColumns = false;
            dgv_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Columns.AddRange(new DataGridViewColumn[] { Column_ID_producto, Column_Nombre_Item, Column_Precio_Producto, Column_Stock_Producto });
            dgv_Productos.DataSource = productoBindingSource;
            dgv_Productos.Location = new Point(143, 276);
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.RowHeadersVisible = false;
            dgv_Productos.RowHeadersWidth = 51;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Productos.Size = new Size(1270, 654);
            dgv_Productos.TabIndex = 6;
            // 
            // Column_ID_producto
            // 
            Column_ID_producto.HeaderText = "Código";
            Column_ID_producto.MinimumWidth = 6;
            Column_ID_producto.Name = "Column_ID_producto";
            // 
            // Column_Nombre_Item
            // 
            Column_Nombre_Item.HeaderText = "NombreItem";
            Column_Nombre_Item.MinimumWidth = 6;
            Column_Nombre_Item.Name = "Column_Nombre_Item";
            // 
            // Column_Precio_Producto
            // 
            Column_Precio_Producto.HeaderText = "Precio";
            Column_Precio_Producto.MinimumWidth = 6;
            Column_Precio_Producto.Name = "Column_Precio_Producto";
            // 
            // Column_Stock_Producto
            // 
            Column_Stock_Producto.HeaderText = "Stock";
            Column_Stock_Producto.MinimumWidth = 6;
            Column_Stock_Producto.Name = "Column_Stock_Producto";
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
            txtbox_buscar.Location = new Point(561, 158);
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
            // 
            // button_añadir_producto
            // 
            button_añadir_producto.Anchor = AnchorStyles.None;
            button_añadir_producto.Image = (Image)resources.GetObject("button_añadir_producto.Image");
            button_añadir_producto.Location = new Point(1250, 146);
            button_añadir_producto.Name = "button_añadir_producto";
            button_añadir_producto.Size = new Size(69, 48);
            button_añadir_producto.TabIndex = 4;
            button_añadir_producto.UseVisualStyleBackColor = true;
            // 
            // button_salir
            // 
            button_salir.Anchor = AnchorStyles.None;
            button_salir.Image = (Image)resources.GetObject("button_salir.Image");
            button_salir.Location = new Point(171, 146);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(69, 48);
            button_salir.TabIndex = 3;
            button_salir.UseVisualStyleBackColor = true;
            // 
            // lbl_GP
            // 
            lbl_GP.Anchor = AnchorStyles.None;
            lbl_GP.AutoSize = true;
            lbl_GP.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GP.Location = new Point(561, 33);
            lbl_GP.Name = "lbl_GP";
            lbl_GP.Size = new Size(405, 54);
            lbl_GP.TabIndex = 0;
            lbl_GP.Text = "Gestión de productos";
            // 
            // Form_Gestion_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 1175);
            Controls.Add(panel_GP);
            Name = "Form_Gestion_Productos";
            Text = "InkPOS - Gestión de productos";
            WindowState = FormWindowState.Maximized;
            Load += Form_Gestion_Productos_Load;
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
        private BindingSource productoBindingSource;
        private DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreItemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column_ID_producto;
        private DataGridViewTextBoxColumn Column_Nombre_Item;
        private DataGridViewTextBoxColumn Column_Precio_Producto;
        private DataGridViewTextBoxColumn Column_Stock_Producto;
    }
}