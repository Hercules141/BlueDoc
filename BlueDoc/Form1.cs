namespace BlueDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            MessageBox.Show("get back here!");
        }
    }
}