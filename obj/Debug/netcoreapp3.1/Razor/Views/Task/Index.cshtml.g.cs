#pragma checksum "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a190b1b850f6868d32e1be6079ecdc6b0b24cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\_ViewImports.cshtml"
using TaskManagerZUwierzytelnieniem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\_ViewImports.cshtml"
using TaskManagerZUwierzytelnieniem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a190b1b850f6868d32e1be6079ecdc6b0b24cc", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f9620cfa091fe25af16436a207dbbf65dcc61ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskManagerZUwierzytelnieniem.Models.TaskModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"navbar-nav\">\r\n");
#nullable restore
#line 13 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Lista zadań</h1>\r\n");
            WriteLiteral("        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62a190b1b850f6868d32e1be6079ecdc6b0b24cc4279", async() => {
                WriteLiteral("Dodaj zadanie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 39 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 43 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                       Write(Html.ActionLink("Gotowe", "Done", new { id = item.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 47 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                       Write(Html.ActionLink("Edytuj", "Edit", new { id = item.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 48 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                       Write(Html.ActionLink("Szczegóły", "Details", new { id = item.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 49 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                       Write(Html.ActionLink("Usuń", "Delete", new { id = item.TaskId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 55 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"

    }
    else
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3><center><a href=\"Identity/Account/Login\">Proszę się zalogować, aby dodać zadanie.</a></center></h3>\r\n");
#nullable restore
#line 67 "C:\Users\marta\source\repos\TaskManagerZUwierzytelnieniem\Views\Task\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskManagerZUwierzytelnieniem.Models.TaskModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
