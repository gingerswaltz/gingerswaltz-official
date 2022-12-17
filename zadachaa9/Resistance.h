/// @author:georgy purtov
#ifndef RESISTANCE_H
#define RESISTANCE_H
#include <QString>
#include "mainwindow.h"
#include "ui_mainwindow.h"
using namespace std;
class Resistance{
    float r1,r2,r3;
    float res;
public:
    Resistance();
    Resistance(float x1, float x2, float x3);
    void set_Res(float x1, float x2, float x3);
    float get_Res() const;
    void calc_res();
    void set_paralRes(float n);
};

#endif // RESISTANCE_H
