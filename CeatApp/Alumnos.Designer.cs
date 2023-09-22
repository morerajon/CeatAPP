﻿namespace CeatApp
{
    partial class Alumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAlumnos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeight = 20;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlumnos.Location = new System.Drawing.Point(15, 36);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAlumnos.Size = new System.Drawing.Size(858, 633);
            this.dgvAlumnos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnBorrarAlumno);
            this.panel1.Controls.Add(this.btnModificarAlumno);
            this.panel1.Controls.Add(this.btnNuevoAlumno);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(877, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 692);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(0, 386);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(204, 48);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "  Buscar Alumno";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrarAlumno.FlatAppearance.BorderSize = 0;
            this.btnBorrarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnBorrarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnBorrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBorrarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarAlumno.Image")));
            this.btnBorrarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarAlumno.Location = new System.Drawing.Point(0, 338);
            this.btnBorrarAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(204, 48);
            this.btnBorrarAlumno.TabIndex = 3;
            this.btnBorrarAlumno.Text = "  Borrar Alumno";
            this.btnBorrarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarAlumno.FlatAppearance.BorderSize = 0;
            this.btnModificarAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnModificarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnModificarAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarAlumno.Image")));
            this.btnModificarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlumno.Location = new System.Drawing.Point(0, 290);
            this.btnModificarAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(204, 48);
            this.btnModificarAlumno.TabIndex = 2;
            this.btnModificarAlumno.Text = "  Modificar Alumno";
            this.btnModificarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarAlumno.UseVisualStyleBackColor = false;
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoAlumno.FlatAppearance.BorderSize = 0;
            this.btnNuevoAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnNuevoAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btnNuevoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAlumno.ForeColor = System.Drawing.Color.White;
            this.btnNuevoAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoAlumno.Image")));
            this.btnNuevoAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAlumno.Location = new System.Drawing.Point(0, 242);
            this.btnNuevoAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(204, 48);
            this.btnNuevoAlumno.TabIndex = 1;
            this.btnNuevoAlumno.Text = "  Nuevo Alumno";
            this.btnNuevoAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoAlumno.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 242);
            this.panel2.TabIndex = 5;
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1081, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "228; 229; 233";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.Panel panel2;
    }
}