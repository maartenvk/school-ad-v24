using System;

namespace AD
{
    public static class BracketChecker
    {

        /// <summary>
        ///    Run over all characters in a string, push all '(' characters
        ///    found on a stack. When ')' is found, it shoud match a '(' on
        ///    the stack, which is then popped.
        ///
        ///    If ')' is found when no '(' is on the stack, this method will
        ///    terminate prematurely, no further inspection is needed.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>Returns True if all '(' are matched by ')'.
        /// Returns False otherwise.</returns>
        public static bool CheckBrackets(string s)
        {
            // faster implementation
            int count = 0;
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(': count++; break;
                    case ')': count--; break;
                }

                if (count < 0)
                {
                    return false;
                }
            }

            return count == 0;

            // naive
            MyStack<char> stack = new();

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;

                    case ')':
                        if (stack.IsEmpty())
                        {
                            return false;
                        }

                        stack.Pop();
                        break;

                    default:
                        break;
                }
            }

            return stack.IsEmpty();
        }


        /// <summary>
        ///    Run over all characters in a string, when an opening bracket is
		///    found the closing counterpart from closeChar is pushed on a Stack
        ///    When an closing bracket is found, it should match the top character
		///    from this stack.
		///    
        ///    This method will terminate prematurely if a wrong or missmatched
        ///    closing bracket is found and no further inspection is needed.
		/// </summary>
		/// <param name="s">The string to check</param>
		/// <returns>Returns True if all opening brackets are matched by
		/// it's correct counterpart in a correct order.
        /// Returns False otherwise.</returns>
        public static bool CheckBrackets2(string s)
        {
            MyStack<char> stack = new();

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(c);
                        break;

                    case ')':
                    case ']':
                    case '}':
                        if (stack.IsEmpty())
                        {
                            return false;
                        }

                        char opposite = c switch
                        {
                            ')' => '(',
                            ']' => '[',
                            '}' => '{',
                            _ => throw new NotImplementedException()
                        };

                        if (stack.Top() != opposite)
                        {
                            return false;
                        }

                        stack.Pop();
                        break;

                    default:
                        break;
                }
            }

            return stack.IsEmpty();
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
