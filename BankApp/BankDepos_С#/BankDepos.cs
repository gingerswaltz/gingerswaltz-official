/// <summary>
/// author: Georgy Purtov
/// </summary> 
namespace BankDeposit;
using System;


/// Класс описывающий банковский вклад
public class BankDepos 
{
    const double proc_eps = 10; // Чиселко точности для процентов, потому что проценты могут быть ниже 0
    const double eps = 0.01; // Чиселко точности для процентов, потому что проценты могут быть ниже 0
    private double _money; // Деньги
    private double _proc; // Проценты
    private uint _licnum; // Лицевой счет
    private uint _codenum; // Код клиента

    // Конструктор 1
    public BankDepos(double money, double proc, uint codenum, uint licnum)
    {
        setMoney(money);        
        setcodeNum(codenum);
        setProc(proc);
        setlicNum(licnum);  
    }
    
    // Конструктор 2
    public BankDepos()
    {
        _money = 1.0;
        _proc = 1.0;
        _codenum = 1111;
        _licnum = 2222;
        
    }

    // сеттер денег, входящее значение не меньше 1;
    public void setMoney(double value)
    {
        if (value < 0) 
            throw new ArgumentException("Too litle");
        else
       _money = value;
    }
    // геттер денег
    public double getMoney() { return _money; }

    // сеттер процентов. входящее значение не меньше 0.01 и не более 10
    public void setProc(double value)
    {
        if ((value < eps) || (value> proc_eps))               
            throw new ArgumentException("Wrong Procents");
        else 
            _proc = value;
    }
    // геттер процентов
    public double getProc() { return _proc; }

    // сеттер кода клиента. входящее значение не более 4 цифр
    public void setcodeNum(uint value)
    {
        if (value > 9999) throw new ArgumentException("Wrong Number");
        else 
            _codenum = value;
    }
    
    // геттер кода клиента
    public uint getcodeNum() { return _codenum; }

    // сеттер лицевого счета. входящее число не более 4 цифр
    public void setlicNum(uint value)
    {
        if (value > 9999) throw new ArgumentException("Wrong Number");
        else
            _licnum = value;
    }

    // геттер лицевого счета
    public uint getlicNum() { return _licnum; }
    

    // изменение суммы счета клиента
    public void MoneyChange(double value)
    {
        _money += value;        
    }


    // Вывод данных объекта, tostring наследован от System.Object 
    public override string ToString()
    {
        return $"Client license number: {_licnum}\n" +
            $"Client Code Number: {_codenum}\n" +
            $"Client procents: {_proc}%\n" +
            $"Client money deposit: {_money}$\n" +
            $"Client date of deposit: {DateTime.Now.Day} day, {DateTime.Now.Month} month, {DateTime.Now.Year} year\n";

    }

}
