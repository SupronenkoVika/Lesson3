namespace Lesson3
{
    internal class QueueRes
    {
        static public Queue<double> lastResults = new Queue<double>();
        public double AddToQueue(double res)
        {
            var input = res;
            lastResults.Enqueue(input);
            if (lastResults.Count > 5)
            {
                lastResults.Dequeue();
            }
            return input;
        }

        public void LastResults()
        {
            Console.WriteLine("History of last 5 results: ");
            int num = 0;
            foreach (var item in lastResults)
            {
                ++num;
                Console.WriteLine($"Result {num}:  {item}");
            }
        }
    }
}

