//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.security.cert
{
    public abstract partial class Certificate : global::java.lang.Object, global::java.io.Serializable
    {
        protected partial class CertificateRep : global::java.lang.Object, global::java.io.Serializable
        {
            public CertificateRep(global::java.lang.String prm1, byte[] prm2){}
            protected virtual global::System.Object readResolve(){return default(global::System.Object);}
        }
        public override bool equals(global::System.Object prm1){return default(bool);}
        public override int hashCode(){return default(int);}
        public Certificate(global::java.lang.String prm1){}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public virtual void verify(PublicKey prm1, global::java.lang.String prm2){}
        public virtual void verify(PublicKey prm1){}
        protected virtual global::System.Object writeReplace(){return default(global::System.Object);}
        public byte[]  Encoded { get; private set;}
        public PublicKey  PublicKey { get; private set;}
        public global::java.lang.String  Type { get; private set;}
    }
}
