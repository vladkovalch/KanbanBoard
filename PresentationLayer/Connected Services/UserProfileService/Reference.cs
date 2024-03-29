﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer.UserProfileService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDTO", Namespace="http://schemas.datacontract.org/2004/07/BusinessLogicLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class UserDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.UserProfileService.BoardDTO[] BoardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfileIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Sha256PasswordField;
        
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
        public PresentationLayer.UserProfileService.BoardDTO[] Boards {
            get {
                return this.BoardsField;
            }
            set {
                if ((object.ReferenceEquals(this.BoardsField, value) != true)) {
                    this.BoardsField = value;
                    this.RaisePropertyChanged("Boards");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public int ProfileId {
            get {
                return this.ProfileIdField;
            }
            set {
                if ((this.ProfileIdField.Equals(value) != true)) {
                    this.ProfileIdField = value;
                    this.RaisePropertyChanged("ProfileId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sha256Password {
            get {
                return this.Sha256PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.Sha256PasswordField, value) != true)) {
                    this.Sha256PasswordField = value;
                    this.RaisePropertyChanged("Sha256Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BoardDTO", Namespace="http://schemas.datacontract.org/2004/07/BusinessLogicLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class BoardDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.UserProfileService.ListDTO[] ListsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.UserProfileService.UserDTO[] UsersField;
        
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
        public PresentationLayer.UserProfileService.ListDTO[] Lists {
            get {
                return this.ListsField;
            }
            set {
                if ((object.ReferenceEquals(this.ListsField, value) != true)) {
                    this.ListsField = value;
                    this.RaisePropertyChanged("Lists");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PresentationLayer.UserProfileService.UserDTO[] Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ListDTO", Namespace="http://schemas.datacontract.org/2004/07/BusinessLogicLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class ListDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.UserProfileService.CardDTO[] CardsField;
        
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
        public PresentationLayer.UserProfileService.CardDTO[] Cards {
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
        private PresentationLayer.UserProfileService.Color ColorField;
        
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
        public PresentationLayer.UserProfileService.Color Color {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserProfileService.IUserMgmtContract")]
    public interface IUserMgmtContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/AddUser", ReplyAction="http://tempuri.org/IUserMgmtContract/AddUserResponse")]
        void AddUser(PresentationLayer.UserProfileService.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/AddUser", ReplyAction="http://tempuri.org/IUserMgmtContract/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(PresentationLayer.UserProfileService.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/FindUserById", ReplyAction="http://tempuri.org/IUserMgmtContract/FindUserByIdResponse")]
        PresentationLayer.UserProfileService.UserDTO FindUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/FindUserById", ReplyAction="http://tempuri.org/IUserMgmtContract/FindUserByIdResponse")]
        System.Threading.Tasks.Task<PresentationLayer.UserProfileService.UserDTO> FindUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/GetAllUsers", ReplyAction="http://tempuri.org/IUserMgmtContract/GetAllUsersResponse")]
        PresentationLayer.UserProfileService.UserDTO[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/GetAllUsers", ReplyAction="http://tempuri.org/IUserMgmtContract/GetAllUsersResponse")]
        System.Threading.Tasks.Task<PresentationLayer.UserProfileService.UserDTO[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/GetUsers", ReplyAction="http://tempuri.org/IUserMgmtContract/GetUsersResponse")]
        PresentationLayer.UserProfileService.UserDTO[] GetUsers(System.Func<PresentationLayer.UserProfileService.UserDTO, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/GetUsers", ReplyAction="http://tempuri.org/IUserMgmtContract/GetUsersResponse")]
        System.Threading.Tasks.Task<PresentationLayer.UserProfileService.UserDTO[]> GetUsersAsync(System.Func<PresentationLayer.UserProfileService.UserDTO, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/RemoveUser", ReplyAction="http://tempuri.org/IUserMgmtContract/RemoveUserResponse")]
        void RemoveUser(PresentationLayer.UserProfileService.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/RemoveUser", ReplyAction="http://tempuri.org/IUserMgmtContract/RemoveUserResponse")]
        System.Threading.Tasks.Task RemoveUserAsync(PresentationLayer.UserProfileService.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/UpdateUser", ReplyAction="http://tempuri.org/IUserMgmtContract/UpdateUserResponse")]
        void UpdateUser(PresentationLayer.UserProfileService.UserDTO user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserMgmtContract/UpdateUser", ReplyAction="http://tempuri.org/IUserMgmtContract/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(PresentationLayer.UserProfileService.UserDTO user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserMgmtContractChannel : PresentationLayer.UserProfileService.IUserMgmtContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserMgmtContractClient : System.ServiceModel.ClientBase<PresentationLayer.UserProfileService.IUserMgmtContract>, PresentationLayer.UserProfileService.IUserMgmtContract {
        
        public UserMgmtContractClient() {
        }
        
        public UserMgmtContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserMgmtContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserMgmtContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserMgmtContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddUser(PresentationLayer.UserProfileService.UserDTO user) {
            base.Channel.AddUser(user);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(PresentationLayer.UserProfileService.UserDTO user) {
            return base.Channel.AddUserAsync(user);
        }
        
        public PresentationLayer.UserProfileService.UserDTO FindUserById(int id) {
            return base.Channel.FindUserById(id);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.UserProfileService.UserDTO> FindUserByIdAsync(int id) {
            return base.Channel.FindUserByIdAsync(id);
        }
        
        public PresentationLayer.UserProfileService.UserDTO[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.UserProfileService.UserDTO[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public PresentationLayer.UserProfileService.UserDTO[] GetUsers(System.Func<PresentationLayer.UserProfileService.UserDTO, bool> predicate) {
            return base.Channel.GetUsers(predicate);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.UserProfileService.UserDTO[]> GetUsersAsync(System.Func<PresentationLayer.UserProfileService.UserDTO, bool> predicate) {
            return base.Channel.GetUsersAsync(predicate);
        }
        
        public void RemoveUser(PresentationLayer.UserProfileService.UserDTO user) {
            base.Channel.RemoveUser(user);
        }
        
        public System.Threading.Tasks.Task RemoveUserAsync(PresentationLayer.UserProfileService.UserDTO user) {
            return base.Channel.RemoveUserAsync(user);
        }
        
        public void UpdateUser(PresentationLayer.UserProfileService.UserDTO user) {
            base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(PresentationLayer.UserProfileService.UserDTO user) {
            return base.Channel.UpdateUserAsync(user);
        }
    }
}
