/* mCanvasItemShaderGraph.i */
%module mCanvasItemShaderGraph

%typemap(ctype, out="CanvasItemShaderGraph*") Ref<CanvasItemShaderGraph> "CanvasItemShaderGraph*"
%typemap(out, null="NULL") Ref<CanvasItemShaderGraph> %{
  $result = $1.ptr();
  $result->reference();
%}
%typemap(csin) Ref<CanvasItemShaderGraph> "CanvasItemShaderGraph.getCPtr($csinput)"
%typemap(imtype, out="global::System.IntPtr") Ref<CanvasItemShaderGraph> "global::System.Runtime.InteropServices.HandleRef"
%typemap(cstype) Ref<CanvasItemShaderGraph> "CanvasItemShaderGraph"
%typemap(csout, excode=SWIGEXCODE) Ref<CanvasItemShaderGraph> {
    global::System.IntPtr cPtr = $imcall;
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    CanvasItemShaderGraph ret = InternalHelpers.UnmanagedGetManaged(cPtr) as CanvasItemShaderGraph;$excode
    return ret;
}

template<class CanvasItemShaderGraph> class Ref;%template() Ref<CanvasItemShaderGraph>;
%feature("novaluewrapper") Ref<CanvasItemShaderGraph>;


%typemap(csbody_derived) CanvasItemShaderGraph %{

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal $csclassname(global::System.IntPtr cPtr, bool cMemoryOwn) : base($imclassname.$csclazznameSWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected $csclassname(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init($imclassname.$csclazznameSWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr($csclassname obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }
%}

%typemap(cscode) CanvasItemShaderGraph %{

%}

%typemap(csconstruct, excode=SWIGEXCODE) CanvasItemShaderGraph %{: this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor CanvasItemShaderGraph;

class CanvasItemShaderGraph : public ShaderGraph {
public:
  CanvasItemShaderGraph();
  %extend {
    ~CanvasItemShaderGraph() {
      if ($self->get_script_instance()) {
        CSharpInstance *cs_instance = dynamic_cast<CSharpInstance*>($self->get_script_instance());
        if (cs_instance) {
          cs_instance->mono_object_disposed();
          return;
        }
      }
      if ($self->unreference()) {
        memdelete($self);
      }
    }
  }


};