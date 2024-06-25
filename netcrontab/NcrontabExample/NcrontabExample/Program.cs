// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var cron = NCrontab.CrontabSchedule.Parse("5 * * * *");
var start  = DateTime.Now;
var end = DateTime.Now.AddHours(1);

var occurences =  cron.GetNextOccurrences(start, end);
foreach (var occurence in occurences)
{
    Console.WriteLine(occurence);
}