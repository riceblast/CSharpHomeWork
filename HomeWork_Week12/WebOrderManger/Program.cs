using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WebOrderManger
{
    // 学到/需要注意的点
    // 1.当传入对象时，如果不存在对数据库的操作，则构造对象时，哪些属性有初始值
    // 最后就只有这些对象有值，如果添加了对于数据的操作，若主键和外键没赋值或者赋值
    // 不符合规范，则会由数据库自动赋值，其他属性和没操作数据库时相同
    // 2.利用json传入对象时，属性大小写不敏感,但是名字和类型都不能出错
    // 3.可以用非枚举之外的对象作为GoodsName，但是写入数据库时，在GoodsName这一列为空
    // 4.路由路径的字母大小写不影响实际使用
    // 5.在发出请求构造对象时，属性的顺序不影响使用
    // 6.当数组作为一个属性时，json语法中应该在对象之前加上属性名，若不加，则只能单独作一个数组而不能作为对象
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
