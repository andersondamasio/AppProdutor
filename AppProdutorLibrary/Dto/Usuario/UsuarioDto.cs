using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace com.datacoper.appprodutor.Dto.Usuario
{
    public class UsuarioDto
    {
        public string username { get; set; }
        public string password { get; set; }

        public bool rememberMe { get; set; }

        public override string ToString()
        {
            return username;
        } 
    } 
}