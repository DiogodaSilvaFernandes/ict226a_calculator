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

            do
            {
                op2 = AskUserForInteger("Rentrez votre second numéro :");

                if (op2 == 0) DisplayMessage("Vous ne pouvez pas diviser un nombre par 0 !");
            } while(op2 == 0);

            result = PerformCalculation(op1, oper, op2);

            DisplayResult(op1, oper, op2, result);

            result = 0;
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
        /// This method is design to perform a calculation using the MathsBasicOperation class
        /// </summary>
        /// <param name="op1">First number choosed by the user</param>
        /// <param name="oper">Math operator choosed by the user</param>
        /// <param name="op2">Second number choosed by the user</param>
        /// <returns>Calculation result (add/substract/multiply/divide)</returns>
        static int PerformCalculation(int op1, char oper, int op2)
        {
            MathsBasicOperation mathsOperations = new MathsBasicOperation();
            int result = 0;

            switch (oper)
            {
                case '+':
                    result = mathsOperations.Add(op1, op2);
                    break;

                case '-':
                    result = mathsOperations.Substract(op1, op2);
                    break;

                case '*':
                    result = mathsOperations.Multiply(op1, op2);
                    break;

                case '/':
                    result = mathsOperations.Divide(op1, op2);
                    break;

                default:
                    DisplayMessage("L'opérateur demandé n'est pas disponible.");
                    break;
            }

            return result;
        }
    }
}