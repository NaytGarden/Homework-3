/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

/*int N = new Random().Next(10000,100000); 
int a = N / 10000; 
int b = N / 1000 % 10; 
int c = N / 100 % 10; 
int d = N / 10 % 10; 
int f = N % 10; 
if(a == f && b == d){Console.WriteLine("Это число палиндром");}
else {Console.WriteLine(N + " Число не является палиндромом");}*/


/* Задача 21 Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.*/

/*int xa = new Random().Next(1,10);
int ya = new Random().Next(1,10);
int za = new Random().Next(1,10);

int xb = new Random().Next(1,10);
int yb = new Random().Next(1,10);
int zb = new Random().Next(1,10);

double temp = Math.Round(Math.Sqrt(Math.Pow((xb - xa),2)) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
Console.WriteLine(temp);*/

/*Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

int N = new Random().Next(1,100);
for (int i = 1; i <= N; i++){double result = Math.Pow(i,3); System.Console.WriteLine(result);}