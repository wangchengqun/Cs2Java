//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util
{
    public partial interface List<E> : Collection<E>
    {
        void add(int prm1, E prm2);
        bool addAll(int prm1, Collection<E> prm2);
        E get(int prm1);
        int indexOf(global::System.Object prm1);
        int lastIndexOf(global::System.Object prm1);
        ListIterator<E> listIterator();
        ListIterator<E> listIterator(int prm1);
        E remove(int prm1);
        E set(int prm1, E prm2);
        List<E> subList(int prm1, int prm2);
    }
}