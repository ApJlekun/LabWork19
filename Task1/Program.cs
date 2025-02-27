﻿using Task1;

Context context = new(new OperationAdd());
Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

context = new Context(new OperationSubstract());
Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

context = new Context(new OperationMultiply());
Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));

context = new Context(new OperationDivision());
Console.WriteLine("10 / 5 = " + context.ExecuteStrategy(10, 5));