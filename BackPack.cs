using System;
namespace RpgLogicProject
{

	//Рюкзак
	public class BackPack
	{
		//Массив обьектов в рюкзаке
		private readonly Item[] items;

		//Следующая свободная ячейка
		private int count = 0;

		public int maxWeigth { get; set; }

		public BackPack(int count)
		{
			items = new Item[count];
		}

		public void Add(Item item)
		{

            //Проверить нет ли перевеса (использовать метод GetWeigth())
            //Проверить есть ли свободная ячейка
            //Добавить item в массив по счетчику count
        }

		public int GetWeigth() {
			int result = 0;
			// Вычислить текуший вес рюкзака
			return result;
		}


	}
}

