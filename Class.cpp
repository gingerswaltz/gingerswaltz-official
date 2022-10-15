#include <iostream>
class BankVklad{
    float money, money_c;
    short int lic, code, proc, date_d, date_m;
/// todo: определить длину кода, процентов, лиц счета. ограничить длину
  
  public:
    Lic(){ vklad = 0} // Лицевой счет

    Lic(){ // if () 
       

    int get(){ 
        return lic;
    }

    void set(short int x){ 
        if (x=" ") throw invalid_argument("License is empty!")
        lic=x;
        }

    Code(){ code = 0} // Код клиента

    Code(){ 
       

    int get(){ 
        return code;
    }

    void set(short int x){ 
        if (x=" ") throw invalid_argument("Code is empty!")
        code=x;
        }

    
    Proc(){ proc = 0} // Проценты

    Proc(){ // if () 
       

    int get(){ 
        return proc;
    }

    void set(short int x){ 
        if (x=" ") throw invalid_argument("Procents is empty!")
        proc=x;
        }

    Date(){ date_d = 1, date_m=1} // Проценты

    Date(){ // if () 
       

    int get(){ 
        return date_d;
        return date_m;
    }

    void set(short int x, short int y){ 
        if ((x=" ") or (y=" ")) throw invalid_argument("Date is empty!")
        date_d=x;
        date_m=y;
        }


    Money(){ money = 0} // Вклад

    Money(){ // if () 
       

    int get(){ 
        return money;
    }

    void set(short int x){ 
        if (x=" ") throw invalid_argument("Money is empty!")
        money=x;
        }

    float change(float money1,float money_c) {
        if (money1=" ") throw invalid_argument("Money is empty!")
        if (money_c=" ") throw invalid_argument("Money changing is empty!")
        money1+=money_c;
        res=money1;
        return res;
    } 

};


int main(int argc, char const *argv[])
{
    //*Array a(10);
    a.set(5, 123); 
    float x = a.get(5);
    a.print();*//  

    return 0;
}