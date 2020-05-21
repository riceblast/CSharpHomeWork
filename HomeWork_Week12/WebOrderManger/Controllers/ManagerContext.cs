using OrderManagementWithMysql.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.ControlSystem
{
    public class ManagerContext:DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options)
            :base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        /// <summary>
        /// 数据库中的订单表
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// 数据库中的订单明细项表
        /// </summary>
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
