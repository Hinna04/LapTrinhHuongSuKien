
namespace ThucHanh3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_mabn = new System.Windows.Forms.ComboBox();
            this.rtb_nhan = new System.Windows.Forms.RichTextBox();
            this.rtb_dsdv = new System.Windows.Forms.RichTextBox();
            this.cb_dichvu = new System.Windows.Forms.ComboBox();
            this.tb_nam = new System.Windows.Forms.TextBox();
            this.tb_thang = new System.Windows.Forms.TextBox();
            this.tb_ngay = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_ketqua = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_mabn);
            this.groupBox1.Controls.Add(this.rtb_nhan);
            this.groupBox1.Controls.Add(this.rtb_dsdv);
            this.groupBox1.Controls.Add(this.cb_dichvu);
            this.groupBox1.Controls.Add(this.tb_nam);
            this.groupBox1.Controls.Add(this.tb_thang);
            this.groupBox1.Controls.Add(this.tb_ngay);
            this.groupBox1.Controls.Add(this.tb_ten);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Mã bệnh nhân";
            // 
            // cb_mabn
            // 
            this.cb_mabn.FormattingEnabled = true;
            this.cb_mabn.Location = new System.Drawing.Point(139, 33);
            this.cb_mabn.Name = "cb_mabn";
            this.cb_mabn.Size = new System.Drawing.Size(307, 28);
            this.cb_mabn.TabIndex = 0;
            this.cb_mabn.SelectedIndexChanged += new System.EventHandler(this.cb_mabn_SelectedIndexChanged);
            // 
            // rtb_nhan
            // 
            this.rtb_nhan.Location = new System.Drawing.Point(158, 255);
            this.rtb_nhan.Name = "rtb_nhan";
            this.rtb_nhan.Size = new System.Drawing.Size(104, 52);
            this.rtb_nhan.TabIndex = 4;
            this.rtb_nhan.Text = "";
            this.rtb_nhan.Visible = false;
            // 
            // rtb_dsdv
            // 
            this.rtb_dsdv.Location = new System.Drawing.Point(522, 176);
            this.rtb_dsdv.Name = "rtb_dsdv";
            this.rtb_dsdv.Size = new System.Drawing.Size(258, 199);
            this.rtb_dsdv.TabIndex = 3;
            this.rtb_dsdv.Text = "";
            this.rtb_dsdv.TextChanged += new System.EventHandler(this.rtb_dsdv_TextChanged);
            // 
            // cb_dichvu
            // 
            this.cb_dichvu.FormattingEnabled = true;
            this.cb_dichvu.Items.AddRange(new object[] {
            "Lăn kim",
            "Triệt lông",
            "Nâng mũi",
            "Cắt môi trái tim",
            "Cắt mí mắt",
            "Xăm lông mày",
            "Xăm môi"});
            this.cb_dichvu.Location = new System.Drawing.Point(139, 174);
            this.cb_dichvu.Name = "cb_dichvu";
            this.cb_dichvu.Size = new System.Drawing.Size(203, 28);
            this.cb_dichvu.TabIndex = 2;
            this.cb_dichvu.SelectedIndexChanged += new System.EventHandler(this.cb_dichvu_SelectedIndexChanged);
            // 
            // tb_nam
            // 
            this.tb_nam.Location = new System.Drawing.Point(381, 130);
            this.tb_nam.Name = "tb_nam";
            this.tb_nam.Size = new System.Drawing.Size(65, 26);
            this.tb_nam.TabIndex = 1;
            this.tb_nam.TextChanged += new System.EventHandler(this.tb_nam_TextChanged);
            // 
            // tb_thang
            // 
            this.tb_thang.Location = new System.Drawing.Point(230, 127);
            this.tb_thang.Name = "tb_thang";
            this.tb_thang.Size = new System.Drawing.Size(65, 26);
            this.tb_thang.TabIndex = 1;
            this.tb_thang.TextChanged += new System.EventHandler(this.tb_thang_TextChanged);
            // 
            // tb_ngay
            // 
            this.tb_ngay.Location = new System.Drawing.Point(59, 127);
            this.tb_ngay.Name = "tb_ngay";
            this.tb_ngay.Size = new System.Drawing.Size(65, 26);
            this.tb_ngay.TabIndex = 1;
            this.tb_ngay.TextChanged += new System.EventHandler(this.tb_ngay_TextChanged);
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(139, 84);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(307, 26);
            this.tb_ten.TabIndex = 1;
            this.tb_ten.TextChanged += new System.EventHandler(this.tb_ten_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh sách dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(150, 427);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(109, 40);
            this.btn_chon.TabIndex = 1;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.Location = new System.Drawing.Point(308, 427);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(109, 40);
            this.btn_tieptuc.TabIndex = 1;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.UseVisualStyleBackColor = true;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(464, 427);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(109, 40);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(20, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kết quả";
            // 
            // rtb_ketqua
            // 
            this.rtb_ketqua.Location = new System.Drawing.Point(24, 519);
            this.rtb_ketqua.Name = "rtb_ketqua";
            this.rtb_ketqua.Size = new System.Drawing.Size(768, 178);
            this.rtb_ketqua.TabIndex = 3;
            this.rtb_ketqua.Text = "";
            this.rtb_ketqua.TextChanged += new System.EventHandler(this.rtb_ketqua_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 721);
            this.Controls.Add(this.rtb_ketqua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Thẩm mỹ viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tb_nam;
        private System.Windows.Forms.TextBox tb_thang;
        private System.Windows.Forms.TextBox tb_ngay;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_dsdv;
        private System.Windows.Forms.ComboBox cb_dichvu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Button btn_tieptuc;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_ketqua;
        private System.Windows.Forms.RichTextBox rtb_nhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_mabn;
    }
}

