using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFname = Console.ReadLine();
        string managerLname = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}",companyAddress);
        Console.WriteLine("Tel. {0}",phoneNumber);
        if (faxNumber == "")
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}",faxNumber);
        }
        Console.WriteLine("Web site: {0}",webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFname,managerLname,managerAge,managerPhone);
    }
}
