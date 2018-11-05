using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        #region "metodos"
        public bool Guardar(string archivo, T datos)
        {
            XmlSerializer serializer;
            XmlTextWriter write= null;
            bool flag = false;

            
            try
            {
                write = new XmlTextWriter(archivo, Encoding.UTF8);
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(write, datos);
                flag= true;
            }
            catch(Exception e)
            {
                throw new ArchivosException("Archivo no se pudo guardar", e);

            }
            finally
            {
                if(!(write==null))
                {
                    write.Close();
                }

            }
            return flag;  
           
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlSerializer serializer;
            XmlTextReader reader=null;
            datos = default(T);
            bool flag = false;
            try
            {

                reader = new XmlTextReader(archivo);
                serializer = new XmlSerializer(typeof(T));

                datos=(T)serializer.Deserialize(reader);
                flag= true;
            }
            catch(Exception e )
            {
                throw new ArchivosException("Archivo no se pudo leer", e);
            }
            finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }
                
            }
            return flag;



        }
        #endregion
        #region "constructores"
        public Xml()
        {

        }
        #endregion
    }
}
