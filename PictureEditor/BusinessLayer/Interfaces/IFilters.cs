﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEditor.BusinessLayer.Interfaces
{
    public interface IFilters
    {
        Bitmap BlackWhite (Bitmap bitmap);
        Bitmap MagicMosaic (Bitmap bitmap);
        Bitmap Swap (Bitmap bitmap);
    }
}