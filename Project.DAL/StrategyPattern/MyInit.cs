using Project.COMMON.Tools;
using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.StrategyPattern
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            #region Admin

            AppUser au = new AppUser();
            au.UserName = "cgr";
            au.Password = DantexCrypt.Crypt("123");
            au.Email = "cagri.yolyapar@gmail.com";
            au.Role = ENTITIES.Enums.UserRole.Admin;
            





            #endregion
        }
    }
}
