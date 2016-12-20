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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRekap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvRekap = new System.Windows.Forms.DataGridView();
            this.nama_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomor_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suara_masuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_suara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintDataGridView = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvCalon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnInput, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "SELESAI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Bebas Neue Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(13, 253);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(178, 39);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(13, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "CABUT SUARA";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInput.FlatAppearance.BorderSize = 0;
            this.btnInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(13, 143);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(178, 39);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "INPUT SUARA";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.PaleGreen;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(13, 88);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(178, 39);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::FrmLogin.Properties.Resources.Layout_IMK_Menu;
            this.pictureBox2.Location = new System.Drawing.Point(13, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dgvRekap
            // 
            this.dgvRekap.AllowUserToAddRows = false;
            this.dgvRekap.AllowUserToResizeColumns = false;
            this.dgvRekap.AllowUserToResizeRows = false;
            this.dgvRekap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRekap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRekap.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRekap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRekap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRekap.ColumnHeadersHeight = 42;
            this.dgvRekap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_calon,
            this.nomor_calon,
            this.suara_masuk,
            this.waktu_suara});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRekap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRekap.Location = new System.Drawing.Point(794, 164);
            this.dgvRekap.Name = "dgvRekap";
            this.dgvRekap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRekap.RowTemplate.Height = 24;
            this.dgvRekap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRekap.Size = new System.Drawing.Size(867, 500);
            this.dgvRekap.TabIndex = 1;
            // 
            // nama_calon
            // 
            this.nama_calon.DataPropertyName = "nama_calon";
            this.nama_calon.HeaderText = "NAMA CALON TERPILIH";
            this.nama_calon.Name = "nama_calon";
            // 
            // nomor_calon
            // 
            this.nomor_calon.DataPropertyName = "nomor_calon";
            this.nomor_calon.HeaderText = "NOMOR CALON";
            this.nomor_calon.Name = "nomor_calon";
            // 
            // suara_masuk
            // 
            this.suara_masuk.DataPropertyName = "suara_masuk";
            this.suara_masuk.HeaderText = "JUMLAH SUARA";
            this.suara_masuk.Name = "suara_masuk";
            // 
            // waktu_suara
            // 
            this.waktu_suara.DataPropertyName = "waktu_suara";
            this.waktu_suara.HeaderText = "WAKTU SUARA MASUK/KELUAR";
            this.waktu_suara.Name = "waktu_suara";
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FrmLogin.Properties.Resources.Layout_IMKxzx;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1649, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgvCalon
            // 
            this.dgvCalon.AllowUserToAddRows = false;
            this.dgvCalon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalon.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCalon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalon.ColumnHeadersHeight = 42;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCalon.Location = new System.Drawing.Point(269, 164);
            this.dgvCalon.Name = "dgvCalon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCalon.RowTemplate.Height = 24;
            this.dgvCalon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalon.Size = new System.Drawing.Size(493, 500);
            this.dgvCalon.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(270, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATA CALON";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bebas Neue Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(802, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATA PEROLEHAN SUARA";
            // 
            // FrmRekap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmLogin.Properties.Resources.Layout_IMK;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 676);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCalon);
            this.Controls.Add(this.dgvRekap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmRekap";
            this.Text = "APLIKASI PENGHITUNG SUARA PEMILU (BETA V1.0)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvRekap;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog PrintDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvCalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn suara_masuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_suara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}