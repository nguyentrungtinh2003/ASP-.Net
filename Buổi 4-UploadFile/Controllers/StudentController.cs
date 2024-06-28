using Buổi_4_UploadFile.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text.Json;

namespace Buổi_4_UploadFile.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ActionResult Manage(StudentInfo model, string command)
		{
			if (command == "Lưu File Text")
			{
				var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.txt");
				String[] lines = { model.Id, model.Name, model.Marks.ToString() };
				System.IO.File.WriteAllLines(path, lines);
				ViewBag.Message = "Đã ghi vào file text!";
			}
			else if (command == "Mở File Text")
			{
				var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.txt");
				if (System.IO.File.Exists(path))
				{
					String[] lines = System.IO.File.ReadAllLines(path);
					ViewBag.Id = lines[0];
					ViewBag.Name = lines[1];
					ViewBag.Marks = Convert.ToDouble(lines[2]);
					ViewBag.Message = "Đã đọc từ file text!";
				}
				else
				{
					ViewBag.Message = "File text không tồn tại!";
				}
			}
			else if (command == "Lưu File Json")
			{
				var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.json");
				var json = JsonSerializer.Serialize(model);
				System.IO.File.WriteAllText(path, json);
				ViewBag.Message = "Đã ghi vào file JSON!";
			}
			else if (command == "Mở File Json")
			{
				var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Student.json");
				if (System.IO.File.Exists(path))
				{
					var json = System.IO.File.ReadAllText(path);
					var student = JsonSerializer.Deserialize<StudentInfo>(json);
					ViewBag.Id = student.Id;
					ViewBag.Name = student.Name;
					ViewBag.Marks = student.Marks;
					ViewBag.Message = "Đã đọc từ file JSON!";
				}
				else
				{
					ViewBag.Message = "File JSON không tồn tại!";
				}
			}

			return View("Index");
		}
	}
}
