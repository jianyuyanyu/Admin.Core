﻿namespace ZhonTai.Admin.Services.User.Dto;

/// <summary>
/// 用户分页查询条件
/// </summary>
public class UserGetPageInput
{
    /// <summary>
    /// 部门Id
    /// </summary>
    public long? OrgId { get; set; }
}
