﻿using System;
using System.Data.Entity;
using System.Linq;
using MySql.Data.EntityFramework;

namespace Book1
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BookContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Model1”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“Book.Model1”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Model1”
        //连接字符串。
        public BookContext() : base("BookDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookContext>());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}