#pragma checksum "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f6e70064000b7ba58e12f9d090f71971d771c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__ListProduct), @"mvc.1.0.view", @"/Views/Product/_ListProduct.cshtml")]
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
#line 1 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\_ViewImports.cshtml"
using Ajax_Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\_ViewImports.cshtml"
using Ajax_Crud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f6e70064000b7ba58e12f9d090f71971d771c8b", @"/Views/Product/_ListProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b91223e53cb89f5bdd2a6f3845b5d9e8690375", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__ListProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ajax_Crud.Models.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
  
    int page = ViewBag.page;
    int totalPage = ViewBag.totalPage;
    int dem = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            WriteLiteral(@"    <div class=""row"">
        <table id=""table"" class=""table table-striped"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Name</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Status</th>
                    <th>Created Date</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                  
                    int stt = 1;
                    foreach (var m in Model)
                    {
                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 31 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                   Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\'Name\'>");
#nullable restore
#line 32 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"Price\">");
#nullable restore
#line 33 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                 Write(m.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"Quantity\">");
#nullable restore
#line 34 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                    Write(m.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                     if (m.Status == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"Status\">Active</td>\r\n");
#nullable restore
#line 38 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                    }
                                    else if (m.Status == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"Status\">Block</td>\r\n");
#nullable restore
#line 42 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                    }
                                    else if (m.Status == -1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"Status\">Delete</td>\r\n");
#nullable restore
#line 46 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td class=\"Createdate\">");
#nullable restore
#line 47 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                      Write(m.Createdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"Id\" hidden=\"hidden\">");
#nullable restore
#line 48 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                              Write(m.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                    <td>\r\n");
#nullable restore
#line 51 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                         switch (m.Status)
                                        {
                                            case 1:
                                                // Active

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <button id=""detail"" class=""btn btn-outline-info"">Detail</button>
                                                <button id=""update"" class=""btn btn-outline-success"" data-toggle=""modal"" data-target=""#form"">Update</button>
                                                <button class=""btn btn-outline-secondary""");
            BeginWriteAttribute("onclick", " onclick=\"", 2485, "\"", 2514, 3);
            WriteAttributeValue("", 2495, "ActiveStatus(", 2495, 13, true);
#nullable restore
#line 57 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue("", 2508, m.Id, 2508, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2513, ")", 2513, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Block</button>\r\n                                                <button class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2618, "\"", 2648, 3);
            WriteAttributeValue("", 2628, "ActiveStatus(-", 2628, 14, true);
#nullable restore
#line 58 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue("", 2642, m.Id, 2642, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2647, ")", 2647, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n");
#nullable restore
#line 59 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                break;
                                            case 0:
                                                // Unblock

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button id=\"update\" class=\"btn btn-outline-success\" data-toggle=\"modal\" data-target=\"#form\">Update</button>\r\n                                                <button class=\"btn btn-outline-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3082, "\"", 3111, 3);
            WriteAttributeValue("", 3092, "ActiveStatus(", 3092, 13, true);
#nullable restore
#line 63 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue("", 3105, m.Id, 3105, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3110, ")", 3110, 1, true);
            EndWriteAttribute();
            WriteLiteral(">UnBlock</button>");
#nullable restore
#line 63 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                                                                                                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button class=\"btn btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3218, "\"", 3248, 3);
            WriteAttributeValue("", 3228, "ActiveStatus(-", 3228, 14, true);
#nullable restore
#line 64 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue("", 3242, m.Id, 3242, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3247, ")", 3247, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n");
#nullable restore
#line 65 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                break;
                                            default:
                                                // Delete
                                                break;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                        stt++;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-2\">\r\n            <lable><b>Page ");
#nullable restore
#line 82 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                       Write(page);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 82 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                  Write(totalPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></lable>\r\n        </div>\r\n        <div class=\"col-5\">\r\n            <ul class=\"pagination justify-content-right\">\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 4035, "\"", 4084, 2);
            WriteAttributeValue("", 4043, "page-item", 4043, 9, true);
#nullable restore
#line 86 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue(" ", 4052, page == 1 ? "disabled" : "" , 4053, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\" data-dt-idx=\"1\" tabindex=\"-1\">First</a>\r\n                </li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 4212, "\"", 4262, 2);
            WriteAttributeValue("", 4220, "page-item", 4220, 9, true);
#nullable restore
#line 89 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue("  ", 4229, page == 1 ? "disabled" : "" , 4231, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\" data-dt-idx=\"");
#nullable restore
#line 90 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                  Write(page-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"-1\">Previous</a>\r\n                </li>\r\n");
#nullable restore
#line 92 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                 for (int i = page - 2; i <= totalPage; i++)
                {
                    if (i > 0 && dem < 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 4556, "\"", 4602, 2);
            WriteAttributeValue("", 4564, "page-item", 4564, 9, true);
#nullable restore
#line 96 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue(" ", 4573, page == i ? "active" : "", 4574, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\" data-dt-idx=\"");
#nullable restore
#line 96 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 96 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 97 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                        dem++;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 4748, "\"", 4805, 2);
            WriteAttributeValue("", 4756, "page-item", 4756, 9, true);
#nullable restore
#line 100 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue(" ", 4765, page == totalPage ? "disabled" : "" , 4766, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\" data-dt-idx=\"");
#nullable restore
#line 101 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                  Write(page+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"-1\">Next</a>\r\n                </li>\r\n                <li");
            BeginWriteAttribute("class", " class=\"", 4940, "\"", 4997, 2);
            WriteAttributeValue("", 4948, "page-item", 4948, 9, true);
#nullable restore
#line 103 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue(" ", 4957, page == totalPage ? "disabled" : "" , 4958, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a class=\"page-link\" data-dt-idx=\"");
#nullable restore
#line 104 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
                                                 Write(totalPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" tabindex=\"-1\">Last</a>\r\n                </li>\r\n                \r\n            </ul>\r\n        </div>\r\n        <div class=\"col-3\"></div>\r\n        <input");
            BeginWriteAttribute("value", " value=\"", 5216, "\"", 5234, 1);
#nullable restore
#line 110 "C:\Users\tan\source\repos\ajax_crud\Ajax_Crud\Views\Product\_ListProduct.cshtml"
WriteAttributeValue("", 5224, totalPage, 5224, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""totalPage"" hidden />
    </div>
</div>

<script>
    $("".page-link"").click(function () {
        _page = $(this).attr(""data-dt-idx"");
        ListPro(_page);
    })

    $(""#table"").on('click', '#detail', function () {
        var Name = $("".Name"").html();
        var Price = $("".Price"").html();
        var Quantity = $("".Quantity"").html();
        var Createdate = $("".Createdate"").html();
        swal({
            title: "" -- Detai Product -- "",
            text: ""Name Product : "" + Name + ""\n"" + ""Price Product : "" + Price + ""\n"" + ""Quantity Product : "" + Quantity + ""\n"" + ""Create Date : "" + Createdate,
            buttonsStyling: true,
        })

    });

    $(""#table"").on('click', '#update', function () {
        $(""#exampleModalLabel"").html(""<h2> -- Update Product -- </h2>"");
        $(""#validate_name"").html("""");
        var Name = $("".Name"").html();
        var Price = $("".Price"").html();
        var Quantity = $("".Quantity"").html();
        var Id = $("".Id"").html();");
            WriteLiteral(@"

        // gán giá trị của td vào modal
        $(""#Name"").val(Name);
        $(""#Price"").val(Price);
        $(""#Quantity"").val(Quantity);
        _id = Id;
    });

    function ActiveStatus(Id) {
        var status = $("".Status"").html();
        var titleMessage;
        switch (status)
        {
            case 1:
                titleMessage = ""Are you sure Block?"";
                break;
            case 0:
                titleMessage = ""Are you sure Unblock?"";
                break;
            case -1:
                titleMessage = ""Are you sure Delete?"";
                break;
            default:
                break;
        }
        swal({
            title: titleMessage,
            text: ""You will not be able to recover this imaginary file!"",
            icon: ""warning"",
            buttons: [
                'No, cancel it!',
                'Yes, I am sure!'
            ],
            dangerMode: true,
        }).then(function (isConfirm) {
           ");
            WriteLiteral(@" if (isConfirm) {
                $.ajax({
                    url: ""/Product/ActiveStatus/"" + Id,
                    type: ""POST"",
                    dataType: 'json',
                    success: ((data) => {
                        //alert(data.status);
                        if (status == 1) {
                            if (Id > 0) {
                                swal(""Block Product Success"", ""You clicked the button!"", ""success"");
                            } else {
                                swal(""Delete Product Success"", ""You clicked the button!"", ""success"");
                            }  
                        }
                        else{
                            swal(""UnBlock Product Success"", ""You clicked the button!"", ""success"");
                        }
                        ListPro(1);
                    })
                });
            } else {
                swal(""Cancelled"", ""Your imaginary file is safe :)"", ""error"");
            }
        })
");
            WriteLiteral("    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ajax_Crud.Models.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
