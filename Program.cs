using System;
using System.Diagnostics;

Console.WriteLine("Welcome to the stop watch program");
Stopwatch stopwatch = new Stopwatch();

String start = Console.ReadLine();
Console.WriteLine("Started");

stopwatch.Start();                      //Start timing
String stop = Console.ReadLine();
stopwatch.Stop();                        // Stop timing
Console.WriteLine("Stoped");
Console.WriteLine("Time Elapsed : "+stopwatch.Elapsed);
Console.ReadLine();