using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Dapper;

namespace SqlT.Tools;

public class SqlDbHelper
{
    private static string _connString;
    private static SqlConnection _conn;

    /// <summary>
    /// 生成SQL链接字符串
    /// </summary>
    public static bool GenerateDbConn(string ip, string userName, string password, string db)
    {
        if (string.IsNullOrEmpty(ip))
        {
            MessageBox.Show(@"数据库IP为空");
            return false;
        }
        if (string.IsNullOrEmpty(userName))
        {
            MessageBox.Show(@"数据库用户名为空");
            return false;
        }
        if (string.IsNullOrEmpty(password))
        {
            MessageBox.Show(@"数据库密码为空");
            return false;
        }
        if (string.IsNullOrEmpty(db))
        {
            MessageBox.Show(@"数据库名为空");
            return false;
        }
        _connString = @$"server={ip};database={db};user id={userName};password={password};TrustServerCertificate=true";
        return true;
    }

    /// <summary>
    /// 测试链接
    /// </summary>
    /// <returns></returns>
    public static bool TestDb()
    {
        bool isOpen = false;
        try
        {
            OpenConn();
            if (_conn.State == ConnectionState.Open)
            {
                isOpen = true;
            }
        }
        catch (Exception e)
        {
            if (_conn.State == ConnectionState.Broken || _conn.State == ConnectionState.Closed)
            {
                isOpen = false;
            }
        }
        finally
        {
            CloseConn();
        }

        return isOpen;
    }

    /// <summary>
    /// 开启链接
    /// </summary>
    private static void OpenConn()
    {

        _conn = new SqlConnection(_connString);
        _conn.Open();
    }

    /// <summary>
    /// 关闭链接
    /// </summary>
    private static void CloseConn()
    {
        _conn.Dispose();
        _conn.Close();
    }

    /// <summary>
    /// 执行SQL
    /// </summary>
    /// <param name="sql"></param>
    public static int Execute(string sql)
    {
        try
        {
            OpenConn();
            var res = _conn.Execute(sql);
            return res;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
        finally
        {
            CloseConn();
        }
    }
}