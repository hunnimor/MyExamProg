using System.Drawing.Drawing2D;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Imaging;

namespace exam
{
    public partial class Form1 : Form
    {
        private DBHelper dbh;
        private string login;
        private string password;
        Bitmap picture;
        private int height = 1057;
        private int width = 818;
        private double min;
        private double max;
        //private string function_text;

        int function(int x)
        {
            //PostfixNotationExpression c = new PostfixNotationExpression();
            //return c.result(function_text, x); // tyta funcia budet;
            if (x == 0) { x = 1; }
            return 1 / x;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string login, string password)
        {
            dbh = new DBHelper("localhost", 3306, "root", "", "exam");
            picture = new Bitmap(height, width);
            this.login = login;
            this.password = password;
            InitializeComponent();
        }
        private void информацияОбАккаунтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            $"Информация об аккаунте:\nЛогин:\t {login}\nПароль:\t{password}",
            "Информация об аккаунте");
        }

        private void выйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = -5, b = 5;
            Graphics graphics = Graphics.FromImage(picture);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            Pen myPen = new Pen(Color.Blue);

            graphics.DrawLine(myPen, new Point(10, 100), new Point(59, 32));
            graphics.DrawLine(myPen, new Point(400, 323), new Point(214, 4234));
            graphics.DrawLine(myPen, new Point(312, 994), new Point(134, 15));
            graphics.DrawLine(myPen, new Point(134, 994), new Point(903, 405));
            pictureBox1.Image = picture;
            pictureBox1.Refresh();
            dbh.InsertPicture(login, ImageToByteArray(pictureBox1.Image));
        }
        public byte[] ImageToByteArray(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}