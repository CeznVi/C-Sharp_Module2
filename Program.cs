using System;
using System.Collections.Concurrent;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace Module2
{
    internal class Program
    {
        //////Завдання №1
        /////Оголосити одновимірний (5 елементів) масив з назвою
        ////A i двовимірний масив(3 рядки, 4 стовпці) дробових чисел
        ////з назвою B.Заповнити одновимірний масив А числами,
        ////введеними з клавіатури користувачем, а двовимірний
        ////масив В — випадковими числами за допомогою циклів.
        ////Вивести на екран значення масивів: масиву А — в один
        ////рядок, масиву В — у вигляді матриці.
        /////Знайти у даних масивах 
        /////загальний максимальний елемент, 
        /////мінімальний елемент, 
        /////загальну суму усіх елементів, 
        /////загальний добуток усіх елементів, 
        /////суму парних елементів масиву А, 
        /////суму непарних стовпців масиву В.

        //static void Main(string[] args)
        //{

        //    int[] A = new int[5];

        //    Console.WriteLine($"Enter {A.Length} number:");

        //    for (int i = 0; i < A.Length; i++)
        //        A[i] = Int32.Parse(Console.ReadLine());

        //    float[,] B = new float[3, 4];

        //    Random r = new Random();

        //    for(int i = 0; i < B.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < B.GetLength(1); j++)
        //        {
        //            B[i, j] = r.Next(1, 9) / (float)r.Next(2, 3);
        //        }
        //    }

        //    Console.Clear();
        //    Console.WriteLine("Masive A:");
        //    foreach (int i in A)
        //        Console.Write($"{i} \t");
        //    Console.WriteLine();

        //    Console.WriteLine("Masive B:");
        //    for (int i = 0; i < B.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < B.GetLength(1); j++)
        //        {
        //            Console.Write($"{B[i,j]} \t");
        //        }
        //        Console.WriteLine();
        //    }

        //    int dobutokA = 1;
        //    int sumApar = 0;

        //    for(int i = 0; i < A.Length; i++)
        //    {
        //        if(A[i] == 0)
        //            dobutokA = A[i];

        //        dobutokA *= A[i];

        //        if (A[i] % 2 == 0)
        //            sumApar += A[i];
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine($"Max element in massive A {A.Max()}");
        //    Console.WriteLine($"Min element in massive A {A.Min()}");
        //    Console.WriteLine($"Sum all element in massive A {A.Sum()}");
        //    Console.WriteLine($"Dobutok all element in massive A {dobutokA}");
        //    Console.WriteLine($"Summ (element %2 == 0) in massive A {sumApar}");

        //    float max = 0;
        //    float min = 0;
        //    float sum = 0;
        //    float dobutokB = 1;
        //    float sumBpar = 0;
        //    float sumBnopar = 0;

        //    for (int i = 0; i < B.GetLength(0); i++)
        //        for (int j = 0; j < B.GetLength(1); j++)
        //        {
        //            if (i == 0 && j == 0)
        //            {
        //                min = B[i, j];
        //                max = B[i, j];
        //                dobutokB = B[i, j];
        //            }
        //            if(B[i, j] > max)
        //                max = B[i, j];
        //            if(B[i, j] < min)
        //                min = B[i, j];
        //            if(B[i, j] % 2 == 0)
        //                sumBpar += B[i, j];
        //            if (B[i, j] % 2 != 0)
        //                sumBnopar += B[i, j];
        //            sum += B[i, j];
        //            dobutokB *= B[i, j];
        //        }
        //    Console.WriteLine();
        //    Console.WriteLine($"Max element in massive B {max}");
        //    Console.WriteLine($"Min element in massive B {min}");
        //    Console.WriteLine($"Sum all element in massive B {sum}");
        //    Console.WriteLine($"Dobutok all element in massive B {dobutokB}");
        //    Console.WriteLine($"Summ (element %2 == 0) in massive B {sumBpar}");
        //    Console.WriteLine($"Summ (element %2 != 0) in massive B {sumBnopar}");

        //}

        /*кінець завдання 1*/

        //////Завдання №2
        //////Дано двовимірний масив розміром 5×5, заповнений випадковими числами з діапазону від –100 до 100.
        /////Визначити суму елементів масиву, розташованих між мінімальним і максимальним елементами.
        //static void Main(string[] args)
        //{
        //    int[,] a = new int[5, 5];
        //    Random r = new Random();
        //    ////Заповнюємо масив рандомними значеннями у введеному діапазоні
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            a[i, j] = r.Next(-100, 100);
        //        }
        //    }
        //    Console.WriteLine("Masive:");
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            Console.Write($"{a[i, j]} \t");
        //        }
        //        Console.WriteLine();
        //    }
        //    ////Переводимо масив до виду одномірного
        //    int[] temp = new int[a.Length];
        //    temp = a.Cast<int>().ToArray();
        //    int min = 0;
        //    int minInd = 0;
        //    int maxInd = 0;
        //    int max = 0;
        //    int sumelement = 0;
        //    ////У циклі знаходимо максимальне і мінімальне значення, а також їхні індекси
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            min = temp[i];
        //            max = temp[i];
        //        }
        //        if (max < temp[i])
        //        {
        //            max = temp[i];
        //            maxInd = i;
        //        }
        //        else if (min > temp[i])
        //        {
        //            min = temp[i];
        //            minInd = i;
        //        }
        //    }
        //    ////Друкуємо отримону послідовність
        //    if (minInd < maxInd)
        //    {
        //        for (int i = minInd; i <= maxInd; i++)
        //        {
        //            Console.Write($"{temp[i]} ");
        //            sumelement += temp[i];
        //        }
        //        Console.WriteLine();
        //    }
        //    else if (minInd > maxInd)
        //    {
        //        for (int i = minInd; i >= maxInd; i--)
        //        {
        //            Console.Write($"{temp[i]} ");
        //            sumelement += temp[i];
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine($"Minimal value is {min}");
        //    Console.WriteLine($"Maximal value is {max}");
        //    Console.WriteLine($"Summ element in min-max range array is {sumelement}");
        //}
        /*кінець завдання 2*/

        /////Завдання №3
        //////Користувач вводить рядок із клавіатури. Необхідно
        //////зашифрувати цей рядок, використовуючи шифр Цезаря.
        //////Шифр Цезаря — це вид підстановочного шифру, в
        //////якому кожна буква відкритого тексту заміняється на ту,
        //////що віддалена від неї в алфавіті на сталу кількість позицій.
        //////Наприклад, у шифрі зі зсувом правіше на 3, замість A була б
        //////D, замість B-E, і т.д.Детальніше тут: https://uk.wikipedia.
        //////org/wiki/Шифр_Цезаря.
        //////Окрім механізму шифрування, реалізуйте механізм
        //////розшифрування.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please input text");
        //    string text = Console.ReadLine();
        //    Console.WriteLine("Please input key");
        //    int key = Int32.Parse(Console.ReadLine());

        //    ////Шифруємо текст
        //    char[] temp = text.ToCharArray();

        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        if (temp[i] == ' ')
        //            temp[i] = temp[i];
        //        else
        //            temp[i] += (char)key;

        //    }

        //    string protectedText = new string(temp);

        //    ////Дешефруємо текст
        //    temp = protectedText.ToCharArray();

        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        if (temp[i] == ' ')
        //            temp[i] = temp[i];
        //        else
        //            temp[i] -= (char)key;
        //    }
        //    string unprotectedText = new string(temp);

        //    Console.WriteLine();
        //    Console.WriteLine($"Input text:\n{text}");
        //    Console.WriteLine($"Input key:\n{key}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Protected text:\n{protectedText}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Unprotected text:\n{unprotectedText}");

        //}
        /*кінець завдання 3*/


        /////Завдання №4
        /////Створіть додаток, який здійснює операції над матрицями:
        //////■ Множення матриці на число;
        //////■ Додавання матриць;
        //////■ Добуток матриць.


        ////Роздрукувати матрицю функція
        //static void PrintMatrix(int[,] m)
        //{
        //    for (int i = 0; i < m.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < m.GetLength(1); j++)
        //        {
        //            Console.Write($"{m[i, j]} \t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        ////Функція генерації матриці із вказаними границями
        //static int[,] GenerateMatrix(int row, int colum, int max, int min)
        //{
        //    int[,] a = new int[row, colum];
        //    Random r = new Random();
        //    ////Заповнюємо масив рандомними значеннями у введеному діапазоні
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            a[i, j] = r.Next(min, max);
        //        }
        //    }

        //    return a;
        //}

        ////Функція множення матриці на число
        //static void MultMatrixOnNum(int[,] m, int num)
        //{
        //    for (int i = 0; i < m.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < m.GetLength(1); j++)
        //        {
        //            m[i, j] *= num;
        //        }
        //    }
        //}

        ////Функція додавання матриць, повертає матрицю
        //static int[,] AddMatrixOnMatrix(int[,] m, int[,] m2)
        //{
        //    int[,] m3 = new int[m2.GetLength(0), m2.GetLength(1)];

        //    if (m.GetLength(0) != m2.GetLength(0) || m.GetLength(1) != m2.GetLength(1))
        //    {
        //        Console.WriteLine("Неможлива операція, через різний розмір матриць");
        //        return m3;
        //    }

        //    for (int i = 0; i < m.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < m.GetLength(1); j++)
        //        {
        //            m3[i, j] = m[i, j] + m2[i,j];
        //        }
        //    }
        //    return m3;
        //}

        ////Функція множення матриць, повертає матрицю
        //static int[,] MultMatrixOnMatrix(int[,] m, int[,] m2)
        //{
        //    int[,] m3 = new int[m2.GetLength(0), m2.GetLength(1)];

        //    if (m.GetLength(0) != m2.GetLength(0) || m.GetLength(1) != m2.GetLength(1))
        //    {
        //        Console.WriteLine("Неможлива операція, через різний розмір матриць");
        //        return m3;
        //    }

        //    for (int i = 0; i < m.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < m.GetLength(1); j++)
        //        {
        //            m3[i, j] = m[i, j] * m2[i, j];
        //        }
        //    }
        //    return m3;
        //}

        ////мейн функція 
        //static void Main(string[] args)
        //{
        //    //Генеруемо дві матриці
        //    int[,] m1 = GenerateMatrix(3, 3, 10, -10);
        //    int[,] m2 = GenerateMatrix(3, 3, 10, -10);

        //    Console.WriteLine("Матриця 1:");
        //    PrintMatrix(m1);
        //    Console.WriteLine("\nМатриця 2:");
        //    PrintMatrix(m2);

        //    Console.WriteLine("Множення матриць на число. Введiть число");
        //    int num = Int32.Parse(Console.ReadLine());

        //    Console.WriteLine($"Результат множення матрицi 2 на число {num}");
        //    MultMatrixOnNum(m2, num);
        //    PrintMatrix(m2);

        //    Console.WriteLine($"Результат додавання матриць 1 i 2");
        //    int[,] m3 = AddMatrixOnMatrix(m1, m2);
        //    PrintMatrix(m3);

        //    Console.WriteLine($"Результат множення матриць 1 i 3");
        //    int[,] m4 = AddMatrixOnMatrix(m1, m3);
        //    PrintMatrix(m4);
        //}

        /*кінець завдання 4*/


        //////Завдання №5
        //////Користувач з клавіатури вводить до рядка арифме-
        //////тичний вираз.Додаток має підрахувати його результат.
        //////Необхідно дотримуватися лише двох операцій: + і –.
        //////***Додатково добавив * та /

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введіть арифметичний рядок по типу (1+4) або (31-4) (підтримка +-*/)");
        //    string s = Console.ReadLine();


        //    char[] separators = new char[] { '+', '-', '*', '/' };
        //    char[] charsToTrim = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        //    char znak = (s.Trim(charsToTrim)).ToCharArray()[0];
        //    string[] temp = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        //    int a = Int32.Parse(temp[0]);
        //    int b = Int32.Parse(temp[1]);

        //    int result = 0;

        //    switch (znak)
        //    {
        //        case '+':
        //            result = a + b;
        //            break;
        //        case '-':
        //            result = a - b;
        //            break;
        //        case '*':
        //            result = a * b;
        //            break;
        //        case '/':
        //            result = a / b;
        //            break;
        //        default:   break;
        //    }

        //    Console.WriteLine($"Ви ввели наступний вираз {a} {znak} {b} = {result}");
        //}

        /*кінець завдання 5*/

        //////Завдання №6
        //////Користувач з клавіатури вводить певний текст. Додаток
        //////має змінювати регістр першої літери кожного речення на
        //////літеру у верхньому регістрі.
        //////Наприклад, якщо користувач ввів: 
        //////
        //////today is a good day for walking.i will try to walk near the sea.
        //////
        //////Результат роботи додатку: Today is a good day for
        //////walking.I will try to walk near the sea.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введіть речення");
        //    string text = Console.ReadLine();
        //    string result = "";

        //    //ділимо наше речення на суб речення по ознаку "." на кінці речення
        //    string[] temp = text.Split(".", StringSplitOptions.RemoveEmptyEntries);

        //    //убираємо пробіл в початку наших підреченнях
        //    for (int i = 0; i < temp.Length; i++)
        //        temp[i] = temp[i].Trim(' ');

        //    //Робимо в наших реченнях 1 літеру великою
        //    for (int i = 0; i < temp.Length; i++)
        //        temp[i] = temp[i].Substring(0, 1).ToUpper() + temp[i].Substring(1, temp[i].Length - 1);

        //    //Склеюємо під речення у едине реченні з додаванням у їх кінець крапки та пробілу 
        //    for (int i = 0; i < temp.Length; i++)
        //        result += temp[i] + ". ";      

        //    Console.WriteLine($"Модернізований рядок:\n{result}");

        //}

        /*кінець завдання 6*/

        ///////Завдання №7
        ///////Створіть додаток, який перевіряє текст на неприпу-
        ///////стимі слова.Якщо неприпустиме слово знайдено, воно
        ///////має бути замінено набором символів *. За підсумками
        ///////роботи програми, необхідно показати статистику дій.
        ///////
        /*
To be, or not to be, that is the question,
Whether 'tis nobler in the mind to suffer
The slings and arrows of outrageous fortune,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
The heart-ache and the thousand natural shocks
That flesh is heir to, 'tis a consummation
Devoutly to be wish'd. To die, to sleep
        */
        ///////

        static void Main(string[] args)
        {

            Console.WriteLine("Введiть текст");
            string text = "";
            string temp = "";

            while (true)
            {
                temp = Console.ReadLine();

                if (String.IsNullOrEmpty(temp))
                    break;

                text += temp + '\n';
                temp = null;
            }

            Console.WriteLine("Введiть неприпустиме слово");
            string stopWord = Console.ReadLine();
            
            Console.WriteLine("Введiть чим замiняти неприпустиме слово");
            string analog = Console.ReadLine();

            //ділимо наше речення на суб речення по ознаку " " на кінці речення
            char[] separators1 = new char[] { ' ', '.', ',', ':', ';' };
            char[] separators = new char[] { ' ' };
            int countStopWords = 0;


            string[] textm = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < textm.Length; i++)
            {
                if (textm[i].Trim(separators1).ToLower() == stopWord)
                {
                    textm[i] = analog;
                    countStopWords++;
                }
            }

            text = "";

            for (int i = 0; i < textm.Length; i++)
                text += textm[i] + " ";

            Console.WriteLine($"\nМодернiзований рядок:\n{text}");
            Console.WriteLine($"\nCтатистика: {countStopWords} замiни слова {stopWord} на {analog}");
        }

        /*кінець завдання 7*/
    }
}
