using System.Web.Mvc;

namespace KeToanTapTrung.Areas.HoiSo
{
    public class HoiSoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HoiSo";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HoiSo_default",
                "HoiSo/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}