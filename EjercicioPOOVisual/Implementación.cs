using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPOOVisual
{

    class Implementación
    {
        private readonly static Implementación _instance = new Implementación();
        private List<Usuario> usuarios;
        private Usuario usuarioActual;
        Usuario usuarioTemp;
        int numCuentaActual;

        private Implementación()
        {
            usuarios = new List<Usuario>();

        }

        public void SetUsuarioTemp(Usuario us)
        {
            this.usuarioTemp = us;
        }

        public Usuario GetUsuarioTemp()
        {
            return usuarioTemp;
        }

        public void setNumCuenta(int cuenta)
        {
            this.numCuentaActual = cuenta;
        }

        public int getNumCuenta()
        {
            return numCuentaActual;
        }

        public static Implementación Instance
        {
            get
            {
                return _instance;
            }
        }      
        
        public void GuardarUsuarios()
        {
            String dir = Directory.GetCurrentDirectory();
            String serializationFile = Path.Combine(dir, "usuarios.bin");
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, usuarios);
            }

            //MessageBox.Show("Se ha guardado la última operación");
        }

        public Boolean EstaUsuario(int id)
        {
            foreach (Usuario item in usuarios)
            {
                if (id == item.GetId())
                {
                    usuarioActual = item;
                    return true;
                }                
            }
            return false;

        }

        public void addUsuario(Usuario usuario) 
        {
            if (EstaUsuario(usuario.GetId()))
            {
                throw new Exception(("Ya existe el usuario " + usuario.GetId()));                
            }
            else
            {
                usuarios.Add(usuario);
            }

            
        }

        public Usuario GetUsuarioActual()
        {
            return usuarioActual;
        }

        public void setUsuarioActual(Usuario us)
        {
            usuarioActual = us;
        }

        public List<Usuario> GetUsuarios()
        {
           return usuarios;
        }

        public void setUsuarios(List<Usuario> us)
        {
            this.usuarios = us;
        }
    }
}
