namespace border
{
    public partial class Form1 : Form
    {
        private bool isLeftMouseDown = false;
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = true;
                startPoint = e.Location;
            }
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isLeftMouseDown = false;
            }
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isLeftMouseDown)
            {
               
                int dx = e.X - startPoint.X;
                int dy = e.Y - startPoint.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }
        private void Label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }
        private void Label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}