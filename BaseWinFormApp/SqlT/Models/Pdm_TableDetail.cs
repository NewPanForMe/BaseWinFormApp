namespace SqlT.Models;

/// <summary>
/// 
/// </summary>
public record Pdm_TableDetail
{
    /// <summary>  
    /// 自增长序号 
    /// </summary>  
    public long Id { get; set; }
    /// <summary>  
    /// 主键 
    /// </summary>  
    public string Code { get; set; }
    /// <summary>  
    /// 字段名称 
    /// </summary>  
    public string TName { get; set; }
    /// <summary>  
    /// 字段编码 
    /// </summary>  
    public string TCode { get; set; }
    /// <summary>  
    /// 表注释 
    /// </summary>  
    public string TComment { get; set; }
    /// <summary>  
    /// 字段类型 
    /// </summary>  
    public string TDataType { get; set; }
    /// <summary>  
    /// 是否自增 
    /// </summary>  
    public string TIdentity { get; set; }
    /// <summary>  
    /// 是否必填 
    /// </summary>  
    public string TMandatory { get; set; }
    /// <summary>  
    /// 主表Code 
    /// </summary>  
    public string Pdm_Table_Code { get; set; }
    /// <summary>  
    /// 标记Code 
    /// </summary>  
    public string SignCode { get; set; }

}