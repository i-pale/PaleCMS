using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PL.Models.Core;
using PL.ViewModel.Core;

namespace PL.Data.Domain.Repositories.Core
{
    public partial interface IModuleRepository
    {
        IList<ModuleVM> GetListModuleVM(Expression<Func<Module, bool>> wh, int limit, int offset, out int total);
    }
}
