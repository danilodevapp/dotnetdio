using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using diointer.Models;

Pessoa p1;

p1 = new Pessoa();

Console.WriteLine();

Console.Write("Digite o Nome: ");
p1.Nome = Console.ReadLine();

Console.WriteLine();

Console.Write("Digite a idade: ");
p1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine();

// p1.Nome = "Danilo";
// p1.Idade = 44;

p1.Apresentar();