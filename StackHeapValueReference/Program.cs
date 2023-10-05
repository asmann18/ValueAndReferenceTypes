namespace StackHeapValueReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, };
            InsertArray(ref arr,12,21,321,12,312);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hello, World! \n \n \n");
            //Task 2
            int Balance = 0;
            restart:

            Console.WriteLine("1.Check up Balance");
            Console.WriteLine("2.Top up Balance");
            Console.WriteLine("3.Pay to Balance");
            Console.WriteLine("0.Exit");
            bool isParse=int.TryParse(Console.ReadLine(), out int menu);
            if(!isParse ||  menu < 0)
            {
                Console.Clear();
                Console.WriteLine("duzgun simvol daxil edin:");
                goto restart;
            }
            switch (menu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Balance:"+CheckBalance(Balance));
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(TopUpBalance(ref Balance));
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(Pay(ref Balance));
                        break;
                case 0:
                    Console.WriteLine("Goodbye :)");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("duzgun simvol daxil edin");
                    break;

            }
            goto restart;
        }

        static int[] InsertArray(ref int[] array, params int[] numbers) {
            int[] newArray= new int[array.Length+numbers.Length];
            int index= 0;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = array.Length; i < newArray.Length; i++)
            {
                newArray[i] = numbers[index];
                index++;
            }
            array = newArray;
            return array;
        }

        static int CheckBalance(int balance)
        {
            return balance;
        }
        static int TopUpBalance(ref int balance) {
            Console.WriteLine("Meblegi daxil edin:");
            restart:
            bool isParse=int.TryParse(Console.ReadLine(), out int amount);
            if (amount >0)
            {
                balance += amount;
                return balance;
            }
            Console.Clear ();
            Console.WriteLine("Duzgun eded daxil edin.");
            goto restart;

        }
        static int Pay(ref int balance)
        {
            Console.WriteLine("Meblegi daxil edin:");
        restart:
            bool isParse = int.TryParse(Console.ReadLine(), out int amount);
            if (amount < balance) { 
            
                balance-=amount;
                return balance;
            }
            if (!isParse)
            {
                Console.Clear();
                Console.WriteLine("Duzgun eded daxil edin");
                goto restart;
            }
                Console.Clear();
            Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur");
            goto restart;
        }
    }
}