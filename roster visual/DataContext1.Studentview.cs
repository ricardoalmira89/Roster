//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 07/09/2014 15:08:54
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
    /// VIEW
    /// </summary>
    [Table(Name = @"roster_mysql.studentview")]
    public partial class Studentview
    {
        #pragma warning disable 0649

        private int _ScheduleId;

        private string _Fullname;

        private string _Cv;

        private string _CvClear;

        private string _Picture;

        private string _ProgramScheduleName;

        private string _ProgramScheduleSlug;

        private string _Languages;

        private int _Id;

        private string _LastName;

        private string _FirstName;

        private System.DateTime _StartDate;

        private string _CellPhone;

        private string _ProgramName;

        private string _ProgramSlug;

        private string _ScheduleName;

        private string _ScheduleSlug;

        private int _Programid;

        private int _Scheduleid;

        private string _EO;
        #pragma warning restore 0649
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnScheduleIdChanging(int value);
        partial void OnScheduleIdChanged();
        partial void OnFullnameChanging(string value);
        partial void OnFullnameChanged();
        partial void OnCvChanging(string value);
        partial void OnCvChanged();
        partial void OnCvClearChanging(string value);
        partial void OnCvClearChanged();
        partial void OnPictureChanging(string value);
        partial void OnPictureChanged();
        partial void OnProgramScheduleNameChanging(string value);
        partial void OnProgramScheduleNameChanged();
        partial void OnProgramScheduleSlugChanging(string value);
        partial void OnProgramScheduleSlugChanged();
        partial void OnLanguagesChanging(string value);
        partial void OnLanguagesChanged();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnStartDateChanging(System.DateTime value);
        partial void OnStartDateChanged();
        partial void OnCellPhoneChanging(string value);
        partial void OnCellPhoneChanged();
        partial void OnProgramNameChanging(string value);
        partial void OnProgramNameChanged();
        partial void OnProgramSlugChanging(string value);
        partial void OnProgramSlugChanged();
        partial void OnScheduleNameChanging(string value);
        partial void OnScheduleNameChanged();
        partial void OnScheduleSlugChanging(string value);
        partial void OnScheduleSlugChanged();
        partial void OnProgramidChanging(int value);
        partial void OnProgramidChanged();
        partial void OnScheduleidChanging(int value);
        partial void OnScheduleidChanged();
        partial void OnEOChanging(string value);
        partial void OnEOChanged();
        #endregion

        public Studentview()
        {
            OnCreated();
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
                    this._ScheduleId = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Fullname in the schema.
        /// </summary>
        [Column(Name = @"fullname", Storage = "_Fullname", DbType = "MEDIUMTEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Fullname
        {
            get
            {
                return this._Fullname;
            }
            set
            {
                if (this._Fullname != value)
                {
                    this._Fullname = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Cv in the schema.
        /// </summary>
        [Column(Name = @"cv", Storage = "_Cv", DbType = "MEDIUMTEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Cv
        {
            get
            {
                return this._Cv;
            }
            set
            {
                if (this._Cv != value)
                {
                    this._Cv = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CvClear in the schema.
        /// </summary>
        [Column(Name = @"cv_clear", Storage = "_CvClear", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CvClear
        {
            get
            {
                return this._CvClear;
            }
            set
            {
                if (this._CvClear != value)
                {
                    this._CvClear = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Picture in the schema.
        /// </summary>
        [Column(Name = @"picture", Storage = "_Picture", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Picture
        {
            get
            {
                return this._Picture;
            }
            set
            {
                if (this._Picture != value)
                {
                    this._Picture = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ProgramScheduleName in the schema.
        /// </summary>
        [Column(Name = @"program_schedule_name", Storage = "_ProgramScheduleName", CanBeNull = false, DbType = "MEDIUMTEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string ProgramScheduleName
        {
            get
            {
                return this._ProgramScheduleName;
            }
            set
            {
                if (this._ProgramScheduleName != value)
                {
                    this._ProgramScheduleName = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ProgramScheduleSlug in the schema.
        /// </summary>
        [Column(Name = @"program_schedule_slug", Storage = "_ProgramScheduleSlug", DbType = "MEDIUMTEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string ProgramScheduleSlug
        {
            get
            {
                return this._ProgramScheduleSlug;
            }
            set
            {
                if (this._ProgramScheduleSlug != value)
                {
                    this._ProgramScheduleSlug = value;
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
                    this._Languages = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        [Column(Name = @"id", Storage = "_Id", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
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
                    this._Id = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for LastName in the schema.
        /// </summary>
        [Column(Name = @"last_name", Storage = "_LastName", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if (this._LastName != value)
                {
                    this._LastName = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        [Column(Name = @"first_name", Storage = "_FirstName", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if (this._FirstName != value)
                {
                    this._FirstName = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for StartDate in the schema.
        /// </summary>
        [Column(Name = @"start_date", Storage = "_StartDate", CanBeNull = false, DbType = "DATETIME NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public System.DateTime StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                if (this._StartDate != value)
                {
                    this._StartDate = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CellPhone in the schema.
        /// </summary>
        [Column(Name = @"cell_phone", Storage = "_CellPhone", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string CellPhone
        {
            get
            {
                return this._CellPhone;
            }
            set
            {
                if (this._CellPhone != value)
                {
                    this._CellPhone = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ProgramName in the schema.
        /// </summary>
        [Column(Name = @"program_name", Storage = "_ProgramName", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string ProgramName
        {
            get
            {
                return this._ProgramName;
            }
            set
            {
                if (this._ProgramName != value)
                {
                    this._ProgramName = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ProgramSlug in the schema.
        /// </summary>
        [Column(Name = @"program_slug", Storage = "_ProgramSlug", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string ProgramSlug
        {
            get
            {
                return this._ProgramSlug;
            }
            set
            {
                if (this._ProgramSlug != value)
                {
                    this._ProgramSlug = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ScheduleName in the schema.
        /// </summary>
        [Column(Name = @"schedule_name", Storage = "_ScheduleName", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string ScheduleName
        {
            get
            {
                return this._ScheduleName;
            }
            set
            {
                if (this._ScheduleName != value)
                {
                    this._ScheduleName = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for ScheduleSlug in the schema.
        /// </summary>
        [Column(Name = @"schedule_slug", Storage = "_ScheduleSlug", CanBeNull = false, DbType = "TEXT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string ScheduleSlug
        {
            get
            {
                return this._ScheduleSlug;
            }
            set
            {
                if (this._ScheduleSlug != value)
                {
                    this._ScheduleSlug = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Programid in the schema.
        /// </summary>
        [Column(Name = @"programid", Storage = "_Programid", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int Programid
        {
            get
            {
                return this._Programid;
            }
            set
            {
                if (this._Programid != value)
                {
                    this._Programid = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Scheduleid in the schema.
        /// </summary>
        [Column(Name = @"scheduleid", Storage = "_Scheduleid", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int Scheduleid
        {
            get
            {
                return this._Scheduleid;
            }
            set
            {
                if (this._Scheduleid != value)
                {
                    this._Scheduleid = value;
                }
            }
        }

    
        /// <summary>
        /// There are no comments for EO in the schema.
        /// </summary>
        [Column(Storage = "_EO", DbType = "TEXT NULL", UpdateCheck = UpdateCheck.Never)]
        public string EO
        {
            get
            {
                return this._EO;
            }
            set
            {
                if (this._EO != value)
                {
                    this._EO = value;
                }
            }
        }
    }

}
