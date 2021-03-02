using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
   public class Computer
    {
        private long id;
        private String brand;
        private String model;
        private double processorFrequency;
        private int ram;

        public Computer(long id, String brand, String model, double processorFrequency, int ram)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.processorFrequency = processorFrequency;
            this.ram = ram;
        }

        public void start()
        {
            Console.WriteLine("computer start");
        }
        public void halt()
        {
            Console.WriteLine("computer halt");
        }

        public int getRam() { return this.ram; }
        protected void setRam(int ram) { this.ram = ram; }
        public double getProcessorFrequency() { return this.processorFrequency; }
        protected void setProcessorFrequency(double processorFrequency) { this.processorFrequency = processorFrequency; }
        public long getId() { return this.id; }
        public String getBrand() { return this.brand; }
        public void setBrand(String brand) { this.brand = brand; }
        public String getModel() { return this.model; }
        public void setModel(String model) { this.model = model; }
    }
}
