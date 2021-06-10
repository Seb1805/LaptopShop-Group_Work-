using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    class ScreenRepo : IScreenRepo
    {
        private readonly IEnumerable<Screen> _context;

        public ScreenRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Screen> GetScreenByAspectRatio(string aspectRatio)
        {
            return _context.
        }

        public IEnumerable<Screen> GetScreenByBrightness(int brightness)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenByHDR(bool HDR)
        {
            throw new NotImplementedException();
        }

        public Screen GetScreenById(int screenId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenByRefreshRate(int refreshRate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenByResolution(string resolution)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenByScreenTech(string screenTech)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenBySize(float size)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenBySyncType(string syncType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Screen> GetScreenByTouch(bool touch)
        {
            throw new NotImplementedException();
        }
    }
}
