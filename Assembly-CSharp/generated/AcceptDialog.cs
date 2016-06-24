/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class AcceptDialog : WindowDialog {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal AcceptDialog(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.AcceptDialog_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected AcceptDialog(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.AcceptDialog_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AcceptDialog obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  public Object get_ok() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_get_ok(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public Object get_label() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_get_label(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Object ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Object;
    return ret;
  }

  public void set_hide_on_ok(bool enabled) {
    GodotEnginePINVOKE.AcceptDialog_set_hide_on_ok(swigCPtr, enabled);
  }

  public bool get_hide_on_ok() {
    bool ret = GodotEnginePINVOKE.AcceptDialog_get_hide_on_ok(swigCPtr);
    return ret;
  }

  public Button add_button(string text, bool right, string action) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_add_button__SWIG_0(swigCPtr, text, right, action);
    Button ret = (cPtr == global::System.IntPtr.Zero) ? null : new Button(cPtr, false);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Button add_button(string text, bool right) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_add_button__SWIG_1(swigCPtr, text, right);
    Button ret = (cPtr == global::System.IntPtr.Zero) ? null : new Button(cPtr, false);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Button add_button(string text) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_add_button__SWIG_2(swigCPtr, text);
    Button ret = (cPtr == global::System.IntPtr.Zero) ? null : new Button(cPtr, false);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Button add_cancel(string name) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_add_cancel(swigCPtr, name);
    Button ret = (cPtr == global::System.IntPtr.Zero) ? null : new Button(cPtr, false);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public LineEdit register_text_enter(Object line_edit) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AcceptDialog_register_text_enter(swigCPtr, Object.getCPtr(line_edit));
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    LineEdit ret = InternalHelpers.UnmanagedGetManaged(cPtr) as LineEdit;
    return ret;
  }

  public void set_text(string text) {
    GodotEnginePINVOKE.AcceptDialog_set_text(swigCPtr, text);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_text() {
    string ret = GodotEnginePINVOKE.AcceptDialog_get_text(swigCPtr);
    return ret;
  }

  public AcceptDialog() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_AcceptDialog());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}