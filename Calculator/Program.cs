using System;

Console.WriteLine("Hisoblash dasturiga hush kelibsiz");

Console.Write("1-sonni kiriting: ");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
Console.Write("2-sonni kiriting: ");
decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("============ Sodda arifmetik amallar ==========");
Console.WriteLine($"Yig'indi       -> {firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
Console.WriteLine($"Ayirma         -> {firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
Console.WriteLine($"Ko'paytma      -> {firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
Console.WriteLine($"Bo'linma       -> {firstNumber} / {secondNumber} = {(firstNumber/secondNumber):F2}");
Console.WriteLine($"Qoldiq         -> {firstNumber} % {secondNumber} = {firstNumber%secondNumber}");

Console.WriteLine("============== Math kutubxonasi ==============");
Console.WriteLine($"Yig'indi butun qismi       -> {firstNumber} + {secondNumber} = {Math.Round(firstNumber/secondNumber)}");
Console.WriteLine($"Butun qism ko'paytmasi     -> {firstNumber} * {secondNumber} = {Math.BigMul((int)firstNumber, (int)secondNumber)}");
Console.WriteLine($"Sonlarning kattasi         -> {firstNumber} yoki {secondNumber} = {Math.Max(firstNumber, secondNumber)}");
Console.WriteLine($"Sonlarning kichigi         -> {firstNumber} yoki {secondNumber} = {Math.Min(firstNumber, secondNumber)}");