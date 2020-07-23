namespace Capa_view
{
    partial class frmpublicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbidpubli = new System.Windows.Forms.ComboBox();
            this.dtpubli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtpubli)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 18);
            this.label1.TabIndex = 136;
            this.label1.Text = "¡Da un click para ver comentarios asociados a una publicacion";
            // 
            // cbidpubli
            // 
            this.cbidpubli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbidpubli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbidpubli.FormattingEnabled = true;
            this.cbidpubli.Location = new System.Drawing.Point(177, 117);
            this.cbidpubli.Name = "cbidpubli";
            this.cbidpubli.Size = new System.Drawing.Size(200, 21);
            this.cbidpubli.TabIndex = 135;
            this.cbidpubli.SelectedIndexChanged += new System.EventHandler(this.cbidpubli_SelectedIndexChanged);
            // 
            // dtpubli
            // 
            this.dtpubli.AllowUserToAddRows = false;
            this.dtpubli.AllowUserToDeleteRows = false;
            this.dtpubli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpubli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtpubli.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpubli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtpubli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpubli.Location = new System.Drawing.Point(80, 214);
            this.dtpubli.Name = "dtpubli";
            this.dtpubli.ReadOnly = true;
            this.dtpubli.RowHeadersVisible = false;
            this.dtpubli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtpubli.Size = new System.Drawing.Size(424, 137);
            this.dtpubli.TabIndex = 134;
            // 
            // frmpublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbidpubli);
            this.Controls.Add(this.dtpubli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmpublicacion";
            this.Text = "frmpublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.dtpubli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbidpubli;
        private System.Windows.Forms.DataGridView dtpubli;
    }
}