﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientAffiliate.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
    [System.SerializableAttribute()]
    public partial class CustomFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vAffiliate", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
    [System.SerializableAttribute()]
    public partial class vAffiliate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> BirthDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MainLibrary_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ValidityField;
        
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
        public System.Nullable<System.DateTime> BirthDate {
            get {
                return this.BirthDateField;
            }
            set {
                if ((this.BirthDateField.Equals(value) != true)) {
                    this.BirthDateField = value;
                    this.RaisePropertyChanged("BirthDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CardNum {
            get {
                return this.CardNumField;
            }
            set {
                if ((this.CardNumField.Equals(value) != true)) {
                    this.CardNumField = value;
                    this.RaisePropertyChanged("CardNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MainLibrary_Id {
            get {
                return this.MainLibrary_IdField;
            }
            set {
                if ((this.MainLibrary_IdField.Equals(value) != true)) {
                    this.MainLibrary_IdField = value;
                    this.RaisePropertyChanged("MainLibrary_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Validity {
            get {
                return this.ValidityField;
            }
            set {
                if ((this.ValidityField.Equals(value) != true)) {
                    this.ValidityField = value;
                    this.RaisePropertyChanged("Validity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vEmpruntDetail", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
    [System.SerializableAttribute()]
    public partial class vEmpruntDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DailyPenaltyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short DurationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdEmpruntField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Item_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> LastModifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Library_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameLibraryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameTarifField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReturnDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Tarif_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public int CardNum {
            get {
                return this.CardNumField;
            }
            set {
                if ((this.CardNumField.Equals(value) != true)) {
                    this.CardNumField = value;
                    this.RaisePropertyChanged("CardNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DailyPenalty {
            get {
                return this.DailyPenaltyField;
            }
            set {
                if ((this.DailyPenaltyField.Equals(value) != true)) {
                    this.DailyPenaltyField = value;
                    this.RaisePropertyChanged("DailyPenalty");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((this.DurationField.Equals(value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Fee {
            get {
                return this.FeeField;
            }
            set {
                if ((this.FeeField.Equals(value) != true)) {
                    this.FeeField = value;
                    this.RaisePropertyChanged("Fee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdEmprunt {
            get {
                return this.IdEmpruntField;
            }
            set {
                if ((this.IdEmpruntField.Equals(value) != true)) {
                    this.IdEmpruntField = value;
                    this.RaisePropertyChanged("IdEmprunt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Item_Id {
            get {
                return this.Item_IdField;
            }
            set {
                if ((this.Item_IdField.Equals(value) != true)) {
                    this.Item_IdField = value;
                    this.RaisePropertyChanged("Item_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> LastModified {
            get {
                return this.LastModifiedField;
            }
            set {
                if ((this.LastModifiedField.Equals(value) != true)) {
                    this.LastModifiedField = value;
                    this.RaisePropertyChanged("LastModified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Library_Id {
            get {
                return this.Library_IdField;
            }
            set {
                if ((this.Library_IdField.Equals(value) != true)) {
                    this.Library_IdField = value;
                    this.RaisePropertyChanged("Library_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameLibrary {
            get {
                return this.NameLibraryField;
            }
            set {
                if ((object.ReferenceEquals(this.NameLibraryField, value) != true)) {
                    this.NameLibraryField = value;
                    this.RaisePropertyChanged("NameLibrary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameTarif {
            get {
                return this.NameTarifField;
            }
            set {
                if ((object.ReferenceEquals(this.NameTarifField, value) != true)) {
                    this.NameTarifField = value;
                    this.RaisePropertyChanged("NameTarif");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReturnDate {
            get {
                return this.ReturnDateField;
            }
            set {
                if ((this.ReturnDateField.Equals(value) != true)) {
                    this.ReturnDateField = value;
                    this.RaisePropertyChanged("ReturnDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tarif_Id {
            get {
                return this.Tarif_IdField;
            }
            set {
                if ((this.Tarif_IdField.Equals(value) != true)) {
                    this.Tarif_IdField = value;
                    this.RaisePropertyChanged("Tarif_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vLibrary", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
    [System.SerializableAttribute()]
    public partial class vLibrary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeIdLibraryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdLibraryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameLibraryField;
        
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
        public string CodeIdLibrary {
            get {
                return this.CodeIdLibraryField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeIdLibraryField, value) != true)) {
                    this.CodeIdLibraryField = value;
                    this.RaisePropertyChanged("CodeIdLibrary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdLibrary {
            get {
                return this.IdLibraryField;
            }
            set {
                if ((this.IdLibraryField.Equals(value) != true)) {
                    this.IdLibraryField = value;
                    this.RaisePropertyChanged("IdLibrary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameLibrary {
            get {
                return this.NameLibraryField;
            }
            set {
                if ((object.ReferenceEquals(this.NameLibraryField, value) != true)) {
                    this.NameLibraryField = value;
                    this.RaisePropertyChanged("NameLibrary");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="vVolume", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
    [System.SerializableAttribute()]
    public partial class vVolume : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IsbnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Pers_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Cover {
            get {
                return this.CoverField;
            }
            set {
                if ((object.ReferenceEquals(this.CoverField, value) != true)) {
                    this.CoverField = value;
                    this.RaisePropertyChanged("Cover");
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
        public string Isbn {
            get {
                return this.IsbnField;
            }
            set {
                if ((object.ReferenceEquals(this.IsbnField, value) != true)) {
                    this.IsbnField = value;
                    this.RaisePropertyChanged("Isbn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pers_Id {
            get {
                return this.Pers_IdField;
            }
            set {
                if ((this.Pers_IdField.Equals(value) != true)) {
                    this.Pers_IdField = value;
                    this.RaisePropertyChanged("Pers_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IAffiliateService")]
    public interface IAffiliateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/CheckIn", ReplyAction="http://tempuri.org/IAffiliateService/CheckInResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/CheckInCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        bool CheckIn(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/CheckIn", ReplyAction="http://tempuri.org/IAffiliateService/CheckInResponse")]
        System.Threading.Tasks.Task<bool> CheckInAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetAffiliateById", ReplyAction="http://tempuri.org/IAffiliateService/GetAffiliateByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetAffiliateByIdCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vAffiliate GetAffiliateById(int lectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetAffiliateById", ReplyAction="http://tempuri.org/IAffiliateService/GetAffiliateByIdResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vAffiliate> GetAffiliateByIdAsync(int lectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetAffiliateByName", ReplyAction="http://tempuri.org/IAffiliateService/GetAffiliateByNameResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetAffiliateByNameCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vAffiliate GetAffiliateByName(string FirstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetAffiliateByName", ReplyAction="http://tempuri.org/IAffiliateService/GetAffiliateByNameResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vAffiliate> GetAffiliateByNameAsync(string FirstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetEmpruntsByAffiliate", ReplyAction="http://tempuri.org/IAffiliateService/GetEmpruntsByAffiliateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetEmpruntsByAffiliateCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vEmpruntDetail[] GetEmpruntsByAffiliate(int lectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetEmpruntsByAffiliate", ReplyAction="http://tempuri.org/IAffiliateService/GetEmpruntsByAffiliateResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vEmpruntDetail[]> GetEmpruntsByAffiliateAsync(int lectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetEmpruntByCode", ReplyAction="http://tempuri.org/IAffiliateService/GetEmpruntByCodeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetEmpruntByCodeCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vEmpruntDetail GetEmpruntByCode(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetEmpruntByCode", ReplyAction="http://tempuri.org/IAffiliateService/GetEmpruntByCodeResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vEmpruntDetail> GetEmpruntByCodeAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetRetards", ReplyAction="http://tempuri.org/IAffiliateService/GetRetardsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetRetardsCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vEmpruntDetail[] GetRetards(System.DateTime date, int libId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetRetards", ReplyAction="http://tempuri.org/IAffiliateService/GetRetardsResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vEmpruntDetail[]> GetRetardsAsync(System.DateTime date, int libId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetLibraries", ReplyAction="http://tempuri.org/IAffiliateService/GetLibrariesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetLibrariesCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vLibrary[] GetLibraries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetLibraries", ReplyAction="http://tempuri.org/IAffiliateService/GetLibrariesResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vLibrary[]> GetLibrariesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetAllVolumes", ReplyAction="http://tempuri.org/IAffiliateService/GetAllVolumesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClientAffiliate.ServiceReference2.CustomFault), Action="http://tempuri.org/IAffiliateService/GetAllVolumesCustomFaultFault", Name="CustomFault", Namespace="http://schemas.datacontract.org/2004/07/WcfBLAffiliate")]
        ClientAffiliate.ServiceReference2.vVolume[] GetAllVolumes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffiliateService/GetAllVolumes", ReplyAction="http://tempuri.org/IAffiliateService/GetAllVolumesResponse")]
        System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vVolume[]> GetAllVolumesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAffiliateServiceChannel : ClientAffiliate.ServiceReference2.IAffiliateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AffiliateServiceClient : System.ServiceModel.ClientBase<ClientAffiliate.ServiceReference2.IAffiliateService>, ClientAffiliate.ServiceReference2.IAffiliateService {
        
        public AffiliateServiceClient() {
        }
        
        public AffiliateServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AffiliateServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AffiliateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AffiliateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckIn(string login, string password) {
            return base.Channel.CheckIn(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> CheckInAsync(string login, string password) {
            return base.Channel.CheckInAsync(login, password);
        }
        
        public ClientAffiliate.ServiceReference2.vAffiliate GetAffiliateById(int lectId) {
            return base.Channel.GetAffiliateById(lectId);
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vAffiliate> GetAffiliateByIdAsync(int lectId) {
            return base.Channel.GetAffiliateByIdAsync(lectId);
        }
        
        public ClientAffiliate.ServiceReference2.vAffiliate GetAffiliateByName(string FirstName, string lastName) {
            return base.Channel.GetAffiliateByName(FirstName, lastName);
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vAffiliate> GetAffiliateByNameAsync(string FirstName, string lastName) {
            return base.Channel.GetAffiliateByNameAsync(FirstName, lastName);
        }
        
        public ClientAffiliate.ServiceReference2.vEmpruntDetail[] GetEmpruntsByAffiliate(int lectId) {
            return base.Channel.GetEmpruntsByAffiliate(lectId);
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vEmpruntDetail[]> GetEmpruntsByAffiliateAsync(int lectId) {
            return base.Channel.GetEmpruntsByAffiliateAsync(lectId);
        }
        
        public ClientAffiliate.ServiceReference2.vEmpruntDetail GetEmpruntByCode(string code) {
            return base.Channel.GetEmpruntByCode(code);
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vEmpruntDetail> GetEmpruntByCodeAsync(string code) {
            return base.Channel.GetEmpruntByCodeAsync(code);
        }
        
        public ClientAffiliate.ServiceReference2.vEmpruntDetail[] GetRetards(System.DateTime date, int libId) {
            return base.Channel.GetRetards(date, libId);
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vEmpruntDetail[]> GetRetardsAsync(System.DateTime date, int libId) {
            return base.Channel.GetRetardsAsync(date, libId);
        }
        
        public ClientAffiliate.ServiceReference2.vLibrary[] GetLibraries() {
            return base.Channel.GetLibraries();
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vLibrary[]> GetLibrariesAsync() {
            return base.Channel.GetLibrariesAsync();
        }
        
        public ClientAffiliate.ServiceReference2.vVolume[] GetAllVolumes() {
            return base.Channel.GetAllVolumes();
        }
        
        public System.Threading.Tasks.Task<ClientAffiliate.ServiceReference2.vVolume[]> GetAllVolumesAsync() {
            return base.Channel.GetAllVolumesAsync();
        }
    }
}
