/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class CollisionObject : Spatial {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal CollisionObject(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.CollisionObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected CollisionObject(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.CollisionObject_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CollisionObject obj) {
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

  internal CollisionObject() {}


  public void _input_event(Object camera, SWIGTYPE_p_InputEvent arg1, SWIGTYPE_p_Vector3 click_pos, SWIGTYPE_p_Vector3 click_normal, int shape_idx) {
    GodotEnginePINVOKE.CollisionObject__input_event(swigCPtr, Object.getCPtr(camera), SWIGTYPE_p_InputEvent.getCPtr(arg1), SWIGTYPE_p_Vector3.getCPtr(click_pos), SWIGTYPE_p_Vector3.getCPtr(click_normal), shape_idx);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_shape(Shape shape, SWIGTYPE_p_Transform transform) {
    GodotEnginePINVOKE.CollisionObject_add_shape__SWIG_0(swigCPtr, Shape.getCPtr(shape), SWIGTYPE_p_Transform.getCPtr(transform));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void add_shape(Shape shape) {
    GodotEnginePINVOKE.CollisionObject_add_shape__SWIG_1(swigCPtr, Shape.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int get_shape_count() {
    int ret = GodotEnginePINVOKE.CollisionObject_get_shape_count(swigCPtr);
    return ret;
  }

  public void set_shape(int shape_idx, Shape shape) {
    GodotEnginePINVOKE.CollisionObject_set_shape(swigCPtr, shape_idx, Shape.getCPtr(shape));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_shape_transform(int shape_idx, SWIGTYPE_p_Transform transform) {
    GodotEnginePINVOKE.CollisionObject_set_shape_transform(swigCPtr, shape_idx, SWIGTYPE_p_Transform.getCPtr(transform));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_shape_as_trigger(int shape_idx, bool enable) {
    GodotEnginePINVOKE.CollisionObject_set_shape_as_trigger(swigCPtr, shape_idx, enable);
  }

  public bool is_shape_set_as_trigger(int shape_idx) {
    bool ret = GodotEnginePINVOKE.CollisionObject_is_shape_set_as_trigger(swigCPtr, shape_idx);
    return ret;
  }

  public Shape get_shape(int shape_idx) {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.CollisionObject_get_shape(swigCPtr, shape_idx);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Shape ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Shape;
    return ret;
}

  public SWIGTYPE_p_Transform get_shape_transform(int shape_idx) {
    SWIGTYPE_p_Transform ret = new SWIGTYPE_p_Transform(GodotEnginePINVOKE.CollisionObject_get_shape_transform(swigCPtr, shape_idx), true);
    return ret;
  }

  public void remove_shape(int shape_idx) {
    GodotEnginePINVOKE.CollisionObject_remove_shape(swigCPtr, shape_idx);
  }

  public void clear_shapes() {
    GodotEnginePINVOKE.CollisionObject_clear_shapes(swigCPtr);
  }

  public void set_ray_pickable(bool ray_pickable) {
    GodotEnginePINVOKE.CollisionObject_set_ray_pickable(swigCPtr, ray_pickable);
  }

  public bool is_ray_pickable() {
    bool ret = GodotEnginePINVOKE.CollisionObject_is_ray_pickable(swigCPtr);
    return ret;
  }

  public void set_capture_input_on_drag(bool enable) {
    GodotEnginePINVOKE.CollisionObject_set_capture_input_on_drag(swigCPtr, enable);
  }

  public bool get_capture_input_on_drag() {
    bool ret = GodotEnginePINVOKE.CollisionObject_get_capture_input_on_drag(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_RID get_rid() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.CollisionObject_get_rid(swigCPtr), true);
    return ret;
  }

}

}