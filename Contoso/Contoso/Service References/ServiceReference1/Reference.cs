﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contoso.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SupplierType", Namespace="http://schemas.datacontract.org/2004/07/DataModel")]
    [System.SerializableAttribute()]
    public partial class SupplierType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long SupplierIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactName {
            get {
                return this.ContactNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNameField, value) != true)) {
                    this.ContactNameField = value;
                    this.RaisePropertyChanged("ContactName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactTitle {
            get {
                return this.ContactTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactTitleField, value) != true)) {
                    this.ContactTitleField = value;
                    this.RaisePropertyChanged("ContactTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long SupplierId {
            get {
                return this.SupplierIdField;
            }
            set {
                if ((this.SupplierIdField.Equals(value) != true)) {
                    this.SupplierIdField = value;
                    this.RaisePropertyChanged("SupplierId");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SupplierDetail", Namespace="http://schemas.datacontract.org/2004/07/DataModel")]
    [System.SerializableAttribute()]
    public partial class SupplierDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long SupplierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WebsiteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactName {
            get {
                return this.ContactNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactNameField, value) != true)) {
                    this.ContactNameField = value;
                    this.RaisePropertyChanged("ContactName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactTitle {
            get {
                return this.ContactTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactTitleField, value) != true)) {
                    this.ContactTitleField = value;
                    this.RaisePropertyChanged("ContactTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fax {
            get {
                return this.FaxField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxField, value) != true)) {
                    this.FaxField = value;
                    this.RaisePropertyChanged("Fax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region {
            get {
                return this.RegionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionField, value) != true)) {
                    this.RegionField = value;
                    this.RaisePropertyChanged("Region");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long SupplierId {
            get {
                return this.SupplierIdField;
            }
            set {
                if ((this.SupplierIdField.Equals(value) != true)) {
                    this.SupplierIdField = value;
                    this.RaisePropertyChanged("SupplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel {
            get {
                return this.TelField;
            }
            set {
                if ((object.ReferenceEquals(this.TelField, value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Website {
            get {
                return this.WebsiteField;
            }
            set {
                if ((object.ReferenceEquals(this.WebsiteField, value) != true)) {
                    this.WebsiteField = value;
                    this.RaisePropertyChanged("Website");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISupplierService")]
    public interface ISupplierService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/GetSupplierByName", ReplyAction="http://tempuri.org/ISupplierService/GetSupplierByNameResponse")]
        System.Collections.Generic.List<Contoso.ServiceReference1.SupplierType> GetSupplierByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/GetSupplierByName", ReplyAction="http://tempuri.org/ISupplierService/GetSupplierByNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Contoso.ServiceReference1.SupplierType>> GetSupplierByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/GetSupplierDetail", ReplyAction="http://tempuri.org/ISupplierService/GetSupplierDetailResponse")]
        Contoso.ServiceReference1.SupplierDetail GetSupplierDetail(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/GetSupplierDetail", ReplyAction="http://tempuri.org/ISupplierService/GetSupplierDetailResponse")]
        System.Threading.Tasks.Task<Contoso.ServiceReference1.SupplierDetail> GetSupplierDetailAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/DelSupplier", ReplyAction="http://tempuri.org/ISupplierService/DelSupplierResponse")]
        bool DelSupplier(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/DelSupplier", ReplyAction="http://tempuri.org/ISupplierService/DelSupplierResponse")]
        System.Threading.Tasks.Task<bool> DelSupplierAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/UpdateSupplier", ReplyAction="http://tempuri.org/ISupplierService/UpdateSupplierResponse")]
        bool UpdateSupplier(Contoso.ServiceReference1.SupplierDetail sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/UpdateSupplier", ReplyAction="http://tempuri.org/ISupplierService/UpdateSupplierResponse")]
        System.Threading.Tasks.Task<bool> UpdateSupplierAsync(Contoso.ServiceReference1.SupplierDetail sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/AddSupplier", ReplyAction="http://tempuri.org/ISupplierService/AddSupplierResponse")]
        bool AddSupplier(Contoso.ServiceReference1.SupplierDetail sd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplierService/AddSupplier", ReplyAction="http://tempuri.org/ISupplierService/AddSupplierResponse")]
        System.Threading.Tasks.Task<bool> AddSupplierAsync(Contoso.ServiceReference1.SupplierDetail sd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISupplierServiceChannel : Contoso.ServiceReference1.ISupplierService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SupplierServiceClient : System.ServiceModel.ClientBase<Contoso.ServiceReference1.ISupplierService>, Contoso.ServiceReference1.ISupplierService {
        
        public SupplierServiceClient() {
        }
        
        public SupplierServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SupplierServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplierServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplierServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Contoso.ServiceReference1.SupplierType> GetSupplierByName(string name) {
            return base.Channel.GetSupplierByName(name);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Contoso.ServiceReference1.SupplierType>> GetSupplierByNameAsync(string name) {
            return base.Channel.GetSupplierByNameAsync(name);
        }
        
        public Contoso.ServiceReference1.SupplierDetail GetSupplierDetail(long id) {
            return base.Channel.GetSupplierDetail(id);
        }
        
        public System.Threading.Tasks.Task<Contoso.ServiceReference1.SupplierDetail> GetSupplierDetailAsync(long id) {
            return base.Channel.GetSupplierDetailAsync(id);
        }
        
        public bool DelSupplier(long id) {
            return base.Channel.DelSupplier(id);
        }
        
        public System.Threading.Tasks.Task<bool> DelSupplierAsync(long id) {
            return base.Channel.DelSupplierAsync(id);
        }
        
        public bool UpdateSupplier(Contoso.ServiceReference1.SupplierDetail sd) {
            return base.Channel.UpdateSupplier(sd);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateSupplierAsync(Contoso.ServiceReference1.SupplierDetail sd) {
            return base.Channel.UpdateSupplierAsync(sd);
        }
        
        public bool AddSupplier(Contoso.ServiceReference1.SupplierDetail sd) {
            return base.Channel.AddSupplier(sd);
        }
        
        public System.Threading.Tasks.Task<bool> AddSupplierAsync(Contoso.ServiceReference1.SupplierDetail sd) {
            return base.Channel.AddSupplierAsync(sd);
        }
    }
}
