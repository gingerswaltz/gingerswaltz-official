/// @author:georgy purtov

#include "Resistance.h"
#include "exception"
using namespace std;

Resistance::Resistance(){
this->r1=1;
this->r2=1;
this->r3=1;
this->res=12;
};


Resistance::Resistance(float x1, float x2, float x3){
set_Res(x1,x2,x3);
calc_res();

};
void Resistance::calc_res(){

   float n=(r1*r2*r3)/((r1*r2)+(r2*r3)+(r1*r3)); // по формуле из интернета.
set_paralRes(n);
}


float Resistance::get_Res() const{
    return res;
}

void Resistance::set_paralRes(float n){
    this->res=n;
}
void Resistance::set_Res(float x1, float x2, float x3){
    if ((x1<1) or (x2<1) or (x3<1)) throw std::invalid_argument("Error");
    r1=x1;
    r2=x2;
    r3=x3;

}
