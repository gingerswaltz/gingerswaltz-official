#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    form = new Form;
    form->show();

    /// Связь сигнала первого окна и слота второго окна
    connect(this, &MainWindow::signal, form, &Form::slot);
    /// Связь сигнала второго окна и слота первого окна
    connect(form, &Form::signalForm, this, &MainWindow::slotForm);
    /// Связь сигнала и слота внутри окна
    connect(this, &MainWindow::changeColor, this, &MainWindow::onChangeColor);


}

QColor MainWindow::getRandomColor()
{
    // Инициализируем генератор случайных чисел
    srand(time(nullptr));

    // Получаем случайный цвет
    QColor color(rand() % 256, rand() % 256, rand() % 256);

    // Возвращаем случайный цвет
    return color;
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::onChangeColor()
{
    // Инициализируем генератор случайных чисел
    srand(time(nullptr));

    // Получаем случайный цвет
    QColor color(rand() % 256, rand() % 256, rand() % 256);

    // Устанавливаем новый цвет формы
    this->setStyleSheet(QString("background-color: %1").arg(color.name()));
}


// событие нажатия кнопки
void MainWindow::on_pushButton_clicked()
{
    emit signal(ui->lineEdit->text());
    // Вызываем новый сигнал "changeColor()"
        emit changeColor();
}

// слот
void MainWindow::slotForm(QString a)
{
    ui->label->setText(a); // получаем строку из другого окна
}

