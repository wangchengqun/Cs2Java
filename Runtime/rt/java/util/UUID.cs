//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util
{
    public partial class UUID : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable<UUID>
    {
        public virtual int clockSequence(){return default(int);}
        public virtual int compareTo(UUID prm1){return default(int);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public static UUID fromString(global::java.lang.String prm1){return default(UUID);}
        public override int hashCode(){return default(int);}
        public UUID(long prm1, long prm2){}
        public static UUID nameUUIDFromBytes(byte[] prm1){return default(UUID);}
        public virtual long node(){return default(long);}
        public static UUID randomUUID(){return default(UUID);}
        public virtual long timestamp(){return default(long);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public virtual int variant(){return default(int);}
        public virtual int version(){return default(int);}
        public long  LeastSignificantBits { get; private set;}
        public long  MostSignificantBits { get; private set;}
    }
}