#pragma checksum "E:\практика\резерв\WebApplication1\WebApplication1\Views\People1\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3596e8795272111432a9bdb1809007aee110cc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People1_Edit), @"mvc.1.0.view", @"/Views/People1/Edit.cshtml")]
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
#line 1 "E:\практика\резерв\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3596e8795272111432a9bdb1809007aee110cc8", @"/Views/People1/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395f142e01bc38e8ed6ce859d70e3249e21cfb62", @"/Views/_ViewImports.cshtml")]
    public class Views_People1_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\практика\резерв\WebApplication1\WebApplication1\Views\People1\Edit.cshtml"
  
    ViewData["Title"] = "Изменить";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Изменить</h1>


<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""id"" />
            <div class=""form-group"">
                <label asp-for=""name"" class=""control-label""></label>
                <input asp-for=""name"" class=""form-control"" />
                <span asp-validation-for=""name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""date"" class=""control-label""></label>
                <input asp-for=""date"" class=""form-control"" />
                <span asp-validation-for=""date"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""img"" class=""control-label""></label>
                <input asp-for=""img"" class=""form-control"" />
                <span asp-validation-for=""img"" class=""text-danger""></span>");
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                <label asp-for=""categoryID"" class=""control-label""></label>
                <select asp-for=""categoryID"" class=""form-control"" asp-items=""ViewBag.categoryID""></select>
                <span asp-validation-for=""categoryID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Сохранить"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a href=""/People1/Index"">Вернуться назад</a>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
