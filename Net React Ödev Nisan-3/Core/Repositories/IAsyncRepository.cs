namespace Core.Repositories;

public interface IAsyncRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);        // id'ye göre bul
    Task<IReadOnlyList<T>> GetAllAsync(); // tüm veriyi getir
    Task<T> AddAsync(T entity);           // veri ekle
    Task UpdateAsync(T entity);           // veri güncelle
    Task DeleteAsync(T entity);           // veri sil
}


//IAsyncRepository<T> ne? == Generic bir interface (şablon).

//<T> ne?  == Hangi entity üzerinde çalışılacağını belirtiyor.

//where T : class ne? == Sadece class'lar kullanılabilir. (int, bool gibi şeyler yasak)