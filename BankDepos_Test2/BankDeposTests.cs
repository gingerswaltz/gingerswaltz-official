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

            /// Геттерами получим значение полей (вероятность ошибки низка, геттеры просты)
            var _licnum = bankDepos.getlicNum();
            var _codenum = bankDepos.getcodeNum();
            var _proc=bankDepos.getProc();
            var _money = bankDepos.getMoney();
            

            /// Инициализируем пример строки из ToString() с заведомо рабочими значениями
            string str = $"Client license number: {_licnum}\n" +
            $"Client Code Number: {_codenum}\n" +
            $"Client procents: {_proc}%\n" +
            $"Client money deposit: {_money}$\n" +
            $"Client date of deposit: {DateTime.Now.Day} day, {DateTime.Now.Month} month, {DateTime.Now.Year} year\n";


            // Если вдруг ToString() потеряет данные полей, я отслежу это. Геттеры менее подвержены ошибкам благодаря своей простоте
            Assert.AreEqual(str, bankDepos.ToString()); 

        }


    }


}