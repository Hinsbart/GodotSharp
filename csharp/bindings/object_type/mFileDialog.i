/* mFileDialog.i */
%module mFileDialog


%typemap(csbody_derived) FileDialog %{
  public static readonly int MODE_OPEN_FILE = 0;
  public static readonly int MODE_OPEN_FILES = 1;
  public static readonly int MODE_OPEN_DIR = 2;
  public static readonly int MODE_OPEN_ANY = 3;
  public static readonly int MODE_SAVE_FILE = 4;
  public static readonly int ACCESS_RESOURCES = 0;
  public static readonly int ACCESS_USERDATA = 1;
  public static readonly int ACCESS_FILESYSTEM = 2;

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

%typemap(cscode) FileDialog %{

%}

%typemap(csconstruct, excode=SWIGEXCODE) FileDialog %{: this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init($imcall);
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }$excode
  }
%}

%nodefaultdtor FileDialog;

class FileDialog : public ConfirmationDialog {
public:
  FileDialog();

%extend {

void clear_filters() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "clear_filters");
  __method_bind->ptrcall($self, NULL, NULL);
}

void add_filter(const String& filter) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "add_filter");
  const void* __args[1] = { &filter };
  __method_bind->ptrcall($self, __args, NULL);
}

String get_current_dir() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "get_current_dir");
  String ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

String get_current_file() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "get_current_file");
  String ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

String get_current_path() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "get_current_path");
  String ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_current_dir(const String& dir) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "set_current_dir");
  const void* __args[1] = { &dir };
  __method_bind->ptrcall($self, __args, NULL);
}

void set_current_file(const String& file) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "set_current_file");
  const void* __args[1] = { &file };
  __method_bind->ptrcall($self, __args, NULL);
}

void set_current_path(const String& path) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "set_current_path");
  const void* __args[1] = { &path };
  __method_bind->ptrcall($self, __args, NULL);
}

void set_mode(int mode) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "set_mode");
  const void* __args[1] = { &mode };
  __method_bind->ptrcall($self, __args, NULL);
}

int get_mode() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "get_mode");
  int ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

VBoxContainer* get_vbox() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "get_vbox");
  VBoxContainer* ret = NULL;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_access(int access) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "set_access");
  const void* __args[1] = { &access };
  __method_bind->ptrcall($self, __args, NULL);
}

int get_access() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "get_access");
  int ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void set_show_hidden_files(bool show) {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "set_show_hidden_files");
  const void* __args[1] = { &show };
  __method_bind->ptrcall($self, __args, NULL);
}

bool is_showing_hidden_files() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "is_showing_hidden_files");
  bool ret;
  __method_bind->ptrcall($self, NULL, &ret);
  return ret;
}

void invalidate() {
  static MethodBind* __method_bind = NULL;
  if (!__method_bind)
    __method_bind = ObjectTypeDB::get_method("FileDialog", "invalidate");
  __method_bind->ptrcall($self, NULL, NULL);
}

}


};
