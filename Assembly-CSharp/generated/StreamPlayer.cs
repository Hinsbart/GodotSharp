/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class StreamPlayer : Node {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal StreamPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.StreamPlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected StreamPlayer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.StreamPlayer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StreamPlayer obj) {
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



  public void set_stream(AudioStream stream) {
    GodotEnginePINVOKE.StreamPlayer_set_stream(swigCPtr, AudioStream.getCPtr(stream));
  }

  public AudioStream get_stream() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.StreamPlayer_get_stream(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    AudioStream ret = InternalHelpers.UnmanagedGetManaged(cPtr) as AudioStream;
    return ret;
}

  public void play(float offset) {
    GodotEnginePINVOKE.StreamPlayer_play__SWIG_0(swigCPtr, offset);
  }

  public void play() {
    GodotEnginePINVOKE.StreamPlayer_play__SWIG_1(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.StreamPlayer_stop(swigCPtr);
  }

  public bool is_playing() {
    bool ret = GodotEnginePINVOKE.StreamPlayer_is_playing(swigCPtr);
    return ret;
  }

  public void set_paused(bool paused) {
    GodotEnginePINVOKE.StreamPlayer_set_paused(swigCPtr, paused);
  }

  public bool is_paused() {
    bool ret = GodotEnginePINVOKE.StreamPlayer_is_paused(swigCPtr);
    return ret;
  }

  public void set_loop(bool enabled) {
    GodotEnginePINVOKE.StreamPlayer_set_loop(swigCPtr, enabled);
  }

  public bool has_loop() {
    bool ret = GodotEnginePINVOKE.StreamPlayer_has_loop(swigCPtr);
    return ret;
  }

  public void set_volume(float volume) {
    GodotEnginePINVOKE.StreamPlayer_set_volume(swigCPtr, volume);
  }

  public float get_volume() {
    float ret = GodotEnginePINVOKE.StreamPlayer_get_volume(swigCPtr);
    return ret;
  }

  public void set_volume_db(float db) {
    GodotEnginePINVOKE.StreamPlayer_set_volume_db(swigCPtr, db);
  }

  public float get_volume_db() {
    float ret = GodotEnginePINVOKE.StreamPlayer_get_volume_db(swigCPtr);
    return ret;
  }

  public void set_buffering_msec(int msec) {
    GodotEnginePINVOKE.StreamPlayer_set_buffering_msec(swigCPtr, msec);
  }

  public int get_buffering_msec() {
    int ret = GodotEnginePINVOKE.StreamPlayer_get_buffering_msec(swigCPtr);
    return ret;
  }

  public void set_loop_restart_time(float secs) {
    GodotEnginePINVOKE.StreamPlayer_set_loop_restart_time(swigCPtr, secs);
  }

  public float get_loop_restart_time() {
    float ret = GodotEnginePINVOKE.StreamPlayer_get_loop_restart_time(swigCPtr);
    return ret;
  }

  public string get_stream_name() {
    string ret = GodotEnginePINVOKE.StreamPlayer_get_stream_name(swigCPtr);
    return ret;
  }

  public int get_loop_count() {
    int ret = GodotEnginePINVOKE.StreamPlayer_get_loop_count(swigCPtr);
    return ret;
  }

  public float get_pos() {
    float ret = GodotEnginePINVOKE.StreamPlayer_get_pos(swigCPtr);
    return ret;
  }

  public void seek_pos(float time) {
    GodotEnginePINVOKE.StreamPlayer_seek_pos(swigCPtr, time);
  }

  public void set_autoplay(bool enabled) {
    GodotEnginePINVOKE.StreamPlayer_set_autoplay(swigCPtr, enabled);
  }

  public bool has_autoplay() {
    bool ret = GodotEnginePINVOKE.StreamPlayer_has_autoplay(swigCPtr);
    return ret;
  }

  public float get_length() {
    float ret = GodotEnginePINVOKE.StreamPlayer_get_length(swigCPtr);
    return ret;
  }

  public StreamPlayer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_StreamPlayer());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
