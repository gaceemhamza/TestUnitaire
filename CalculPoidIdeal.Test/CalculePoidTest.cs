using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace CalculPoidIdeal.Test
{
    [TestClass]
    public class CalculePoidTest
    {
       // [TestMethod]
        //public void GetPoidIdeal_SexeM_And_Taille_180_return_72_5()
        //{

        //    //Arrange
        //    CalculePoid Poid = new CalculePoid
        //    {
        //        Taille = 180,
        //        Sexe = 'm'
        //    };
        //    // Act
        //    double actual= Poid.GetPoidIdeal();
        //    double expected = 72.5;

        //    //Assert

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void GetPoidIdeal_SexeF_And_Taille_180_return_65()
        //{

        //    //Arrange
        //    CalculePoid Poid = new CalculePoid
        //    {
        //        Taille = 180,
        //        Sexe = 'f'
        //    };
        //    // Act
        //    double actual = Poid.GetPoidIdeal();
        //    double expected = 65;

        //    //Assert

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void GetPoidIdeal_SexeR_And_Taille_180_return_0()
        //{

        //    //Arrange
        //    CalculePoid Poid = new CalculePoid
        //    {
        //        Taille = 180,
        //        Sexe = 'R'
        //    };
        //    // Act
        //    double actual = Poid.GetPoidIdeal();
        //    double expected = 0;

        //    //Assert

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Assert_test()
        //{
        //    CalculePoid Poid = new CalculePoid();
        //    //CalculePoid Poid1 = Poid;
        //    //Assert.AreSame(Poid, Poid1);
        //    Assert.IsInstanceOfType(Poid,  typeof(CalculePoid));
           
        //}
        //[TestMethod]
        //public void StringAssert_test()
        //{
        //    string nom = "hamza";

            
        //    //StringAssert.Contains(nom, "ha");
        //    nom.Should().Contain("ha");


        //}

        [TestMethod]
        public void FluentTest()
        {
            //string nom = "hamza";

            //nom.Should().StartWith("ha");

            //int number = 10; 

            //number.Should().BeOfType(typeof(int));
            //List<string> name = new List<string>() { "h", "g" };
            List<int> x = new List<int>() { 5, 7};
            x.Should().Equal(5, 7);






        }



        //[TestMethod]
        //public void Collection_Assert_test()
        //{
        //    List<string> Nom = new List<string>() { "hamza", "ali", "reda" };

        //    CollectionAssert.AllItemsAreNotNull(Nom);
        //    CollectionAssert.DoesNotContain(Nom, "kha");
        //    CollectionAssert.AllItemsAreInstancesOfType(Nom, typeof(string) );





        //}

        [TestMethod]
        public void GetPoidIdestFromDataSource_WithGoodInput_Return_Correct_Resultas()
        {
            CalculePoid P = new CalculePoid(new FakePoidRepo());
            List<double> actual = P.GetPoidFromDataSource();
            double[] expected = { 62.5, 62.75, 74 };
            CollectionAssert.AreEqual(expected, actual);
        }




        [TestMethod]
        public void GetPoidIdestFromDataSource_usin_moq()
        {
            List<CalculePoid> calculePoids = new List<CalculePoid>();
            {
                new CalculePoid { Taille = 175, Sexe = 'f' }, //62.5
                new CalculePoid { Taille = 167, Sexe = 'm' },  //62.75
            };

            Mock<IDataRepo> poid = new Mock<IDataRepo>();
            poid.Setup(w => w.GetWeight()).Returns(calculePoids);
           
        }
    }
}
