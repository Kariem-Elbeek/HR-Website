#pragma checksum "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "754e492d2666a8aaf681ec110e07b2d55b4e93d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.DAL.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754e492d2666a8aaf681ec110e07b2d55b4e93d4", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358b92d7e6ebd46e6a1776cf51dd91c3ee6937e0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-SearchValue", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Cancel Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Employee Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-black-50\">All employees </h1>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754e492d2666a8aaf681ec110e07b2d55b4e93d49016", async() => {
                WriteLiteral("Create New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "754e492d2666a8aaf681ec110e07b2d55b4e93d410287", async() => {
                WriteLiteral(@"
    <div class=""row align-item-center justify-content-center"">
        <div class=""col-8"">
            <input type=""text"" class=""form-control"" placeholder=""Search by Name"" name=""SearchValue"" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" class=""btn btn-primary"" value=""Search""/>
");
#nullable restore
#line 19 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
             if (ViewData["SearchPage"] == "SearchPageSuccess")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "754e492d2666a8aaf681ec110e07b2d55b4e93d411215", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-SearchValue", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["SearchValue"] = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"mt-3 table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 31 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 32 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 33 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 34 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 37 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 38 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 39 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 40 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d => d.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 47 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
             foreach (var employee in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 50 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "754e492d2666a8aaf681ec110e07b2d55b4e93d419835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2064, "~/files/images/", 2064, 15, true);
#nullable restore
#line 53 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 2079, employee.ImageName, 2079, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(m => employee.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "754e492d2666a8aaf681ec110e07b2d55b4e93d423766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#nullable restore
#line 60 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = employee.Id.ToString();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n                </tr>\r\n");
#nullable restore
#line 62 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 66 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-5\">\r\n        <table class=\"mt-3 table table-striped table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 74 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 75 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 76 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 77 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.Department.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 78 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 79 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 80 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 81 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 82 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayNameFor(d => d.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                    <th>Details</th>
                    <th>Update</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>
        <h3 class=""mt-5 alert alert-warning"">
            No Emplyees Available!
        </h3>
    </div>
");
#nullable restore
#line 93 "E:\ACADEMY ROUTE\Back End\Eng Ahmed Nasr\07 ASP.NET MVC\MVC Project\MVC_Project_Solution\Demo.PL\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
