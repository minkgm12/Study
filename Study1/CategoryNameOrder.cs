using System;
using System.Collections.Generic;
using System.Text;

namespace Study1
{
	/// <summary>
	/// 열거형 카테고리 이름 정렬 방법
	/// </summary>
	/// 
	//오브설리트
	[Obsolete("SortOrder 열거형을 사용하세요.")]
	public enum CategoryNameOrder
	{
		/// <summary>
		/// 오름차순
		/// </summary>
		Asc,
		
		/// <summary>
		/// 내림차순
		/// </summary>
		Desc
	}
}
