namespace FakeMail
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbSMTPIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSMTPPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.listBoxAttachements = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddAttachment = new System.Windows.Forms.Button();
            this.btnDelAttachment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSMTPIP
            // 
            this.tbSMTPIP.Location = new System.Drawing.Point(183, 13);
            this.tbSMTPIP.Name = "tbSMTPIP";
            this.tbSMTPIP.Size = new System.Drawing.Size(318, 31);
            this.tbSMTPIP.TabIndex = 0;
            this.tbSMTPIP.Text = "mail.test.local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "smtp server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // tbSMTPPort
            // 
            this.tbSMTPPort.Location = new System.Drawing.Point(531, 13);
            this.tbSMTPPort.Name = "tbSMTPPort";
            this.tbSMTPPort.Size = new System.Drawing.Size(78, 31);
            this.tbSMTPPort.TabIndex = 3;
            this.tbSMTPPort.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(426, 31);
            this.tbName.TabIndex = 5;
            this.tbName.Text = "admin";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(143, 129);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(426, 31);
            this.tbFrom.TabIndex = 7;
            this.tbFrom.Text = "admin@test.local";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "from";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(143, 181);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(426, 31);
            this.tbTo.TabIndex = 9;
            this.tbTo.Text = "user1@test.local";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "to";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(143, 235);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(426, 31);
            this.tbSubject.TabIndex = 11;
            this.tbSubject.Text = "主题";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "subject";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(143, 295);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(426, 331);
            this.tbContent.TabIndex = 13;
            this.tbContent.Text = "正文";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "content";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(143, 661);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(426, 73);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // listBoxAttachements
            // 
            this.listBoxAttachements.FormattingEnabled = true;
            this.listBoxAttachements.ItemHeight = 25;
            this.listBoxAttachements.Location = new System.Drawing.Point(631, 104);
            this.listBoxAttachements.Name = "listBoxAttachements";
            this.listBoxAttachements.Size = new System.Drawing.Size(458, 529);
            this.listBoxAttachements.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "附件列表";
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Location = new System.Drawing.Point(1133, 104);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(165, 69);
            this.btnAddAttachment.TabIndex = 17;
            this.btnAddAttachment.Text = "添加附件";
            this.btnAddAttachment.UseVisualStyleBackColor = true;
            this.btnAddAttachment.Click += new System.EventHandler(this.BtnAddAttachment_Click);
            // 
            // btnDelAttachment
            // 
            this.btnDelAttachment.Location = new System.Drawing.Point(1133, 216);
            this.btnDelAttachment.Name = "btnDelAttachment";
            this.btnDelAttachment.Size = new System.Drawing.Size(165, 69);
            this.btnDelAttachment.TabIndex = 18;
            this.btnDelAttachment.Text = "删除选定附件";
            this.btnDelAttachment.UseVisualStyleBackColor = true;
            this.btnDelAttachment.Click += new System.EventHandler(this.BtnDelAttachment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 756);
            this.Controls.Add(this.btnDelAttachment);
            this.Controls.Add(this.btnAddAttachment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxAttachements);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSMTPPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSMTPIP);
            this.Name = "Form1";
            this.Text = "伪造邮件发送器  https://github.com/abcdlzy/FakeMail ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSMTPIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSMTPPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listBoxAttachements;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.Button btnDelAttachment;
    }
}

