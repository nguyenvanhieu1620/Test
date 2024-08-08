using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static com.yotech.exercises.Lib;

namespace com.yotech.exercises
{
    class MediumOld
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int number;
            do
            {
                Log("1: Viết hàm sắp xếp 1 mảng các số theo thứ tự tăng hoặc giảm dần");
                Log("2: Viết hàm nối 2 mảng số với nhau");
                Log("3: Viết hàm cộng giá trị của 2 mảng số");
                Log("4: Viết hàm trừ giá trị của 2 mảng số");
                Log("5: Viết hàm nhân giá trị của 2 mảng số");
                Log("6: Viết hàm chia giá trị của 2 mảng số");
                Log("7: Viết hàm lấy 1 số phần từ của mảng số dựa vào vị trí đầu và cuối");
                Log("8: Viết hàm tìm vị trí một chuỗi trong một chuỗi khác");
                Log("9: Viết hàm tìm tổng số các phần tử của chuỗi a trong chuỗi b");
                Log("10: Viết hàm tìm tổng số các phần tử của chuỗi a không có trong chuỗi b");
                Log("11: Cho hàm random() trả về giá trị từ 0 đến 1(có lấy 0 và 1).Viết hàm random(a) trong đó dùng hàm random() để trả về một giá trị random trong khoảng từ 0 đến a");
                Log("12: Cho hàm random() trả về giá trị từ 0 đến 1(có lấy 0 và 1).Viết hàm random(a) trong đó dùng hàm random() để trả về một giá trị random trong khoảng từ - a đến a");
                Log("13: Tính tiền trả nhà");
                Log("14: Thuế thu nhập cá nhân");
                Log("15: Viết hàm tình tổng số các chữ số của 1 số nguyên");
                Log("16: Viết hàm in ra n số đầu tiên trong chuỗi fibonaci");
                Log("17: Viết hàm cắt string theo vị trí bắt đầu và vị trí kết thúc");
                Log("18: Viết hàm cắt string theo vị trí bắt đầu và số ký tự cần cắt");
                Log("Chọn 0: Kết thúc trương trình");

                do
                {
                    Log("Mời bạn chọn câu hỏi:");
                    string input = Console.ReadLine();
                    bool isNumber = int.TryParse(input, out number);
                }
                while (number < 0 || number > 18);
                switch (number)
                {
                    case 1:
                        {
                            Console.Write("Nhập kích thước của mảng: ");
                            int size = int.Parse(Console.ReadLine());

                            
                            int[] array = new int[size];

                            Log("Nhập giá trị mảng");
                            for (int i = 0; i < size; i++)
                            {
                                
                                array[i] = int.Parse(Console.ReadLine());
                            }
                            Console.Write("Nhập cách sắp xếp (tăng/giảm): ");
                            string sortOrder = Console.ReadLine().ToLower();
                            if (sortOrder == "tang")
                            {
                                TangDan(array);
                                Log("Mảng sau khi sắp xếp theo thứ tự tăng dần:");
                            }
                            else if (sortOrder == "giam")
                            {
                                GiamDan(array);
                                Log("Mảng sau khi sắp xếp theo thứ tự giảm dần:");
                            }
                            else
                            {
                                Log("Lựa chọn sắp xếp không hợp lệ. Vui lòng nhập 'tăng' hoặc 'giảm'.");
                                return;
                            }
                            foreach(int i in array)
                            {
                                Console.Write(i + " ");
                            }
                            Log();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Nhập kích thước của 2 mảng: ");
                            int size = int.Parse(Console.ReadLine());


                            double[] array1 = new double[size];
                            double[] array2 = new double[size];
                            double[] array3 = new double[size * 2];
                            Log("Nhập giá trị mảng a: ");
                            for (int i = 0; i < size; i++)
                            {

                                array1[i] = double.Parse(Console.ReadLine());
                            }
                            Log("Nhập giá trị mảng b: ");
                            for (int i = 0; i < size; i++)
                            {

                                array2[i] = double.Parse(Console.ReadLine());
                            }
                            array3 = array1.Concat(array2).ToArray();
                            Log("2 mảng sau khi nối với nhau là: ");
                            foreach(double i in array3)
                            {
                                Console.Write(i + " ");
                            }
                            Log();
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Nhập kích thước của 2 mảng: ");
                            int size = int.Parse(Console.ReadLine());


                            double[] array1 = new double[size];
                            double[] array2 = new double[size];
                            double[] array3 = new double[size * 2];
                            Log("Nhập giá trị mảng a: ");
                            for (int i = 0; i < size; i++)
                            {

                                array1[i] = double.Parse(Console.ReadLine());
                            }
                            Log("Nhập giá trị mảng b: ");
                            for (int i = 0; i < size; i++)
                            {

                                array2[i] = double.Parse(Console.ReadLine());
                            }
                            array3 = trumang(array1, array2);
                            Log("2 mảng sau khi cộng với nhau là: ");
                            foreach (double i in array3)
                            {
                                Console.Write(i + " ");
                            }
                            Log();
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Nhập kích thước của 2 mảng: ");
                            int size = int.Parse(Console.ReadLine());


                            double[] array1 = new double[size];
                            double[] array2 = new double[size];
                            double[] array3 = new double[size * 2];
                            Log("Nhập giá trị mảng a: ");
                            for (int i = 0; i < size; i++)
                            {

                                array1[i] = double.Parse(Console.ReadLine());
                            }
                            Log("Nhập giá trị mảng b: ");
                            for (int i = 0; i < size; i++)
                            {

                                array2[i] = double.Parse(Console.ReadLine());
                            }
                            array3 = trumang(array1, array2);
                            Log("2 mảng sau khi trừ với nhau là: ");
                            foreach (double i in array3)
                            {
                                Console.Write(i + " ");
                            }
                            Log();
                        }
                        break;
                    case 5:
                        {
                            {
                                Console.Write("Nhập kích thước của 2 mảng: ");
                                int size = int.Parse(Console.ReadLine());


                                double[] array1 = new double[size];
                                double[] array2 = new double[size];
                                double[] array3 = new double[size * 2];
                                Log("Nhập giá trị mảng a: ");
                                for (int i = 0; i < size; i++)
                                {

                                    array1[i] = double.Parse(Console.ReadLine());
                                }
                                Log("Nhập giá trị mảng b: ");
                                for (int i = 0; i < size; i++)
                                {

                                    array2[i] = double.Parse(Console.ReadLine());
                                }
                                array3 = nhanmang(array1, array2);
                                Log("2 mảng sau khi nhân với nhau là: ");
                                foreach (double i in array3)
                                {
                                    Console.Write(i + " ");
                                }
                                Log();
                            }
                        }
                        break;
                    case 6:
                        {
                            {
                                Console.Write("Nhập kích thước của 2 mảng: ");
                                int size = int.Parse(Console.ReadLine());


                                double[] array1 = new double[size];
                                double[] array2 = new double[size];
                                double[] array3 = new double[size * 2];
                                Log("Nhập giá trị mảng a: ");
                                for (int i = 0; i < size; i++)
                                {

                                    array1[i] = double.Parse(Console.ReadLine());
                                }
                                Log("Nhập giá trị mảng b: ");
                                for (int i = 0; i < size; i++)
                                {

                                    array2[i] = double.Parse(Console.ReadLine());
                                }
                                array3 = chiamang(array1, array2);
                                Log("2 mảng sau khi chia với nhau là: ");
                                foreach (double i in array3)
                                {
                                    Console.Write(i + " ");
                                }
                                Log();
                            }
                        }
                        break;
                    case 7:
                        {

                            Console.Write("Nhập kích thước của mảng: ");
                            int size = int.Parse(Console.ReadLine());


                            double[] array1 = new double[size];
                           
                            Log("Nhập giá trị mảng a: ");
                            for (int i = 0; i < size; i++)
                            {

                                array1[i] = double.Parse(Console.ReadLine());
                            }
                            Console.Write("Nhập vị trí đầu: ");
                            int start = int.Parse(Console.ReadLine());

                            Console.Write("Nhập vị trí cuối: ");
                            int end = int.Parse(Console.ReadLine());
                            double[] array2 = laymang(array1, start, end); 
                            Log("2 mảng sau khi chia với nhau là: ");
                            foreach (double i in array2)
                            {
                                Console.Write(i + " ");
                            }
                            Log();
                        }
                        break;
                    case 8:
                        {
                            Console.Write("Nhập chuỗi chính: ");
                            string mainString = Console.ReadLine();

                           
                            Console.Write("Nhập chuỗi con: ");
                            string subString = Console.ReadLine();

                           
                            int position = timvitrichuoi(mainString, subString);

                           
                            if (position != -1)
                            {
                                Log($"Chuỗi con '{subString}' được tìm thấy tại vị trí: {position}");
                            }
                            else
                            {
                                Log($"Chuỗi con '{subString}' không được tìm thấy trong chuỗi chính.");
                            }
                        }
                        break;
                    case 9:
                        {
                            Console.Write("Nhập kích thước của mảng a: ");
                            int sizeA = int.Parse(Console.ReadLine());

                            
                            int[] arrayA = new int[sizeA];

                            Log("Nhập mảng a: ");
                            for (int i = 0; i < sizeA; i++)
                            {
                                
                                arrayA[i] = int.Parse(Console.ReadLine());
                            }

                            
                            Console.Write("Nhập kích thước của mảng b: ");
                            int sizeB = int.Parse(Console.ReadLine());

                            
                            int[] arrayB = new int[sizeB];

                            Log("Nhập mảng b: ");
                            for (int i = 0; i < sizeB; i++)
                            {
                                
                                arrayB[i] = int.Parse(Console.ReadLine());
                            }


                            int count = tongphantunamtrong(arrayA, arrayB);


                            Log($"Tổng số các phần tử trong mảng a tồn tại trong mảng b là: {count}");
                        }
                        break;
                    case 10:
                        {
                            Console.Write("Nhập kích thước của mảng a: ");
                            int sizeA = int.Parse(Console.ReadLine());


                            int[] arrayA = new int[sizeA];

                            Log("Nhập mảng a: ");
                            for (int i = 0; i < sizeA; i++)
                            {

                                arrayA[i] = int.Parse(Console.ReadLine());
                            }


                            Console.Write("Nhập kích thước của mảng b: ");
                            int sizeB = int.Parse(Console.ReadLine());


                            int[] arrayB = new int[sizeB];

                            Log("Nhập mảng b: ");
                            for (int i = 0; i < sizeB; i++)
                            {

                                arrayB[i] = int.Parse(Console.ReadLine());
                            }
                            int count = tongphantukhongnamtrong(arrayA, arrayB);


                            Log($"Tổng số các phần tử trong mảng a tồn tại trong mảng b là: {count}");
                        }
                        break;
                    case 11:
                        {
                            Console.Write("Nhập giá trị a: ");
                            double a = double.Parse(Console.ReadLine());

                            // Lấy giá trị random trong khoảng từ 0 đến a
                            double result = RandomA(a);

                            // In kết quả ra màn hình
                            Log("Giá trị random trong khoảng từ 0 đến " + a + ": " + result);
                        }
                        break;
                    case 12:
                        {
                            Console.Write("Nhập giá trị a: ");
                            double a = double.Parse(Console.ReadLine());

                            // Lấy giá trị random trong khoảng từ 0 đến a
                            double result = RandomB(a);

                            // In kết quả ra màn hình
                            Log($"Giá trị random trong khoảng từ -'{a}' đến " + a + ": " + result);
                        }
                        break;
                    case 13:
                        {
                            //// Nhập thời gian checkin
                            //Console.Write("Nhập thời gian checkin (dạng dd/MM/yyyy HH:mm): ");
                            //DateTime checkInDateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

                            //// Nhập thời gian checkout
                            //Console.Write("Nhập thời gian checkout (dạng dd/MM/yyyy HH:mm): ");
                            //DateTime checkOutDateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

                            //// Tính số tiền phải trả
                            //double totalAmount = CalculateTotalAmount(checkInDateTime, checkOutDateTime);

                            //// Hiển thị kết quả
                            //Log($"Số tiền khách phải trả: {totalAmount}k");
                        }
                        break;
                    case 14:
                        {
                            Log("Nhập số tháng: ");
                            int n = int.Parse(Console.ReadLine());
                            double[] luong = new double[n];
                            Log("Nhập bảng lương các tháng: ");
                            for(int i = 0; i < n; i++)
                            {
                                luong[i] = double.Parse(Console.ReadLine());
                            }
                            double thue = Thuethunhapcanhan(luong);
                            Log($"Thuế thu nhập cá nhân '{n}' tháng = " + thue);
                        }
                        break;
                    case 15:
                        {
                            Console.Write("Nhập một số nguyên: ");
                            int a = int.Parse(Console.ReadLine());
                            int tong = tongchuso(a);

                            
                            Log($"Tổng các chữ số của số {a} là: {tong}");
                        }
                        break;
                    case 16:
                        {
                            Console.Write("Nhập số lượng số Fibonacci cần in: ");
                            int n = int.Parse(Console.ReadLine());
                            PrintFibonacci(n);
                        }
                        break;
                    case 17:
                        {
                            Console.Write("Nhập chuỗi gốc: ");
                            string originalString = Console.ReadLine();

                           
                            Console.Write("Nhập vị trí bắt đầu: ");
                            int startIndex = int.Parse(Console.ReadLine());

                            
                            Console.Write("Nhập vị trí kết thúc: ");
                            int endIndex = int.Parse(Console.ReadLine());

                            if (startIndex < 0 || endIndex >= originalString.Length || startIndex > endIndex)
                            {
                                Log("Vị trí bắt đầu và vị trí kết thúc không hợp lệ.");
                            }
                            else
                            {
                                
                                string result = catchuoi(originalString, startIndex, endIndex);

                                
                                Log($"Chuỗi sau khi cắt: {result}");
                            }
                        }
                        break;
                    case 18:
                        {
                            Console.Write("Nhập chuỗi gốc: ");
                            string originalString = Console.ReadLine();


                            Console.Write("Nhập vị trí bắt đầu: ");
                            int startIndex = int.Parse(Console.ReadLine());
                            Console.Write("Nhập số kĩ tự cắt: ");
                            int length = int.Parse(Console.ReadLine());

                            if (startIndex < 0 || length >= originalString.Length || startIndex > originalString.Length)
                            {
                                Log("Vị trí bắt đầu và vị trí kết thúc không hợp lệ.");
                            }
                            else
                            {

                                string result = catchuoisokitu(originalString, startIndex, length);


                                Log($"Chuỗi sau khi cắt: {result}");
                            }
                        }
                        break;

                }
            }
            while (number != 0);
            Console.ReadKey();
        }
        //Hàm tính tiền thuế thu nhập
        static double Thuethunhapcanhan(double[] luong)
        {
            double thue = 0;
            foreach(double i in luong)
            {
                if (i > 50000000) thue += i * 0.2;
                else if (i >= 20000000 && i <= 50000000) thue += i * 0.1;
                else if (i < 20000000) thue += i * 0.05;
            }
            return thue;
        }

        //Hàm tính tiens nhà nghỉ
        //static double CalculateTotalAmount(DateTime checkIn, DateTime checkOut)
        //{
        //    const double firstTwoHoursRate = 70;
        //    const double subsequentHoursRate = 50;
        //    const double overnightRate = 160;
        //    const double extraHourRate = 40;

        //    double totalAmount = 0;

        //    // Tính tổng số giờ sử dụng
        //    double totalHours = (checkOut - checkIn).TotalHours;

        //    // Kiểm tra nếu qua đêm (checkIn trước 24h và checkOut sau 8h sáng hôm sau)
        //    if (checkIn.Date < checkOut.Date && (checkIn.Date == checkOut.Date && checkOut.TimeOfDay > TimeSpan.FromHours(8)))
        //    {
        //        // Số giờ vượt quá 8h sáng hôm sau
        //        DateTime nextDay8AM = checkIn.Date.AddDays(1).AddHours(8);
        //        double extraHours = (checkOut - nextDay8AM).TotalHours;

        //        if (extraHours < 0)
        //        {
        //            extraHours = 0;
        //        }
               
        //        // Tổng số tiền phải trả
        //        totalAmount = +overnightRate + extraHours * extraHourRate;
        //    }
        //    else
        //    {
        //        // Tính tiền theo giờ thông thường
        //        if (totalHours <= 2)
        //        {
        //            totalAmount = totalHours * firstTwoHoursRate;
        //        }
        //        else
        //        {
        //            totalAmount = 2 * firstTwoHoursRate + (totalHours - 2) * subsequentHoursRate;
        //        }
        //    }

        //    return totalAmount;
        //}
        // hàm cắt chuỗi từ vị trí bắt đầu và số kí tự cắt
        static string catchuoisokitu(string str,int start ,int length)
        {

           


            return str.Substring(start, length);
        }
        // cắt chuỗi từ vị trí ban đầu đến vị trí kết thúc
        static string catchuoi(string str, int start, int end)
        {
            
            int length = end - start + 1;

            
            return str.Substring(start, length);
        }
        //Ham in n so fibonaci dau tien
        static void PrintFibonacci(int n)
        {
            if (n <= 0)
            {
                Log("Số lượng phải lớn hơn 0");
                return;
            }

            long first = 0;
            long second = 1;

            
            Console.Write("Chuỗi Fibonacci: ");
            Console.Write(first);

            for (int i = 1; i < n; i++)
            {
                Console.Write(", " + second);
                long next = first + second;
                first = second;
                second = next;
            }

            Log();
        }
        //Hàm tính tổng chữ số
        static int tongchuso(int a)
        {
            int sum = 0;
            a = Math.Abs(a);
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
        //hàm tính tổng số phần từ mảng a không nằm trong b
        static int tongphantukhongnamtrong(int[] arrayA, int[] arrayB)
        {
            
            HashSet<int> setB = new HashSet<int>(arrayB);

            int count = 0;

           
            foreach (int element in arrayA)
            {
                if (!setB.Contains(element))
                {
                    count++;
                }
            }

            return count;
        }
        //hàm tính tổng số phần tử mảng a nằm trong mảng b
        static int tongphantunamtrong(int[] arrayA, int[] arrayB)
        {
            
            HashSet<int> setB = new HashSet<int>(arrayB);

            int count = 0;

            
            foreach (int element in arrayA)
            {
                if (setB.Contains(element))
                {
                    count++;
                }
            }

            return count;
        }
        //Tìm vị trí chuỗi
        static int timvitrichuoi(string mainString, string subString)
        {
            return mainString.IndexOf(subString);
        }
        //Hàm lấy mảng vị trí đầu và vị trí cuối
        static double[] laymang(double[] array, int start, int end)
        {
            if (start < 0 || end >= array.Length || start > end)
            {
                throw new ArgumentException("Vị trí đầu và cuối không hợp lệ.");
            }

            int length = end - start + 1;
            double[] result = new double[length];

            Array.Copy(array, start, result, 0, length);

            return result;
        }
        //Hàm cộng giá trị 2 mảng
        static double[] congmang(double[] array1, double[] array2)
        {
           

            double[] result = new double[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }
        //Hàm trừ giá trị 2 mảng
        static double[] trumang(double[] array1, double[] array2)
        {


            double[] result = new double[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] - array2[i];
            }

            return result;
        }
        //Hàm nhân giá trị 2 mảng
        static double[] nhanmang(double[] array1, double[] array2)
        {


            double[] result = new double[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] * array2[i];
            }

            return result;
        }
        // Hàm chia giá trị 2 mảng
        static double[] chiamang(double[] array1, double[] array2)
        {


            double[] result = new double[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i] / array2[i];
            }

            return result;
        }
        // Hàm sắp xếp mảng theo thứ tự tăng dần
        static void TangDan(int[] array)
        {
            Array.Sort(array);
        }

        // Hàm sắp xếp mảng theo thứ tự giảm dần
        static void GiamDan(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
        }
        //Hàm random(0,1)
        static double Random()
        {
            Random rand = new Random();
            return rand.NextDouble();
        }

        // Hàm random(a) trả về giá trị từ 0 đến a
        static double RandomA(double a)
        {
            return Random() * a;
        }
        // Hàm random từ -a đến a
        static double RandomB(double a)
        {
            // Sử dụng Random() để lấy giá trị trong khoảng [0, 1]
            double randValue = Random();

            // Chuyển đổi giá trị này vào khoảng [-a, a]
            return (randValue * 2 * a) - a;
        }
    }
}
