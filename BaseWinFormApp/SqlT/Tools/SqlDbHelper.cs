﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using Public.Alert;
using SqlT.Models;
using Ys.Tools.MoreTool;

namespace SqlT.Tools;

public static  class SqlDbHelper
{
    private static string _connString;
    private const string SqlConnStringPath = "./SqlConnStrings.json";
    private static SqlConnection _conn;

    /// <summary>
    /// 生成SQL链接字符串
    /// </summary>
    public static bool GenerateDbConn(string ip, string userName, string password, string db)
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

        _connString = @$"server={ip};database={db};user id={userName};password={password};TrustServerCertificate=true";

        return true;
    }
    /// <summary>
    /// 生成Json文件
    /// </summary>
    /// <param name="ip"></param>
    /// <param name="userName"></param>
    /// <param name="password"></param>
    /// <param name="db"></param>
    /// <param name="port"></param>
    public static void GenerateJsonFile(string ip, string userName, string password, string db,string port)
    {
        var generateDbConnSelect = GenerateDbConnSelect();
        var firstOrDefault = generateDbConnSelect.FirstOrDefault(x => x.Ip == ip && x.DataBase == db);
        if (firstOrDefault == null)
        {
            var sqlConn = new SqlConn() { DataBase = db, Ip = ip, Password = password, UserName = userName,Port =port };
            generateDbConnSelect.Add(sqlConn);
            var serialize = JsonTools.Serialize(generateDbConnSelect);
            File.Delete(SqlConnStringPath);
            File.AppendAllText(SqlConnStringPath, serialize);
        }
    }
    /// <summary>
    /// 生成数据库链接字符串
    /// </summary>
    public static List<SqlConn> GenerateDbConnSelect()
    {
        var sqlConnString = File.ReadAllText(SqlConnStringPath);
        if (string.IsNullOrEmpty(sqlConnString)) return new List<SqlConn>();
        var sqlConnList = JsonTools.Deserialize<List<SqlConn>>(sqlConnString);
        return sqlConnList;

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
    /// <param name="isTran">是否开启事务</param>
    public static int Execute(string sql,bool isTran=false)
    {
        IDbTransaction transaction = null;
        try
        {
            OpenConn();
            if (isTran)
            {
                transaction = _conn.BeginTransaction();
            }
            var res = _conn.Execute(sql,null, transaction);
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