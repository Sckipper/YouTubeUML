using System.Web.Optimization;

namespace YouTubeUML
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new StyleBundle("~/css/layout").Include(
                "~/Content/CSS/dashboard.css",
                "~/Content/CSS/popuo-box.css",
                "~/Content/CSS/style.css",
                "~/Content/CSS/Layout.css"
            ));

            bundles.Add(new ScriptBundle("~/js/scripts").Include(
                "~/Content/JS/bootstrap.min.js",
                "~/Content/JS/jquery.magnific-popup.js",
                "~/Content/JS/jquery.polyglot.language.switcher.js",
                "~/Content/JS/jquery-1.11.1.min.js",
                "~/Content/JS/modernizr.custom.min.js",
                "~/Content/JS/responsiveslides.min.js"
            ));
        }
    }
}