using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    public class HouseholdItem
    {
        public double Size { get; set; }
        public double Price { get; set; }

        public HouseholdItem(double size, double price)
        {
            Size = size;
            Price = price;
        }

        public HouseholdItem()
        {
            Size = 1;
        }
    }

    public class PeanutWithShell : HouseholdItem
    {
        public PeanutWithShell()
        {
            Size = 10;
        }
    }
    public class PintoBean : HouseholdItem
    {
        public PintoBean()
        {
            Size = 5;
        }
    }
    public class TableSalt : HouseholdItem
    {
        public TableSalt()
        {
            Size = 1;
        }
    }
}
