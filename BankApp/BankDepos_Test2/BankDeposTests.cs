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


            

            /// Инициализируем пример строки из ToString() с заведомо рабочими значениями
            string str = "Client license number: 111\n" +
            $"Client Code Number: 111\n" +
            $"Client procents: 1%\n" +
            $"Client money deposit: 1111$\n" +
            $"Client date of deposit: {DateTime.Now.Day} day, {DateTime.Now.Month} month, {DateTime.Now.Year} year\n";


            // Если вдруг ToString() потеряет данные полей, я отслежу это
            Assert.AreEqual(str, bankDepos.ToString());
            
            BankDepos bankDepos1 = new BankDepos(2222, 2, 222, 222);

            /// Инициализируем пример строки из ToString() с заведомо рабочими значениями
            string str1 = "Client license number: 222\n" +
            $"Client Code Number: 222\n" +
            $"Client procents: 2%\n" +
            $"Client money deposit: 2222$\n" +
            $"Client date of deposit: {DateTime.Now.Day} day, {DateTime.Now.Month} month, {DateTime.Now.Year} year\n";


            // Если вдруг ToString() потеряет данные полей, я отслежу это
            Assert.AreEqual(str1, bankDepos1.ToString());



            BankDepos bankDepos2 = new BankDepos(3333, 3, 333, 333); //

            /// Инициализируем пример строки из ToString() с заведомо рабочими значениями
            string str2 = "Client license number: 333\n" +
            $"Client Code Number: 333\n" +
            $"Client procents: 3%\n" +
            $"Client money deposit: 3333$\n" +
            $"Client date of deposit: {DateTime.Now.Day} day, {DateTime.Now.Month} month, {DateTime.Now.Year} year\n";


            // Если вдруг ToString() потеряет данные полей, я отслежу это
            Assert.AreEqual(str2, bankDepos2.ToString());

        }


    }


}