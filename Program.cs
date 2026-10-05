using System.Diagnostics;

Console.WriteLine($"Логических процессоров (ядер): {Environment.ProcessorCount}");

#if DEBUG
System.Console.WriteLine("Режим сборки: DEBUG");
#else
System.Console.WriteLine("Режим сборки: RELEASE");
#endif

long counter = 0;
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 1000)
{
    counter++;
}

System.Console.WriteLine($"Итераций примерно за 1 секунду: {counter:N0}");

