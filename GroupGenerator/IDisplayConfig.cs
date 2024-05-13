namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IDisplayConfig
    {
        // Enforce of the fields propreties
        string Id { get; set; }

        string Name { get; set; }

        int DisplayMode { get; set; }

        // Enforce of this method
        bool Validate(string value);
    }
}
