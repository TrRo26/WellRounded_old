// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WellRounded.Server.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using WellRounded.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repos\WellRounded\WellRounded.Server\_Imports.razor"
using WellRounded.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Repos\WellRounded\WellRounded.Server\Shared\CategoryMenu.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\WellRounded\WellRounded.Server\Shared\CategoryMenu.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\WellRounded\WellRounded.Server\Shared\CategoryMenu.razor"
using Posts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\WellRounded\WellRounded.Server\Shared\CategoryMenu.razor"
using DataService;

#line default
#line hidden
#nullable disable
    public partial class CategoryMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Repos\WellRounded\WellRounded.Server\Shared\CategoryMenu.razor"
       
    public List<PostMetadata> posts = DataService.PostsService.GetPostsMetadata();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
