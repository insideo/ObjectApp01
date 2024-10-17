using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectApp01
{
    internal class Surename
    {
        public Surename() {
            this.Name = null;
            this.Rank = 0;
            this.Count = 0;
            
        }
        public Surename(string name, int rank, int count) { 
            this.Name = name;
            this.Rank = rank;
            this.Count = count;
            
        }

        public string? Name { get; set; }
        public int Rank { get; set; }
        public int Count { get; set; }

        

        public Surename[] GetSurnameArray(string? pathToFile)
        {
            if (pathToFile == null || pathToFile.Length == 0)
            {
                pathToFile = "..\\..\\..\\Resources\\surnames.csv";
                var lines = File.ReadLines(pathToFile).ToArray();
                int count = lines.Count()-1;
                Surename[] names = new Surename[count];
                for (int i = 1; i < count; i++)
                {
                    string[] splitedLine = lines[i].Split(",");
                    if (splitedLine.Length > 0)
                    {
                        names[i-1] = new Surename(splitedLine[0], int.Parse(splitedLine[1]), int.Parse(splitedLine[2]));
                    }
                }
                return names;

            }
            return null;
        }

    }
}
