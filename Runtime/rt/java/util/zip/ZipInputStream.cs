//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.zip
{
    public partial class ZipInputStream : InflaterInputStream, ZipConstants
    {
        public override int available(){return default(int);}
        public override void close(){}
        public virtual void closeEntry(){}
        protected virtual ZipEntry createZipEntry(global::java.lang.String prm1){return default(ZipEntry);}
        public ZipInputStream(global::java.io.InputStream prm1, global::java.nio.charset.Charset prm2) : base(default(global::java.io.InputStream), default(Inflater)){}
        public ZipInputStream(global::java.io.InputStream prm1) : base(default(global::java.io.InputStream), default(Inflater)){}
        public override int read(byte[] prm1, int prm2, int prm3){return default(int);}
        public override long skip(long prm1){return default(long);}
        public ZipEntry  NextEntry { get; private set;}
    }
}
