using System.Collections.Generic;
using System.Linq;
using PL.Tools;
using PL.Models.Core;
using PL.ViewModel;
using PL.ViewModel.Core;

namespace PL.Services.Core.Interface
{
    public interface IRoleService
    {
        IQueryable<Role> Roles { get; }
        OperationResult Insert(RoleVM model);
        OperationResult Update(RoleVM model);
        OperationResult Delete(IEnumerable<RoleVM> list);
        IList<ZTreeVM> GetListZTreeVM(int id);
        OperationResult UpdateAuthorize(int roleId, int[] ids);
    }
}
