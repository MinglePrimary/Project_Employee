namespace _18110157_LyDucMinh
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
            this.btSet = new System.Windows.Forms.Button();
            this.btDis = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtHuman = new System.Windows.Forms.TextBox();
            this.lblDis = new System.Windows.Forms.Label();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSet
            // 
            this.btSet.Location = new System.Drawing.Point(354, 25);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(75, 23);
            this.btSet.TabIndex = 0;
            this.btSet.Text = "Nhập";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // btDis
            // 
            this.btDis.Location = new System.Drawing.Point(449, 25);
            this.btDis.Name = "btDis";
            this.btDis.Size = new System.Drawing.Size(75, 23);
            this.btDis.TabIndex = 1;
            this.btDis.Text = "Hiển thị";
            this.btDis.UseVisualStyleBackColor = true;
            this.btDis.Click += new System.EventHandler(this.btDis_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(50, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Nhập Data";
            // 
            // txtHuman
            // 
            this.txtHuman.Location = new System.Drawing.Point(148, 27);
            this.txtHuman.Name = "txtHuman";
            this.txtHuman.Size = new System.Drawing.Size(189, 20);
            this.txtHuman.TabIndex = 3;
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Location = new System.Drawing.Point(50, 77);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(67, 13);
            this.lblDis.TabIndex = 4;
            this.lblDis.Text = "Dữ liệu nhập";
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Location = new System.Drawing.Point(50, 131);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(54, 13);
            this.lblHienThi.TabIndex = 5;
            this.lblHienThi.Text = "Thống Kê";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(546, 25);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Lưu Data";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(546, 131);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 323);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.txtHuman);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btDis);
            this.Controls.Add(this.btSet);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.Button btDis;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtHuman;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
    }
}

