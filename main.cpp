#include "Class.h"
#include <iostream>
using namespace std;
int main(int argc, char const* argv[])
{
    BankDepos deposit;
    auto y = 0;
    auto x=0.0;
    std::cout << "Input client lic number\n";
    cin >> x;
    deposit.setLicNum(x);
    std::cout << "Input client code number\n";
    cin >> x;
    deposit.setClientCode(x);
    std::cout << "Input client procent number\n";
    cin >> x;
    x=0;
    deposit.set_Proc(x);
    std::cout << "Input client deposit money number\n";
    cin >> x;
    deposit.set_Money(x);
    x=0;
    std::cout << "Input deposit day and month number\n";
    cin >> x>>y;
    deposit.set_Date(x,y);
    cout << "Client data: \n" << deposit.toString() << '\n';

}
