using Microsoft.AspNetCore.Mvc;
using GearGo.Models;

namespace GearGo.Controllers;

public class EquipmentController : Controller
{
    // Hard-coded list for Week 1. This is replaced by a database in a later week.
    private static readonly List<Equipment> _equipment = new()
    {
        new Equipment { Id = 1, Name = "4-Person Tent", Description = "Waterproof dome tent with groundsheet.", Category = "Camping", DailyRate = 120.00m, IsAvailable = true },
        new Equipment { Id = 2, Name = "Cordless Drill", Description = "18V drill with two batteries and charger.", Category = "Power Tools", DailyRate = 85.00m, IsAvailable = true },
        new Equipment { Id = 3, Name = "Event Marquee 6x3m", Description = "Steel-frame marquee for outdoor events.", Category = "Event Equipment", DailyRate = 650.00m, IsAvailable = false },
        new Equipment { Id = 4, Name = "Portable PA System", Description = "Speaker, mixer and two microphones.", Category = "Event Equipment", DailyRate = 300.00m, IsAvailable = true }
    };

    public IActionResult Index()
    {
        return View(_equipment);
    }

    public IActionResult Details(int id)
    {
        var item = _equipment.FirstOrDefault(e => e.Id == id);
        if (item == null)
        {
            return NotFound();
        }
        return View(item);
    }
}