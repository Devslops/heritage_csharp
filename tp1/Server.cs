using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    class Server : Computer
    {
        public int bayNumber { get; set; }
        public int raid { get; set; }

        public Server(int bayNumber, int raid, long id, String brand, String model, double processorFrequency, int ram) :
            base(id, brand, model, processorFrequency, ram)
            {
                this.bayNumber = bayNumber;
                this.raid = raid;
            }

        public void backup()
        {
            Console.WriteLine("backup");
        }
    }
}
