//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace Microsoft.ServiceModel.Samples {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ICalculator", Namespace="http://tempuri.org/")]
    public partial class CalculatorService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddOperationCompleted;
        
        private System.Threading.SendOrPostCallback SubtractOperationCompleted;
        
        private System.Threading.SendOrPostCallback MultiplyOperationCompleted;
        
        private System.Threading.SendOrPostCallback DivideOperationCompleted;
        
        /// <remarks/>
        public CalculatorService() {
            string urlSetting = System.Configuration.ConfigurationManager.AppSettings["CalculatorServiceAddress"];
            if ((urlSetting != null)) {
                this.Url = urlSetting;
            }
            else {
                this.Url = "http://localhost/ServiceModelSamples/service.svc" +
                    "";
            }
        }
        
        /// <remarks/>
        public event AddCompletedEventHandler AddCompleted;
        
        /// <remarks/>
        public event SubtractCompletedEventHandler SubtractCompleted;
        
        /// <remarks/>
        public event MultiplyCompletedEventHandler MultiplyCompleted;
        
        /// <remarks/>
        public event DivideCompletedEventHandler DivideCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Microsoft.ServiceModel.Samples/ICalculator/Add", RequestNamespace="http://Microsoft.ServiceModel.Samples", ResponseNamespace="http://Microsoft.ServiceModel.Samples", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Add(double n1, double n2) {
            object[] results = this.Invoke("Add", new object[] {
                        n1,
                        n2});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAdd(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Add", new object[] {
                        n1,
                        n2}, callback, asyncState);
        }
        
        /// <remarks/>
        public double EndAdd(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void AddAsync(double n1, double n2) {
            this.AddAsync(n1, n2, null);
        }
        
        /// <remarks/>
        public void AddAsync(double n1, double n2, object userState) {
            if ((this.AddOperationCompleted == null)) {
                this.AddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOperationCompleted);
            }
            this.InvokeAsync("Add", new object[] {
                        n1,
                        n2}, this.AddOperationCompleted, userState);
        }
        
        private void OnAddOperationCompleted(object arg) {
            if ((this.AddCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddCompleted(this, new AddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Microsoft.ServiceModel.Samples/ICalculator/Subtract", RequestNamespace="http://Microsoft.ServiceModel.Samples", ResponseNamespace="http://Microsoft.ServiceModel.Samples", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Subtract(double n1, double n2) {
            object[] results = this.Invoke("Subtract", new object[] {
                        n1,
                        n2});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSubtract(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Subtract", new object[] {
                        n1,
                        n2}, callback, asyncState);
        }
        
        /// <remarks/>
        public double EndSubtract(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void SubtractAsync(double n1, double n2) {
            this.SubtractAsync(n1, n2, null);
        }
        
        /// <remarks/>
        public void SubtractAsync(double n1, double n2, object userState) {
            if ((this.SubtractOperationCompleted == null)) {
                this.SubtractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubtractOperationCompleted);
            }
            this.InvokeAsync("Subtract", new object[] {
                        n1,
                        n2}, this.SubtractOperationCompleted, userState);
        }
        
        private void OnSubtractOperationCompleted(object arg) {
            if ((this.SubtractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubtractCompleted(this, new SubtractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Microsoft.ServiceModel.Samples/ICalculator/Multiply", RequestNamespace="http://Microsoft.ServiceModel.Samples", ResponseNamespace="http://Microsoft.ServiceModel.Samples", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Multiply(double n1, double n2) {
            object[] results = this.Invoke("Multiply", new object[] {
                        n1,
                        n2});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginMultiply(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Multiply", new object[] {
                        n1,
                        n2}, callback, asyncState);
        }
        
        /// <remarks/>
        public double EndMultiply(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void MultiplyAsync(double n1, double n2) {
            this.MultiplyAsync(n1, n2, null);
        }
        
        /// <remarks/>
        public void MultiplyAsync(double n1, double n2, object userState) {
            if ((this.MultiplyOperationCompleted == null)) {
                this.MultiplyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMultiplyOperationCompleted);
            }
            this.InvokeAsync("Multiply", new object[] {
                        n1,
                        n2}, this.MultiplyOperationCompleted, userState);
        }
        
        private void OnMultiplyOperationCompleted(object arg) {
            if ((this.MultiplyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MultiplyCompleted(this, new MultiplyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Microsoft.ServiceModel.Samples/ICalculator/Divide", RequestNamespace="http://Microsoft.ServiceModel.Samples", ResponseNamespace="http://Microsoft.ServiceModel.Samples", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double Divide(double n1, double n2) {
            object[] results = this.Invoke("Divide", new object[] {
                        n1,
                        n2});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDivide(double n1, double n2, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Divide", new object[] {
                        n1,
                        n2}, callback, asyncState);
        }
        
        /// <remarks/>
        public double EndDivide(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void DivideAsync(double n1, double n2) {
            this.DivideAsync(n1, n2, null);
        }
        
        /// <remarks/>
        public void DivideAsync(double n1, double n2, object userState) {
            if ((this.DivideOperationCompleted == null)) {
                this.DivideOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDivideOperationCompleted);
            }
            this.InvokeAsync("Divide", new object[] {
                        n1,
                        n2}, this.DivideOperationCompleted, userState);
        }
        
        private void OnDivideOperationCompleted(object arg) {
            if ((this.DivideCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DivideCompleted(this, new DivideCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void AddCompletedEventHandler(object sender, AddCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void SubtractCompletedEventHandler(object sender, SubtractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SubtractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SubtractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void MultiplyCompletedEventHandler(object sender, MultiplyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MultiplyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MultiplyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void DivideCompletedEventHandler(object sender, DivideCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DivideCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DivideCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}
