#pragma checksum "C:\Users\SaravanaPriyaSelvaKu\Desktop\angular\samples\New folder\angular-pdf-viewer-examples\Common\Web Service\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa821ffc7b74f2027e21b3d53b4ba15ca3148261"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SaravanaPriyaSelvaKu\Desktop\angular\samples\New folder\angular-pdf-viewer-examples\Common\Web Service\Views\_ViewImports.cshtml"
using PdfViewerLatestDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SaravanaPriyaSelvaKu\Desktop\angular\samples\New folder\angular-pdf-viewer-examples\Common\Web Service\Views\_ViewImports.cshtml"
using PdfViewerLatestDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa821ffc7b74f2027e21b3d53b4ba15ca3148261", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"789436e973db4f8652accad91d04512fa9ab5946", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SaravanaPriyaSelvaKu\Desktop\angular\samples\New folder\angular-pdf-viewer-examples\Common\Web Service\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""width:100%;height:600px"">
    <button id=""load1"">Load</button>
    <ejs-pdfviewer id=""pdfViewer"" style=""height:600px"" serviceUrl=""https://localhost:44327/pdfviewer"" documentPath=""HTTP Succinctly.pdf"">
    </ejs-pdfviewer>
</div>

<script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"" type=""text/javascript""></script>
  <input type=""submit"" value=""Generate PDF"" class=""Button"" id=""btn1"" />
  <script type=""text/javascript"">
    $(""load1"").click(function () {
      $.ajax({
        url: 'https://localhost:44327/pdfviewer/GetPdfStream',
        type: ""GET"",
        success: function (data) {
          viewer = document.getElementById('pdfViewer').ej2_instances[0];
          viewer.documentPath = data;
        }
      });
    });
  </script>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
