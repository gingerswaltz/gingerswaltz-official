using BankDeposit;
using System;
namespace BankDeposTests
{
    [TestClass]
    public class BankDeposTests
    {
        [TestMethod]
        public void testSetProc()
        {
            BankDepos bankDepos_test = new BankDepos();
                Assert.ThrowsException<ArgumentException>(() => bankDepos_test.setProc(15));
        }

        [TestMethod]
        public void testSetProc_good()
        {
            BankDepos bankDepos_test = new BankDepos();
            bankDepos_test.setProc(10);
            Assert.IsTrue(bankDepos_test.getProc()==10);
        }


        
        [TestMethod]
        public void testSetMoney()
        {
            BankDepos bankDepos_test = new BankDepos();
            Assert.ThrowsException<ArgumentException>(() => bankDepos_test.setMoney(-1));
        }

        public void testSetMoney_good()
        {
            BankDepos bankDepos_test = new BankDepos();
            bankDepos_test.setMoney(10);
            Assert.IsTrue(bankDepos_test.getMoney() == 10);
        }


       
        public void testSetCodeNum()
        {
            BankDepos bankDepos_test = new BankDepos();
            Assert.ThrowsException<ArgumentException>(() => bankDepos_test.setcodeNum(99999));
             
        }
        
        [TestMethod]
        public void testSetCodenum_good()
        {
            BankDepos bankDepos_test = new BankDepos();
            bankDepos_test.setcodeNum(1000);
            Assert.IsTrue(bankDepos_test.getcodeNum() == 1000);
        }
       
        [TestMethod]
        public void testSetLicNum()
        {
            BankDepos bankDepos_test = new BankDepos();

            Assert.ThrowsException<ArgumentException>(() => bankDepos_test.setlicNum(99999));
            
            BankDepos bankDepos = new BankDepos();
            bankDepos.setlicNum(1000);
            Assert.IsTrue(bankDepos.getlicNum() == 1000); // todo: объединить гуд и плохое
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
            string str = bankDepos.ToString();
            Assert.AreEqual(str, bankDepos1.ToString());

        }


    }


}