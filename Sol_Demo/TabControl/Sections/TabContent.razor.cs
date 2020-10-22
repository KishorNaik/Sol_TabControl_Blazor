﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabControl.Sections
{
    public partial class TabContent
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}