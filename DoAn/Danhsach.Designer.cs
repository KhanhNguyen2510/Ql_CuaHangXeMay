
namespace DoAN
{
    partial class Danhsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Danhsach));
            this.btndsxe = new System.Windows.Forms.Button();
            this.btndscungcap = new System.Windows.Forms.Button();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.btnHoaDonXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndsxe
            // 
            this.btndsxe.Image = ((System.Drawing.Image)(resources.GetObject("btndsxe.Image")));
            this.btndsxe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndsxe.Location = new System.Drawing.Point(527, 12);
            this.btndsxe.Name = "btndsxe";
            this.btndsxe.Size = new System.Drawing.Size(177, 23);
            this.btndsxe.TabIndex = 0;
            this.btndsxe.Text = "Danh sách các loại xe ";
            this.btndsxe.UseVisualStyleBackColor = true;
            this.btndsxe.Click += new System.EventHandler(this.btndsxe_Click);
            // 
            // btndscungcap
            // 
            this.btndscungcap.Image = global::DoAN.Properties.Resources.iconfinder_edit_3218;
            this.btndscungcap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndscungcap.Location = new System.Drawing.Point(527, 72);
            this.btndscungcap.Name = "btndscungcap";
            this.btndscungcap.Size = new System.Drawing.Size(177, 23);
            this.btndscungcap.TabIndex = 1;
            this.btndscungcap.Text = "Danh sách các nhà cung cấp";
            this.btndscungcap.UseVisualStyleBackColor = true;
            this.btndscungcap.Click += new System.EventHandler(this.btndscungcap_Click);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.Image = global::DoAN.Properties.Resources.iconfinder_edit_3218;
            this.btnHoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(527, 135);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(177, 23);
            this.btnHoaDonNhap.TabIndex = 2;
            this.btnHoaDonNhap.Text = "Danh sách hóa đơn nhập kho";
            this.btnHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnHoaDonXuat
            // 
            this.btnHoaDonXuat.Image = global::DoAN.Properties.Resources.iconfinder_edit_3218;
            this.btnHoaDonXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonXuat.Location = new System.Drawing.Point(527, 191);
            this.btnHoaDonXuat.Name = "btnHoaDonXuat";
            this.btnHoaDonXuat.Size = new System.Drawing.Size(177, 23);
            this.btnHoaDonXuat.TabIndex = 3;
            this.btnHoaDonXuat.Text = "Danh sách hóa đơn bán hàng";
            this.btnHoaDonXuat.UseVisualStyleBackColor = true;
            this.btnHoaDonXuat.Click += new System.EventHandler(this.btnHoaDonXuat_Click);
            // 
            // Danhsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.btnHoaDonXuat);
            this.Controls.Add(this.btnHoaDonNhap);
            this.Controls.Add(this.btndscungcap);
            this.Controls.Add(this.btndsxe);
            this.Name = "Danhsach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn nhập kho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndsxe;
        private System.Windows.Forms.Button btndscungcap;
        private System.Windows.Forms.Button btnHoaDonNhap;
        private System.Windows.Forms.Button btnHoaDonXuat;
    }
}