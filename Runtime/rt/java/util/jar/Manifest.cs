//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.jar
{
    public partial class Manifest : global::java.lang.Object, global::java.lang.Cloneable
    {
        public virtual void clear(){}
        public virtual new global::System.Object clone(){return default(global::System.Object);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public virtual Attributes getAttributes(global::java.lang.String prm1){return default(Attributes);}
        public override int hashCode(){return default(int);}
        public Manifest(Manifest prm1){}
        public Manifest(global::java.io.InputStream prm1){}
        public Manifest(){}
        public virtual void read(global::java.io.InputStream prm1){}
        public virtual void write(global::java.io.OutputStream prm1){}
        public Map<global::java.lang.String,Attributes>  Entries { get; private set;}
        public Attributes  MainAttributes { get; private set;}
    }
}
