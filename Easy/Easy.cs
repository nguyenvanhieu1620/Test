using System;

namespace com.yotech.exercises
{
    class Easy
    {
        public static void Run()
        {
            new EasyEx01TestRunner("Easy - Ex01").Run();
            new EasyEX02TestRunner("Easy - Ex02").Run();
            new EasyEX03TestRunner("Easy - Ex03").Run();
            new EasyEx04TestRunner("Easy - Ex04").Run();
            new EasyEX05TestRunner("Easy - Ex05").Run();
            new EasyEx06TestRunner("Easy - Ex06").Run();
            new EasyEx07TestRunner("Easy - Ex07").Run();
            new EasyEx08TestRunner("Easy - EX08").Run();
            new EasyEx09TestRunner("Easy - Ex09").Run();
            new EasyEx10TestRunner("Easy - Ex10").Run();
            new EasyEx11TestRunner("Easy - Ex11").Run();
            new EasyEx12TestRunner("Easy - Ex12").Run();
            new EasyEx13TestRunner("Easy - Ex13").Run();
            new EasyEx14TestRunner("Easy - Ex14").Run();
            new EasyEx15TestRunner("Easy - Ex15").Run();









            //EasyEX02Test.Run();
            //EasyEX03Test.Run();
            //EasyEx04Test.Run();
            //EasyEX05Test.Run();
            //EasyEx06Test.Run();
            //EasyEx07Test.Run();
            //EasyEx08Test.Run();
            //EasyEx09Test.Run();
            //EasyEx10Test.Run();
            //EasyEx11Test.Run();
            //EasyEx12Test.Run();
            //EasyEx13Test.Run();
            //EasyEx14Test.Run();
            //EasyEx15Test.Run();


            //return;
            //// Test exercises 02
            //Log("==== START - Test Ex02 ===");
            //int powerValue = new EasyEx02().Run(2, 5);
            //int expectedValue = 32;

            //if(powerValue == expectedValue)
            //{
            //    Log("Test Ex02 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex02 - Testcase 01 - Incorrect");
            //}
            //Log("====END - Test EX02 ===");

            //// Test exercises 03
            //Log("==== START - Test Ex03 ===");
            //int compareValue = new EasyEx03().Run(1, 2);
            //if (compareValue == 2) Log("Test Ex03 - TestCase 01 - Even coin");
            //else if (compareValue == 1) Log("Test Ex03 - TestCase 01 - Odd coin");
            //else Log("Test Ex03- TestCase01 - One Odd One Even");
            ////Test exercises 04
            //Log("==== START - Test Ex04 ===");
            //int[] inputCheckEvenNumbers = { 1, 2, 3, 4 }; 
            //int countEvenNumbers = new EasyEx04().Run(inputCheckEvenNumbers);
            //int expectedEvenNumbers = 2;
            //if(countEvenNumbers == expectedEvenNumbers)
            //{
            //    Log("Test Ex04 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex04 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 05
            // Log("==== START - Test Ex05 ===");
            //int[] inputCheckOddNumbers = { 1, 2, 3, 4 }; 
            //int countOddNumbers = new EasyEx05().Run(inputCheckOddNumbers);
            //int expectedOddNumbers = 2;
            //if(countOddNumbers == expectedOddNumbers)
            //{
            //    Log("Test Ex05 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex05 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 06
            //Log("==== START - Test Ex06 ===");
            //int[] inputTotalEvenNumber = { 1, 2, 3, 4 };
            //int totalEvenNumbers = new EasyEx06().Run(inputTotalEvenNumber);
            //int expectedTotalEvenNumbers = 6;
            //if(totalEvenNumbers == expectedTotalEvenNumbers)

            //{
            //    Log("Test Ex06 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex06 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 07
            //Log("==== START - Test Ex07 ===");
            //int[] inputTotalOddNumber = { 1, 2, 3, 4 };
            //int totalOddNumbers = new EasyEx07().Run(inputTotalEvenNumber);
            //int expectedTotalOddNumbers = 4;
            //if (totalOddNumbers == expectedTotalOddNumbers)

            //{
            //    Log("Test Ex06 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex06 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 08
            //Log("==== START - Test Ex08 ===");
            //bool checkPrimeValue = new EasyEx08().Run(7);
            //if (checkPrimeValue)
            //{
            //    Log("Test Ex08 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex08 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 09
            //Log("==== START - Test Ex09 ===");
            //int surplus = new EasyEx09().Run(10, 4);
            //int expectedSurplus = 2;
            //if(surplus == expectedSurplus)
            //{
            //    Log("Test Ex09 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex09 - Testcase 01 - Incorrect");
            //}

            ////Test exercise 10
            //Log("==== START - Test Ex10 ===");
            //int[] inputMaxArray = { 5, 8, 35, 78, 76 }; 
            //int maxValue = new EasyEx10().Run(inputMaxArray);
            //int expectedMaxValue = 78;
            //if(maxValue == expectedMaxValue)
            //{
            //    Log("Test Ex10 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex10 - Testcase 01 - Incorrect");

            //}
            ////Test exercise 11
            //Log("==== START - Test Ex11 ===");
            //int[] inputMinArray = { 5, 8, 35, 78, 76 };
            //int minValue = new EasyEx11().Run(inputMinArray);
            //int expextedMinValue = 5;
            //if(minValue == expextedMinValue)
            //{
            //    Log("Test Ex11 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex11 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 12 
            //Log("==== START - Test Ex12 ===");
            //double[] inputAverageArray = { 1, 5, 8, 9, 12 };
            //double averageValue = new EasyEx12().Run(inputAverageArray);
            //double expectedAverageValue = 7;
            //if(averageValue == expectedAverageValue)
            //{
            //    Log("Test Ex12 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex12 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 13
            //Log("==== START - Test Ex13 ===");
            //int[] inputReverseArray = { 2, 4, 56, 8, 9 };
            //int[] reverseArray = new EasyEx13().Run(inputReverseArray);
            //int[] expectedReverseArray = { 9, 8, 56, 4, 2 };
            //bool checkReverse = IsTwoArrayEqual(reverseArray, expectedReverseArray);
            //if (expectedCheck)
            //{
            //    Log("Test Ex13 - Testcase 01 - Correct");

            //}
            //else
            //{
            //    Log("Test Ex13 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 14
            //Log("==== START - Test Ex14 ===");
            //int[] inputFirstIndexArray = { 1, 5, 9, 35, 90 };
            //int Number = 35;
            //int firstIndexNumber = new EasyEx14().Run(inputFirstIndexArray, Number);
            //int expectedIndexNumber = 3;
            //if(firstIndexNumber == expectedIndexNumber)
            //{
            //    Log("Test Ex14 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex14 - Testcase 01 - Incorrect");
            //}
            ////Test exercise 15
            //Log("==== START - Test Ex15 ===");
            //int factorial = new EasyEx15().Run(10);
            //int expectedFactorial = 3628800;
            //if(factorial == expectedFactorial)
            //{
            //    Log("Test Ex15 - Testcase 01 - Correct");
            //}
            //else
            //{
            //    Log("Test Ex15 - Testcase 01 - Incorrect");
            //}


            Console.ReadKey();
        }
    }

}
