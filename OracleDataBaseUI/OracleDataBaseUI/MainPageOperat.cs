using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 主要界面的操作类,负责编写主界面的底层操作
/// </summary>
namespace OracleDataBaseUI
{
    class MainPageOperat
    {
        /// <summary>
        /// 更改数据库类型 目前是否是Oracle数据库，按钮控件
        /// </summary>
       public void ChangeDatabaseType(bool DatabaseIsOracle,Button ChangeDatabaseBut)
       {
            if(DatabaseIsOracle)
                ChangeDatabaseBut.Text = "切换成SqlServer数据库";
            else
                ChangeDatabaseBut.Text = "切换成Oracle数据库";
       }
    }
}
