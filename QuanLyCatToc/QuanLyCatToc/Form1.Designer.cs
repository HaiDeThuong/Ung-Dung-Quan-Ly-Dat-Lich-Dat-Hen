namespace QuanLyCatToc
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.dgvDanhSachLich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLich)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỆ THỐNG ĐẶT LỊCH CẮT TÓC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(388, 39);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(100, 22);
            this.txtTenKhach.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(135, 42);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(100, 22);
            this.txtSoDienThoai.TabIndex = 4;
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHen.Location = new System.Drawing.Point(12, 90);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayHen.TabIndex = 5;
            // 
            // cbDichVu
            // 
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(261, 73);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(121, 24);
            this.cbDichVu.TabIndex = 6;
            // 
            // btnDatLich
            // 
            this.btnDatLich.Location = new System.Drawing.Point(307, 124);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(75, 23);
            this.btnDatLich.TabIndex = 7;
            this.btnDatLich.Text = "Đặt Lịch";
            this.btnDatLich.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachLich
            // 
            this.dgvDanhSachLich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLich.Location = new System.Drawing.Point(32, 188);
            this.dgvDanhSachLich.Name = "dgvDanhSachLich";
            this.dgvDanhSachLich.RowHeadersWidth = 51;
            this.dgvDanhSachLich.RowTemplate.Height = 24;
            this.dgvDanhSachLich.Size = new System.Drawing.Size(516, 150);
            this.dgvDanhSachLich.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDanhSachLich);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.cbDichVu);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.DataGridView dgvDanhSachLich;
    }
}

