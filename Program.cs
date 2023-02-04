using RpgLogicProject;

//Инициализировать классы. И начать битву 
Console.WriteLine("Битва!");

var Elf = new Hero("LEGOLAS", 22, 127);

var Orc = new Enemy("Thrall", 20, 137);

var Arena = new BattleArena(Orc, Elf);

var pobedka = Arena.Battle();

if (pobedka == 1) Console.WriteLine("Эльф победил");
else Console.WriteLine("Эльф проиграл");



///////////////////////////////////////////////////////////////////
// Дополнительное задание на 5.
// Реализовать механизм лута предметов с противника в случае победы
///////////////////////////////////////////////////////////////////