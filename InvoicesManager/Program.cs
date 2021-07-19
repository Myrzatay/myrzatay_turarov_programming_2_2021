using System;
using System.Linq;

namespace InvoicesManager
{}
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string path = System.IO.Directory.GetCurrentDirectory()+"/"+file;
            if(System.IO.File.Exists(path)){
                string[] lines = System.IO.File.ReadAllLines(path);
                Console.WriteLine(lines[0]);
                decimal total = 0;
                string[] dates = new string[lines.Length-1];
                for(int i=1; i<lines.Length; i++){
                    string[] line = lines[i].Split(';');
                    total += decimal.Parse( line[0]);
                    dates[i-1] = line[2];
                    Console.WriteLine(lines[i]);
                }
                var distinctDates = dates.Distinct();
                int n=0;
                foreach(var type in distinctDates){
                    n++;
                }
                Console.WriteLine($"Total expenses:{total}");
                Console.WriteLine($"Dates of payment: {n}");
                
            }
            else{
                Console.WriteLine("Incorrect input!");
            }
        }
    }

