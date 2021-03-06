//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.concurrent
{
    public partial interface ExecutorService : Executor
    {
        bool awaitTermination(long prm1, TimeUnit prm2);
        List<Future<T>> invokeAll<T>(Collection<Callable<T>> prm1, long prm2, TimeUnit prm3);
        List<Future<T>> invokeAll<T>(Collection<Callable<T>> prm1);
        T invokeAny<T>(Collection<Callable<T>> prm1);
        T invokeAny<T>(Collection<Callable<T>> prm1, long prm2, TimeUnit prm3);
        void shutdown();
        List<global::java.lang.Runnable> shutdownNow();
        Future<T> submit<T>(Callable<T> prm1);
        Future<T> submit<T>(global::java.lang.Runnable prm1, T prm2);
        Future<global::System.Object> submit(global::java.lang.Runnable prm1);
        bool  IsShutdown { get;}
        bool  IsTerminated { get;}
    }
}
