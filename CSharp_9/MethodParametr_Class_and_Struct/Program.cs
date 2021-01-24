using System;

namespace MethodParametr_Class_and_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            TheClass theClass = new TheClass("Not Change");
            TheStruct theStruct = new TheStruct("Not Change");

            Console.WriteLine($"Original TheClass field Name: {theClass.Name}");
            Console.WriteLine($"Original TheStruct field Name: {theStruct.Name}\n");

            theClass.ChangeNameClass(theClass);
            theStruct.ChangeNameStruct(theStruct);

            Console.WriteLine($"Change TheClass field Name: {theClass.Name}");
            Console.WriteLine($"Change TheStruct field Name: {theStruct.Name}");
        }
    }

    class TheClass
    {
        public string Name;
        public TheClass(string Name)
        {
            this.Name = Name;
        }
        public void ChangeNameClass(TheClass ChangeName)
        {
            ChangeName.Name = "Change";
        }
    }
    struct TheStruct
    {
        public string Name;
        public TheStruct(string Name)
        {
            this.Name = Name;
        }
        public void ChangeNameStruct(TheStruct ChangeName)
        {
            ChangeName.Name = "Change";
        }
    }
}
