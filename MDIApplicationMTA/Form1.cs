namespace MDIApplicationMTA {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}