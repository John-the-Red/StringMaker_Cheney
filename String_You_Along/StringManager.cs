using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Cheney
{
    class StringManager
    {
        private string _name;
        public string Reverse(string s)
        {
            _name = s;
            string temp = null;
            Stack<char> stack = new(); 
            for (int i = 0; i < s.Length; i++) 
            {
                stack.Push(s[i]); 
            }
            for (int i = 0; i < s.Length; i++)
            {
                temp += stack.Pop(); 
            } 
            return temp;
        }
        public string Reverse(string s, bool PreserveCaseLocation)
        {
            if(!PreserveCaseLocation)
            {
                return Reverse(s);
            }
            else
            {
                _name = s;
                string temp = null;
                Stack<char> stack = new();
                bool[] isCapital = new bool[s.Length];
                for (int i = 0; i < s.Length; i++)
                {  
                    if(s[i].ToString() == s[i].ToString().ToUpper() && s[i] != ' ')
                    {
                        isCapital[i] = true;
                    }
                    else
                    {
                        isCapital[i] = false;
                    }
                    stack.Push(s[i]); 
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if(isCapital[i])
                    {
                        temp += stack.Pop().ToString().ToUpper();
                    }
                    else
                    {
                        temp += stack.Pop().ToString().ToLower();
                    }
                    
                }
                return temp;
            }
            
        }
        public bool Symmetric(string s)
        {
            _name = s;
            if (s == Reverse(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            Dictionary<int, string> valuePairs = new();
            valuePairs.Add(45,"Negative One");
            valuePairs.Add(48, "Zero");
            valuePairs.Add(49, "One");
            valuePairs.Add(50, "Two");
            valuePairs.Add(51, "Three");
            valuePairs.Add(52, "Four");
            valuePairs.Add(53, "Five");
            valuePairs.Add(54, "Six");
            valuePairs.Add(55, "Seven");
            valuePairs.Add(56, "Eight");
            valuePairs.Add(57, "Nine");


            string temp = null;
            int ASCII = 0;
            foreach (char c in _name)
            {
                ASCII += (int)c;
            }
            if (ASCII == 0)
            {
                return valuePairs[45];
            }
            
            string sASCII = ASCII.ToString();
            for(int i = 0; i < sASCII.Length; i++)
            {
                if(i == 0)
                {
                    temp = valuePairs[sASCII[i]];
                }
                else
                {
                    temp += " " + valuePairs[sASCII[i]];
                }
            }

            return temp;
        }
        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                return _name == obj.ToString();
            }
            else
            {
                return false;
            }
        }
        
    }
   
}
