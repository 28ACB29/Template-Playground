using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Web.Mvc;
using TemplatePlayground.Models;

namespace TemplatePlayground.Controllers
{
	public class TestController : Controller
	{
		private TestDB DB = new TestDB();

		// GET: Test
		public ActionResult Index()
		{
			IEnumerable<Test> tests = this.DB.Tests;
			return this.View(tests);
		}

		// GET: Test/Details/5
		public ActionResult Details(int id)
		{
			Test test = this.DB.Tests.Find(id);
			return this.View(test);
		}

		// GET: Test/Create
		public ActionResult Create()
		{
			return this.View(new Test());
		}

		// POST: Test/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				// TODO: Add insert logic here
				Test test = new Test
				{
					Bool = bool.Parse(collection["Bool"]),
					Byte = byte.Parse(collection["Byte"]),
					Char = char.Parse(collection["Char"]),
					DateTime = DateTime.Parse(collection["DateTime"]),
					Decimal = decimal.Parse(collection["Decimal"]),
					Double = double.Parse(collection["Double"]),
					Float = float.Parse(collection["Float"]),
					Int = int.Parse(collection["Int"]),
					Long = long.Parse(collection["Long"]),
					//Sbyte = sbyte.Parse(collection["Sbyte"]),
					Short = short.Parse(collection["Short"]),
					Uint = uint.Parse(collection["Uint"]),
					Ulong = ulong.Parse(collection["Ulong"]),
					Ushort = ushort.Parse(collection["Ushort"])
				};
				this.DB.Tests.AddOrUpdate(test);
				this.DB.SaveChanges();
				return this.RedirectToAction("Index");
			}
			catch
			{
				return this.View();
			}
		}

		// GET: Test/Edit/5
		public ActionResult Edit(int id)
		{
			Test test = this.DB.Tests.Find(id);
			return this.View(test);
		}

		// POST: Test/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here
				Test test = this.DB.Tests.Find(id);
				test.Bool = bool.Parse(collection["Bool"]);
				test.Byte = byte.Parse(collection["Byte"]);
				test.Char = char.Parse(collection["Char"]);
				test.DateTime = DateTime.Parse(collection["DateTime"]);
				test.Decimal = decimal.Parse(collection["Decimal"]);
				test.Double = double.Parse(collection["Double"]);
				test.Float = float.Parse(collection["Float"]);
				test.Int = int.Parse(collection["Int"]);
				test.Long = long.Parse(collection["Long"]);
				//test.Sbyte = sbyte.Parse(collection["Sbyte"]);
				test.Short = short.Parse(collection["Short"]);
				test.Uint = uint.Parse(collection["Uint"]);
				test.Ulong = ulong.Parse(collection["Ulong"]);
				test.Ushort = ushort.Parse(collection["Ushort"]);
				this.DB.Tests.AddOrUpdate(test);
				this.DB.SaveChanges();
				return this.RedirectToAction("Index");
			}
			catch
			{
				return this.View();
			}
		}

		// GET: Test/Delete/5
		public ActionResult Delete(int id)
		{
			Test test = this.DB.Tests.Find(id);
			return this.View(test);
		}

		// POST: Test/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here
				Test test = this.DB.Tests.Find(id);
				this.DB.Tests.Remove(test);
				this.DB.SaveChanges();
				return this.RedirectToAction("Index");
			}
			catch
			{
				return this.View();
			}
		}
	}
}
