﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>>
            {
                {"Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },

                {"Koenigsegg Agera RS", new List<int> {2, 3, 5, 6, 7} },

                {"Lamborghini Aventador", new List<int> {20, 18, 22, 24, 16} },

                {"Pagani Huayra", new List<int> {4, 5, 6, 5, 4 } },

                { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }

            };

            double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();
            Console.WriteLine("Media de vendas do Bugatti Veyron: " + mediaVendasBugatti);



                      }
    }
}
