#pragma checksum "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a9045e219779f2b9b4b8ab7b5665b8ef9c39de0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Show), @"mvc.1.0.view", @"/Views/Employee/Show.cshtml")]
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
#line 1 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\_ViewImports.cshtml"
using TL2_TP2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\_ViewImports.cshtml"
using TL2_TP2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a9045e219779f2b9b4b8ab7b5665b8ef9c39de0", @"/Views/Employee/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c47f91552b0860df94dbeef986aa5abcad9f45", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TL2_TP2.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml"
  
    ViewData["Title"] = "Show Employee";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead class=""thead-dark"">
        <tr>
            <td>LastName</td>
            <td>Name</td>
            <td>Age</td>
            <td>Antiquity</td>
            <td>Salary</td>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 21 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml"
           Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml"
           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml"
           Write(Model.Antiquity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\jivit\Desktop\Mis Cosas\Facultad\Licenciatura En Informatica\2do Anio\Taller de Lenguajes 2\Practica\TP2-Vitian\TL2-TP2\TL2-TP2\Views\Employee\Show.cshtml"
           Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n    <tr>\r\n        <td></td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TL2_TP2.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591