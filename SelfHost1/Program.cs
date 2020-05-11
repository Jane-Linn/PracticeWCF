using Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        string input = "";
        using (ServiceHost host = new ServiceHost(typeof(Service)))
        {
            bool open = true;
            host.Open();
            Console.WriteLine("WCF裝載完成");
            Console.WriteLine("輸入exit關閉host");
            while (open)
            {
                input = Console.ReadLine();
               
                if (input.Equals("exit"))
                {
                    open = false;
                }
            }

        }
    }
}
