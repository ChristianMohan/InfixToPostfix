using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Infix_To_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use whatever you need from below...

            Console.WriteLine("enter an expression:");

            String xp = Console.ReadLine();

            Stack st = new Stack();
            String[] letters = new String[xp.Length];
            for( int i = 0; i < xp.Length; i++)
            {
                letters[i] = xp.Substring(i, 1);
            }

            foreach(String c in letters)
            {
                if(c == )
            }
            foreach(char c in xp)
            {

            }
            /*/
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            /*/
        }
    }
}
