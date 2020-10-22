using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabControl.Links
{
    public partial class TabNavLink
    {
        [Parameter]
        public String Id { get; set; }

        [Parameter]
        public String Name { get; set; }

        [Parameter]
        public bool IsActive { get; set; }
    }
}