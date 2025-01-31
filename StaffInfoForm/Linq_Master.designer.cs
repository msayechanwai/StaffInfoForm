﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StaffInfoForm
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SSBS")]
	public partial class Linq_MasterDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStaff(Staff instance);
    partial void UpdateStaff(Staff instance);
    partial void DeleteStaff(Staff instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public Linq_MasterDataContext() : 
				base(global::StaffInfoForm.Properties.Settings.Default.SSBSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Linq_MasterDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Linq_MasterDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Linq_MasterDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Linq_MasterDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Staff> Staffs
		{
			get
			{
				return this.GetTable<Staff>();
			}
		}
		
		public System.Data.Linq.Table<StaffView> StaffViews
		{
			get
			{
				return this.GetTable<StaffView>();
			}
		}
		
		public System.Data.Linq.Table<CustomerView> CustomerViews
		{
			get
			{
				return this.GetTable<CustomerView>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<UserView> UserViews
		{
			get
			{
				return this.GetTable<UserView>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Staff")]
	public partial class Staff : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _StaffID;
		
		private string _StaffName;
		
		private string _NRCNo;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _Age;
		
		private string _City;
		
		private string _Address;
		
		private string _Gender;
		
		private System.Nullable<bool> _HTML;
		
		private System.Nullable<bool> _CSS;
		
		private System.Nullable<bool> _DotNet;
		
		private System.Nullable<bool> _JQuery;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnStaffIDChanging(string value);
    partial void OnStaffIDChanged();
    partial void OnStaffNameChanging(string value);
    partial void OnStaffNameChanged();
    partial void OnNRCNoChanging(string value);
    partial void OnNRCNoChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnHTMLChanging(System.Nullable<bool> value);
    partial void OnHTMLChanged();
    partial void OnCSSChanging(System.Nullable<bool> value);
    partial void OnCSSChanged();
    partial void OnDotNetChanging(System.Nullable<bool> value);
    partial void OnDotNetChanged();
    partial void OnJQueryChanging(System.Nullable<bool> value);
    partial void OnJQueryChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedOnChanged();
    #endregion
		
		public Staff()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string StaffID
		{
			get
			{
				return this._StaffID;
			}
			set
			{
				if ((this._StaffID != value))
				{
					this.OnStaffIDChanging(value);
					this.SendPropertyChanging();
					this._StaffID = value;
					this.SendPropertyChanged("StaffID");
					this.OnStaffIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffName", DbType="NVarChar(50)")]
		public string StaffName
		{
			get
			{
				return this._StaffName;
			}
			set
			{
				if ((this._StaffName != value))
				{
					this.OnStaffNameChanging(value);
					this.SendPropertyChanging();
					this._StaffName = value;
					this.SendPropertyChanged("StaffName");
					this.OnStaffNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NRCNo", DbType="NVarChar(50)")]
		public string NRCNo
		{
			get
			{
				return this._NRCNo;
			}
			set
			{
				if ((this._NRCNo != value))
				{
					this.OnNRCNoChanging(value);
					this.SendPropertyChanging();
					this._NRCNo = value;
					this.SendPropertyChanged("NRCNo");
					this.OnNRCNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="DateTime")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HTML", DbType="Bit")]
		public System.Nullable<bool> HTML
		{
			get
			{
				return this._HTML;
			}
			set
			{
				if ((this._HTML != value))
				{
					this.OnHTMLChanging(value);
					this.SendPropertyChanging();
					this._HTML = value;
					this.SendPropertyChanged("HTML");
					this.OnHTMLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSS", DbType="Bit")]
		public System.Nullable<bool> CSS
		{
			get
			{
				return this._CSS;
			}
			set
			{
				if ((this._CSS != value))
				{
					this.OnCSSChanging(value);
					this.SendPropertyChanging();
					this._CSS = value;
					this.SendPropertyChanged("CSS");
					this.OnCSSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DotNet", DbType="Bit")]
		public System.Nullable<bool> DotNet
		{
			get
			{
				return this._DotNet;
			}
			set
			{
				if ((this._DotNet != value))
				{
					this.OnDotNetChanging(value);
					this.SendPropertyChanging();
					this._DotNet = value;
					this.SendPropertyChanged("DotNet");
					this.OnDotNetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JQuery", DbType="Bit")]
		public System.Nullable<bool> JQuery
		{
			get
			{
				return this._JQuery;
			}
			set
			{
				if ((this._JQuery != value))
				{
					this.OnJQueryChanging(value);
					this.SendPropertyChanging();
					this._JQuery = value;
					this.SendPropertyChanged("JQuery");
					this.OnJQueryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StaffView")]
	public partial class StaffView
	{
		
		private string _StaffID;
		
		private string _StaffName;
		
		private string _NRCNo;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _Age;
		
		private string _City;
		
		private string _Address;
		
		private string _Gender;
		
		private System.Nullable<bool> _HTML;
		
		private System.Nullable<bool> _CSS;
		
		private System.Nullable<bool> _DotNet;
		
		private System.Nullable<bool> _JQuery;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
		public StaffView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string StaffID
		{
			get
			{
				return this._StaffID;
			}
			set
			{
				if ((this._StaffID != value))
				{
					this._StaffID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaffName", DbType="NVarChar(50)")]
		public string StaffName
		{
			get
			{
				return this._StaffName;
			}
			set
			{
				if ((this._StaffName != value))
				{
					this._StaffName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NRCNo", DbType="NVarChar(50)")]
		public string NRCNo
		{
			get
			{
				return this._NRCNo;
			}
			set
			{
				if ((this._NRCNo != value))
				{
					this._NRCNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="DateTime")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this._DOB = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this._Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HTML", DbType="Bit")]
		public System.Nullable<bool> HTML
		{
			get
			{
				return this._HTML;
			}
			set
			{
				if ((this._HTML != value))
				{
					this._HTML = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSS", DbType="Bit")]
		public System.Nullable<bool> CSS
		{
			get
			{
				return this._CSS;
			}
			set
			{
				if ((this._CSS != value))
				{
					this._CSS = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DotNet", DbType="Bit")]
		public System.Nullable<bool> DotNet
		{
			get
			{
				return this._DotNet;
			}
			set
			{
				if ((this._DotNet != value))
				{
					this._DotNet = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JQuery", DbType="Bit")]
		public System.Nullable<bool> JQuery
		{
			get
			{
				return this._JQuery;
			}
			set
			{
				if ((this._JQuery != value))
				{
					this._JQuery = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this._ModifiedOn = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerView")]
	public partial class CustomerView
	{
		
		private string _CustomerID;
		
		private string _CustomerName;
		
		private string _Email;
		
		private string _PhoneNo;
		
		private string _Address;
		
		private string _City;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
		public CustomerView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this._CustomerID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="NVarChar(50)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this._CustomerName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNo", DbType="NVarChar(50)")]
		public string PhoneNo
		{
			get
			{
				return this._PhoneNo;
			}
			set
			{
				if ((this._PhoneNo != value))
				{
					this._PhoneNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this._ModifiedOn = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CustomerID;
		
		private string _CustomerName;
		
		private string _Email;
		
		private string _PhoneNo;
		
		private string _Address;
		
		private string _City;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneNoChanging(string value);
    partial void OnPhoneNoChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedOnChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="NVarChar(50)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNo", DbType="NVarChar(50)")]
		public string PhoneNo
		{
			get
			{
				return this._PhoneNo;
			}
			set
			{
				if ((this._PhoneNo != value))
				{
					this.OnPhoneNoChanging(value);
					this.SendPropertyChanging();
					this._PhoneNo = value;
					this.SendPropertyChanged("PhoneNo");
					this.OnPhoneNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _UserCode;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnUserCodeChanging(string value);
    partial void OnUserCodeChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnCreatedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedOnChanged();
    partial void OnModifiedOnChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedOnChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="NVarChar(50)")]
		public string UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this.OnUserCodeChanging(value);
					this.SendPropertyChanging();
					this._UserCode = value;
					this.SendPropertyChanged("UserCode");
					this.OnUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(150)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this.OnModifiedOnChanging(value);
					this.SendPropertyChanging();
					this._ModifiedOn = value;
					this.SendPropertyChanged("ModifiedOn");
					this.OnModifiedOnChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserView")]
	public partial class UserView
	{
		
		private string _UserID;
		
		private string _UserCode;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<System.DateTime> _CreatedOn;
		
		private System.Nullable<System.DateTime> _ModifiedOn;
		
		public UserView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this._UserID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="NVarChar(50)")]
		public string UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this._UserCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(150)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this._CreatedOn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedOn", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this._ModifiedOn;
			}
			set
			{
				if ((this._ModifiedOn != value))
				{
					this._ModifiedOn = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
