/// @author:georgy purtov

#include "Resistance.h"
#include "exception"
using namespace std;

Resistance::Resistance(){
this->r1=0;
this->r2=0;
this->r3=0;
this->res=0;
};


Resistance::Resistance(float x1, float x2, float x3){
set_Res(x1,x2,x3);
calc_res();

};
void Resistance::calc_res(){

   double n=(r1 * r2 * r3)/(r1 * r2 + r2 * r3 + r3 * r1); // по формуле из интернета.
set_paralRes(n);
}


double Resistance::get_Res() const{
    return res;
}

void Resistance::set_paralRes(float n){
    this->res=n;
}
void Resistance::set_Res(float x1, float x2, float x3){
    if ((x1<e) or (x2<e) or (x3<e)) throw std::invalid_argument("Error");
    r1=x1;
    r2=x2;
    r3=x3;

}
