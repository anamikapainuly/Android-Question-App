using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace Android_Question_App
{
    [Activity(Label = "SidebarActivity")]
    public class SidebarActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var sidebarHtml = Intent.Extras.GetString("sidebarHtml");
            var webView = new WebView(this);

            var deviceWidth = Resources.DisplayMetrics.WidthPixels; //getting the width in pixels  
            var deviceHeight = Resources.DisplayMetrics.HeightPixels; //getting the height in pixels  

            //set content view with device width and height
            AddContentView(webView, new ViewGroup.LayoutParams(deviceWidth, deviceHeight)); 
            webView.LoadData(sidebarHtml, "text/html", "utf-8");    //load data in web view
        }
    }
}