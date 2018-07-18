using Microsoft.VisualStudio.TestTools.UnitTesting;
using CovalcoWebAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using CovalcoWebAPI.Models;
using System.Web.Http.Results;

namespace CovalcoWebAPI.Controllers.Tests
{
    [TestClass()]
    public class AlumnoesControllerTests
    {
        [TestMethod()]
        public void GetAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IQueryable<Alumno> alumnos = controller.GetAlumno();
            Assert.IsTrue(alumnos.Count<Alumno>() > 0);

        }

        [TestMethod()]
        public void GetAlumnoTest1()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionResult = controller.GetAlumno(1);

            var contenResult = actionResult as OkNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(contenResult);
            Assert.IsNotNull(contenResult.Content);
            Assert.IsNotNull(contenResult.Content.Id);
        }

        [TestMethod()]
        public void PutAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionResult = controller.PutAlumno(1, new Alumno
            {
                Id = 1,
                Nombre = "Ferran",
                Apellidos = "Ferrer",
                Dni = "2345454E"
            });

            Assert.IsNotNull(actionResult);

        }

        [TestMethod()]
        public void PostAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionResult = controller.PostAlumno(new Alumno
            {
                Nombre = "Ferran",
                Apellidos = "Ferrer",
                Dni = "23927012C"
            });

            var contentResult = actionResult as CreatedAtRouteNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(actionResult);
            Assert.IsTrue(contentResult.RouteName == "DefaultApi");
        }

        [TestMethod()]
        public void DeleteAlumnoTest()
        {
            AlumnoesController controller = new AlumnoesController();
            IHttpActionResult actionResult = controller.PostAlumno(new Alumno
            {
                Nombre = "Ferran",
                Apellidos = "Ferrer",
                Dni = "23927012C"
            });

            var contentResult = actionResult as CreatedAtRouteNegotiatedContentResult<Alumno>;

            IHttpActionResult actionDeleteResult = controller.DeleteAlumno(contentResult.Content.Id);

            var contentDeleteResult = actionDeleteResult as OkNegotiatedContentResult<Alumno>;
            Assert.IsNotNull(contentDeleteResult);
            Assert.IsNotNull(contentDeleteResult.Content);

        }
    }
}