#pragma checksum "Z:\PROYECTOSdePROGRAMACION\OpenpayNet\Views\Openpay\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6820655fb0da3273a7815c3088b9efec8ed3dce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Openpay_index), @"mvc.1.0.view", @"/Views/Openpay/index.cshtml")]
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
#line 1 "Z:\PROYECTOSdePROGRAMACION\OpenpayNet\Views\_ViewImports.cshtml"
using OpenpayNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\PROYECTOSdePROGRAMACION\OpenpayNet\Views\_ViewImports.cshtml"
using OpenpayNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6820655fb0da3273a7815c3088b9efec8ed3dce", @"/Views/Openpay/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c616abc143fba96116108c22530c2013495456", @"/Views/_ViewImports.cshtml")]
    public class Views_Openpay_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formulario-tarjeta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formulario-tarjeta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario-tarjeta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "Z:\PROYECTOSdePROGRAMACION\OpenpayNet\Views\Openpay\index.cshtml"
  
	ViewData["Title"] = "Openpay";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Implementación de la libreria Openpay</h2>

<div class=""contenedor"">


	<div id=""errorFormulario"">
		<span class=""span_error"">
		</span>
	</div>

	<!-- Tarjeta -->
	<section class=""tarjeta"" id=""tarjeta"">
		<div class=""delantera"">
			<div class=""logo-marca"" id=""logo-marca"">
			</div>
			<img src=""/img/chip-tarjeta.png"" class=""chip""");
            BeginWriteAttribute("alt", " alt=\"", 393, "\"", 399, 0);
            EndWriteAttribute();
            WriteLiteral(@">
			<div class=""datos"">
				<div class=""grupo"" id=""numero"">
					<p class=""label"">Número Tarjeta</p>
					<p class=""numero"">#### #### #### ####</p>
				</div>
				
				<div class=""flexbox"">
					<div class=""grupo"" id=""nombre"">
						<p class=""label"">Nombre Tarjeta</p>
						<p class=""nombre"">XXXX XXX</p>
					</div>

					<div class=""grupo"" id=""expiracion"">
						<p class=""label"">Expiracion</p>
						<p class=""expiracion""><span class=""mes"">MM</span> / <span class=""year"">AA</span></p>
					</div>
				</div>
			</div>
		</div>

		<div class=""trasera"">
			<div class=""barra-magnetica""></div>
			<div class=""datos"">
				<div class=""grupo"" id=""firma"">
					<p class=""label"">Firma</p>
					<div class=""firma"">
						<p></p>
					</div>
				</div>
				<div class=""grupo"" id=""ccv"">
					<p class=""label"">CCV</p>
					<p class=""ccv""></p>
				</div>
			</div>
			<p class=""leyenda"">Es un gusto compartir esta Implementación con ustedes, espero que les sea de mucha ayuda
				en sus proyectos");
            WriteLiteral(@".</p>
			<a href=""#"" class=""link-banco"">www.openpay.pe</a>
		</div>
	</section>

	<!-- Contenedor Boton Abrir Formulario -->
	<div class=""contenedor-btn"">
		<button class=""btn-abrir-formulario"" id=""btn-abrir-formulario"">
			<i class=""fas fa-plus"">-</i>
		</button>
	</div>


	<!-- Formulario -->
	");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6820655fb0da3273a7815c3088b9efec8ed3dce6504", async() => {
                WriteLiteral(@"
		<div class=""grupo"">
			<label for=""inputTarjeta"">Número Tarjeta</label>
			<input type=""text"" id=""inputNumero"" data-openpay-card=""card_number"" maxlength=""16"" autocomplete=""off"">
		</div>
		<div class=""grupo"">
			<label for=""inputNombre"">Nombre</label>
			<input type=""text"" id=""inputNombre"" data-openpay-card=""holder_name"" maxlength=""19"" autocomplete=""off"">
		</div>
		<div class=""flexbox"">
			<div class=""grupo expira"">
				<label for=""selectMes"">Expiracion</label>
				<div class=""flexbox"">
					<div class=""grupo-select"">
						<select name=""mes"" id=""selectMes"" data-openpay-card=""expiration_month"">
							");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6820655fb0da3273a7815c3088b9efec8ed3dce7431", async() => {
                    WriteLiteral("Mes");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</select>\r\n\t\t\t\t\t\t<i class=\"fas fa-angle-down\"></i>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"grupo-select\">\r\n\t\t\t\t\t\t<select name=\"year\" id=\"selectYear\" data-openpay-card=\"expiration_year\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6820655fb0da3273a7815c3088b9efec8ed3dce9334", async() => {
                    WriteLiteral("Año");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
						</select>
						<i class=""fas fa-angle-down""></i>
					</div>
				</div>
			</div>

			<div class=""grupo ccv"">
				<label for=""inputCCV"">CCV</label>
				<input type=""text"" id=""inputCCV"" data-openpay-card=""cvv2"" maxlength=""4"">
			</div>
		</div>

		<label");
                BeginWriteAttribute("for", " for=\"", 2990, "\"", 2996, 0);
                EndWriteAttribute();
                WriteLiteral(">Dirección</label>\r\n\t\t<div class=\"formularioDireccion\">\r\n\t\t\t<label for=\"Street\">Calle:</label>\r\n\t\t\t<input type=\"text\" data-openpay-card-address=\"line1\" maxlength=\"19\" autocomplete=\"off\">\r\n\t\t</div>\r\n\r\n\t\t<div class=\"grupo\">\r\n\t\t\t<label");
                BeginWriteAttribute("for", " for=\"", 3229, "\"", 3235, 0);
                EndWriteAttribute();
                WriteLiteral(">Referencias</label>\r\n\t\t\t<input type=\"text\" data-openpay-card-address=\"line3\" autocomplete=\"off\">\r\n\t\t</div>\r\n\r\n\t\t<div class=\"flexbox\">\r\n\r\n\t\t\t<div class=\"grupo\">\r\n\t\t\t\t<label");
                BeginWriteAttribute("for", " for=\"", 3408, "\"", 3414, 0);
                EndWriteAttribute();
                WriteLiteral(">Teléfono:</label>\r\n\t\t\t\t<input type=\"text\" data-openpay-card-address=\"line2\" maxlength=\"10\"autocomplete=\"off\">\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"grupo\">\r\n\t\t\t\t<label");
                BeginWriteAttribute("for", " for=\"", 3574, "\"", 3580, 0);
                EndWriteAttribute();
                WriteLiteral(">Código postal:</label>\r\n\t\t\t\t<input type=\"text\" data-openpay-card-address=\"postal_code\" maxlength=\"6\"autocomplete=\"off\">\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\r\n\t\t\r\n\r\n\t\t\t<div class=\"City\">\r\n\t\t\t\t<label");
                BeginWriteAttribute("for", " for=\"", 3767, "\"", 3773, 0);
                EndWriteAttribute();
                WriteLiteral(">Ciudad:</label>\r\n\t\t\t\t<input type=\"text\" data-openpay-card-address=\"city\" autocomplete=\"off\">\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"State\">\r\n\t\t\t\t<label");
                BeginWriteAttribute("for", " for=\"", 3916, "\"", 3922, 0);
                EndWriteAttribute();
                WriteLiteral(">País:</label>\r\n\t\t\t\t<input type=\"text\" data-openpay-card-address=\"state\" autocomplete=\"off\">\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"codigoPais\">\r\n\t\t\t\t<label");
                BeginWriteAttribute("for", " for=\"", 4069, "\"", 4075, 0);
                EndWriteAttribute();
                WriteLiteral(">Código del país:</label>\r\n\t\t\t\t<input type=\"text\" data-openpay-card-address=\"country_code\" value=\"PE\">\r\n\t\t\t</div>\r\n\r\n\r\n\t\t<input id=\"makeRequestCard\" type=\"button\" value=\"Pagar\">\r\n\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
