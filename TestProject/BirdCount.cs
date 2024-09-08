using System;
using TestProject.Models;

namespace TestProject.Functions
{
    public class BirdCount
    {
        private readonly Data _data;

        public BirdCount(Data data)
        {
            _data = data;
        }

        public void LastWeek()
        {
        
        }

        public void Today()
        {
            int today = _data.ThisWeek[6];
            Console.WriteLine($"You have seen {today} birds today.");
        }

        public void IncrementTodaysCount()
        {

        }

        public void HasDayWithoutBirds()
        {

        }

        public void CountForFirstDays()
        {

        }

        public void BusyDays()
        {
            
        }
    }
}
