/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class GETATTR3res : XdrAble {
    public int status;
    public GETATTR3resok resok;

    public GETATTR3res() {
    }

    public GETATTR3res(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(status);
        switch ( status ) {
        case nfsstat3.NFS3_OK:
            resok.xdrEncode(xdr);
            break;
        default:
            break;
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        status = xdr.xdrDecodeInt();
        switch ( status ) {
        case nfsstat3.NFS3_OK:
            resok = new GETATTR3resok(xdr);
            break;
        default:
            break;
        }
    }

}
// End of GETATTR3res.cs
