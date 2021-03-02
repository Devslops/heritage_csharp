using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Laptop : Computer
    {
        private String screen;
        private bool batteryLoad;

        public Laptop(String screen, bool batteryLoad, long id, String brand, String model, double processorFrequency, int ram) :
            base(id, brand, model, processorFrequency, ram) {
                this.screen = screen;
                this.batteryLoad = batteryLoad;
            }

        public void sleep()
        {
            Console.WriteLine("laptop sleep");
        }
        public void load()
        {
            Console.WriteLine("laptop load");
        }

        public String getScreen() { return this.screen;  }
        private void setScreen(String screen) { this.screen = screen; }
        public bool getBatteryLoad() { return this.batteryLoad; }
        private void setBatteryLoad(bool batteryLoad) { this.batteryLoad = batteryLoad; }
        
    }
}
