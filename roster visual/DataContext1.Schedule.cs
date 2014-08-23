//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 23/08/2014 10:51:58
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
    /// There are no comments for roster_visual.Schedule in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.schedule")]
    public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private string _Name;

        private string _Slug;

        private string _Languages;

        private int _ProgramId;
        #pragma warning restore 0649

        private EntityRef<Program> _Program;

        private EntitySet<StudentSchedule> _StudentSchedules;
    
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
        partial void OnLanguagesChanging(string value);
        partial void OnLanguagesChanged();
        partial void OnProgramIdChanging(int value);
        partial void OnProgramIdChanged();
        #endregion

        public Schedule()
        {
            this._Program  = default(EntityRef<Program>);
            this._StudentSchedules = new EntitySet<StudentSchedule>(new Action<StudentSchedule>(this.attach_StudentSchedules), new Action<StudentSchedule>(this.detach_StudentSchedules));
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
        [Column(Name = @"slug", Storage = "_Slug", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
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
        /// There are no comments for Languages in the schema.
        /// </summary>
        [Column(Name = @"languages", Storage = "_Languages", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Languages
        {
            get
            {
                return this._Languages;
            }
            set
            {
                if (this._Languages != value)
                {
                    this.OnLanguagesChanging(value);
                    this.SendPropertyChanging();
                    this._Languages = value;
                    this.SendPropertyChanged("Languages");
                    this.OnLanguagesChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ProgramId in the schema.
        /// </summary>
        [Column(Name = @"program_id", Storage = "_ProgramId", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int ProgramId
        {
            get
            {
                return this._ProgramId;
            }
            set
            {
                if (this._ProgramId != value)
                {
                    if (this._Program.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnProgramIdChanging(value);
                    this.SendPropertyChanging();
                    this._ProgramId = value;
                    this.SendPropertyChanged("ProgramId");
                    this.OnProgramIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Program in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Program_Schedule", Storage="_Program", ThisKey="ProgramId", OtherKey="Id", IsForeignKey=true)]
        public Program Program
        {
            get
            {
                return this._Program.Entity;
            }
            set
            {
                Program previousValue = this._Program.Entity;
                if ((previousValue != value) || (this._Program.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging();
                    if (previousValue != null)
                    {
                        this._Program.Entity = null;
                        previousValue.Schedules.Remove(this);
                    }
                    this._Program.Entity = value;
                    if (value != null)
                    {
                        this._ProgramId = value.Id;
                        value.Schedules.Add(this);
                    }
                    else
                    {
                        this._ProgramId = default(int);
                    }
                    this.SendPropertyChanged("Program");
                }
            }
        }

    
        /// <summary>
        /// There are no comments for StudentSchedules in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Schedule_StudentSchedule", Storage="_StudentSchedules", ThisKey="Id", OtherKey="ScheduleId", DeleteRule="RESTRICT")]
        public EntitySet<StudentSchedule> StudentSchedules
        {
            get
            {
                return this._StudentSchedules;
            }
            set
            {
                this._StudentSchedules.Assign(value);
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

        private void attach_StudentSchedules(StudentSchedule entity)
        {
            this.SendPropertyChanging("StudentSchedules");
            entity.Schedule = this;
        }
    
        private void detach_StudentSchedules(StudentSchedule entity)
        {
            this.SendPropertyChanging("StudentSchedules");
            entity.Schedule = null;
        }
    }

}
