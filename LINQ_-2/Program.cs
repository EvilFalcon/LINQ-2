using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ__2
{
    internal class Program
    {
        public static void Main()
        {
            DrowInfo showDrowInfo = new DrowInfo();

            string articleAmnesty = "Антиправительственное";

            List<Criminal> criminals = new List<Criminal>
            {
                new Criminal("Педро Алонсо Лопес", "Антиправительственное"),
                new Criminal("Усама бен Ладан", "Кража"),
                new Criminal("Матео Мессина Денаро", "Антиправительственное"),
                new Criminal("Джозеф Кони", "Разбой"),
            };
            
        
            showDrowInfo.ShowInfo(criminals);
            
            criminals = criminals.Where(criminal => criminal.Article !=articleAmnesty ).ToList();


            showDrowInfo.ShowInfo(criminals);
            Console.ReadKey();
        }
    }

    public class DrowInfo
    {
        public void ShowInfo(IEnumerable<Criminal> criminals)
        {
            Console.WriteLine(new string('_', 40));

            Console.WriteLine("В местах лишения свободы");

            foreach (var criminal in criminals)
            {
                Console.WriteLine($"{criminal.FullName} {criminal.Article}");
            }

            Console.WriteLine(new string('_', 40));
        }
    }

    public class Criminal
    {
        public Criminal(string fullName, string article)
        {
            FullName = fullName;
            Article = article;
        }

        public string FullName { get; }
        public string Article { get; }
    }
}