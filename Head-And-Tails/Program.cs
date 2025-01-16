Random rnd = new();


Console.WriteLine($"A resposta é: {((rnd.Next(0, 2) % 2) == 0 ? "Head" : "Tails")}");