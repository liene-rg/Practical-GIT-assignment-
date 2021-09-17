using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace DS_asgm_3
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            dictionary.Add("Rice,", 0.5);
            dictionary.Add("Cream", 0.8);
            dictionary.Add("Bagels", 2);
            dictionary.Add("Cookies", 3.5);
            dictionary.Add("Avocado", 0.95);
            dictionary.Add("Candy", 4.5);


            Hashtable productPrices = new Hashtable(dictionary);

            productPrices.Add("Bread", 1.5);
            productPrices.Add("Milk", 0.9);
            productPrices.Add("Cheese", 5.8);
            productPrices.Add("Butter", 1.5);
            productPrices.Add("Onions", 0.5);
            productPrices.Add("Meat", 5);
            productPrices.Add("Lemonade", 1.5);



            var minPrice = dictionary.Values.Min();


            Console.WriteLine("The minimum price is " + minPrice);

            foreach (DictionaryEntry entry in productPrices)
            {
                Console.WriteLine("Product name " + entry.Key + ":Product price " + entry.Value);



            }






        }
    }

}