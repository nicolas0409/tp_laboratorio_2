using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
    public  static class  GuardarString
    {
        
        
       public  static bool Guardar(this string texto,string archivo)
        {

            StreamWriter streamGuardar = null;
            
            bool flag = false;


            try
            {
                archivo=string.Format(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + '\\' + archivo);
                    streamGuardar = new StreamWriter(archivo ,true);

                    streamGuardar.Write(texto);
                    flag = true;
                
            }
            catch (Exception e)
            {
                throw new DirectoryNotFoundException ("Archivo no se pudo guardar", e);
            }
            finally
            {
                if (streamGuardar != null)
                { streamGuardar.Close(); }

            }
            return flag;
        }

    }
}
