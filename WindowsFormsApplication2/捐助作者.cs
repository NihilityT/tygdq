﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TYGDQ
{
    public partial class 捐助作者 : Form
    {
        public 捐助作者()
        {
            InitializeComponent();
        }

        private void Jump(string str)
        {
            try
            {
                Process.Start(str);
            }
            catch (Exception ex)
            {

            }
        }
        private DateTime Start = new DateTime(2012, 3, 20);
        private void 捐助作者_Load(object sender, EventArgs e)
        {
            var ts = DateTime.Now - Start;
            lblInfo.Text = string.Format("添雨跟打器从{0}至今已经更新了{1}天", Start.ToShortDateString(),
                                         ts.TotalDays.ToString("0.00"));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Clipboard.SetDataObject("taliove@vip.qq.com", true, 200, 3);
            }
            catch (Exception ex)
            {
                //TyLogModel.Instance.WriteLog(LogType.ClipboardError, ex);
            }
            //            this.Jump("https://me.alipay.com/taliove");
            var result = MessageBox.Show(this, "通过支付宝捐助我，支付宝账号：taliove@vip.qq.com，已复制至剪切板，感谢您的捐助！\n点击“是”，跳转至支付宝转款页面。", "捐助", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Jump("https://shenghuo.alipay.com/send/payment/fill.htm");
            }
        }
    }
}
