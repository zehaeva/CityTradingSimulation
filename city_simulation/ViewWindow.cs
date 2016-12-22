using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace city_simulation
{
    public class ViewWindow : Form
    {
        private List<TradeRoute> _tradeRoutes;
        private List<City> _cities;
        private Timer _timer;
        private long _time_elapsed;

        public ViewWindow(List<TradeRoute> tradeRoutes, List<City> cities)
        {
            Rectangle screen = Screen.FromControl(this).Bounds;
            Bounds = new Rectangle((screen.Width / 2) - 400 , (screen.Height / 2) - 300, 800, 600);
            BackColor = Color.White;
            // FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            _cities = cities;
            _tradeRoutes = tradeRoutes;

            _time_elapsed = 0;

            _timer = new Timer();
            _timer.Interval = 1000 / 60;
            _timer.Enabled = true;
            _timer.Tick += new EventHandler(tick);

            _timer.Start();
        }

        private void tick(Object o, EventArgs e)
        {
            if (_time_elapsed == 20)
            {
                foreach (City city in _cities)
                {
                    city.nextTurn();
                }
                _time_elapsed = 0;
            }
            else
            {
                _time_elapsed++;
            }

            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            float y = 0;

            foreach (var city in _cities)
            {
                g.DrawString(city.Name + " " + city.Products[0].StockPile,  new Font("Ariel", 16), new SolidBrush(Color.Black), 0, y);

                y += 24;
            }
        }


    }
}