/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class AudioServer : Object {
  private static AudioServer instance;
  public static readonly int SAMPLE_FORMAT_PCM8 = 0;
  public static readonly int SAMPLE_FORMAT_PCM16 = 1;
  public static readonly int SAMPLE_FORMAT_IMA_ADPCM = 2;
  public static readonly int SAMPLE_LOOP_NONE = 0;
  public static readonly int SAMPLE_LOOP_FORWARD = 1;
  public static readonly int SAMPLE_LOOP_PING_PONG = 2;
  public static readonly int FILTER_NONE = 0;
  public static readonly int FILTER_LOWPASS = 1;
  public static readonly int FILTER_BANDPASS = 2;
  public static readonly int FILTER_HIPASS = 3;
  public static readonly int FILTER_NOTCH = 4;
  public static readonly int FILTER_BANDLIMIT = 6;
  public static readonly int REVERB_SMALL = 0;
  public static readonly int REVERB_MEDIUM = 1;
  public static readonly int REVERB_LARGE = 2;
  public static readonly int REVERB_HALL = 3;

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal AudioServer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.AudioServer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected AudioServer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.AudioServer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioServer obj) {
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

  public static AudioServer Instance {
    get {
      if (instance == null) {
        instance = SingletonGetInstance();
      }
      return instance;
    }
  }

  internal AudioServer() {}


  public SWIGTYPE_p_RID sample_create(int format, bool stereo, int length) {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.AudioServer_sample_create(swigCPtr, format, stereo, length), true);
    return ret;
  }

  public void sample_set_description(SWIGTYPE_p_RID sample, string description) {
    GodotEnginePINVOKE.AudioServer_sample_set_description(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), description);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public string sample_get_description(SWIGTYPE_p_RID sample) {
    string ret = GodotEnginePINVOKE.AudioServer_sample_get_description(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int sample_get_format(SWIGTYPE_p_RID sample) {
    int ret = GodotEnginePINVOKE.AudioServer_sample_get_format(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool sample_is_stereo(SWIGTYPE_p_RID sample) {
    bool ret = GodotEnginePINVOKE.AudioServer_sample_is_stereo(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int sample_get_length(SWIGTYPE_p_RID sample) {
    int ret = GodotEnginePINVOKE.AudioServer_sample_get_length(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sample_set_signed_data(SWIGTYPE_p_RID sample, SWIGTYPE_p_RealArray data) {
    GodotEnginePINVOKE.AudioServer_sample_set_signed_data(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), SWIGTYPE_p_RealArray.getCPtr(data));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void sample_set_data(SWIGTYPE_p_RID sample, SWIGTYPE_p_RawArray data) {
    GodotEnginePINVOKE.AudioServer_sample_set_data(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), SWIGTYPE_p_RawArray.getCPtr(data));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_RawArray sample_get_data(SWIGTYPE_p_RID sample) {
    SWIGTYPE_p_RawArray ret = new SWIGTYPE_p_RawArray(GodotEnginePINVOKE.AudioServer_sample_get_data(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample)), true);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sample_set_mix_rate(SWIGTYPE_p_RID sample, int mix_rate) {
    GodotEnginePINVOKE.AudioServer_sample_set_mix_rate(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), mix_rate);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int sample_get_mix_rate(SWIGTYPE_p_RID sample) {
    int ret = GodotEnginePINVOKE.AudioServer_sample_get_mix_rate(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sample_set_loop_format(SWIGTYPE_p_RID sample, int loop_format) {
    GodotEnginePINVOKE.AudioServer_sample_set_loop_format(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), loop_format);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int sample_get_loop_format(SWIGTYPE_p_RID sample) {
    int ret = GodotEnginePINVOKE.AudioServer_sample_get_loop_format(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sample_set_loop_begin(SWIGTYPE_p_RID sample, int pos) {
    GodotEnginePINVOKE.AudioServer_sample_set_loop_begin(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int sample_get_loop_begin(SWIGTYPE_p_RID sample) {
    int ret = GodotEnginePINVOKE.AudioServer_sample_get_loop_begin(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sample_set_loop_end(SWIGTYPE_p_RID sample, int pos) {
    GodotEnginePINVOKE.AudioServer_sample_set_loop_end(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample), pos);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public int sample_get_loop_end(SWIGTYPE_p_RID sample) {
    int ret = GodotEnginePINVOKE.AudioServer_sample_get_loop_end(swigCPtr, SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_RID voice_create() {
    SWIGTYPE_p_RID ret = new SWIGTYPE_p_RID(GodotEnginePINVOKE.AudioServer_voice_create(swigCPtr), true);
    return ret;
  }

  public void voice_play(SWIGTYPE_p_RID voice, SWIGTYPE_p_RID sample) {
    GodotEnginePINVOKE.AudioServer_voice_play(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), SWIGTYPE_p_RID.getCPtr(sample));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_volume(SWIGTYPE_p_RID voice, float volume) {
    GodotEnginePINVOKE.AudioServer_voice_set_volume(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), volume);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_pan(SWIGTYPE_p_RID voice, float pan, float depth, float height) {
    GodotEnginePINVOKE.AudioServer_voice_set_pan__SWIG_0(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), pan, depth, height);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_pan(SWIGTYPE_p_RID voice, float pan, float depth) {
    GodotEnginePINVOKE.AudioServer_voice_set_pan__SWIG_1(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), pan, depth);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_pan(SWIGTYPE_p_RID voice, float pan) {
    GodotEnginePINVOKE.AudioServer_voice_set_pan__SWIG_2(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), pan);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_filter(SWIGTYPE_p_RID voice, int type, float cutoff, float resonance, float gain) {
    GodotEnginePINVOKE.AudioServer_voice_set_filter__SWIG_0(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), type, cutoff, resonance, gain);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_filter(SWIGTYPE_p_RID voice, int type, float cutoff, float resonance) {
    GodotEnginePINVOKE.AudioServer_voice_set_filter__SWIG_1(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), type, cutoff, resonance);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_chorus(SWIGTYPE_p_RID voice, float chorus) {
    GodotEnginePINVOKE.AudioServer_voice_set_chorus(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), chorus);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_reverb(SWIGTYPE_p_RID voice, int room, float reverb) {
    GodotEnginePINVOKE.AudioServer_voice_set_reverb(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), room, reverb);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_mix_rate(SWIGTYPE_p_RID voice, int rate) {
    GodotEnginePINVOKE.AudioServer_voice_set_mix_rate(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), rate);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void voice_set_positional(SWIGTYPE_p_RID voice, bool enabled) {
    GodotEnginePINVOKE.AudioServer_voice_set_positional(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice), enabled);
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public float voice_get_volume(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_volume(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_pan(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_pan(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_pan_height(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_pan_height(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_pan_depth(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_pan_depth(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int voice_get_filter_type(SWIGTYPE_p_RID voice) {
    int ret = GodotEnginePINVOKE.AudioServer_voice_get_filter_type(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_filter_cutoff(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_filter_cutoff(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_filter_resonance(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_filter_resonance(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_chorus(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_chorus(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int voice_get_reverb_type(SWIGTYPE_p_RID voice) {
    int ret = GodotEnginePINVOKE.AudioServer_voice_get_reverb_type(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float voice_get_reverb(SWIGTYPE_p_RID voice) {
    float ret = GodotEnginePINVOKE.AudioServer_voice_get_reverb(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int voice_get_mix_rate(SWIGTYPE_p_RID voice) {
    int ret = GodotEnginePINVOKE.AudioServer_voice_get_mix_rate(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool voice_is_positional(SWIGTYPE_p_RID voice) {
    bool ret = GodotEnginePINVOKE.AudioServer_voice_is_positional(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void voice_stop(SWIGTYPE_p_RID voice) {
    GodotEnginePINVOKE.AudioServer_voice_stop(swigCPtr, SWIGTYPE_p_RID.getCPtr(voice));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void free_rid(SWIGTYPE_p_RID rid) {
    GodotEnginePINVOKE.AudioServer_free_rid(swigCPtr, SWIGTYPE_p_RID.getCPtr(rid));
    if (GodotEnginePINVOKE.SWIGPendingException.Pending) throw GodotEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void set_stream_global_volume_scale(float scale) {
    GodotEnginePINVOKE.AudioServer_set_stream_global_volume_scale(swigCPtr, scale);
  }

  public float get_stream_global_volume_scale() {
    float ret = GodotEnginePINVOKE.AudioServer_get_stream_global_volume_scale(swigCPtr);
    return ret;
  }

  public void set_fx_global_volume_scale(float scale) {
    GodotEnginePINVOKE.AudioServer_set_fx_global_volume_scale(swigCPtr, scale);
  }

  public float get_fx_global_volume_scale() {
    float ret = GodotEnginePINVOKE.AudioServer_get_fx_global_volume_scale(swigCPtr);
    return ret;
  }

  public void set_event_voice_global_volume_scale(float scale) {
    GodotEnginePINVOKE.AudioServer_set_event_voice_global_volume_scale(swigCPtr, scale);
  }

  public float get_event_voice_global_volume_scale() {
    float ret = GodotEnginePINVOKE.AudioServer_get_event_voice_global_volume_scale(swigCPtr);
    return ret;
  }

  private static AudioServer SingletonGetInstance() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.AudioServer_SingletonGetInstance();
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    AudioServer ret = InternalHelpers.UnmanagedGetManaged(cPtr) as AudioServer;
    return ret;
  }

}

}