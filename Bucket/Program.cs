using System;
using System.Linq;
using Bucket.Data;

namespace Bucket
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterBucket bucket = new WaterBucket();
            bucket.Overflowing += Bucket_Overflowing;
            bucket.Overflowed += Bucket_Overflowed;
            bucket.Fill(14);
        }

        private static void Bucket_Overflowing(object sender, int e)
        {
            Console.WriteLine($"You donkey, what are you doing? You are overflowing {e} liters too much!");
        }

        private static void Bucket_Overflowed(object sender, int e)
        {
            Console.WriteLine($"You messed up everything! {e} liters!?");
        }
    }
}
