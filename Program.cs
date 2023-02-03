using RpgLogicProject;

//Инициализировать классы. И начать битву 
Console.WriteLine("ПИЗДЕЛОВКА");

var Elf = new Hero("LEGOLAS", 22, 127);

var Orc = new Enemy("Pidor", 20, 137);

var Arena = new BattleArena(Orc, Elf);

var pobedka = Arena.Battle();

if (pobedka == 1) Console.WriteLine("Эльф разъебал");
else Console.WriteLine("Эльф пососал");



///////////////////////////////////////////////////////////////////
// Дополнительное задание на 5.
// Реализовать механизм лута предметов с противника в случае победы
///////////////////////////////////////////////////////////////////