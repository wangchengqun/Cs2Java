//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.zip
{
    public partial class ZipOutputStream : DeflaterOutputStream, ZipConstants
    {
        public static int DEFLATED;
        public static int STORED;
        public override void close(){}
        public virtual void closeEntry(){}
        public override void finish(){}
        public ZipOutputStream(global::java.io.OutputStream prm1, global::java.nio.charset.Charset prm2) : base(default(global::java.io.OutputStream)){}
        public ZipOutputStream(global::java.io.OutputStream prm1) : base(default(global::java.io.OutputStream)){}
        public virtual void putNextEntry(ZipEntry prm1){}
        public virtual void setComment(global::java.lang.String prm1){}
        public virtual void setLevel(int prm1){}
        public virtual void setMethod(int prm1){}
        public override void write(byte[] prm1, int prm2, int prm3){}
    }
}