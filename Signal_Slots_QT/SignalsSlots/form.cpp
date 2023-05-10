#include "form.h"
#include "ui_form.h"


Form::Form(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Form)
{
    ui->setupUi(this);
    /// Связь сигнала и слота внутри окна
    connect(this, &Form::changeColor, this, &Form::onChangeColor);

}

Form::~Form()
{
    delete ui;
}

///Слот у второй формы
void Form::slot(QString a)
{
    ui->label->setText(a); // ловим текст с другого окна
}

/// Сигнал второй формы
void Form::on_pushButton_clicked()
{
    emit signalForm(ui->lineEdit->text()); // передаем текст с эдита
    \
    // Вызываем новый сигнал "changeColor()"
        emit changeColor();

}

/// генерация рандомного цвета
QColor Form::getRandomColor()
{
    // Инициализируем генератор случайных чисел
    srand(time(nullptr));

    // Получаем случайный цвет
    QColor color(rand() % 256, rand() % 256, rand() % 256);

    // Возвращаем случайный цвет
    return color;
}

/// сигнал смены цвета на форме
void Form::onChangeColor()
{
    // Инициализируем генератор случайных чисел
    srand(time(nullptr));

    // Получаем случайный цвет
    QColor color(rand() % 256, rand() % 256, rand() % 256);

    // Устанавливаем новый цвет формы
    this->setStyleSheet(QString("background-color: %1").arg(color.name()));
}
