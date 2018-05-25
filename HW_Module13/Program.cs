using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Module13_Stack
{
    class Program
    {

        #region Stack

        //public static string pathRe = "input.txt";
        //public static string pathWr = "out.txt";
        //public static string path = "test.txt";


        //// 1.	Дан файл, в котором записан набор чисел.Переписать в другой файл все числа в обратном порядке. 

        //static void Revers()
        //{

        //    Stack stack = new Stack();

        //    StreamReader read = new StreamReader(pathRe, Encoding.Default);   //open file for reading
        //    foreach (string s in read.ReadToEnd().Split(' '))
        //    {
        //        stack.Push(s);                                                //push on the stack
        //    }
        //    read.Close();

        //    StreamWriter write = new StreamWriter(pathWr);                     //writing on file
        //    foreach (var v in stack)
        //    {
        //        write.WriteLine(v);
        //    }
        //    write.Close();
        //}


        //// 2.	Создать текстовый файл. Распечатать гласные буквы этого файла в обратном порядке.
        //static void Letter()
        //{
        //    Console.WriteLine("Введите текст:");
        //    string text = Console.ReadLine();
        //    using (StreamWriter writer = new StreamWriter(path, false, Encoding.Default))
        //    {
        //        writer.Write(text);
        //    }
        //    char ch;
        //    string vowels = "уеыаоэяию";
        //    Stack<char> vowelStack = new Stack<char>();
        //    using (StreamReader reader = new StreamReader(path, Encoding.Default))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            ch = (char)reader.Read();
        //            if (vowels.Contains(ch))
        //            {
        //                vowelStack.Push(ch);
        //            }
        //        }
        //        Console.WriteLine(string.Join(string.Empty, vowelStack));
        //    }
        //}

        ////3.	Напечатать содержимое текстового файла t, выписывая литеры каждой его строки в обратном порядке. 
        //static void ReversLine()
        //{

        //    var read = File.ReadAllLines(pathRe, Encoding.Default);

        //    foreach (var s in read)
        //    {

        //        Stack stack = new Stack();

        //        foreach (var c in s)
        //        {
        //            stack.Push(c);
        //        }

        //        var count = stack.Count;

        //        for (var i = 0; i < count; i++)
        //        {
        //            Console.Write(stack.Pop());
        //        }
        //        Console.WriteLine();
        //    }

        //}

        //// 4.	Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1. 

        //static void Comparision()
        //{
        //    Console.Write(" S1: ");
        //    string s1 = Console.ReadLine();
        //    Console.Write(" S2: ");
        //    string s2 = Console.ReadLine();

        //    if (s1.Length != s2.Length)
        //    {
        //        Console.WriteLine(" Strings not equal!");
        //    }
        //    else
        //    {
        //        Console.Write(s1 == new string(s2.Reverse().ToArray()) ? " + Strings equal!" : " - Strings not equal!");
        //    }
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Stack
            //Revers();
            //Letter();
            //ReversLine();
            //Comparision();
            #endregion

            Console.ReadKey();
        }
    }
}
