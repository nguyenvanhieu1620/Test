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
                        {
                            double a, b;
                            do
                            {
                                Console.Write("Nhập giá trị a: ");
                                 a = double.Parse(Console.ReadLine());
                                Console.Write("Nhập giá trị b: ");
                                 b = double.Parse(Console.ReadLine());
                            } while (a > b);
                            
                            
                            double result = RandomRange(a, b);
                            Console.WriteLine($"Giá trị random trong khoảng từ '{a}' đến " + b + ": " + result);
                        }
                        break;
                    case 3:
                        {
                            // Nhập các phần tử của mảng a từ bàn phím
                            Console.Write("Nhập các phần tử của mảng a (cách nhau bởi dấu cách): ");
                            int[] arrayA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Nhập các phần tử của mảng b từ bàn phím
                            Console.Write("Nhập các phần tử của mảng b (cách nhau bởi dấu cách): ");
                            int[] arrayB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Gọi hàm để nối hai mảng và sắp xếp
                            int[] arrayC = MergeSortedArrays(arrayA, arrayB);

                            // In mảng kết quả ra màn hình
                            Console.WriteLine("Mảng sau khi nối và sắp xếp:");
                            Console.WriteLine(string.Join(" ", arrayC));
                        }
                        break;
                    case 4:
                        {
                            // Nhập các phần tử của mảng a từ bàn phím
                            Console.Write("Nhập các phần tử của mảng a (cách nhau bởi dấu cách): ");
                            int[] arrayA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Nhập các phần tử của mảng b từ bàn phím
                            Console.Write("Nhập các phần tử của mảng b (cách nhau bởi dấu cách): ");
                            int[] arrayB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Gọi hàm để nối hai mảng và sắp xếp
                            int[] arrayC = MergeSortedArrays2(arrayA, arrayB);

                            // In mảng kết quả ra màn hình
                            Console.WriteLine("Mảng sau khi nối và sắp xếp:");
                            Console.WriteLine(string.Join(" ", arrayC));
                        }
                    break;
                    case 5:
                        {
                            // Nhập các phần tử của mảng a từ bàn phím
                            Console.Write("Nhập các phần tử của mảng a (cách nhau bởi dấu cách): ");
                            int[] arrayA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Nhập các phần tử của mảng b từ bàn phím
                            Console.Write("Nhập các phần tử của mảng b (cách nhau bởi dấu cách): ");
                            int[] arrayB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Gọi hàm để nối hai mảng và sắp xếp
                            int[] arrayC = MergeSortedArrays3(arrayA, arrayB);

                            // In mảng kết quả ra màn hình
                            Console.WriteLine("Mảng sau khi nối và sắp xếp:");
                            Console.WriteLine(string.Join(" ", arrayC));
                        }
                        break;
                    case 6:
                        {
                            // Nhập các phần tử của mảng a từ bàn phím
                            Console.Write("Nhập các phần tử của mảng a (cách nhau bởi dấu cách): ");
                            int[] arrayA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Nhập các phần tử của mảng b từ bàn phím
                            Console.Write("Nhập các phần tử của mảng b (cách nhau bởi dấu cách): ");
                            int[] arrayB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                            // Gọi hàm để nối hai mảng và sắp xếp
                            int[] arrayC = MergeSortedArrays4(arrayA, arrayB);

                            // In mảng kết quả ra màn hình
                            Console.WriteLine("Mảng sau khi nối và sắp xếp:");
                            Console.WriteLine(string.Join(" ", arrayC));
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
                        {
                            Console.WriteLine("Nhập số tiền: ");
                            long amount = long.Parse(Console.ReadLine());

                            minCoins(amount);
                        }
                        break;
                    case 9:
                        {
                            Console.Write("Nhập chuỗi chính: ");
                            string mainString = Console.ReadLine();

                           
                            Console.Write("Nhập chuỗi con: ");
                            string subString = Console.ReadLine();

                            
                            int count = CountSubstringOccurrences(mainString, subString);

                           
                            Console.WriteLine($"Chuỗi con '{subString}' xuất hiện {count} lần trong chuỗi chính.");
                        }
                
                        break;
                    case 10:
                        {
                            Console.Write("Nhập các phần tử của mảng (cách nhau bởi dấu cách): ");
                            string input = Console.ReadLine();
                            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

                            // Xáo trộn mảng số
                            ShuffleArray(array);

                            // In kết quả ra màn hình
                            Console.WriteLine("Mảng sau khi xáo trộn:");
                            Console.WriteLine(string.Join(" ", array));
                        }
                        break;
                    case 11:
                        {
                            Console.Write("Nhập giá trị của n: ");
                            int n = int.Parse(Console.ReadLine());
                            long result = giaithua(n);
                            long t = 0;
                            while (t == 0)
                            {
                                t = result % 10;
                                result /= 10;
                            }
                            Console.WriteLine($"Chữ số khác 0 cuối cùng của '{n}'! là: " + t);
                        }
                        break;
                    case 12:
                        {
                            Console.Write("Nhập giá trị của n: ");
                            int n = int.Parse(Console.ReadLine());
                            long result = giaithua(n);
                            int dem = 0;
                            while (result > 0)
                            {
                                if(result%10 == 0)
                                {
                                    dem++;
                                }
                                result /= 10;
                            }
                            Console.WriteLine($"Số chữ số 0 xuất hiện trong '{n}'! là: " + dem);
                        }
                        break;

                }
            }
            while (number != 0);
        }
        // Hàm đổi số tờ tiền ít nhất
        static void minCoins(long amount)
        {
            long[] denominations = { 500000, 200000, 100000, 50000, 20000, 10000, 5000, 2000, 1000 };
            long[] count = new long[denominations.Length];

            for(int i = 0; i < denominations.Length; i++)
            {
                if(amount >= denominations[i])
                {
                    count[i] = amount / denominations[i];
                    amount = amount % denominations[i];
                }
            }
            Console.Write("Số tờ tiền đổi ít nhất là: ");
            for(int i =0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{denominations[i]} VND : {count[i]} tờ");
                }
            }
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
        // số lần xuất hiện chuỗi a trong b
        
        static int CountSubstringOccurrences(string mainString, string subString)
        {
            if (string.IsNullOrEmpty(mainString) || string.IsNullOrEmpty(subString))
            {
                return 0;
            }

            int count = 0;
            int startIndex = 0;

            while ((startIndex = mainString.IndexOf(subString, startIndex)) != -1)
            {
                count++;
                startIndex += subString.Length;
            }

            return count;
        }
        // hàm xáo trộn mảng
        static void ShuffleArray(int[] array)
        {
            Random rand = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                // Hoán đổi array[i] và array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        // hàm tính giai thừa n
        static long giaithua(int k)
        {
            if (k < 0)
            {
                throw new ArgumentException("N phải là số nguyên dương.");
            }

            if (k == 0 || k == 1)
            {
                return 1;
            }

            return k * giaithua(k - 1);
        }
        static double Random()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }

        // Hàm randomRange(a, b) trả về giá trị từ a đến b
        static double RandomRange(double a, double b)
        {
            // Sử dụng Random() để lấy giá trị trong khoảng [0, 1]
            double randValue = Random();

            // Chuyển đổi giá trị này vào khoảng [a, b]
            return a + (randValue * (b - a));
        }
        // hàm sắp xếp tăng dần sẵn
        static int[] MergeSortedArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            // Hợp nhất hai mảng
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }

            // Sao chép các phần tử còn lại của mảng a, nếu có
            while (i < a.Length)
            {
                c[k++] = a[i++];
            }

            // Sao chép các phần tử còn lại của mảng b, nếu có
            while (j < b.Length)
            {
                c[k++] = b[j++];
            }

            return c;
        }
        // hàm sắp xếp giảm dần
        static int[] MergeSortedArrays2(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0, j = 0, k = 0;

            // Hợp nhất hai mảng
            while (i < a.Length && j < b.Length)
            {
                if (a[i] >= b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }

            // Sao chép các phần tử còn lại của mảng a, nếu có
            while (i < a.Length)
            {
                c[k++] = a[i++];
            }

            // Sao chép các phần tử còn lại của mảng b, nếu có
            while (j < b.Length)
            {
                c[k++] = b[j++];
            }

            return c;
        }
        //Hàm sắp xếp tăng dần theo giảm dần
        static int[] MergeSortedArrays3(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0, j = 0, k = a.Length + b.Length;

            // Hợp nhất hai mảng
            while (i < a.Length && j < b.Length)
            {
                if (a[i] <= b[j])
                {
                    c[k--] = a[i++];
                }
                else
                {
                    c[k--] = b[j++];
                }
            }

            // Sao chép các phần tử còn lại của mảng a, nếu có
            while (i < a.Length)
            {
                c[k--] = a[i++];
            }

            // Sao chép các phần tử còn lại của mảng b, nếu có
            while (j < b.Length)
            {
                c[k--] = b[j++];
            }

            return c;
        }
        static int[] MergeSortedArrays4(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            int i = 0, j = 0, k = a.Length + b.Length;

            // Hợp nhất hai mảng
            while (i < a.Length && j < b.Length)
            {
                if (a[i] >= b[j])
                {
                    c[k--] = a[i++];
                }
                else
                {
                    c[k--] = b[j++];
                }
            }

            // Sao chép các phần tử còn lại của mảng a, nếu có
            while (i < a.Length)
            {
                c[k--] = a[i++];
            }

            // Sao chép các phần tử còn lại của mảng b, nếu có
            while (j < b.Length)
            {
                c[k--] = b[j++];
            }

            return c;
        }
    }
}
