using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Adapter.Services
{
    public interface IAdvanceImageProcess
    {
        //void AddWaterMark(string text, string fileName, Stream imageStream);

        void AddWaterMarkImage(Stream stream, string text, string filePath, Color color, Color outlineColor);
    }
}
