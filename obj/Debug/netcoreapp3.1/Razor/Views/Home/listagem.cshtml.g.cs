#pragma checksum "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10247e27a15aa9c26300b8582a90b205fc60b797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_listagem), @"mvc.1.0.view", @"/Views/Home/listagem.cshtml")]
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
#line 1 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\_ViewImports.cshtml"
using segundaparte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\_ViewImports.cshtml"
using segundaparte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10247e27a15aa9c26300b8582a90b205fc60b797", @"/Views/Home/listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0431c6ff2cf2a4fc86d81b84a97869e7dadabefc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
    <style>
    table {
        text-align: center;
        line-height: 2;
    }
</style>

    <h2> Seus pedidos </h2>
<table border=""1"">
   <thead>
       <tr>
           <th>Nome</th>
           <th>Telefone</th>
           <th>Cardapio</th>
           <th>Quantidade</th>
           <th>Endereco</th>
       </tr>
   </thead>
   <tbody>
");
#nullable restore
#line 22 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
        foreach(ItemPedido a in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 25 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
          Write(a.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 26 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
          Write(a.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 27 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
          Write(a.cardapio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 28 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
          Write(a.quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 29 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
          Write(a.endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Thaís\Desktop\Programmer\Módulo 1\Unidade 3\Atividade1\segundaparte\Views\Home\listagem.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("   </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10247e27a15aa9c26300b8582a90b205fc60b7975724", async() => {
                WriteLiteral("Fazer novo pedido");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591