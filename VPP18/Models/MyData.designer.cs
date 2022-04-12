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

namespace VPP18.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VanPhongPhamnew")]
	public partial class MyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertADMIN(ADMIN instance);
    partial void UpdateADMIN(ADMIN instance);
    partial void DeleteADMIN(ADMIN instance);
    partial void InsertDANHMUCSANPHAM(DANHMUCSANPHAM instance);
    partial void UpdateDANHMUCSANPHAM(DANHMUCSANPHAM instance);
    partial void DeleteDANHMUCSANPHAM(DANHMUCSANPHAM instance);
    partial void InsertDONHANG(DONHANG instance);
    partial void UpdateDONHANG(DONHANG instance);
    partial void DeleteDONHANG(DONHANG instance);
    partial void InsertNCC(NCC instance);
    partial void UpdateNCC(NCC instance);
    partial void DeleteNCC(NCC instance);
    partial void InsertNGUOIDUNG(NGUOIDUNG instance);
    partial void UpdateNGUOIDUNG(NGUOIDUNG instance);
    partial void DeleteNGUOIDUNG(NGUOIDUNG instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertTHANHTOAN(THANHTOAN instance);
    partial void UpdateTHANHTOAN(THANHTOAN instance);
    partial void DeleteTHANHTOAN(THANHTOAN instance);
    #endregion
		
		public MyDataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VanPhongPhamnewConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ADMIN> ADMINs
		{
			get
			{
				return this.GetTable<ADMIN>();
			}
		}
		
		public System.Data.Linq.Table<DANHMUCSANPHAM> DANHMUCSANPHAMs
		{
			get
			{
				return this.GetTable<DANHMUCSANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<DONHANG> DONHANGs
		{
			get
			{
				return this.GetTable<DONHANG>();
			}
		}
		
		public System.Data.Linq.Table<NCC> NCCs
		{
			get
			{
				return this.GetTable<NCC>();
			}
		}
		
		public System.Data.Linq.Table<NGUOIDUNG> NGUOIDUNGs
		{
			get
			{
				return this.GetTable<NGUOIDUNG>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<THANHTOAN> THANHTOANs
		{
			get
			{
				return this.GetTable<THANHTOAN>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMIN")]
	public partial class ADMIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TenAD;
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTenADChanging(string value);
    partial void OnTenADChanged();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public ADMIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenAD", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenAD
		{
			get
			{
				return this._TenAD;
			}
			set
			{
				if ((this._TenAD != value))
				{
					this.OnTenADChanging(value);
					this.SendPropertyChanging();
					this._TenAD = value;
					this.SendPropertyChanged("TenAD");
					this.OnTenADChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DANHMUCSANPHAM")]
	public partial class DANHMUCSANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdDM;
		
		private string _TenDM;
		
		private string _HinhAnh;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdDMChanging(int value);
    partial void OnIdDMChanged();
    partial void OnTenDMChanging(string value);
    partial void OnTenDMChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    #endregion
		
		public DANHMUCSANPHAM()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDM", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdDM
		{
			get
			{
				return this._IdDM;
			}
			set
			{
				if ((this._IdDM != value))
				{
					this.OnIdDMChanging(value);
					this.SendPropertyChanging();
					this._IdDM = value;
					this.SendPropertyChanged("IdDM");
					this.OnIdDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenDM
		{
			get
			{
				return this._TenDM;
			}
			set
			{
				if ((this._TenDM != value))
				{
					this.OnTenDMChanging(value);
					this.SendPropertyChanging();
					this._TenDM = value;
					this.SendPropertyChanged("TenDM");
					this.OnTenDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="VarChar(100)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUCSANPHAM_SANPHAM", Storage="_SANPHAMs", ThisKey="IdDM", OtherKey="IdDM")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUCSANPHAM = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.DANHMUCSANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONHANG")]
	public partial class DONHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDH;
		
		private int _IdND;
		
		private System.Nullable<decimal> _ThanhTien;
		
		private string _TinhTrang;
		
		private System.DateTime _NgayDat;
		
		private System.DateTime _NgayGiao;
		
		private EntitySet<THANHTOAN> _THANHTOANs;
		
		private EntityRef<NGUOIDUNG> _NGUOIDUNG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnIdNDChanging(int value);
    partial void OnIdNDChanged();
    partial void OnThanhTienChanging(System.Nullable<decimal> value);
    partial void OnThanhTienChanged();
    partial void OnTinhTrangChanging(string value);
    partial void OnTinhTrangChanged();
    partial void OnNgayDatChanging(System.DateTime value);
    partial void OnNgayDatChanged();
    partial void OnNgayGiaoChanging(System.DateTime value);
    partial void OnNgayGiaoChanged();
    #endregion
		
		public DONHANG()
		{
			this._THANHTOANs = new EntitySet<THANHTOAN>(new Action<THANHTOAN>(this.attach_THANHTOANs), new Action<THANHTOAN>(this.detach_THANHTOANs));
			this._NGUOIDUNG = default(EntityRef<NGUOIDUNG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdND", DbType="Int NOT NULL")]
		public int IdND
		{
			get
			{
				return this._IdND;
			}
			set
			{
				if ((this._IdND != value))
				{
					if (this._NGUOIDUNG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdNDChanging(value);
					this.SendPropertyChanging();
					this._IdND = value;
					this.SendPropertyChanged("IdND");
					this.OnIdNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="DateTime NOT NULL")]
		public System.DateTime NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="DateTime NOT NULL")]
		public System.DateTime NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONHANG_THANHTOAN", Storage="_THANHTOANs", ThisKey="MaDH", OtherKey="MaDH")]
		public EntitySet<THANHTOAN> THANHTOANs
		{
			get
			{
				return this._THANHTOANs;
			}
			set
			{
				this._THANHTOANs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NGUOIDUNG_DONHANG", Storage="_NGUOIDUNG", ThisKey="IdND", OtherKey="IdND", IsForeignKey=true)]
		public NGUOIDUNG NGUOIDUNG
		{
			get
			{
				return this._NGUOIDUNG.Entity;
			}
			set
			{
				NGUOIDUNG previousValue = this._NGUOIDUNG.Entity;
				if (((previousValue != value) 
							|| (this._NGUOIDUNG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NGUOIDUNG.Entity = null;
						previousValue.DONHANGs.Remove(this);
					}
					this._NGUOIDUNG.Entity = value;
					if ((value != null))
					{
						value.DONHANGs.Add(this);
						this._IdND = value.IdND;
					}
					else
					{
						this._IdND = default(int);
					}
					this.SendPropertyChanged("NGUOIDUNG");
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
		
		private void attach_THANHTOANs(THANHTOAN entity)
		{
			this.SendPropertyChanging();
			entity.DONHANG = this;
		}
		
		private void detach_THANHTOANs(THANHTOAN entity)
		{
			this.SendPropertyChanging();
			entity.DONHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NCC")]
	public partial class NCC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdNCC;
		
		private string _TenNCC;
		
		private string _HinhAnh;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNCCChanging(int value);
    partial void OnIdNCCChanged();
    partial void OnTenNCCChanging(string value);
    partial void OnTenNCCChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public NCC()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNCC", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdNCC
		{
			get
			{
				return this._IdNCC;
			}
			set
			{
				if ((this._IdNCC != value))
				{
					this.OnIdNCCChanging(value);
					this.SendPropertyChanging();
					this._IdNCC = value;
					this.SendPropertyChanged("IdNCC");
					this.OnIdNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNCC", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNCC
		{
			get
			{
				return this._TenNCC;
			}
			set
			{
				if ((this._TenNCC != value))
				{
					this.OnTenNCCChanging(value);
					this.SendPropertyChanging();
					this._TenNCC = value;
					this.SendPropertyChanged("TenNCC");
					this.OnTenNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="VarChar(100)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(11)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NCC_SANPHAM", Storage="_SANPHAMs", ThisKey="IdNCC", OtherKey="IdNCC")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NCC = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NCC = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUOIDUNG")]
	public partial class NGUOIDUNG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdND;
		
		private string _TenND;
		
		private string _SDT;
		
		private string _DiaChi;
		
		private string _Email;
		
		private string _MatKhau;
		
		private EntitySet<DONHANG> _DONHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdNDChanging(int value);
    partial void OnIdNDChanged();
    partial void OnTenNDChanging(string value);
    partial void OnTenNDChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    #endregion
		
		public NGUOIDUNG()
		{
			this._DONHANGs = new EntitySet<DONHANG>(new Action<DONHANG>(this.attach_DONHANGs), new Action<DONHANG>(this.detach_DONHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdND", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdND
		{
			get
			{
				return this._IdND;
			}
			set
			{
				if ((this._IdND != value))
				{
					this.OnIdNDChanging(value);
					this.SendPropertyChanging();
					this._IdND = value;
					this.SendPropertyChanged("IdND");
					this.OnIdNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenND", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenND
		{
			get
			{
				return this._TenND;
			}
			set
			{
				if ((this._TenND != value))
				{
					this.OnTenNDChanging(value);
					this.SendPropertyChanging();
					this._TenND = value;
					this.SendPropertyChanged("TenND");
					this.OnTenNDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Char(11) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NGUOIDUNG_DONHANG", Storage="_DONHANGs", ThisKey="IdND", OtherKey="IdND")]
		public EntitySet<DONHANG> DONHANGs
		{
			get
			{
				return this._DONHANGs;
			}
			set
			{
				this._DONHANGs.Assign(value);
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
		
		private void attach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.NGUOIDUNG = this;
		}
		
		private void detach_DONHANGs(DONHANG entity)
		{
			this.SendPropertyChanging();
			entity.NGUOIDUNG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IdSP;
		
		private int _IdDM;
		
		private int _IdNCC;
		
		private string _TenSP;
		
		private string _HinhAnh;
		
		private System.Nullable<decimal> _DonGia;
		
		private int _SoLuongTon;
		
		private string _MoTa;
		
		private EntitySet<THANHTOAN> _THANHTOANs;
		
		private EntityRef<DANHMUCSANPHAM> _DANHMUCSANPHAM;
		
		private EntityRef<NCC> _NCC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdSPChanging(string value);
    partial void OnIdSPChanged();
    partial void OnIdDMChanging(int value);
    partial void OnIdDMChanged();
    partial void OnIdNCCChanging(int value);
    partial void OnIdNCCChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnDonGiaChanging(System.Nullable<decimal> value);
    partial void OnDonGiaChanged();
    partial void OnSoLuongTonChanging(int value);
    partial void OnSoLuongTonChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public SANPHAM()
		{
			this._THANHTOANs = new EntitySet<THANHTOAN>(new Action<THANHTOAN>(this.attach_THANHTOANs), new Action<THANHTOAN>(this.detach_THANHTOANs));
			this._DANHMUCSANPHAM = default(EntityRef<DANHMUCSANPHAM>);
			this._NCC = default(EntityRef<NCC>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSP", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IdSP
		{
			get
			{
				return this._IdSP;
			}
			set
			{
				if ((this._IdSP != value))
				{
					this.OnIdSPChanging(value);
					this.SendPropertyChanging();
					this._IdSP = value;
					this.SendPropertyChanged("IdSP");
					this.OnIdSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdDM", DbType="Int NOT NULL")]
		public int IdDM
		{
			get
			{
				return this._IdDM;
			}
			set
			{
				if ((this._IdDM != value))
				{
					if (this._DANHMUCSANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdDMChanging(value);
					this.SendPropertyChanging();
					this._IdDM = value;
					this.SendPropertyChanged("IdDM");
					this.OnIdDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdNCC", DbType="Int NOT NULL")]
		public int IdNCC
		{
			get
			{
				return this._IdNCC;
			}
			set
			{
				if ((this._IdNCC != value))
				{
					if (this._NCC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdNCCChanging(value);
					this.SendPropertyChanging();
					this._IdNCC = value;
					this.SendPropertyChanged("IdNCC");
					this.OnIdNCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="VarChar(100)")]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongTon", DbType="Int NOT NULL")]
		public int SoLuongTon
		{
			get
			{
				return this._SoLuongTon;
			}
			set
			{
				if ((this._SoLuongTon != value))
				{
					this.OnSoLuongTonChanging(value);
					this.SendPropertyChanging();
					this._SoLuongTon = value;
					this.SendPropertyChanged("SoLuongTon");
					this.OnSoLuongTonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(500)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_THANHTOAN", Storage="_THANHTOANs", ThisKey="IdSP", OtherKey="IdSP")]
		public EntitySet<THANHTOAN> THANHTOANs
		{
			get
			{
				return this._THANHTOANs;
			}
			set
			{
				this._THANHTOANs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DANHMUCSANPHAM_SANPHAM", Storage="_DANHMUCSANPHAM", ThisKey="IdDM", OtherKey="IdDM", IsForeignKey=true)]
		public DANHMUCSANPHAM DANHMUCSANPHAM
		{
			get
			{
				return this._DANHMUCSANPHAM.Entity;
			}
			set
			{
				DANHMUCSANPHAM previousValue = this._DANHMUCSANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._DANHMUCSANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DANHMUCSANPHAM.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._DANHMUCSANPHAM.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._IdDM = value.IdDM;
					}
					else
					{
						this._IdDM = default(int);
					}
					this.SendPropertyChanged("DANHMUCSANPHAM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NCC_SANPHAM", Storage="_NCC", ThisKey="IdNCC", OtherKey="IdNCC", IsForeignKey=true)]
		public NCC NCC
		{
			get
			{
				return this._NCC.Entity;
			}
			set
			{
				NCC previousValue = this._NCC.Entity;
				if (((previousValue != value) 
							|| (this._NCC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NCC.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._NCC.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._IdNCC = value.IdNCC;
					}
					else
					{
						this._IdNCC = default(int);
					}
					this.SendPropertyChanged("NCC");
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
		
		private void attach_THANHTOANs(THANHTOAN entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_THANHTOANs(THANHTOAN entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THANHTOAN")]
	public partial class THANHTOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTT;
		
		private int _MaDH;
		
		private string _IdSP;
		
		private int _SoLuong;
		
		private System.Nullable<decimal> _TongTien;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
		private EntityRef<DONHANG> _DONHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTTChanging(int value);
    partial void OnMaTTChanged();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnIdSPChanging(string value);
    partial void OnIdSPChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnTongTienChanging(System.Nullable<decimal> value);
    partial void OnTongTienChanged();
    #endregion
		
		public THANHTOAN()
		{
			this._SANPHAM = default(EntityRef<SANPHAM>);
			this._DONHANG = default(EntityRef<DONHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTT
		{
			get
			{
				return this._MaTT;
			}
			set
			{
				if ((this._MaTT != value))
				{
					this.OnMaTTChanging(value);
					this.SendPropertyChanging();
					this._MaTT = value;
					this.SendPropertyChanged("MaTT");
					this.OnMaTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", DbType="Int NOT NULL")]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					if (this._DONHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdSP", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string IdSP
		{
			get
			{
				return this._IdSP;
			}
			set
			{
				if ((this._IdSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdSPChanging(value);
					this.SendPropertyChanging();
					this._IdSP = value;
					this.SendPropertyChanged("IdSP");
					this.OnIdSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_THANHTOAN", Storage="_SANPHAM", ThisKey="IdSP", OtherKey="IdSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.THANHTOANs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.THANHTOANs.Add(this);
						this._IdSP = value.IdSP;
					}
					else
					{
						this._IdSP = default(string);
					}
					this.SendPropertyChanged("SANPHAM");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONHANG_THANHTOAN", Storage="_DONHANG", ThisKey="MaDH", OtherKey="MaDH", IsForeignKey=true)]
		public DONHANG DONHANG
		{
			get
			{
				return this._DONHANG.Entity;
			}
			set
			{
				DONHANG previousValue = this._DONHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONHANG.Entity = null;
						previousValue.THANHTOANs.Remove(this);
					}
					this._DONHANG.Entity = value;
					if ((value != null))
					{
						value.THANHTOANs.Add(this);
						this._MaDH = value.MaDH;
					}
					else
					{
						this._MaDH = default(int);
					}
					this.SendPropertyChanged("DONHANG");
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
}
#pragma warning restore 1591
