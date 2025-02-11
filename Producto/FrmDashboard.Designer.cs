namespace CapaPresentacion
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnPersonas;
        private System.Windows.Forms.Button btnOtroFormulario;
        private System.Windows.Forms.Label lblTitulo;

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
            panelMenu = new Panel();
            lblTitulo = new Label();
            btnPersonas = new Button();
            btnOtroFormulario = new Button();
            panelContainer = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelMenu.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 46);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnPersonas);
            panelMenu.Controls.Add(btnOtroFormulario);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 600);
            panelMenu.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(10, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menú Principal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPersonas
            // 
            btnPersonas.BackColor = Color.SteelBlue;
            btnPersonas.FlatAppearance.BorderSize = 0;
            btnPersonas.FlatStyle = FlatStyle.Flat;
            btnPersonas.ForeColor = Color.White;
            btnPersonas.Location = new Point(10, 100);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(180, 50);
            btnPersonas.TabIndex = 1;
            btnPersonas.Text = "Gestión de Personas";
            btnPersonas.UseVisualStyleBackColor = false;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // btnOtroFormulario
            // 
            btnOtroFormulario.BackColor = Color.DarkSlateGray;
            btnOtroFormulario.FlatAppearance.BorderSize = 0;
            btnOtroFormulario.FlatStyle = FlatStyle.Flat;
            btnOtroFormulario.ForeColor = Color.White;
            btnOtroFormulario.Location = new Point(10, 160);
            btnOtroFormulario.Name = "btnOtroFormulario";
            btnOtroFormulario.Size = new Size(180, 50);
            btnOtroFormulario.TabIndex = 2;
            btnOtroFormulario.Text = "Producto";
            btnOtroFormulario.UseVisualStyleBackColor = false;
            btnOtroFormulario.Click += btnOtroFormulario_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Controls.Add(flowLayoutPanel1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(200, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(700, 600);
            panelContainer.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(355, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Gestión de Personas";
            panelMenu.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
    }
}
