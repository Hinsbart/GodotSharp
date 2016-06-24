/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class Shader : Resource {
  public static readonly int MODE_MATERIAL = 0;
  public static readonly int MODE_CANVAS_ITEM = 1;
  public static readonly int MODE_POST_PROCESS = 2;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal Shader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.Shader_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected Shader(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.Shader_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Shader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Shader() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GodotEnginePINVOKE.delete_Shader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal Shader() {}


  public int get_mode() {
    int ret = GodotEnginePINVOKE.Shader_get_mode(swigCPtr);
    return ret;
  }

  public void set_code(string vcode, string fcode, string lcode, int fofs, int lofs) {
    GodotEnginePINVOKE.Shader_set_code__SWIG_0(swigCPtr, vcode, fcode, lcode, fofs, lofs);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_code(string vcode, string fcode, string lcode, int fofs) {
    GodotEnginePINVOKE.Shader_set_code__SWIG_1(swigCPtr, vcode, fcode, lcode, fofs);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_code(string vcode, string fcode, string lcode) {
    GodotEnginePINVOKE.Shader_set_code__SWIG_2(swigCPtr, vcode, fcode, lcode);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string get_vertex_code() {
    string ret = GodotEnginePINVOKE.Shader_get_vertex_code(swigCPtr);
    return ret;
  }

  public string get_fragment_code() {
    string ret = GodotEnginePINVOKE.Shader_get_fragment_code(swigCPtr);
    return ret;
  }

  public string get_light_code() {
    string ret = GodotEnginePINVOKE.Shader_get_light_code(swigCPtr);
    return ret;
  }

  public void set_default_texture_param(string param, SWIGTYPE_p_RefT_Texture_t texture) {
    GodotEnginePINVOKE.Shader_set_default_texture_param(swigCPtr, param, SWIGTYPE_p_RefT_Texture_t.getCPtr(texture));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RefT_Texture_t get_default_texture_param(string param) {
    SWIGTYPE_p_RefT_Texture_t ret = new SWIGTYPE_p_RefT_Texture_t(GodotEnginePINVOKE.Shader_get_default_texture_param(swigCPtr, param), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool has_param(string name) {
    bool ret = GodotEnginePINVOKE.Shader_has_param(swigCPtr, name);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}