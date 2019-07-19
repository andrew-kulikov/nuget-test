using System;
using cloud.trading.viewBusinessObjects.Container;
using cloud.trading.viewBusinessObjects.Enum;
using SampleLib;

namespace CliTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var c = new Calculator();
            var x = new AccountInfoContainer {AccountingType = AccountingType.Cash};

            Console.WriteLine(c.Add(1, 2));
            Console.WriteLine(x.AccountingType);
        }
    }
}
