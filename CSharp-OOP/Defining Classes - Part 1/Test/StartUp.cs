namespace GSMTest
{
    using MobileStore;
    using System;
    using System.Collections.Generic;
    
    class StartUp
    {
        static void Main(string[] args)
        {
            const double pricePerMinute = 0.37;

            var gsms = new List<GSM>();
            gsms.Add(new GSM("S860", "Lenovo", 500,"Peter", new Batery(BatteryType.NiCd.ToString(), 20, 12), new Display(6, 60000000000000)));
            gsms.Add(new GSM("Desire 820", "HTC", 1000, "Ivaylo", new Batery(BatteryType.LiIon.ToString(), 55, 49), new Display(5.5, 34445566000)));
            gsms.Add(new GSM("Galaxy S6", "Samsung", 1500, "Vankata", new Batery(BatteryType.Other.ToString(), 59, 50), new Display(5.2, 160000000000000)));

            foreach (var mobile in gsms)
            {
                Console.WriteLine(mobile);
                Console.WriteLine(new string('-',20));
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine(GSM.Iphone4s);
            Console.WriteLine(new string('-', 20));
            var gsm = gsms[1];

            GSMCallHistoryTest.AddCalls(gsm);
            GSMCallHistoryTest.CallsInfo(gsm);
            GSMCallHistoryTest.PrintTotalPrice(gsm, pricePerMinute); GSMCallHistoryTest.RemoveLongestCall(gsm);
            GSMCallHistoryTest.PrintTotalPrice(gsm, pricePerMinute);
            gsm.ClearCallHistory();
            GSMCallHistoryTest.CallsInfo(gsm);



        }
    }
}
