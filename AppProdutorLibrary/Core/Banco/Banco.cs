using com.datacoper.appprodutor.Dto.Usuario;
using SQLite;
using System;
using System.Linq;

namespace com.datacoper.appprodutor.Core.Banco
{
    public class Banco
    {
        public static string CreateDatabase(string path)
        {
            try
            {
                var db = new SQLiteConnection(path); 
                db.CreateTable<UsuarioDto>(CreateFlags.AllImplicit | CreateFlags.AutoIncPK);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static string CreateTable<T>(string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                db.CreateTable<T>(CreateFlags.AllImplicit | CreateFlags.AutoIncPK);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string InsertUpdateUsuario(UsuarioDto usuarioDto, string path)
        {
            try
            {
                var db = new SQLiteConnection(path);
                if (db.Insert(usuarioDto) != 0)
                    db.Update(usuarioDto);
                return "OK";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

       public static string UpdateUsuario(UsuarioDto usuarioDto, string path)
       {
           try
           {
               var db = new SQLiteConnection(path);
              db.Update(usuarioDto);
               return "OK";
           }
           catch (SQLiteException ex)
           {
               return ex.Message;
           }
       }

        public static UsuarioDto SelectUsuario(string path)
       {
           try
           {
               var db = new SQLiteConnection(path);
               UsuarioDto usuarioDto = db.Query<UsuarioDto>("SELECT * FROM [UsuarioDto]").FirstOrDefault();
               return usuarioDto;
           }
           catch (SQLiteException)
           {
               return null;
           }
       }
    }
}
