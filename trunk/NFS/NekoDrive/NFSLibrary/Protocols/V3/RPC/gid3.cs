/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class gid3 : XdrAble {

    public uint32 value;

    public gid3() {
    }

    public gid3(uint32 value) {
        this.value = value;
    }

    public gid3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        value.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        value = new uint32(xdr);
    }

}
// End of gid3.cs
