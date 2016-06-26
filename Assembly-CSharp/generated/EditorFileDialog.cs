/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class EditorFileDialog : ConfirmationDialog {
  public static readonly int MODE_OPEN_FILE = 0;
  public static readonly int MODE_OPEN_FILES = 1;
  public static readonly int MODE_OPEN_DIR = 2;
  public static readonly int MODE_OPEN_ANY = 3;
  public static readonly int MODE_SAVE_FILE = 4;
  public static readonly int ACCESS_RESOURCES = 0;
  public static readonly int ACCESS_USERDATA = 1;
  public static readonly int ACCESS_FILESYSTEM = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal EditorFileDialog(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.EditorFileDialog_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected EditorFileDialog(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.EditorFileDialog_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EditorFileDialog obj) {
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



  public void clear_filters() {
    GodotEnginePINVOKE.EditorFileDialog_clear_filters(swigCPtr);
  }

  public void add_filter(string filter) {
    GodotEnginePINVOKE.EditorFileDialog_add_filter(swigCPtr, filter);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_current_dir() {
    string ret = GodotEnginePINVOKE.EditorFileDialog_get_current_dir(swigCPtr);
    return ret;
  }

  public string get_current_file() {
    string ret = GodotEnginePINVOKE.EditorFileDialog_get_current_file(swigCPtr);
    return ret;
  }

  public string get_current_path() {
    string ret = GodotEnginePINVOKE.EditorFileDialog_get_current_path(swigCPtr);
    return ret;
  }

  public void set_current_dir(string dir) {
    GodotEnginePINVOKE.EditorFileDialog_set_current_dir(swigCPtr, dir);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_current_file(string file) {
    GodotEnginePINVOKE.EditorFileDialog_set_current_file(swigCPtr, file);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_current_path(string path) {
    GodotEnginePINVOKE.EditorFileDialog_set_current_path(swigCPtr, path);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_mode(int mode) {
    GodotEnginePINVOKE.EditorFileDialog_set_mode(swigCPtr, mode);
  }

  public int get_mode() {
    int ret = GodotEnginePINVOKE.EditorFileDialog_get_mode(swigCPtr);
    return ret;
  }

  public VBoxContainer get_vbox() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.EditorFileDialog_get_vbox(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    VBoxContainer ret = InternalHelpers.UnmanagedGetManaged(cPtr) as VBoxContainer;
    return ret;
  }

  public void set_access(int access) {
    GodotEnginePINVOKE.EditorFileDialog_set_access(swigCPtr, access);
  }

  public int get_access() {
    int ret = GodotEnginePINVOKE.EditorFileDialog_get_access(swigCPtr);
    return ret;
  }

  public void set_show_hidden_files(bool show) {
    GodotEnginePINVOKE.EditorFileDialog_set_show_hidden_files(swigCPtr, show);
  }

  public bool is_showing_hidden_files() {
    bool ret = GodotEnginePINVOKE.EditorFileDialog_is_showing_hidden_files(swigCPtr);
    return ret;
  }

  public void set_display_mode(int mode) {
    GodotEnginePINVOKE.EditorFileDialog_set_display_mode(swigCPtr, mode);
  }

  public int get_display_mode() {
    int ret = GodotEnginePINVOKE.EditorFileDialog_get_display_mode(swigCPtr);
    return ret;
  }

  public void set_disable_overwrite_warning(bool disable) {
    GodotEnginePINVOKE.EditorFileDialog_set_disable_overwrite_warning(swigCPtr, disable);
  }

  public bool is_overwrite_warning_disabled() {
    bool ret = GodotEnginePINVOKE.EditorFileDialog_is_overwrite_warning_disabled(swigCPtr);
    return ret;
  }

  public void invalidate() {
    GodotEnginePINVOKE.EditorFileDialog_invalidate(swigCPtr);
  }

  public EditorFileDialog() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_EditorFileDialog());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
