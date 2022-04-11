namespace MTABookRect {
    public class Rectangle : Polygon, IComparable {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get { return Length * Width; } }

        public override void Draw() {
            Console.WriteLine("Drawing: Rectangle");
        }

        public int CompareTo(object? obj) { 
            if (obj == null) {
                return 1;
            }
            
            if (obj is not Rectangle) {
                throw new ArgumentException("Argument not a Rectangle.");
            }

            Rectangle target = (Rectangle) obj;
            double diff = Area - target.Area;

            if (diff == 0) {
                return 0;
            } else if (diff > 0) {
                return 1;
            } else {
                return -1;
            }
        }
    }
}
