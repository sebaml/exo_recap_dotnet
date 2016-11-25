﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contoso.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryDetail", Namespace="http://schemas.datacontract.org/2004/07/DataModel")]
    [System.SerializableAttribute()]
    public partial class CategoryDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PictureField;
        
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
        public long CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ICategoryService")]
    public interface ICategoryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategoryByName", ReplyAction="http://tempuri.org/ICategoryService/GetCategoryByNameResponse")]
        Contoso.ServiceReference2.CategoryDetail[] GetCategoryByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/GetCategoryByName", ReplyAction="http://tempuri.org/ICategoryService/GetCategoryByNameResponse")]
        System.Threading.Tasks.Task<Contoso.ServiceReference2.CategoryDetail[]> GetCategoryByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/DelCategory", ReplyAction="http://tempuri.org/ICategoryService/DelCategoryResponse")]
        void DelCategory(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/DelCategory", ReplyAction="http://tempuri.org/ICategoryService/DelCategoryResponse")]
        System.Threading.Tasks.Task DelCategoryAsync(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/UpdateCategory", ReplyAction="http://tempuri.org/ICategoryService/UpdateCategoryResponse")]
        bool UpdateCategory(Contoso.ServiceReference2.CategoryDetail cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/UpdateCategory", ReplyAction="http://tempuri.org/ICategoryService/UpdateCategoryResponse")]
        System.Threading.Tasks.Task<bool> UpdateCategoryAsync(Contoso.ServiceReference2.CategoryDetail cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        bool AddCategory(Contoso.ServiceReference2.CategoryDetail cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategoryService/AddCategory", ReplyAction="http://tempuri.org/ICategoryService/AddCategoryResponse")]
        System.Threading.Tasks.Task<bool> AddCategoryAsync(Contoso.ServiceReference2.CategoryDetail cd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryServiceChannel : Contoso.ServiceReference2.ICategoryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryServiceClient : System.ServiceModel.ClientBase<Contoso.ServiceReference2.ICategoryService>, Contoso.ServiceReference2.ICategoryService {
        
        public CategoryServiceClient() {
        }
        
        public CategoryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Contoso.ServiceReference2.CategoryDetail[] GetCategoryByName(string name) {
            return base.Channel.GetCategoryByName(name);
        }
        
        public System.Threading.Tasks.Task<Contoso.ServiceReference2.CategoryDetail[]> GetCategoryByNameAsync(string name) {
            return base.Channel.GetCategoryByNameAsync(name);
        }
        
        public void DelCategory(long id) {
            base.Channel.DelCategory(id);
        }
        
        public System.Threading.Tasks.Task DelCategoryAsync(long id) {
            return base.Channel.DelCategoryAsync(id);
        }
        
        public bool UpdateCategory(Contoso.ServiceReference2.CategoryDetail cd) {
            return base.Channel.UpdateCategory(cd);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateCategoryAsync(Contoso.ServiceReference2.CategoryDetail cd) {
            return base.Channel.UpdateCategoryAsync(cd);
        }
        
        public bool AddCategory(Contoso.ServiceReference2.CategoryDetail cd) {
            return base.Channel.AddCategory(cd);
        }
        
        public System.Threading.Tasks.Task<bool> AddCategoryAsync(Contoso.ServiceReference2.CategoryDetail cd) {
            return base.Channel.AddCategoryAsync(cd);
        }
    }
}
