
namespace PdfJoin
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHattyuFile = new System.Windows.Forms.TextBox();
            this.btnHattyu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHImgY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbHImgX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbHImg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMImg2Y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMImg2X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMImg1Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMImg1X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMImg1 = new System.Windows.Forms.TextBox();
            this.tbMImg2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMitumori = new System.Windows.Forms.Button();
            this.tbMtumoriFile = new System.Windows.Forms.TextBox();
            this.btnJoinImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMSaveFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbHSaveFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHattyuFile
            // 
            this.tbHattyuFile.Location = new System.Drawing.Point(94, 41);
            this.tbHattyuFile.Name = "tbHattyuFile";
            this.tbHattyuFile.Size = new System.Drawing.Size(576, 23);
            this.tbHattyuFile.TabIndex = 0;
            // 
            // btnHattyu
            // 
            this.btnHattyu.Location = new System.Drawing.Point(676, 40);
            this.btnHattyu.Name = "btnHattyu";
            this.btnHattyu.Size = new System.Drawing.Size(64, 23);
            this.btnHattyu.TabIndex = 1;
            this.btnHattyu.Text = "参照";
            this.btnHattyu.UseVisualStyleBackColor = true;
            this.btnHattyu.Click += new System.EventHandler(this.btnOpenPdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbHSaveFile);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbHImgY);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbHImgX);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbHImg);
            this.groupBox3.Location = new System.Drawing.Point(8, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 106);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "発注書";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Y位置";
            // 
            // tbHImgY
            // 
            this.tbHImgY.Location = new System.Drawing.Point(435, 29);
            this.tbHImgY.Name = "tbHImgY";
            this.tbHImgY.Size = new System.Drawing.Size(94, 23);
            this.tbHImgY.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "X位置";
            // 
            // tbHImgX
            // 
            this.tbHImgX.Location = new System.Drawing.Point(289, 29);
            this.tbHImgX.Name = "tbHImgX";
            this.tbHImgX.Size = new System.Drawing.Size(95, 23);
            this.tbHImgX.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "画像";
            // 
            // tbHImg
            // 
            this.tbHImg.Location = new System.Drawing.Point(62, 29);
            this.tbHImg.Name = "tbHImg";
            this.tbHImg.Size = new System.Drawing.Size(171, 23);
            this.tbHImg.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbMSaveFile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbMImg2Y);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbMImg2X);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMImg1Y);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbMImg1X);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbMImg1);
            this.groupBox2.Controls.Add(this.tbMImg2);
            this.groupBox2.Location = new System.Drawing.Point(8, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 127);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "見積もり";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y位置";
            // 
            // tbMImg2Y
            // 
            this.tbMImg2Y.Location = new System.Drawing.Point(435, 58);
            this.tbMImg2Y.Name = "tbMImg2Y";
            this.tbMImg2Y.Size = new System.Drawing.Size(94, 23);
            this.tbMImg2Y.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "X位置";
            // 
            // tbMImg2X
            // 
            this.tbMImg2X.Location = new System.Drawing.Point(289, 58);
            this.tbMImg2X.Name = "tbMImg2X";
            this.tbMImg2X.Size = new System.Drawing.Size(95, 23);
            this.tbMImg2X.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y位置";
            // 
            // tbMImg1Y
            // 
            this.tbMImg1Y.Location = new System.Drawing.Point(435, 29);
            this.tbMImg1Y.Name = "tbMImg1Y";
            this.tbMImg1Y.Size = new System.Drawing.Size(94, 23);
            this.tbMImg1Y.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "X位置";
            // 
            // tbMImg1X
            // 
            this.tbMImg1X.Location = new System.Drawing.Point(289, 29);
            this.tbMImg1X.Name = "tbMImg1X";
            this.tbMImg1X.Size = new System.Drawing.Size(95, 23);
            this.tbMImg1X.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "画像";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "画像";
            // 
            // tbMImg1
            // 
            this.tbMImg1.Location = new System.Drawing.Point(62, 29);
            this.tbMImg1.Name = "tbMImg1";
            this.tbMImg1.Size = new System.Drawing.Size(171, 23);
            this.tbMImg1.TabIndex = 6;
            // 
            // tbMImg2
            // 
            this.tbMImg2.Location = new System.Drawing.Point(62, 58);
            this.tbMImg2.Name = "tbMImg2";
            this.tbMImg2.Size = new System.Drawing.Size(171, 23);
            this.tbMImg2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "発注書";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "見積もり";
            // 
            // btnMitumori
            // 
            this.btnMitumori.Location = new System.Drawing.Point(676, 11);
            this.btnMitumori.Name = "btnMitumori";
            this.btnMitumori.Size = new System.Drawing.Size(64, 23);
            this.btnMitumori.TabIndex = 7;
            this.btnMitumori.Text = "参照";
            this.btnMitumori.UseVisualStyleBackColor = true;
            this.btnMitumori.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMtumoriFile
            // 
            this.tbMtumoriFile.Location = new System.Drawing.Point(94, 12);
            this.tbMtumoriFile.Name = "tbMtumoriFile";
            this.tbMtumoriFile.Size = new System.Drawing.Size(576, 23);
            this.tbMtumoriFile.TabIndex = 6;
            // 
            // btnJoinImage
            // 
            this.btnJoinImage.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnJoinImage.Location = new System.Drawing.Point(564, 365);
            this.btnJoinImage.Name = "btnJoinImage";
            this.btnJoinImage.Size = new System.Drawing.Size(176, 62);
            this.btnJoinImage.TabIndex = 9;
            this.btnJoinImage.Text = "印鑑追加";
            this.btnJoinImage.UseVisualStyleBackColor = true;
            this.btnJoinImage.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "保存ファイル名";
            // 
            // tbMSaveFile
            // 
            this.tbMSaveFile.Location = new System.Drawing.Point(95, 87);
            this.tbMSaveFile.Name = "tbMSaveFile";
            this.tbMSaveFile.Size = new System.Drawing.Size(171, 23);
            this.tbMSaveFile.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "保存ファイル名";
            // 
            // tbHSaveFile
            // 
            this.tbHSaveFile.Location = new System.Drawing.Point(98, 68);
            this.tbHSaveFile.Name = "tbHSaveFile";
            this.tbHSaveFile.Size = new System.Drawing.Size(171, 23);
            this.tbHSaveFile.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(623, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 439);
            this.Controls.Add(this.btnJoinImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMitumori);
            this.Controls.Add(this.tbMtumoriFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHattyu);
            this.Controls.Add(this.tbHattyuFile);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "印鑑追加";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHattyuFile;
        private System.Windows.Forms.Button btnHattyu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMImg2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMImg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMitumori;
        private System.Windows.Forms.TextBox tbMtumoriFile;
        private System.Windows.Forms.Button btnJoinImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMImg1X;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHImgY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbHImgX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbHImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMImg2Y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMImg2X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMImg1Y;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbHSaveFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMSaveFile;
        private System.Windows.Forms.Button btnSave;
    }
}

