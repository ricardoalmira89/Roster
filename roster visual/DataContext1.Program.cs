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
    /// There are no comments for roster_visual.Program in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.program")]
    public partial class Program : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private string _Name;

        private string _Slug;
        #pragma warning restore 0649

        private EntitySet<Schedule> _Schedules;

        private EntitySet<StudentProgram> _StudentPrograms;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnSlugChanging(string value);
        partial void OnSlugChanged();
        #endregion

        public Program()
        {
            this._Schedules = new EntitySet<Schedule>(new Action<Schedule>(this.attach_Schedules), new Action<Schedule>(this.detach_Schedules));
            this._StudentPrograms = new EntitySet<StudentProgram>(new Action<StudentProgram>(this.attach_StudentPrograms), new Action<StudentProgram>(this.detach_StudentPrograms));
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
        /// There are no comments for Name in the schema.
        /// </summary>
        [Column(Name = @"name", Storage = "_Name", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if (this._Name != value)
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Slug in the schema.
        /// </summary>
        [Column(Name = @"slug", Storage = "_Slug", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Slug
        {
            get
            {
                return this._Slug;
            }
            set
            {
                if (this._Slug != value)
                {
                    this.OnSlugChanging(value);
                    this.SendPropertyChanging();
                    this._Slug = value;
                    this.SendPropertyChanged("Slug");
                    this.OnSlugChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Schedules in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Program_Schedule", Storage="_Schedules", ThisKey="Id", OtherKey="ProgramId", DeleteRule="RESTRICT")]
        public EntitySet<Schedule> Schedules
        {
            get
            {
                return this._Schedules;
            }
            set
            {
                this._Schedules.Assign(value);
            }
        }

    
        /// <summary>
        /// There are no comments for StudentPrograms in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Program_StudentProgram", Storage="_StudentPrograms", ThisKey="Id", OtherKey="ProgramId", DeleteRule="RESTRICT")]
        public EntitySet<StudentProgram> StudentPrograms
        {
            get
            {
                return this._StudentPrograms;
            }
            set
            {
                this._StudentPrograms.Assign(value);
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

        private void attach_Schedules(Schedule entity)
        {
            this.SendPropertyChanging("Schedules");
            entity.Program = this;
        }
    
        private void detach_Schedules(Schedule entity)
        {
            this.SendPropertyChanging("Schedules");
            entity.Program = null;
        }

        private void attach_StudentPrograms(StudentProgram entity)
        {
            this.SendPropertyChanging("StudentPrograms");
            entity.Program = this;
        }
    
        private void detach_StudentPrograms(StudentProgram entity)
        {
            this.SendPropertyChanging("StudentPrograms");
            entity.Program = null;
        }
    }

}
