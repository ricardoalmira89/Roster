//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 21/08/2014 14:14:35
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace roster_visual
{

    /// <summary>
    /// There are no comments for roster_visual.Graduated in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.graduated")]
    public partial class Graduated : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private System.Nullable<bool> _Licensed;

        private System.Nullable<bool> _Temporary;

        private string _EmploymentStatus;

        private string _CompanyName;

        private string _CompanyAddress;

        private string _CompanyCity;

        private string _CompanyState;

        private string _CompanyZip;

        private string _CompanyPhone;

        private System.Nullable<bool> _FullTime;

        private System.Nullable<System.DateTime> _DiplomaPrinted;

        private System.Nullable<System.DateTime> _StartWorking;

        private string _SupervisorPhone;

        private string _SupervisorName;

        private string _JobTitle;

        private string _EmployerAddress;
        #pragma warning restore 0649

        private EntitySet<Student> _Students;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnLicensedChanging(System.Nullable<bool> value);
        partial void OnLicensedChanged();
        partial void OnTemporaryChanging(System.Nullable<bool> value);
        partial void OnTemporaryChanged();
        partial void OnEmploymentStatusChanging(string value);
        partial void OnEmploymentStatusChanged();
        partial void OnCompanyNameChanging(string value);
        partial void OnCompanyNameChanged();
        partial void OnCompanyAddressChanging(string value);
        partial void OnCompanyAddressChanged();
        partial void OnCompanyCityChanging(string value);
        partial void OnCompanyCityChanged();
        partial void OnCompanyStateChanging(string value);
        partial void OnCompanyStateChanged();
        partial void OnCompanyZipChanging(string value);
        partial void OnCompanyZipChanged();
        partial void OnCompanyPhoneChanging(string value);
        partial void OnCompanyPhoneChanged();
        partial void OnFullTimeChanging(System.Nullable<bool> value);
        partial void OnFullTimeChanged();
        partial void OnDiplomaPrintedChanging(System.Nullable<System.DateTime> value);
        partial void OnDiplomaPrintedChanged();
        partial void OnStartWorkingChanging(System.Nullable<System.DateTime> value);
        partial void OnStartWorkingChanged();
        partial void OnSupervisorPhoneChanging(string value);
        partial void OnSupervisorPhoneChanged();
        partial void OnSupervisorNameChanging(string value);
        partial void OnSupervisorNameChanged();
        partial void OnJobTitleChanging(string value);
        partial void OnJobTitleChanged();
        partial void OnEmployerAddressChanging(string value);
        partial void OnEmployerAddressChanged();
        #endregion

        public Graduated()
        {
            this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [Column(Name = @"id", Storage = "_Id", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT(11) NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (this._Id != value)
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Licensed in the schema.
        /// </summary>
        [Column(Name = @"licensed", Storage = "_Licensed", DbType = "BIT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<bool> Licensed
        {
            get
            {
                return this._Licensed;
            }
            set
            {
                if (this._Licensed != value)
                {
                    this.OnLicensedChanging(value);
                    this.SendPropertyChanging();
                    this._Licensed = value;
                    this.SendPropertyChanged("Licensed");
                    this.OnLicensedChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Temporary in the schema.
        /// </summary>
        [Column(Name = @"temporary", Storage = "_Temporary", DbType = "BIT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<bool> Temporary
        {
            get
            {
                return this._Temporary;
            }
            set
            {
                if (this._Temporary != value)
                {
                    this.OnTemporaryChanging(value);
                    this.SendPropertyChanging();
                    this._Temporary = value;
                    this.SendPropertyChanged("Temporary");
                    this.OnTemporaryChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for EmploymentStatus in the schema.
        /// </summary>
        [Column(Name = @"employment_status", Storage = "_EmploymentStatus", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string EmploymentStatus
        {
            get
            {
                return this._EmploymentStatus;
            }
            set
            {
                if (this._EmploymentStatus != value)
                {
                    this.OnEmploymentStatusChanging(value);
                    this.SendPropertyChanging();
                    this._EmploymentStatus = value;
                    this.SendPropertyChanged("EmploymentStatus");
                    this.OnEmploymentStatusChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyName in the schema.
        /// </summary>
        [Column(Name = @"company_name", Storage = "_CompanyName", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                if (this._CompanyName != value)
                {
                    this.OnCompanyNameChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyName = value;
                    this.SendPropertyChanged("CompanyName");
                    this.OnCompanyNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyAddress in the schema.
        /// </summary>
        [Column(Name = @"company_address", Storage = "_CompanyAddress", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CompanyAddress
        {
            get
            {
                return this._CompanyAddress;
            }
            set
            {
                if (this._CompanyAddress != value)
                {
                    this.OnCompanyAddressChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyAddress = value;
                    this.SendPropertyChanged("CompanyAddress");
                    this.OnCompanyAddressChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyCity in the schema.
        /// </summary>
        [Column(Name = @"company_city", Storage = "_CompanyCity", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CompanyCity
        {
            get
            {
                return this._CompanyCity;
            }
            set
            {
                if (this._CompanyCity != value)
                {
                    this.OnCompanyCityChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyCity = value;
                    this.SendPropertyChanged("CompanyCity");
                    this.OnCompanyCityChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyState in the schema.
        /// </summary>
        [Column(Name = @"company_state", Storage = "_CompanyState", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CompanyState
        {
            get
            {
                return this._CompanyState;
            }
            set
            {
                if (this._CompanyState != value)
                {
                    this.OnCompanyStateChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyState = value;
                    this.SendPropertyChanged("CompanyState");
                    this.OnCompanyStateChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyZip in the schema.
        /// </summary>
        [Column(Name = @"company_zip", Storage = "_CompanyZip", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CompanyZip
        {
            get
            {
                return this._CompanyZip;
            }
            set
            {
                if (this._CompanyZip != value)
                {
                    this.OnCompanyZipChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyZip = value;
                    this.SendPropertyChanged("CompanyZip");
                    this.OnCompanyZipChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CompanyPhone in the schema.
        /// </summary>
        [Column(Name = @"company_phone", Storage = "_CompanyPhone", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CompanyPhone
        {
            get
            {
                return this._CompanyPhone;
            }
            set
            {
                if (this._CompanyPhone != value)
                {
                    this.OnCompanyPhoneChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyPhone = value;
                    this.SendPropertyChanged("CompanyPhone");
                    this.OnCompanyPhoneChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FullTime in the schema.
        /// </summary>
        [Column(Name = @"full_time", Storage = "_FullTime", DbType = "BIT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<bool> FullTime
        {
            get
            {
                return this._FullTime;
            }
            set
            {
                if (this._FullTime != value)
                {
                    this.OnFullTimeChanging(value);
                    this.SendPropertyChanging();
                    this._FullTime = value;
                    this.SendPropertyChanged("FullTime");
                    this.OnFullTimeChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for DiplomaPrinted in the schema.
        /// </summary>
        [Column(Name = @"diploma_printed", Storage = "_DiplomaPrinted", DbType = "DATE NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> DiplomaPrinted
        {
            get
            {
                return this._DiplomaPrinted;
            }
            set
            {
                if (this._DiplomaPrinted != value)
                {
                    this.OnDiplomaPrintedChanging(value);
                    this.SendPropertyChanging();
                    this._DiplomaPrinted = value;
                    this.SendPropertyChanged("DiplomaPrinted");
                    this.OnDiplomaPrintedChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for StartWorking in the schema.
        /// </summary>
        [Column(Name = @"start_working", Storage = "_StartWorking", DbType = "DATE NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> StartWorking
        {
            get
            {
                return this._StartWorking;
            }
            set
            {
                if (this._StartWorking != value)
                {
                    this.OnStartWorkingChanging(value);
                    this.SendPropertyChanging();
                    this._StartWorking = value;
                    this.SendPropertyChanged("StartWorking");
                    this.OnStartWorkingChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SupervisorPhone in the schema.
        /// </summary>
        [Column(Name = @"supervisor_phone", Storage = "_SupervisorPhone", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string SupervisorPhone
        {
            get
            {
                return this._SupervisorPhone;
            }
            set
            {
                if (this._SupervisorPhone != value)
                {
                    this.OnSupervisorPhoneChanging(value);
                    this.SendPropertyChanging();
                    this._SupervisorPhone = value;
                    this.SendPropertyChanged("SupervisorPhone");
                    this.OnSupervisorPhoneChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for SupervisorName in the schema.
        /// </summary>
        [Column(Name = @"supervisor_name", Storage = "_SupervisorName", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string SupervisorName
        {
            get
            {
                return this._SupervisorName;
            }
            set
            {
                if (this._SupervisorName != value)
                {
                    this.OnSupervisorNameChanging(value);
                    this.SendPropertyChanging();
                    this._SupervisorName = value;
                    this.SendPropertyChanged("SupervisorName");
                    this.OnSupervisorNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for JobTitle in the schema.
        /// </summary>
        [Column(Name = @"job_title", Storage = "_JobTitle", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string JobTitle
        {
            get
            {
                return this._JobTitle;
            }
            set
            {
                if (this._JobTitle != value)
                {
                    this.OnJobTitleChanging(value);
                    this.SendPropertyChanging();
                    this._JobTitle = value;
                    this.SendPropertyChanged("JobTitle");
                    this.OnJobTitleChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for EmployerAddress in the schema.
        /// </summary>
        [Column(Name = @"employer_address", Storage = "_EmployerAddress", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string EmployerAddress
        {
            get
            {
                return this._EmployerAddress;
            }
            set
            {
                if (this._EmployerAddress != value)
                {
                    this.OnEmployerAddressChanging(value);
                    this.SendPropertyChanging();
                    this._EmployerAddress = value;
                    this.SendPropertyChanged("EmployerAddress");
                    this.OnEmployerAddressChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Graduated_Student", Storage="_Students", ThisKey="Id", OtherKey="GraduatedId", DeleteRule="CASCADE")]
        public EntitySet<Student> Students
        {
            get
            {
                return this._Students;
            }
            set
            {
                this._Students.Assign(value);
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {    
		        var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {    
		        var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void attach_Students(Student entity)
        {
            this.SendPropertyChanging("Students");
            entity.Graduated = this;
        }
    
        private void detach_Students(Student entity)
        {
            this.SendPropertyChanging("Students");
            entity.Graduated = null;
        }
    }

}
