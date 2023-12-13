using System;
using NUnit.Framework;
namespace TiOPO
{
    [TestFixture]
    public class TestingClass
    {
        [Author("Лесовой В.Р.")]
        [Category("Сортировка")]
        [TestCase(new int[5] { 1, 4, 2, 3, 5 }, new int[5] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[5] { -1, 2, -5, -10, 10 }, new int[5] { -10, -5, -1, 2, 10 })]
        [TestCase(new int[5] { 1, 0, 1, 0, 1 }, new int[5] { 0, 0, 1, 1, 1 })]
        public void BubbleSort_Tests(int[] input, int[] result)
        {
            Assert.AreEqual(result, FuncClass.BubbleSort(input));
        }
        [Author("Лесовой В.Р.")]
        [Category("Сортировка")]
        [Test]
        public void BubbleSort_Exception_Tests()
        {
            Assert.Throws<ArrayLength>(() => FuncClass.BubbleSort(new int[0]));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Палиндромность")]
        [TestCase("saippuakivikauppias", true)]
        [TestCase("tenet", true)]
        [TestCase("биба", false)]
        public void PalindromeString_Tests(string word, bool result)
        {
            Assert.AreEqual(FuncClass.PalindromeString(word), result);
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Факториал")]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        [TestCase(12, 479001600)]
        public void Factorial_Tests(int num, int result)
        {
            Assert.AreEqual(FuncClass.Factorial(num), result);
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Факториал")]
        [Test]
        public void Factorial_Exception_Tests()
        {
            Assert.Throws<OutOfRange>(() => FuncClass.Factorial(13));
            Assert.Throws<OutOfRange>(() => FuncClass.Factorial(-1));
            Assert.Throws<OutOfRange>(() => FuncClass.Factorial(56));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Числа Фибоначчи")]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(12, 89)]
        [TestCase(24, 28657)]
        [TestCase(47, 1836311903)]
        public void Fibonacci_Tests(int num, int result)
        {
            Assert.AreEqual(result, FuncClass.Fibonacci(num));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Числа Фибоначчи")]
        [Test]
        public void Fibonacci_Exception_Tests()
        {
            Assert.Throws<OutOfRange>(() => FuncClass.Fibonacci(48));
            Assert.Throws<OutOfRange>(() => FuncClass.Fibonacci(-50));
            Assert.Throws<OutOfRange>(() => FuncClass.Fibonacci(10000));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Степень")]
        [TestCase(5d, 4d, 625d)]
        [TestCase(0.5323d, 0.5323d, 0.71d)]
        [TestCase(2d, 12d, 4096d)]
        [TestCase(0d, 0d, 1d)]
        [TestCase(1.23d, 4.2d, 2.38d)]
        public void Pow_Tests(double num, double steps, double result)
        {
            double res = FuncClass.Pow(num, steps);
            Assert.That(result, Is.EqualTo(res).Within(0.01));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Натуральное число")]
        [TestCase(2, true)]
        [TestCase(991, true)]
        [TestCase(857, true)]
        [TestCase(1783, true)]
        [TestCase(6, false)]
        [TestCase(1485, false)]
        [TestCase(1648, false)]
        public void Prime_Tests(int num, bool result)
        {
            Assert.AreEqual(result, FuncClass.Prime(num));
        }
    }
    public class TaylorTest
    {
        [Author("Лесовой В.Р.")]
        [Category("Синус Тейлор")]
        [TestCase(0.5)]
        [TestCase(-0.5)]
        [TestCase(0)]
        [TestCase(1)]
        public void Taylor_Sin_Tests(double num)
        {
            Assert.AreEqual(Math.Sin(num), Taylor.Sin(num));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Косинус Тейлор")]
        [TestCase(0.5)]
        [TestCase(-0.5)]
        [TestCase(0)]
        [TestCase(1)]
        public void Taylor_Cos_Tests(double num)
        {
            Assert.That(Math.Cos(num), Is.EqualTo(Taylor.Cos(num)).Within(2));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Степень Тейлор")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void Taylor_Pow_Tests(int num)
        {
            Assert.AreEqual(Math.Pow(num, 5), Taylor.Power(num, 5));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Экспонента Тейлор")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void Taylor_Exp_Tests(int num)
        {
            Assert.That(Math.Exp(num), Is.EqualTo(Taylor.Exp(num)).Within(4));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Факториал Тейлор")]
        [TestCase(4)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(10)]
        public void Taylor_Fact_Tests(int num)
        {
            Assert.AreEqual(FuncClass.Factorial(num), Taylor.Factorial(num));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Логарифм Тейлор")]
        [TestCase(0.5f, 0.81093f)]
        [TestCase(1f, 0f)]
        [TestCase(-0.9f, 1.03318f)]
        public void Taylor_Log_Tests(float num, float res)
        {
            Assert.That(res, Is.EqualTo(Taylor.LnPlus(num)).Within(4));
        }
        //
        [Author("Лесовой В.Р.")]
        [Category("Логарифм Тейлор")]
        [TestCase(2d)]
        [TestCase(1d)]
        [TestCase(-1d)]
        public void Taylor_Log_Exception_Tests(double num)
        {
            Assert.Throws<OutOfRange>(delegate { double v = Taylor.LnPlus(Taylor.Power(num, 2) + 1); });
        }
        [Author("Лесовой В.Р.")]
        [Category("Интеграция Тейлор")]
        [TestCase(1d, 7.3890d + -0.9899d)]
        [TestCase(2d, 54.5981d + -0.6536d)]
        public void Taylor_Exp_Plus_Cos_Tests(double num, double res)
        {
            Assert.That(
                res, 
                Is.EqualTo(Taylor.Exp(2 * num) + Taylor.Cos(3 * 1)).Within(4)
                );
        }
        [Author("Лесовой В.Р.")]
        [Category("Интеграция Тейлор")]
        [TestCase(-1d, 0.7080d / (0.1353 + -0.9899d))]
        [TestCase(-2d, 0.8268d / (0.0183d + 0.9601d))]
        public void Taylor_Sin_Square_Divided_By_Exp_Plus_Cos_Tests(double num, double res)
        {
            Assert.That(
                res,
                Is.EqualTo(Taylor.Power(Taylor.Sin(num), 2) / (Taylor.Exp(2 * num) + Taylor.Cos(3 * 1))).Within(4)
                );
        }
        [Author("Лесовой В.Р.")]
        [Category("Интеграция Тейлор")]
        [TestCase(0d, 0 + 1 - 1.7917d)]
        public void Taylor_Sqrt_Minus_Ln_Plus_One_Tests(double num, double res)
        {
            Assert.That(
                res,
                Is.EqualTo(num + 1 - Taylor.LnPlus(Taylor.Power(num, 2) + 1)).Within(4)
                );
        }
        [Author("Лесовой В.Р.")]
        [Category("Интеграция Тейлор")]
        [TestCase(1d)]
        [TestCase(-1d)]
        public void Taylor_Sqrt_Minus_Ln_Plus_One_Ln_Out_Of_Range_Exception_Tests(double num)
        {
            Assert.Throws<OutOfRange>(delegate { double v = num + 1 - Taylor.LnPlus(Taylor.Power(num, 2) + 1); });
        }
        [Author("Лесовой В.Р.")]
        [Category("Интеграция Тейлор")]
        [TestCase(-1d, -0.828457d)]
        [TestCase(-2d, 0.84505d)]
        [TestCase(0d, -0.7917d)]
        public void Taylor_Func_Tests(double num, double res)
        {
            Assert.That(
                res,
                Is.EqualTo(FuncClass.Func(num)).Within(4)
                );
        }
    }
    public class FuncClass
    {
        public static int[] BubbleSort(int[] array)
        {
            if (array.Length < 1) throw new ArrayLength();
            int[] arr = array;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static bool PalindromeString(string str)
        {
            str = str.ToLower();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return str == new string(charArray);
        }
        public static int Factorial(int num)
        {
            if (num <= 0 || num > 12) throw new OutOfRange();
            if (num == 1) return 1;
            return num * Factorial(num - 1);
        }
        public static uint Fibonacci(int pos)
        {
            if (pos < 1 || pos > 47) throw new OutOfRange();
            uint result = 0;
            uint b = 1;
            uint tmp;
            for (int i = 0; i < pos - 1; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }
            return result;
        }
        public static double Pow(double num, double steps) => Math.Pow(num, steps);
        public static bool Prime(int num)
        {
            if(num <= 0) return false;
            if (num == 2 || num == 3) return true;
            if(num%2 == 0 || num%3 == 0) return false;
            for (int i = 5; i <= Math.Sqrt(num); i = i + 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
            return true;
        }
        public static double Func(double x)
        {
            if (x < 0) return Taylor.Power(Taylor.Sin(x), 2) / (Taylor.Exp(2 * x) + Taylor.Cos(3 * x));
            return x - Taylor.LnPlus(Taylor.Power(x, 2));
        }
    }
}