using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class ScreenRepo : IScreenRepo
    {
        private readonly LaptopContext _context;

        public ScreenRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Screen> GetScreenByAspectRatio(string aspectRatio)
        {
            return _context.Screen.Where(s => s.AspectRatio == aspectRatio);
        }

        public IEnumerable<Screen> GetScreenByBrightness(int brightness)
        {
            return _context.Screen.Where(s => s.Brightness == brightness);
        }

        public IEnumerable<Screen> GetScreenByHDR(bool hdr)
        {
            return _context.Screen.Where(s => s.HDR == hdr);
        }

        public Screen GetScreenById(int screenId)
        {
            return _context.Screen.FirstOrDefault(s => s.ScreenId == screenId);
        }

        public IEnumerable<Screen> GetScreenByRefreshRate(int refreshRate)
        {
            return _context.Screen.Where(s => s.RefreshRate == refreshRate);
        }

        public IEnumerable<Screen> GetScreenByResolution(string resolution)
        {
            return _context.Screen.Where(s => s.Resolution == resolution);
        }

        public IEnumerable<Screen> GetScreenByScreenTech(string screenTech)
        {
            return _context.Screen.Where(s => s.ScreenTechnology == screenTech);
        }

        public IEnumerable<Screen> GetScreenBySize(float size)
        {
            return _context.Screen.Where(s => s.Size == size);
        }

        public IEnumerable<Screen> GetScreenBySyncType(string syncType)
        {
            return _context.Screen.Where(s => s.SyncType == syncType);
        }

        public IEnumerable<Screen> GetScreenByTouch(bool touch)
        {
            return _context.Screen.Where(s => s.Touch == touch);
        }
    }
}
