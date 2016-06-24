/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class MeshInstance : GeometryInstance {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal MeshInstance(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.MeshInstance_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected MeshInstance(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.MeshInstance_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MeshInstance obj) {
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



  public void set_mesh(Mesh mesh) {
    GodotEnginePINVOKE.MeshInstance_set_mesh(swigCPtr, Mesh.getCPtr(mesh));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public Mesh get_mesh() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.MeshInstance_get_mesh(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Mesh ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Mesh;
    return ret;
}

  public void set_skeleton_path(NodePath skeleton_path) {
    GodotEnginePINVOKE.MeshInstance_set_skeleton_path(swigCPtr, NodePath.getCPtr(skeleton_path));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public NodePath get_skeleton_path() {
    NodePath ret = new NodePath(GodotEnginePINVOKE.MeshInstance_get_skeleton_path(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_AABB get_aabb() {
    SWIGTYPE_p_AABB ret = new SWIGTYPE_p_AABB(GodotEnginePINVOKE.MeshInstance_get_aabb(swigCPtr), true);
    return ret;
  }

  public void create_trimesh_collision() {
    GodotEnginePINVOKE.MeshInstance_create_trimesh_collision(swigCPtr);
  }

  public void create_convex_collision() {
    GodotEnginePINVOKE.MeshInstance_create_convex_collision(swigCPtr);
  }

  public MeshInstance() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_MeshInstance());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}