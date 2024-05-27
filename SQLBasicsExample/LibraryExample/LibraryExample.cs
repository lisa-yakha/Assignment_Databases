using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
        public class Models
        {

            public class Product
            {
                public string Id { get; set; }
                public string Title { get; set; }
                public float Price { get; set; }
                public DateTime DateAdded { get; set; }
                public string Description { get; set; }
                public float DiscountPrice { get; set; }
                public bool IsSold { get; set; }

            }
            public class Inventory
            {
                public string ProductReference { get; set; }
                public int Amount { get; set; }
                public DateTime DateUpdated { get; set; }

            }
            public class ComplaintForm
            {
                public enum Solution
                {
                    CashRefund = 0,
                    Replace = 1,
                    VoucherCard = 2
                }
                public string Reference { get; set; }
                public bool IsUsed { get; set; }
                public bool DamageOnArrival { get; set; }
                public bool IsWorking { get; set; }
                public bool DamageCaused { get; set; }
                public string Complaint { get; set; }
                public DateTime DateOrdered { get; set; }
                public bool Arrived { get; set; }
                public Solution DesiredSolution {get; set;}
                public DateTime DateReceived { get; set; }
            }
        }
}
