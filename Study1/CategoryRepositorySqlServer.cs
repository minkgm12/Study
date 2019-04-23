using System;
using System.Collections.Generic;
using System.Text;

namespace Study1
{
	public class CategoryRepositorySqlServer : ICategoryRepository
	{
		public bool HasValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Category Add(Category model)
		{
			throw new NotImplementedException();
		}

		public Category Browse(int id)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public List<Category> Search(string query)
		{
			throw new NotImplementedException();
		}
	}
}
