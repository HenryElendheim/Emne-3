namespace Undervisning_Emne_3
{
    internal class Datatyper
    {
        private int _number = 1;

        private float _decimalNumb = 1.05F;
        private double _decimalNumb2 = 1.5;
        private decimal _decimalNumb3 = 1.8M;

        private char _symbol = 'A';
        private string _text = "Greetings";

        private bool _trueFalse = false;

        private int[] _numbArray = { 1, 2, 3 };
        private string[] _stringArray = { "Hello", "My", "Friend" };

        private List<int> _listWithNumbers = new List<int> { 1, 2, 3 }; //Makes a new list with numbers

        public int NumberFive()
        {
            return 5;
        }

        private int _a = 5;
        private int _b = 3;

        private int ReturnWholeNumber(int _a, int _b)
        {
            return _a + _b;
        }


        public void Run()
        {
            Console.WriteLine($"Summen er: {ReturnWholeNumber(_a, _b)}");
        }

        public void Test()
        {
            for (int i = 0; i < _listWithNumbers.Count; i++)
            {
                _listWithNumbers.Add(4);
                Console.WriteLine(_listWithNumbers[i]);
                if (_listWithNumbers.Count == 15)
                {
                    break;
                }
            }

        }

        public void NoReturn()
        {
            Console.WriteLine("Denne metoden returnerer ingenting!");
        }


        private int _number1 = 5;
        private int _number2 = 2;


        public bool Conditions(int _number1, int _number2)
        {
            if (_number1 == _number2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int Conditions2(int _number1, int _number2)
        {
            if (_number1 == _number2)
            {
                return _number1 *= _number2;
            }
            else
            {
                return _number1 += _number2;
            }
        }


        public bool Conditions3(int _number1, int _number2)
        {
            int sum = _number1 + _number2;
            if (_number1 >= 30 || _number2 >= 30 || sum >= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

