#pragma checksum "C:\Users\navid\source\repos\Chord\Chord\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff53205ed22f3a8833da3a18e34f699530c2c9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff53205ed22f3a8833da3a18e34f699530c2c9d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff53205ed22f3a8833da3a18e34f699530c2c9d2872", async() => {
                BeginContext(31, 74, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Display Webcam Stream</title>\r\n\r\n");
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
            BeginContext(112, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(116, 8384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ff53205ed22f3a8833da3a18e34f699530c2c9d4138", async() => {
                BeginContext(122, 8371, true);
                WriteLiteral(@"
    <p id=""para2""> This method will detect the movement of selected color as points</p>
    <p id=""para""> detected Points </p>


    <div id=""container"">
        <video autoplay=""FALSE"" id=""videox"" width=""100"" height=""100"" controls></video>
    </div>

    <div style=""position:relative;  top:2px;  "">
        <input id=""sens"" type=""number"" value=10 onchange=""setSensiv()"" />
        <input id=""colFilR"" type=""number"" value=1 onchange=""setColorfilterR()"" />
        <input id=""colFilG"" type=""number"" value=254 onchange=""setColorfilterG()"" />
        <input id=""colFilB"" type=""number"" value=1 onchange=""setColorfilterB()"" />
        <input id=""fRate"" type=""number"" value=500 onchange=""setFrameRate()"" />
        <p>Sensitivity -----   Red -----   Green-----   Blue------   frameRate </p>
    </div>

    <button onclick=""captureStrt()"">Capture</button>
    <button onclick=""StopFunction()"">Stop</button>
    <canvas id=""canvas"" style=""overflow:auto""></canvas>



    <canvas id=""ColorCanvas"" width=""5");
                WriteLiteral(@"0"" height=""50"" style=""border:1px solid #000000;""> </canvas>

    <script>
        var myVar = 0;
        var detectedPoints = [];
        console.log(detectedPoints.length);

        var captureItretor = 0;
        var videoOrg = document.querySelector(""#video"");
        var videox = document.getElementById('videox');

        var filterObj = { r: 1, g: 254, b: 1 };//green
        var sens = 10;
        var frameRate = 100;
        var video = videox;

        function showColor() {

            var canvas2 = document.getElementById('ColorCanvas');
            var ctx2 = canvas2.getContext('2d');
            imgData2 = ImgCrtF(filterObj.r, filterObj.g, filterObj.b, 50, ctx2);
            ctx2.putImageData(imgData2, 0, 0);

        }
        showColor();


        if (navigator.mediaDevices.getUserMedia) {
            navigator.mediaDevices.getUserMedia({ video: true })
                .then(function (stream) {
                    video.srcObject = stream;
                })
   ");
                WriteLiteral(@"             .catch(function (err0r) {
                    console.log(""Something went wrong!"");
                });
        }

        //filter functions
        function setSensiv() {

            sens = document.getElementById(""sens"").value;
            showColor();

        }

        function setColorfilterR() {
            filterObj.r = document.getElementById(""colFilR"").value;
            showColor();

        }

        function setColorfilterG() {
            filterObj.g = document.getElementById(""colFilG"").value;
            showColor();

        }

        function setColorfilterB() {
            filterObj.b = document.getElementById(""colFilB"").value;
            showColor();

        }


        function setFrameRate() {
            frameRate = document.getElementById(""fRate"").value;
            console.log(frameRate)
        }





        //
        function captureStrt() {
            myVar = window.setInterval(capture, frameRate);
        }

      ");
                WriteLiteral(@"  function StopFunction() {
            clearInterval(myVar);
            detectedPoints = [];

        }




        /// capture
        function capture() {
            var canvas = document.getElementById('canvas');

            // var img = document.createElement(""img"");
            var ctx = canvas.getContext('2d');
            var temp = 0;
            var tempAry = [];
            //var imModdata = imgDataC;
            this.captureItretor = this.captureItretor + 1;

            video = this.videox;
            //console.log(video.videoWidth);



            canvas.width = video.videoWidth;
            canvas.height = video.videoHeight;

            ctx.drawImage(video, 0, 0, video.videoWidth, video.videoHeight); // vedio from cam to canvas
            var imgDataC = ctx.getImageData(0, 0, video.videoWidth, video.videoHeight);

            //console.log(imgDataC);
            //img.src = canvas.toDataURL();
            //canvas.srcObject = stream.url;



           ");
                WriteLiteral(@" // document.getElementById(""para"").innerHTML = condColor1[1];



            //canvas.getContext('2d').putImageData(imgDataC, 0, 0);
            // canvas.getContext('2d').putImageData(imgData, 0, 0);
            //ctx.putImageData(imgData, 100, 100);

            //imgData = ImgCrtF(0, 255, 0, 4, ctx); // this is for test
            //ctx.putImageData(imgData, 2 * this.captureItretor, 5 * this.captureItretor); //TODO condColor1 can be used here, the location is x , y


            //info// video.videoWidth(1340)* video.videoHeight*4 = imgData.data.length

            var imgDataWithMod = ctx.getImageData(0, 0, video.videoWidth, video.videoHeight);
            // canvas.getContext('2d').putImageData(imgDataWithMod, 0, 0);
            tempAry = DetectObj(this.filterObj.r, this.filterObj.g, this.filterObj.b, imgDataWithMod, this.sens);



            for (i = 0; i < tempAry.length; i++)// this as push makes new ary in ary
                this.detectedPoints.push(tempAry[i]);


        ");
                WriteLiteral(@"    if (detectedPoints.length > 1)
                document.getElementById(""para"").innerHTML = this.detectedPoints[detectedPoints.length - 1].toString(); //+ "" "" + (condColor[2] % video.videoWidth).toString() + "" "" + condColor[3].toString() + "" "" + video.videoWidth;

            //test
            // console.log(Lineto2Dy(detectedPoints[0], video.videoWidth, video.videoWidth));
            //console.log(Lineto2Dx(detectedPoints[0], video.videoWidth, video.videoWidth));
            //console.log(detectedPoints[0]);


            console.log(this.detectedPoints.length);
            //console.log(video.videoWidth); //1340
            //depict the final curve at the end of each frame
            imgData = ImgCrtF(0, 255, 0, 2, ctx); //create base element shape
            // detectedPoints  contains all of points
            // the image canvas  is  imgDataC
            // the functio to depict is this ctx.putImageData(img, x=0, y =0);
            // ctx.putImageData (x,y) x--> horiz, Lineto2Dx
");
                WriteLiteral(@"
            ShowLine(ctx, detectedPoints, video.videoWidth, imgData);
            if (detectedPoints.length > 85000)
                StopFunction();



        }




        //---------------------functions
        function ImgCrtF(r, g, b, size, ctx) {

            var imgData = ctx.createImageData(size, size);
            for (i = 0; i < imgData.data.length; i += 4) {
                imgData.data[i + 0] = r;
                imgData.data[i + 1] = g;
                imgData.data[i + 2] = b;
                imgData.data[i + 3] = 255;
            }
            return imgData;
        }



        function DetectObj(rm, gm, bm, imgDataC, sens) {
            var condColor1 = [];
            var temp = 0;
            for (i = 0; i < imgDataC.data.length; i += 4) {
                if ((imgDataC.data[i + 0] < rm + sens) & (imgDataC.data[i + 1] < gm + sens) & (imgDataC.data[i + 2] < bm + sens) & ((imgDataC.data[i + 0] > rm - sens) & (imgDataC.data[i + 1] > gm - sens) & (imgDataC.data[i ");
                WriteLiteral(@"+ 2] > bm - sens))) {
                    condColor1.push(i / 4);

                    //document.getElementById(""para2"").innerHTML = ++temp;
                }
            }
            return condColor1;
        }


        function Lineto2Dy(detectedPoint, width, height) {
            var y = Math.floor(detectedPoint / width);
            return y;
        }
        function Lineto2Dx(detectedPoint, width, height) {
            var x = Math.floor(detectedPoint % width);
            return x;
        }

        function ShowLine(ctx, detectedPoints, videoWidth, imgData) {
            var y = Lineto2Dy(detectedPoints[0], videoWidth, 0)
            var x = Lineto2Dx(detectedPoints[0], videoWidth, 0)

            for (p = 0; p < detectedPoints.length; p++) {
                y = Lineto2Dy(detectedPoints[p], videoWidth, 0)
                x = Lineto2Dx(detectedPoints[p], videoWidth, 0)

                ctx.putImageData(imgData, x, y);
            }

        }

                     ");
                WriteLiteral("           //html back up\r\n                                //<video id=\"video\" src=\"~/vedio/x.mp4\" type=\"video/mp4\" controls></video>\r\n\r\n    </script>\r\n    <styl>\r\n\r\n    </styl>\r\n");
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
            BeginContext(8500, 9, true);
            WriteLiteral("\r\n</html>");
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
