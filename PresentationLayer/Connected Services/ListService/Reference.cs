﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer.ListService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListDTO", Namespace="http://schemas.datacontract.org/2004/07/BusinessLogicLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class ListDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.ListService.CardDTO[] CardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public PresentationLayer.ListService.CardDTO[] Cards {
            get {
                return this.CardsField;
            }
            set {
                if ((object.ReferenceEquals(this.CardsField, value) != true)) {
                    this.CardsField = value;
                    this.RaisePropertyChanged("Cards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CardDTO", Namespace="http://schemas.datacontract.org/2004/07/BusinessLogicLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class CardDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.ListService.Color ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public PresentationLayer.ListService.Color Color {
            get {
                return this.ColorField;
            }
            set {
                if ((this.ColorField.Equals(value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/System.Drawing")]
    [System.SerializableAttribute()]
    public partial struct Color : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private short knownColorField;
        
        private string nameField;
        
        private short stateField;
        
        private long valueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short knownColor {
            get {
                return this.knownColorField;
            }
            set {
                if ((this.knownColorField.Equals(value) != true)) {
                    this.knownColorField = value;
                    this.RaisePropertyChanged("knownColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short state {
            get {
                return this.stateField;
            }
            set {
                if ((this.stateField.Equals(value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long value {
            get {
                return this.valueField;
            }
            set {
                if ((this.valueField.Equals(value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ListService.IListMgmtContract")]
    public interface IListMgmtContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/AddList", ReplyAction="http://tempuri.org/IListMgmtContract/AddListResponse")]
        void AddList(PresentationLayer.ListService.ListDTO list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/AddList", ReplyAction="http://tempuri.org/IListMgmtContract/AddListResponse")]
        System.Threading.Tasks.Task AddListAsync(PresentationLayer.ListService.ListDTO list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/FindListById", ReplyAction="http://tempuri.org/IListMgmtContract/FindListByIdResponse")]
        PresentationLayer.ListService.ListDTO FindListById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/FindListById", ReplyAction="http://tempuri.org/IListMgmtContract/FindListByIdResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ListService.ListDTO> FindListByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/GetAllLists", ReplyAction="http://tempuri.org/IListMgmtContract/GetAllListsResponse")]
        PresentationLayer.ListService.ListDTO[] GetAllLists();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/GetAllLists", ReplyAction="http://tempuri.org/IListMgmtContract/GetAllListsResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ListService.ListDTO[]> GetAllListsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/GetLists", ReplyAction="http://tempuri.org/IListMgmtContract/GetListsResponse")]
        PresentationLayer.ListService.ListDTO[] GetLists(System.Func<PresentationLayer.ListService.ListDTO, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/GetLists", ReplyAction="http://tempuri.org/IListMgmtContract/GetListsResponse")]
        System.Threading.Tasks.Task<PresentationLayer.ListService.ListDTO[]> GetListsAsync(System.Func<PresentationLayer.ListService.ListDTO, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/RemoveList", ReplyAction="http://tempuri.org/IListMgmtContract/RemoveListResponse")]
        void RemoveList(PresentationLayer.ListService.ListDTO list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/RemoveList", ReplyAction="http://tempuri.org/IListMgmtContract/RemoveListResponse")]
        System.Threading.Tasks.Task RemoveListAsync(PresentationLayer.ListService.ListDTO list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/UpdateList", ReplyAction="http://tempuri.org/IListMgmtContract/UpdateListResponse")]
        void UpdateList(PresentationLayer.ListService.ListDTO list);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListMgmtContract/UpdateList", ReplyAction="http://tempuri.org/IListMgmtContract/UpdateListResponse")]
        System.Threading.Tasks.Task UpdateListAsync(PresentationLayer.ListService.ListDTO list);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IListMgmtContractChannel : PresentationLayer.ListService.IListMgmtContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListMgmtContractClient : System.ServiceModel.ClientBase<PresentationLayer.ListService.IListMgmtContract>, PresentationLayer.ListService.IListMgmtContract {
        
        public ListMgmtContractClient() {
        }
        
        public ListMgmtContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ListMgmtContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListMgmtContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListMgmtContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddList(PresentationLayer.ListService.ListDTO list) {
            base.Channel.AddList(list);
        }
        
        public System.Threading.Tasks.Task AddListAsync(PresentationLayer.ListService.ListDTO list) {
            return base.Channel.AddListAsync(list);
        }
        
        public PresentationLayer.ListService.ListDTO FindListById(int id) {
            return base.Channel.FindListById(id);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ListService.ListDTO> FindListByIdAsync(int id) {
            return base.Channel.FindListByIdAsync(id);
        }
        
        public PresentationLayer.ListService.ListDTO[] GetAllLists() {
            return base.Channel.GetAllLists();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ListService.ListDTO[]> GetAllListsAsync() {
            return base.Channel.GetAllListsAsync();
        }
        
        public PresentationLayer.ListService.ListDTO[] GetLists(System.Func<PresentationLayer.ListService.ListDTO, bool> predicate) {
            return base.Channel.GetLists(predicate);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.ListService.ListDTO[]> GetListsAsync(System.Func<PresentationLayer.ListService.ListDTO, bool> predicate) {
            return base.Channel.GetListsAsync(predicate);
        }
        
        public void RemoveList(PresentationLayer.ListService.ListDTO list) {
            base.Channel.RemoveList(list);
        }
        
        public System.Threading.Tasks.Task RemoveListAsync(PresentationLayer.ListService.ListDTO list) {
            return base.Channel.RemoveListAsync(list);
        }
        
        public void UpdateList(PresentationLayer.ListService.ListDTO list) {
            base.Channel.UpdateList(list);
        }
        
        public System.Threading.Tasks.Task UpdateListAsync(PresentationLayer.ListService.ListDTO list) {
            return base.Channel.UpdateListAsync(list);
        }
    }
}
