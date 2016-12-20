namespace FrmLogin
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRekap = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCabut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvSuara = new System.Windows.Forms.DataGridView();
            this.nomor_calon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suara_masuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu_suara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuara)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.btnRekap, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnInput, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCabut, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 109);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(204, 310);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 39);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "selesai";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRekap
            // 
            this.btnRekap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRekap.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRekap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRekap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRekap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRekap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekap.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekap.Location = new System.Drawing.Point(13, 198);
            this.btnRekap.Name = "btnRekap";
            this.btnRekap.Size = new System.Drawing.Size(178, 39);
            this.btnRekap.TabIndex = 16;
            this.btnRekap.Text = "rekap";
            this.btnRekap.UseVisualStyleBackColor = false;
            this.btnRekap.Click += new System.EventHandler(this.btnRekap_Click);
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInput.BackColor = System.Drawing.Color.PaleGreen;
            this.btnInput.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInput.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(13, 88);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(178, 39);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Input suara";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCabut
            // 
            this.btnCabut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCabut.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCabut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCabut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCabut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCabut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabut.Font = new System.Drawing.Font("Bebas Neue Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabut.Location = new System.Drawing.Point(13, 143);
            this.btnCabut.Name = "btnCabut";
            this.btnCabut.Size = new System.Drawing.Size(178, 39);
            this.btnCabut.TabIndex = 10;
            this.btnCabut.Text = "Cabut suara [F3]";
            this.btnCabut.UseVisualStyleBackColor = false;
            this.btnCabut.Click += new System.EventHandler(this.btnCabut_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.dgvSuara);
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Location = new System.Drawing.Point(222, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 477);
            this.panel4.TabIndex = 3;
            // 
            // dgvSuara
            // 
            this.dgvSuara.AllowUserToAddRows = false;
            this.dgvSuara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuara.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvSuara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomor_calon,
            this.suara_masuk,
            this.waktu_suara});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PF Encore Sans Pro Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuara.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuara.GridColor = System.Drawing.Color.White;
            this.dgvSuara.Location = new System.Drawing.Point(15, 17);
            this.dgvSuara.Name = "dgvSuara";
            this.dgvSuara.RowTemplate.Height = 24;
            this.dgvSuara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuara.Size = new System.Drawing.Size(574, 444);
            this.dgvSuara.TabIndex = 1;
            // 
            // nomor_calon
            // 
            this.nomor_calon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomor_calon.DataPropertyName = "nomor_calon";
            this.nomor_calon.HeaderText = "NOMOR CALON";
            this.nomor_calon.Name = "nomor_calon";
            // 
            // suara_masuk
            // 
            this.suara_masuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.suara_masuk.DataPropertyName = "suara_masuk";
            this.suara_masuk.HeaderText = "JUMLAH SUARA";
            this.suara_masuk.Name = "suara_masuk";
            // 
            // waktu_suara
            // 
            this.waktu_suara.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waktu_suara.DataPropertyName = "waktu_suara";
            this.waktu_suara.HeaderText = "WAKTU MASUK/KELUAR SUARA";
            this.waktu_suara.Name = "waktu_suara";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(609, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 236);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Suara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 183);
            this.panel3.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("PF Encore Sans Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(64, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 67);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FrmLogin.Properties.Resources.Layout_IMKxx;
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(12, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 161);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Location = new System.Drawing.Point(5, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 86);
            this.panel2.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("PF Encore Sans Pro Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(-5, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(192, 47);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("PF Encore Sans Pro Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(9, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(166, 31);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "dd-mm-yyyy";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FrmLogin.Properties.Resources.Layout_IMK_Jam;
            this.pictureBox3.Location = new System.Drawing.Point(7, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(162, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::FrmLogin.Properties.Resources.Layout_IMK_Menu;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1057, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "APLIKASI PENGHITUNG SUARA PEMILU (BETA V1.0)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuara)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCabut;
        private System.Windows.Forms.Button btnRekap;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvSuara;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_calon;
        private System.Windows.Forms.DataGridViewTextBoxColumn suara_masuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu_suara;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}