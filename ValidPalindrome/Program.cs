namespace ValidPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "abba";
            bool v = two_pointers_outside(input);
            Console.WriteLine(v);

            bool x = two_pointers_middle(input);
            Console.WriteLine(x);

            bool y = reverse_approach(input);
            Console.WriteLine(y);

        }
        /// <summary>
        /// This function will user two pointers on opposite ends of the string and work its way towards the middle
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Returns true if values match on opposite ends. </returns>
        static bool two_pointers_outside(string input)
        {
            bool equal = false;
            int length = input.Length;
            int a = 0;
            int b = length - 1;
            
            if(length >2)
            {
                if(length % 2 == 0)
                {
                    while(a < b)
                    {
                        if(input[a] == input[b])
                        {
                            a += 1;
                            b -= 1;
                            equal = true;
                        }

                        else
                        {
                            equal = false;
                            break;
                        }
                    }
                }
                else
                {
                    while (a <= b)
                    {
                        if (input[a] == input[b])
                        {
                            a += 1;
                            b -= 1;
                            equal = true;
                        }

                        else
                        {
                            equal = false;
                            break;
                        }
                    }
                }
            }
            return equal;
        }
        /// <summary>
        /// This function will have the pointers start in the middle of the string and move outward comparing values. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool two_pointers_middle(string input)
        {
            bool equal = false;
            int a = 0, b= 0;
            int length = input.Length;

            if(length > 2)
            {
                if(length % 2 == 0)
                {
                    // if the string has an even number of letters then move right pointer to the left so they don't start at the same spot
                    a = length / 2 - 1;
                    b = length / 2;

                    while(a>0 && b < length)
                    {
                        if(input[a] == input[b])
                            equal=true;
                        else
                        {
                            equal = false;
                            break;
                        }
                        a -= 1;
                        b += 1;
                    }
                }
                else
                {
                    a = b = length / 2;
                    while(a > 0 && b < length)
                    {
                        if (input[a] == input[b])
                            equal = true;
                        else
                        {
                            equal = false;
                            break;
                        }
                        a -= 1;
                        b += 1;
                    }
                }
            }

            return equal;
        }
        /// <summary>
        /// This method will cut the string in half and then compare the two new strings
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        static bool reverse_approach(string input)
        {
            bool equal = false;
            int length = input.Length;
            string a, b, b_reversed;
            int middle = 0;

            if (0 <= length && length <= 1)
                return true;
            if(length > 2)
            {
                if(length % 2 == 0)
                {
                    middle = length / 2;
                    a = input.Substring(0, middle);
                    b = input.Substring(middle);
                }
                else
                {
                    middle = ((length-1) / 2);
                    a = input.Substring(0, middle);
                    b = input.Substring(middle + 1);
                    
                }

                b_reversed = new string(b.Reverse().ToArray());
                if (a == b_reversed)
                    equal = true;
            }
            return equal;
        }
    }
}