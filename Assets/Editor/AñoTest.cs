using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class AñoTest {
 
    [Test]
	public void AñoTestSimplePasses()
    {
        // Arrange

        Año test = new Año();
        

        //Act
       bool esBisiesto= test.esBisiesto(5000);

        //Assert
        Assert.AreEqual(false, esBisiesto);
	}
        [Test]
	public void TestSimplePasses1984()
    {
        // Arrange

        Año test = new Año();
        

        //Act
       bool esBisiesto= test.esBisiesto(1984);

        //Assert
        Assert.AreEqual(true, esBisiesto);
	}

    [Test]
    public void Given1884ShouldPassIsleap()
    {
        // Arrange

        Año test = new Año();


        //Act
        bool esBisiesto = test.esBisiesto(1884);

        //Assert
        Assert.AreEqual(true, esBisiesto);
    }
    [Test]
    public void CheckIfIsDivisibleBy100()
    {
        // Arrange

        Año test = new Año();


        //Act

        bool esBisiesto = test.esBisiesto(500);

        //Assert
        Assert.AreEqual(false, esBisiesto);
    }
    [Test]
    public void CheckIfIsDivisibleBy400IsLeap()
    {
        // Arrange

        Año test = new Año();


        //Act
        bool esBisiesto = test.esBisiesto(400);

        //Assert
        Assert.AreEqual(true, esBisiesto);
    }
    [Test]
    public void Given800ShouldPassIsleap()
    {
        // Arrange

        Año test = new Año();


        //Act
        bool esBisiesto = test.esBisiesto(800);

        //Assert
        Assert.AreEqual(true, esBisiesto);
    }

    [Test]
    public void Given1600ShouldPassIsleap()
    {
        // Arrange

        Año test = new Año();


        //Act
        bool esBisiesto = test.esBisiesto(1600);

        //Assert
        Assert.AreEqual(true, esBisiesto);
    }


    [Test]
    public void Given2011ShouldntPassIsntleap()
    {
        // Arrange

        Año test = new Año();


        //Act
        bool esBisiesto = test.esBisiesto(2011);

        //Assert
        Assert.AreEqual(false, esBisiesto);
    }
}
