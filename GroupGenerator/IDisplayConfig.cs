﻿namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IDisplayConfig
    {
        string Id { get; set; }

        string Name { get; set; }

        int DisplayMode { get; set; }

        bool Validate(string value);
    }
}
