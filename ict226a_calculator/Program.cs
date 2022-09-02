namespace Calculator
{
    class Program
    {
        #region var section
        static int result;
        static int op1;
        static int op2;
        static char oper;
        static char[] operators = {'+','-','*','/'};
        #endregion

        /// <summary>
        /// This method is the entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // checks if the operator the user entered is in the list, if not, it will a new time ask the operator
            do
            {
                oper = AskUserForCharInput("Rentrez votre opérateur :");
            } while(!operators.Contains(oper));

            op1 = AskUserForInteger("Rentrez votre premier numéro :");
            op2 = AskUserForInteger("Rentrez votre second numéro :");

            switch (oper)
            {
                case '+':
                    result = Add(op1, op2);
                    break;

                case '-':
                    result = Substract(op1, op2);
                    break;

                case '*':
                    result = Multiply(op1, op2);
                    break;

                case '/':
                    result = Divide(op1, op2);
                    break;
                //TODO Add default case (exception ?)
            }
            DisplayResult(op1, oper, op2, result);
            
            //TODO What about reset result to get a clean environnement before the next user's request ?
        }

        /// <summary>
        /// This method is designed to ask to the user a math operator
        /// </summary>
        /// <param name="question">A question who will be shown to the user</param>
        /// <returns></returns>
        static char AskUserForCharInput(string question)
        {
            DisplayMessage(question);

            char[] calcOperator = Console.ReadLine().ToCharArray();

            return calcOperator[0];
        }

        /// <summary>
        /// This method is designed to ask to the user a number
        /// </summary>
        /// <param name="question">A question who will be shown to the user</param>
        /// <returns></returns>
        static int AskUserForInteger(string question)
        {
            DisplayMessage(question);

            int number = Int32.Parse(Console.ReadLine());

            return number;
        }

        /// <summary>
        /// This method is designed to show to the user the result
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="oper">Math operator choosed by the user </param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <param name="result">Result (Add/Substract/Multiply/Divide)</param>
        static void DisplayResult(int op1, char oper, int op2, int result)
        {
            DisplayMessage($"{op1} {oper} {op2} = {result}");
        }

        /// <summary>
        /// This method is designed to show to the user any message
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// This method is designed to return the addition of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        static int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        /// <summary>
        /// This method is designed to return the substraction of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        static int Substract(int op1, int op2)
        {
            return op1 - op2;
        }

        /// <summary>
        /// This method is designed to return the multiplication of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        static int Multiply(int op1, int op2)
        {
            return op1 * op2;
        }

        /// <summary>
        /// This method is designed to return the division of 2 numbers
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns></returns>
        static int Divide(int op1, int op2)
        {
            //TODO Add division by zero protection
            return op1 / op2;
        }
    }
}