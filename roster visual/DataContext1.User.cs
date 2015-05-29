//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 04/11/2014 14:25:19
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
    /// There are no comments for roster_visual.User in the schema.
    /// </summary>
    [Table(Name = @"roster_mysql.user")]
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _Id;

        private string _Username;

        private string _Password;

        private string _FullName;

        private int _RoleId;
        #pragma warning restore 0649

        private EntityRef<Role> _Role;
    
        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        partial void OnFullNameChanging(string value);
        partial void OnFullNameChanged();
        partial void OnRoleIdChanging(int value);
        partial void OnRoleIdChanged();
        #endregion

        public User()
        {
            this._Role  = default(EntityRef<Role>);
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
        /// There are no comments for Username in the schema.
        /// </summary>
        [Column(Name = @"username", Storage = "_Username", CanBeNull = false, DbType = "VARCHAR(255) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                if (this._Username != value)
                {
                    this.OnUsernameChanging(value);
                    this.SendPropertyChanging();
                    this._Username = value;
                    this.SendPropertyChanged("Username");
                    this.OnUsernameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        [Column(Name = @"`password`", Storage = "_Password", CanBeNull = false, DbType = "VARCHAR(255) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if (this._Password != value)
                {
                    this.OnPasswordChanging(value);
                    this.SendPropertyChanging();
                    this._Password = value;
                    this.SendPropertyChanged("Password");
                    this.OnPasswordChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FullName in the schema.
        /// </summary>
        [Column(Name = @"full_name", Storage = "_FullName", CanBeNull = false, DbType = "VARCHAR(255) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string FullName
        {
            get
            {
                return this._FullName;
            }
            set
            {
                if (this._FullName != value)
                {
                    this.OnFullNameChanging(value);
                    this.SendPropertyChanging();
                    this._FullName = value;
                    this.SendPropertyChanged("FullName");
                    this.OnFullNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for RoleId in the schema.
        /// </summary>
        [Column(Name = @"role_id", Storage = "_RoleId", CanBeNull = false, DbType = "INT(11) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public int RoleId
        {
            get
            {
                return this._RoleId;
            }
            set
            {
                if (this._RoleId != value)
                {
                    if (this._Role.HasLoadedOrAssignedValue)
                    {
                        throw new ForeignKeyReferenceAlreadyHasValueException();
                    }

                    this.OnRoleIdChanging(value);
                    this.SendPropertyChanging();
                    this._RoleId = value;
                    this.SendPropertyChanged("RoleId");
                    this.OnRoleIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Role in the schema.
        /// </summary>
        [Devart.Data.Linq.Mapping.Association(Name="Role_User", Storage="_Role", ThisKey="RoleId", OtherKey="Id", IsForeignKey=true)]
        public Role Role
        {
            get
            {
                return this._Role.Entity;
            }
            set
            {
                Role previousValue = this._Role.Entity;
                if ((previousValue != value) || (this._Role.HasLoadedOrAssignedValue == false))
                {
                    this.SendPropertyChanging();
                    if (previousValue != null)
                    {
                        this._Role.Entity = null;
                        previousValue.Users.Remove(this);
                    }
                    this._Role.Entity = value;
                    if (value != null)
                    {
                        this._RoleId = value.Id;
                        value.Users.Add(this);
                    }
                    else
                    {
                        this._RoleId = default(int);
                    }
                    this.SendPropertyChanged("Role");
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
