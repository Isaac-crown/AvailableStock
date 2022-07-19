using System;

namespace Stocks
{


    public class Program
    {
        public static void Main()
        {
            List<Goods> objects = new List<Goods>();
            objects.Add(new Goods() { Id = 1, Name= "Electric Irons", AvailableGoods = 120, Restock = 100,  Sales = 80});
            objects.Add(new Goods() { Id = 2, Name = "Switch", AvailableGoods = 170, Restock = 50, Sales = 10 });
            objects.Add(new Goods() { Id = 3, Name = "Cables", AvailableGoods = 150, Restock = 80, Sales = 11 });
            objects.Add(new Goods() { Id = 4, Name = "Extensions", AvailableGoods = 110, Restock = 90, Sales = 17 });
            objects.Add(new Goods() { Id = 5, Name = "Bulbs", AvailableGoods = 110, Restock = 80, Sales = 50 });
            objects.Add(new Goods() { Id = 6, Name = "Chargers", AvailableGoods = 170, Restock = 70, Sales = 8 });
            objects.Add(new Goods() { Id = 7, Name = "Tv Guards", AvailableGoods = 150, Restock = 70, Sales = 8 });
            objects.Add(new Goods() { Id = 8, Name = "Fuses", AvailableGoods = 90, Restock = 70, Sales = 8 });
            objects.Add(new Goods() { Id = 9, Name = "Freezers", AvailableGoods = 140, Restock = 70, Sales = 8 });
            objects.Add(new Goods() { Id = 10, Name = "Lamps", AvailableGoods = 140, Restock = 70, Sales = 8 });


            Console.WriteLine("Pick an option");
            Console.WriteLine("1. Make Enquiry on stocks");
            Console.WriteLine("2. Exit");
            

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
            Console.Clear();

            foreach (Goods obj in objects)

            {
    
            Console.WriteLine(obj.Id + " " + obj.Name);

            }

             
            }
            Console.WriteLine("Make a choice");
            int check = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 0; i < objects.Count; i++)
             {

             if (objects[i].Id == check)
             {
            Console.Clear();
            Console.WriteLine( objects[i].Name);
            Console.WriteLine("Available Goods = {0}", objects[i].AvailableGoods);
            Console.WriteLine("Restock Goods = {0}", objects[i].Restock);
            Console.WriteLine("Sales = {0}", objects[i].Sales);

            }
    }


            Console.ReadKey();



        }








    }



}
                                                                 