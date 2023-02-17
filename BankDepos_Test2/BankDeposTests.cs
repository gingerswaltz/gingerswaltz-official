using BankDeposit;
using System;
namespace BankDeposTests
{
    [TestClass]
    public class BankDeposTests
    {
       
        [TestMethod]
        public void testSet()
        {
            BankDepos bankDepos_bad1 = new BankDepos();

            Assert.ThrowsException<ArgumentException>(() => bankDepos_bad1.setlicNum(99999));


            BankDepos bankDepos_bad2 = new BankDepos();
            Assert.ThrowsException<ArgumentException>(() => bankDepos_bad2.setcodeNum(99999));


            BankDepos bankDepos_bad3 = new BankDepos();
            Assert.ThrowsException<ArgumentException>(() => bankDepos_bad3.setMoney(-1));



            BankDepos bankDepos_bad4 = new BankDepos();
            Assert.ThrowsException<ArgumentException>(() => bankDepos_bad4.setProc(15));


            BankDepos bankDepos2 = new BankDepos();
            bankDepos2.setlicNum(1000);
            Assert.IsTrue(bankDepos2.getlicNum() == 1000); 


            BankDepos bankDepos3 = new BankDepos();
            bankDepos3.setcodeNum(1000);
            Assert.IsTrue(bankDepos3.getcodeNum() == 1000);

            BankDepos bankDepos4 = new BankDepos();
            bankDepos4.setMoney(10);
            Assert.IsTrue(bankDepos4.getMoney() == 10);

            BankDepos bankDepos5 = new BankDepos();
            bankDepos5.setProc(10);
            Assert.IsTrue(bankDepos5.getProc() == 10);

        }
        
        
        [TestMethod]

        public void testCreateObject()
        {
            BankDepos bankDepos = new BankDepos(1,1,1111,2222);
            Assert.IsNotNull(bankDepos);
        }
        
        [TestMethod]
        public void testChangeMoney()
        {
            BankDepos bankDepos = new BankDepos();
            bankDepos.MoneyChange(-1);
            Assert.IsTrue(bankDepos.getMoney() == 0);
        }

        [TestMethod]

        public void testToString()
        {
            BankDepos bankDepos = new BankDepos(1111,1,111,111);
            BankDepos bankDepos1 = new BankDepos(1111, 1, 111, 111);
            string str = bankDepos.ToString(); // объект 1 в строку.
            Assert.AreEqual(str, bankDepos1.ToString()); // сравним 2 эквивалетных по данным объекта

        }


    }


}