/* mCapsuleShape.i */
%module mCapsuleShape

template<class CapsuleShape> class Ref;%template() Ref<CapsuleShape>;
%feature("novaluewrapper") Ref<CapsuleShape>;


%typemap(csbody_derived) CapsuleShape %{

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

%typemap(cscode) CapsuleShape %{

%}

%typemap(csconstruct, excode=SWIGEXCODE) CapsuleShape %{: this(true) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor CapsuleShape;

class CapsuleShape : public Shape {
public:
  CapsuleShape();

%extend {

void set_radius(float radius) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("CapsuleShape", "set_radius");
  const void* __args[1] = { &radius };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_radius() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("CapsuleShape", "get_radius");
  float ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_height(float height) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("CapsuleShape", "set_height");
  const void* __args[1] = { &height };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_height() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("CapsuleShape", "get_height");
  float ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

~CapsuleShape() {
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
