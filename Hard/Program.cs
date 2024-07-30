using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int number;
            do {
                Console.WriteLine("1: Viết hàm đảo ngược ký tự của từng từ trong một câu");
                Console.WriteLine("2: Cho hàm random() trả về giá trị từ 0 đến 1(có lấy 0 và 1).Viết hàm randomRange(a, b) trong đó dùng hàm random() để trả về một giá trị random trong khoảng từ a đến b");
                Console.WriteLine("3: Viết hàm nối 2 mảng số đã sắp xếp theo thứ tự tăng dần");
                Console.WriteLine("4: Viết hàm nối 2 mảng số đã sắp xếp theo thứ tự giảm dần");
                Console.WriteLine("5: Viết hàm nối 2 mảng số đã sắp xếp theo thứ tự tăng dần");
                Console.WriteLine("6: Viết hàm nối 2 mảng số đã sắp xếp theo thứ tự giảm dần");
                Console.WriteLine("7: Viết hàm đổi từ số tiền bắng số sang số tiền bằng chữ");
                Console.WriteLine("8: Ngân hàng nhà nước việt nam có các loại tiền 1 nghìn, 2 nghìn, 5 nghìn, 10 nghìn, 50 nghìn và 100 nghìn 500 nghìn.Viết hàm tính số đồng tiền ít nhất khi quy đổi một số tiền nhất định");
                Console.WriteLine("9: Viết hàm tình tổng số lần xuất hiện của một string a trong string b");
                Console.WriteLine("10: Viết hàm xáo trộn thứ tự của các phần tử trong mảng số");
                Console.WriteLine("11: Viết hàm trả về chữ số cuối cùng khác 0 của n giai thừa");
                Console.WriteLine("12:Viết hàm trả về số chữ số 0 xuất hiện trong giá trị của n giai thừa");
                Console.WriteLine("Chọn 0: Kết thúc trương trình");

                do
                {
                    Console.WriteLine("Mời bạn chọn câu hỏi:");
                    string input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out number);
                }
                while (number < 0 || number > 12);

                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhập một mảng ký tự: ");
                            string kyTu = Console.ReadLine();
                            string result = ReverseCharactersInWords(kyTu);
                            Console.WriteLine("Chuỗi sau khi đảo chiều: " + result);
                        }
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        {
                            Console.Write("Nhập kích thước của  mảng A: ");
                            int sizeA = int.Parse(Console.ReadLine());
                            double[] arrayA = new double[sizeA];
                            Console.WriteLine("Nhập mảng A: ");
                            for (int i = 0; i < sizeA; i++)
                            {
                                arrayA[i] = double.Parse(Console.ReadLine());
                            }
                            Console.Write("Nhập kích thước của  mảng B: ");
                            int sizeB = int.Parse(Console.ReadLine());
                            double[] arrayB = new double[sizeB];
                            Console.WriteLine("Nhập mảng B: ");
                            for (int j = 0; j < sizeB; j++)
                            {
                                arrayB[j] = double.Parse(Console.ReadLine());
                            }
                            double[] arrayC = arrayA.Concat(arrayB).ToArray();
                            TangDan(arrayC);
                            foreach (int k in arrayC)
                            {
                                Console.Write(k + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        { 
                        Console.Write("Nhập kích thước của  mảng A: ");
                        int sizeA = int.Parse(Console.ReadLine());
                        double[] arrayA = new double[sizeA];
                        Console.WriteLine("Nhập mảng A: ");
                        for (int i = 0; i < sizeA; i++)
                        {
                            arrayA[i] = double.Parse(Console.ReadLine());
                        }
                        Console.Write("Nhập kích thước của  mảng B: ");
                        int sizeB = int.Parse(Console.ReadLine());
                        double[] arrayB = new double[sizeB];
                        Console.WriteLine("Nhập mảng B: ");
                        for (int j = 0; j < sizeB; j++)
                        {
                            arrayB[j] = double.Parse(Console.ReadLine());
                        }
                        double[] arrayC = arrayA.Concat(arrayB).ToArray();
                        GiamDan(arrayC);
                        foreach (int k in arrayC)
                        {
                            Console.Write(k + " ");
                        }
                        Console.WriteLine();
                }
                    break;
                    case 5:
                        {
                            Console.Write("Nhập kích thước của  mảng A: ");
                            int sizeA = int.Parse(Console.ReadLine());
                            double[] arrayA = new double[sizeA];
                            Console.WriteLine("Nhập mảng A: ");
                            for (int i = 0; i < sizeA; i++)
                            {
                                arrayA[i] = double.Parse(Console.ReadLine());
                            }
                            Console.Write("Nhập kích thước của  mảng B: ");
                            int sizeB = int.Parse(Console.ReadLine());
                            double[] arrayB = new double[sizeB];
                            Console.WriteLine("Nhập mảng B: ");
                            for (int j = 0; j < sizeB; j++)
                            {
                                arrayB[j] = double.Parse(Console.ReadLine());
                            }
                            double[] arrayC = arrayA.Concat(arrayB).ToArray();
                            TangDan(arrayC);
                            foreach (int k in arrayC)
                            {
                                Console.Write(k + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        {
                            Console.Write("Nhập kích thước của  mảng A: ");
                            int sizeA = int.Parse(Console.ReadLine());
                            double[] arrayA = new double[sizeA];
                            Console.WriteLine("Nhập mảng A: ");
                            for (int i = 0; i < sizeA; i++)
                            {
                                arrayA[i] = double.Parse(Console.ReadLine());
                            }
                            Console.Write("Nhập kích thước của  mảng B: ");
                            int sizeB = int.Parse(Console.ReadLine());
                            double[] arrayB = new double[sizeB];
                            Console.WriteLine("Nhập mảng B: ");
                            for (int j = 0; j < sizeB; j++)
                            {
                                arrayB[j] = double.Parse(Console.ReadLine());
                            }
                            double[] arrayC = arrayA.Concat(arrayB).ToArray();
                            GiamDan(arrayC);
                            foreach (int k in arrayC)
                            {
                                Console.Write(k + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        {
                            Console.Write("Nhập số tiền = ");
                            long amount = long.Parse(Console.ReadLine());
                            string amountWords = NumberToWords(amount);
                            Console.WriteLine(amountWords);
                        }
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;

                }
            }
            while (number != 0);
        }
        //Hàm đổi tiền từ số qua chữ
        static string NumberToWords(long number)
        {
            if (number == 0)
                return "Không đồng";

            if (number < 0)
                return "Âm " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " tỷ ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "và ";

                var unitsMap = new[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                var tensMap = new[] { "không", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

                if (number < 10)
                    words += unitsMap[number];
                else if (number < 20)
                    words += "mười " + unitsMap[number - 10];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words.Trim();
        }
        //Hàm đảo từ
        static string ReverseCharactersInWords(string kyTu)
        {
            string[] words = kyTu.Split(' ');
            for(int i =0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
            return string.Join(" ", words);
        }
        static void TangDan(double[] array)
        {
            Array.Sort(array);
        }

        // Hàm sắp xếp mảng theo thứ tự giảm dần
        static void GiamDan(double[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
    }
}
