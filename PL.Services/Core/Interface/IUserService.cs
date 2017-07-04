using System.Collections.Generic;
using System.Linq;
using PL.Tools;
using PL.Models.Core;
using PL.ViewModel.Core;

namespace PL.Services.Core.Interface
{
    public interface IUserService
    {
        IQueryable<User> Users { get; }
        OperationResult Insert(UserVM model);
        OperationResult Update(UserVM model);
        OperationResult Delete(IEnumerable<UserVM> list);
        OperationResult ResetPassword(IEnumerable<UserVM> list);
        OperationResult UpdateUserRoles(int roleId, string[] chkRoles);
        OperationResult UpdateUserGroups(int userId, string[] chkUserGroups);
    }
}
