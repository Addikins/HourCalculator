using System;
using System.Collections.Generic;

namespace HourCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            string typedInput = null;
            List<float> hours = new List<float>();
            int hourlyRate = 0;
            float totalHours = 0;
            float totalInvoice = 0;

            Console.WriteLine("Enter your hours. Type 'done' when finished");

            while (typedInput == null || typedInput.ToLower() != "stop")
            {
                Console.WriteLine("Enter Hours:");
                typedInput = Console.ReadLine();
                if (typedInput.ToLower() == "stop") { break; }
                hours.Add(Convert.ToSingle(typedInput));
            }
            Console.WriteLine("Enter Rate:");
            hourlyRate = Convert.ToInt32(Console.ReadLine());

            float[] subTotals = new float[hours.Count];

            Console.WriteLine("Sub Totals For Each Day:");
            for (int i = 0; i < hours.Count; i++)
            {
                //Console.WriteLine(hours[i]);
                subTotals[i] = hours[i] * hourlyRate;
                totalHours += hours[i];
                totalInvoice += subTotals[i];

                Console.WriteLine(subTotals[i]);
            }
            Console.WriteLine("Total Hours: " + totalHours);
            Console.WriteLine("Total Invoice: " + totalInvoice);
        }
    }
}
