using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Study1
{
	public class CategoryRepositoryInMemory : ICategoryRepository
	{
		private static List<Category> _categories = new List<Category>(); //초기화까지 시킴, 공유를 위한 static 선언을 한다.

		public bool HasValue { get; set; }

		public CategoryRepositoryInMemory()
		{
			_categories = new List<Category>()
			{
				new Category() {CategoryId = 1, CategoryName = "test"},
				new Category() {CategoryId = 2, CategoryName = "test2"},
				new Category() {CategoryId = 3, CategoryName = "test3"}

			};

			HasValue = (_categories.Count > 0); //카테고리의 카운트값이 0보다 큰값인지
		}

		public Category Add(Category model)
		{
			_categories.Add(model);

			return model;
		}

		public Category Browse(int id)
		{
			return _categories.Where(c => c.CategoryId == id).SingleOrDefault(); //List 카테고리이기 때문에 singleOrDefault로 단일 데이터를 넘겨줌
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Category Edit(Category model)
		{
			throw new NotImplementedException();
		}

		public List<Category> Ordering(SortOrder sortOrder)
		{
			throw new NotImplementedException();
		}

		public List<Category> Paging(int PageNumber, int PageSize)
		{
			throw new NotImplementedException();
		}

		public List<Category> Read()
		{
			//리스트

			return _categories;
		}

		public List<Category> Search(string query)
		{
			throw new NotImplementedException();
		}
	}
}
