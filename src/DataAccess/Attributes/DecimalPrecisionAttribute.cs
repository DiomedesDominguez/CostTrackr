// Copyright 2004-2024 DNMOFT- http://www.dnmoft.com/
//
// Licensed under the Microsoft Public License (Ms-PL), (the "License");
// you may not use this file except in compliance with the License.
//
// You may obtain a copy of the License at
//
//     https://msdn.microsoft.com/en-us/library/ff649456.aspx
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace System.ComponentModel.DataAnnotations
{
	/// <summary>
	///     Class DecimalPrecisionAttribute.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class DecimalPrecisionAttribute : Attribute
	{
		#region Constructors

		/// <summary>
		///     Initializes a new instance of the <see cref="DecimalPrecisionAttribute" /> class.
		/// </summary>
		/// <param name="precision">The precision.</param>
		/// <param name="scale">The scale.</param>
		public DecimalPrecisionAttribute(byte precision = 18, byte scale = 2)
		{
			Precision = precision;
			Scale = scale;
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		///     Gets or sets the precision.
		/// </summary>
		/// <value>The precision.</value>
		public byte Precision { get; set; }

		/// <summary>
		///     Gets or sets the scale.
		/// </summary>
		/// <value>The scale.</value>
		public byte Scale { get; set; }

		#endregion Properties
	}
}