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
namespace Lite.ServiceFactibilidad1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.grr.net.fv/svc", ConfigurationName="ServiceFactibilidad1.WsCalculaFactibilidadPortType")]
    public interface WsCalculaFactibilidadPortType {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:calculaFactibilidad", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BegincalculaFactibilidad(Lite.ServiceFactibilidad1.calculaFactibilidadRequest request, System.AsyncCallback callback, object asyncState);
        
        Lite.ServiceFactibilidad1.calculaFactibilidadResponse EndcalculaFactibilidad(System.IAsyncResult result);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="wsCalculaFactibilidad-RQ-Type", Namespace="http://www.grr.net.fv/gis")]
    public partial class wsCalculaFactibilidadRQType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string longitudField;
        
        private string latitudField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string longitud {
            get {
                return this.longitudField;
            }
            set {
                this.longitudField = value;
                this.RaisePropertyChanged("longitud");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string latitud {
            get {
                return this.latitudField;
            }
            set {
                this.latitudField = value;
                this.RaisePropertyChanged("latitud");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.grr.net.fv/gis")]
    public partial class detallerespuestatype : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fechaRespuestaField;
        
        private string codigoRespuestaField;
        
        private string codigoErrorField;
        
        private string descripcionErrorField;
        
        private string mensajeErrorField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FechaRespuesta {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.grr.net.fv/gis")]
    public partial class InfoFactibilidad : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string factibilidadField;
        
        private string direccionField;
        
        private string porcentajeField;
        
        private string criteriosField;
        
        private string comentariosField;
        
        private string nombre_clusterField;
        
        private detallerespuestatype detalle_RespuestaField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string factibilidad {
            get {
                return this.factibilidadField;
            }
            set {
                this.factibilidadField = value;
                this.RaisePropertyChanged("factibilidad");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string porcentaje {
            get {
                return this.porcentajeField;
            }
            set {
                this.porcentajeField = value;
                this.RaisePropertyChanged("porcentaje");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string criterios {
            get {
                return this.criteriosField;
            }
            set {
                this.criteriosField = value;
                this.RaisePropertyChanged("criterios");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string comentarios {
            get {
                return this.comentariosField;
            }
            set {
                this.comentariosField = value;
                this.RaisePropertyChanged("comentarios");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string nombre_cluster {
            get {
                return this.nombre_clusterField;
            }
            set {
                this.nombre_clusterField = value;
                this.RaisePropertyChanged("nombre_cluster");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public detallerespuestatype Detalle_Respuesta {
            get {
                return this.detalle_RespuestaField;
            }
            set {
                this.detalle_RespuestaField = value;
                this.RaisePropertyChanged("Detalle_Respuesta");
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
    public partial class calculaFactibilidadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wsCalculaFactibilidad-RQ", Namespace="http://www.grr.net.fv/gis", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("wsCalculaFactibilidad-RQ")]
        public Lite.ServiceFactibilidad1.wsCalculaFactibilidadRQType wsCalculaFactibilidadRQ;
        
        public calculaFactibilidadRequest() {
        }
        
        public calculaFactibilidadRequest(Lite.ServiceFactibilidad1.wsCalculaFactibilidadRQType wsCalculaFactibilidadRQ) {
            this.wsCalculaFactibilidadRQ = wsCalculaFactibilidadRQ;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class calculaFactibilidadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="wsCalculaFactibilidad-RS", Namespace="http://www.grr.net.fv/gis", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("wsCalculaFactibilidad-RS")]
        public Lite.ServiceFactibilidad1.InfoFactibilidad wsCalculaFactibilidadRS;
        
        public calculaFactibilidadResponse() {
        }
        
        public calculaFactibilidadResponse(Lite.ServiceFactibilidad1.InfoFactibilidad wsCalculaFactibilidadRS) {
            this.wsCalculaFactibilidadRS = wsCalculaFactibilidadRS;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WsCalculaFactibilidadPortTypeChannel : Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class calculaFactibilidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public calculaFactibilidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Lite.ServiceFactibilidad1.calculaFactibilidadResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Lite.ServiceFactibilidad1.calculaFactibilidadResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsCalculaFactibilidadPortTypeClient : System.ServiceModel.ClientBase<Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType>, Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType {
        
        private BeginOperationDelegate onBegincalculaFactibilidadDelegate;
        
        private EndOperationDelegate onEndcalculaFactibilidadDelegate;
        
        private System.Threading.SendOrPostCallback oncalculaFactibilidadCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WsCalculaFactibilidadPortTypeClient() {
        }
        
        public WsCalculaFactibilidadPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsCalculaFactibilidadPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsCalculaFactibilidadPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsCalculaFactibilidadPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<calculaFactibilidadCompletedEventArgs> calculaFactibilidadCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType.BegincalculaFactibilidad(Lite.ServiceFactibilidad1.calculaFactibilidadRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegincalculaFactibilidad(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lite.ServiceFactibilidad1.calculaFactibilidadResponse Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType.EndcalculaFactibilidad(System.IAsyncResult result) {
            return base.Channel.EndcalculaFactibilidad(result);
        }
        
        private System.IAsyncResult OnBegincalculaFactibilidad(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Lite.ServiceFactibilidad1.calculaFactibilidadRequest request = ((Lite.ServiceFactibilidad1.calculaFactibilidadRequest)(inValues[0]));
            return ((Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType)(this)).BegincalculaFactibilidad(request, callback, asyncState);
        }
        
        private object[] OnEndcalculaFactibilidad(System.IAsyncResult result) {
            Lite.ServiceFactibilidad1.calculaFactibilidadResponse retVal = ((Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType)(this)).EndcalculaFactibilidad(result);
            return new object[] {
                    retVal};
        }
        
        private void OncalculaFactibilidadCompleted(object state) {
            if ((this.calculaFactibilidadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.calculaFactibilidadCompleted(this, new calculaFactibilidadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void calculaFactibilidadAsync(Lite.ServiceFactibilidad1.calculaFactibilidadRequest request) {
            this.calculaFactibilidadAsync(request, null);
        }
        
        public void calculaFactibilidadAsync(Lite.ServiceFactibilidad1.calculaFactibilidadRequest request, object userState) {
            if ((this.onBegincalculaFactibilidadDelegate == null)) {
                this.onBegincalculaFactibilidadDelegate = new BeginOperationDelegate(this.OnBegincalculaFactibilidad);
            }
            if ((this.onEndcalculaFactibilidadDelegate == null)) {
                this.onEndcalculaFactibilidadDelegate = new EndOperationDelegate(this.OnEndcalculaFactibilidad);
            }
            if ((this.oncalculaFactibilidadCompletedDelegate == null)) {
                this.oncalculaFactibilidadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OncalculaFactibilidadCompleted);
            }
            base.InvokeAsync(this.onBegincalculaFactibilidadDelegate, new object[] {
                        request}, this.onEndcalculaFactibilidadDelegate, this.oncalculaFactibilidadCompletedDelegate, userState);
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
        
        protected override Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType CreateChannel() {
            return new WsCalculaFactibilidadPortTypeClientChannel(this);
        }
        
        private class WsCalculaFactibilidadPortTypeClientChannel : ChannelBase<Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType>, Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType {
            
            public WsCalculaFactibilidadPortTypeClientChannel(System.ServiceModel.ClientBase<Lite.ServiceFactibilidad1.WsCalculaFactibilidadPortType> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BegincalculaFactibilidad(Lite.ServiceFactibilidad1.calculaFactibilidadRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("calculaFactibilidad", _args, callback, asyncState);
                return _result;
            }
            
            public Lite.ServiceFactibilidad1.calculaFactibilidadResponse EndcalculaFactibilidad(System.IAsyncResult result) {
                object[] _args = new object[0];
                Lite.ServiceFactibilidad1.calculaFactibilidadResponse _result = null;
                try
                {
                    _result = ((Lite.ServiceFactibilidad1.calculaFactibilidadResponse)(base.EndInvoke("calculaFactibilidad", _args, result)));
                }
                catch { }
                return _result;
            }
        }
    }
}
