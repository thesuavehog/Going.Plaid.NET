﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/processor/stripe/bank_account_token/create</c>' endpoint. Exchange a Link access_token for an Stripe API stripe_bank_account_token.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class StripeTokenResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		/// <value>The access token.</value>
		[JsonProperty("stripe_bank_account_token")]
		public string StripeBankAccountToken { get; set; } = string.Empty;
	}
}
