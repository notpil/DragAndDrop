#pragma checksum "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e1c5dda13182e647a49624d61c050be769690d7"
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
#line 1 "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\_ViewImports.cshtml"
using DragAndDropTraning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\_ViewImports.cshtml"
using DragAndDropTraning.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e1c5dda13182e647a49624d61c050be769690d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16e6cc174738dfd7cf33da7612728a9f6c3f49f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\Home\Index.cshtml"
  
	//ViewData["Title"] = "Home Page"
	ViewBag.Tile = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<div class=\"text-center justify-content-center\">\r\n\t\t<h2>Drag & Drop file upload </h2>\r\n\r\n\t\t<div class=\"row\">\r\n");
#nullable restore
#line 10 "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\Home\Index.cshtml"
             using (Html.BeginForm("UploadFile", "Home",
							 FormMethod.Post,
							 new
							 {
								 @class = "dropzone",
								 id = "dropzone-form",
							 }))
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"fallback\">\r\n\t\t\t\t\t<input name=\"file\" type=\"file\" multiple />\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 21 "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\Home\Index.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t\t<p>");
#nullable restore
#line 24 "E:\Project\DragAndDropTraning\DragAndDropTraning\Views\Home\Index.cshtml"
      Write(ViewData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t\t\t<script type=\"text/javascript\">\r\n\t\t\t\tDropzone.options.dropzoneForm = {\r\n\t\t\t\t\tparamName: \"file\",\r\n\t\t\t\t\tmaxFilesize: 65535,\r\n\t\t\t\t\ttimeout: 600000,\r\n\t\t\t\t\tmaxFiles: 1,\r\n\t\t\t\t\tdictMaxFilesExceeded: \"Custom max files msg\",\r\n\t\t\t\t};\r\n\t\t\t</script>\r\n\t\t");
            }
            );
            WriteLiteral("\t</div>\r\n");
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