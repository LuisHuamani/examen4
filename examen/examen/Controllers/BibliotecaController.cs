using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace examen.Controllers
{
    public class BibliotecaController : Controller
    {
        #region Contexto

        private BibliotecaEntities _contexto;

        public BibliotecaEntities contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new BibliotecaEntities();
                return _contexto;
            }
        }

        // GET: Biblioteca
        public ActionResult Index()
        {
            return View();
        }
    }
}