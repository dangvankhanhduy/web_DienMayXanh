#pragma checksum "C:\Users\minhh\IT\DoAnKhoaLuan\QL_DienMayXanh\QL_DienMayXanh\QL_DienMayXanh\Views\Customer\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6673091a6c85ec39e561d47a771b5e3cd2e5de9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Product), @"mvc.1.0.view", @"/Views/Customer/Product.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6673091a6c85ec39e561d47a771b5e3cd2e5de9a", @"/Views/Customer/Product.cshtml")]
    public class Views_Customer_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\minhh\IT\DoAnKhoaLuan\QL_DienMayXanh\QL_DienMayXanh\QL_DienMayXanh\Views\Customer\Product.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container pt-5\">\r\n    <div class=\"row d-block\">\r\n        <div class=\"row mb-4\">\r\n            <div class=\"col\" style=\"border-bottom: 2px solid #ffec00;\">\r\n                <h4>Sản Phẩm</h4>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\minhh\IT\DoAnKhoaLuan\QL_DienMayXanh\QL_DienMayXanh\QL_DienMayXanh\Views\Customer\Product.cshtml"
         for (int j = 1; j <= 6; j++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mb-5 d-flex flex-nowrap \" style=\"gap:10px; margin-bottom:6px; height:290px\">\r\n\r\n");
#nullable restore
#line 17 "C:\Users\minhh\IT\DoAnKhoaLuan\QL_DienMayXanh\QL_DienMayXanh\QL_DienMayXanh\Views\Customer\Product.cshtml"
                 for (int i = 0; i <= 5; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<a class=""product-hover"" href=""#"">
                        <div class=""col  list-product"" style=""padding: 10px"">

                            <div class=""row list-product-img"">
                                <div>
                                    <img class=""img-product"" style=""width:166px"" src=""	https://cdn.tgdd.vn/Products/Images/42/289663/iPhone-14-plus-thumb-den-600x600.jpg"" />
                                </div>
                            </div>
                            <div class=""row"" style=""padding:0 0 0 15px"">
                                <span style=""font-size:14px; font-weight:500"">IPhone 14 Pro-max</span>
                            </div>
                            <div class=""row"">
                                <div class=""col-8"">

                                    <span style=""font-size:16px; font-weight:700"">32.000.000đ</span>
                                </div>
                                <div class=""col-4"">
                                    <div t");
            WriteLiteral(@"ype=""button"" class=""btn btn-primary"" style=""font-size:8px"">
                                        <i class=""fa-solid fa-cart-shopping""></i>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"" style=""justify-content:center"">
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                    <span class=""fa fa-star checked""></span>
                                </div>
                            </div>

                        </div>
                    </a>");
#nullable restore
#line 51 "C:\Users\minhh\IT\DoAnKhoaLuan\QL_DienMayXanh\QL_DienMayXanh\QL_DienMayXanh\Views\Customer\Product.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>");
#nullable restore
#line 52 "C:\Users\minhh\IT\DoAnKhoaLuan\QL_DienMayXanh\QL_DienMayXanh\QL_DienMayXanh\Views\Customer\Product.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
