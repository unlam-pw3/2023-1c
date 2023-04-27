using Clase3.MVC.Dominio.Entidades;
using Clase3.MVC.Dominio.Logica;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clase3.MVC.Web.Controllers
{
	public class PoderController : Controller
	{
		IPoderesRepositorio _poderesRepositorio;
		public PoderController(IPoderesRepositorio poderesRepositorio)
		{
			_poderesRepositorio = poderesRepositorio;
		}
		public IActionResult Index()
		{
			var poder = _poderesRepositorio.ObtenerTodos();
			return View(poder);
		}

		[HttpGet]
		public IActionResult Agregar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Agregar(Poder poder)
		{
			try
			{
				_poderesRepositorio.Agregar(poder);
			}
			catch (ArgumentException ex)
			{
				ViewBag.Mensaje = $"El nombre de poder {poder.Nombre} ya existe";
				return View(poder);
			}
			catch (Exception ex)
			{
				ViewBag.Mensaje = "No puede estar vacio el nombre del poder";
				return View(poder);
			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Eliminar(int id)
		{
			_poderesRepositorio.Eliminar(id);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Detalle(int? id)
		{
			var poderEncontrado = _poderesRepositorio.ObtenerPoder(id);
			return View(poderEncontrado);
		}

		[HttpGet]
		public IActionResult FormularioEditarPoder(int? id)
		{
			var poderEncontrado = _poderesRepositorio.ObtenerPoder(id);
			ViewBag.Mensaje = "El nombre de poder ya existe";
			return View(poderEncontrado);
		}

		[HttpPost]
		public IActionResult EditarPoder(Poder poder)
		{
			try
			{
				var poderExistente = _poderesRepositorio.ObtenerPoderPorNombre(poder.Nombre);
				if (poderExistente != null && poderExistente.Id != poder.Id)
				{
					ViewBag.Mensaje = "El nombre de poder ya existe";
					return View(poder);
				}
				else
				{
					// ViewBag.Mensaje = "Su edición se ha hecho correctamente";
					_poderesRepositorio.Editar(poder);
					return RedirectToAction("Index");
				}
			}
			catch (ArgumentException ex)
			{
				ViewBag.Mensaje = "El nombre de poder está vacío";
				return View(poder);
			}
			catch (Exception ex)
			{
				ViewBag.Mensaje = $"Error al editar el poder: {ex.Message}";
				return View(poder);
			}
		}
	}
}
