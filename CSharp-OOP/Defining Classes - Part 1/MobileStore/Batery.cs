namespace MobileStore
{
    using System;

    public class Batery
    {
        private string model;

        private double hoursIdle;

        private double hoursTalk;

        public Batery(string model)
        {
            this.Model = model;
        }

        public Batery(string model,double hoursIdle,double hoursTalk)
            :this(model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
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

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (double.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException("The hours Idle must be a valid double number");
                }
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The hours Idle can not be smaller than one zero");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (double.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException("The hours Idle must be a valid double number");
                }
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The hours Idle can not be smaller than one zero");
                }
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            return $"Batery\nModel: {this.Model}\nHours Idle: {this.HoursIdle}\nHours Talk: {this.HoursTalk}";
        }



    }
}
