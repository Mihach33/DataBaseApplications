#pragma checksum "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283e9c05b3b1995a41c4889b44016306e2952883"
// <auto-generated/>
#pragma warning disable 1591
namespace APBD11.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using APBD11.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using APBD11.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using APBD11.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editstudent/{Id:int}")]
    public partial class EditStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"mb-4 mt-5\">Student\'s Details</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "mr-5");
            __builder.OpenElement(5, "form");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mb-3 d-flex justify-content-end align-items-center");
            __builder.AddMarkupContent(8, "<label for=\"first-name\" class=\"form-label text-end me-3\" style=\"white-space: nowrap; min-width: 100px\">First name:</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "first-name");
            __builder.AddAttribute(13, "value", 
#nullable restore
#line 39 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                                                                student.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "readonly");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "mb-3 d-flex justify-content-end align-items-center");
            __builder.AddMarkupContent(18, "<label for=\"last-name\" class=\"form-label text-end me-3\" style=\"white-space: nowrap; min-width: 100px\">Last name:</label>\r\n                ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "id", "last-name");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 43 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                                                               student.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "readonly");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "mb-3 d-flex justify-content-end align-items-center");
            __builder.AddMarkupContent(28, "<label for=\"birth-date\" class=\"form-label text-end me-3\" style=\"white-space: nowrap; min-width: 100px\">Birth Date:</label>\r\n                ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "id", "birth-date");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 47 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                                                                student.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "readonly");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "mb-3 d-flex justify-content-end align-items-center");
            __builder.AddMarkupContent(38, "<label for=\"studies\" class=\"form-label text-end me-3\" style=\"white-space: nowrap; min-width: 100px\">Studies:</label>\r\n                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "id", "studies");
            __builder.AddAttribute(43, "value", 
#nullable restore
#line 51 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                                                             student.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "readonly");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-primary mt-3 ms-2");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                                              ()=>GoToStudents()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Return");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "d-flex flex-column");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "mb-3 d-flex justify-content-end align-items-center");
            __builder.AddMarkupContent(55, "<label for=\"avatar\" class=\"form-label text-end me-3\" style=\"white-space: nowrap; min-width: 100px\">Avatar:</label>\r\n            ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "text");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "id", "avatar");
            __builder.AddAttribute(60, "value", 
#nullable restore
#line 59 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                                                        student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(61, "readonly");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "img");
            __builder.AddAttribute(64, "class", "align-self-center");
            __builder.AddAttribute(65, "src", 
#nullable restore
#line 61 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
                                             student.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "alt", "Avatar");
            __builder.AddAttribute(67, "width", "100");
            __builder.AddAttribute(68, "height", "100");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\EditStudent.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Student student = new Student();

    protected override async Task OnInitializedAsync()
    {
        var httpClient = new HttpClient();
        var result = await httpClient.GetAsync("https://localhost:44356/api/students/" + Id);
        var data = await result.Content.ReadAsStringAsync();
        Console.WriteLine(data);

        student = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(data);
    }

    private void GoToStudents()
    {
        NavManager.NavigateTo("/students");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
