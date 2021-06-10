using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IScreenRepo
    {
        public Screen GetScreenById(int screenId);
        public Screen GetScreenByAspectRatio(string aspectRatio);
        public Screen GetScreenByResolution(string resolution);
        public Screen GetScreenBySize(float size);
        public Screen GetScreenByHDR(bool HDR);
        public Screen GetScreenByRefreshRate(int refreshRate);
        public Screen GetScreenByScreenTech(string screenTech);
        public Screen GetScreenByBrightness(int brightness);
        public Screen GetScreenByTouch(bool touch);
        public Screen GetScreenBySyncType(string syncType);
    }
}
