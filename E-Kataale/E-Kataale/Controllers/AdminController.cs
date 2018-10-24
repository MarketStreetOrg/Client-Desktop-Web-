using E_Kataale.Code;
using E_Kataale.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using System.Web.Mvc;

namespace E_Kataale.Controllers
{
    public class AdminController : Controller
    {
        List<Department> departments;
        HttpGeneric generic = new HttpGeneric();
        Department FocusDepartment;

        string Departm = null;

        // GET: Default
        public async Task<ActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> Departments()
        {

            departments = new List<Department>();

            JArray JsonArray = JArray.Parse(await generic.GetAsync("http://localhost/ms/api/Admin/Departments"));

            foreach(JObject jObject in JsonArray)
            {
                Department department = new Department
                {
                    ID = Convert.ToInt32(jObject["ID"].ToString()),
                    Name = jObject["Name"].ToString(),
                    Description = jObject["Description"].ToString(),
                    Categories=Convert.ToInt32(jObject["Categories"].ToString())
                    
                };

                departments.Add(department);
            }


            return View(departments);
        }

        [HttpPost]
        public async Task<ActionResult> NewDepartment(string Name,string Description)
        {

         
            JObject DepartmentObject = new JObject();
            DepartmentObject["Name"] = Name;
            DepartmentObject["Description"] = Description;

            await generic.PostAsync("http://localhost/ms/api/Admin/AddDepartment", DepartmentObject);

            return RedirectToAction("Departments");
        }



        public async Task<ActionResult> Department(int id)
        {
            JObject JsonObject = JObject.Parse(await generic.GetAsync("http://localhost/ms/api/Admin/department/" + id.ToString()));

            Department department = new Department()
            {
                ID = Convert.ToInt32(JsonObject["ID"].ToString()),
                Name = JsonObject["Name"].ToString(),
                Description = JsonObject["Description"].ToString()
            };

            FocusDepartment = department;

            return View(department);
        }
        
        public async Task<ActionResult> EditDepartment(Department department)
        {
            JObject DepartmentObject = new JObject();
            DepartmentObject["ID"] = department.ID;
            DepartmentObject["Name"] = department.Name;
            DepartmentObject["Description"] = department.Description;

             await generic.PutAsync("http://localhost/ms/api/Admin/EditDepartment", DepartmentObject);

            return RedirectToAction("department",new { id = department.ID });
        }

        public async Task<ActionResult> DeleteDepartment(int id)
        {
            await generic.DeleteAsync("http://localhost/ms/api/Admin/DeleteDepartment/?id="+id);

            return RedirectToAction("departments");
        }

        [ActionName("categories-dept")]
        [HttpGet]
        public async Task<ActionResult> CategoriesInDepartment(int ID)
        {
            List<Category> categories = new List<Category>();

            
            JArray JsonArray = JArray.Parse(await generic.GetAsync("http://localhost/ms/api/Admin/Categories-dept?id="+ID));

            foreach (JObject jObject in JsonArray)
            {
                Category category = new Category
                {
                    ID = Convert.ToInt32(jObject["ID"].ToString()),
                    Name = jObject["Name"].ToString(),
                    Description = jObject["Description"].ToString(),
                    Products=Convert.ToInt32(jObject["Products"].ToString())
                
                };

                JObject departmentObject = (JObject)jObject["Department"];

                Department department = new Department();

                department.ID = Convert.ToInt32(departmentObject["ID"].ToString());
                department.Name = departmentObject["Name"].ToString();

                category.Department = department;

               

                categories.Add(category);
            }

            var RunDepartments = await Departments();

            ViewData["Departments"] = departments;

            await Department(ID);

            ViewData["FocusDepartment"] = FocusDepartment;

            return View("categories",categories);
        }

        [HttpGet]
        public async Task<ActionResult> Categories()
        {
            List<Category> categories = new List<Category>();


            JArray JsonArray = JArray.Parse(await generic.GetAsync("http://localhost/ms/api/Admin/Categories"));

            foreach (JObject jObject in JsonArray)
            {
                Category category = new Category
                {
                    ID = Convert.ToInt32(jObject["ID"].ToString()),
                    Name = jObject["Name"].ToString(),
                    Description = jObject["Description"].ToString(),
                    Products = Convert.ToInt32(jObject["Products"].ToString())

                };

                JObject departmentObject = (JObject)jObject["Department"];

                Department department = new Department();

                department.ID = Convert.ToInt32(departmentObject["ID"].ToString());
                department.Name = departmentObject["Name"].ToString();

                category.Department = department;

                categories.Add(category);
            }

            var RunDepartments = await Departments();

            ViewData["Departments"] = departments;

            return View(categories);
        }

        [HttpPost]
        public async Task<ActionResult> NewCategory(int Department,string Name,string Description)
        {
            JObject CategoryObject = new JObject();

            CategoryObject["Departmentid"] = Department;
            CategoryObject["Name"] = Name;
            CategoryObject["Description"] = Description;

            await generic.PostAsync("http://localhost/ms/api/Admin/AddCategory", CategoryObject);

            return RedirectToAction("Categories");

        }

        public ActionResult Markets()
        {
            return View();
        }

        public ActionResult Suppliers()
        {
            return View();
        }

        public ActionResult Manufacturers()
        {
            return View();
        }

        //SET

    }
}