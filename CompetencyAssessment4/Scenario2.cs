namespace CompetencyAssessment4 {
    public abstract class Scenario2 {
        /// <summary>
        /// Main method equivalent for Scenario2.
        /// </summary>
        public static void RunScenario2() => UserFact();

        /// <summary>
        /// Takes input from user and outputs the value's factorial.
        /// </summary>
        private static void UserFact() {
            double? n = TakeNumericalInput("Please enter the number you wish to receive the factorial of: ", null);

            if (n == null) {
                Console.WriteLine("Sorry, that's not a valid number.");
                return;
            }

            Console.WriteLine($"The factorial of {n} is {Fact((double)n)}");
        }

        /// <summary>
        /// Returns the factorial of given <c>n</c>;
        /// </summary>
        /// <param name="n">n</param>
        /// <returns></returns>
        private static double Fact(double n) {
            double _fact = 1;

            while (n > 1) {
                _fact *= n;
                n--;
            }

            return _fact;
        }

        /// <summary>
        /// Prompts the user for a numerical value. If parsing is successful, returns the <c>int</c> form, else the default provided (duplicate method for standalone purposes).
        /// </summary>
        /// <param name="prompt">Text prompt for user.</param>
        /// <param name="def">Default value should parsing fail.</param>
        /// <returns></returns>
        private static double? TakeNumericalInput(string prompt, double? def) {
            Console.Write(prompt);

            try {
                string? input = Console.ReadLine();

                if (input == null || input == "") {
                    throw new Exception();
                }

                return double.Parse(input);
            } catch (Exception) {
                Console.WriteLine("Invalid n value.");
                return def;
            }
        }
    }
}
