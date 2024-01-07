using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlahCitra.Strategy
{
    public abstract class TransformationStrategy
    {
        protected readonly OlahCitra _olahCitraForm;

        public TransformationStrategy(OlahCitra olahCitraForm)
        {
            _olahCitraForm = olahCitraForm;
        }

        public abstract Bitmap Transform();
    }
}
