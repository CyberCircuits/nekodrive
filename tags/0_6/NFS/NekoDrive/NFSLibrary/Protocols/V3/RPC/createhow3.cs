/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class createhow3 : XdrAble {
    public int mode;
    public sattr3 obj_attributes_un;
    public sattr3 obj_attributes_gu;
    public createverf3 verf;

    public createhow3() {
    }

    public createhow3(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(mode);
        switch ( mode ) {
        case createmode3.UNCHECKED:
            obj_attributes_un.xdrEncode(xdr);
            break;
        case createmode3.GUARDED:
            obj_attributes_gu.xdrEncode(xdr);
            break;
        case createmode3.EXCLUSIVE:
            verf.xdrEncode(xdr);
            break;
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        mode = xdr.xdrDecodeInt();
        switch ( mode ) {
        case createmode3.UNCHECKED:
            obj_attributes_un = new sattr3(xdr);
            break;
        case createmode3.GUARDED:
            obj_attributes_gu = new sattr3(xdr);
            break;
        case createmode3.EXCLUSIVE:
            verf = new createverf3(xdr);
            break;
        }
    }

}
// End of createhow3.cs