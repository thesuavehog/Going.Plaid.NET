﻿namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/delete</c>' endpoints. The '<c>/item/delete</c>' endpoint allows you to delete an <see cref="Entity.Item"/>. Once deleted, the access_token associated with the Item is no longer valid and cannot be used to access any data that was associated with the <see cref="Entity.Item"/>.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class DeleteItemResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets a value indicating whether the <see cref="Entity.Item"/> was deleted.
		/// </summary>
		/// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
		public bool Deleted { get; set; }
	}
}
