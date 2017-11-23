//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace EliteQuant {

public class MCEuropeanEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MCEuropeanEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.MCEuropeanEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MCEuropeanEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MCEuropeanEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_MCEuropeanEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance, int maxSamples, int seed) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_0(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance, maxSamples, seed), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance, int maxSamples) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_1(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance, maxSamples), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_2(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_3(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear, bool brownianBridge, bool antitheticVariate) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_4(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear, bool brownianBridge) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_5(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps, int timeStepsPerYear) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_6(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps, timeStepsPerYear), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits, int timeSteps) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_7(GeneralizedBlackScholesProcess.getCPtr(process), traits, timeSteps), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanEngine(GeneralizedBlackScholesProcess process, string traits) : this(NQuantLibcPINVOKE.new_MCEuropeanEngine__SWIG_8(GeneralizedBlackScholesProcess.getCPtr(process), traits), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}