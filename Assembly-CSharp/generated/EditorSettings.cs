/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class EditorSettings : Resource {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal EditorSettings(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.EditorSettings_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected EditorSettings(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.EditorSettings_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EditorSettings obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EditorSettings() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_EditorSettings(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



  public void erase(string property) {
    GodotEnginePINVOKE.EditorSettings_erase(swigCPtr, property);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_settings_path() {
    string ret = GodotEnginePINVOKE.EditorSettings_get_settings_path(swigCPtr);
    return ret;
  }

  public string get_project_settings_path() {
    string ret = GodotEnginePINVOKE.EditorSettings_get_project_settings_path(swigCPtr);
    return ret;
  }

  public void set_favorite_dirs(SWIGTYPE_p_StringArray dirs) {
    GodotEnginePINVOKE.EditorSettings_set_favorite_dirs(swigCPtr, SWIGTYPE_p_StringArray.getCPtr(dirs));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_StringArray get_favorite_dirs() {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.EditorSettings_get_favorite_dirs(swigCPtr), true);
    return ret;
  }

  public void set_recent_dirs(SWIGTYPE_p_StringArray dirs) {
    GodotEnginePINVOKE.EditorSettings_set_recent_dirs(swigCPtr, SWIGTYPE_p_StringArray.getCPtr(dirs));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_StringArray get_recent_dirs() {
    SWIGTYPE_p_StringArray ret = new SWIGTYPE_p_StringArray(GodotEnginePINVOKE.EditorSettings_get_recent_dirs(swigCPtr), true);
    return ret;
  }

  public EditorSettings() : this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_EditorSettings());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}