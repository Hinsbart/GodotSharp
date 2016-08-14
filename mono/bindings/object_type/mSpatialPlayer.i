/* mSpatialPlayer.i */
%module mSpatialPlayer

%nodefaultctor SpatialPlayer;

%typemap(csbody_derived) SpatialPlayer %{
  public static readonly int PARAM_VOLUME_DB = 0;
  public static readonly int PARAM_PITCH_SCALE = 1;
  public static readonly int PARAM_ATTENUATION_MIN_DISTANCE = 2;
  public static readonly int PARAM_ATTENUATION_MAX_DISTANCE = 3;
  public static readonly int PARAM_ATTENUATION_DISTANCE_EXP = 4;
  public static readonly int PARAM_EMISSION_CONE_DEGREES = 5;
  public static readonly int PARAM_EMISSION_CONE_ATTENUATION_DB = 6;
  public static readonly int PARAM_MAX = 7;

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

%typemap(cscode) SpatialPlayer %{
  internal $csclassname() {}

%}

%typemap(csconstruct, excode=SWIGEXCODE) SpatialPlayer %{: this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor SpatialPlayer;

class SpatialPlayer : public Spatial {
public:

%extend {

void set_param(int param, float value) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("SpatialPlayer", "set_param");
  const void* __args[2] = { &param, &value };
  __method_bind->ptrcall($self, __args, NULL);
}

float get_param(int param) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("SpatialPlayer", "get_param");
  const void* __args[1] = { &param };
  float ret;
  __method_bind->ptrcall($self, __args, &ret);
  return ret;
}

}


};