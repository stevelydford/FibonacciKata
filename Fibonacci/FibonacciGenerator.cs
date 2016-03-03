namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public int[] Generate(int number)
        {
            if (number <= 0 || number > 30)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            var fibonacciSequence = new int[number];

            for (var i = 0; i < number; i++)
            {
                fibonacciSequence[i] = GetNumberAtPosition(i);
            }

            return fibonacciSequence;
        }

        private static int GetNumberAtPosition(int position)
        {
            if (position > 1)
                return GetNumberAtPosition(position - 1) + GetNumberAtPosition(position - 2);

            return position;
        }
    }
}
