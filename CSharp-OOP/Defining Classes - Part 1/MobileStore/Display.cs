namespace MobileStore
{
    using System;

    public class Display
    {
        private double size;

        private ulong numberOfColors;

        public Display(double size, ulong numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (double.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException("The size must be a valid double number");
                }
                if (value < 1)
                {
                    throw new IndexOutOfRangeException("The size can not be smaller than one inch");
                }
                this.size = value;
            }
        }

        public ulong NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return $"Display\nSize: {this.Size}\nNumber of colors: {this.NumberOfColors}";
        }
    }
}
