using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace FakeMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBoxAttachements.HorizontalScrollbar = true;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MailMessage();
                foreach (var item in listBoxAttachements.Items)
                {
                    message.Attachments.Add(new Attachment(item.ToString()));
                }
                message.Subject = tbSubject.Text;
                message.Body = tbContent.Text;
                message.From = new MailAddress(tbFrom.Text, tbName.Text);
                message.To.Add(tbTo.Text);

                var smtpClient = new SmtpClient();
                smtpClient.Host = tbSMTPIP.Text;
                smtpClient.Port = int.Parse(tbSMTPPort.Text);
                smtpClient.Send(message);
                MessageBox.Show("已成功发送");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件|*.*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径     
                listBoxAttachements.Items.Add(file);
            }
        }

        private void BtnDelAttachment_Click(object sender, EventArgs e)
        {
            if (listBoxAttachements.Items.Count > 0)
            {
                listBoxAttachements.Items.Remove(listBoxAttachements.SelectedItem);
            }
            
        }
    }
}
