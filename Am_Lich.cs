using System;

namespace Am_Lich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi ban nhap nam:");
            int Year = int.Parse(Console.ReadLine());
            String val_Can = " ";
            String val_Chi = " ";
            switch (Year % 10)
            {
                case 0:
                    val_Can = "Canh";
                    break;
                case 1:
                    val_Can = "Tan";
                    break;
                case 2:
                    val_Can = "Nham";
                    break;
                case 3:
                    val_Can = "Quy";
                    break;
                case 4:
                    val_Can = "Giap";
                    break;
                case 5:
                    val_Can = "At";
                    break;
                case 6:
                    val_Can = "Binh";
                    break;
                case 7:
                    val_Can = "Dinh";
                    break;
                case 8:
                    val_Can = "Mau";
                    break;
                case 9:
                    val_Can = "Ky";
                    break;
            }
            switch (Year % 12)
            {
                case 0:
                    val_Chi = "Than";
                    break;
                case 1:
                    val_Chi = "Dau";
                    break;
                case 2:
                    val_Chi = "Tuat";
                    break;
                case 3:
                    val_Chi = "Hoi";
                    break;
                case 4:
                    val_Chi = "Ti";
                    break;
                case 5:
                    val_Chi = "Suu";
                    break;
                case 6:
                    val_Chi = "Dan";
                    break;
                case 7:
                    val_Chi = "Mao";
                    break;
                case 8:
                    val_Chi = "Thin";
                    break;
                case 9:
                    val_Chi = "Ti";
                    break;
                case 10:
                    val_Chi = "Ngo";
                    break;
                case 11:
                    val_Chi = "Mui";
                    break;
            }
            Console.WriteLine("Nam {0} am lich la:{1} {2}", Year, val_Can, val_Chi);
        }
    }
}
