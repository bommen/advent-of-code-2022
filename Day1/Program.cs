var input = File.ReadAllText("input.txt");

var topElves = input.Split("\r\n\r\n")
    .Select(elf => elf.Split("\r\n").Select(int.Parse).Sum())
    .Order()
    .Reverse()
    .ToList();

// Part 1
Console.WriteLine("Elf with most categories: {0:D}",
    topElves.Max());

// Part 2
Console.WriteLine("Sum of top three elves: {0:D}", 
    topElves.Take(3).Sum());