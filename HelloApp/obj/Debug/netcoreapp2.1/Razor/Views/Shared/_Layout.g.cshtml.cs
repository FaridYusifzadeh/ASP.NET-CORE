#pragma checksum "C:\Users\Farid\source\repos\HelloApp\HelloApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a9c32662e52ee0907eb1d4d2f1b247f3574c5d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Farid\source\repos\HelloApp\HelloApp\Views\_ViewImports.cshtml"
using HelloApp.Models;

#line default
#line hidden
#line 2 "C:\Users\Farid\source\repos\HelloApp\HelloApp\Views\_ViewImports.cshtml"
using HelloApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a9c32662e52ee0907eb1d4d2f1b247f3574c5d2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f64528867fcbe0c69c9763bf806083ba02e1ee1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/scss/home.scss"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/scss/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/scss/home.css.map"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/first-page.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img//logo1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 796, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd1d4ea129c6476793dfeb4bf8034193", async() => {
                BeginContext(43, 532, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
    <script src=""https://kit.fontawesome.com/8ee7bee6cf.js""></script>
    <link rel=""stylesheet"" href=""https://unpkg.com/flickity@2/dist/flickity.min.css"">
    <link href=""https://fonts.googleapis.com/css?family=Roboto&display=swap"" rel=""stylesheet"">
    ");
                EndContext();
                BeginContext(575, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2bc49b9aeb4a450f870d9830f69fa6c8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(622, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(628, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e1eb645b3344f0285ae360ce22b8aa5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(674, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(680, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e035a4ac698441cbbf3521cb41b2091d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(730, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(736, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b1c302b320e64de495408492d47189f4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(787, 15, true);
                WriteLiteral("\r\n\r\n    <title>");
                EndContext();
                BeginContext(803, 13, false);
#line 17 "C:\Users\Farid\source\repos\HelloApp\HelloApp\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(816, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(837, 13934, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5bfb76030bf49dd9e4bdb188e8450ef", async() => {
                BeginContext(843, 404, true);
                WriteLiteral(@"
    <header>
        <section id=""polo-header"">
            <div id=""barbla"" class=""polo-head fixed-top"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <nav id=""nav_bar"" class=""navbar navbar-expand-lg"" style=""height: 70px;"">
                                <a class=""navbar-brand"" href=""#"">");
                EndContext();
                BeginContext(1247, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "32b0b61360374c21aafa82811db61036", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1275, 9044, true);
                WriteLiteral(@"</a>
                                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse""
                                        data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false""
                                        aria-label=""Toggle navigation"">
                                    <span class=""navbar-toggler-icon""></span>
                                </button>
                                <div class=""collapse navbar-collapse right-nav justify-content-end"" id=""navbarNav"">
                                    <ul class=""navbar-nav nav-pills"">
                                        <li class=""nav-item active"">
                                            <a class=""nav-link"" href=""#"">HOME <span class=""sr-only"">(current)</span></a>

                                        </li>
                                        <li class=""nav-item active dropdown"">
                                            <a class=""nav-link"" href=""#"">LAYOUT</a>
               ");
                WriteLiteral(@"                             <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Topbar</a>
                                                <a class=""dropdown-item"" href=""#"">Header</a>
                                                <a class=""dropdown-item"" href=""#"">Main Menu</a>
                                                <a class=""dropdown-item"" href=""#"">Page Title</a>
                                                <a class=""dropdown-item"" href=""#"">Page Menu</a>
                                                <a class=""dropdown-item"" href=""#"">Sidebars</a>
                                                <a class=""dropdown-item"" href=""#"">Footers</a>
                                                <a class=""dropdown-item"" href=""#"">Options</a>
                                                <a class=""dropdown-item"" href=""#"">Layout Demos</a>
                                            </div>
                                        </li>
 ");
                WriteLiteral(@"                                       <li class=""nav-item active dropdown"">
                                            <a class=""nav-link"" href=""#"">FEATURES</a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Sliders</a>
                                                <a class=""dropdown-item"" href=""#"">Widgets</a>
                                                <a class=""dropdown-item"" href=""#"">Page Loaders</a>
                                                <a class=""dropdown-item"" href=""#"">Modal Auto Open</a>
                                                <a class=""dropdown-item"" href=""#"">Cookie Notify</a>
                                                <a class=""dropdown-item"" href=""#"">Menu Labels</a>
                                            </div>
                                        </li>
                                        <li class=""nav-item active dropdown"">
               ");
                WriteLiteral(@"                             <a class=""nav-link"" href=""#"">ELEMENTS</a>
                                            <div class=""dropdown-menu"">

                                                <a class=""dropdown-item""
                                                   href=""../Front-End Layihe/accardion.html"">Accordions</a>
                                                <a class=""dropdown-item""
                                                   href=""../Front-End Layihe/button.html"">Buttons</a>
                                                <a class=""dropdown-item"" href=""../Front-End Layihe/dataTables.html"">
                                                    Data
                                                    Tables
                                                </a>
                                                <a class=""dropdown-item"" href=""../Front-End Layihe/dateTime.html"">
                                                    Date &
                                                   ");
                WriteLiteral(@" Time Pickers
                                                </a>
                                                <a class=""dropdown-item""
                                                   href=""../Front-End Layihe/image.html"">Images</a>
                                                <a class=""dropdown-item"" href=""../Front-End Layihe/form.html"">Forms</a>
                                            </div>
                                        </li>
                                        <li class=""nav-item active dropdown"">
                                            <a class=""nav-link"" href=""#"">PAGES</a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">About us</a>
                                                <a class=""dropdown-item"" href=""#"">About me</a>
                                                <a class=""dropdown-item"" href=""#"">Contact us</a>
                                  ");
                WriteLiteral(@"              <a class=""dropdown-item"" href=""#"">Gallery</a>
                                                <a class=""dropdown-item"" href=""#"">User pages</a>
                                                <a class=""dropdown-item"" href=""#"">Services</a>
                                            </div>
                                        </li>
                                        <li class=""nav-item active dropdown"">
                                            <a class=""nav-link"" href=""#"">PORTFOLIO</a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Grids</a>
                                                <a class=""dropdown-item"" href=""#"">Masonry</a>
                                                <a class=""dropdown-item"" href=""#"">Styles</a>
                                                <a class=""dropdown-item"" href=""#"">Layouts</a>
                                                <a cl");
                WriteLiteral(@"ass=""dropdown-item"" href=""#"">User pages</a>
                                                <a class=""dropdown-item"" href=""#"">Single Project</a>
                                            </div>
                                        </li>
                                        <li class=""nav-item active dropdown"">
                                            <a class=""nav-link"" href=""#"">BLOG</a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Grids</a>
                                                <a class=""dropdown-item"" href=""#"">Masonry</a>
                                                <a class=""dropdown-item"" href=""#"">Styles</a>
                                                <a class=""dropdown-item"" href=""#"">Layouts</a>
                                                <a class=""dropdown-item"" href=""#"">User pages</a>
                                                <a class=""dropdown-i");
                WriteLiteral(@"tem"" href=""#"">Single Project</a>
                                            </div>
                                        </li>
                                        <li class=""nav-item active dropdown"">
                                            <a class=""nav-link"" href=""#"">SHOP</a>
                                            <div class=""dropdown-menu"">
                                                <a class=""dropdown-item"" href=""#"">Columns</a>
                                                <a class=""dropdown-item"" href=""#"">Layouts</a>
                                                <a class=""dropdown-item"" href=""#"">Order Process</a>
                                                <a class=""dropdown-item"" href=""#"">Single Product</a>
                                            </div>
                                        </li>
                                    </ul>
                                    <div class=""icon-head"" style=""font-size:13px;"">
                                    ");
                WriteLiteral(@"    <div class=""icon-search"">
                                            <i class=""fas fa-search""></i>
                                        </div>
                                        <div class=""icon-shop"">
                                            <i class=""fas fa-shopping-cart""><sup>8</sup></i>

                                        </div>
                                        <div class=""icon-flag"">
                                            <i class=""far fa-flag""></i>
                                        </div>
                                    </div>
                                </div>
                            </nav>
                        </div>

                    </div>





                </div>

            </div>

            </div>

        </section>
    </header>

    ");
                EndContext();
                BeginContext(10320, 12, false);
#line 160 "C:\Users\Farid\source\repos\HelloApp\HelloApp\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(10332, 4394, true);
                WriteLiteral(@"
     

    <footer>
        <section id=""polo-foot"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-4"">
                        <div class=""left-foot"">
                            <h4>POLO HTML5 TEMPLATE</h4>
                            <p>
                                Built with love in Fort Worth, Texas, USA<br>
                                All rights reserved. Copyright © 2019. INSPIRO.
                            </p>
                            <button class=""btn btn-primary but"">PURCHASE NOW</button>
                        </div>

                    </div>
                    <div class=""col-8"">
                        <div class=""right-foot"">
                            <div class=""row"">
                                <div class=""col-3"">
                                    <div class=""item"">
                                        <h4>DISCOVER</h4>
                                        <ul>
                 ");
                WriteLiteral(@"                           <li><a href=""#"">Features</a></li>
                                            <li><a href=""#"">Layouts</a></li>
                                            <li><a href=""#"">Corporate</a></li>
                                            <li><a href=""#"">Updates</a></li>
                                            <li><a href=""#"">Pricing</a></li>
                                            <li><a href=""#"">Customers</a></li>
                                        </ul>
                                    </div>

                                </div>
                                <div class=""col-3"">
                                    <div class=""item"">
                                        <h4>FEATURES</h4>
                                        <ul>
                                            <li><a href=""#"">Layouts</a></li>
                                            <li><a href=""#"">Headers</a></li>
                                            <li><a href=""#"">Widge");
                WriteLiteral(@"ts</a></li>
                                            <li><a href=""#"">Footers</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""item"">
                                        <h4>PAGES</h4>
                                        <ul>
                                            <li><a href=""#"">Portfolio</a></li>
                                            <li><a href=""#"">Blog</a></li>
                                            <li><a href=""#"">Shop</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""item"">
                                        <h4>SUPPORT</h4>
                                        <ul>
                 ");
                WriteLiteral(@"                           <li><a href=""#"">Help Desk</a></li>
                                            <li><a href=""#"">Documentation</a></li>
                                            <li><a href=""#"">Contact Us</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </section>
        <div class=""row"">
            <div class=""under col-12"">
                <p>© 2019 POLO - Responsive Multi-Purpose HTML5 Template. All Rights Reserved. INSPIRO</p><span class=""angle-class""><i class=""fa fa-angle-up angle""></i> </span>
            </div>
        </div>

    </footer>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
    <");
                WriteLiteral(@"script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/flickity/2.2.0/flickity.pkgd.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/gsap/2.1.3/TweenMax.min.js""></script>
    ");
                EndContext();
                BeginContext(14726, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7a1ea6888934e2ab4e768550a9ae6da", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14762, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14771, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
