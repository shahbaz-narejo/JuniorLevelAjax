using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JuniorLevelAjax.Models;

namespace JuniorLevelAjax.Controllers
{
    public class StudentController : Controller
    {
        JuniorLevelAjax.App_Content.BAL.ClassBL classBL;
        JuniorLevelAjax.App_Content.BAL.CourseBL courseBL;
        JuniorLevelAjax.App_Content.BAL.StudentBL studentBL;
        JuniorLevelAjax.App_Content.BAL.StudentCourseBL studentCourseBL;

        public StudentController()
        {
            classBL = new App_Content.BAL.ClassBL();
            courseBL = new App_Content.BAL.CourseBL();
            studentBL = new App_Content.BAL.StudentBL();
            studentCourseBL = new App_Content.BAL.StudentCourseBL();
        }
        // GET: Student
        public ActionResult Index()
        {
            AddViewModel AddViewModel = new AddViewModel();
            //AddViewModel.ClassList = classBL.DropDownClassList(null);
            //AddViewModel.CourseList = courseBL.DropDownCourseList(null);
            return View(AddViewModel);
        }
        [HttpGet]
        public ActionResult GetByID(int? S_id)
        {
            List<ViewModel> ViewModelList = new List<ViewModel>();

            //DataTable dt = new DataTable();//studentBL.GetByID(S_id);
            //foreach (DataRow item in dt.Rows)
            //{
            //    ViewModel ViewModel = new ViewModel();
            //    ViewModel.S_id = Convert.ToInt32(item["S_id"]);
            //    ViewModel.S_name = item["S_name"].ToString();
            //    ViewModel.Class_id = Convert.ToInt32(item["Class_id"]);
            //    ViewModel.Class_name = item["Class_name"].ToString();
            //    ViewModel.Course_id = item["Course_id"].ToString();
            //    ViewModel.Course_name = item["Course_name"].ToString();
            //    ViewModel.S_contact = item["S_contact"].ToString();
            //    ViewModelList.Add(ViewModel);
            //}
            return Json(ViewModelList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveStudent(AddViewModel model)
        {
            //if (model.S_id<= 0)
            //{
            //    int Id = studentBL.InsertStudent(model.S_name,model.S_contact, model.Class_id);
            //    foreach (var item in model.Course_id)
            //    {
            //        studentCourseBL.InsertStudentCourse(Id, item);
            //    }
            //    return Json("Add Successful");
            //}
            //else
            //{
            //    studentBL.UpdateStudent(model.S_name, model.S_contact, model.Class_id, model.S_id);
            //    studentCourseBL.DeleteStudentCourse(model.S_id);
            //    foreach (var item in model.Course_id)
            //    {
            //        studentCourseBL.InsertStudentCourse(model.S_id, item);
            //    }
            //    return Json("Update Successful");
            //}
            return Json("Update Successful");
        }

        [HttpPost]
        public JsonResult Delete(int ID)
        {
            studentCourseBL.DeleteStudentCourse(ID);
            studentBL.DeleteStudent(ID);
            return Json("Delete Successful", JsonRequestBehavior.AllowGet);
        }
    }
}