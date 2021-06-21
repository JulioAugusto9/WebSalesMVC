using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSalesMVC.Models.Enums;

namespace WebSalesMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord(DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
