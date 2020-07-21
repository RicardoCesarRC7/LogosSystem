using System.Web;
using System.Web.Optimization;

namespace LogosSystem
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            /*bundles.Add(new ScriptBundle("~/bundles/jquerymask").Include(
                        "~/Scripts/plugins/jquery-mask/jquerymask.js"));*/

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                      "~/Scripts/libs/popper/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/matchHeight").Include(
                      "~/Scripts/plugins/jqueryMatchHeight/jquery.matchHeight-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/font-awesome").Include(
                      "~/Scripts/libs/font-awesome/all.min.js"));

            bundles.Add(new Bundle("~/bundles/MainAngularModule").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/App/app.module.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/libs/font-awesome/all.min.css",
                      "~/Content/site.css"));
        }
    }
}
