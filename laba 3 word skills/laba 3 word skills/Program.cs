using System;
using System.Linq;

public struct Student
{
    public string Name; // Поле для хранения имени студента
    public int GroupNumber; // Поле для хранения номера группы студента
    public int[] Grades; // Поле для хранения оценок студента

    public double AverageGrade // Свойство для вычисления среднего балла студента
    {
        get { return Grades.Average(); } // Вычисление среднего балла на основе массива оценок
    }
}

public class Program
{
    public static void Main()
    {
        Student[] students = new Student[7]; // Создание массива студентов

        // Инициализация данных для каждого студента
        students[0] = new Student { Name = "Душин М.В", GroupNumber = 001, Grades = new int[] { 4, 3, 5, 3, 4 } };
        students[1] = new Student { Name = "Иванов И.И.", GroupNumber = 002, Grades = new int[] { 5, 4, 4, 5, 3 } };
        students[2] = new Student { Name = "Петров П.П.", GroupNumber = 001, Grades = new int[] { 5, 5, 5, 4, 4 } };
        students[3] = new Student { Name = "Смирнов С.С.", GroupNumber = 002, Grades = new int[] { 2, 3, 5, 3, 5 } };
        students[4] = new Student { Name = "Рузанов И.И", GroupNumber = 001, Grades = new int[] { 5, 4, 3, 5, 4 } };
        students[5] = new Student { Name = "Илюшин И.И.", GroupNumber = 002, Grades = new int[] { 4, 5, 2, 4, 3 } };
        students[6] = new Student { Name = "Алексеев А.А.", GroupNumber = 001, Grades = new int[] { 3, 4, 4, 2, 5 } };

        // Сортировка массива студентов по возрастанию среднего балла
        Array.Sort(students, (x, y) => x.AverageGrade.CompareTo(y.AverageGrade));

        // Вывод информации о студентах после сортировки
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.Name}, Группа: {student.GroupNumber}, Средний балл: {student.AverageGrade}");
        }
    }
}