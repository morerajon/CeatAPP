namespace CeatApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBotonesM = new System.Windows.Forms.Panel();
            this.btnCerrarSesion1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClaves = new System.Windows.Forms.Button();
            this.btnMensajes = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBotonesM.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(5)))), ((int)(((byte)(25)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(12)))), ((int)(((byte)(21)))));
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(1281, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 26);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.pnlBotonesM);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 579);
            this.panel1.TabIndex = 5;
            // 
            // pnlBotonesM
            // 
            this.pnlBotonesM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(94)))), ((int)(((byte)(140)))));
            this.pnlBotonesM.Controls.Add(this.btnCerrarSesion1);
            this.pnlBotonesM.Controls.Add(this.panel4);
            this.pnlBotonesM.Controls.Add(this.btnClaves);
            this.pnlBotonesM.Controls.Add(this.btnMensajes);
            this.pnlBotonesM.Controls.Add(this.btnPerfil);
            this.pnlBotonesM.Controls.Add(this.btnHome);
            this.pnlBotonesM.Controls.Add(this.panel3);
            this.pnlBotonesM.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotonesM.Location = new System.Drawing.Point(17, 0);
            this.pnlBotonesM.Name = "pnlBotonesM";
            this.pnlBotonesM.Size = new System.Drawing.Size(198, 579);
            this.pnlBotonesM.TabIndex = 2;
            // 
            // btnCerrarSesion1
            // 
            this.btnCerrarSesion1.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion1.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnCerrarSesion1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnCerrarSesion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion1.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion1.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion1.Image")));
            this.btnCerrarSesion1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion1.Location = new System.Drawing.Point(0, 475);
            this.btnCerrarSesion1.Name = "btnCerrarSesion1";
            this.btnCerrarSesion1.Size = new System.Drawing.Size(198, 74);
            this.btnCerrarSesion1.TabIndex = 4;
            this.btnCerrarSesion1.Text = "    Cerrar sesion";
            this.btnCerrarSesion1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion1.UseVisualStyleBackColor = false;
            this.btnCerrarSesion1.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCerrarSesion1.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 549);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(198, 30);
            this.panel4.TabIndex = 5;
            // 
            // btnClaves
            // 
            this.btnClaves.BackColor = System.Drawing.Color.Transparent;
            this.btnClaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClaves.FlatAppearance.BorderSize = 0;
            this.btnClaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnClaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaves.ForeColor = System.Drawing.Color.White;
            this.btnClaves.Image = ((System.Drawing.Image)(resources.GetObject("btnClaves.Image")));
            this.btnClaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaves.Location = new System.Drawing.Point(0, 252);
            this.btnClaves.Name = "btnClaves";
            this.btnClaves.Size = new System.Drawing.Size(198, 74);
            this.btnClaves.TabIndex = 3;
            this.btnClaves.Text = "    Seguridad";
            this.btnClaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClaves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClaves.UseVisualStyleBackColor = false;
            this.btnClaves.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnClaves.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnMensajes
            // 
            this.btnMensajes.BackColor = System.Drawing.Color.Transparent;
            this.btnMensajes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMensajes.FlatAppearance.BorderSize = 0;
            this.btnMensajes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnMensajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensajes.ForeColor = System.Drawing.Color.White;
            this.btnMensajes.Image = ((System.Drawing.Image)(resources.GetObject("btnMensajes.Image")));
            this.btnMensajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensajes.Location = new System.Drawing.Point(0, 178);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Size = new System.Drawing.Size(198, 74);
            this.btnMensajes.TabIndex = 2;
            this.btnMensajes.Text = "    Mensajes";
            this.btnMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMensajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMensajes.UseVisualStyleBackColor = false;
            this.btnMensajes.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnMensajes.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 104);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(198, 74);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "    Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnPerfil.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(198, 74);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "    Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 30);
            this.panel3.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Aqua;
            this.btnCerrarSesion.Location = new System.Drawing.Point(17, 557);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(198, 74);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnlBotonesM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBotonesM;
        private System.Windows.Forms.Button btnCerrarSesion1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClaves;
        private System.Windows.Forms.Button btnMensajes;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}