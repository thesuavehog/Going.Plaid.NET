﻿using Newtonsoft.Json;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/public_token/exchange</c>' endpoint. Exchange a Link public_token for an API access_token.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class ExchangeTokenResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the <see cref="Entity.Item"/> identifier.
		/// </summary>
		/// <value>The item identifier.</value>
		[JsonProperty("item_id")]
		public string ItemId { get; set; } = null!;

		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		/// <value>The access token.</value>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; } = null!;
	}
}
