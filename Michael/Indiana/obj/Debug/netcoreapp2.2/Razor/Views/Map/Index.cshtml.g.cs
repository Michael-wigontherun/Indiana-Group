#pragma checksum "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\Map\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81868335001b4a47755f29f2190713dad674dffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Index), @"mvc.1.0.view", @"/Views/Map/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Map/Index.cshtml", typeof(AspNetCore.Views_Map_Index))]
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
#line 1 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\_ViewImports.cshtml"
using Indiana;

#line default
#line hidden
#line 2 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\_ViewImports.cshtml"
using Indiana.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81868335001b4a47755f29f2190713dad674dffd", @"/Views/Map/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac064a92acf5a4afadc4d0f453fe79576e450585", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\Map\Index.cshtml"
  
    ViewData["Title"] = "Map";

#line default
#line hidden
            BeginContext(41, 48, true);
            WriteLiteral("<h1>Map</h1>\r\n<p>Your Latitude</p>\r\n<p id=\"lat\">");
            EndContext();
            BeginContext(90, 15, false);
#line 7 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\Map\Index.cshtml"
       Write(ViewData["lat"]);

#line default
#line hidden
            EndContext();
            BeginContext(105, 42, true);
            WriteLiteral("</p>\r\n<p>Your Longitude</p>\r\n<p id=\"long\">");
            EndContext();
            BeginContext(148, 16, false);
#line 9 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\Map\Index.cshtml"
        Write(ViewData["long"]);

#line default
#line hidden
            EndContext();
            BeginContext(164, 2569, true);
            WriteLiteral(@"</p>
<script>

    var map;
    var locationSplitLat;
    var locationSplitLng;

    locationSplitLat = parseFloat(document.getElementById(""lat"").innerHTML);
    locationSplitLng = parseFloat(document.getElementById(""long"").innerHTML);


    var focusPointLat = locationSplitLat;
    var focusPointLng = locationSplitLng;

    var focusPointLatRadiusHigh = focusPointLat + 0.5710999999999999;
    var focusPointLngRadiusHigh = focusPointLng + 0.5710999999999999;
    var focusPointLatRadiusLow = focusPointLat - 0.5710999999999999;
    var focusPointLngRadiusLow = focusPointLng - 0.5710999999999999;

    var focusPoint = { lat: focusPointLat, lng: focusPointLng };

    function initMap() {

        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 10,
            center: focusPoint
        });

        var allLats = [focusPointLat, 39.5067, focusPointLatRadiusHigh, focusPointLatRadiusLow, 41.070364, 41, 45, 41.332];
        var allLngs = [focusPointLng, -");
            WriteLiteral(@"86.3559, focusPointLngRadiusHigh, focusPointLngRadiusLow, -85.110736, -85, -86, -85.432];
        for (var i = 0; i < allLats.length; i++) {

            var myLatLng = { lat: allLats[i], lng: allLngs[i] };

            if (allLats[i] > focusPointLatRadiusHigh || allLngs[i] > focusPointLngRadiusHigh || allLats[i] < focusPointLatRadiusLow || allLngs[i] < focusPointLngRadiusLow) {

            }
            else {
                var marker = new google.maps.Marker({
                    position: myLatLng,
                    map: map,
                    title: 'GeoLocation: ' + allLats[i] + ':' + allLngs[i]
                });

            }
        }
        var citymap = {
            focus: {
                center: focusPoint,
                population: 603502
            }
        };
        for (var city in citymap) {
            // Add the circle for this city to the map.
            var cityCircle = new google.maps.Circle({
                strokeColor: '#00FFFF',
          ");
            WriteLiteral(@"      strokeOpacity: 0.8,
                strokeWeight: 2,
                fillColor: '#00FFFF',
                fillOpacity: 0.35,
                map: map,
                center: citymap[city].center,
                radius: 80467.2
            });
        }
    }
</script>

<div id=""map""></div>
<!-- Replace the value of the key parameter with your own API key. -->
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyA-gRm0nZea7Tr4w2aTYiaN6eu7OWxNvQ4&callback=initMap"" async defer></script>");
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
