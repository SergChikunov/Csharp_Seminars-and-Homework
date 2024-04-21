/* За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, 
в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную 
сумму вклада с учетом начисления процентов за каждый месяц.
Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение
 Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal). */

 double valProcent = 1.07;
 Console.WriteLine("Введите сумму вклада: ");
 double valDeposit = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите срок вклада в месяцах (не более 250): ");
 Console.WriteLine();

 double resultSumm = valDeposit;
 byte valPeriod = Convert.ToByte(Console.ReadLine());

for (byte i = 1; i < valPeriod; i++)
{
    valDeposit = valDeposit * valProcent;
}

Console.WriteLine($"\nИтоговая сумма вклада в {resultSumm} монет, через {valPeriod} месяца составит {valDeposit} монет, при процентной ставке в 7%.");
Console.WriteLine("Для выхода из программы, нажмите любую клавишу...");
Console.ReadKey();
