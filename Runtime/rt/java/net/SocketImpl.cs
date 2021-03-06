//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public abstract partial class SocketImpl : global::java.lang.Object, SocketOptions
    {
        public InetAddress address;
        public global::java.io.FileDescriptor fd;
        public int localport;
        public int port;
        protected virtual void accept(SocketImpl prm1){}
        protected virtual int available(){return default(int);}
        protected virtual void bind(InetAddress prm1, int prm2){}
        protected virtual void close(){}
        protected virtual void connect(global::java.lang.String prm1, int prm2){}
        protected virtual void connect(SocketAddress prm1, int prm2){}
        protected virtual void connect(InetAddress prm1, int prm2){}
        protected virtual void create(bool prm1){}
        public virtual global::System.Object getOption(int prm1){return default(global::System.Object);}
        public SocketImpl(){}
        protected virtual void listen(int prm1){}
        protected virtual void sendUrgentData(int prm1){}
        public virtual void setOption(int prm1, global::System.Object prm2){}
        protected virtual void setPerformancePreferences(int prm1, int prm2, int prm3){}
        protected virtual void shutdownInput(){}
        protected virtual void shutdownOutput(){}
        protected virtual bool supportsUrgentData(){return default(bool);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public global::java.io.FileDescriptor  FileDescriptor { get; private set;}
        public InetAddress  InetAddress { get; private set;}
        public global::java.io.InputStream  InputStream { get; private set;}
        public int  LocalPort { get; private set;}
        public global::java.io.OutputStream  OutputStream { get; private set;}
        public int  Port { get; private set;}
    }
}
