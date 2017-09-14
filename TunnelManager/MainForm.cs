using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TunnelManager.UserManager;
using TunnelManager.SearchAndReport;
using TunnelManager.SearchAndReport.CO;
using TunnelManager.SearchAndReport.VI;
using TunnelManager.SearchAndReport.Fan;
using TunnelManager.SearchAndReport.FCMS;
using TunnelManager.SearchAndReport.Command;
using TunnelManager.SearchAndReport.Breakdown;
using TunnelManager.SearchAndReport.Alarm;
using TunnelManager.SearchAndReport.Manual;

namespace TunnelManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 登陆LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 人员管理UToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserManagment f = new UserManagment();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 一氧化碳详情查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CO_Search f = new CO_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 一氧化碳日报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CO_DayReport f = new CO_DayReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 一氧化碳月报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CO_MonthReport f = new CO_MonthReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 一氧化碳年报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CO_YearReport f = new CO_YearReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 烟雾详情查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VI_Search f = new VI_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 烟雾日报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VI_DayReport f = new VI_DayReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 烟雾月报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VI_MonthReport f = new VI_MonthReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 烟雾年报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VI_YearReport f = new VI_YearReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 风机运行情况查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fan_Search f = new Fan_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 可变情报板发布查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCMS_Search f = new FCMS_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 可变情报板日报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCMS_DayReport f = new FCMS_DayReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 可变情报板月报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCMS_MonthReport f = new FCMS_MonthReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 可变情报板年报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCMS_YearReport f = new FCMS_YearReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 指令下发详情查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command_Search f = new Command_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 指令下发日报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command_DayReport f = new Command_DayReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 指令下发月报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command_MonthReport f = new Command_MonthReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 指令下发年报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command_YearReport f = new Command_YearReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 设备故障查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Breakdown_Search f = new Breakdown_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 设备故障日报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Breakdown_DayReport f = new Breakdown_DayReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 设备故障月报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Breakdown_MonthReport f = new Breakdown_MonthReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 设备故障年报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Breakdown_YearReport f = new Breakdown_YearReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 报警信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alarm_Search f = new Alarm_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 报警信息日报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alarm_DayReport f = new Alarm_DayReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 报警信息月报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alarm_MonthReport f = new Alarm_MonthReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 报警信息年报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alarm_YearReport f = new Alarm_YearReport();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void 手工事件查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual_Search f = new Manual_Search();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
