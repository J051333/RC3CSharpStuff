namespace MTABookRect {
    public class Program {
        static void Main() {
            Rectangle rect1 = new Rectangle() { Length = 10, Width = 200 };
            Rectangle rect2 = new Rectangle() { Length = 100, Width = 200 };

            Console.WriteLine(rect1.CompareTo(rect2));
        }
    }
}