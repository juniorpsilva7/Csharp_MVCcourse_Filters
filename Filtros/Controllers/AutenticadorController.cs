using Filtros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Filtros.Controllers
{
    public class AutenticadorController : Controller
    {
        //
        // GET: /Autenticador/

        public ActionResult Formulario()
        {
            return View();
        }

        public ActionResult Entrar(Usuario usuario) 
        { 
            if (usuario.Username != null && usuario.Password != null && 
                usuario.Username.Equals("K19") && usuario.Password.Equals("K19"))
            {
                //Session["Usuario"] = usuario;
                FormsAuthentication.SetAuthCookie(usuario.Username, false);
                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Mensagem = "Usuário  ou Senha incorreta!";
                return View("Formulario");
            }
        }

        public ActionResult Sair()
        {
            //Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Formulario");
        }




    }
}
