#include <iostream>

struct date{
    unsigned short day;
    unsigned short month;
}

class BankDepos{
    float money;
    short lic, code, proc, //struct …

/// убрать short int (оставить short)
  public:
    BankDepos(){lic = 0,code=0,proc=0 ,money=0,date_m=1, date_d=1} // Лицевой счет       

    int getLicNum() const{  // все методы которые не меняют поля константные
        return lic;
    }

    void setLicNum(unsigned short x){  // прописать везде unsigned short кроме money 
        lic=x;
    }       

    int getClientCode()const{ 
        return code;
    }

    void setClientCode(unsigned short x){ 
        code=x;
        }

    int get_Proc()const{ 
        return proc;
    }

    void set_Proc(unsigned short x){ 
        proc=x;
    }

    int get_Date()const{ // вернем значение типа struct …
        
        return date_d;
        return date_m;
    }

    void set_Date(unsigned short x, unsigned short y){ 
        date.day=x;
        date.month=y;
    }

       

    int get_Money()const{ 
        return money;
    }

    void set_Money(unsigned float x){ 
        money=x;
        }

    float change(float money_c) {
        res=money+money_c;
        return res;
    } 

};


int main(int argc, char const *argv[])
{
  
}