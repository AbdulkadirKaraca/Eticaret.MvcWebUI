#pragma checksum "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8a48982162b900bd8235ad21fc29e59291e610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UrunEkle), @"mvc.1.0.view", @"/Views/Admin/UrunEkle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UrunEkle.cshtml", typeof(AspNetCore.Views_Admin_UrunEkle))]
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
#line 1 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\_ViewImports.cshtml"
using Eticaret.MvcWebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8a48982162b900bd8235ad21fc29e59291e610", @"/Views/Admin/UrunEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d45445bea0cfad2b567a0215a18203ae1abf6f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UrunEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eticaret.MvcWebUI.Models.Urunler>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/UrunEkle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal tasi-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
  
    ViewData["Title"] = "Ürün Ekle";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(151, 255, true);
            WriteLiteral("\r\n    \r\n    \r\n\r\n\r\n    \r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <section class=\"panel\">\r\n            <header class=\"panel-heading\">\r\n                Ürün Ekle\r\n            </header>\r\n            <div class=\"panel-body\">\r\n                ");
            EndContext();
            BeginContext(406, 5164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7a9680235442648beed66a4377d45d", async() => {
                BeginContext(498, 287, true);
                WriteLiteral(@"


                    <div class=""form-group has-warning"">
                        <label class=""col-lg-2 control-label""> Kategori Seçiniz</label>
                        <div class=""col-lg-10"">
                            <select class=""form-control m-bot15"" name=""KategoriId"">
");
                EndContext();
#line 27 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                 foreach (var kategori in ViewBag.Kategoriler)
                                {

#line default
#line hidden
                BeginContext(900, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(936, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db1cfe7fcf3b476cb8b7abcb3607e68e", async() => {
                    BeginContext(974, 20, false);
#line 29 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                                                    Write(kategori.KategoriTür);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                       WriteLiteral(kategori.KategoriId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1003, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                }

#line default
#line hidden
                BeginContext(1040, 374, true);
                WriteLiteral(@"                            </select>
                        </div>
                    </div>
                    <div class=""form-group has-warning"">
                        <label class=""col-lg-2 control-label""> Marka Seçiniz</label>
                        <div class=""col-lg-10"">
                            <select class=""form-control m-bot15"" name=""MarkaId"">
");
                EndContext();
#line 38 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                 foreach (var marka in ViewBag.Markalar)
                                {


#line default
#line hidden
                BeginContext(1525, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1561, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41691af138f2473198f52cee84f5ea49", async() => {
                    BeginContext(1593, 14, false);
#line 41 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                                              Write(marka.MarkaAdi);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                       WriteLiteral(marka.MarkaId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1616, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "C:\Users\Kadir\Documents\Visual Studio 2017\Projects\Eticaret\Eticaret.MvcWebUI\Views\Admin\UrunEkle.cshtml"
                                }

#line default
#line hidden
                BeginContext(1653, 3910, true);
                WriteLiteral(@"                            </select>
                        </div>
                    </div>

                    <div class=""form-group has-success"">
                        <label class=""col-lg-2 control-label"">Ürün Adı</label>
                        <div class=""col-lg-10"">
                            <input type=""text"" placeholder="""" id=""f-name"" class=""form-control"" name=""UrunAdi"">
                            <p class=""help-block"">Successfully done</p>
                        </div>
                    </div>

                    <div class=""form-group has-error"">
                        <label class=""col-lg-2 control-label"">Açıklama</label>
                        <div class=""col-lg-10"">
                            <input type=""text"" placeholder="""" id=""l-name"" class=""form-control"" name=""Acıklama"">
                            <p class=""help-block"">Aha you gave a wrong info</p>
                        </div>
                    </div>

                    <div class=""form-group has-w");
                WriteLiteral(@"arning"">
                        <label class=""col-lg-2 control-label"">Alış Fiyatı</label>
                        <div class=""col-lg-10"">
                            <input type=""text"" class=""spinner-input form-control"" name=""AlisFiyat"">
                            <p class=""help-block"">Something went wrong</p>
                        </div>
                    </div>

                    <div class=""form-group has-warning"">
                        <label class=""col-lg-2 control-label"">Satiş Fiyatı</label>
                        <div class=""col-lg-10"">
                            <input type=""text"" class=""spinner-input form-control"" name=""SatisFiyat"">
                            <p class=""help-block"">Something went wrong</p>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""control-label col-md-3"">Eklenme Tarihi</label>
                        <div class=""col-md-3 col-xs-11"">
                      ");
                WriteLiteral(@"      <div data-date-viewmode=""years"" data-date-format=""dd-mm-yyyy"" data-date=""19-12-2018"" class=""input-append date dpYears"">
                                <input type=""text"" name=""EklenmeTarihi"" readonly="""" value=""19-12-2018"" size=""16"" class=""form-control"">
                                <span class=""input-group-btn add-on"">
                                    <button class=""btn btn-danger"" type=""button""><i class=""icon-calendar""></i></button>
                                </span>
                            </div>
                            <span class=""help-block""> Tarihi Seçiniz</span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label col-md-3"">Son Kullanma Tarihi</label>
                        <div class=""col-md-3 col-xs-11"">
                            <div data-date-viewmode=""years"" data-date-format=""dd-mm-yyyy"" data-date=""19-12-2018"" class=""input-append date dpYears"">
           ");
                WriteLiteral(@"                     <input type=""text"" name=""SonKullanmaTarihi"" readonly="""" value=""19-12-2018"" size=""16"" class=""form-control"">
                                <span class=""input-group-btn add-on"">
                                    <button class=""btn btn-danger"" type=""button""><i class=""icon-calendar""></i></button>
                                </span>
                            </div>
                            <span class=""help-block""> Tarihi Seçiniz</span>
                        </div>
                    </div>

                    

                    <div class=""form-group"">
                        <div class=""col-lg-offset-2 col-lg-10"">
                            <button class=""btn btn-danger"" type=""submit"">Kaydet</button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5570, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eticaret.MvcWebUI.Models.Urunler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
