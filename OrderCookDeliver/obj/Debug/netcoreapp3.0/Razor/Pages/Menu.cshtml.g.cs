#pragma checksum "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8b8ef89725f887afb7d6483d52fb09dfd13b87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OrderCookDeliver.Pages.Pages_Menu), @"mvc.1.0.razor-page", @"/Pages/Menu.cshtml")]
namespace OrderCookDeliver.Pages
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
#line 1 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\_ViewImports.cshtml"
using OrderCookDeliver;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b8ef89725f887afb7d6483d52fb09dfd13b87a", @"/Pages/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc945ea3b24905559f5ee358ca8b3089eb01d573", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Menu : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("480"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("338"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
  
    //get current week
    DateTime week = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek));
    string month = "Jan";
    int day = Convert.ToInt32(week.Day);

    //determine the rotation
    int rot = 1;

    //determine the current month
    switch (week.Month)
    {
        case 1:
            month = "Jan";
            break;
        case 2:
            month = "Feb";
            break;
        case 3:
            month = "Mar";
            break;
        case 4:
            month = "Apr";
            break;
        case 5:
            month = "May";
            break;
        case 6:
            month = "Jun";
            break;
        case 7:
            month = "Jul";
            break;
        case 8:
            month = "Aug";
            break;
        case 9:
            month = "Sep";
            break;
        case 10:
            month = "Oct";
            break;
        case 11:
            month = "Nov";
            break;
        case 12:
            month = "Dec";
            break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">

    <section class=""jumbotron text-center"">
        <div class=""container"">
            <h1 class=""jumbotron-heading""><b>Menu</b></h1>
            <h4>Current menu for the week</h4>
        </div>
    </section>

        <div class=""album py-5 bg-light"">
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 70 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                 foreach (var item in Model.calendar)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        int currentDay = day + i;
                        DateTime dayWeek = week.AddDays(i);
                        if (item.rotation == 1 & item.day == i)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                             if (item.mealId == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-4\"");
            BeginWriteAttribute("id", " id=", 2024, "", 2036, 1);
#nullable restore
#line 80 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
WriteAttributeValue("", 2028, item.ID, 2028, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <h3><b>");
#nullable restore
#line 81 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                          Write(month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 81 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                 Write(currentDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 81 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                              Write(dayWeek.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n                                        <div class=\"card mb-4 shadow-sm\">\r\n                                            <h6><b>");
#nullable restore
#line 83 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                              Write(item.mealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8b8ef89725f887afb7d6483d52fb09dfd13b87a8924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2340, "~/img/", 2340, 6, true);
#nullable restore
#line 84 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
AddHtmlAttributeValue("", 2346, item.mealName, 2346, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2362, ".png", 2362, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 84 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
AddHtmlAttributeValue("", 2373, item.mealName, 2373, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <div class=\"card-body\">\r\n                                                <p class=\"card-text\">");
#nullable restore
#line 86 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                                Write(item.mealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <div class=\"d-flex justify-content-between align-items-center\">\r\n                                                    <div class=\"btn-group\">\r\n");
#nullable restore
#line 89 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                         if (currentDay != DateTime.Today.Day)
                                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b8ef89725f887afb7d6483d52fb09dfd13b87a12145", async() => {
                WriteLiteral("\r\n                                                                <input type=\"submit\" class=\"btn btn-sm btn-outline-secondary\" value=\"Details\">\r\n                                                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 3248, "\"", 3270, 1);
#nullable restore
#line 94 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
WriteAttributeValue("", 3256, item.mealName, 3256, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"meal\" hidden />\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
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
#line 96 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                         if (currentDay <= DateTime.Today.Day)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <button href=\"Detail\" type=\"button\" class=\"btn btn-sm btn-outline-secondary\" disabled>Details</button>\r\n");
#nullable restore
#line 100 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </div>
                                                    <small class=""text-muted"">$5.99</small>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-4""></div>
");
#nullable restore
#line 108 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                               
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                             if (item.mealId == 2)
                            {

                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-4\"");
            BeginWriteAttribute("id", " id=", 4460, "", 4472, 1);
#nullable restore
#line 114 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
WriteAttributeValue("", 4464, item.ID, 4464, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <br /><br />\r\n                                        <div class=\"card mb-4 shadow-sm\">\r\n                                            <h6><b>");
#nullable restore
#line 117 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                              Write(item.mealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d8b8ef89725f887afb7d6483d52fb09dfd13b87a17541", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4734, "~/img/", 4734, 6, true);
#nullable restore
#line 118 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
AddHtmlAttributeValue("", 4740, item.mealName, 4740, 16, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 4756, ".png", 4756, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 118 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
AddHtmlAttributeValue("", 4767, item.mealName, 4767, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <div class=\"card-body\">\r\n                                                <p class=\"card-text\">");
#nullable restore
#line 120 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                                Write(item.mealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <div class=\"d-flex justify-content-between align-items-center\">\r\n                                                    <div class=\"btn-group\">\r\n");
#nullable restore
#line 123 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                         if (currentDay > DateTime.Today.Day)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8b8ef89725f887afb7d6483d52fb09dfd13b87a20764", async() => {
                WriteLiteral("\r\n                                                                <input type=\"submit\" class=\"btn btn-sm btn-outline-secondary\" value=\"Details\">\r\n                                                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 5639, "\"", 5661, 1);
#nullable restore
#line 127 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
WriteAttributeValue("", 5647, item.mealName, 5647, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"meal\" hidden />\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
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
#line 129 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                         if (currentDay <= DateTime.Today.Day)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <button href=\"Detail\" type=\"button\" class=\"btn btn-sm btn-outline-secondary\" disabled>Details</button>\r\n");
#nullable restore
#line 133 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </div>
                                                    <small class=""text-muted"">$5.99</small>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
");
#nullable restore
#line 140 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                                    
                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\Armando\source\repos\OrderCookDeliver\OrderCookDeliver\Pages\Menu.cshtml"
                              
                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderCookDeliver.Pages.MenuModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrderCookDeliver.Pages.MenuModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OrderCookDeliver.Pages.MenuModel>)PageContext?.ViewData;
        public OrderCookDeliver.Pages.MenuModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
