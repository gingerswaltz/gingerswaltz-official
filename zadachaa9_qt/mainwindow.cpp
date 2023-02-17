/// @author:georgy purtov

#include <QString> // библиотека строк
#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "Resistance.h" // модуль с моей функцией
#include <QMessageBox> // библиотека мессаг

using namespace std;
/// Конструктор
MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->plainTextOutput->setStyleSheet("background-color: white");
    ui->lineEdit_r1->setStyleSheet("background-color: white");
     ui->lineEdit_r2->setStyleSheet("background-color: white");
     ui->lineEdit_r3->setStyleSheet("background-color: white");
}
/// Деструктор
MainWindow::~MainWindow()
{
    delete ui;
}



void MainWindow::on_actionCredits_triggered()
{
    QMessageBox msgBox;
    msgBox.setWindowTitle("Author");
    msgBox.setText("Georgy Purtov 2022");
    msgBox.exec();
}


void MainWindow::on_actionClear_Plain_Text_Bar_triggered()
{
    ui->plainTextOutput->clear();
}


void MainWindow::on_pushButton_calc_clicked()
{
    QString str;
    float r1,r2,r3;

    /// пробуем наш код и ловим исключения
    try {
       /// Выкрасим в белый наши поля, чтобы исправить красный цвет ошибки
        ui->lineEdit_r1->setStyleSheet("background-color: white");
         ui->lineEdit_r2->setStyleSheet("background-color: white");
         ui->lineEdit_r3->setStyleSheet("background-color: white");
        str=ui->lineEdit_r1->text(); // получаем значение
        r1=str.toFloat(); // конвертируем в вещественное число для передачи в функцию
        str=ui->lineEdit_r2->text();
        r2=str.toFloat();
        str=ui->lineEdit_r3->text();
        r3=str.toFloat();
        resist_obj.set_Res1(r1);
        resist_obj.set_Res2(r2);
        resist_obj.set_Res3(r3);

        resist_obj.calc_res();
        /// добавим результат вычислений
         ui->plainTextOutput->appendPlainText("Result="+QString::number(resist_obj.get_Res(),'g',3)+" Ohm");
        /// добавим в статус бар что все хорошо
        ui->statusbar->showMessage("OK");
    }  catch (invalid_argument &err) {
        /// окрасим эдиты

        if (ui->lineEdit_r1->text().toFloat()<=e) {ui->lineEdit_r1->setStyleSheet("background-color: #F08080");};

        if (ui->lineEdit_r2->text().toFloat()<=e) {ui->lineEdit_r2->setStyleSheet("background-color: #F08080");};

       if (ui->lineEdit_r3->text().toFloat()<=e) {ui->lineEdit_r3->setStyleSheet("background-color: #F08080");};


        /// словим исключение и напишем что неверно введены данные
        ui->statusbar->showMessage("ERROR INPUT");

    }

}

