using System.Drawing;
using System.Windows.Forms;

namespace city_simulation
{
    public class ViewWindow : Form
    {
        public ViewWindow()
        {
            Rectangle screen = Screen.FromControl(this).Bounds;
            Bounds = new Rectangle((screen.Width / 2) - 400 , (screen.Height / 2) - 300, 800, 600);
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawEllipse(new Pen(Color.Black), 10, 10, 100, 100);
        }
    }
}