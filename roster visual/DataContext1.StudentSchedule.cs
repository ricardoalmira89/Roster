//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 20/08/2014 15:16:49
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
    /// There are no comments for roster_visual.StudentSchedule in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.student_schedule")]
    public partial class StudentSchedule : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private int _StudentId;

        private int _ScheduleId;

        private int _ProgramId;
        #pragma warning restore 0649

        private EntityRef<Program> _Program;

        private EntityRef<Schedule> _Schedule;

        private EntityRef<Student> _Student;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnStudentIdChanging(int value);
        partial void OnStudentIdChanged();
        partial void OnScheduleIdChanging(int value);
        partial void OnScheduleIdChanged();
        partial void OnProgramIdChanging(int value);
        partial void OnProgramIdChanged();
        #endregion

        public StudentSchedule()
        {
            this._Program  = default(EntityRef<Program>);
            this._Schedule  = default(EntityRef<Schedule>);
            this._Student  = default(EntityRef<Student>);
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
        /// There are no comments for StudentId in the schema.
        /// </summary>
        [Column(Name = @"student_id", Storage = "_StudentId", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int StudentId
        {
            get
            {
                return this._StudentId;
            }
            set
            {
                if (this._StudentId != value)
                {
                    if (this._Student.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnStudentIdChanging(value);
                    this.SendPropertyChanging();
                    this._StudentId = value;
                    this.SendPropertyChanged("StudentId");
                    this.OnStudentIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ScheduleId in the schema.
        /// </summary>
        [Column(Name = @"schedule_id", Storage = "_ScheduleId", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int ScheduleId
        {
            get
            {
                return this._ScheduleId;
            }
            set
            {
                if (this._ScheduleId != value)
                {
                    if (this._Schedule.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnScheduleIdChanging(value);
                    this.SendPropertyChanging();
                    this._ScheduleId = value;
                    this.SendPropertyChanged("ScheduleId");
                    this.OnScheduleIdChanged();
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
        [Devart.Data.Linq.Mapping.Association(Name="Program_StudentSchedule", Storage="_Program", ThisKey="ProgramId", OtherKey="Id", IsForeignKey=true)]
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
                        previousValue.StudentSchedules.Remove(this);
                    }
                    this._Program.Entity = value;
                    if (value != null)
                    {
                        this._ProgramId = value.Id;
                        value.StudentSchedules.Add(this);
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
        /// There are no comments for Schedule in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Schedule_StudentSchedule", Storage="_Schedule", ThisKey="ScheduleId", OtherKey="Id", IsForeignKey=true)]
        public Schedule Schedule
        {
            get
            {
                return this._Schedule.Entity;
            }
            set
            {
                Schedule previousValue = this._Schedule.Entity;
                if ((previousValue != value) || (this._Schedule.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging();
                    if (previousValue != null)
                    {
                        this._Schedule.Entity = null;
                        previousValue.StudentSchedules.Remove(this);
                    }
                    this._Schedule.Entity = value;
                    if (value != null)
                    {
                        this._ScheduleId = value.Id;
                        value.StudentSchedules.Add(this);
                    }
                    else
                    {
                        this._ScheduleId = default(int);
                    }
                    this.SendPropertyChanged("Schedule");
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Student in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Student_StudentSchedule", Storage="_Student", ThisKey="StudentId", OtherKey="Id", IsForeignKey=true)]
        public Student Student
        {
            get
            {
                return this._Student.Entity;
            }
            set
            {
                Student previousValue = this._Student.Entity;
                if ((previousValue != value) || (this._Student.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging();
                    if (previousValue != null)
                    {
                        this._Student.Entity = null;
                        previousValue.StudentSchedules.Remove(this);
                    }
                    this._Student.Entity = value;
                    if (value != null)
                    {
                        this._StudentId = value.Id;
                        value.StudentSchedules.Add(this);
                    }
                    else
                    {
                        this._StudentId = default(int);
                    }
                    this.SendPropertyChanged("Student");
                }
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
    }

}
