using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace city_simulation
{
    public class ViewWindow : Form
    {
        private List<TradeRoute> _tradeRoutes;
        private List<City> _cities;

        public ViewWindow(List<TradeRoute> tradeRoutes, List<City> cities)
        {
            Rectangle screen = Screen.FromControl(this).Bounds;
            Bounds = new Rectangle((screen.Width / 2) - 400 , (screen.Height / 2) - 300, 800, 600);
            BackColor = Color.White;
            // FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            _cities = cities;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            float y = 0;

            foreach (var city in _cities)
            {
                g.DrawString(city.Name,  new Font("Ariel", 16), new SolidBrush(Color.Black), 0, y);

                y += 24;
            }
        }
    }
}