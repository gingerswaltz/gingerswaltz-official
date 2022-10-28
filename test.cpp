#include "pch.h"
#include "..\BankDepos_project\Class.h"

TEST(BankDepos, get_Proc) {
	BankDepos test_Bank;
	EXPECT_EQ(test_Bank.get_Proc(), 1);
};

TEST(BankDepos, get_Date().day){
	BankDepos test_Bank;
	EXPECT_EQ(test_Bank.get_Date().day, 1);
}
