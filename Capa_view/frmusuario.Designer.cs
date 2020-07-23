namespace Capa_view
{
    partial class frmusuario
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
            this.dtusuario = new System.Windows.Forms.DataGridView();
            this.cbnomuser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtusuario
            // 
            this.dtusuario.AllowUserToAddRows = false;
            this.dtusuario.AllowUserToDeleteRows = false;
            this.dtusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtusuario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtusuario.Location = new System.Drawing.Point(84, 212);
            this.dtusuario.Name = "dtusuario";
            this.dtusuario.ReadOnly = true;
            this.dtusuario.RowHeadersVisible = false;
            this.dtusuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtusuario.Size = new System.Drawing.Size(424, 137);
            this.dtusuario.TabIndex = 129;
            // 
            // cbnomuser
            // 
            this.cbnomuser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbnomuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnomuser.FormattingEnabled = true;
            this.cbnomuser.Location = new System.Drawing.Point(177, 105);
            this.cbnomuser.Name = "cbnomuser";
            this.cbnomuser.Size = new System.Drawing.Size(200, 21);
            this.cbnomuser.TabIndex = 130;
            this.cbnomuser.SelectedIndexChanged += new System.EventHandler(this.cbnomuser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 18);
            this.label1.TabIndex = 133;
            this.label1.Text = "¡Da un click para ver publicaciones asociados a un usuario";
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbnomuser);
            this.Controls.Add(this.dtusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmusuario";
            this.Text = "frmusuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtusuario;
        private System.Windows.Forms.ComboBox cbnomuser;
        private System.Windows.Forms.Label label1;
    }
}