namespace WP_2020
{
    partial class frmGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.bt_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("新細明體", 40F);
            this.btnDraw.Location = new System.Drawing.Point(343, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(250, 80);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "抽牌";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(343, 188);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(250, 250);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(39, 12);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(258, 426);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("新細明體", 40F);
            this.bt_reset.Location = new System.Drawing.Point(343, 98);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(250, 80);
            this.bt_reset.TabIndex = 4;
            this.bt_reset.Text = "洗牌";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnDraw);
            this.Name = "frmGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button bt_reset;
    }
}

