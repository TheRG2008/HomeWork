using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            Model model = new Model();

            view.Hello();
            model.EnterNumber();
            model.Calculation();
            view.Result(model.Factorial, model.Sum, model.MaxEvenNumber);
        }
    }

    public class Model
    {
        private int _factorial = 1;
        private int _sum = 0;
        private int _maxEvenNumber = 0;
        private int _number;
        private string _enteredNumber;

        public int Factorial
        {
            get => _factorial;
            private set => _factorial = value;
        }
        public int Sum
        {
            get => _sum;
            private set => _sum = value;
        }
        public int MaxEvenNumber
        {
            get => _maxEvenNumber;
            private set => _maxEvenNumber = value;
        }

        public void EnterNumber()
        {
            _enteredNumber = Console.ReadLine();

            if (_enteredNumber == "q")
                return;
        }

        public void Calculation()
        {
            _number = Int32.Parse(_enteredNumber);

            for (int i = 1; i <= _number; i++)
            {
                Factorial = Factorial * i;
                Sum = Sum + i;
                if (i % 2 == 0)
                {
                    MaxEvenNumber = i;
                }
            }
        }

    }
    public class View
    {
        public void Hello()
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("пажалуйста введите число. ");
        }

        public void Result(int factorial, int sum, int maxEvenNumber)
        {
            Console.WriteLine("Факториал равет " + factorial); Console.WriteLine("Сума от 1 до N равна " + sum);

            Console.WriteLine("максимальное четное число меньше N равно" + maxEvenNumber);
            Console.ReadLine();
        }
    }
}
