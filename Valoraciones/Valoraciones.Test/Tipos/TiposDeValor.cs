﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test.Tipos
{
    [TestClass]
    public class TiposDeValor
    {
        /*
            Variables de tipo valor
        */
         int x;
         float y;
         double z;
         string cadena;
        

        [TestMethod]
        public void VariableTiposDeValor()
        {
            int x1 = 10;
            int x2 = x1;
            Assert.AreEqual(x1, x2);
        }

    }

}
