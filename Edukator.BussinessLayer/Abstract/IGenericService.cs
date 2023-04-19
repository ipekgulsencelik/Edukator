namespace Edukator.BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        List<T> TGetList();
        T TGetByID(int id);
    }
}