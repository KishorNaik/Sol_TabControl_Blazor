using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabControl.Links
{
    public partial class TabLink
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}