using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    class Program
    {
        public static List<int> first;
        public static List<int> second;
        static void Main(string[] args)
        {
            first = new List<int>();
            second = new List<int>();
            doSomething();
        }
        public static char getOperator(string input)
        {
            char output = ' ';
            if (input.Contains('+'))
            {
                output = '+';
            }
            else if (input.Contains('-'))
            {
                output = '-';
            }
            else if (input.Contains('*'))
            {
                output = '*';
            }
            else if (input.Contains('/'))
            {
                output = '/';
            }
            else if (input.Contains('$'))
            {
                output = '$';
            }
            return output;
        }
        public static void hexConverter(string input)
        {
            char[] chars = input.ToCharArray();
            List<int> output = new List<int>();
            for (int i =0 ; i < chars.Length; i++)
            {
                if (chars[i] == 'A')
                {
                    output.Add(10);
                }
                else if(chars[i] == 'B')
                {
                    output.Add(11);
                }
                else if (chars[i] == 'C')
                {
                    output.Add(12);
                }
                else if (chars[i] == 'D')
                {
                    output.Add(13);
                }
                else if (chars[i] == 'E')
                {
                    output.Add(14);
                }
                else if (chars[i] == 'F')
                {
                    output.Add(15);
                }
                else
                {
                    output.Add((int)Char.GetNumericValue(chars[i]));
                }
            }
            int index = 0;
            while(output[index] != -1)
            {
                first.Add(output[index]);
                index++;
            }
            for(int i = index+1; i < output.Count; i++)
            {
                second.Add(output[i]);
            }
            first.Reverse();
            second.Reverse();
            //list<int> test1 = first;
            //test1.reverse();
            //list<int> test2 = second;
            //test2.reverse();

            //return output;

        }
        public static string addition()
        {
            string output = "";
            int carry = 0;
            if (first.Count == second.Count)
            {
                for(int i = 0; i < first.Count; i++)
                {
                    int sum = first[i] + second[i] + carry;
                    if (sum > 16)
                    {
                        carry = 1;
                        output += (sum - 16) + " ";
                    }
                    else
                    {
                        carry = 0;
                        output += sum + " ";
                    }
                }
            }
            if(carry == 1)
            {
                output += 1;
            }
            output.Reverse();
            return output;
        }
        public static void doSomething()
        {
            List<String> text = new List<String>();
            text.Add("AAAA+BBBF");
            text.Add("BFD+2DE");
            text.Add("100*AA");
            text.Add("100$5");
            text.Add("100/F");
            text.Add("1000000000000-1");
            text.Add("AAAAABBBBBCCCCCDDDDDEEEEEFFFFF-ABCDEF0123456789ABCDEF");
            text.Add("FACDFDB1/45CDF521");
            hexConverter(text[0]);
            addition();
            //List<int> test = hexConverter(text[0]);
           // Console.WriteLine(test);

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
