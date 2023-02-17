/// @author: Georgy Purtov
/// Защита от повторного подключения
#ifndef MAINWINDOW_H
#define MAINWINDOW_H
#include <QMainWindow>
#include "Resistance.h"
#include <QStatusBar>

QT_BEGIN_NAMESPACE
/// Определим ui класс заранее, чтобы визуальное редактирование
/// не привело к крупным рекомпиляциям
namespace Ui { class MainWindow; }
QT_END_NAMESPACE
/// Класс формы
class MainWindow : public QMainWindow
{
    /// Макрос который добавляет файл в компиляцию MOC
    Q_OBJECT

public:
    /// Конструктор и деструктор
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

    /// Слоты - фишка QT , которая обрабатывается MOC
private slots:

    void on_actionCredits_triggered();

    void on_actionClear_Plain_Text_Bar_triggered();

    void on_pushButton_calc_clicked();

private:
    /// Указатель на UI, для него в QT есть программа UIC
    Ui::MainWindow *ui;
    Resistance resist_obj;

};
#endif // MAINWINDOW_H
