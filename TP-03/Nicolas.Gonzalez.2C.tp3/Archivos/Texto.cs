﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string  datos)
        {
            StreamWriter streamGuardar = null;
            bool flag = false;


            try
            {
             
            streamGuardar = new StreamWriter(archivo);
            streamGuardar.Write(datos);
            flag= true;
            }
            catch(Exception e )
            {
                throw new ArchivosException("Archivo no se pudo guardar", e);
            }
            finally
            {   if(streamGuardar!=null)
                { streamGuardar.Close(); }
                
            }
            return flag;
}

        public  bool Leer(string archivo,out string datos)
        {
            datos = default(string);
            StreamReader streamLectura=null;
            bool flag = false;
            try
            {
                streamLectura = new StreamReader(archivo);
                datos = streamLectura.ReadToEnd();
                flag= true;
             }
            catch (Exception e)
            {

                throw new ArchivosException("El archivo no se pudo leer", e);
            }
            finally
            {
                if(streamLectura!=null)
                { streamLectura.Close(); }
                
            }
            return flag;
           
        }
    }
}
