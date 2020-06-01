﻿using AzureSpherePublicAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSphereExplorer
{
    class ImageModel
    {
        public AzureSphereImage Context;

        public string Image { get; set; }
        public string Description { get; set; }
        public int ImageType { get; set; }
    }
}
