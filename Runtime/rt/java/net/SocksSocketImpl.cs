//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    internal partial class SocksSocketImpl : PlainSocketImpl, SocksConsts
    {
        public SocksSocketImpl(){}
        protected virtual void acceptFrom(SocketImpl prm1, InetSocketAddress prm2){}
        protected override void close(){}
        protected override void connect(SocketAddress prm1, int prm2){}
        protected virtual void socksBind(InetSocketAddress prm1){}
        public InetAddress  InetAddress { get; private set;}
        public int  LocalPort { get; private set;}
        public int  Port { get; private set;}
    }
}
