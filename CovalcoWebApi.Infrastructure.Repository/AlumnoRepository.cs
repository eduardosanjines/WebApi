using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovalcoWebApi.Infrastructure.Repository
{
    public class AlumnoRepository
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Dni { get; set; }
    }
}
