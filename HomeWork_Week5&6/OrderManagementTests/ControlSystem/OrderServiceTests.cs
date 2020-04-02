using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement.ControlSystem;
using OrderManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.ControlSystem.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        private static List<OrderItem> orderItems; // 便于测试使用
        private static List<OrderItem> orderItemsNew; // 便于测试用

        [ClassInitialize]
        public static void CreateTestOrderItems(TestContext testContext)
        {
            // 初始化测试用的orderItems
            orderItems = new List<OrderItem>();
            orderItems.Add(new OrderItem(GoodsType.Battery, 12));
            orderItems.Add(new OrderItem(GoodsType.Soc, 23));

            // 初始化测试用的orderItemsNew
            orderItemsNew = new List<OrderItem>();
            orderItemsNew.Add(new OrderItem(GoodsType.Cmos, 45));
        }

        [TestCleanup]
        public void CleanUpOrders()
        {
            OrderService.Orders.Clear();
            OrderService.TotalOrderNums = 0;
        }

        [TestMethod()]
        public void AppendOrderTest()
        {
            List<Order> actual = new List<Order>();
            actual.Add(new Order(1, DateTime.Now, "Andy", orderItems));
            OrderService.AppendOrder("Andy", orderItems);
            Assert.AreEqual(OrderService.Orders[0],actual[0]);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            // 先添加再删除
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.DeleteOrder(1);
            List<Order> actual = new List<Order>();
            CollectionAssert.AreEqual(OrderService.Orders, actual);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.UpdateOrder(1, "Bob");
            List<Order> actual = new List<Order>();
            actual.Add(new Order(1, DateTime.Now, "Bob", orderItems));
            CollectionAssert.AreEqual(OrderService.Orders, actual);
        }

        [TestMethod()]
        public void UpdateOrderTest1()
        {
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.UpdateOrder(1, orderItemsNew);
            List<Order> actual = new List<Order>();
            actual.Add(new Order(1, DateTime.Now, "Andy", orderItemsNew));
            CollectionAssert.AreEqual(OrderService.Orders, actual);
        }

        [TestMethod()]
        public void QueryOrderTest()
        {
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.AppendOrder("Andy", orderItemsNew);
            List<Order> actual = new List<Order>();
            actual.Add(new Order(1, DateTime.Now, "Andy", orderItems));
            CollectionAssert.AreEqual(OrderService.QueryOrder(GoodsType.Battery), actual);
        }

        [TestMethod()]
        public void QueryOrderTest1()
        {
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.AppendOrder("Andy", orderItemsNew);
            List<Order> actual = new List<Order>();
            actual.Add(new Order(2, DateTime.Now, "Andy", orderItemsNew));
            CollectionAssert.AreEqual(OrderService.QueryOrder(2), actual);
        }

        [TestMethod()]
        public void QueryOrderTest2()
        {
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.AppendOrder("Bob", orderItemsNew);
            List<Order> actual = new List<Order>();
            actual.Add(new Order(1, DateTime.Now, "Andy", orderItems));
            CollectionAssert.AreEqual(OrderService.QueryOrder("Andy"), actual);
        }

        [TestMethod()]
        public void sortOrdersTest()
        {
            OrderService.AppendOrder("Andy", orderItems);
            OrderService.AppendOrder("Andy", orderItemsNew);
            List<Order> actual = new List<Order>();
            actual.Add(new Order(1, DateTime.Now, "Andy", orderItems));
            actual.Add(new Order(2, DateTime.Now, "Andy", orderItemsNew));
            OrderService.sortOrders();
            CollectionAssert.AreEqual(OrderService.Orders, actual);
        }

    }
}