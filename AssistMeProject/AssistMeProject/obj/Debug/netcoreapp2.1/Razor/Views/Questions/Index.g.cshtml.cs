#pragma checksum "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e03c64e8dd4b1bffa077a627df446463666e488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Index), @"mvc.1.0.view", @"/Views/Questions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Index.cshtml", typeof(AspNetCore.Views_Questions_Index))]
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
#line 1 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject;

#line default
#line hidden
#line 2 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\_ViewImports.cshtml"
using AssistMeProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e03c64e8dd4b1bffa077a627df446463666e488", @"/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e9000fdfbf39452f2df6e36ab8c5a2875360c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssistMeProject.Models.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Questions";

#line default
#line hidden
            BeginContext(100, 526, true);
            WriteLiteral(@"
<div class=""col-md-9"">

    <section class=""container main-content"">
        <div class=""row"">
            <div class=""col-md-9"">

                <div class=""tabs-warp question-tab"">
                    <ul class=""tabs"">
                        <li class=""tab""><a href=""#"" class=""current"">Recent Questions</a></li>
                        <li class=""tab""><a href=""#"">No answers</a></li>
                    </ul>
                    <div class=""tab-inner-warp"">
                        <div class=""tab-inner"">
");
            EndContext();
#line 20 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(715, 163, true);
            WriteLiteral("                                <article class=\"question question-type-normal\">\r\n                                    <h2>\r\n                                        ");
            EndContext();
            BeginContext(878, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db439b8e60264bcaac6b81fc07f5a04b", async() => {
                BeginContext(926, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(928, 40, false);
#line 24 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(972, 743, true);
            WriteLiteral(@"
                                    </h2>
                                    <a class=""question-report"" href=""#"">Report</a>
                                    <div class=""question-type-main""><i class=""icon-question-sign""></i>Question</div>
                                    <div class=""question-author"">
                                        <a href=""#"" original-title=""ahmed"" class=""question-author-img tooltip-n""><span></span><img alt="""" src=""http://placehold.it/60x60/FFF/444""></a>
                                    </div>
                                    <div class=""question-inner"">
                                        <div class=""clearfix""></div>
                                        <p class=""question-desc"">");
            EndContext();
            BeginContext(1716, 46, false);
#line 33 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 606, true);
            WriteLiteral(@"</p>
                                        <div class=""question-details"">
                                            <span class=""question-answered question-answered-done""><i class=""icon-ok""></i>solved</span>
                                            <span class=""question-favorite""><i class=""icon-star""></i>5</span>
                                        </div>
                                        <span class=""question-category""><a href=""#""><i class=""icon-folder-close""></i>wordpress</a></span>
                                        <span class=""question-date""><i class=""icon-time""></i>");
            EndContext();
            BeginContext(2369, 39, false);
#line 39 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2408, 80, true);
            WriteLiteral("</span>\r\n                                        <span class=\"question-comment\">");
            EndContext();
            BeginContext(2488, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74b2bc6f6cb449ccbd3972b42f6d2952", async() => {
                BeginContext(2536, 36, true);
                WriteLiteral("<i class=\"icon-comment\"></i>5 Answer");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2576, 277, true);
            WriteLiteral(@"</span>
                                        <span class=""question-view""><i class=""icon-user""></i>70 views</span>
                                        <div class=""clearfix""></div>
                                    </div>
                                </article>
");
            EndContext();
#line 45 "D:\projects\visualStudio\AssistMe\AssistMeProject\AssistMeProject\Views\Questions\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2884, 964, true);
            WriteLiteral(@"                            <a href=""#"" class=""load-questions""><i class=""icon-refresh""></i>Load More Questions</a>
                        </div>
                    </div>

                </div>

            </div><!-- End page-content -->
            <aside class=""col-md-3 sidebar"">
                <div class=""widget widget_stats"">
                    <h3 class=""widget_title"">Stats</h3>
                    <div class=""ul_list ul_list-icon-ok"">
                        <ul>
                            <li><i class=""icon-question-sign""></i>Questions ( <span>20</span> )</li>
                            <li><i class=""icon-comment""></i>Answers ( <span>50</span> )</li>
                        </ul>
                    </div>
                </div>

                <div class=""widget widget_login"">
                    <h3 class=""widget_title"">Login</h3>
                    <div class=""form-style form-style-2"">
                        ");
            EndContext();
            BeginContext(3848, 1312, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9235e42b70c343db83348b1260cc67f4", async() => {
                BeginContext(3854, 1299, true);
                WriteLiteral(@"
                            <div class=""form-inputs clearfix"">
                                <p class=""login-text"">
                                    <input type=""text"" value=""Username"" onfocus=""if (this.value == 'Username') {this.value = '';}"" onblur=""if (this.value == '') {this.value = 'Username';}"">
                                    <i class=""icon-user""></i>
                                </p>
                                <p class=""login-password"">
                                    <input type=""password"" value=""Password"" onfocus=""if (this.value == 'Password') {this.value = '';}"" onblur=""if (this.value == '') {this.value = 'Password';}"">
                                    <i class=""icon-lock""></i>
                                    <a href=""#"">Forget</a>
                                </p>
                            </div>
                            <p class=""form-submit login-submit"">
                                <input type=""submit"" value=""Log in"" class=""button color smal");
                WriteLiteral(@"l login-submit submit"">
                            </p>
                            <div class=""rememberme"">
                                <label><input type=""checkbox"" checked=""checked""> Remember Me</label>
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5160, 1647, true);
            WriteLiteral(@"
                        <ul class=""login-links login-links-r"">
                            <li><a href=""#"">Register</a></li>
                        </ul>
                        <div class=""clearfix""></div>
                    </div>
                </div>

                <div class=""widget widget_highest_points"">
                    <h3 class=""widget_title"">Highest points</h3>
                    <ul>
                        <li>
                            <div class=""author-img"">
                                <a href=""#""><img width=""60"" height=""60"" src=""http://placehold.it/60x60/FFF/444"" alt=""""></a>
                            </div>
                            <h6><a href=""#"">user 1</a></h6>
                            <span class=""comment"">12 Points</span>
                        </li>
                        <li>
                            <div class=""author-img"">
                                <a href=""#""><img width=""60"" height=""60"" src=""http://placehold.it/60x60/FFF/444"" alt");
            WriteLiteral(@"=""""></a>
                            </div>
                            <h6><a href=""#"">user 2</a></h6>
                            <span class=""comment"">11 Points</span>
                        </li>
                    </ul>
                </div>

                <div class=""widget widget_tag_cloud"">
                    <h3 class=""widget_title"">Tags</h3>
                    <a href=""#"">Tag 1</a>
                    <a href=""#"">Tag 2</a>
                </div>

            </aside><!-- End sidebar -->


        </div><!-- End row -->
    </section><!-- End container -->

</div><!-- End main -->");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssistMeProject.Models.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
