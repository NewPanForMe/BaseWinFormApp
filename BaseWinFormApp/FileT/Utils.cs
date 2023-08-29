using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// 常用工具类
/// </summary>
class Utils
{
    
    #region 字串简繁转换，引用：Microsoft.VisualBasic，依赖：Microsoft.VisualBasic;
    /// <summary>
    /// 字符串简体转繁体
    /// </summary>
    /// <param name="strSimple"></param>
    /// <returns></returns>
    public static string ToTraditionalChinese(string strSimple)
    {
        string strTraditional = Strings.StrConv(strSimple, VbStrConv.TraditionalChinese, 0);
        return strTraditional;
    }

    /// <summary>
    /// 字符串繁体转简体
    /// </summary>
    /// <param name="strTraditional"></param>
    /// <returns></returns>
    public static string ToSimplifiedChinese(string strTraditional)
    {
        string strSimple = Strings.StrConv(strTraditional, VbStrConv.SimplifiedChinese, 0);
        return strSimple;
    }
    #endregion
}