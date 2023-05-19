#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <form.h>
#include <cstdlib>
#include <ctime>
QT_BEGIN_NAMESPACE
namespace Ui { class MainWindow; }
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private:
    Ui::MainWindow *ui;
    Form *form;
    QColor getRandomColor();

private slots:
    void on_pushButton_clicked();
    void onChangeColor();

signals:
    void signal(QString);
    void changeColor();

public slots:
    void slotForm(QString a);
};
#endif // MAINWINDOW_H
