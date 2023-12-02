using Public.Alert;
using SqlT.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using System.IO;
using System.Linq;
using Dapper;
using Npgsql;
using Ys.Tools.MoreTool;

namespace SqlT.Tools;

public static class NpgSqlDbHelper
{
    private static string _connString;
    private static NpgsqlConnection _conn;

    /// <summary>
    /// 生成SQL链接字符串
    /// </summary>
    public static bool GenerateDbConn(string ip, string userName, string password, string db,string port)
    {
        if (string.IsNullOrEmpty(ip))
        {
            MessageAlert.ShowWarning(@"数据库IP为空");
            return false;
        }

        if (string.IsNullOrEmpty(userName))
        {
            MessageAlert.ShowWarning(@"数据库用户名为空");
            return false;
        }

        if (string.IsNullOrEmpty(password))
        {
            MessageAlert.ShowWarning(@"数据库密码为空");
            return false;
        }

        if (string.IsNullOrEmpty(db))
        {
            MessageAlert.ShowWarning(@"数据库名为空");
            return false;
        }

        _connString = @$"HOST={ip};DATABASE={db};Username={userName};PASSWORD={password};Port={port}";
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
        catch (Exception)
        {
            isOpen = false;
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
        _conn = new (_connString);
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
    /// <param name="isTran">是否开启事务</param>
    public static int Execute(string sql, bool isTran = false)
    {
        IDbTransaction transaction = null;
        try
        {
            OpenConn();
            if (isTran)
            {
                transaction = _conn.BeginTransaction();
            }
            var res = _conn.Execute(sql, null, transaction);
            transaction?.Commit();
            return res;
        }
        catch (Exception e)
        {
            MessageAlert.ShowError(e.Message);
            transaction?.Rollback();
            return 0;
        }
        finally
        {
            CloseConn();
        }
    }
    /// <summary>
    /// 查询SQL
    /// </summary>
    /// <param name="sql"></param>
    public static List<T> Query<T>(string sql)
    {
        try
        {
            OpenConn();
            var res = _conn.Query<T>(sql).ToList();
            return res;
        }
        catch (Exception e)
        {
            MessageAlert.ShowError(e.Message);
            return new List<T>();
        }
        finally
        {
            CloseConn();
        }
    }

}