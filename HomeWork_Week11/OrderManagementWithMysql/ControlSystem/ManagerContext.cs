using OrderManagementWithMysql.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.ControlSystem
{
    public class ManagerContext:DbContext
    {
        public ManagerContext()
            :base("OrderManagerDataBase")
        {
            // 每次更改了表就从新建表
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ManagerContext>());
            this.Configuration.LazyLoadingEnabled = false;

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
