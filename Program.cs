using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Luhn Algoritması");

static bool CreditCard(string cardNumber)
{
    cardNumber = cardNumber.Replace(" ", "");
    if (!cardNumber.All(char.IsDigit)) return false;

    int sum = cardNumber
        .Reverse()
        .Select((c, i) =>
        {
            int digit = c - '0';
            if (i % 2 == 1) digit = digit * 2 > 9 ? digit * 2 - 9 : digit * 2;
            return digit;
        })
        .Sum();
    return sum % 10 == 0;
}

string creditCardNumber = "4847 3529 8926 3094";
bool isValid = CreditCard(creditCardNumber);
Console.WriteLine(isValid);
