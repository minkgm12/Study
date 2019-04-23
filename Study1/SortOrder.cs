using System;
using System.Collections.Generic;
using System.Text;

namespace Study1
{
	/// <summary>
	/// SortOrder 열거형 : 행의 데이터 정렬 방법을 지정 합니다.
	/// </summary>
	public enum SortOrder
	{
		/// <summary>
		/// 오름차순
		/// </summary>
		Ascending,
		
		/// <summary>
		/// 내림차순
		/// </summary>
		Descending,

		/// <summary>
		/// 정렬 순서 없음
		/// </summary>
		None
	}
}
