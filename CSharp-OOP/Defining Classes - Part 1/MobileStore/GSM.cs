namespace MobileStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        public static GSM iPhone4s = new GSM("I Phone 4s", "Apple", 1000);
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Batery batery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Batery batery, Display dispay) :
            this(model, manufacturer, price, owner)
        {
            this.Batery = batery;
            this.Display = dispay;
        }

        public static GSM Iphone4s
        {
            get
            {
                return iPhone4s;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new IndexOutOfRangeException("The model must be longer than two symbols");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new IndexOutOfRangeException("The name of manufacturer must be longer than two symbols");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The price can not be negative number!!!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The name of the owner must be more than 2 symbols");
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("The name of the owner can not be empty.");
                }

                this.owner = value;
            }
        }

        public Batery Batery
        {
            get
            {
                return this.batery;
            }
            set
            {
                this.batery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory { get; set; }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        public void DeleteCall(int callIndex)
        {
            CallHistory.RemoveAt(callIndex);
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal TotalPriceOfCall(decimal pricePerMinute)
        {
            decimal allCallsInSecs = (decimal)(this.CallHistory.Select(x => x.Duration).Sum());
            return pricePerMinute * (allCallsInSecs / 60.0m);
        }


        public override string ToString()
        {
            return $"Model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price}\n{this.Batery}\n{this.Display}\nOwner: {this.Owner}";
        }

    }

}
