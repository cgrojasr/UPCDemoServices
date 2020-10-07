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

namespace UPC.Demo.DA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="upcdemo")]
	public partial class dmUPCDemoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertorderBody(orderBody instance);
    partial void UpdateorderBody(orderBody instance);
    partial void DeleteorderBody(orderBody instance);
    partial void InsertorderHeader(orderHeader instance);
    partial void UpdateorderHeader(orderHeader instance);
    partial void DeleteorderHeader(orderHeader instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    partial void InsertuserApp(userApp instance);
    partial void UpdateuserApp(userApp instance);
    partial void DeleteuserApp(userApp instance);
    #endregion
		
		public dmUPCDemoDataContext() : 
				base(global::UPC.Demo.DA.Properties.Settings.Default.upcdemoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dmUPCDemoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dmUPCDemoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dmUPCDemoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dmUPCDemoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<orderBody> orderBodies
		{
			get
			{
				return this.GetTable<orderBody>();
			}
		}
		
		public System.Data.Linq.Table<orderHeader> orderHeaders
		{
			get
			{
				return this.GetTable<orderHeader>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
		
		public System.Data.Linq.Table<userApp> userApps
		{
			get
			{
				return this.GetTable<userApp>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orderBody")]
	public partial class orderBody : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idProduct;
		
		private int _idOrderHeader;
		
		private int _count;
		
		private decimal _price;
		
		private decimal _discount;
		
		private EntityRef<orderHeader> _orderHeader;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidProductChanging(int value);
    partial void OnidProductChanged();
    partial void OnidOrderHeaderChanging(int value);
    partial void OnidOrderHeaderChanged();
    partial void OncountChanging(int value);
    partial void OncountChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OndiscountChanging(decimal value);
    partial void OndiscountChanged();
    #endregion
		
		public orderBody()
		{
			this._orderHeader = default(EntityRef<orderHeader>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProduct", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idProduct
		{
			get
			{
				return this._idProduct;
			}
			set
			{
				if ((this._idProduct != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProductChanging(value);
					this.SendPropertyChanging();
					this._idProduct = value;
					this.SendPropertyChanged("idProduct");
					this.OnidProductChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idOrderHeader", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idOrderHeader
		{
			get
			{
				return this._idOrderHeader;
			}
			set
			{
				if ((this._idOrderHeader != value))
				{
					if (this._orderHeader.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidOrderHeaderChanging(value);
					this.SendPropertyChanging();
					this._idOrderHeader = value;
					this.SendPropertyChanged("idOrderHeader");
					this.OnidOrderHeaderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int NOT NULL")]
		public int count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(18,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_discount", DbType="Decimal(18,0) NOT NULL")]
		public decimal discount
		{
			get
			{
				return this._discount;
			}
			set
			{
				if ((this._discount != value))
				{
					this.OndiscountChanging(value);
					this.SendPropertyChanging();
					this._discount = value;
					this.SendPropertyChanged("discount");
					this.OndiscountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="orderHeader_orderBody", Storage="_orderHeader", ThisKey="idOrderHeader", OtherKey="id", IsForeignKey=true)]
		public orderHeader orderHeader
		{
			get
			{
				return this._orderHeader.Entity;
			}
			set
			{
				orderHeader previousValue = this._orderHeader.Entity;
				if (((previousValue != value) 
							|| (this._orderHeader.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._orderHeader.Entity = null;
						previousValue.orderBodies.Remove(this);
					}
					this._orderHeader.Entity = value;
					if ((value != null))
					{
						value.orderBodies.Add(this);
						this._idOrderHeader = value.id;
					}
					else
					{
						this._idOrderHeader = default(int);
					}
					this.SendPropertyChanged("orderHeader");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_orderBody", Storage="_product", ThisKey="idProduct", OtherKey="id", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.orderBodies.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.orderBodies.Add(this);
						this._idProduct = value.id;
					}
					else
					{
						this._idProduct = default(int);
					}
					this.SendPropertyChanged("product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orderHeader")]
	public partial class orderHeader : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _idUser;
		
		private string _orderNumber;
		
		private System.DateTime _date;
		
		private string _numberCard;
		
		private string _address;
		
		private System.Nullable<int> _idUserModify;
		
		private System.Nullable<System.DateTime> _dateModify;
		
		private int _idUserCreated;
		
		private System.DateTime _dateCreated;
		
		private string _commet;
		
		private EntitySet<orderBody> _orderBodies;
		
		private EntityRef<userApp> _userApp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnidUserChanging(int value);
    partial void OnidUserChanged();
    partial void OnorderNumberChanging(string value);
    partial void OnorderNumberChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnnumberCardChanging(string value);
    partial void OnnumberCardChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnidUserModifyChanging(System.Nullable<int> value);
    partial void OnidUserModifyChanged();
    partial void OndateModifyChanging(System.Nullable<System.DateTime> value);
    partial void OndateModifyChanged();
    partial void OnidUserCreatedChanging(int value);
    partial void OnidUserCreatedChanged();
    partial void OndateCreatedChanging(System.DateTime value);
    partial void OndateCreatedChanged();
    partial void OncommetChanging(string value);
    partial void OncommetChanged();
    #endregion
		
		public orderHeader()
		{
			this._orderBodies = new EntitySet<orderBody>(new Action<orderBody>(this.attach_orderBodies), new Action<orderBody>(this.detach_orderBodies));
			this._userApp = default(EntityRef<userApp>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUser", DbType="Int NOT NULL")]
		public int idUser
		{
			get
			{
				return this._idUser;
			}
			set
			{
				if ((this._idUser != value))
				{
					if (this._userApp.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUserChanging(value);
					this.SendPropertyChanging();
					this._idUser = value;
					this.SendPropertyChanged("idUser");
					this.OnidUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderNumber", DbType="VarChar(10)")]
		public string orderNumber
		{
			get
			{
				return this._orderNumber;
			}
			set
			{
				if ((this._orderNumber != value))
				{
					this.OnorderNumberChanging(value);
					this.SendPropertyChanging();
					this._orderNumber = value;
					this.SendPropertyChanged("orderNumber");
					this.OnorderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="Date NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numberCard", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string numberCard
		{
			get
			{
				return this._numberCard;
			}
			set
			{
				if ((this._numberCard != value))
				{
					this.OnnumberCardChanging(value);
					this.SendPropertyChanging();
					this._numberCard = value;
					this.SendPropertyChanged("numberCard");
					this.OnnumberCardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUserModify", DbType="Int")]
		public System.Nullable<int> idUserModify
		{
			get
			{
				return this._idUserModify;
			}
			set
			{
				if ((this._idUserModify != value))
				{
					this.OnidUserModifyChanging(value);
					this.SendPropertyChanging();
					this._idUserModify = value;
					this.SendPropertyChanged("idUserModify");
					this.OnidUserModifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateModify", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateModify
		{
			get
			{
				return this._dateModify;
			}
			set
			{
				if ((this._dateModify != value))
				{
					this.OndateModifyChanging(value);
					this.SendPropertyChanging();
					this._dateModify = value;
					this.SendPropertyChanged("dateModify");
					this.OndateModifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUserCreated", DbType="Int NOT NULL")]
		public int idUserCreated
		{
			get
			{
				return this._idUserCreated;
			}
			set
			{
				if ((this._idUserCreated != value))
				{
					this.OnidUserCreatedChanging(value);
					this.SendPropertyChanging();
					this._idUserCreated = value;
					this.SendPropertyChanged("idUserCreated");
					this.OnidUserCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime dateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				if ((this._dateCreated != value))
				{
					this.OndateCreatedChanging(value);
					this.SendPropertyChanging();
					this._dateCreated = value;
					this.SendPropertyChanged("dateCreated");
					this.OndateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_commet", DbType="VarChar(1000)")]
		public string commet
		{
			get
			{
				return this._commet;
			}
			set
			{
				if ((this._commet != value))
				{
					this.OncommetChanging(value);
					this.SendPropertyChanging();
					this._commet = value;
					this.SendPropertyChanged("commet");
					this.OncommetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="orderHeader_orderBody", Storage="_orderBodies", ThisKey="id", OtherKey="idOrderHeader")]
		public EntitySet<orderBody> orderBodies
		{
			get
			{
				return this._orderBodies;
			}
			set
			{
				this._orderBodies.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userApp_orderHeader", Storage="_userApp", ThisKey="idUser", OtherKey="id", IsForeignKey=true)]
		public userApp userApp
		{
			get
			{
				return this._userApp.Entity;
			}
			set
			{
				userApp previousValue = this._userApp.Entity;
				if (((previousValue != value) 
							|| (this._userApp.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._userApp.Entity = null;
						previousValue.orderHeaders.Remove(this);
					}
					this._userApp.Entity = value;
					if ((value != null))
					{
						value.orderHeaders.Add(this);
						this._idUser = value.id;
					}
					else
					{
						this._idUser = default(int);
					}
					this.SendPropertyChanged("userApp");
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
		
		private void attach_orderBodies(orderBody entity)
		{
			this.SendPropertyChanging();
			entity.orderHeader = this;
		}
		
		private void detach_orderBodies(orderBody entity)
		{
			this.SendPropertyChanging();
			entity.orderHeader = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _description;
		
		private string _title;
		
		private decimal _price;
		
		private string _image;
		
		private bool _active;
		
		private int _idUserCreated;
		
		private System.DateTime _dateCreated;
		
		private System.Nullable<int> _idUserModify;
		
		private System.Nullable<System.DateTime> _dateModify;
		
		private EntitySet<orderBody> _orderBodies;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnimageChanging(string value);
    partial void OnimageChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    partial void OnidUserCreatedChanging(int value);
    partial void OnidUserCreatedChanged();
    partial void OndateCreatedChanging(System.DateTime value);
    partial void OndateCreatedChanged();
    partial void OnidUserModifyChanging(System.Nullable<int> value);
    partial void OnidUserModifyChanged();
    partial void OndateModifyChanging(System.Nullable<System.DateTime> value);
    partial void OndateModifyChanged();
    #endregion
		
		public product()
		{
			this._orderBodies = new EntitySet<orderBody>(new Action<orderBody>(this.attach_orderBodies), new Action<orderBody>(this.detach_orderBodies));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(18,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="VarChar(1000)")]
		public string image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUserCreated", DbType="Int NOT NULL")]
		public int idUserCreated
		{
			get
			{
				return this._idUserCreated;
			}
			set
			{
				if ((this._idUserCreated != value))
				{
					this.OnidUserCreatedChanging(value);
					this.SendPropertyChanging();
					this._idUserCreated = value;
					this.SendPropertyChanged("idUserCreated");
					this.OnidUserCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime dateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				if ((this._dateCreated != value))
				{
					this.OndateCreatedChanging(value);
					this.SendPropertyChanging();
					this._dateCreated = value;
					this.SendPropertyChanged("dateCreated");
					this.OndateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUserModify", DbType="Int")]
		public System.Nullable<int> idUserModify
		{
			get
			{
				return this._idUserModify;
			}
			set
			{
				if ((this._idUserModify != value))
				{
					this.OnidUserModifyChanging(value);
					this.SendPropertyChanging();
					this._idUserModify = value;
					this.SendPropertyChanged("idUserModify");
					this.OnidUserModifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateModify", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateModify
		{
			get
			{
				return this._dateModify;
			}
			set
			{
				if ((this._dateModify != value))
				{
					this.OndateModifyChanging(value);
					this.SendPropertyChanging();
					this._dateModify = value;
					this.SendPropertyChanged("dateModify");
					this.OndateModifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_orderBody", Storage="_orderBodies", ThisKey="id", OtherKey="idProduct")]
		public EntitySet<orderBody> orderBodies
		{
			get
			{
				return this._orderBodies;
			}
			set
			{
				this._orderBodies.Assign(value);
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
		
		private void attach_orderBodies(orderBody entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_orderBodies(orderBody entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.userApp")]
	public partial class userApp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _username;
		
		private System.Data.Linq.Binary _password;
		
		private string _email;
		
		private bool _active;
		
		private int _idUserCreated;
		
		private System.DateTime _dateCreated;
		
		private System.Nullable<int> _idUserModify;
		
		private System.Nullable<System.DateTime> _dateModify;
		
		private EntitySet<orderHeader> _orderHeaders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(System.Data.Linq.Binary value);
    partial void OnpasswordChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnactiveChanging(bool value);
    partial void OnactiveChanged();
    partial void OnidUserCreatedChanging(int value);
    partial void OnidUserCreatedChanged();
    partial void OndateCreatedChanging(System.DateTime value);
    partial void OndateCreatedChanged();
    partial void OnidUserModifyChanging(System.Nullable<int> value);
    partial void OnidUserModifyChanged();
    partial void OndateModifyChanging(System.Nullable<System.DateTime> value);
    partial void OndateModifyChanged();
    #endregion
		
		public userApp()
		{
			this._orderHeaders = new EntitySet<orderHeader>(new Action<orderHeader>(this.attach_orderHeaders), new Action<orderHeader>(this.detach_orderHeaders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarBinary(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_active", DbType="Bit NOT NULL")]
		public bool active
		{
			get
			{
				return this._active;
			}
			set
			{
				if ((this._active != value))
				{
					this.OnactiveChanging(value);
					this.SendPropertyChanging();
					this._active = value;
					this.SendPropertyChanged("active");
					this.OnactiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUserCreated", DbType="Int NOT NULL")]
		public int idUserCreated
		{
			get
			{
				return this._idUserCreated;
			}
			set
			{
				if ((this._idUserCreated != value))
				{
					this.OnidUserCreatedChanging(value);
					this.SendPropertyChanging();
					this._idUserCreated = value;
					this.SendPropertyChanged("idUserCreated");
					this.OnidUserCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime dateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				if ((this._dateCreated != value))
				{
					this.OndateCreatedChanging(value);
					this.SendPropertyChanging();
					this._dateCreated = value;
					this.SendPropertyChanged("dateCreated");
					this.OndateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUserModify", DbType="Int")]
		public System.Nullable<int> idUserModify
		{
			get
			{
				return this._idUserModify;
			}
			set
			{
				if ((this._idUserModify != value))
				{
					this.OnidUserModifyChanging(value);
					this.SendPropertyChanging();
					this._idUserModify = value;
					this.SendPropertyChanged("idUserModify");
					this.OnidUserModifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateModify", DbType="DateTime")]
		public System.Nullable<System.DateTime> dateModify
		{
			get
			{
				return this._dateModify;
			}
			set
			{
				if ((this._dateModify != value))
				{
					this.OndateModifyChanging(value);
					this.SendPropertyChanging();
					this._dateModify = value;
					this.SendPropertyChanged("dateModify");
					this.OndateModifyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="userApp_orderHeader", Storage="_orderHeaders", ThisKey="id", OtherKey="idUser")]
		public EntitySet<orderHeader> orderHeaders
		{
			get
			{
				return this._orderHeaders;
			}
			set
			{
				this._orderHeaders.Assign(value);
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
		
		private void attach_orderHeaders(orderHeader entity)
		{
			this.SendPropertyChanging();
			entity.userApp = this;
		}
		
		private void detach_orderHeaders(orderHeader entity)
		{
			this.SendPropertyChanging();
			entity.userApp = null;
		}
	}
}
#pragma warning restore 1591