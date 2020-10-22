using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TabControl.Sections
{
    public partial class TabPane
    {
        [Parameter]
        public RenderFragment TemplateSection { get; set; }

        [Parameter]
        public String Title { get; set; }

        [Parameter]
        public String RefId { get; set; }

        [Parameter]
        public bool IsActive { get; set; }
    }
}