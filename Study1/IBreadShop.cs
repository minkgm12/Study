using System.Collections.Generic;

namespace Study1
{
	/// <summary>
	/// 제너릭 인터페이스: 공통 CRUD 코드
	/// </summary>
	/// <typeparam name="T">모델 클래스</typeparam>
	/// <typeparam name="V">열거형 또는 문자열</typeparam>
	public interface IBreadShop<T> where T : class
	{
		T Browse(int id);   //T를 반환시켜주는 메소드를 정의
		List<T> Read(); //카테고리에 대한 전체 리스트값 출력
		T Edit(T model); //수정, 카테고리값(파라미터)을 넘겨주어, edit을 진행 함. 반환값은 T를 명시하였지만 void를 해도 상관 없음.
		T Add(T model);
		void Delete(int id);

		List<T> Search(string query); //검색
		bool HasValue { get; set; } //속성 값 유무 체크
		List<T> Ordering(SortOrder sortOrder);
		List<T> Paging(int PageNumber, int PageSize);
	}
}
