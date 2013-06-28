﻿using System.Collections.Generic;
using System.Web.Mvc;
using SmartStore.Core.Domain.Stores;

namespace SmartStore.Services.Stores
{
	/// <summary>
	/// Store service interface
	/// </summary>
	public partial interface IStoreService
	{
		/// <summary>
		/// Deletes a store
		/// </summary>
		/// <param name="store">Store</param>
		void DeleteStore(Store store);

		/// <summary>
		/// Gets all stores
		/// </summary>
		/// <returns>Store collection</returns>
		IList<Store> GetAllStores();

		/// <summary>
		/// Gets all stores
		/// </summary>
		/// <returns>Store collection</returns>
		/// <remarks>codehint: sm-add</remarks>
		IList<SelectListItem> GetAllStoresAsListItems(IList<Store> stores = null);

		/// <summary>
		/// Gets a store 
		/// </summary>
		/// <param name="storeId">Store identifier</param>
		/// <returns>Store</returns>
		Store GetStoreById(int storeId);

		/// <summary>
		/// Inserts a store
		/// </summary>
		/// <param name="store">Store</param>
		void InsertStore(Store store);

		/// <summary>
		/// Updates the store
		/// </summary>
		/// <param name="store">Store</param>
		void UpdateStore(Store store);

		/// <summary>
		/// True if there's only one store. Otherwise False.
		/// </summary>
		/// <remarks>codehint: sm-add</remarks>
		bool IsSingleStoreMode();
	}
}