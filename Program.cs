//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int NumberDey = Convert.ToInt32(Console.ReadLine());
if (NumberDey >=1 &&  NumberDey <=5  )   
{
    Console.Write($" Да, это рабочий день недели") ; 
}
if (NumberDey >=5 &&  NumberDey <=7  )   
{
    Console.Write($"Нет, это выходной") ; 
}
if (NumberDey >=7 )   
{
     Console.Write($"Нет, цифра {NumberDey} не может обозначать день недели.") ;  
      
}