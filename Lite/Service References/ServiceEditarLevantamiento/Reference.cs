﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Lite.ServiceEditarLevantamiento {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.is.net.edit/svc", ConfigurationName="ServiceEditarLevantamiento.EditEnviarLevantamientoPortType")]
    public interface EditEnviarLevantamientoPortType {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:enviarLevantamiento", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginenviarLevantamiento(Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest request, System.AsyncCallback callback, object asyncState);
        
        Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse EndenviarLevantamiento(System.IAsyncResult result);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="EditEnviarLevantamiento-RQ-Type", Namespace="http://www.is.net.edit/gis")]
    public partial class EditEnviarLevantamientoRQType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string informacionElementosField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string InformacionElementos {
            get {
                return this.informacionElementosField;
            }
            set {
                this.informacionElementosField = value;
                this.RaisePropertyChanged("InformacionElementos");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.is.net.edit/gis")]
    public partial class UTCDate : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string dateField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
                this.RaisePropertyChanged("date");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.is.net.edit/gis")]
    public partial class GisRespuestaGeneralType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private UTCDate fechaRespuestaField;
        
        private string codigoRespuestaField;
        
        private string codigoErrorField;
        
        private string descripcionErrorField;
        
        private string mensajeErrorField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public UTCDate FechaRespuesta {
            get {
                return this.fechaRespuestaField;
            }
            set {
                this.fechaRespuestaField = value;
                this.RaisePropertyChanged("FechaRespuesta");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CodigoRespuesta {
            get {
                return this.codigoRespuestaField;
            }
            set {
                this.codigoRespuestaField = value;
                this.RaisePropertyChanged("CodigoRespuesta");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CodigoError {
            get {
                return this.codigoErrorField;
            }
            set {
                this.codigoErrorField = value;
                this.RaisePropertyChanged("CodigoError");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DescripcionError {
            get {
                return this.descripcionErrorField;
            }
            set {
                this.descripcionErrorField = value;
                this.RaisePropertyChanged("DescripcionError");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string MensajeError {
            get {
                return this.mensajeErrorField;
            }
            set {
                this.mensajeErrorField = value;
                this.RaisePropertyChanged("MensajeError");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="EditEnviarLevantamiento-RS-Type", Namespace="http://www.is.net.edit/gis")]
    public partial class EditEnviarLevantamientoRSType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private GisRespuestaGeneralType gisRespuestaProcesoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public GisRespuestaGeneralType GisRespuestaProceso {
            get {
                return this.gisRespuestaProcesoField;
            }
            set {
                this.gisRespuestaProcesoField = value;
                this.RaisePropertyChanged("GisRespuestaProceso");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class enviarLevantamientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditEnviarLevantamiento-RQ", Namespace="http://www.is.net.edit/gis", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EditEnviarLevantamiento-RQ")]
        public Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoRQType EditEnviarLevantamientoRQ;
        
        public enviarLevantamientoRequest() {
        }
        
        public enviarLevantamientoRequest(Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoRQType EditEnviarLevantamientoRQ) {
            this.EditEnviarLevantamientoRQ = EditEnviarLevantamientoRQ;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class enviarLevantamientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditEnviarLevantamiento-RS", Namespace="http://www.is.net.edit/gis", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EditEnviarLevantamiento-RS")]
        public Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoRSType EditEnviarLevantamientoRS;
        
        public enviarLevantamientoResponse() {
        }
        
        public enviarLevantamientoResponse(Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoRSType EditEnviarLevantamientoRS) {
            this.EditEnviarLevantamientoRS = EditEnviarLevantamientoRS;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EditEnviarLevantamientoPortTypeChannel : Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class enviarLevantamientoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public enviarLevantamientoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EditEnviarLevantamientoPortTypeClient : System.ServiceModel.ClientBase<Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType>, Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType {
        
        private BeginOperationDelegate onBeginenviarLevantamientoDelegate;
        
        private EndOperationDelegate onEndenviarLevantamientoDelegate;
        
        private System.Threading.SendOrPostCallback onenviarLevantamientoCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public EditEnviarLevantamientoPortTypeClient() {
        }
        
        public EditEnviarLevantamientoPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EditEnviarLevantamientoPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EditEnviarLevantamientoPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EditEnviarLevantamientoPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("No se puede establecer el objeto CookieContainer. Asegúrese de que el enlace cont" +
                            "iene un objeto HttpCookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<enviarLevantamientoCompletedEventArgs> enviarLevantamientoCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType.BeginenviarLevantamiento(Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginenviarLevantamiento(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType.EndenviarLevantamiento(System.IAsyncResult result) {
            return base.Channel.EndenviarLevantamiento(result);
        }
        
        private System.IAsyncResult OnBeginenviarLevantamiento(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest request = ((Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest)(inValues[0]));
            return ((Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType)(this)).BeginenviarLevantamiento(request, callback, asyncState);
        }
        
        private object[] OnEndenviarLevantamiento(System.IAsyncResult result) {
            Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse retVal = ((Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType)(this)).EndenviarLevantamiento(result);
            return new object[] {
                    retVal};
        }
        
        private void OnenviarLevantamientoCompleted(object state) {
            if ((this.enviarLevantamientoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.enviarLevantamientoCompleted(this, new enviarLevantamientoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void enviarLevantamientoAsync(Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest request) {
            this.enviarLevantamientoAsync(request, null);
        }
        
        public void enviarLevantamientoAsync(Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest request, object userState) {
            if ((this.onBeginenviarLevantamientoDelegate == null)) {
                this.onBeginenviarLevantamientoDelegate = new BeginOperationDelegate(this.OnBeginenviarLevantamiento);
            }
            if ((this.onEndenviarLevantamientoDelegate == null)) {
                this.onEndenviarLevantamientoDelegate = new EndOperationDelegate(this.OnEndenviarLevantamiento);
            }
            if ((this.onenviarLevantamientoCompletedDelegate == null)) {
                this.onenviarLevantamientoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnenviarLevantamientoCompleted);
            }
            base.InvokeAsync(this.onBeginenviarLevantamientoDelegate, new object[] {
                        request}, this.onEndenviarLevantamientoDelegate, this.onenviarLevantamientoCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType CreateChannel() {
            return new EditEnviarLevantamientoPortTypeClientChannel(this);
        }
        
        private class EditEnviarLevantamientoPortTypeClientChannel : ChannelBase<Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType>, Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType {
            
            public EditEnviarLevantamientoPortTypeClientChannel(System.ServiceModel.ClientBase<Lite.ServiceEditarLevantamiento.EditEnviarLevantamientoPortType> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginenviarLevantamiento(Lite.ServiceEditarLevantamiento.enviarLevantamientoRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("enviarLevantamiento", _args, callback, asyncState);
                return _result;
            }
            
            public Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse EndenviarLevantamiento(System.IAsyncResult result) {
                object[] _args = new object[0];
                Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse _result = ((Lite.ServiceEditarLevantamiento.enviarLevantamientoResponse)(base.EndInvoke("enviarLevantamiento", _args, result)));
                return _result;
            }
        }
    }
}
