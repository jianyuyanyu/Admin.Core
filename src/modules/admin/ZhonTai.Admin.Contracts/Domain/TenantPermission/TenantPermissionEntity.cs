﻿using FreeSql.DataAnnotations;
using ZhonTai.Admin.Core.Entities;
using ZhonTai.Admin.Domain.Tenant;
using ZhonTai.Admin.Domain.Permission;
using ZhonTai.Admin.Core.Attributes;

namespace ZhonTai.Admin.Domain.TenantPermission;

/// <summary>
/// 租户权限
/// </summary>
[Table(Name = DbConsts.TableNamePrefix + "tenant_permission", OldName = DbConsts.TableOldNamePrefix + "tenant_permission")]
[Index("idx_{tablename}_01", nameof(TenantId) + "," + nameof(PermissionId), true)]
public class TenantPermissionEntity : EntityAdd
{
    /// <summary>
    /// 租户Id
    /// </summary>
	[Column(IsPrimary = true)]
    public long TenantId { get; set; }

    /// <summary>
    /// 租户
    /// </summary>
    [NotGen]
    public TenantEntity Tenant { get; set; }

    /// <summary>
    /// 权限Id
    /// </summary>
    [Column(IsPrimary = true)]
    public long PermissionId { get; set; }

    /// <summary>
    /// 权限
    /// </summary>
    [NotGen]
    public PermissionEntity Permission { get; set; }
}