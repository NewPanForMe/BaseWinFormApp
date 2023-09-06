namespace SqlT.Models;

/// <summary>
/// Pdm表的主表
/// 用于记录表的主要信息
/// </summary>
public record Pdm_Table
{
    /// <summary>  
    /// Id 
    /// </summary>  
    public long Id { get; set; }
    /// <summary>  
    /// 编号 
    /// </summary>  
    public string Code { get; set; }
    /// <summary>  
    /// 表名称 
    /// </summary>  
    public string Name { get; set; }
    /// <summary>  
    /// 表编码 
    /// </summary>  
    public string TbCode { get; set; }
    /// <summary>  
    /// 表注释 
    /// </summary>  
    public string Comment { get; set; }
    /// <summary>  
    /// 表主键 
    /// </summary>  
    public string PK { get; set; }
    /// <summary>  
    /// 表主键编码 
    /// </summary>  
    public string PkCode { get; set; }
    /// <summary>  
    /// 标记Code 
    /// </summary>  
    public string SignCode { get; set; }

}