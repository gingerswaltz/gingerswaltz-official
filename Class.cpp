#include <iostream>

struct date{
    unsigned short day=1;
    unsigned short month=1;
};

class BankDepos{
    float money;
    short lic, code, proc; //struct …
    date date_Depos;
/// убрать short int (оставить short)
  public:
    BankDepos(){lic = 0,code=0,proc=0 ,money=0, date_Depos.month=1, date_Depos.day=1;} // Лицевой счет       

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
        
        return date_Depos.day;
        return date_Depos.month;
    }

    void set_Date(unsigned short x, unsigned short y){ 
        date_Depos.day=x;
        date_Depos.month=y;
    }

       

    int get_Money()const{ 
        return money;
    }

    void set_Money(float x){ 
        money=x;
        }

    float change(float money_c) {
        float res=money+money_c;
        return res;
    } 

};


int main(int argc, char const *argv[])
{
  BankDepos deposit;
  int x=0;
  std::cout<<"Input client lic number\n";
  std::cin>>x;
  deposit.setLicNum(x);
  int b=deposit.getLicNum();
  std::cout<<"Lic number: "<<deposit.getLicNum()<<'\n';
}