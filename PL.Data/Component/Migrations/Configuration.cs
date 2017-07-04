using PL.Data.Component.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using PL.Data.Component.Enum;
using PL.Models.Core;

namespace PL.Data.Component.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            #region ģ�����
            List<Module> modules = new List<Module>
            {
                new Module { Id = 1, ParentId = null, Name = "��Ȩ����", Code = 200,LinkUrl="#",  Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now},
                new Module { Id = 2, ParentId = 1, Name = "��ɫ����", LinkUrl = "~/Member/Role/Index",  Code = 201,Description = null, IsMenu = true, Enabled = true, UpdateDate = DateTime.Now},
                new Module { Id = 3, ParentId = 1, Name = "�û�����", LinkUrl = "~/Member/User/Index", Code = 202, Description = null, IsMenu = true, Enabled = true, UpdateDate = DateTime.Now },
                new Module { Id = 4, ParentId = 1, Name = "ģ�����", LinkUrl = "~/Member/Module/Index",  Code = 204, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 5, ParentId = 1, Name = "Ȩ�޹���", LinkUrl = "~/Member/Permission/Index",  Code = 205, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                 new Module { Id = 6, ParentId = null, Name = "ϵͳӦ��", LinkUrl = "#",  Code = 300,  Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 7, ParentId = 6, Name = "������־����", LinkUrl = "#",Code = 301,Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 8, ParentId = 1, Name = "�û������", LinkUrl = "~/Member/UserGroup/Index",  Code = 203, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now }
                //~/SysConfig/OperateLog/Index
            };
            DbSet<Module> moduleSet = context.Set<Module>();
            moduleSet.AddOrUpdate(t => new { t.Name }, modules.ToArray());
            context.SaveChanges();
            #endregion

            #region Ȩ�޹���
            List<Permission> permissions = new List<Permission>
            {
             #region ��ɫ
		       new Permission{Id=1, Name="��ѯ",Code=EnumPermissionCode.QueryRole.ToString(), 
                    Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]},
               new Permission{Id=2, Name="����",Code=EnumPermissionCode.AddRole.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]},
               new Permission{Id=3, Name="�޸�",Code=EnumPermissionCode.UpdateRole.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]},
               new Permission{Id=4, Name="ɾ��",Code=EnumPermissionCode.DeleteRole.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]},
               new Permission{Id=5, Name="��Ȩ",Code=EnumPermissionCode.AuthorizeRole.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]}, 
             #endregion

             #region �û�
		       new Permission{Id=6, Name="��ѯ",Code=EnumPermissionCode.QueryUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=7, Name="����",Code=EnumPermissionCode.AddUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=8, Name="�޸�",Code=EnumPermissionCode.UpdateUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=9, Name="ɾ��",Code=EnumPermissionCode.DeleteUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=10, Name="��������",Code=EnumPermissionCode.ResetPwdUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=11, Name="�����û���",Code=EnumPermissionCode.SetGroupUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=12, Name="���ý�ɫ",Code=EnumPermissionCode.SetRolesUser.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]}, 
	         #endregion
             
             #region ģ��
		     new Permission{Id=13, Name="��ѯ",Code=EnumPermissionCode.QueryModule.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[3]},
             new Permission{Id=14, Name="����",Code=EnumPermissionCode.AddModule.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[3]},
             new Permission{Id=15, Name="�޸�",Code=EnumPermissionCode.UpdateModule.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[3]},
	         #endregion

             #region Ȩ��
		     new Permission{Id=16, Name="��ѯ",Code=EnumPermissionCode.QueryPermission.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[4]},
             new Permission{Id=17, Name="����",Code=EnumPermissionCode.AddPermission.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[4]},
             new Permission{Id=18, Name="�޸�",Code=EnumPermissionCode.UpdatePermission.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[4]},
	         #endregion

             #region ������־
		     new Permission{Id=19, Name="��ѯ",Code=EnumPermissionCode.QuerySystemLog.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[6]},
	         #endregion

             #region �û���
		     new Permission{Id=20, Name="��ѯ",Code=EnumPermissionCode.QueryUserGroup.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[7]},
             new Permission{Id=21, Name="����",Code=EnumPermissionCode.AddUserGroup.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[7]},
             new Permission{Id=22, Name="�޸�",Code=EnumPermissionCode.UpdateUserGroup.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[7]},
             new Permission{Id=23, Name="ɾ��",Code=EnumPermissionCode.DeleteUserGroup.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[7]},
             new Permission{Id=24, Name="���ý�ɫ",Code=EnumPermissionCode.SetRolesUserGroup.ToString(), Description="����" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[7]}
	         #endregion
            };
            DbSet<Permission> permissionSet = context.Set<Permission>();
            permissionSet.AddOrUpdate(m => new { m.Id }, permissionSet.ToArray());
            context.SaveChanges();
            #endregion

            #region ��ɫ����
            List<Role> roles = new List<Role>
            {
                new Role { Id=1,  RoleName = "superadmin", Description="��������Ա",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now ,Permissions=permissions},
                new Role { Id=2,  RoleName = "����Ա", Description="ϵͳ����Ա",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now,Permissions=permissions},
                new Role { Id=3,  RoleName = "��ͨ��ɫ1", Description="��ͨ��ɫ1",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now ,Permissions=permissions},
                new Role { Id=4,  RoleName = "��ͨ��ɫ2", Description="��ͨ��ɫ2",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=5,  RoleName = "��ͨ��ɫ3", Description="��ͨ��ɫ3",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=6,  RoleName = "��ͨ��ɫ4", Description="��ͨ��ɫ4",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=7,  RoleName = "��ͨ��ɫ5", Description="��ͨ��ɫ5",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=8,  RoleName = "��ͨ��ɫ6", Description="��ͨ��ɫ6",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=9,  RoleName = "��ͨ��ɫ7", Description="��ͨ��ɫ7",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=10,  RoleName = "��ͨ��ɫ8", Description="��ͨ��ɫ8",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=11,  RoleName = "��ͨ��ɫ9", Description="��ͨ��ɫ9",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=12,  RoleName = "��ͨ��ɫ10", Description="��ͨ��ɫ10",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now }
            };
            DbSet<Role> roleSet = context.Set<Role>();
            roleSet.AddOrUpdate(m => new { m.RoleName }, roles.ToArray());
            context.SaveChanges();
            #endregion

            #region �û�����
            List<User> members = new List<User>
            {
                new User { Id=1, UserName = "admin", Password = "e10adc3949ba59abbe56e057f20f883e", Email = "375368093@qq.com", TrueName = "����Ա",Phone="18181818181",Address="�㶫���������������·XX��XX��XXX��X��" ,Enabled=true,Roles=new List<Role>{roles[1]} },
                new User { Id=2, UserName = "xiaowu", Password = "e10adc3949ba59abbe56e057f20f883e", Email = "11111@1111.com", TrueName = "С��",Phone="18181818181",Address="�㶫���������������·XX��X�㶫���������������·XX��XX��XXX��X��",Enabled=true,Roles=new List<Role>{roles[1]} }
            };
            DbSet<User> memberSet = context.Set<User>();
            memberSet.AddOrUpdate(m => new { m.UserName }, members.ToArray());
            context.SaveChanges();
            #endregion

            #region �û������
            List<UserGroup> userGroups = new List<UserGroup>
            {
                new UserGroup { Id=1, GroupName = "������",Description = "������Ա��",Enabled=true,Roles=new List<Role>{roles[1]},OrderSort = 1,Users = new List<User>(){members[0]}},
                new UserGroup { Id=2, GroupName = "��Ŀ������", Description = "��Ŀ������",Enabled=true,Roles=new List<Role>{roles[1]},OrderSort = 2,Users = new List<User>(){members[1]}}
            };
            DbSet<UserGroup> userGroupsSet = context.Set<UserGroup>();
            userGroupsSet.AddOrUpdate(m => new { m.GroupName }, userGroups.ToArray());
            context.SaveChanges();
            #endregion
        }
    }
}