#pragma checksum "/Users/drakewilcox/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Letter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "759925d0ac88e8febd24d0926a3a09fd5d6b4231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Letter), @"mvc.1.0.view", @"/Views/Home/Letter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Letter.cshtml", typeof(AspNetCore.Views_Home_Letter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"759925d0ac88e8febd24d0926a3a09fd5d6b4231", @"/Views/Home/Letter.cshtml")]
    public class Views_Home_Letter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            EndContext();
            BeginContext(25, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "759925d0ac88e8febd24d0926a3a09fd5d6b42312855", async() => {
                BeginContext(31, 142, true);
                WriteLiteral("\n    <title> Hello Friend!</title>\n    <link rel=\'stylesheet\' href=\'https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css\'>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(180, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(183, 531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "759925d0ac88e8febd24d0926a3a09fd5d6b42314162", async() => {
                BeginContext(189, 42, true);
                WriteLiteral("\n    <h1>Hello From Afar</h1>\n    <p>Dear ");
                EndContext();
                BeginContext(232, 15, false);
#line 9 "/Users/drakewilcox/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Letter.cshtml"
       Write(Model.Recipient);

#line default
#line hidden
                EndContext();
                BeginContext(247, 135, true);
                WriteLiteral(",</p>\n    <p>How are you? I hope that you are having a nice weekend. I\'m vacationing in Iceland while I learn programming! </p>\n    <p>");
                EndContext();
                BeginContext(383, 15, false);
#line 11 "/Users/drakewilcox/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Letter.cshtml"
  Write(Model.Recipient);

#line default
#line hidden
                EndContext();
                BeginContext(398, 284, true);
                WriteLiteral(@", you would not believe how cold it is here. I should have gone to Hawaii instead.</p>
    <p>But I like programming a lot, so I've got that going for me. </p>
    <p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>
    <p>Cheers,</p>
    <p>Travel Enthusiast ");
                EndContext();
                BeginContext(683, 12, false);
#line 15 "/Users/drakewilcox/Desktop/FriendLetter.Solution/FriendLetter/Views/Home/Letter.cshtml"
                    Write(Model.Sender);

#line default
#line hidden
                EndContext();
                BeginContext(695, 12, true);
                WriteLiteral("</p>\n    \n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591