using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Tools;
using PL.Models.Core;
using PL.ViewModel.Core;

namespace PL.Services.Core.Interface
{
    public interface IUserGroupService
    {
        IQueryable<UserGroup> UserGroups { get; }
        OperationResult Insert(UserGroupVM model);
        OperationResult Update(UserGroupVM model);
        OperationResult Delete(IEnumerable<UserGroupVM> list);
        OperationResult UpdateUserGroupRoles(int userId, string[] chkRoles);
    }
}
