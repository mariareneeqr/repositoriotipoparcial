using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tipoparcial.Controllers;
using tipoparcial.Models;

namespace tipoparcial.Tests
{
    [TestClass]
    public class UnitTestAmigo
    {
        [TestMethod]
        public void TestMethodGetAmigoes()
        {
            //arange
            AmigoesController amigocontroller= new AmigoesController();          //asignacion del proceso 

            //act
            var amigoes= amigocontroller.GetAmigoes();// var adopta el obtejo que te envie el Amigoes controller(arreglo o lista de amigos)

            //assert                  
            Assert.IsNotNull(amigoes);

        }

        [TestMethod]
        public void TestMethodPostAmigo(Amigo amigo)
        {
            //arange
            AmigoesController amigocontroller = new AmigoesController();
            Amigo amigo = new Amigo();
            amigo.Name = "Diego";
            amigo.List = 0;
            amigo.Birthday = 5;

            //act
            var amigoes = amigocontroller.PostAmigo(amigo);

            //assert                  
            Assert.IsNotNull(amigoes);







        }
    }
 }
