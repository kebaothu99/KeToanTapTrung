using System.Web.Mvc;

namespace KeToanTapTrung.Areas.DonVi
{
    public class DonViAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "DonVi";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "DonVi_default",
                "DonVi/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}