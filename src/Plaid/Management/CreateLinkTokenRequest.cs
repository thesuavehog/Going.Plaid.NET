﻿using System.Collections.Generic;
using Going.Plaid.Entity;
using Newtonsoft.Json;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/link/token/create</c>' endpoint. Used to create a <c>link_token</c>.
	/// </summary>
	/// <seealso cref="RequestBase" />
	public class CreateLinkTokenRequest : RequestBase
	{
		/// <summary>
		/// Displayed once a user has successfully linked their <see cref="Item"/>.
		/// </summary>
		[JsonProperty("client_name")]
		public string ClientName { get; set; } = null!;

		/// <summary>
		/// Specify a Plaid-supported language to localize Link.
		/// </summary>
		[JsonProperty("language")]
		public Language Language { get; set; }

		/// <summary>
		/// Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard. Note that if you initialize with a European country code, your users will see the European consent panel during the Link flow.
		/// </summary>
		[JsonProperty("country_codes")]
		public string[] CountryCodes { get; set; } = null!;

		/// <summary>
		/// An object containing information about your end user.
		/// </summary>
		[JsonProperty("user")]
		public User User { get; set; } = null!;

		/// <summary>
		/// A list of Plaid product(s) you wish to use. Only institutions that support all requested products will be shown. In Production, you will be billed for each product that you specify when initializing Link. If Link is launched with multiple <see cref="CountryCodes"/>, only <c>product</c>s that you are enabled for in all countries will be used by Link.
		/// </summary>
		[JsonProperty("products")]
		public Product[]? Products { get; set; } = null!;

		/// <summary>
		/// Specify a webhook to associate with an <see cref="Item"/>. Plaid fires a webhook when the <see cref="Item"/> requires updated credentials, when new data is available, or when Auth numbers have been successfully verified.
		/// </summary>
		[JsonProperty("webhook")]
		public string? Webhook { get; set; }

		/// <summary>
		/// A URI indicating the destination where a user should be forwarded after completing the Link flow. The <see cref="RedirectUri"/> is used to support OAuth authentication flows when launching Link in the browser or via a webview.
		/// </summary>
		[JsonProperty("redirect_uri")]
		public string? RedirectUri { get; set; }

		/// <summary>
		/// Configures Link to return only accounts that are specified by these filters if Auth or Liabilities is a configured product. 
		/// </summary>
		[JsonProperty("account_filters")]
		public Dictionary<AccountType, AccountSubTypeFilter>? AccountFilters { get; set; }

		/// <summary>
		/// Holds a list of subtype filters used for an account filter
		/// </summary>
		public class AccountSubTypeFilter
		{
			/// <summary>
			/// The subtypes filtered within an account type
			/// </summary>
			[JsonProperty("account_subtypes")]
			public AccountSubType[] AccountSubTypes { get; set; } = null!;
		}
	}
}
