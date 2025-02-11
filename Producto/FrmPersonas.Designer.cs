namespace CapaPresentacion
{
    partial class FrmPersonas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCorreo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPersonas = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            lblId = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEdad = new Label();
            lblCorreo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.Location = new Point(20, 270);
            dgvPersonas.MultiSelect = false;
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.Size = new Size(420, 162);
            dgvPersonas.TabIndex = 13;
            dgvPersonas.SelectionChanged += dgvPersonas_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(150, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(150, 100);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(150, 140);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(150, 180);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 220);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(120, 220);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(20, 100);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(100, 23);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblEdad
            // 
            lblEdad.Location = new Point(20, 140);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(100, 23);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad:";
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(20, 180);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(100, 23);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo Electrónico:";
            // 
            // FrmPersonas
            // 
            ClientSize = new Size(645, 500);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblEdad);
            Controls.Add(txtEdad);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvPersonas);
            Name = "FrmPersonas";
            Text = "Gestión de Personas";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
