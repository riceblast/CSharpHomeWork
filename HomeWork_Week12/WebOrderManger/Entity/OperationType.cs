using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementWithMysql.Entity
{
	// 存储着用户可选的操作方式
	public enum OperationType
	{
		Append,
		Delete,
		Update,
		Query
	}
}
