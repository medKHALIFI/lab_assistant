//------------------------------------------------------------------------------
// <auto-generated>
//     Este c�digo fue generado por una herramienta.
//     Versi�n de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podr�an causar un comportamiento incorrecto y se perder�n si
//     se vuelve a generar el c�digo.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Lite.ServiceU2000
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.grr.net.fv/svc", ConfigurationName = "ServiceU2000.WsOpticalInformationPortType")]
    public interface WsOpticalInformationPortType
    {

        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "urn:opticalInformation", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        System.IAsyncResult BeginopticalInformation(Lite.ServiceU2000.opticalInformationRequest request, System.AsyncCallback callback, object asyncState);

        Lite.ServiceU2000.opticalInformationResponse EndopticalInformation(System.IAsyncResult result);
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.grr.net.fv/gis")]
    public partial class process : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string no_AccountField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string No_Account
        {
            get
            {
                return this.no_AccountField;
            }
            set
            {
                this.no_AccountField = value;
                this.RaisePropertyChanged("No_Account");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.grr.net.fv/gis")]
    public partial class processResponse : object, System.ComponentModel.INotifyPropertyChanged
    {

        private processResponseONTS[] oNTSField;

        private processResponseArrResult arrResultField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("ONTS", Order = 0)]
        public processResponseONTS[] ONTS
        {
            get
            {
                return this.oNTSField;
            }
            set
            {
                this.oNTSField = value;
                this.RaisePropertyChanged("ONTS");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public processResponseArrResult arrResult
        {
            get
            {
                return this.arrResultField;
            }
            set
            {
                this.arrResultField = value;
                this.RaisePropertyChanged("arrResult");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.grr.net.fv/gis")]
    public partial class processResponseONTS : object, System.ComponentModel.INotifyPropertyChanged
    {

        private string snField;

        private string tXPowerField;

        private string rXPowerField;

        private string tXTEMPERATUREField;

        private string tXVOLField;

        private string bIASCURRENTField;

        private string oLTField;

        private string fRAMEField;

        private string sLOTField;

        private string pORTField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string SN
        {
            get
            {
                return this.snField;
            }
            set
            {
                this.snField = value;
                this.RaisePropertyChanged("SN");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string TXPower
        {
            get
            {
                return this.tXPowerField;
            }
            set
            {
                this.tXPowerField = value;
                this.RaisePropertyChanged("TXPower");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string RXPower
        {
            get
            {
                return this.rXPowerField;
            }
            set
            {
                this.rXPowerField = value;
                this.RaisePropertyChanged("RXPower");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string TXTEMPERATURE
        {
            get
            {
                return this.tXTEMPERATUREField;
            }
            set
            {
                this.tXTEMPERATUREField = value;
                this.RaisePropertyChanged("TXTEMPERATURE");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string TXVOL
        {
            get
            {
                return this.tXVOLField;
            }
            set
            {
                this.tXVOLField = value;
                this.RaisePropertyChanged("TXVOL");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string BIASCURRENT
        {
            get
            {
                return this.bIASCURRENTField;
            }
            set
            {
                this.bIASCURRENTField = value;
                this.RaisePropertyChanged("BIASCURRENT");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string OLT
        {
            get
            {
                return this.oLTField;
            }
            set
            {
                this.oLTField = value;
                this.RaisePropertyChanged("OLT");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string FRAME
        {
            get
            {
                return this.fRAMEField;
            }
            set
            {
                this.fRAMEField = value;
                this.RaisePropertyChanged("FRAME");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string SLOT
        {
            get
            {
                return this.sLOTField;
            }
            set
            {
                this.sLOTField = value;
                this.RaisePropertyChanged("SLOT");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string PORT
        {
            get
            {
                return this.pORTField;
            }
            set
            {
                this.pORTField = value;
                this.RaisePropertyChanged("PORT");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.grr.net.fv/gis")]
    public partial class processResponseArrResult : object, System.ComponentModel.INotifyPropertyChanged
    {

        private long idResultField;

        private int resultField;

        private string resultDescriptionField;

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public long IdResult
        {
            get
            {
                return this.idResultField;
            }
            set
            {
                this.idResultField = value;
                this.RaisePropertyChanged("IdResult");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public int Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
                this.RaisePropertyChanged("Result");
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ResultDescription
        {
            get
            {
                return this.resultDescriptionField;
            }
            set
            {
                this.resultDescriptionField = value;
                this.RaisePropertyChanged("ResultDescription");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class opticalInformationRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "WsOpticalInformation-RQ", Namespace = "http://www.grr.net.fv/gis", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("WsOpticalInformation-RQ")]
        public Lite.ServiceU2000.process WsOpticalInformationRQ;

        public opticalInformationRequest()
        {
        }

        public opticalInformationRequest(Lite.ServiceU2000.process WsOpticalInformationRQ)
        {
            this.WsOpticalInformationRQ = WsOpticalInformationRQ;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class opticalInformationResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "WsOpticalInformation-RS", Namespace = "http://www.grr.net.fv/gis", Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("WsOpticalInformation-RS")]
        public Lite.ServiceU2000.processResponse WsOpticalInformationRS;

        public opticalInformationResponse()
        {
        }

        public opticalInformationResponse(Lite.ServiceU2000.processResponse WsOpticalInformationRS)
        {
            this.WsOpticalInformationRS = WsOpticalInformationRS;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WsOpticalInformationPortTypeChannel : Lite.ServiceU2000.WsOpticalInformationPortType, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class opticalInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        public opticalInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        public Lite.ServiceU2000.opticalInformationResponse Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((Lite.ServiceU2000.opticalInformationResponse)(this.results[0]));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsOpticalInformationPortTypeClient : System.ServiceModel.ClientBase<Lite.ServiceU2000.WsOpticalInformationPortType>, Lite.ServiceU2000.WsOpticalInformationPortType
    {

        private BeginOperationDelegate onBeginopticalInformationDelegate;

        private EndOperationDelegate onEndopticalInformationDelegate;

        private System.Threading.SendOrPostCallback onopticalInformationCompletedDelegate;

        private BeginOperationDelegate onBeginOpenDelegate;

        private EndOperationDelegate onEndOpenDelegate;

        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;

        private BeginOperationDelegate onBeginCloseDelegate;

        private EndOperationDelegate onEndCloseDelegate;

        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;

        public WsOpticalInformationPortTypeClient()
        {
        }

        public WsOpticalInformationPortTypeClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public WsOpticalInformationPortTypeClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public WsOpticalInformationPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public WsOpticalInformationPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public System.Net.CookieContainer CookieContainer
        {
            get
            {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null))
                {
                    return httpCookieContainerManager.CookieContainer;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null))
                {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else
                {
                    throw new System.InvalidOperationException("No se puede establecer el objeto CookieContainer. Aseg�rese de que el enlace cont" +
                            "iene un objeto HttpCookieContainerBindingElement.");
                }
            }
        }

        public event System.EventHandler<opticalInformationCompletedEventArgs> opticalInformationCompleted;

        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;

        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Lite.ServiceU2000.WsOpticalInformationPortType.BeginopticalInformation(Lite.ServiceU2000.opticalInformationRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginopticalInformation(request, callback, asyncState);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lite.ServiceU2000.opticalInformationResponse Lite.ServiceU2000.WsOpticalInformationPortType.EndopticalInformation(System.IAsyncResult result)
        {
            return base.Channel.EndopticalInformation(result);
        }

        private System.IAsyncResult OnBeginopticalInformation(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            Lite.ServiceU2000.opticalInformationRequest request = ((Lite.ServiceU2000.opticalInformationRequest)(inValues[0]));
            return ((Lite.ServiceU2000.WsOpticalInformationPortType)(this)).BeginopticalInformation(request, callback, asyncState);
        }

        private object[] OnEndopticalInformation(System.IAsyncResult result)
        {
            Lite.ServiceU2000.opticalInformationResponse retVal = ((Lite.ServiceU2000.WsOpticalInformationPortType)(this)).EndopticalInformation(result);
            return new object[] {
                    retVal};
        }

        private void OnopticalInformationCompleted(object state)
        {
            if ((this.opticalInformationCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.opticalInformationCompleted(this, new opticalInformationCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }

        public void opticalInformationAsync(Lite.ServiceU2000.opticalInformationRequest request)
        {
            this.opticalInformationAsync(request, null);
        }

        public void opticalInformationAsync(Lite.ServiceU2000.opticalInformationRequest request, object userState)
        {
            if ((this.onBeginopticalInformationDelegate == null))
            {
                this.onBeginopticalInformationDelegate = new BeginOperationDelegate(this.OnBeginopticalInformation);
            }
            if ((this.onEndopticalInformationDelegate == null))
            {
                this.onEndopticalInformationDelegate = new EndOperationDelegate(this.OnEndopticalInformation);
            }
            if ((this.onopticalInformationCompletedDelegate == null))
            {
                this.onopticalInformationCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnopticalInformationCompleted);
            }
            base.InvokeAsync(this.onBeginopticalInformationDelegate, new object[] {
                        request}, this.onEndopticalInformationDelegate, this.onopticalInformationCompletedDelegate, userState);
        }

        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }

        private object[] OnEndOpen(System.IAsyncResult result)
        {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }

        private void OnOpenCompleted(object state)
        {
            if ((this.OpenCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }

        public void OpenAsync()
        {
            this.OpenAsync(null);
        }

        public void OpenAsync(object userState)
        {
            if ((this.onBeginOpenDelegate == null))
            {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null))
            {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null))
            {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }

        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }

        private object[] OnEndClose(System.IAsyncResult result)
        {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }

        private void OnCloseCompleted(object state)
        {
            if ((this.CloseCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }

        public void CloseAsync()
        {
            this.CloseAsync(null);
        }

        public void CloseAsync(object userState)
        {
            if ((this.onBeginCloseDelegate == null))
            {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null))
            {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null))
            {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }

        protected override Lite.ServiceU2000.WsOpticalInformationPortType CreateChannel()
        {
            return new WsOpticalInformationPortTypeClientChannel(this);
        }

        private class WsOpticalInformationPortTypeClientChannel : ChannelBase<Lite.ServiceU2000.WsOpticalInformationPortType>, Lite.ServiceU2000.WsOpticalInformationPortType
        {

            public WsOpticalInformationPortTypeClientChannel(System.ServiceModel.ClientBase<Lite.ServiceU2000.WsOpticalInformationPortType> client) :
                base(client)
            {
            }

            public System.IAsyncResult BeginopticalInformation(Lite.ServiceU2000.opticalInformationRequest request, System.AsyncCallback callback, object asyncState)
            {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("opticalInformation", _args, callback, asyncState);
                return _result;
            }

            public Lite.ServiceU2000.opticalInformationResponse EndopticalInformation(System.IAsyncResult result)
            {
                object[] _args = new object[0];
                Lite.ServiceU2000.opticalInformationResponse _result = ((Lite.ServiceU2000.opticalInformationResponse)(base.EndInvoke("opticalInformation", _args, result)));
                return _result;
            }
        }
    }
}
