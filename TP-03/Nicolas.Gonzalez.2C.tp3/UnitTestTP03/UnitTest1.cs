using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using Excepciones;
using Archivos;
namespace UnitTestTP03
{
    [TestClass]
    public class UnitTest1
    {
       
       
        

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestMethod1()
        {
            //arrange
            //act
            Alumno a = new Alumno(1, "nicolas", "gonzalez", "12344543", EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);

            //asert lo maneja expectedexception
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestMethod2()
        {
            //arrange
            //act
            Alumno a = new Alumno(1, "nicolas", "gonzalez", "1234434543", EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);

            //asert lo maneja expectedexception
        }
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestMethod3()
        {
            //arrange
            string ruta;
            Alumno a = new Alumno(1, "nicolas", "gonzalez", "12344543", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            //act

            Archivos.Texto texto = new Archivos.Texto();
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            texto.Guardar(ruta, a.ToString());

            //asert lo maneja expectedexception
        }


        [TestMethod]
        public void TestMethod4()
        {
            //arrangue
            Alumno a = new Alumno(1, "nicolas", "gonzalez", "12344543", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            int num;
            //act

            //assert
            Assert.IsTrue(a.Dni>=1&& a.Dni<= 99999999,"valor numerico fuera de rango");




        }
        [TestMethod]
        public void TestMethodAlumnoNotNull()
        {
            //arrange
            Alumno alumno = new Alumno();
            //act
            Assert.IsNotNull(alumno, "alumno nulo");
            Assert.IsNotNull(alumno.Apellido, "Apellido nulo");
            Assert.IsNotNull(alumno.Dni, "Dni nulo");
            Assert.IsNotNull(alumno.Nacionalidad, "Nacionalidad nulo");
            Assert.IsNotNull(alumno.Nombre, "Nombre nulo");
           


        }
        [TestMethod]
        public void TestMethodProfesorNull()
        {

            Profesor profesor = new Profesor();

            Assert.IsNotNull(profesor, "profesor nulo");
            Assert.IsNotNull(profesor.Apellido, "profesor nulo");
            Assert.IsNotNull(profesor.Dni, "profesor nulo");
            Assert.IsNotNull(profesor.Nacionalidad, "profesor nulo");
            Assert.IsNotNull(profesor.Nombre, "profesor nulo");
           

        }
        [TestMethod]
        public void TestMethodUniversidadNull()
        {
            Universidad universidad = new Universidad();
            Assert.IsNotNull(universidad, "universidad nula");
            Assert.IsNotNull(universidad.Alumnos, "alumnos nulo");
            Assert.IsNotNull(universidad.Jornada, "jornada nula");
            Assert.IsNotNull(universidad.Profersores, "profesores nulo");


        }
        [TestMethod]
        public void TestMethodJornadaNotNull()
        {
            Profesor profesor = new Profesor();
            Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);

            Assert.IsNotNull(jornada, "jornada nula");
            Assert.IsNotNull(jornada.Alumnos, "Alumnos nulo");
            Assert.IsNotNull(jornada.Clase, "Clase nula");
            Assert.IsNotNull(jornada.Instructor, "Instructor nulo");

        }
    }
}
