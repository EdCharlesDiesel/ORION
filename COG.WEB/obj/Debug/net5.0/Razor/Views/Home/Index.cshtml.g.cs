#pragma checksum "C:\Khotso\Projects\SABBG.WEB\_00_SABBG.WEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777ac8b173d58accefdc3eac6147870f43b1f8ec"
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
#line 1 "C:\Khotso\Projects\SABBG.WEB\_00_SABBG.WEB\Views\_ViewImports.cshtml"
using SABBG.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Khotso\Projects\SABBG.WEB\_00_SABBG.WEB\Views\_ViewImports.cshtml"
using SABBG.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777ac8b173d58accefdc3eac6147870f43b1f8ec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e9d9edeab7d65544986a08f3d0127769f60c74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Khotso\Projects\SABBG.WEB\_00_SABBG.WEB\Views\Home\Index.cshtml"
   
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <section id=""hero"">
    <div id=""heroCarousel"" data-bs-interval=""5000"" class=""carousel slide carousel-fade"" data-bs-ride=""carousel"">

      <div class=""carousel-inner"" role=""listbox"">

        <!-- Slide 1 -->
        <div class=""carousel-item active"" style=""background-image: url(./img/slide/slide-1.jpg);"">
          <div class=""carousel-container"">
            <div class=""carousel-content animate__animated animate__fadeInUp"">
              <h2>Welcome to <span>SABBG</span></h2>
              <p>South African Black Business Group is an intergration of various groups of companies with one common goal! To Help all small, medium and startup business to group and have access to a number of business oppotunities and services within South Africa and abroad</p>
            
              <div class=""text-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777ac8b173d58accefdc3eac6147870f43b1f8ec4672", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
            </div>
          </div>
        </div>

        <!-- Slide 2 -->
        <div class=""carousel-item"" style=""background-image: url(./img/slide/slide-2.jpg);"">
          <div class=""carousel-container"">
            <div class=""carousel-content animate__animated animate__fadeInUp"">
              <h2>Nation Sector</h2>
              <p>We are avalable in all nine provices within South Africa and Gauteng, North-West, Western Cape, Eastern Cape, Kwazulu-Natal, Free-State, Limpopo, Northern Provice and Mpumalanga all of them we have office and a presence within the country .</p>
              <div class=""text-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777ac8b173d58accefdc3eac6147870f43b1f8ec6690", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
            </div>
          </div>
        </div>

        <!-- Slide 3 -->
        <div class=""carousel-item"" style=""background-image: url(./img/slide/slide-3.jpg);"">
          <div class=""carousel-container"">
            <div class=""carousel-content animate__animated animate__fadeInUp"">
              <h2>Provincial Executive</h2>
              <p>The Provicial executive team is always available of help you with anything from consulting to Tax, Business coaching and finances. Our Invertment Arm also provides various investment oppotunities for all our clients both locally and abroad.... </p>
              <div class=""text-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777ac8b173d58accefdc3eac6147870f43b1f8ec8719", async() => {
                WriteLiteral("Read More");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
            </div>
          </div>
        </div>

      </div>

      <a class=""carousel-control-prev"" href=""#heroCarousel"" role=""button"" data-bs-slide=""prev"">
        <span class=""carousel-control-prev-icon bx bx-left-arrow"" aria-hidden=""true""></span>
      </a>

      <a class=""carousel-control-next"" href=""#heroCarousel"" role=""button"" data-bs-slide=""next"">
        <span class=""carousel-control-next-icon bx bx-right-arrow"" aria-hidden=""true""></span>
      </a>

      <ol class=""carousel-indicators"" id=""hero-carousel-indicators""></ol>

    </div>
  </section><!-- End Hero -->

  <main id=""main"">

    <!-- ======= Cta Section ======= -->
    <section id=""cta"" class=""cta"">
      <div class=""container"">
       <div class=""row"">

          <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
            <div class=""member"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""member-img"">
                <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3375, "\"", 3381, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100px"" height=""100px"">                
              </div>
              <div class=""member-info"">
                <h6>Segaetsho Cultural Village</h6>
              </div>
            </div>
          </div>

          <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
            <div class=""member"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""member-img"">
                <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3855, "\"", 3861, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100px"" height=""100px"">                
              </div>
              <div class=""member-info"">
                <h6>Khestha Invertments and Projects</h6>
              </div>
            </div>
          </div>

          <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
            <div class=""member"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""member-img"">
                <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4341, "\"", 4347, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100px"" height=""100px"">                
              </div>
              <div class=""member-info"">
                <h6>Hydro - Aqua Africa</h6>
              </div>
            </div>
          </div>
          <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
            <div class=""member"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""member-img"">
                <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4812, "\"", 4818, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100px"" height=""100px"">                
              </div>
              <div class=""member-info"">
                <h6>LLT Billas</h6>
              </div>
            </div>
          </div>

          <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
            <div class=""member"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""member-img"">
                <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5276, "\"", 5282, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100px"" height=""100px"">                
              </div>
              <div class=""member-info"">
                <h6>StarPeace Technologies</h6>
              </div>
            </div>
          </div>

          <div class=""col-lg-3 col-md-6 d-flex align-items-stretch"">
            <div class=""member"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""member-img"">
                <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 5752, "\"", 5758, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""100px"" height=""100px"">                
              </div>
              <div class=""member-info"">
                <h6>Loyiso Guided Solutions</h6>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!-- End Cta Section -->

    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
      <div class=""container"">

        <div class=""row"">
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"">
              <div class=""icon""><i class=""bi bi-briefcase""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 6414, "\"", 6421, 0);
            EndWriteAttribute();
            WriteLiteral(@">Mining</a></h4>
              <p class=""description"">We have business in the mining sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""100"">
              <div class=""icon""><i class=""bi bi-card-checklist""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 6812, "\"", 6819, 0);
            EndWriteAttribute();
            WriteLiteral(@">Agriculture</a></h4>
              <p class=""description"">We have business in the Agriculture sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""200"">
              <div class=""icon""><i class=""bi bi-bar-chart""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 7215, "\"", 7222, 0);
            EndWriteAttribute();
            WriteLiteral(@">Construction</a></h4>
              <p class=""description"">We have business in the Construction sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""200"">
              <div class=""icon""><i class=""bi bi-car""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 7614, "\"", 7621, 0);
            EndWriteAttribute();
            WriteLiteral(@">Transport</a></h4>
              <p class=""description"">We have business in the Transport sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""icon""><i class=""bi bi-brightness-high""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 8019, "\"", 8026, 0);
            EndWriteAttribute();
            WriteLiteral(@">Services, Exports and Import</a></h4>
              <p class=""description"">We have business in the Exports and Import sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""400"">
              <div class=""icon""><i class=""bi bi-calendar4-week""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 8451, "\"", 8458, 0);
            EndWriteAttribute();
            WriteLiteral(@">Engineering and Development</a></h4>
              <p class=""description"">We have business in the Engineering and Development sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""200"">
              <div class=""icon""><i class=""bi bi-binoculars""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 8887, "\"", 8894, 0);
            EndWriteAttribute();
            WriteLiteral(@">Training and Development</a></h4>
              <p class=""description"">We have business in the Training and Development sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""300"">
              <div class=""icon""><i class=""bi bi-brightness-high""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 9322, "\"", 9329, 0);
            EndWriteAttribute();
            WriteLiteral(@">Energy</a></h4>
              <p class=""description"">We have business in the Energy sector within various provinces</p>
            </div>
          </div>
          <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""400"">
              <div class=""icon""><i class=""bi bi-calendar4-week""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 9720, "\"", 9727, 0);
            EndWriteAttribute();
            WriteLiteral(@">Health</a></h4>
              <p class=""description"">We have business in the Health sector within various provinces</p>
            </div>
          </div>
           <div class=""col-lg-4 col-md-6"">
            <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""400"">
              <div class=""icon""><i class=""bi bi-calendar4-week""></i></div>
              <h4 class=""title""><a");
            BeginWriteAttribute("href", " href=\"", 10119, "\"", 10126, 0);
            EndWriteAttribute();
            WriteLiteral(@">Travel and Tourism</a></h4>
              <p class=""description"">We have business in the Health sector within various provinces</p>
            </div>
          </div>
        </div>

      </div>
    </section><!-- End Services Section -->

    <!-- ======= Portfolio Section ======= -->
    <section id=""portfolio"" class=""portfolio"">
      <div class=""container"">

        <div class=""row"" data-aos=""fade-up"">
          <div class=""col-lg-12 d-flex justify-content-center"">
            <ul id=""portfolio-flters"">
              <li data-filter=""*"" class=""filter-active"">All</li>
              <li data-filter="".filter-mining"">Mining</li>
              <li data-filter="".filter-agriculture"">Agriculture</li>
              <li data-filter="".filter-construction"">Construction</li>
              <li data-filter="".filter-transport"">Transport</li>
              <li data-filter="".filter-export-import"">Services, Exports & Import</li>
              <li data-filter="".filter-engineering-development"">Enginee");
            WriteLiteral(@"ring & Development</li>
              <li data-filter="".filter-training-development"">Training & Development</li>
              <li data-filter="".filter-travel-tourism`"">Travel & Tourism</li>
              <li data-filter="".filter-energy"">Energy</li>
              <li data-filter="".filter-health"">Health</li>
            </ul>
          </div>
        </div>

        <div class=""row portfolio-container"" data-aos=""fade-up"">

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 11716, "\"", 11722, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 12136, "\"", 12142, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 12556, "\"", 12562, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 12976, "\"", 12982, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 13396, "\"", 13402, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 13816, "\"", 13822, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 14236, "\"", 14242, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 14656, "\"", 14662, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

          <div class=""col-lg-4 col-md-6 portfolio-item filter-app"">
            <img src=""./img/NoSlogan.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 15076, "\"", 15082, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""portfolio-info"">
              <h4>Thuto Legwale</h4>
              <p>Travel and Tourism</p>
              <a href=""portfolio-details.html"" class=""details-link"" title=""More Details""><i class=""bx bx-link""></i></a>
            </div>
          </div>

        </div>

      </div>
    </section><!-- End Portfolio Section -->

    <!-- ======= Our Clients Section ======= -->
    <section id=""clients"" class=""clients"">
      <div class=""container"">

        <div class=""section-title"" data-aos=""fade-up"">
          <h2>Our <strong>Companies</strong></h2>
          <p>The following are some of the companies that represent SABBG. Various industries and services are available you can chose or wecan advice which company 
            gets the tender to give you the best rate and service and most importantly value for your money.
          </p>
        </div>

        <div class=""row no-gutters clients-wrap clearfix"" data-aos=""fade-up"">

          <div class=""col-lg-3 co");
            WriteLiteral("l-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-1.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16234, "\"", 16240, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-2.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16444, "\"", 16450, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-3.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16654, "\"", 16660, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-4.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 16864, "\"", 16870, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-5.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 17074, "\"", 17080, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-6.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 17284, "\"", 17290, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-7.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 17494, "\"", 17500, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-lg-3 col-md-4 col-xs-6\">\r\n            <div class=\"client-logo\">\r\n              <img src=\"./img/clients/client-8.png\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 17704, "\"", 17710, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n\r\n      </div>\r\n    </section><!-- End Our Clients Section -->\r\n\r\n  </main><!-- End #main -->\r\n");
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
