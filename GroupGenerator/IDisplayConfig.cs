namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IDisplayConfig
    {
        int Id { get; set; }

        int DisplayModeFullNameWithId { get; set; }

        string Name { get; set; }
    }
}
