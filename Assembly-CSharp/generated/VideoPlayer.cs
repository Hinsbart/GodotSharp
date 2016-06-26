/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace GodotEngine {

public class VideoPlayer : Control {

  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  
  internal VideoPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(GodotEnginePINVOKE.VideoPlayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }  
  
  protected VideoPlayer(bool cMemoryOwn) : base(cMemoryOwn) {}
  
  new internal void internal_init(global::System.IntPtr cPtr) {
    base.internal_init(GodotEnginePINVOKE.VideoPlayer_SWIGUpcast(cPtr));
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }
  
  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VideoPlayer obj) {
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



  public void set_stream(VideoStream stream) {
    GodotEnginePINVOKE.VideoPlayer_set_stream(swigCPtr, VideoStream.getCPtr(stream));
  }

  public VideoStream get_stream() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.VideoPlayer_get_stream(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    VideoStream ret = InternalHelpers.UnmanagedGetManaged(cPtr) as VideoStream;
    return ret;
}

  public void play() {
    GodotEnginePINVOKE.VideoPlayer_play(swigCPtr);
  }

  public void stop() {
    GodotEnginePINVOKE.VideoPlayer_stop(swigCPtr);
  }

  public bool is_playing() {
    bool ret = GodotEnginePINVOKE.VideoPlayer_is_playing(swigCPtr);
    return ret;
  }

  public void set_paused(bool paused) {
    GodotEnginePINVOKE.VideoPlayer_set_paused(swigCPtr, paused);
  }

  public bool is_paused() {
    bool ret = GodotEnginePINVOKE.VideoPlayer_is_paused(swigCPtr);
    return ret;
  }

  public void set_volume(float volume) {
    GodotEnginePINVOKE.VideoPlayer_set_volume(swigCPtr, volume);
  }

  public float get_volume() {
    float ret = GodotEnginePINVOKE.VideoPlayer_get_volume(swigCPtr);
    return ret;
  }

  public void set_volume_db(float db) {
    GodotEnginePINVOKE.VideoPlayer_set_volume_db(swigCPtr, db);
  }

  public float get_volume_db() {
    float ret = GodotEnginePINVOKE.VideoPlayer_get_volume_db(swigCPtr);
    return ret;
  }

  public void set_audio_track(int track) {
    GodotEnginePINVOKE.VideoPlayer_set_audio_track(swigCPtr, track);
  }

  public int get_audio_track() {
    int ret = GodotEnginePINVOKE.VideoPlayer_get_audio_track(swigCPtr);
    return ret;
  }

  public string get_stream_name() {
    string ret = GodotEnginePINVOKE.VideoPlayer_get_stream_name(swigCPtr);
    return ret;
  }

  public float get_stream_pos() {
    float ret = GodotEnginePINVOKE.VideoPlayer_get_stream_pos(swigCPtr);
    return ret;
  }

  public void set_autoplay(bool enabled) {
    GodotEnginePINVOKE.VideoPlayer_set_autoplay(swigCPtr, enabled);
  }

  public bool has_autoplay() {
    bool ret = GodotEnginePINVOKE.VideoPlayer_has_autoplay(swigCPtr);
    return ret;
  }

  public void set_expand(bool enable) {
    GodotEnginePINVOKE.VideoPlayer_set_expand(swigCPtr, enable);
  }

  public bool has_expand() {
    bool ret = GodotEnginePINVOKE.VideoPlayer_has_expand(swigCPtr);
    return ret;
  }

  public void set_buffering_msec(int msec) {
    GodotEnginePINVOKE.VideoPlayer_set_buffering_msec(swigCPtr, msec);
  }

  public int get_buffering_msec() {
    int ret = GodotEnginePINVOKE.VideoPlayer_get_buffering_msec(swigCPtr);
    return ret;
  }

  public Texture get_video_texture() {
    global::System.IntPtr cPtr = GodotEnginePINVOKE.VideoPlayer_get_video_texture(swigCPtr);
    if (cPtr == global::System.IntPtr.Zero)
      return null;
    Texture ret = InternalHelpers.UnmanagedGetManaged(cPtr) as Texture;
    return ret;
}

  public VideoPlayer() : this(false) {
    if (swigCPtr.Handle == global::System.IntPtr.Zero) {
      internal_init(GodotEnginePINVOKE.new_VideoPlayer());
      InternalHelpers.TieManagedToUnmanaged(this, swigCPtr.Handle);
    }
  }

}

}
