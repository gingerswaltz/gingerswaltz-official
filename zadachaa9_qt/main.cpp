/// @author: Georgy Purtov
#include "mainwindow.h"
#include <QApplication>
/// Main Program
int main(int argc, char *argv[])
{
   /// Класс QApplication руководит логикой UI и основными настройками
    QApplication a(argc, argv);
    /// Класс окна
    MainWindow w;
    /// Показывает окно
    w.show();
   /// Входит в осн. цикл обработки событий и ждет пока не будет вызван метод
   /// exit, а затем возвращает значение, установленное для метода exit()  (которое равно false,
   /// если метод вызывается через quit()
   /// Главный цикл находится внутри exec

    return a.exec();
}
