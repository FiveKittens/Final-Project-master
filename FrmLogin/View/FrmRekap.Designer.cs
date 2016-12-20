namespace FrmLogin.View
{
    partial class FrmRekap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRekap));
            this.button4 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvRekap = new System.Windows.Forms.DataGridView();
            this.PrintDataGridView = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.nama_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomor_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suara_masuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_suara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(444, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "SELESAI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Bebas Neue Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(0, 250);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(444, 43);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(0, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(444, 43);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "CABUT SUARA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInput.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInput.FlatAppearance.BorderSize = 0;
            this.btnInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(0, 153);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(444, 43);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "INPUT SUARA";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.PaleGreen;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 104);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(444, 43);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::FrmLogin.Properties.Resources.Layout_IMK_Menu;
            this.pictureBox2.Location = new System.Drawing.Point(0, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dgvRekap
            // 
            this.dgvRekap.AllowUserToAddRows = false;
            this.dgvRekap.AllowUserToResizeColumns = false;
            this.dgvRekap.AllowUserToResizeRows = false;
            this.dgvRekap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRekap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRekap.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRekap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRekap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRekap.ColumnHeadersHeight = 42;
            this.dgvRekap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_calon,
            this.nomor_calon,
            this.suara_masuk,
            this.waktu_suara});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRekap.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRekap.Location = new System.Drawing.Point(447, 0);
            this.dgvRekap.Name = "dgvRekap";
            this.dgvRekap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRekap.RowTemplate.Height = 24;
            this.dgvRekap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRekap.Size = new System.Drawing.Size(407, 516);
            this.dgvRekap.TabIndex = 1;
            // 
            // PrintDataGridView
            // 
            this.PrintDataGridView.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintDataGridView.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintDataGridView.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintDataGridView.Enabled = true;
            this.PrintDataGridView.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintDataGridView.Icon")));
            this.PrintDataGridView.Name = "PrintDataGridView";
            this.PrintDataGridView.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(229, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 705);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.dgvRekap);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(65, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 516);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.lblJam);
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 157);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnInput);
            this.panel4.Location = new System.Drawing.Point(0, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 357);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrmLogin.Properties.Resources.Layout_IMK_Jam;
            this.pictureBox1.Location = new System.Drawing.Point(0, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("PF Encore Sans Pro", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(134, 80);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(163, 30);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "dd-mm-yyyy";
            // 
            // lblJam
            // 
            this.lblJam.AutoSize = true;
            this.lblJam.Font = new System.Drawing.Font("PF Encore Sans Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJam.ForeColor = System.Drawing.Color.DimGray;
            this.lblJam.Location = new System.Drawing.Point(118, 111);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(184, 45);
            this.lblJam.TabIndex = 2;
            this.lblJam.Text = "00:00:00";
            // 
            // nama_calon
            // 
            this.nama_calon.DataPropertyName = "nama_calon";
            this.nama_calon.FillWeight = 169.474F;
            this.nama_calon.HeaderText = "NAMA CALON TERPILIH";
            this.nama_calon.Name = "nama_calon";
            // 
            // nomor_calon
            // 
            this.nomor_calon.DataPropertyName = "nomor_calon";
            this.nomor_calon.FillWeight = 30.59523F;
            this.nomor_calon.HeaderText = "NOMOR CALON";
            this.nomor_calon.Name = "nomor_calon";
            // 
            // suara_masuk
            // 
            this.suara_masuk.DataPropertyName = "suara_masuk";
            this.suara_masuk.FillWeight = 30.45685F;
            this.suara_masuk.HeaderText = "JUMLAH SUARA";
            this.suara_masuk.Name = "suara_masuk";
            // 
            // waktu_suara
            // 
            this.waktu_suara.DataPropertyName = "waktu_suara";
            this.waktu_suara.FillWeight = 169.474F;
            this.waktu_suara.HeaderText = "WAKTU SUARA MASUK/KELUAR";
            this.waktu_suara.Name = "waktu_suara";
            // 
            // FrmRekap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmLogin.Properties.Resources.Layout_IMK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 929);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmRekap";
            this.Text = "APLIKASI PENGHITUNG SUARA PEMILU (BETA V1.0)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvRekap;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog PrintDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn suara_masuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_suara;
    }
}