using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        ///  metodo  abstracto por defecto para guardar  un archivo
      
        /// </summary>
        /// <param name="archivo">ruta  y/o nobre del archivo</param>
        /// <param name="datos">datos a guardar en el archivo</param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// funcion abstracta por defecto para leer un archivo 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool  Leer(string archivo, out T datos);

    }
}
