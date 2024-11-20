namespace test_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            do
            {
                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Enter your choice :");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a numbers");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest numbers");
                Console.WriteLine("L - Display the largest numbers");
                Console.WriteLine("I - search in the index ");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.Write("===>");
                char chose =char.Parse(Console.ReadLine().ToUpper());
                
                switch (chose)
                {
                    case 'A':
                        
                            Console.WriteLine($"enter value ");
                            list.Add(int.Parse(Console.ReadLine()));

                        
                        break;
                        
                    case 'P':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        else {
                        Console.Write("[ ");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write(list[i]+ " " );
                        }
                        Console.Write("]\n");
                        }
                        
                        break;
                        
                    case 'S':
                        int smallest = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < smallest)
                            {
                                smallest = list[i];
                            }
                        }
                        Console.WriteLine($"small = {smallest}");
                        
                        break;
                    case 'L':
                        int large = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > large)
                            {
                                large = list[i];
                            }
                        }
                        Console.WriteLine($"Large = {large}");
                       
                        break;
                    case 'I':
                        Console.Write("enter the num");
                        int num = int.Parse(Console.ReadLine());
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == num)
                                Console.WriteLine($"index = {i}");

                        }

                        break;
                    case 'M':
                        int sum = 0;
                        double avarage = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        avarage = sum / list.Count;
                        Console.WriteLine($"Sum = {sum}");
                        Console.Write($"Avarage = {avarage}");
                        break;
                    case 'C':
                        list.Clear();
                        Console.WriteLine("List is clear ");
                        break;
                    case 'Q':
                        Console.WriteLine("Quit");
                        break;
                    default:
                        Console.WriteLine("Goodbay");
                        break ;
                }
               
                

                
            }
            while (true);

        }
    }

}