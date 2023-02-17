/// @author:georgy purtov
#ifndef RESISTANCE_H
#define RESISTANCE_H
const double e=0.00001; // число меньшее 0 которое нас не интересует при расчетах

#include <string>



using namespace std;

/// Класс Параллельное Сопротивление (электрическое)
class Resistance{
    float r1,r2,r3; // сопр 1, 2, 3
    float res; // параллельное сопротивление
public:
    Resistance(); // конструктор1
    Resistance(float x1, float x2, float x3); // конструктор 2
    void set_Res1(float x1); // сеттер r1
    void set_Res2(float x1); // setter r2
    void set_Res3(float x1); // setter r3
    float get_Res1()const; // getter r1
    float get_Res2()const; // getter r2
    float get_Res3()const; // getter r3
    double get_Res() const; // getter res параллелльное
    void calc_res(); // расчет
};

#endif // RESISTANCE_H
