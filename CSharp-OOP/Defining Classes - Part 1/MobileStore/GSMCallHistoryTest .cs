namespace MobileStore
{
    using System;

    public class GSMCallHistoryTest
    {
        public static void AddCalls(GSM gsm)
        {
            gsm.AddCall(new Call("0882323436", 74));
            gsm.AddCall(new Call("0882323436", 7324));
            gsm.AddCall(new Call("0882323436", 7344));
            gsm.AddCall(new Call("0882323436", 123474));
            gsm.AddCall(new Call("0882323436", 174));
            gsm.AddCall(new Call("0882323436", 574));
        }

        public static void CallsInfo(GSM gsm)
        {
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine("*****New call*****");
                Console.WriteLine(call);
            }
        }

        public static void PrintTotalPrice(GSM gsm, double price)
        {

            Console.WriteLine("Total price is: {0}", gsm.Price);
        }

        public static void RemoveLongestCall(GSM gsm)
        {
            const int start = 0;

            long longestCall = start;
            int index = start;

            for (int i = start; i < gsm.CallHistory.Count; i++)
            {
                if (gsm.CallHistory[i].Duration > longestCall)
                {
                    longestCall = gsm.CallHistory[i].Duration;
                    index = i;
                }
            }
            gsm.DeleteCall(index);
        }
    }
}