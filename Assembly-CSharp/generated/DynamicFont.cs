/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class DynamicFont : Font {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal DynamicFont(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.DynamicFont_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected DynamicFont(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.DynamicFont_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DynamicFont obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DynamicFont() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_DynamicFont(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  public void set_font_data(DynamicFontData data) {
    GodotEnginePINVOKE.DynamicFont_set_font_data(swigCPtr, DynamicFontData.getCPtr(data));
  }

  public DynamicFontData get_font_data() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.DynamicFont_get_font_data(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    DynamicFontData ret = InternalHelpers.UnmanagedGetManaged(cPtr) as DynamicFontData;
    return ret;
}

  public void set_size(int data) {
    GodotEnginePINVOKE.DynamicFont_set_size(swigCPtr, data);
  }

  public int get_size() {
    int ret = GodotEnginePINVOKE.DynamicFont_get_size(swigCPtr);
    return ret;
  }

  public void add_fallback(DynamicFontData data) {
    GodotEnginePINVOKE.DynamicFont_add_fallback(swigCPtr, DynamicFontData.getCPtr(data));
  }

  public void set_fallback(int idx, DynamicFontData data) {
    GodotEnginePINVOKE.DynamicFont_set_fallback(swigCPtr, idx, DynamicFontData.getCPtr(data));
  }

  public DynamicFontData get_fallback(int idx) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.DynamicFont_get_fallback(swigCPtr, idx);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    DynamicFontData ret = InternalHelpers.UnmanagedGetManaged(cPtr) as DynamicFontData;
    return ret;
}

  public void remove_fallback(int idx) {
    GodotEnginePINVOKE.DynamicFont_remove_fallback(swigCPtr, idx);
  }

  public int get_fallback_count() {
    int ret = GodotEnginePINVOKE.DynamicFont_get_fallback_count(swigCPtr);
    return ret;
  }

  public DynamicFont() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_DynamicFont());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
