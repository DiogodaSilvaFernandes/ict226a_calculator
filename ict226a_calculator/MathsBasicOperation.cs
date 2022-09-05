using System;

namespace Calculator
{
    public class MathsBasicOperation
    {
        /// <summary>
        /// This method is designed to return the addition of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        /// <summary>
        /// This method is designed to return the substraction of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        public int Substract(int op1, int op2)
        {
            return op1 - op2;
        }

        /// <summary>
        /// This method is designed to return the multiplication of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        public int Multiply(int op1, int op2)
        { 
            return op1 * op2;
        }

        /// <summary>
        /// This method is designed to return the division of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        public int Divide(int op1, int op2)
        {
            return op1 / op2;
        }
    }
}
