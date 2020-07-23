namespace Capa_view
{
    partial class frmmenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.pane_lateral = new System.Windows.Forms.Panel();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnpubli = new System.Windows.Forms.Button();
            this.panelconten = new System.Windows.Forms.Panel();
            this.pane_lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pane_lateral
            // 
            this.pane_lateral.Controls.Add(this.btnpubli);
            this.pane_lateral.Controls.Add(this.btnuser);
            this.pane_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pane_lateral.Location = new System.Drawing.Point(0, 0);
            this.pane_lateral.Name = "pane_lateral";
            this.pane_lateral.Size = new System.Drawing.Size(200, 450);
            this.pane_lateral.TabIndex = 0;
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(7)))), ((int)(((byte)(114)))));
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.btnuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(3, 154);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(197, 39);
            this.btnuser.TabIndex = 6;
            this.btnuser.Text = "usuarios";
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnpubli
            // 
            this.btnpubli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(7)))), ((int)(((byte)(114)))));
            this.btnpubli.FlatAppearance.BorderSize = 0;
            this.btnpubli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.btnpubli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(45)))), ((int)(((byte)(212)))));
            this.btnpubli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpubli.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpubli.ForeColor = System.Drawing.SystemColors.Control;
            this.btnpubli.Image = ((System.Drawing.Image)(resources.GetObject("btnpubli.Image")));
            this.btnpubli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpubli.Location = new System.Drawing.Point(3, 255);
            this.btnpubli.Name = "btnpubli";
            this.btnpubli.Size = new System.Drawing.Size(197, 46);
            this.btnpubli.TabIndex = 7;
            this.btnpubli.Text = "Publicaciones";
            this.btnpubli.UseVisualStyleBackColor = false;
            this.btnpubli.Click += new System.EventHandler(this.btnpubli_Click);
            // 
            // panelconten
            // 
            this.panelconten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconten.Location = new System.Drawing.Point(200, 0);
            this.panelconten.Name = "panelconten";
            this.panelconten.Size = new System.Drawing.Size(600, 450);
            this.panelconten.TabIndex = 1;
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelconten);
            this.Controls.Add(this.pane_lateral);
            this.Name = "frmmenu";
            this.Text = "Form1";
            this.pane_lateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pane_lateral;
        private System.Windows.Forms.Button btnpubli;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Panel panelconten;
    }
}

