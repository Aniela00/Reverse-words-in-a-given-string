namespace exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your sentence, remember to seperate each word with '.'");
            string s = Console.ReadLine();
            Stack<string> stack = new Stack<string>(); 
            foreach (var c in s.Split('.'))
            {
                stack.Push(c);
            }
            foreach (var c in stack)
            {
                Console.Write(c + '.'); //tutaj wiem, że nie potrzebnie dodaję kropkę
                                        //na końcu ostatniego słowa, ale nie wiem jak to obejść
            }
        }
    }
}
