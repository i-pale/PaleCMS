/************************************
 * 描述：尚未添加描述
 * 作者：Pale
 * 日期：2017/07/03 11:41:58  
*************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Data.Component.Configurations.Core
{
    internal partial class ModuleConfiguration
    {
        partial void ModuleConfigurationAppend()
        {
            this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasOptional(c => c.ParentModule).WithMany(c => c.ChildModules).HasForeignKey(d => d.ParentId);
        }
    }
}
