namespace WinFormsPracticeCalculator {
    public partial class Form1 : Form {
        private double currentResult;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Text = "potato";
            label1.Size = new Size(Size.Width, Size.Height);
            label1.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}