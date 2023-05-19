#ifndef FORM_H
#define FORM_H
#include <cstdlib>
#include <ctime>


#include <QWidget>

namespace Ui {
class Form;
}

class Form : public QWidget
{
    Q_OBJECT

public:
    explicit Form(QWidget *parent = nullptr);
    ~Form();

private:
    Ui::Form *ui;
    QColor getRandomColor();

private slots:
    void on_pushButton_clicked();
    void onChangeColor();

    /// для сигналов тело метода не нужно.
signals:
    void signalForm(QString);
    void changeColor();
public slots:
    void slot(QString a);
};

#endif // FORM_H
