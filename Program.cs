
//int[] numbers = new int[0];
//int[] comp=new int[0];
//int[] prime=new int[0];


//Console.WriteLine("Do you want entered data");
//int len = int.Parse(Console.ReadLine());

//int count = 0;

//for (int i = 0; i < len; i++)
//{
//    Console.WriteLine("Please enter value");
//    int value = int.Parse(Console.ReadLine());

//    switch (value)
//    {
//        case 0:
//            Console.WriteLine("The minimum value you enter can be 1");
//            return;
//        case < 0:
//            Console.WriteLine("The value you enter must be greater than 0");
//            return;
//        default:
//            Array.Resize(ref numbers, numbers.Length + 1);
//            numbers[numbers.Length - 1] = value;
//            break;
//    }
//}


//for (int i = 0; i < numbers.Length; i++)
//{
//    count = 0;
//    for (int j = 2; j < numbers[i]; j++)
//    {
//        if (numbers[i] % j == 0)
//            count++;
//    }

//    if(count > 0)
//    {
//        Array.Resize(ref comp, comp.Length + 1);
//        comp[comp.Length - 1] = numbers[i];
//    }
//    else
//    {
//        Array.Resize(ref prime, prime.Length + 1);
//        prime[prime.Length - 1] = numbers[i];
//    }
//}
//Console.WriteLine("Composide numbers");
//foreach (var c in comp)
//{
//    Console.WriteLine(c);
//}

//Console.WriteLine("Prime numbers");
//foreach (var p in prime)
//{
//    Console.WriteLine(p);
//}





