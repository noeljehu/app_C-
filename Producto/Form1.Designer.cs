namespace CapaPresentacion
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            panelControles = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelHeader = new Panel();
            labelTitulo = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelControles.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(99, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(437, 190);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 15);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(80, 55);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(80, 95);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(200, 23);
            txtStock.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(305, 9);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 33);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.RoyalBlue;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(305, 58);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(305, 98);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panelControles
            // 
            panelControles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelControles.Controls.Add(label3);
            panelControles.Controls.Add(label2);
            panelControles.Controls.Add(label1);
            panelControles.Controls.Add(txtNombre);
            panelControles.Controls.Add(btnEliminar);
            panelControles.Controls.Add(txtPrecio);
            panelControles.Controls.Add(btnActualizar);
            panelControles.Controls.Add(txtStock);
            panelControles.Controls.Add(btnAgregar);
            panelControles.Location = new Point(99, 305);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(437, 132);
            panelControles.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 98);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 58);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(labelTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(673, 60);
            panelHeader.TabIndex = 8;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(20, 15);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(260, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Gestión de Productos";
            // 
            // button1
            // 
            button1.Location = new Point(572, 414);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "CAMBIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(673, 467);
            Controls.Add(button1);
            Controls.Add(panelHeader);
            Controls.Add(panelControles);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Gestión de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitulo;
        private Button button1;
    }
}