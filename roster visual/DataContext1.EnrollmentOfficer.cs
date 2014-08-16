//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 16/08/2014 11:25:27
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
    /// There are no comments for roster_visual.EnrollmentOfficer in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.enrollment_officer")]
    public partial class EnrollmentOfficer : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private string _Text;
        #pragma warning restore 0649

        private EntitySet<Student> _Students;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
        #endregion

        public EnrollmentOfficer()
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
        /// There are no comments for Text in the schema.
        /// </summary>
        [Column(Name = @"`text`", Storage = "_Text", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                if (this._Text != value)
                {
                    this.OnTextChanging(value);
                    this.SendPropertyChanging();
                    this._Text = value;
                    this.SendPropertyChanged("Text");
                    this.OnTextChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="EnrollmentOfficer_Student", Storage="_Students", ThisKey="Id", OtherKey="EOId", DeleteRule="RESTRICT")]
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
            entity.EnrollmentOfficer = this;
        }
    
        private void detach_Students(Student entity)
        {
            this.SendPropertyChanging("Students");
            entity.EnrollmentOfficer = null;
        }
    }

}
