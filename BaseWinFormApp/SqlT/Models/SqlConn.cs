namespace SqlT.Models;

public record SqlConn
{
    /// <summary>
    /// 数据库IP
    /// </summary>
    public string Ip { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// 数据库
    /// </summary>
    public string DataBase { get; set; }
    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; }

}