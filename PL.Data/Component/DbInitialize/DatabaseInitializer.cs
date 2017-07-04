﻿/************************************
 * 描述：尚未添加描述
 * 作者：Pale
 * 日期：2015/9/8 11:15:26  
*************************************/

using System.Data.Entity;
using PL.Data.Component.EF;
using PL.Data.Component.Migrations;

namespace PL.Data.Component.DbInitialize
{
    /// <summary>
    /// 数据库初始化操作类
    /// </summary>
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            //启用自动迁移数据库配置
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFDbContext, Configuration>());
        }
    }
}
