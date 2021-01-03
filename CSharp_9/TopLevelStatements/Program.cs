﻿using System;
using System.Threading.Tasks;

Console.WriteLine();
foreach (var s in args)
{
    Console.Write(s);
    Console.Write(' ');
}
Console.WriteLine();

//
string[] answers =
{
    "It is certain.",       "Reply hazy, try again.",     "Don’t count on it.",
    "It is decidedly so.",  "Ask again later.",           "My reply is no.",
    "Without a doubt.",     "Better not tell you now.",   "My sources say no.",
    "Yes – definitely.",    "Cannot predict now.",        "Outlook not so good.",
    "You may rely on it.",  "Concentrate and ask again.", "Very doubtful.",
    "As I see it, yes.",
    "Most likely.",
    "Outlook good.",
    "Yes.",
    "Signs point to yes.",
};
var index = new Random().Next(0, answers.Length - 1);
Console.WriteLine($"{answers[index]} index:{index}");


foreach (var item in answers)
{
    var index2 = new Random().Next(0, answers.Length - 1);
    Console.WriteLine(answers[index2]);
}