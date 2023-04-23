using System;
using System.Collections.Generic;
using System.Text;

namespace HQTCSDL_G6.DatabaseManager.DTOs
{
    public class TotalStatistics
    {
        public int Order;
        public int Price;
        public int Shipping;

        public TotalStatistics (int order, int price, int shipping)
        {
            this.Order = order;
            this.Price = price;
            this.Shipping = shipping;
        }
    }
}
