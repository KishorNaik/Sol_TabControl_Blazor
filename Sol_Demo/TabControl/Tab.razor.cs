using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace TabControl
{
    public partial class Tab
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}