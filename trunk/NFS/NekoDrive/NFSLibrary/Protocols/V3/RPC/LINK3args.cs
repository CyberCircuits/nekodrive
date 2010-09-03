/*
 * Automatically generated by jrpcgen 1.0.7 on 27/08/2010
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
using org.acplt.oncrpc;

public class LINK3args : XdrAble {
    public nfs_fh3 file;
    public diropargs3 link;

    public LINK3args() {
    }

    public LINK3args(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        file.xdrEncode(xdr);
        link.xdrEncode(xdr);
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        file = new nfs_fh3(xdr);
        link = new diropargs3(xdr);
    }

}
// End of LINK3args.cs
