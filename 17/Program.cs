using System;

namespace _17
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double annualGrossPay = 0;
            double totalBonuses = 0;

            getGrossPay(annualGrossPay);
            double grossPay = double.Parse(Console.ReadLine());
            getBonuses(grossPay);
            double bonuses = double.Parse(Console.ReadLine());
            showGrossPayContrib(grossPay);
            showBonusContrub(bonuses);
        }
        public static void getGrossPay(double grossPay)
        {
            Console.WriteLine("Wprowadź wartośc wynagrodzenia.");
            
        }
        public static void getBonuses(double bonuses)
        {
            
            Console.WriteLine("Wprowadź wartość wypłaconych premii.");
            

        }
        public static void showGrossPayContrib(double grossPay)
        {
            
            double contribution_rate = 0.05;
            double contrib;
            contrib = grossPay * contribution_rate;
            Console.WriteLine($"Wartość składki naliczona od wynagrodzenia wynosi {contrib} zł.");
        }
        public static void showBonusContrub(double bonuses)
        {
            
            double contribution_rate = 0.05;
            double contrib;
            contrib = bonuses * contribution_rate;
            Console.WriteLine($"Wartość składki naliczona od premii wynosi {contrib} zł.");
        }
    }
}
