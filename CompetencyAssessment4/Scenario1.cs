namespace CompetencyAssessment4 {
    public abstract class Scenario1 {
        
        /// <summary>
        /// Main method equivalent for Scenario 1.
        /// </summary>
        public static void RunScenario1() => Console.WriteLine($"Your quantity-based discount is {HandleQuantity(TakeNumericalInput("Please enter your total item quantity: ", null))}%");

        /// <summary>
        /// Returns a discount based on the given quantity.
        /// </summary>
        /// <param name="quantity">Number of ordered items.</param>
        /// <returns>Discount</returns>
        private static double HandleQuantity(double? quantity) { 
            if (quantity == null) {
                return -0.50;
            } else if (quantity < 10) {
                return 0.05;
            } else if (quantity < 50) {
                return 0.10;
            } else if (quantity < 100) {
                return 0.15;
            } else if (quantity >= 100) {
                return 0.20;
            }

            return 0;
        }

        /// <summary>
        /// Prompts the user for a numerical value. If parsing is successful, returns the <c>int</c> form, else the default provided.
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
                Console.WriteLine("You will be fined for your failure to input a valid quantity.");
                return def;
            }
        }
    }
}
