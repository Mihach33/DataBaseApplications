#pragma checksum "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f769f5a01468ccc619f22a8ad49c0c1bf10422"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class StudentsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Students</h3>\r\n<div height=\"50\"></div>");
#nullable restore
#line 7 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
 if (Students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<img src=\"https://media0.giphy.com/media/3oEjI6SIIHBdRxXI40/200.gif\" alt=\"Loading\">");
#nullable restore
#line 10 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
}
else if (Students.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<span>There are no students</span>");
#nullable restore
#line 14 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.OpenElement(5, "thead");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th style=\"border:2px solid #000\">Avatar</th>\r\n                ");
            __builder.OpenElement(8, "th");
            __builder.AddAttribute(9, "style", "border:2px solid #000");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                              ()=>Sort(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "First Name");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "style", "border:2px solid #000");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                              ()=>Sort(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Last Name");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "th");
            __builder.AddAttribute(19, "style", "border:2px solid #000");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                              ()=>Sort(3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Birth Date");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "th");
            __builder.AddAttribute(24, "style", "border:2px solid #000");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                              ()=>Sort(4)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Studies");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                <th style=\"border:0px solid #fff\"></th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "tbody");
#nullable restore
#line 29 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
             foreach (var s in Students)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "tr");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "style", "border:2px solid #000");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                                  ()=>SeeStudent(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(34, "img");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 33 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                   s.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "width", "90");
            __builder.AddAttribute(37, "height", "90");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "style", "border:2px solid #000");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                                  ()=>SeeStudent(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, 
#nullable restore
#line 36 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                         s.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "style", "border:2px solid #000");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                                  ()=>SeeStudent(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, 
#nullable restore
#line 39 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                         s.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "style", "border:2px solid #000");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                                  ()=>SeeStudent(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, 
#nullable restore
#line 42 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                         s.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "style", "border:2px solid #000");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                                  ()=>SeeStudent(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, 
#nullable restore
#line 45 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                         s.Studies

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "style", "border:0px solid #fff");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn-danger");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
                                                               ()=>DeleteStudents(s)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Mihach\Desktop\APBD11\APBD11\Client\Pages\StudentsList.razor"
       
    public List<Student> Students { get; set; }

    public Student student = new Student();

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(2000);

        var httpClient = new HttpClient();
        var result = await httpClient.GetAsync("https://localhost:44356/api/students");
        var data = await result.Content.ReadAsStringAsync();
        Console.WriteLine(data);

        Students = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(data);
        Students.Sort((x, y) => x.LastName.CompareTo(y.LastName));
    }

    private void SeeStudent(Student stud)
    {
        student = stud;
        NavManager.NavigateTo("/editstudent/" + stud.IdStudent); 
    }


    private async Task DeleteStudents(Student student)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the student '{student.FirstName} {student.LastName}'?"))
        {
            return;
        }

        Students.Remove(student);
    }

    private async Task Sort(int sortWay)
    {
        switch (sortWay)
        {
            case 1:
                if (Students.SequenceEqual(Students.OrderByDescending(x => x.FirstName)))
                {
                    Students.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
                }
                else
                {
                    Students.Sort((x, y) => y.FirstName.CompareTo(x.FirstName));
                }

                break;

            case 2:
                if (Students.SequenceEqual(Students.OrderByDescending(x => x.LastName)))
                {
                    Students.Sort((x, y) => x.LastName.CompareTo(y.LastName));
                }
                else
                {
                    Students.Sort((x, y) => y.LastName.CompareTo(x.LastName));
                }

                break;

            case 3:
                if (Students.SequenceEqual(Students.OrderByDescending(x => x.BirthDate)))
                {
                    Students.Sort((x, y) => x.BirthDate.CompareTo(y.BirthDate));
                }
                else
                {
                    Students.Sort((x, y) => y.BirthDate.CompareTo(x.BirthDate));
                }

                break;

            case 4:
                if (Students.SequenceEqual(Students.OrderByDescending(x => x.Studies)))
                {
                    Students.Sort((x, y) => x.Studies.CompareTo(y.Studies));
                }
                else
                {
                    Students.Sort((x, y) => y.Studies.CompareTo(x.Studies));
                }

                break;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
