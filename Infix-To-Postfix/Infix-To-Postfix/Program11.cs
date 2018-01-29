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
            // "A*B–(C+D)+E";
            Console.WriteLine("enter an expression:");
            String post = "";
            String xp = Console.ReadLine().Replace(" ", "");

            String[] letters = new String[xp.Length];
            
            
            for( int i = 0; i < xp.Length; i++)
            {
                letters[i] = xp.Substring(i, 1);
            }
            Stack<char> st = new Stack<char>();
            String ops = "+-*/()";
            foreach(String t in letters)
            {
                
                if(t != "+" && t != "-" && t != "*" && t != "/" && t != "(" && t != ")")
                {
                    post = post + t;
                   
                }

                else if(t == ")")
                {
                    while(true)
                        {
                        if(st.Count > 0)
                        {
                            if (st.Peek() =='(')
                            {

                                st.Pop();
                                break;
                            }
                            else
                            {
                                post = post + st.Peek();
                            }
                        }
                        else
                        {
                            break;
                        }
                        
                       
                    }

                    
                }
                else
                {
                    bool x = false;

                    if (t == "*" || t == "/")
                    {
                        x = true;
                    }
                    while(/*/x is false or t is ( /*/true)
                    {

                        if (st.Count == 0 || st.Peek() == '(') break;


                        if(ops.IndexOf(st.Peek()) < ops.IndexOf(t))
                        {
                            break;
                        }
                        post = post + st.Peek();
                        st.Pop();
                        
                    }
                    char[] myChar = t.ToCharArray();
                    st.Push(myChar[0]);


                }
                

            }
            for(int i = 0; i < st.Count; i++ )
            {
                post = post + st.Peek();

                st.Pop();
            }

            post = post.Replace("(", "");
            post = post.Replace(")", "");

            Console.WriteLine(post);
            

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
