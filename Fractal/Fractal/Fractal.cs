namespace Fractal
{
    public partial class frmFractal : Form
    {

        Random rndGen = new Random();

        public frmFractal()
        {
            InitializeComponent();
        }

        public void Generate_Fractal(int n, Graphics g, /*int x, int y, int width, int height,*/ Point p1, Point p2, Point p3, Point p4, Point p5, Point p6)
        {
            if (n == 0)
                return;
            else
            {

                // creating RGB variables 
                int R = rndGen.Next(0, 256);
                int G = rndGen.Next(0, 256);
                int B = rndGen.Next(0, 256);

                // generating random colour
                Color FractalColor = Color.FromArgb(180, R, G, B);

                // creating brush and pen for fractal
                SolidBrush myBrush = new SolidBrush(FractalColor);
                Pen myPen = new Pen(FractalColor, 2);

                // creating 6 points for hexagon
                Point[] hexagon = new Point[6];

                // creating midpoints of sides
                Point m1, m2, m3, m4, m5, m6;

                // creating midpoints as new point 
                m1 = new Point();
                m2 = new Point();
                m3 = new Point();
                m4 = new Point();
                m5 = new Point();
                m6 = new Point();

                // putting points of hexagon in an array
                hexagon[0] = p1;
                hexagon[1] = p2;
                hexagon[2] = p3;
                hexagon[3] = p4;
                hexagon[4] = p5;
                hexagon[5] = p6;

                // drawing and filling the hexagon
                g.DrawPolygon(myPen, hexagon);
                g.FillPolygon(myBrush, hexagon);

                // midpoint of linesegment p1p2
                m1.X = (p1.X + p2.X) / 2;
                m1.Y = (p1.Y + p2.Y) / 2;
                // midpoint of linesegment p2p3
                m2.X = (p2.X + p3.X) / 2;
                m2.Y = (p2.Y + p3.Y) / 2;
                // midpoint of linesegment p3p4
                m3.X = (p3.X + p4.X) / 2;
                m3.Y = (p3.Y + p4.Y) / 2;
                // midpoint of linesegment p4p5
                m4.X = (p4.X + p5.X) / 2;
                m4.Y = (p4.Y + p5.Y) / 2;
                // midpoint of linesegment p5p6
                m5.X = (p5.X + p6.X) / 2;
                m5.Y = (p2.Y + p3.Y) / 2;
                // midpoint of linesegment p6p1
                m6.X = (p6.X + p1.X) / 2;
                m6.Y = (p6.Y + p1.Y) / 2;

                // defining the midpoint of hexagon
                Point midpoint;
                midpoint = new Point();

                // defining x and y coordinates of hexagon
                midpoint.X = 303;
                midpoint.Y = 303;

                // translating hexagon about midpoint
                g.TranslateTransform(midpoint.X, midpoint.Y);

                // rotating hexagon 90 degrees
                g.RotateTransform(90f);

                // translating hexagon about midpoint, and saving it to draw
                g.TranslateTransform(-midpoint.X, -midpoint.Y);
                g.DrawPolygon(myPen, hexagon.ToArray());

                // calling rcursive method inside its method
                Generate_Fractal(n - 1, g, m1, m2, m3, m4, m5, m6);

            }
        }

        // method when generate button is clicked
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                Point p1, p2, p3, p4, p5, p6;
                n = Convert.ToInt32(txtGenerate.Text);

                // creating points as new points
                p1 = new Point();
                p2 = new Point();
                p3 = new Point();
                p4 = new Point();
                p5 = new Point();
                p6 = new Point();

                // defining x and y components of each point
                p1.X = 505;
                p1.Y = 1;
                p2.X = 604;
                p2.Y = 303;
                p3.X = 505;
                p3.Y = 604;
                p4.X = 100;
                p4.Y = 604;
                p5.X = 1;
                p5.Y = 303;
                p6.X = 100;
                p6.Y = 1;

                // generating graphics in picture box
                Graphics g = Graphics.FromHwnd(pbFractal.Handle);
                g.Clear(Color.White);

                // calling the recursive method to generate fractal
                Generate_Fractal(n, g, p1, p2, p3, p4, p5, p6);
            }
            catch
            {
                MessageBox.Show("An error occured, please try again!");
            }
        }
    }
}