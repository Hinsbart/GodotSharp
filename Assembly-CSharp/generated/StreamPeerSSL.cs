/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class StreamPeerSSL : StreamPeer {
  public static readonly int STATUS_DISCONNECTED = 0;
  public static readonly int STATUS_CONNECTED = 1;
  public static readonly int STATUS_ERROR_NO_CERTIFICATE = 2;
  public static readonly int STATUS_ERROR_HOSTNAME_MISMATCH = 3;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal StreamPeerSSL(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.StreamPeerSSL_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected StreamPeerSSL(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.StreamPeerSSL_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StreamPeerSSL obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamPeerSSL() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_StreamPeerSSL(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  public int accept(StreamPeer stream) {
    int ret = GodotEnginePINVOKE.StreamPeerSSL_accept(swigCPtr, StreamPeer.getCPtr(stream));
    return ret;
  }

  public int connect(StreamPeer stream, bool validate_certs, string for_hostname) {
    int ret = GodotEnginePINVOKE.StreamPeerSSL_connect__SWIG_0(swigCPtr, StreamPeer.getCPtr(stream), validate_certs, for_hostname);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int connect(StreamPeer stream, bool validate_certs) {
    int ret = GodotEnginePINVOKE.StreamPeerSSL_connect__SWIG_1(swigCPtr, StreamPeer.getCPtr(stream), validate_certs);
    return ret;
  }

  public int connect(StreamPeer stream) {
    int ret = GodotEnginePINVOKE.StreamPeerSSL_connect__SWIG_2(swigCPtr, StreamPeer.getCPtr(stream));
    return ret;
  }

  public int get_status() {
    int ret = GodotEnginePINVOKE.StreamPeerSSL_get_status(swigCPtr);
    return ret;
  }

  public void disconnect() {
    GodotEnginePINVOKE.StreamPeerSSL_disconnect(swigCPtr);
  }

  public StreamPeerSSL() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_StreamPeerSSL());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
