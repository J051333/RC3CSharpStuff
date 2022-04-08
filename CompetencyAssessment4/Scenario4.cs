namespace CompetencyAssessment4 {
    public abstract class Scenario4 {
        /// <summary>
        /// Scenario4's main method.
        /// </summary>
        public static void RunScenario4() {
            double n = TakeNumericalInput("Please enter the number to evaluate: ", 5);

            Console.WriteLine($"There are {CountDigits(n)} digits in {n}.");
        }

        // I'm taking the easy way out but I was too tired to think of the mathematical
        // approach to this. I would have used the modulo and / 10 but that doesn't count
        // decimals. The approach using TakeNumericalInput does ensure that n is a valid numeral though.
        /// <summary>
        /// Counts the number of digits in the given number.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static double CountDigits(double n) {
            return n.ToString().Contains('.') ? n.ToString().Remove(n.ToString().IndexOf('.'), 1).Length : n.ToString().Length;
        }

        /// <summary>
        /// Prompts the user for a numerical value. If parsing is successful, returns the <c>int</c> form, else the default provided (duplicate method for standalone purposes).
        /// </summary>
        /// <param name="prompt">Text prompt for user.</param>
        /// <param name="def">Default value should parsing fail.</param>
        /// <returns></returns>
        private static double TakeNumericalInput(string prompt, double def) {
            Console.Write(prompt);

            try {
                string? input = Console.ReadLine();

                if (input == null || input == "") {
                    throw new Exception();
                }

                return double.Parse(input);
            } catch (Exception) {
                Console.WriteLine("Invalid value.");
                return def;
            }
        }
    }
}
