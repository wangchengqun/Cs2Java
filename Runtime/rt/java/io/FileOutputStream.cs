//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.io
{
    public partial class FileOutputStream : OutputStream
    {
        public override void close(){}
        protected override void finalize(){}
        public FileOutputStream(FileDescriptor prm1){}
        public FileOutputStream(File prm1){}
        public FileOutputStream(global::java.lang.String prm1, bool prm2){}
        public FileOutputStream(global::java.lang.String prm1){}
        public FileOutputStream(File prm1, bool prm2){}
        public override void write(byte[] prm1){}
        public override void write(byte[] prm1, int prm2, int prm3){}
        public override void write(int prm1){}
        public global::java.nio.channels.FileChannel  Channel { get; private set;}
        public FileDescriptor  FD { get; private set;}
    }
}
