//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 11/08/2014 14:38:22
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
    /// There are no comments for roster_visual.DropInfo in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.drop_info")]
    public partial class DropInfo : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private System.Nullable<bool> _Refund;

        private System.Nullable<int> _Amount;

        private System.Nullable<System.DateTime> _Date;

        private string _Check;

        private System.Nullable<bool> _Paid;
        #pragma warning restore 0649

        private EntitySet<Student> _Students;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnRefundChanging(System.Nullable<bool> value);
        partial void OnRefundChanged();
        partial void OnAmountChanging(System.Nullable<int> value);
        partial void OnAmountChanged();
        partial void OnDateChanging(System.Nullable<System.DateTime> value);
        partial void OnDateChanged();
        partial void OnCheckChanging(string value);
        partial void OnCheckChanged();
        partial void OnPaidChanging(System.Nullable<bool> value);
        partial void OnPaidChanged();
        #endregion

        public DropInfo()
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
        /// There are no comments for Refund in the schema.
        /// </summary>
        [Column(Name = @"refund", Storage = "_Refund", DbType = "BIT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<bool> Refund
        {
            get
            {
                return this._Refund;
            }
            set
            {
                if (this._Refund != value)
                {
                    this.OnRefundChanging(value);
                    this.SendPropertyChanging();
                    this._Refund = value;
                    this.SendPropertyChanged("Refund");
                    this.OnRefundChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Amount in the schema.
        /// </summary>
        [Column(Name = @"amount", Storage = "_Amount", DbType = "INT(11) NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<int> Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                if (this._Amount != value)
                {
                    this.OnAmountChanging(value);
                    this.SendPropertyChanging();
                    this._Amount = value;
                    this.SendPropertyChanged("Amount");
                    this.OnAmountChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Date in the schema.
        /// </summary>
        [Column(Name = @"`date`", Storage = "_Date", DbType = "DATETIME NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                if (this._Date != value)
                {
                    this.OnDateChanging(value);
                    this.SendPropertyChanging();
                    this._Date = value;
                    this.SendPropertyChanged("Date");
                    this.OnDateChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Check in the schema.
        /// </summary>
        [Column(Name = @"`check`", Storage = "_Check", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Check
        {
            get
            {
                return this._Check;
            }
            set
            {
                if (this._Check != value)
                {
                    this.OnCheckChanging(value);
                    this.SendPropertyChanging();
                    this._Check = value;
                    this.SendPropertyChanged("Check");
                    this.OnCheckChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Paid in the schema.
        /// </summary>
        [Column(Name = @"paid", Storage = "_Paid", DbType = "BIT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.Nullable<bool> Paid
        {
            get
            {
                return this._Paid;
            }
            set
            {
                if (this._Paid != value)
                {
                    this.OnPaidChanging(value);
                    this.SendPropertyChanging();
                    this._Paid = value;
                    this.SendPropertyChanged("Paid");
                    this.OnPaidChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="DropInfo_Student", Storage="_Students", ThisKey="Id", OtherKey="DropinfoId", DeleteRule="CASCADE")]
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
            entity.DropInfo = this;
        }
    
        private void detach_Students(Student entity)
        {
            this.SendPropertyChanging("Students");
            entity.DropInfo = null;
        }
    }

}
