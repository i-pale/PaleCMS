/************************************
 * 描述：尚未添加描述
 * 作者：Pale
 * 日期：2015/9/8 13:59:57  
*************************************/

using PL.Data.Component;
using PL.Data.Component.EF.Interface;

namespace PL.Services
{
    /// <summary>
    /// 核心业务实现基类
    /// </summary>
    public abstract class CoreServiceBase
    {
        protected IUnitOfWork UnitOfWork;

        protected CoreServiceBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
