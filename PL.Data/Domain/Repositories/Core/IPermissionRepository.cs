using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PL.Models.Core;
using PL.ViewModel.Core;

namespace PL.Data.Domain.Repositories.Core
{
    public partial interface IPermissionRepository
    {
        IList<PermissionVM> GetListPermissionVM(Expression<Func<Permission, bool>> wh, int limit, int offset, out int total);
    }
}
