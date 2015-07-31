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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GamerTagDB")]
public partial class GamerTagDBLinqDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertTable(Table instance);
  partial void UpdateTable(Table instance);
  partial void DeleteTable(Table instance);
  #endregion
	
	public GamerTagDBLinqDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["GamerTagDBConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public GamerTagDBLinqDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GamerTagDBLinqDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GamerTagDBLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GamerTagDBLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Table> Tables
	{
		get
		{
			return this.GetTable<Table>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
public partial class Table : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _name;
	
	private string _live;
	
	private string _psn;
	
	private string _steam;
	
	private string _wiiu;
	
	private string _games;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnliveChanging(string value);
    partial void OnliveChanged();
    partial void OnpsnChanging(string value);
    partial void OnpsnChanged();
    partial void OnsteamChanging(string value);
    partial void OnsteamChanged();
    partial void OnwiiuChanging(string value);
    partial void OnwiiuChanged();
    partial void OngamesChanging(string value);
    partial void OngamesChanged();
    #endregion
	
	public Table()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Id
	{
		get
		{
			return this._Id;
		}
		set
		{
			if ((this._Id != value))
			{
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_live", DbType="NVarChar(50)")]
	public string live
	{
		get
		{
			return this._live;
		}
		set
		{
			if ((this._live != value))
			{
				this.OnliveChanging(value);
				this.SendPropertyChanging();
				this._live = value;
				this.SendPropertyChanged("live");
				this.OnliveChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_psn", DbType="NVarChar(50)")]
	public string psn
	{
		get
		{
			return this._psn;
		}
		set
		{
			if ((this._psn != value))
			{
				this.OnpsnChanging(value);
				this.SendPropertyChanging();
				this._psn = value;
				this.SendPropertyChanged("psn");
				this.OnpsnChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_steam", DbType="NVarChar(50)")]
	public string steam
	{
		get
		{
			return this._steam;
		}
		set
		{
			if ((this._steam != value))
			{
				this.OnsteamChanging(value);
				this.SendPropertyChanging();
				this._steam = value;
				this.SendPropertyChanged("steam");
				this.OnsteamChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_wiiu", DbType="NVarChar(50)")]
	public string wiiu
	{
		get
		{
			return this._wiiu;
		}
		set
		{
			if ((this._wiiu != value))
			{
				this.OnwiiuChanging(value);
				this.SendPropertyChanging();
				this._wiiu = value;
				this.SendPropertyChanged("wiiu");
				this.OnwiiuChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_games", DbType="NVarChar(200)")]
	public string games
	{
		get
		{
			return this._games;
		}
		set
		{
			if ((this._games != value))
			{
				this.OngamesChanging(value);
				this.SendPropertyChanging();
				this._games = value;
				this.SendPropertyChanged("games");
				this.OngamesChanged();
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
#pragma warning restore 1591
