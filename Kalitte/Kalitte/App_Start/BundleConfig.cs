using System.Web;
using System.Web.Optimization;

namespace Kalitte
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*",
                        "~/Scripts/modernizer.custom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/mainjs").Include(
                      "~/Scripts/jquery.easing.1.3.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.fancybox.pack.js",
                      "~/Scripts/jquery.fancybox-media.js",
                      "~/Scripts/jquery.isotope.min.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/animate.js",
                      "~/Scripts/custom.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/sliderjs").Include(
                      "~/Scripts/jquery.flexslider.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/galleryjs").Include(
                      "~/Scripts/jquery.flexslider.js"
                      ));




            bundles.Add(new StyleBundle("~/Content/maincss").Include(
                      "~/Content/css/animate.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/custom-fonts.css",
                      "~/Content/css/custom-kalitte.css",
                      "~/Content/css/font-awesome.css",
                      "~/Content/css/style.css",
                      "~/Content/css/fancybox/jquery.fancybox.css"

                      ));

            bundles.Add(new StyleBundle("~/Content/slidercss").Include(
                      "~/Content/css/flexslider.css"
                      ));
            
            bundles.Add(new StyleBundle("~/Content/gallerycss").Include(
                      "~/Content/css/gallery-1.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/magnific-popup.css"
                        ));

        }
    }
}
