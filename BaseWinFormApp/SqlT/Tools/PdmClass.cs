using System.Collections.Generic;
namespace SqlT.Tools;
#region table


public record O_ColumnItem
{
    /// <summary>
    /// 
    /// </summary>
    public string @Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ObjectID { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_CreationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Creator { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ModificationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Modifier { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Comment { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_DataType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Length { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Identity { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Column_Mandatory { get; set; }
}

public record C_Columns
{
    /// <summary>
    /// 
    /// </summary>
    public List<O_ColumnItem> O_Column { get; set; }
}

public record O_Column
{
    /// <summary>
    /// 
    /// </summary>
    public string @Ref { get; set; }
}

public record C_Key_Columns
{
    /// <summary>
    /// 
    /// </summary>
    public O_Column O_Column { get; set; }
}

public record O_Key
{
    /// <summary>
    /// 
    /// </summary>
    public string @Ref { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string @Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ObjectID { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_CreationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Creator { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ModificationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Modifier { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_Key_Columns C_Key_Columns { get; set; }
}

public record C_Keys
{
    /// <summary>
    /// 
    /// </summary>
    public O_Key O_Key { get; set; }
}



public record C_PrimaryKey
{
    /// <summary>
    /// 
    /// </summary>
    public O_Key O_Key { get; set; }
}

public record O_TableItem
{
    /// <summary>
    /// 
    /// </summary>
    public string @Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ObjectID { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_CreationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Creator { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ModificationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Modifier { get; set; }
    /// <summary>
    /// 工艺
    /// </summary>
    public string A_Comment { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_TotalSavingCurrency { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_Columns C_Columns { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_Keys C_Keys { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_PrimaryKey C_PrimaryKey { get; set; }
}

public record C_Tables
{
    /// <summary>
    /// 
    /// </summary>
    public List<O_TableItem> O_Table { get; set; }
}

public record Root
{
    /// <summary>
    /// 
    /// </summary>
    public C_Tables C_Tables { get; set; }
}

#endregion

#region pdm

public record Pdm
{
    //public List<TableData> ListTableData { get; set; }
    //public List<TableAttributes> ListAttributesList { get; set; }

    public string TableJsonString { get; set; }
    public string ReferJsonString { get; set; }
    public Root TableRoot { get; set; }
    public ReferRoot ReferRoot { get; set; }

}
public record TableData
{
    public string TableId { get; set; }//表标记，用于与xml解析数据对应
    public string TableName { get; set; }//表名？数据库注释
    public string TableCode { get; set; }//表名
    public string TableComment { get; set; }//数据库注释
    public string TablePrimaryKey { get; set; }//表主键
}
public record TableAttributes
{
    /// <summary>
    /// 字段名？数据库注释
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// 字段名？数据库注释
    /// </summary>
    public string ObjectId { get; set; }
    /// <summary>
    /// 与table表关联字段
    /// </summary>
    public string TableId { get; set; }
    /// <summary>
    /// 字段名？数据库注释
    /// </summary>
    public string AttributeName { get; set; }
    /// <summary>
    /// 字段名
    /// </summary>
    public string AttributeCode { get; set; }
    /// <summary>
    /// /数据库注释
    /// </summary>
    public string AttributeComment { get; set; }
    /// <summary>
    /// /数据类型
    /// </summary>
    public string AttributeDataType { get; set; }
    /// <summary>
    /// 数据长度
    /// </summary>
    public string AttributeDataLength { get; set; }
    /// <summary>
    /// 主键ID
    /// </summary>
    public string AttributePrimaryKey { get; set; }
    /// <summary>
    /// 是否为空
    /// </summary>
    public string AttributeMandatory { get; set; }
    /// <summary>
    /// 是否自增
    /// </summary>
    public string AttributeIdentity { get; set; }


}


#endregion

#region refer



public record O_Table
{
    /// <summary>
    /// 
    /// </summary>
    public string @Ref { get; set; }
}

public record C_ParentTable
{
    /// <summary>
    /// 
    /// </summary>
    public O_Table O_Table { get; set; }
}

public record C_ChildTable
{
    /// <summary>
    /// 
    /// </summary>
    public O_Table O_Table { get; set; }
}



public record C_ParentKey
{
    /// <summary>
    /// 
    /// </summary>
    public O_Key O_Key { get; set; }
}



public record C_Object1
{
    /// <summary>
    /// 
    /// </summary>
    public O_Column O_Column { get; set; }
}


public record C_Object2
{
    /// <summary>
    /// 
    /// </summary>
    public O_Column O_Column { get; set; }
}

public record O_ReferenceJoin
{
    /// <summary>
    /// 
    /// </summary>
    public string @Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ObjectID { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_CreationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Creator { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ModificationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Modifier { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_Object1 C_Object1 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_Object2 C_Object2 { get; set; }
}

public record C_Joins
{
    /// <summary>
    /// 
    /// </summary>
    public O_ReferenceJoin O_ReferenceJoin { get; set; }
}

public record O_ReferenceItem
{
    /// <summary>
    /// 
    /// </summary>
    public string @Id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ObjectID { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Code { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_CreationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Creator { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_ModificationDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Modifier { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_Cardinality { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_UpdateConstraint { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string A_DeleteConstraint { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_ParentTable C_ParentTable { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_ChildTable C_ChildTable { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_ParentKey C_ParentKey { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public C_Joins C_Joins { get; set; }
}

public record C_References
{
    /// <summary>
    /// 
    /// </summary>
    public List<O_ReferenceItem> O_Reference { get; set; }
}

public record ReferRoot
{
    /// <summary>
    /// 
    /// </summary>
    public C_References C_References { get; set; }
}


#endregion