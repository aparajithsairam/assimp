/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiVertexWeight : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiVertexWeight(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiVertexWeight obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiVertexWeight() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiVertexWeight(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public uint mVertexId {
    set {
      Assimp_NETPINVOKE.aiVertexWeight_mVertexId_set(swigCPtr, value);
    } 
    get {
      uint ret = Assimp_NETPINVOKE.aiVertexWeight_mVertexId_get(swigCPtr);
      return ret;
    } 
  }

  public float mWeight {
    set {
      Assimp_NETPINVOKE.aiVertexWeight_mWeight_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiVertexWeight_mWeight_get(swigCPtr);
      return ret;
    } 
  }

  public aiVertexWeight() : this(Assimp_NETPINVOKE.new_aiVertexWeight__SWIG_0(), true) {
  }

  public aiVertexWeight(uint pID, float pWeight) : this(Assimp_NETPINVOKE.new_aiVertexWeight__SWIG_1(pID, pWeight), true) {
  }

}