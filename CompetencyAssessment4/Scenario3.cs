namespace CompetencyAssessment4 {
    public abstract class Scenario3 {
        /// <summary>
        /// Scenario3's main method.
        /// </summary>
        public static void RunScenario3() {
            double x = TakeNumericalInput("Please enter x: ", 10);
            double y = TakeNumericalInput("Please enter x: ", 5);

            Console.WriteLine($"The quotient of x and y is {MyLibDotDivide(x, y)}.");
        }

        /// <summary>
        /// A simple division method.
        /// </summary>
        /// <param name="x">Numerator</param>
        /// <param name="y">Denominator</param>
        /// <returns>Quotient of x and y</returns>
        private static double MyLibDotDivide(double x, double y) { 
            try {
                return x / y;
                
                // This should catch any exception. I'm not sure how many [exceptions]
                // simple division of two doubles could cause but it's there.
            } catch (Exception) {
                return 0;
            }
        }

        // The majority of the exception handling would happen here.
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