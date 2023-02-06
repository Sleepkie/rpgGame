using RpgLogicProject;

//Инициализировать классы. И начать битву 
Console.WriteLine("Битва!");

var elf = new Hero("LEGOLAS", 60, 127);


elf.Backpack.Add(new Item("shield", 7));
elf.Backpack.Add(new Item("sword", 1));
elf.Backpack.Add(new Item("Hood", 5));


var orc = new Enemy("Thrall", 20, 137);



orc.Backpack.Add(new Item("Big Sword", 1));
orc.Backpack.Add(new Item("Armor", 5));

var arena = new BattleArena(orc, elf);

var pobedka = arena.Battle();

if (pobedka == 1) elf.LootCreature(orc);

if (pobedka == 1) Console.WriteLine("Эльф победил");
else Console.WriteLine("Эльф проиграл");



///////////////////////////////////////////////////////////////////
// Дополнительное задание на 5.
// Реализовать механизм лута предметов с противника в случае победы
///////////////////////////////////////////////////////////////////