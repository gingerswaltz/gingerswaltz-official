/// @author:georgy purtov

#include "Resistance.h"
#include "exception"
using namespace std;

Resistance::Resistance(){
this->r1=1;
this->r2=1;
this->r3=1;
this->res=0.33;
};


Resistance::Resistance(float x1, float x2, float x3){
set_Res1(x1);
set_Res2(x2);
set_Res3(x3);
calc_res();

};
void Resistance::calc_res(){

    res=(r1 * r2 * r3)/(r1 * r2 + r2 * r3 + r3 * r1); // по формуле из интернета.
}


double Resistance::get_Res() const{
    return res;
}

float Resistance::get_Res1()const {return r1;}; // getter r1

float Resistance::get_Res2()const{return r2;}; // getter r2
float Resistance::get_Res3()const{return r3;}; // getter r3

void Resistance::set_Res1(float x1){
   if (x1<e)  throw std::invalid_argument("Error");
   else
    r1=x1;
}

void Resistance::set_Res2(float x2){
    if (x2<e) throw std::invalid_argument("Error"); else
        r2=x2;}
void Resistance::set_Res3(float x3){if (x3<e) throw std::invalid_argument("Error"); else r3=x3;}
