#pragma checksum "C:\Users\Sinan\source\repos\CoreWeb\CoreWeb\Views\Shared\PartialLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "013d1d646d395af540c7df70a2e402ea263f008d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialLogin), @"mvc.1.0.view", @"/Views/Shared/PartialLogin.cshtml")]
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
#line 1 "C:\Users\Sinan\source\repos\CoreWeb\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sinan\source\repos\CoreWeb\CoreWeb\Views\_ViewImports.cshtml"
using CoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"013d1d646d395af540c7df70a2e402ea263f008d", @"/Views/Shared/PartialLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ccaa0bb7c2237ad0e2193309f82bddc35d0c1ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<a href=""#"" data-toggle=""modal"" data-target=""#login"" class=""mr-2 text-dark bg-light rounded-pill p-2 icofont-size border shadow-sm"">
               <i class=""icofont-login""></i>
               </a>
               <!-- notification -->
               <div class=""dropdown"">
                  <a href=""#"" class=""text-dark dropdown-toggle not-drop"" id=""dropdownMenuNotification"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                     <i class=""icofont-notification d-flex align-items-center bg-light rounded-pill p-2 icofont-size border shadow-sm"">
                        <!-- <p class=""mt-n2 mb-0 font-weight-bold text-success"">2</p> -->
                     </i>
                  </a>
                  <div class=""dropdown-menu dropdown-menu-right p-0 osahan-notifications-main"" aria-labelledby=""dropdownMenuNotification"">
                     <!-- notification 1 -->
                     <div class=""osahan-notifications bg-white border-bottom p-2"">
                        <");
            WriteLiteral(@"div class=""position-absolute ml-n1 py-2""><i class=""icofont-check-circled text-white bg-success rounded-pill p-1""></i></div>
                        <a href=""status_complete.html"" class=""text-decoration-none text-dark"">
                           <div class=""notifiction small"">
                              <div class=""ml-3"">
                                 <p class=""font-weight-bold mb-1"">Yay! Order Complete</p>
                                 <p class=""small m-0""><i class=""icofont-ui-calendar""></i> Today, 05:14 AM</p>
                              </div>
                           </div>
                        </a>
                     </div>
                     <!-- notification 2 -->
                     <div class=""osahan-notifications bg-white border-bottom p-2"">
                        <a href=""status_onprocess.html"" class=""text-decoration-none text-muted"">
                           <div class=""notifiction small"">
                              <div class=""ml-3"">
                     ");
            WriteLiteral(@"            <p class=""font-weight-bold mb-1"">Yipiee. order Success</p>
                                 <p class=""small m-0""><i class=""icofont-ui-calendar""></i> Monday, 08:30 PM</p>
                              </div>
                           </div>
                        </a>
                     </div>
                     <!-- notification 3 -->
                     <div class=""osahan-notifications bg-white p-2"">
                        <a href=""status_onprocess.html"" class=""text-decoration-none text-muted"">
                           <div class=""notifiction small"">
                              <div class=""ml-3"">
                                 <p class=""font-weight-bold mb-1"">New Promos Coming</p>
                                 <p class=""small m-0""><i class=""icofont-ui-calendar""></i> Sunday, 10:30 AM</p>
                              </div>
                           </div>
                        </a>
                     </div>
                  </div>
               </div>");
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
