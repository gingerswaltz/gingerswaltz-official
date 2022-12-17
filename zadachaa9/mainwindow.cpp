/// @author:georgy purtov

#include <QString>
#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "Resistance.h" // модуль с моей функцией
#include <QMessageBox>

using namespace std;
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

}

MainWindow::~MainWindow()
{
    delete ui;
}


void MainWindow::on_pushButton_clicked()
{
   QString str;
   try {
       str=ui->lineEdit->text(); // получаем значение
       x1=str.toFloat(); // конвертируем в вещественное число для передачи в функцию
       str=ui->lineEdit_2->text();
       x2=str.toFloat();
       str=ui->lineEdit_3->text();
       x3=str.toFloat();
        Resistance resist(x1,x2,x3);
       ui->plainTextEdit->appendPlainText("Result="+QString::number(resist.get_Res()+'\n'));
       ui->statusbar->showMessage("OK");
   }  catch (invalid_argument &e) {
       ui->statusbar->showMessage("UNDER 0");


   }

}


void MainWindow::on_actionCredits_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowTitle("Author");
    msgBox.setText("Georgy Purtov 2022");
    msgBox.exec();
}

