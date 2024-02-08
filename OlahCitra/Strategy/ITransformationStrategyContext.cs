using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public interface ITransformationStrategyContext
    {
        Bitmap RGBImage { get; }
        Bitmap GrayScaleImage { get; }
    }
}
