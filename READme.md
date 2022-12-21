
<center> 
<h1> Проверочная работа по итогам первого блока</h2>
</center>

![Task Description](/Task.png)

## Задача:
Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше или равна 3-м символам.

## Решение:

Для решения задачи будет использоваться метод *"GetArrayShortElements"*

Параметры - *string[], int*

Возвращаемое значение - *string[]*

Данный метод проверяет длину элементов исходного массива (параметр *string[]*) и возвращает новый массив, состоящий из элементов исходного массива, длина которых меньше или равна (параметр *int*.)


## Алгоритим работы метода *"GetArrayShortElements"* :

![Блок-схема алгоритма использованного метода](/Diag_func_1.png)

1. Инициализация переменной *int newSize* для определения длины возвращаемого массива.
2. Пересчёт элементов исходного массива удовлетворяющих условию *string.Lenght* <= (параметр *int*).
3. Инициализация возвращаемого массива *string[] shortArray* c размером *int newSize*.
3. Проверка переменной *int newSize*. Если в исходном массиве не найдены элементы удовлетворяющие условию, то *int newSize* равна 0 и метод возвратит пустой массив.
4. При значениях *int newSize* отличных от 0, инициализируется переменная *int j* для обращения к элементам возвращаемого массива.
4. Заполение возвращаемого массива *string[] shortArray* элементами исходного массива,удовлетворяющими условию *string.Lenght* <= (параметр *int*).

## Решение(второй метод):

Метод "GetArrayShortElements"

По сути не отличается от предыдущего решения, но убран второй цикл заполнения результирующего массива за счёт метода Array.Resize

# Важно!!!!
В рамках текущей задачи метод Array.Resize вполне применим из-за  редкого обращения к нему и малом размере самого массива. 

Но исходя из справки по его работе, при постоянном "клонировании" массива и добавлении размерности будет выделяться больше памяти, чем при использовании Решения 1.
