/************************************
 * 描述：尚未添加描述
 * 作者：Pale
 * 日期：2015/11/11 14:02:29  
*************************************/

using System.ComponentModel.DataAnnotations.Schema;

namespace PL.Data.Component.Configurations.Core
{
    internal partial class RoleConfiguration
    {
        partial void RoleConfigurationAppend()
        {
            this.HasMany(r => r.Users).WithMany(u => u.Roles);
            this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
