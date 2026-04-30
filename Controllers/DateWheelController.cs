using CoffeeDateWheel.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeDateWheel.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DateWheelController : ControllerBase
    {
        private static readonly string[] Coffees =
        {
             "Latte ☕", "Cappuccino 🤎", "Mocha 🍫",
            "Türk Kahvesi 🇹🇷", "Flat White 🥛", "Americano ✨",
            "Caramel Macchiato 🍯", "Iced Coffee 🧊"
        };

        private static readonly string[] Places =
        {
            "Deniz kenarı 🌊", "Rooftop kafe 🏙️", "Kitapçı kafe 📚",
            "Park bahçesi 🌳", "Retro kafe 🎶", "Gizli bahçe 🌿",
            "Sanat galerisi kafesi 🎨", "Nostaljik tramvay durağı 🚋"
        };

        private static readonly string[] Activities =
        {
            "Birbirimize mektup yazalım 💌",
            "Kahve falı bakalım ☕🔮",
            "Birlikte playlist yapalım 🎵",
            "20 soru oynayalım 🎲",
            "Birbirimize çizim yapalım 🎨",
            "Fotoğraf challenge yapalım 📸",
            "Birbirimize kitap önerelim 📖",
            "Gelecek planları kuralım 🌟"
        };

        private static readonly string[] Moods =
        {
            "Romantik 💕", "Eğlenceli 🎉", "Huzurlu 🕊️",
            "Maceracı 🗺️", "Nostaljik 📼", "Yaratıcı 🎭"
        };

        private static readonly string[] Messages =
        {
            "Seninle her an güzel ❤️",
            "Bu kahve senin kadar tatlı olamaz 🥰",
            "Bugün sadece biz varız 💫",
            "En güzel anılar seninle 🌹",
            "Her yudum seninle daha güzel ☕❤️",
            "Dünya dursa bile kahvemiz soğumasın 😊"
        };

        private static readonly Random _random = new();

        [HttpGet("spin")]
        public ActionResult<DatePlan> Spin()
        {
            var plan = new DatePlan
            {
                Coffee = Coffees[_random.Next(Coffees.Length)],
                Place = Places[_random.Next(Places.Length)],
                Activity = Activities[_random.Next(Activities.Length)],
                Mood = Moods[_random.Next(Moods.Length)]    ,
                Message = Messages[_random.Next(Messages.Length)]

            };

            return Ok(plan);
        }

        [HttpGet("coffees")]
        public ActionResult<string[]> GetCoffees() => Ok(Coffees);

        [HttpGet("places")]
        public ActionResult<string[]> GetPlaces() => Ok(Places);

        [HttpGet("activities")]
        public ActionResult<string[]> GetActivities() => Ok(Activities);
    }
}
