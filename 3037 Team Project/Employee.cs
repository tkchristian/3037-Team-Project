using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _3037_Team_Project
{
    class Employee
    {
        //Creating properties so that the only properties that can be changed outside
        //the class is the name
        public string Name { set; get; }
        public int ID { get; }
        public float HoursWorked { set; get; }
        public float HoursBreak { get; }
        private float wage;
        private Stopwatch timer = new Stopwatch();
        
        public Employee(string name, int id, int wage)
        {
            this.Name = name;
            this.ID = id;
            this.wage = wage;
            this.HoursWorked = 0;
            this.HoursBreak = 0;
        }

        public void Clock_In()
        {
            //Set timer to on this will continue to keep time until there is a Clock_Out function called
            this.timer.Start();
        }

        public void Clock_Out()
        {
            //Turn timer off
            //Create a TimeSpan vairiable to convert milliseconds into Hours and Minutes
            this.timer.Stop();
            TimeSpan worked = timer.Elapsed;
            //HoursWorked will hold the TimeSpan property Hours+ (Minutes/60)
            this.HoursWorked = (float)(worked.Hours + (worked.Minutes / 60));
        }

        public void Clock_Out(float hour)
        {
            //This is a overridden Clock_Out function for if they want to manually input hours, it will also turn timer off if it is on
            this.HoursWorked = hour;
            if (this.timer.IsRunning)
            {
                this.timer.Stop();
            }
        }

        public void ChangeWage(float newWage)
        {
            this.wage = newWage;
        }
    }
}
