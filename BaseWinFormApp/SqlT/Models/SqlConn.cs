namespace SqlT.Models;

public record SqlConn
{
    /// <summary>
    /// 数据库IP
    /// </summary>
    public string Ip { get; set; } = string.Empty;

    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// 数据库
    /// </summary>
    public string DataBase { get; set; } = string.Empty;
    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; }    =string.Empty;
    /// <summary>
    /// 端口
    /// </summary>
    public string Port { get; set; } = string.Empty;

}