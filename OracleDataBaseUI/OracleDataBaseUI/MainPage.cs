using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Common;
//需要添加引用C:\Windows\assembly\GAC\Oracle.DataAccess\10.2.0.100__89b483f429c47342\Oracle.DataAccess.dll
namespace OracleDataBaseUI
{
    public partial class MainPage : Form
    {
        /// <summary>
        /// sqlserver数据库的链接字符串
        /// </summary>
        private static readonly string sqlServerConnectString = "Data Source=DESKTOP-MRGFBAU;Initial Catalog=KTV数据库;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /// <summary>
        /// Oracle数据库的连接字符串
        /// </summary>
        const string str = "user id=system; password=xysm;data source = (DESCRIPTION =(ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.1.7)(PORT = 1521)))(CONNECT_DATA =(SID =xysmst )(SERVER = DEDICATED)))";
        private static readonly string oracleConnectString = str;

        /// <summary>
        /// 每页输出的长度最多20个
        /// </summary>
        private const int ShowDataLength = 20;
        /// <summary>
        /// 当前第几页，默认从1开始
        /// </summary>
        private int PageCout = 1;
        private int TableColums=10;//当前数据表数据个数
        /// <summary>
        /// 向前翻页
        /// </summary>
        private void PageForward()
        {

        }
        /// <summary>
        /// 向后翻页
        /// </summary>
        private void PageBack()
        {
        
        }
        //现在数据库是不是Oracle
        private bool DatabaseIsOracle = true;
        //数据库的操作类
        Database database = new Database(sqlServerConnectString, oracleConnectString);//这里是SqlServer和Oracle的链接字符串
        //主界面的操作类
        MainPageOperat mainPageOperat = new MainPageOperat();
        public MainPage()
        {
            InitializeComponent();
        }
        private void OracleMainPage_Load(object sender, EventArgs e)
        {
           database.openOracle();//默认先打开Oracle数据库
           database.ShowTableName(this.DatabaseIsOracle, DatabaseListView);//输出表名
        }
        /// <summary>
        /// 关闭窗体按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBut_Click(object sender, EventArgs e)=>this.Close();
        /// <summary>
        /// 清除所有ListView中数据
        /// </summary>
        private void ClearALL()
        {
            DatabaseListView.Items.Clear();//清除上次表名
            TableDataView.Items.Clear();//清除上次数据表内容
            TableDataView.Columns.Clear();//清除上次数据表列名
            TableStructView.Items.Clear();//清除上次结构表内容
        }
        /// <summary>
        /// 点击转换按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDatabaseBut_Click(object sender, EventArgs e)
        {
            this.DatabaseIsOracle = !(this.DatabaseIsOracle);//取反
            if (DatabaseIsOracle == false)//当前是SQLServer状态
            {
                database.closeOracle();//关闭Oracle
            }
            else
            {
                database.openOracle();//打开Oracle数据库
            }
            ClearALL(); 
            stop();
            //改变按钮上字体
            mainPageOperat.ChangeDatabaseType(this.DatabaseIsOracle, ChangeDatabaseBut);
            //输出表名字
            database.ShowTableName(this.DatabaseIsOracle, DatabaseListView);
        }
        /// <summary>
        /// 单击表名出现表结构
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.DatabaseListView.SelectedItems.Count > 0)//当前索引值大于0
            {
                //输出当前选择的表的表结构
                database.ShowTableStruct(DatabaseIsOracle, DatabaseListView.SelectedItems[0].Text, TableStructView);
                //输出当前选择的表的表数据
                database.ShowTableInfo(DatabaseIsOracle, DatabaseListView.SelectedItems[0].Text, TableDataView, TableStructView);
            }
        }
        /// <summary>
        /// 备份成为BAK文件-SQLserver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackUpBut_Click(object sender, EventArgs e)
        =>  database.BackUpDataBase(this.DatabaseIsOracle);//当前是否是Oracle数据库
        /// <summary>
        /// 只有Oracle才能使用这个按钮
        /// </summary>
        private void stop()
        {
            if (DatabaseIsOracle == false)
                ImportDatabaseBut.Enabled = false;
            else
                ImportDatabaseBut.Enabled = true;
        }
        /// <summary>
        /// 导入数据到Sqlserver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportDatabaseBut_Click(object sender, EventArgs e)
        {
            //首先确定SqlServer是否登录
                try
                {
                    if (TableDataView.Items.Count > 0)
                        database.ExportData(DatabaseListView.SelectedItems[0].Text, TableDataView, TableStructView);
                    MessageBox.Show("导入结束");
                }
                catch
                {
                    MessageBox.Show("导入表失败了");
                }
        }
        /// <summary>
        /// 创建当前数据表到SQLServer中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.DatabaseListView.SelectedItems.Count > 0)
                database.ExportStruct(DatabaseListView.SelectedItems[0].Text, TableStructView);
        }
        private void TableStructView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //备份数据
        private void BackUpButDmp_Click(object sender, EventArgs e)
        {

        }
    }
}
