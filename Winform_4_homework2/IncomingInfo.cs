using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_4_homework2
{
    public class IncomingInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Money { get; set; }

        private static decimal totalMoney = 0;

        public IncomingInfo(string name, string description, decimal money)
        {
            Name = name;
            Description = description;
            Money = money;
            totalMoney += money;
        }

        /// <summary>
        /// 获取显示信息
        /// </summary>
        /// <param name="pre"></param>
        /// <returns></returns>
        public string Detail(string pre)
        {
            pre += $"{Name}, {Money}, {Description}\r\n";
            return pre;
        }

        /// <summary>
        /// 获取总金额
        /// </summary>
        /// <param name="pre"></param>
        /// <returns></returns>
        public decimal TotalMoney()
        {
            return totalMoney;
        }
    }
}
