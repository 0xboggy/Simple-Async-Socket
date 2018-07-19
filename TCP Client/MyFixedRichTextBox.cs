using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;

namespace TCP_Client
{
    #region "OLE definitions"
    // STGM
    [Flags(), ComVisible(false)]
    public enum STGM : int
    {
        STGM_DIRECT = 0x0,
        STGM_TRANSACTED = 0x10000,
        STGM_SIMPLE = 0x8000000,
        STGM_READ = 0x0,
        STGM_WRITE = 0x1,
        STGM_READWRITE = 0x2,
        STGM_SHARE_DENY_NONE = 0x40,
        STGM_SHARE_DENY_READ = 0x30,
        STGM_SHARE_DENY_WRITE = 0x20,
        STGM_SHARE_EXCLUSIVE = 0x10,
        STGM_PRIORITY = 0x40000,
        STGM_DELETEONRELEASE = 0x4000000,
        STGM_NOSCRATCH = 0x100000,
        STGM_CREATE = 0x1000,
        STGM_CONVERT = 0x20000,
        STGM_FAILIFTHERE = 0x0,
        STGM_NOSNAPSHOT = 0x200000,
    }

    // DVASPECT
    [Flags(), ComVisible(false)]
    public enum DVASPECT : int
    {
        DVASPECT_CONTENT = 1,
        DVASPECT_THUMBNAIL = 2,
        DVASPECT_ICON = 4,
        DVASPECT_DOCPRINT = 8,
        DVASPECT_OPAQUE = 16,
        DVASPECT_TRANSPARENT = 32,
    }

    // CLIPFORMAT
    [ComVisible(false)]
    public enum CLIPFORMAT : int
    {
        CF_TEXT = 1,
        CF_BITMAP = 2,
        CF_METAFILEPICT = 3,
        CF_SYLK = 4,
        CF_DIF = 5,
        CF_TIFF = 6,
        CF_OEMTEXT = 7,
        CF_DIB = 8,
        CF_PALETTE = 9,
        CF_PENDATA = 10,
        CF_RIFF = 11,
        CF_WAVE = 12,
        CF_UNICODETEXT = 13,
        CF_ENHMETAFILE = 14,
        CF_HDROP = 15,
        CF_LOCALE = 16,
        CF_MAX = 17,
        CF_OWNERDISPLAY = 0x80,
        CF_DSPTEXT = 0x81,
        CF_DSPBITMAP = 0x82,
        CF_DSPMETAFILEPICT = 0x83,
        CF_DSPENHMETAFILE = 0x8E,
    }

    // Object flags
    [Flags(), ComVisible(false)]
    public enum REOOBJECTFLAGS : uint
    {
        REO_NULL = 0x00000000,  // No flags
        REO_READWRITEMASK = 0x0000003F, // Mask out RO bits
        REO_DONTNEEDPALETTE = 0x00000020,   // Object doesn't need palette
        REO_BLANK = 0x00000010, // Object is blank
        REO_DYNAMICSIZE = 0x00000008,   // Object defines size always
        REO_INVERTEDSELECT = 0x00000004,    // Object drawn all inverted if sel
        REO_BELOWBASELINE = 0x00000002, // Object sits below the baseline
        REO_RESIZABLE = 0x00000001, // Object may be resized
        REO_LINK = 0x80000000,  // Object is a link (RO)
        REO_STATIC = 0x40000000,    // Object is static (RO)
        REO_SELECTED = 0x08000000,  // Object selected (RO)
        REO_OPEN = 0x04000000,  // Object open in its server (RO)
        REO_INPLACEACTIVE = 0x02000000, // Object in place active (RO)
        REO_HILITED = 0x01000000,   // Object is to be hilited (RO)
        REO_LINKAVAILABLE = 0x00800000, // Link believed available (RO)
        REO_GETMETAFILE = 0x00400000    // Object requires metafile (RO)
    }

    // OLERENDER
    [ComVisible(false)]
    public enum OLERENDER : int
    {
        OLERENDER_NONE = 0,
        OLERENDER_DRAW = 1,
        OLERENDER_FORMAT = 2,
        OLERENDER_ASIS = 3,
    }

    // TYMED
    [Flags(), ComVisible(false)]
    public enum TYMED : int
    {
        TYMED_NULL = 0,
        TYMED_HGLOBAL = 1,
        TYMED_FILE = 2,
        TYMED_ISTREAM = 4,
        TYMED_ISTORAGE = 8,
        TYMED_GDI = 16,
        TYMED_MFPICT = 32,
        TYMED_ENHMF = 64,
    }

    [StructLayout(LayoutKind.Sequential), ComVisible(false)]
    public struct FORMATETC
    {
        public CLIPFORMAT cfFormat;
        public IntPtr ptd;
        public DVASPECT dwAspect;
        public int lindex;
        public TYMED tymed;
    }

    [StructLayout(LayoutKind.Sequential), ComVisible(false)]
    public struct STGMEDIUM
    {
        //[MarshalAs(UnmanagedType.I4)]
        public int tymed;
        public IntPtr unionmember;
        public IntPtr pUnkForRelease;
    }

    [ComVisible(true),
    ComImport(),
    Guid("00000103-0000-0000-C000-000000000046"),
    InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumFORMATETC
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Next(
            [In, MarshalAs(UnmanagedType.U4)]
            int celt,
            [Out]
            FORMATETC rgelt,
            [In, Out, MarshalAs(UnmanagedType.LPArray)]
            int[] pceltFetched);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Skip(
            [In, MarshalAs(UnmanagedType.U4)]
            int celt);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Reset();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Clone(
            [Out, MarshalAs(UnmanagedType.LPArray)]
            IEnumFORMATETC[] ppenum);
    }

    [ComVisible(true), StructLayout(LayoutKind.Sequential)]
    public class COMRECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;

        public COMRECT()
        {
        }

        public COMRECT(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        public static COMRECT FromXYWH(int x, int y, int width, int height)
        {
            return new COMRECT(x, y, x + width, y + height);
        }
    }

    public enum GETOBJECTOPTIONS
    {
        REO_GETOBJ_NO_INTERFACES = 0x00000000,
        REO_GETOBJ_POLEOBJ = 0x00000001,
        REO_GETOBJ_PSTG = 0x00000002,
        REO_GETOBJ_POLESITE = 0x00000004,
        REO_GETOBJ_ALL_INTERFACES = 0x00000007,
    }

    public enum GETCLIPBOARDDATAFLAGS
    {
        RECO_PASTE = 0,
        RECO_DROP = 1,
        RECO_COPY = 2,
        RECO_CUT = 3,
        RECO_DRAG = 4
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CHARRANGE
    {
        public int cpMin;
        public int cpMax;
    }

    [StructLayout(LayoutKind.Sequential)]
    public class REOBJECT
    {
        public int cbStruct = Marshal.SizeOf(typeof(REOBJECT)); // Size of structure
        public int cp;                                          // Character position of object
        public Guid clsid;                                      // Class ID of object
        public IntPtr poleobj;                              // OLE object interface
        public IStorage pstg;                                   // Associated storage interface
        public IOleClientSite polesite;                         // Associated client site interface
        public Size sizel;                                      // Size of object (may be 0,0)
        public uint dvAspect;                                   // Display aspect to use
        public uint dwFlags;                                    // Object status flags
        public uint dwUser;                                     // Dword for user's use
    }

    [ComVisible(true), Guid("0000010F-0000-0000-C000-000000000046"), InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAdviseSink
    {

        //C#r: UNDONE (Field in interface) public static readonly    Guid iid;
        void OnDataChange(
            [In]
            FORMATETC pFormatetc,
            [In]
            STGMEDIUM pStgmed);

        void OnViewChange(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwAspect,
            [In, MarshalAs(UnmanagedType.I4)]
            int lindex);

        void OnRename(
            [In, MarshalAs(UnmanagedType.Interface)]
            object pmk);

        void OnSave();


        void OnClose();
    }

    [ComVisible(false), StructLayout(LayoutKind.Sequential)]
    public sealed class STATDATA
    {

        [MarshalAs(UnmanagedType.U4)]
        public int advf;
        [MarshalAs(UnmanagedType.U4)]
        public int dwConnection;

    }

    [ComVisible(false), StructLayout(LayoutKind.Sequential)]
    public sealed class tagOLEVERB
    {
        [MarshalAs(UnmanagedType.I4)]
        public int lVerb;

        [MarshalAs(UnmanagedType.LPWStr)]
        public String lpszVerbName;

        [MarshalAs(UnmanagedType.U4)]
        public int fuFlags;

        [MarshalAs(UnmanagedType.U4)]
        public int grfAttribs;

    }

    [ComVisible(true), ComImport(), Guid("00000104-0000-0000-C000-000000000046"), InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumOLEVERB
    {

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Next(
            [MarshalAs(UnmanagedType.U4)]
            int celt,
            [Out]
            tagOLEVERB rgelt,
            [Out, MarshalAs(UnmanagedType.LPArray)]
            int[] pceltFetched);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Skip(
            [In, MarshalAs(UnmanagedType.U4)]
            int celt);

        void Reset();


        void Clone(
            out IEnumOLEVERB ppenum);


    }

    [ComVisible(true), Guid("00000105-0000-0000-C000-000000000046"), InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumSTATDATA
    {

        //C#r: UNDONE (Field in interface) public static readonly    Guid iid;

        void Next(
            [In, MarshalAs(UnmanagedType.U4)]
            int celt,
            [Out]
            STATDATA rgelt,
            [Out, MarshalAs(UnmanagedType.LPArray)]
            int[] pceltFetched);


        void Skip(
            [In, MarshalAs(UnmanagedType.U4)]
            int celt);


        void Reset();


        void Clone(
            [Out, MarshalAs(UnmanagedType.LPArray)]
            IEnumSTATDATA[] ppenum);


    }

    [ComVisible(true), Guid("0000011B-0000-0000-C000-000000000046"), InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleContainer
    {


        void ParseDisplayName(
            [In, MarshalAs(UnmanagedType.Interface)] object pbc,
            [In, MarshalAs(UnmanagedType.BStr)]      string pszDisplayName,
            [Out, MarshalAs(UnmanagedType.LPArray)] int[] pchEaten,
            [Out, MarshalAs(UnmanagedType.LPArray)] object[] ppmkOut);


        void EnumObjects(
            [In, MarshalAs(UnmanagedType.U4)]        int grfFlags,
            [Out, MarshalAs(UnmanagedType.LPArray)] object[] ppenum);


        void LockContainer(
            [In, MarshalAs(UnmanagedType.I4)] int fLock);
    }

    [ComVisible(true),
    ComImport(),
    Guid("0000010E-0000-0000-C000-000000000046"),
    InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDataObject
    {
        [PreserveSig()]
        uint GetData(
            ref FORMATETC a,
            ref STGMEDIUM b);

        [PreserveSig()]
        uint GetDataHere(
            ref FORMATETC pFormatetc,
            out STGMEDIUM pMedium);

        [PreserveSig()]
        uint QueryGetData(
            ref FORMATETC pFormatetc);

        [PreserveSig()]
        uint GetCanonicalFormatEtc(
            ref FORMATETC pformatectIn,
            out FORMATETC pformatetcOut);

        [PreserveSig()]
        uint SetData(
            ref FORMATETC pFormatectIn,
            ref STGMEDIUM pmedium,
            [In, MarshalAs(UnmanagedType.Bool)]
            bool fRelease);

        [PreserveSig()]
        uint EnumFormatEtc(
            uint dwDirection, IEnumFORMATETC penum);

        [PreserveSig()]
        uint DAdvise(
            ref FORMATETC pFormatetc,
            int advf,
            [In, MarshalAs(UnmanagedType.Interface)]
            IAdviseSink pAdvSink,
            out uint pdwConnection);

        [PreserveSig()]
        uint DUnadvise(
            uint dwConnection);

        [PreserveSig()]
        uint EnumDAdvise(
            [Out, MarshalAs(UnmanagedType.Interface)]
            out IEnumSTATDATA ppenumAdvise);
    }

    [ComVisible(true), Guid("00000118-0000-0000-C000-000000000046"), InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleClientSite
    {

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SaveObject();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetMoniker(
            [In, MarshalAs(UnmanagedType.U4)]          int dwAssign,
            [In, MarshalAs(UnmanagedType.U4)]          int dwWhichMoniker,
            [Out, MarshalAs(UnmanagedType.Interface)] out object ppmk);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetContainer([MarshalAs(UnmanagedType.Interface)] out IOleContainer container);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ShowObject();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int OnShowWindow(
            [In, MarshalAs(UnmanagedType.I4)] int fShow);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int RequestNewObjectLayout();
    }

    [ComVisible(false), StructLayout(LayoutKind.Sequential)]
    public sealed class tagLOGPALETTE
    {
        [MarshalAs(UnmanagedType.U2)/*leftover(offset=0, palVersion)*/]
        public short palVersion;

        [MarshalAs(UnmanagedType.U2)/*leftover(offset=2, palNumEntries)*/]
        public short palNumEntries;

        // UNMAPPABLE: palPalEntry: Cannot be used as a structure field.
        //   /** @com.structmap(UNMAPPABLE palPalEntry) */
        //  public UNMAPPABLE palPalEntry;
    }

    [ComVisible(true), ComImport(), Guid("00000112-0000-0000-C000-000000000046"), InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOleObject
    {

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetClientSite(
            [In, MarshalAs(UnmanagedType.Interface)]
            IOleClientSite pClientSite);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetClientSite(out IOleClientSite site);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetHostNames(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string szContainerApp,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string szContainerObj);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Close(
            [In, MarshalAs(UnmanagedType.I4)]
            int dwSaveOption);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetMoniker(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwWhichMoniker,
            [In, MarshalAs(UnmanagedType.Interface)]
            object pmk);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetMoniker(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwAssign,
            [In, MarshalAs(UnmanagedType.U4)]
            int dwWhichMoniker,
            out object moniker);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int InitFromData(
            [In, MarshalAs(UnmanagedType.Interface)]
            IDataObject pDataObject,
            [In, MarshalAs(UnmanagedType.I4)]
            int fCreation,
            [In, MarshalAs(UnmanagedType.U4)]
            int dwReserved);

        int GetClipboardData(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwReserved,
            out IDataObject data);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int DoVerb(
            [In, MarshalAs(UnmanagedType.I4)]
            int iVerb,
            [In]
            IntPtr lpmsg,
            [In, MarshalAs(UnmanagedType.Interface)]
            IOleClientSite pActiveSite,
            [In, MarshalAs(UnmanagedType.I4)]
            int lindex,
            [In]
            IntPtr hwndParent,
            [In]
            COMRECT lprcPosRect);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int EnumVerbs(out IEnumOLEVERB e);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Update();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int IsUpToDate();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetUserClassID(
            [In, Out]
            ref Guid pClsid);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetUserType(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwFormOfType,
            [Out, MarshalAs(UnmanagedType.LPWStr)]
            out string userType);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetExtent(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwDrawAspect,
            [In]
            Size pSizel);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetExtent(
            [In, MarshalAs(UnmanagedType.U4)]
            int dwDrawAspect,
            [Out]
            Size pSizel);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Advise([In, MarshalAs(UnmanagedType.Interface)] IAdviseSink pAdvSink, out int cookie);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int Unadvise([In, MarshalAs(UnmanagedType.U4)] int dwConnection);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int EnumAdvise(out IEnumSTATDATA e);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetMiscStatus([In, MarshalAs(UnmanagedType.U4)] int dwAspect, out int misc);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetColorScheme([In] tagLOGPALETTE pLogpal);
    }

    [ComImport]
    [Guid("0000000d-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumSTATSTG
    {
        // The user needs to allocate an STATSTG array whose size is celt.
        [PreserveSig]
        uint
            Next(
            uint celt,
            [MarshalAs(UnmanagedType.LPArray), Out]
            //STATSTG[] rgelt,
            out uint pceltFetched
            );

        void Skip(uint celt);

        void Reset();

        [return: MarshalAs(UnmanagedType.Interface)]
        IEnumSTATSTG Clone();
    }

    [ComImport]
    [Guid("0000000b-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStorage
    {
        int CreateStream(
            /* [string][in] */ string pwcsName,
            /* [in] */ uint grfMode,
            /* [in] */ uint reserved1,
            /* [in] */ uint reserved2,
            /* [out] */ out IStream ppstm);

        int OpenStream(
            /* [string][in] */ string pwcsName,
            /* [unique][in] */ IntPtr reserved1,
            /* [in] */ uint grfMode,
            /* [in] */ uint reserved2,
            /* [out] */ out IStream ppstm);

        int CreateStorage(
            /* [string][in] */ string pwcsName,
            /* [in] */ uint grfMode,
            /* [in] */ uint reserved1,
            /* [in] */ uint reserved2,
            /* [out] */ out IStorage ppstg);

        int OpenStorage(
            /* [string][unique][in] */ string pwcsName,
            /* [unique][in] */ IStorage pstgPriority,
            /* [in] */ uint grfMode,
            /* [unique][in] */ IntPtr snbExclude,
            /* [in] */ uint reserved,
            /* [out] */ out IStorage ppstg);

        int CopyTo(
            /* [in] */ uint ciidExclude,
            /* [size_is][unique][in] */ Guid rgiidExclude,
            /* [unique][in] */ IntPtr snbExclude,
            /* [unique][in] */ IStorage pstgDest);

        int MoveElementTo(
            /* [string][in] */ string pwcsName,
            /* [unique][in] */ IStorage pstgDest,
            /* [string][in] */ string pwcsNewName,
            /* [in] */ uint grfFlags);

        int Commit(
            /* [in] */ uint grfCommitFlags);

        int Revert();

        int EnumElements(
            /* [in] */ uint reserved1,
            /* [size_is][unique][in] */ IntPtr reserved2,
            /* [in] */ uint reserved3,
            /* [out] */ out IEnumSTATSTG ppenum);

        int DestroyElement(
            /* [string][in] */ string pwcsName);

        int RenameElement(
            /* [string][in] */ string pwcsOldName,
            /* [string][in] */ string pwcsNewName);

        //int SetElementTimes(
        //    /* [string][unique][in] */ string pwcsName,
        //    /* [unique][in] */ FILETIME pctime,
        //    /* [unique][in] */ FILETIME patime,
        //    /* [unique][in] */ FILETIME pmtime);

        int SetClass(
            /* [in] */ Guid clsid);

        int SetStateBits(
            /* [in] */ uint grfStateBits,
            /* [in] */ uint grfMask);

        //int Stat(
        //    /* [out] */ out STATSTG pstatstg,
        //    /* [in] */ uint grfStatFlag);

    }

    [ComImport]
    [Guid("0000000a-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ILockBytes
    {
        int ReadAt(
        /* [in] */ ulong ulOffset,
        /* [unique][out] */ IntPtr pv,
        /* [in] */ uint cb,
        /* [out] */ out IntPtr pcbRead);

        int WriteAt(
        /* [in] */ ulong ulOffset,
        /* [size_is][in] */ IntPtr pv,
        /* [in] */ uint cb,
        /* [out] */ out IntPtr pcbWritten);

        int Flush();

        int SetSize(
        /* [in] */ ulong cb);

        int LockRegion(
        /* [in] */ ulong libOffset,
        /* [in] */ ulong cb,
        /* [in] */ uint dwLockType);

        int UnlockRegion(
        /* [in] */ ulong libOffset,
        /* [in] */ ulong cb,
        /* [in] */ uint dwLockType);

        //int Stat(
        ///* [out] */ out STATSTG pstatstg,
        ///* [in] */ uint grfStatFlag);

    }

    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0c733a30-2a1c-11ce-ade5-00aa0044773d")]
    public interface ISequentialStream
    {
        int Read(
        /* [length_is][size_is][out] */ IntPtr pv,
        /* [in] */ uint cb,
        /* [out] */ out uint pcbRead);

        int Write(
        /* [size_is][in] */ IntPtr pv,
        /* [in] */ uint cb,
        /* [out] */ out uint pcbWritten);

    };

    [ComImport]
    [Guid("0000000c-0000-0000-C000-000000000046")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStream : ISequentialStream
    {
        int Seek(
        /* [in] */ ulong dlibMove,
        /* [in] */ uint dwOrigin,
        /* [out] */ out ulong plibNewPosition);

        int SetSize(
        /* [in] */ ulong libNewSize);

        int CopyTo(
        /* [unique][in] */ [In] IStream pstm,
        /* [in] */ ulong cb,
        /* [out] */ out ulong pcbRead,
        /* [out] */ out ulong pcbWritten);

        int Commit(
        /* [in] */ uint grfCommitFlags);

        int Revert();

        int LockRegion(
        /* [in] */ ulong libOffset,
        /* [in] */ ulong cb,
        /* [in] */ uint dwLockType);

        int UnlockRegion(
        /* [in] */ ulong libOffset,
        /* [in] */ ulong cb,
        /* [in] */ uint dwLockType);

        //int Stat(
        ///* [out] */ out STATSTG pstatstg,
        ///* [in] */ uint grfStatFlag);

        int Clone(
        /* [out] */ out IStream ppstm);

    };

    /// <summary>
    /// Definition for interface IPersist.
    /// </summary>
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0000010c-0000-0000-C000-000000000046")]
    public interface IPersist
    {
        /// <summary>
        /// getClassID
        /// </summary>
        /// <param name="pClassID"></param>
        void GetClassID( /* [out] */ out Guid pClassID);
    }

    /// <summary>
    /// Definition for interface IPersistStream.
    /// </summary>
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("00000109-0000-0000-C000-000000000046")]
    public interface IPersistStream : IPersist
    {
        /// <summary>
        /// GetClassID
        /// </summary>
        /// <param name="pClassID"></param>
        new void GetClassID(out Guid pClassID);
        /// <summary>
        /// isDirty
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        int IsDirty();
        /// <summary>
        /// Load
        /// </summary>
        /// <param name="pStm"></param>
        //void Load([In] UCOMIStream pStm);
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="pStm"></param>
        /// <param name="fClearDirty"></param>
        //void Save([In] UCOMIStream pStm, [In, MarshalAs(UnmanagedType.Bool)] bool fClearDirty);
        /// <summary>
        /// GetSizeMax
        /// </summary>
        /// <param name="pcbSize"></param>
        void GetSizeMax(out long pcbSize);
    }

    [ComImport(), Guid("00020D00-0000-0000-c000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRichEditOle
    {
        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetClientSite(out IOleClientSite site);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetObjectCount();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetLinkCount();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetObject(int iob, [In, Out] REOBJECT lpreobject, [MarshalAs(UnmanagedType.U4)]GETOBJECTOPTIONS flags);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int InsertObject(REOBJECT lpreobject);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ConvertObject(int iob, Guid rclsidNew, string lpstrUserTypeNew);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ActivateAs(Guid rclsid, Guid rclsidAs);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetHostNames(string lpstrContainerApp, string lpstrContainerObj);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetLinkAvailable(int iob, bool fAvailable);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SetDvaspect(int iob, uint dvaspect);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int HandsOffStorage(int iob);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int SaveCompleted(int iob, IStorage lpstg);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int InPlaceDeactivate();

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ContextSensitiveHelp(bool fEnterMode);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int GetClipboardData([In, Out] ref CHARRANGE lpchrg, [MarshalAs(UnmanagedType.U4)] GETCLIPBOARDDATAFLAGS reco, out IDataObject lplpdataobj);

        [return: MarshalAs(UnmanagedType.I4)]
        [PreserveSig]
        int ImportDataObject(IDataObject lpdataobj, int cf, IntPtr hMetaPict);
    }
    #endregion

    public class myDataObject : IDataObject
    {
        private Bitmap mBitmap;
        public FORMATETC mpFormatetc;

        #region IDataObject Members

        private const uint S_OK = 0;
        private const uint E_POINTER = 0x80004003;
        private const uint E_NOTIMPL = 0x80004001;
        private const uint E_FAIL = 0x80004005;

        public uint GetData(ref FORMATETC pFormatetc, ref STGMEDIUM pMedium)
        {
            IntPtr hDst = mBitmap.GetHbitmap();

            pMedium.tymed = (int)TYMED.TYMED_GDI;
            pMedium.unionmember = hDst;
            pMedium.pUnkForRelease = IntPtr.Zero;

            return (uint)S_OK;
        }

        public uint GetDataHere(ref FORMATETC pFormatetc, out STGMEDIUM pMedium)
        {
            Trace.WriteLine("GetDataHere");

            pMedium = new STGMEDIUM();

            return (uint)E_NOTIMPL;
        }

        public uint QueryGetData(ref FORMATETC pFormatetc)
        {
            Trace.WriteLine("QueryGetData");

            return (uint)E_NOTIMPL;
        }

        public uint GetCanonicalFormatEtc(ref FORMATETC pFormatetcIn, out FORMATETC pFormatetcOut)
        {
            Trace.WriteLine("GetCanonicalFormatEtc");

            pFormatetcOut = new FORMATETC();

            return (uint)E_NOTIMPL;
        }

        public uint SetData(ref FORMATETC a, ref STGMEDIUM b, bool fRelease)
        {
            //mpFormatetc = pFormatectIn;
            //mpmedium = pmedium;

            Trace.WriteLine("SetData");

            return (int)S_OK;
        }

        public uint EnumFormatEtc(uint dwDirection, IEnumFORMATETC penum)
        {
            Trace.WriteLine("EnumFormatEtc");

            return (int)S_OK;
        }

        public uint DAdvise(ref FORMATETC a, int advf, IAdviseSink pAdvSink, out uint pdwConnection)
        {
            Trace.WriteLine("DAdvise");

            pdwConnection = 0;

            return (uint)E_NOTIMPL;
        }

        public uint DUnadvise(uint dwConnection)
        {
            Trace.WriteLine("DUnadvise");

            return (uint)E_NOTIMPL;
        }

        public uint EnumDAdvise(out IEnumSTATDATA ppenumAdvise)
        {
            Trace.WriteLine("EnumDAdvise");

            ppenumAdvise = null;

            return (uint)E_NOTIMPL;
        }

        #endregion

        public myDataObject()
        {
            mBitmap = new Bitmap(16, 16);
            mpFormatetc = new FORMATETC();
        }

        public void SetImage(string strFilename)
        {
            try
            {
                mBitmap = (Bitmap)Bitmap.FromFile(strFilename, true);

                mpFormatetc.cfFormat = CLIPFORMAT.CF_BITMAP;                // Clipboard format = CF_BITMAP
                mpFormatetc.ptd = IntPtr.Zero;                          // Target Device = Screen
                mpFormatetc.dwAspect = DVASPECT.DVASPECT_CONTENT;           // Level of detail = Full content
                mpFormatetc.lindex = -1;                            // Index = Not applicaple
                mpFormatetc.tymed = TYMED.TYMED_GDI;                    // Storage medium = HBITMAP handle
            }
            catch
            {
            }
        }

        public void SetImage(Image image)
        {
            try
            {
                mBitmap = new Bitmap(image);

                mpFormatetc.cfFormat = CLIPFORMAT.CF_BITMAP;                // Clipboard format = CF_BITMAP
                mpFormatetc.ptd = IntPtr.Zero;                          // Target Device = Screen
                mpFormatetc.dwAspect = DVASPECT.DVASPECT_CONTENT;           // Level of detail = Full content
                mpFormatetc.lindex = -1;                            // Index = Not applicaple
                mpFormatetc.tymed = TYMED.TYMED_GDI;                    // Storage medium = HBITMAP handle
            }
            catch
            {
            }
        }
    }

    public class MyFixedRichTextBox : RichTextBox
    {
        private bool ignoreMouse = false;
        private List<string> emojiCodes = EmojiCodes.getEmojiCodes();
        private EmojiPanel emojiPanel;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public MyFixedRichTextBox() : this(false) { }
        public MyFixedRichTextBox(bool ignoreMouse = false) : base()
        {
            this.ignoreMouse = ignoreMouse;
            this.MouseDown += new MouseEventHandler(richTextBox_MouseDown);
        }

        public void setEmojiRef(EmojiPanel emojiPanel)
        {
            this.emojiPanel = emojiPanel;
        }

        private void richTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Cut");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Select All");
                menuItem.Click += new EventHandler(SelectAll);
                contextMenu.MenuItems.Add(menuItem);
                this.ContextMenu = contextMenu;
            }
        }

        void CutAction(object sender, EventArgs e)
        {
            if (GetObjectCount(this) > 0 && this.SelectedText != "")
            {
                RichEditOle ole = new RichEditOle(this);
                Clipboard.SetText(ole.DecodeEmoji(emojiCodes, this.SelectedText, true));
                ole.RemoveText(this.SelectionStart, this.SelectedText.Length,emojiPanel);
                //this.Text.Remove(this.Selection)
            }
            else this.Cut();
        }

        void CopyAction(object sender, EventArgs e)
        {
            if (this.SelectedText != "")
            {
                if (GetObjectCount(this) > 0)
                {
                    RichEditOle ole = new RichEditOle(this);
                    Clipboard.SetText(ole.DecodeEmoji(emojiCodes, this.SelectedText, true));
                }
                else
                    Clipboard.SetText(this.SelectedText);
            }
            else
                Clipboard.Clear();
        }

        void PasteAction(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                InsertText(this, this.SelectionStart, Clipboard.GetText(TextDataFormat.Text), emojiPanel);


                //this.AppendText(Clipboard.GetText(TextDataFormat.Text).ToString());
                ///this.Select(this.Text.Length, 0);
                //this.ScrollToCaret();
            }
        }

        void SelectAll(object sender, EventArgs e)
        {
            this.SelectAll();
            this.Focus();
        }

        //Rich Text Box Bug Fix...Remove Blinking cursor and ignoring mouse scrolling
        protected override void WndProc(ref Message m)
        {
            //Send WM_MOUSEWHEEL messages to the parent
            if (ignoreMouse)
            {
                if (m.Msg == 0x20a && this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
                    SendMessage(this.Parent.Handle, m.Msg, m.WParam, m.LParam);
                else
                    base.WndProc(ref m);
                HideCaret(this.Handle);
            }
            else
                base.WndProc(ref m);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!base.AutoWordSelection)
            {
                base.AutoWordSelection = true;
                base.AutoWordSelection = false;
            }
        }

        #region Imports and structs

        // It makes no difference if we use PARAFORMAT or
        // PARAFORMAT2 here, so I have opted for PARAFORMAT2.
        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;

            // PARAFORMAT2 from here onwards.
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CHARFORMAT
        {
            public int cbSize;
            public UInt32 dwMask;
            public UInt32 dwEffects;
            public Int32 yHeight;
            public Int32 yOffset;
            public Int32 crTextColor;
            public byte bCharSet;
            public byte bPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szFaceName;

            // CHARFORMAT2 from here onwards.
            public short wWeight;
            public short sSpacing;
            public Int32 crBackColor;
            public uint lcid;
            public uint dwReserved;
            public short sStyle;
            public short wKerning;
            public byte bUnderlineType;
            public byte bAnimation;
            public byte bRevAuthor;
            public byte bReserved1;
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(HandleRef hWnd,
            int msg,
            int wParam,
            int lParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(HandleRef hWnd,
            int msg,
            int wParam,
            ref PARAFORMAT lp);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern int SendMessage(HandleRef hWnd,
            int msg,
            int wParam,
            ref CHARFORMAT lp);

        private const int EM_SETEVENTMASK = 1073;
        private const int WM_SETREDRAW = 11;

        [DllImport("User32.dll", CharSet = CharSet.Auto, PreserveSig = false)]
        public static extern IRichEditOle SendMessage(IntPtr hWnd, int message, int wParam);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern bool GetClientRect(IntPtr hWnd, [In, Out] ref Rectangle rect);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern bool GetWindowRect(IntPtr hWnd, [In, Out] ref Rectangle rect);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("ole32.dll")]
        static extern int OleSetContainedObject([MarshalAs(UnmanagedType.IUnknown)]
            object pUnk, bool fContained);

        [DllImport("ole32.dll")]
        static extern int OleLoadPicturePath(
            [MarshalAs(UnmanagedType.LPWStr)] string lpszPicturePath,
            [MarshalAs(UnmanagedType.IUnknown)][In] object pIUnknown,
            uint dwReserved,
            uint clrReserved,
            ref Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        [DllImport("ole32.dll")]
        static extern int OleCreateFromFile([In] ref Guid rclsid,
            [MarshalAs(UnmanagedType.LPWStr)] string lpszFileName, [In] ref Guid riid,
            uint renderopt, ref FORMATETC pFormatEtc, IOleClientSite pClientSite,
            IStorage pStg, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        [DllImport("ole32.dll")]
        static extern int OleCreateFromData(IDataObject pSrcDataObj,
            [In] ref Guid riid, uint renderopt, ref FORMATETC pFormatEtc,
            IOleClientSite pClientSite, IStorage pStg,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        [DllImport("ole32.dll")]
        static extern int OleCreateStaticFromData([MarshalAs(UnmanagedType.Interface)]IDataObject pSrcDataObj,
            [In] ref Guid riid, uint renderopt, ref FORMATETC pFormatEtc,
            IOleClientSite pClientSite, IStorage pStg,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        [DllImport("ole32.dll")]
        static extern int OleCreateLinkFromData([MarshalAs(UnmanagedType.Interface)]IDataObject pSrcDataObj,
            [In] ref Guid riid, uint renderopt, ref FORMATETC pFormatEtc,
            IOleClientSite pClientSite, IStorage pStg,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

        #endregion

        public void InsertOleObject(IOleObject oleObj)
        {
            RichEditOle ole = new RichEditOle(this);
            ole.InsertOleObject(oleObj);
        }

        public string DecodeEmoji(List<string> emojiCodes, string message)
        {
            RichEditOle ole = new RichEditOle(this);
            return ole.DecodeEmoji(emojiCodes,message);
        }

        public static void InsertText(MyFixedRichTextBox msgBox, int index, string message, EmojiPanel emojiPanel)
        {
            RichEditOle ole = new RichEditOle(msgBox);
            ole.InsertText(index, message, emojiPanel);
        }

        public static void AppendText(MyFixedRichTextBox msgBox,string message,EmojiPanel emoji)
        {
            RichEditOle ole = new RichEditOle(msgBox);
            ole.AppendText(message,emoji);
        }

        public int GetObjectCount(MyFixedRichTextBox msgBox)
        {
            RichEditOle ole = new RichEditOle(msgBox);
            return ole.GetObjectCount();
        }

        public void InsertControl(Control control,int eIndex)
        {
            RichEditOle ole = new RichEditOle(this);
            ole.InsertControl(control,eIndex);
        }

        public void InsertMyDataObject(myDataObject mdo)
        {
            RichEditOle ole = new RichEditOle(this);
            ole.InsertMyDataObject(mdo);
        }

        public void UpdateObjects()
        {
            RichEditOle ole = new RichEditOle(this);
            ole.UpdateObjects();
        }

        public void InsertImage(Image image)
        {
            myDataObject mdo = new myDataObject();

            mdo.SetImage(image);

            this.InsertMyDataObject(mdo);
        }

        public void InsertImage(string imageFile)
        {
            myDataObject mdo = new myDataObject();

            mdo.SetImage(imageFile);

            this.InsertMyDataObject(mdo);
        }

        public void InsertImageFromFile(string strFilename)
        {
            RichEditOle ole = new RichEditOle(this);
            ole.InsertImageFromFile(strFilename);
        }

        public void InsertActiveX(string strProgID)
        {
            Type t = Type.GetTypeFromProgID(strProgID);
            if (t == null)
                return;

            object o = System.Activator.CreateInstance(t);

            bool b = (o is IOleObject);

            if (b)
                this.InsertOleObject((IOleObject)o);
        }

        // RichEditOle wrapper and helper
        class RichEditOle
        {
            public const int WM_USER = 0x0400;
            public const int EM_GETOLEINTERFACE = WM_USER + 60;

            private MyFixedRichTextBox _richEdit;
            private IRichEditOle _RichEditOle;

            public RichEditOle(MyFixedRichTextBox richEdit)
            {
                this._richEdit = richEdit;
            }

            private IRichEditOle IRichEditOle
            {
                get
                {
                    if (this._RichEditOle == null)
                    {
                        this._RichEditOle = SendMessage(this._richEdit.Handle, EM_GETOLEINTERFACE, 0);
                    }

                    return this._RichEditOle;
                }
            }

            [DllImport("ole32.dll", PreserveSig = false)]
            internal static extern int CreateILockBytesOnHGlobal(IntPtr hGlobal, bool fDeleteOnRelease, [Out] out ILockBytes ppLkbyt);

            [DllImport("ole32.dll")]
            static extern int StgCreateDocfileOnILockBytes(ILockBytes plkbyt, uint grfMode,
                uint reserved, out IStorage ppstgOpen);

            public void InsertControl(Control control,int eIndex)
            {
                if (control == null)
                    return;

                //Guid guid = Marshal.GenerateGuidForType(control.GetType());

                //-----------------------
                //ILockBytes pLockBytes;
                //CreateILockBytesOnHGlobal(IntPtr.Zero, true, out pLockBytes);

                //IStorage pStorage;
                //StgCreateDocfileOnILockBytes(pLockBytes, (uint)(STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_CREATE | STGM.STGM_READWRITE), 0, out pStorage);

                IOleClientSite pOleClientSite;
                this.IRichEditOle.GetClientSite(out pOleClientSite);
                //-----------------------

                //-----------------------
                REOBJECT reoObject = new REOBJECT();
                reoObject.cp = this._richEdit.SelectionStart;// this._richEdit.TextLength;
                //reoObject.clsid = guid;
                //reoObject.pstg = pStorage;
                reoObject.poleobj = Marshal.GetIUnknownForObject(control);
                reoObject.polesite = pOleClientSite;
                reoObject.dvAspect = (uint)(DVASPECT.DVASPECT_CONTENT);
                reoObject.dwFlags = (uint)(REOOBJECTFLAGS.REO_BELOWBASELINE);
                reoObject.dwUser = (uint)eIndex;

                this.IRichEditOle.InsertObject(reoObject);
                //-----------------------

                //-----------------------
              //  Marshal.ReleaseComObject(pLockBytes);
              //  Marshal.ReleaseComObject(pOleClientSite);
               // Marshal.ReleaseComObject(pStorage);
                //-----------------------
            }

            public bool InsertImageFromFile(string strFilename)
            {
                //-----------------------
                ILockBytes pLockBytes;
                CreateILockBytesOnHGlobal(IntPtr.Zero, true, out pLockBytes);

                IStorage pStorage;
                StgCreateDocfileOnILockBytes(pLockBytes, (uint)(STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_CREATE | STGM.STGM_READWRITE), 0, out pStorage);

                IOleClientSite pOleClientSite;
                this.IRichEditOle.GetClientSite(out pOleClientSite);
                //-----------------------


                //-----------------------
                FORMATETC formatEtc = new FORMATETC();

                formatEtc.cfFormat = 0;
                formatEtc.ptd = IntPtr.Zero;
                formatEtc.dwAspect = DVASPECT.DVASPECT_CONTENT;
                formatEtc.lindex = -1;
                formatEtc.tymed = TYMED.TYMED_NULL;

                Guid IID_IOleObject = new Guid("{00000112-0000-0000-C000-000000000046}");
                Guid CLSID_NULL = new Guid("{00000000-0000-0000-0000-000000000000}");

                object pOleObjectOut;

                // I don't sure, but it appears that this function only loads from bitmap
                // You can also try OleCreateFromData, OleLoadPictureIndirect, etc.
                int hr = OleCreateFromFile(ref CLSID_NULL, strFilename, ref IID_IOleObject, (uint)OLERENDER.OLERENDER_DRAW, ref formatEtc, pOleClientSite, pStorage, out pOleObjectOut);

                if (pOleObjectOut == null)
                {
                    Marshal.ReleaseComObject(pLockBytes);
                    Marshal.ReleaseComObject(pOleClientSite);
                    Marshal.ReleaseComObject(pStorage);

                    return false;
                }

                IOleObject pOleObject = (IOleObject)pOleObjectOut;
                //-----------------------


                //-----------------------
                Guid guid = new Guid();

                //guid = Marshal.GenerateGuidForType(pOleObject.GetType());
                pOleObject.GetUserClassID(ref guid);
                //-----------------------

                //-----------------------
                OleSetContainedObject(pOleObject, true);

                REOBJECT reoObject = new REOBJECT();

                reoObject.cp = this._richEdit.TextLength;

                reoObject.clsid = guid;
                reoObject.pstg = pStorage;
                reoObject.poleobj = Marshal.GetIUnknownForObject(pOleObject);
                reoObject.polesite = pOleClientSite;
                reoObject.dvAspect = (uint)(DVASPECT.DVASPECT_CONTENT);
                reoObject.dwFlags = (uint)(REOOBJECTFLAGS.REO_BELOWBASELINE);
                reoObject.dwUser = 0;

                this.IRichEditOle.InsertObject(reoObject);
                //-----------------------

                //-----------------------
                Marshal.ReleaseComObject(pLockBytes);
                Marshal.ReleaseComObject(pOleClientSite);
                Marshal.ReleaseComObject(pStorage);
                Marshal.ReleaseComObject(pOleObject);
                //-----------------------

                return true;
            }

            public void InsertMyDataObject(myDataObject mdo)
            {
                if (mdo == null)
                    return;

                //-----------------------
                ILockBytes pLockBytes;
                int sc = CreateILockBytesOnHGlobal(IntPtr.Zero, true, out pLockBytes);

                IStorage pStorage;
                sc = StgCreateDocfileOnILockBytes(pLockBytes, (uint)(STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_CREATE | STGM.STGM_READWRITE), 0, out pStorage);

                IOleClientSite pOleClientSite;
                this.IRichEditOle.GetClientSite(out pOleClientSite);
                //-----------------------

                Guid guid = Marshal.GenerateGuidForType(mdo.GetType());

                Guid IID_IOleObject = new Guid("{00000112-0000-0000-C000-000000000046}");
                Guid IID_IDataObject = new Guid("{0000010e-0000-0000-C000-000000000046}");
                Guid IID_IUnknown = new Guid("{00000000-0000-0000-C000-000000000046}");

                object pOleObject;

                int hr = OleCreateStaticFromData(mdo, ref IID_IOleObject, (uint)OLERENDER.OLERENDER_FORMAT, ref mdo.mpFormatetc, pOleClientSite, pStorage, out pOleObject);

                if (pOleObject == null)
                    return;
                //-----------------------


                //-----------------------
                OleSetContainedObject(pOleObject, true);

                REOBJECT reoObject = new REOBJECT();

                reoObject.cp = this._richEdit.TextLength;

                reoObject.clsid = guid;
                reoObject.pstg = pStorage;
                reoObject.poleobj = Marshal.GetIUnknownForObject(pOleObject);
                reoObject.polesite = pOleClientSite;
                reoObject.dvAspect = (uint)(DVASPECT.DVASPECT_CONTENT);
                reoObject.dwFlags = (uint)(REOOBJECTFLAGS.REO_BELOWBASELINE);
                reoObject.dwUser = 0;

                this.IRichEditOle.InsertObject(reoObject);
                //-----------------------

                //-----------------------
                Marshal.ReleaseComObject(pLockBytes);
                Marshal.ReleaseComObject(pOleClientSite);
                Marshal.ReleaseComObject(pStorage);
                Marshal.ReleaseComObject(pOleObject);
                //-----------------------
            }

            public void InsertOleObject(IOleObject oleObject)
            {
                if (oleObject == null)
                    return;

                //-----------------------
                ILockBytes pLockBytes;
                CreateILockBytesOnHGlobal(IntPtr.Zero, true, out pLockBytes);

                IStorage pStorage;
                StgCreateDocfileOnILockBytes(pLockBytes, (uint)(STGM.STGM_SHARE_EXCLUSIVE | STGM.STGM_CREATE | STGM.STGM_READWRITE), 0, out pStorage);

                IOleClientSite pOleClientSite;
                this.IRichEditOle.GetClientSite(out pOleClientSite);
                //-----------------------

                //-----------------------
                Guid guid = new Guid();

                oleObject.GetUserClassID(ref guid);
                //-----------------------

                //-----------------------
                OleSetContainedObject(oleObject, true);

                REOBJECT reoObject = new REOBJECT();

                reoObject.cp = this._richEdit.TextLength;
                reoObject.clsid = guid;
                reoObject.pstg = pStorage;
                reoObject.poleobj = Marshal.GetIUnknownForObject(oleObject);
                reoObject.polesite = pOleClientSite;
                reoObject.dvAspect = (uint)DVASPECT.DVASPECT_CONTENT;
                reoObject.dwFlags = (uint)REOOBJECTFLAGS.REO_BELOWBASELINE;

                this.IRichEditOle.InsertObject(reoObject);
                //-----------------------

                //-----------------------
                Marshal.ReleaseComObject(pLockBytes);
                Marshal.ReleaseComObject(pOleClientSite);
                Marshal.ReleaseComObject(pStorage);
                //-----------------------
            }

            public void UpdateObjects()
            {
                int k = this.IRichEditOle.GetObjectCount();

                for (int i = 0; i < k; i++)
                {
                    REOBJECT reoObject = new REOBJECT();

                    this.IRichEditOle.GetObject(i, reoObject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);

                    MessageBox.Show("" + reoObject.dwUser);

                    if (reoObject.dwUser == 1)
                    {
                        Point pt = this._richEdit.GetPositionFromCharIndex(reoObject.cp);
                        Rectangle rect = new Rectangle(pt, reoObject.sizel);

                        this._richEdit.Invalidate(rect, false); // repaint
                    }
                }
            }

            public string DecodeEmoji(List<string> emojiCodes, string message, bool selectedRange = false)
            {
                int emojiCount = this.IRichEditOle.GetObjectCount();
                //int lastInsert = 0;

                //Only used if selectedRange is true
                int start = this._richEdit.SelectionStart;
                int end = start+this._richEdit.SelectedText.Length-1;
                
                for (int a = emojiCount-1; a > -1; a--)
                {
                    REOBJECT reoObject = new REOBJECT();
                    this.IRichEditOle.GetObject(a, reoObject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);

                    //do all objects
                    if (!selectedRange)
                    {
                        message = message.Remove(reoObject.cp, 1);
                        message = message.Insert(reoObject.cp, emojiCodes[(int)reoObject.dwUser]);
                        //lastInsert += emojiCodes[(int)reoObject.dwUser].Length - 1;
                    }
                    else//Only do objects within range
                    {
                        if(reoObject.cp >= start && reoObject.cp <= end)
                        {
                            message = message.Remove(reoObject.cp-start, 1);
                            message = message.Insert(reoObject.cp-start, emojiCodes[(int)reoObject.dwUser]);
                            //lastInsert += emojiCodes[(int)reoObject.dwUser].Length - 1;
                        }
                    }
                }
                return message;
            }

            //Doing it the long way...huhhh
            public void InsertText(int index,string message, EmojiPanel emojiPanel)
            {
                List<string> emojiCodes = emojiPanel.getEmojiCodes();
                int indexGrowth = 0;//How many indexs has the decoding moved the insertion point
                int emojiCount = this.IRichEditOle.GetObjectCount();
                for (int a = emojiCount - 1; a > -1; a--)
                {
                    REOBJECT reoObject = new REOBJECT();
                    this.IRichEditOle.GetObject(a, reoObject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);

                    if (reoObject.cp < index)
                        indexGrowth += emojiCodes[(int)reoObject.dwUser].Length - 1;
                }
                
                string currentMessage = DecodeEmoji(emojiCodes, this._richEdit.Text);
                currentMessage = currentMessage.Insert(index + indexGrowth, message);

                // string text = DecodeEmoji(emojiPanel.getEmojiCodes(), this._richEdit.Text);
                ///MessageBox.Show(text);
                int messageLength = this._richEdit.Text.Length;
                this._richEdit.Text = "";
                AppendText(currentMessage,emojiPanel);
                messageLength = this._richEdit.Text.Length - messageLength;
                this._richEdit.SelectionStart = index+ messageLength;
            }

            //Doing it the long way...huhhh
            public void AppendText(string message,EmojiPanel emojiPanel)
            {
                List<int> codeIndex = new List<int>();
                List<Image> emojiImage = new List<Image>();
                List<string> codes = emojiPanel.getEmojiCodes();
                List<int> usedIndex = new List<int>();

                for (int a = 0; a < codes.Count; a++)
                    if (message.Contains(codes[a]))
                        usedIndex.Add(a);

                if (usedIndex.Count > 0)
                    for (int a = 0; a < message.Length; a++)
                    {
                        for (int b = 0; b < usedIndex.Count; b++)
                        {
                            if (message.Length > a + codes[usedIndex[b]].Length - 1)
                                if (message.Substring(a, codes[usedIndex[b]].Length) == codes[usedIndex[b]])
                                {
                                    message = message.Remove(a, codes[usedIndex[b]].Length);
                                    codeIndex.Add(a+this._richEdit.Text.Length);
                                    emojiImage.Add(emojiPanel.getEmojiPics()[usedIndex[b]].Image);
                                    a--;
                                    break;
                                }
                        }
                    }

                this._richEdit.AppendText(message);

                for (int a = codeIndex.Count - 1; a > -1; a--)
                {
                    this._richEdit.SelectionStart = codeIndex[a];
                    this._richEdit.InsertControl(emojiPanel.getEmoji(emojiImage[a], this._richEdit.BackColor, 25), emojiPanel.getEmojiPics().FindIndex(x => x.Image.Equals(emojiImage[a])));
                }
            }

            public void RemoveText(int startIndex,int count,EmojiPanel emojiPanel)
            {
                int emojiCount = this.IRichEditOle.GetObjectCount();

                List<int> emojiIndex = new List<int>();
                List<Image> emojiImage = new List<Image>();

                string newText = this._richEdit.Text;
                 newText = newText.Remove(startIndex, count);

                //MessageBox.Show("" + emojiCount);

                for (int a = emojiCount-1; a > -1;a--)
                {
                    REOBJECT reoObject = new REOBJECT();
                    this.IRichEditOle.GetObject(a, reoObject, GETOBJECTOPTIONS.REO_GETOBJ_ALL_INTERFACES);
                    if (reoObject.cp < startIndex || reoObject.cp > (startIndex+(count-1)))
                    {
                        emojiImage.Add(emojiPanel.getEmojiPics()[(int)reoObject.dwUser].Image);
                        if (reoObject.cp < startIndex)
                        {
                            emojiIndex.Add(reoObject.cp);
                            newText = newText.Remove(reoObject.cp, 1);
                        }
                        else
                        {
                            emojiIndex.Add(reoObject.cp - this._richEdit.SelectedText.Length);
                            newText = newText.Remove(reoObject.cp - (this._richEdit.SelectedText.Length), 1);
                        }
                    }
                }
                //MessageBox.Show(newText);

                this._richEdit.Text = newText;

                for (int a = emojiIndex.Count - 1; a > -1; a--)
                {
                    this._richEdit.SelectionStart = emojiIndex[a];
                    this._richEdit.InsertControl(emojiPanel.getEmoji(emojiImage[a], this._richEdit.BackColor, 25), emojiPanel.getEmojiPics().FindIndex(x => x.Image.Equals(emojiImage[a])));
                }
            }

            public int GetObjectCount()
            {
                return this.IRichEditOle.GetObjectCount();
            }
        }
    }
}
