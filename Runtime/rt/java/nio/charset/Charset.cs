//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio.charset
{
    public abstract partial class Charset : global::java.lang.Object, global::java.lang.Comparable<Charset>
    {
        public global::java.util.Set<global::java.lang.String> aliases(){return default(global::java.util.Set<global::java.lang.String>);}
        public static global::java.util.SortedMap<global::java.lang.String,Charset> availableCharsets(){return default(global::java.util.SortedMap<global::java.lang.String,Charset>);}
        public virtual bool canEncode(){return default(bool);}
        public int compareTo(Charset prm1){return default(int);}
        public virtual bool contains(Charset prm1){return default(bool);}
        public CharBuffer decode(ByteBuffer prm1){return default(CharBuffer);}
        public static Charset defaultCharset(){return default(Charset);}
        public virtual global::java.lang.String displayName(){return default(global::java.lang.String);}
        public virtual global::java.lang.String displayName(global::java.util.Locale prm1){return default(global::java.lang.String);}
        public ByteBuffer encode(global::java.lang.String prm1){return default(ByteBuffer);}
        public ByteBuffer encode(CharBuffer prm1){return default(ByteBuffer);}
        public bool equals(global::System.Object prm1){return default(bool);}
        public static Charset forName(global::java.lang.String prm1){return default(Charset);}
        public int hashCode(){return default(int);}
        public static bool isSupported(global::java.lang.String prm1){return default(bool);}
        public Charset(global::java.lang.String prm1, global::java.lang.String[] prm2){}
        public global::java.lang.String name(){return default(global::java.lang.String);}
        public virtual CharsetDecoder newDecoder(){return default(CharsetDecoder);}
        public virtual CharsetEncoder newEncoder(){return default(CharsetEncoder);}
        public global::java.lang.String toString(){return default(global::java.lang.String);}
        public bool  IsRegistered { get; private set;}
    }
}