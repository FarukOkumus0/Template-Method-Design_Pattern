using DesingPattern.TemplateMethod.TemplatePatter;
using Microsoft.AspNetCore.Mvc;

namespace DesingPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            MubiPlans mubiPlans = new BasicPlan();
            ViewBag.v1 = mubiPlans.PlanType("Temel Plan");
            ViewBag.v2 = mubiPlans.CountPerson(1);
            ViewBag.v3 = mubiPlans.Price (79.99);
            ViewBag.v4 = mubiPlans.Content("film-dizi-spor-belgesel");
            ViewBag.v5 = mubiPlans.Resolution("720px");
            return View();
        }

        public IActionResult StandartPlanIndex()
        {
            MubiPlans mubiPlans = new StandartPlan();
            ViewBag.v1 = mubiPlans.PlanType("Standart Plan");
            ViewBag.v2 = mubiPlans.CountPerson(2);
            ViewBag.v3 = mubiPlans.Price(99.99);
            ViewBag.v4 = mubiPlans.Content("film-dizi-spor-belgesel-animasyon");
            ViewBag.v5 = mubiPlans.Resolution("10800px");
            return View();
        }

        public IActionResult PlatiniumPlanIndex()
        {
            MubiPlans mubiPlans = new PlatiniumPlan();
            ViewBag.v1 = mubiPlans.PlanType("Platinium Plan");
            ViewBag.v2 = mubiPlans.CountPerson(4);
            ViewBag.v3 = mubiPlans.Price(169.90);
            ViewBag.v4 = mubiPlans.Content("film-dizi-spor-belgesel-animasyon-yetişkin");
            ViewBag.v5 = mubiPlans.Resolution("10800px");
            return View();
        }
    }
}
