using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OracleDataBaseUI
{
    /// <summary>
    /// 集合了Oracle数据库和SQLServer数据库操作的类
    /// </summary>
    class Database
    {
        private OracleDatabaseOper OracleDatabaseOper = null;//Oracle操作对象
        private SQLServerDatOper SQLServerDatOper = null;//sqlserver操作对象
        /// <summary>
        /// 构造函数，参数1SQLserver的连接字符串，参数2 Oracle的连接字符串
        /// </summary>
        /// <param name="SQLConnectString"></param>
        /// <param name="OracleConnectString"></param>
        public Database(string SQLConnectString,string OracleConnectString)
        {
            try {
                SQLServerDatOper = new SQLServerDatOper(SQLConnectString);
                OracleDatabaseOper = new OracleDatabaseOper(OracleConnectString);
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
                MessageBox.Show("初始化SqlServer和Oracle失败");
            }
        }
        /// <summary>
        /// 关闭Oracle数据库
        /// </summary>
        public void closeOracle()
            => OracleDatabaseOper.CloseOracle();
        /// <summary>
        /// 关闭SQLServer数据库
        /// </summary>
        public void closeSQLServer()
            => SQLServerDatOper.SQLServerClose();
        /// <summary>
        /// 打开Oracle数据库
        /// </summary>
        public void openOracle()
        => OracleDatabaseOper.OpenOracle();
        /// <summary>
        /// 打开SqlServer数据库
        /// </summary>
        public void openSQLServer()
            => SQLServerDatOper.SQLServerOpen();
        /// <summary>
        /// 备份SqlServer数据库
        /// </summary>
        /// <param name="IsOracle"></param>
        public void BackUpDataBase(bool IsOracle)
        {
            if (IsOracle)
                ;
            else
                SQLServerDatOper.Backup_database();
        }
        /// <summary>
        /// 输出当前数据库全部表名到表Listview中
        /// </summary>
        /// <param name="IsOracle"></param>
        /// <param name="listView"></param>
        public void ShowTableName(bool IsOracle, ListView listView)
        {
            if (IsOracle)
                 OracleShowTableName(listView); 
            else
                SqlServerShowTableName(listView);
        }
        /// <summary>
        /// sqlserver输出表名字
        /// </summary>
        /// <param name="listView"></param>
        private void SqlServerShowTableName(ListView listView) =>
            this.SQLServerDatOper.getDBAllTableName(listView);          
        /// <summary>
        /// 输出Oracle表名字
        /// </summary>
        /// <param name="listView"></param>
        private void OracleShowTableName(ListView listView)
        {
            OracleDatabaseOper.getDatabaseTableName(listView);
        }
        /// <summary>
        /// 输出当前选的表全部信息
        /// </summary>
        /// <param name="IsOracle"></param>
        /// <param name="selectTableName"></param>
        /// <param name="Table"></param>
        /// <param name="StructTable"></param>
        public void ShowTableInfo(bool IsOracle,string selectTableName,ListView Table, ListView StructTable)
        {
            if(IsOracle)
                OracleDatabaseOper.getTableInfo(selectTableName, Table, StructTable);//Oracle
            else//输出SQLServer
                SQLServerDatOper.getTableInfo(selectTableName, Table,StructTable);
        }
        /// <summary>
        /// 输出表数据结构
        /// </summary>
        /// <param name="IsOracle"></param>
        /// <param name="selectTableName"></param>
        /// <param name="Table"></param>
        public void ShowTableStruct(bool IsOracle, string selectTableName, ListView Table)
        {
            if (IsOracle)
            {//输出Oracle
                OracleDatabaseOper.getTableStruct(selectTableName, Table);
            }
            else//输出SQLServer
                SQLServerDatOper.getTableStruct(selectTableName, Table);
        }
        /// <summary>
        /// 导出表数据
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="TableData"></param>
        /// <param name="TableStruct"></param>
        public void ExportData(string TableName, ListView TableData, ListView TableStruct)
        {
            //先创建表结构，再插入数据
           string HaxiMap = OracleDatabaseOper.ExportIndexMap(TableStruct);//建立映射表
           string[] insertSql = OracleDatabaseOper.ExportTableData(TableName, TableData, HaxiMap);//插入语句
            foreach(var insert in insertSql)
            {
            //   MessageBox.Show(insert);
               SQLServerDatOper.InsertDataTable(insert);
            }
        }
        /// <summary>
        /// 导出表结构
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="TableStruct"></param>
        public void ExportStruct(string TableName, ListView TableStruct)
        {
            //导出Oracle创建表的SQL语句
            string CreateSql = OracleDatabaseOper.ExportDataStruct(TableName, TableStruct);
          //  MessageBox.Show(CreateSql);
            //对SQLServer执行创建表
            SQLServerDatOper.CreateTable(CreateSql);
        }
    }
}
