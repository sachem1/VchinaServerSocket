using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VchinaServerSocket
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            //加载ip 
            var ipStr = ConfigurationManager.AppSettings["ipSetting"];
            if (!string.IsNullOrEmpty(ipStr))
            {
                var ipArr = ipStr.Split(',');
                var port = ConfigurationManager.AppSettings["port"];
                cbbIP.DataSource = ipArr;
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            //启动服务
            var ip = cbbIP.SelectedValue.ToString();
            var port = txtPort.Text.ToString();

        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            //停止服务

        }
    }
}
