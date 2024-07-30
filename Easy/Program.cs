using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int number;
            do
            {
                Console.WriteLine("1: Viết hàm hoán đổi giá trị của 3 số a, b và c với nhau");
                Console.WriteLine("2: Viết hàm tính a mũ b");
                Console.WriteLine("3: Viết hàm kiểm tra tính đồng nhất chẵn lẻ của 2 số");
                Console.WriteLine("4: Viết hàm đếm số lượng số chẵn trong một mảng");
                Console.WriteLine("5: Viết hàm đếm số lượng số lẻ trong một mảng");
                Console.WriteLine("6: Viết hàm tính tổng số chẵn trong một mảng");
                Console.WriteLine("7: Viết hàm tính tổng số lẻ trong một mảng");
                Console.WriteLine("8: Viết hàm kiểm tra một số có phải là số nguyên tố hay không");
                Console.WriteLine("9: Viết hàm tìm số dư của a chia cho b (không dùng toán tử % hoặc toán tử tương tự)");
                Console.WriteLine("10: Viết hàm tìm giá trị lớn nhất trong 1 mảng các số");
                Console.WriteLine("11: Viết hàm tìm giá trị nhỏ nhất trong 1 mảng các số");
                Console.WriteLine("12: Viết hàm tìm giá trị trung bình của một mảng các số");
                Console.WriteLine("13: Viết hàm đảo ngược thứ tự của một mảng các số");
                Console.WriteLine("14: Viết hàm tìm vị trí của 1 số trong 1 mảng các số");
                Console.WriteLine("15: Viết hàm tính n giai thừa");
                Console.WriteLine("Chọn 0: Kết thúc trương trình");

                do
                {
                    Console.WriteLine("Mời bạn chọn câu hỏi:");
                    string input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out number);
                }
                while (number < 0 || number > 15);
               

                
                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("c = ");
                            int c = Convert.ToInt32(Console.ReadLine());
                            int temp = a;
                            a = b;
                            b = c;
                            c = temp;
                            Console.WriteLine("Ba số a,b,c hoán đổi lần lượt là: " + a + " " + b + " " + c);
                        }
                       
                        break;
                    case 2:
                        {
                            Console.WriteLine("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            double result = Math.Pow(a, b);
                            Console.WriteLine(a + " mũ " + b + " = " + result);
                            break;
                        }
                    case 3:
                        {


                            Console.WriteLine("a = ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("b = ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            if (a % 2 == 0 && b % 2 == 0)
                            {
                                Console.WriteLine("2 Số đồng chẵn");
                            }
                            else if (a % 2 == 1 && b % 2 == 1)
                            {
                                Console.WriteLine("2 số đồng lẻ");
                            }
                            else
                            {
                                Console.WriteLine("1 chẵn 1 lẻ");
                            }
                            break;
                        }
                    case 4:
                        {


                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            int[] array = new int[size];
                            int dem = 0;
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = int.Parse(Console.ReadLine());
                                if (array[i] % 2 == 0)
                                {
                                    dem++;
                                }
                            }
                            Console.WriteLine("Số lượng số chẵn = " + dem);
                            break;
                        }
                    case 5:
                        {


                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            int[] array = new int[size];
                            int dem = 0;
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = int.Parse(Console.ReadLine());
                                if (array[i] % 2 == 1)
                                {
                                    dem++;
                                }
                            }
                            Console.WriteLine("Số lượng số lẻ = " + dem);
                            break;
                        }
                    case 6:
                        {


                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            int[] array = new int[size];
                            int tong = 0;
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = int.Parse(Console.ReadLine());
                                if (array[i] % 2 == 0)
                                {
                                    tong+=array[i];
                                }
                            }
                            Console.WriteLine("tổng các số chẵn trong mảng = " + tong);
                            break;
                        }
                    case 7:
                        { 
                        Console.WriteLine("Kích thước");
                        int size = int.Parse(Console.ReadLine());

                        int[] array = new int[size];
                        int tong = 0;
                        Console.WriteLine("Nhập giá trị mảng");
                        for (int i = 0; i < size; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                            if (array[i] % 2 == 1)
                            {
                                tong += array[i];
                            }
                        }
                        Console.WriteLine("tổng các số lẻ trong mảng = " + tong);
                        break;
                }
                    case 8:
                        {
                            Console.WriteLine("Nhập số: ");
                            long a = long.Parse(Console.ReadLine());
                            int ktra()
                            {
                                if (a == 2) return 1;
                                else if (a <= 1) return 0;
                                else
                                {
                                    for (long i = 2; i <= Math.Sqrt(a); i++)
                                    {
                                        if (a % i == 0)
                                            return 0;
                                    }
                                    return 1;
                                }
                                
                            }
                            if (ktra() == 1) Console.WriteLine("Có");
                            else Console.WriteLine("Không");
                            break;
                        }
                    case 9:
                        {
                           
                                Console.Write("Nhập giá trị của a: ");
                                int a = int.Parse(Console.ReadLine());

                                Console.Write("Nhập giá trị của b: ");
                                int b = int.Parse(Console.ReadLine());

                               
                            
                           
                            
                                if (b == 0)
                                {
                                    throw new DivideByZeroException("Không thể chia cho 0");
                                }
                                int absA = Math.Abs(a);
                                int absB = Math.Abs(b);
                                while (absA >= absB)
                                {
                                    absA -= absB;
                                }

                                // Khôi phục dấu của số dư
                                if (a < 0)
                                {
                                    absA = -absA;
                                }

                           
                            Console.WriteLine("Số dư a chia cho b = " + absA);

                        }
                        break;
                    case 10:
                        {
                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            int[] array = new int[size];
                            int max = 0;
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = int.Parse(Console.ReadLine());
                            }
                            max = array[0];
                            for(int i = 0; i < size; i++)
                            {
                                Console.Write(array[i]+" ");
                                if(max < array[i])
                                {
                                    max = array[i];
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Giá trị lớn nhất của mảng = " + max);
                            break;
                        }
                    case 11:
                        {
                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            int[] array = new int[size];
                            int min = 0;
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = int.Parse(Console.ReadLine());
                            }
                            min = array[0];
                            for (int i = 0; i < size; i++)
                            {
                                Console.Write(array[i] + " ");
                                if (min > array[i])
                                {
                                    min = array[i];
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Giá trị nhỏ nhất của mảng = " + min);
                            break;
                        }
                    case 12:
                        {
                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            double[] array = new double[size];
                            double sum = 0;
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = double.Parse(Console.ReadLine());
                                sum += array[i];
                            }
                            double average = Convert.ToDouble(sum/array.Length);
                            Console.WriteLine("Giá trị trung bình của mảng = " + average);
                        }
                        break;
                    case 13:
                        {

                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            double[] array = new double[size];
                            
                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = double.Parse(Console.ReadLine());
                                
                            }
                            int left = 0;
                            int right = array.Length - 1;
                            while(left < right)
                            {
                                double temp = array[left];
                                array[left] = array[right];
                                array[right] = temp;
                                
                                left++;
                                right--;
                            }
                            Console.WriteLine("Giá trị mảng mới là: ");
                            for (int i = 0; i < size; i++)
                            {
                                Console.Write(array[i] + " ");

                            }
                            Console.WriteLine();
                        }
                        break;
                    case 14:
                        {
                            Console.WriteLine("Kích thước");
                            int size = int.Parse(Console.ReadLine());

                            double[] array = new double[size];

                            Console.WriteLine("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                array[i] = double.Parse(Console.ReadLine());

                            }
                            Console.Write("Nhập só a = ");
                            double a = double.Parse(Console.ReadLine());
                            bool check = true;
                            for(int i = 0; i< array.Length; i++)
                            {
                                if(a == array[i])
                                {
                                    Console.WriteLine("Vị trí đầu tiên của a trong mảng là: " + i);
                                    check = false;
                                }
                               
                            }
                            if (check)
                            {
                                Console.WriteLine("-1");
                            }
                            
                        }
                        break;
                    case 15:
                        {
                            
                            Console.Write("Nhập giá trị của n: ");
                            int n = int.Parse(Console.ReadLine());
                            long result = giaithua(n);
                            Console.WriteLine("Gía trị " + n + "!" + " = " + result);


                        }
                        break;

                }
            }
            while (number != 0);
            
            //Console.ReadKey();
         
        }
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
    }

}
