namespace VisualInheritance {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            label1.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}