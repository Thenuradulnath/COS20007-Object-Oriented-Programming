using System;

namespace SemesterTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales();

            //firstbatch
            Batch FirstBatch = new Batch("2024x00001", "CompSci Books");
            FirstBatch.Add(new Transaction("1", "Deep Learning in Python", 90));
            FirstBatch.Add(new Transaction("2", "C# in Action", 80));
            FirstBatch.Add(new Transaction("3", "Design Patterns", 40));
            sales.Add(FirstBatch);

            //ST
            sales.Add(new Transaction("2024x00002", "HungerGames", 40));

            //nest
            Batch NestedBatch = new Batch("2024x00003", "Nested Batch");
            NestedBatch.Add(new Transaction("NBT-ID-001", "NB Transaction 1", 40));
            NestedBatch.Add(new Transaction("NBT-ID-002", "NB Transaction 2", 50));
            sales.Add(NestedBatch);

            //emp
            Batch EmptyBatch = new Batch("2024x00004,", "Fantasy Books");
            sales.Add(EmptyBatch);
            
            sales.PrintOrders();
        }
    }
}
