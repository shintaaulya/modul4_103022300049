// See https://aka.ms/new-console-template for more information
using System;

public class kodeProduk
{
    public enum Produk
    {
        Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera
    }

    public static String[] ListkodeProduk = { "E100", "E101", "E102", "E103", "104", "105", "E106", "E107", "E108", "E109" };


    public static String getKodeProduk(Produk produk)
    {
        return ListkodeProduk[(int)produk];
    }

    public static void Main()
    {
        String input = Console.ReadLine();

        Enum.TryParse(input, true, out kodeProduk.Produk produk);
        {
            String kodeProduk = getKodeProduk(produk);
            Console.WriteLine($"kodeproduk{produk}; {kodeProduk}");
        }
    }


}


//public class FanLaptop
//    {
//        enum State {Quiet, Balanced, Performance, Turbo};
//    public static void Main(string[] args)
//    {
//        State state = State.Quiet;
//        String[] fan = { "Quiet", "Balanced", "Performance", "Turbo" };
//        while (state != State.Quiet) 
//        {
//            Console.WriteLine(fan[(int)state] + "fan");
//            Console.Write("Enter Command : ");

//            String command = Console.ReadLine();
//            switch (state) 
//            {
//                case State.Quiet:
//                    if (command == "")
//                        state = State.Quiet;
//                    break;
//                case State.Balanced:
//                    if (command == "Balanced")
//                        state = State.Balanced;
//                    break;
//                case State.Performance:
//                    if (command == "Performance")
//                        state = State.Performance;
//                    break;
//                case State.Turbo:
//                    if (command == "Turbo")
//                        state = State.Turbo;
//                    break;
           
//                    Console.WriteLine(""
//            }
//        }
//    }
//    }
