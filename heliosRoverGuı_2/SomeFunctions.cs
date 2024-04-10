using Newtonsoft.Json.Linq;
using Plasmoid.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heliosRoverGuı_2
{
    static class SomeFunctions
    {
        // Menüdeki Rounded Rectangleları paneller boyutunda otomatik yapmamızı sağlayan fonksiyon
        public static void RoundedLookingPanel(PaintEventArgs e,Panel pnl,int radius,Color clr)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(clr), 0, 0, pnl.Width, pnl.Height, radius);
            SolidBrush brush = new SolidBrush(clr);
        }


    }
}
