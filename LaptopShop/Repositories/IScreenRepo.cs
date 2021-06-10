using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IScreenRepo
    {
        public Screen GetScreenById(int screenId);
        public IEnumerable<Screen> GetScreenByAspectRatio(string aspectRatio);
        public IEnumerable<Screen> GetScreenByResolution(string resolution);
        public IEnumerable<Screen> GetScreenBySize(float size);
        public IEnumerable<Screen> GetScreenByHDR(bool hdr);
        public IEnumerable<Screen> GetScreenByRefreshRate(int refreshRate);
        public IEnumerable<Screen> GetScreenByScreenTech(string screenTech);
        public IEnumerable<Screen> GetScreenByBrightness(string brightness);
        public IEnumerable<Screen> GetScreenByTouch(bool touch);
        public IEnumerable<Screen> GetScreenBySyncType(string syncType);
    }
}
