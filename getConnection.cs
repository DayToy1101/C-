using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KTV
{
    class getConnection
    {
        public getConnection()
        {

        }
        public OleDbConnection OledCon()
        {
            //创建连接数据库的字符串
            string reportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
             Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            reportPath += @"DataBasetb_KTV";
            string ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + reportPath;
            //创建OleDbConnection对象
            OleDbConnection con = new OleDbConnection(ConStr);
            return con;
        }
    }
}
