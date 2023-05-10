<?xml version="1.0" encoding="utf-8"?>
<RelativeLayout  
    xmlns:android="http://schemas.android.com/apk/res/android"
    xmlns:app="http://schemas.android.com/apk/res-auto"
    xmlns:tools="http://schemas.android.com/tools"
    android:layout_width="wrap_content"
    android:layout_height="wrap_content"
    app:layout_behavior="@string/appbar_scrolling_view_behavior"
    tools:showIn="@layout/activity_main"
    android:minWidth="25px"
    android:minHeight="25px"
    
    >

    <Button
        android:id="@+id/button2"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:layout_alignParentBottom="true"
        android:layout_marginBottom="16dp"
        android:text="Click Me!" />
    
        
        <ImageView
    android:layout_width="128dp"
    android:layout_height="128dp"
    android:layout_alignParentTop="true"
    android:layout_alignParentLeft="true"
    android:layout_marginLeft="16dp"
    android:layout_marginTop="16dp"
    android:src="@drawable/usd26" />


    <TextView
        android:id="@+id/exchangeRateTextView"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:layout_centerInParent="true"
        android:text="Курс обмена:"
        android:textSize="24sp"
        android:textStyle="bold"
        android:textColor="@android:color/black"/>

</RelativeLayout>





<RelativeLayout> - это контейнерный элемент, позволяющий задать относительное расположение вложенных элементов.
xmlns:android="http://schemas.android.com/apk/res/android" - это пространство имен для компонентов Android.
xmlns:app="http://schemas.android.com/apk/res-auto" - это пространство имен для компонентов приложения.
xmlns:tools="http://schemas.android.com/tools" - это пространство имен для средств разработки.
app:layout_behavior="@string/appbar_scrolling_view_behavior" - это атрибут, устанавливающий поведение разметки при прокручивании.
tools:showIn="@layout/activity_main" - это атрибут, указывающий, где будет отображаться данная разметка в режиме предварительного просмотра.
android:minWidth="25px" и android:minHeight="25px" - это минимальные значения ширины и высоты разметки.





<Button> - это компонент кнопки.
android:id="@+id/button2" - это уникальный идентификатор для кнопки.
android:layout_width="match_parent" и android:layout_height="wrap_content" - это параметры ширины и высоты кнопки.
android:layout_alignParentBottom="true" - это параметр, выравнивающий кнопку по нижнему краю родительского контейнера.
android:layout_marginBottom="16dp" - это отступ от нижнего края родительского контейнера до кнопки.
android:text="Click Me!" - это текст, отображаемый на кнопке.



<ImageView> - это компонент изображения.
android:layout_width="128dp" и android:layout_height="128dp" - это параметры ширины и высоты изображения.
android:layout_alignParentTop="true" и android:layout_alignParentLeft="true" - это параметры выравнивания изображения по верхнему левому углу родительского контейнера.
android:layout_marginLeft="16dp" и android:layout_marginTop="16dp" - это отступы от левого верхнего угла родительского контейнера до изображения.
android:src="@drawable/usd26" - это атрибут, указывающий на ресурс изображения, которое будет отображаться.



<TextView> - это компонент текста.
android:id="@+id/exchangeRateTextView" - это уникальный идентификатор для текстового поля.

Установка ширины и высоты TextView как wrap_content, чтобы его размер автоматически настраивался под его содержимое
android:layout_width="wrap_content"
android:layout_height="wrap_content"

Установка центрирования TextView по вертикали и горизонтали внутри родительского RelativeLayout
android:layout_centerInParent="true"

Установка текста в TextView
android:text="Курс обмена:"


Установка размера текста в 24sp
android:textSize="24sp"

Установка жирного начертания для текста в TextView
android:textStyle="bold"

Установка цвета текста в черный
android:textColor="@android:color/black"