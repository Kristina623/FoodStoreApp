using FoodStoreApp.Data;
using FoodStoreApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace FoodStore.Controllers
{
    public class ManufacturersController : Controller
    {
        // Переменная контекста для доступа к базе данных
        private readonly ApplicationDbContext _db;

        // Внедряем зависимость ApplicationDbContext через конструктор
        public ManufacturersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            // Создаем список записей категорий из базы данных
            IEnumerable<Manufacturers> ManufacturersList = _db.Manufacturers;
            // Возвращаем загруженный список в представление
            return View(ManufacturersList);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Manufacturers manufacturers)
        {

            _db.Manufacturers.Add(manufacturers);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            return View();
        }


        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            return View();
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var cat = _db.Manufacturers.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            _db.Manufacturers.Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
