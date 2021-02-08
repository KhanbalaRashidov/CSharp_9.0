using System;
namespace Example_1
{
    internal class House 
    {
        public House(int floorCount,int flatCount,string address)
        {
            this.floorCount = floorCount;
            this.flatCount = flatCount;
            this.address = address;
        }

        private int floorCount;
        private int flatCount;
        private string address;

        public int FloorCount { get { return floorCount; } }
        public int FlatCount { get { return flatCount; } }
        public string Address { get { return address; } }
    }
}
