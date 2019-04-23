using System;

namespace Study1
{
	class Program
	{
		static CategoryRepositoryInMemory _category;

		static void Main(string[] args)
		{
			_category = new CategoryRepositoryInMemory();

			Console.WriteLine("[1] 기본 값이 있는지 확인: ");
			HasCategory();

			Console.WriteLine("[2] 기본 데이터 출력: " );
			ReadCategories();

			Console.WriteLine("[3] 데이터 입력: ");
			AddCategory();

			Console.WriteLine("[4] 조회: ");
			BrowseCategory();
		}

		/// <summary>
		/// 조회
		/// </summary>
		private static void BrowseCategory()
		{
			var category = _category.Browse(4);
			if(category != null)
			{
				Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
			}
			else
			{
				Console.WriteLine($"4번 카테고리가 없습니다.");
			}
			
		}


		/// <summary>
		/// 여부
		/// </summary>
		private static void HasCategory()
		{
			if(_category.HasValue)
			{
				Console.WriteLine("기본 데이터가 있습니다.");
			}
			else
			{
				Console.WriteLine("기본 데이터가 없습니다.");
			}
		}

		#region 출력
		/// <summary>
		/// 출력
		/// </summary>
		private static void ReadCategories()
		{
			var categories = _category.Read();

			foreach (var category in categories)
			{
				Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
			}
		}
		#endregion


		/// <summary>
		/// 입력
		/// </summary>
		private static void AddCategory()
		{
			var category = new Category() { CategoryId = 4, CategoryName = "test4" };
			_category.Add(category);
			ReadCategories();
		}

	}
}
