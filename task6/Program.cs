#region Task1
//using System;

//class Program
//{
//    static void Main()
//    {
//        string metn = "Bu bir {7} numune metndir. {8} simvollarini ehate edir.";


//        int CountA = 0;
//        int CountB = 0;


//        for (int i = 0; i < metn.Length; i++)
//        {

//            if (metn[i] == '{' && i < metn.Length - 1 && metn[i + 1] == 'a')
//            {

//                CountA++;
//            }
//            else if (metn[i] == '{' && i < metn.Length - 1 && metn[i + 1] == 'b')
//            {

//                CountB++;
//            }
//        }


//        Console.WriteLine("Metn: " + metn);
//        Console.WriteLine("{a} simvolunun sayi: " + CountA);
//        Console.WriteLine("{b} simvolunun sayi: " + CountB);

//        if (CountA > CountB)
//        {
//            Console.WriteLine("{a} simvolu {b} simvolundan çoxdur.");
//        }
//        else if (CountA < CountB)
//        {
//            Console.WriteLine("{a} simvolu {b} simvolundan azdır.");
//        }
//        else
//        {
//            Console.WriteLine("{a} simvolu {b} simvoluna bərabərdir.");
//        }
//    }
//}







#endregion

#region Task 2
//using System;

//class Program
//{
//    static void Main()
//    {

//        string metn = "{9} Bu bir numune metndir.";


//        bool hamisiA = true;

//        for (int i = 0; i < metn.Length; i++)
//        {

//            if (i < metn.Length - 1 && metn[i] == '{' && metn[i + 1] != 'a')
//            {
//                hamisiA = false;
//                break;
//            }
//        }


//        Console.WriteLine("Metn: " + metn);
//        Console.WriteLine("Sol terefden beraberdir: " + hamisiA);
//    }
//}
#endregion


//using System;

//class Program
//{
//    static void Main()
//    {

//        string metn = "{6} Bu bir numunə metndir.";


//        bool hamisiB = true;

//        for (int i = 0; i < metn.Length; i++)
//        {

//            if (i < metn.Length - 1 && metn[i] == '{' && metn[i + 1] != 'b')
//            {
//                hamisiB = false;
//                break;
//            }
//        }


//        Console.WriteLine("Metn: " + metn);
//        Console.WriteLine("Sol terefdən beraberdir: " + hamisiB);
//    }
//}



