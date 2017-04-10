/*
'  DNN (formerly DotNetNuke) - http://www.dnnsoftware.com
'  Copyright (c) 2002-2016
'  by DNN Corp
' 
'  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
'  documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
'  the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
'  to permit persons to whom the Software is furnished to do so, subject to the following conditions:
' 
'  The above copyright notice and this permission notice shall be included in all copies or substantial portions 
'  of the Software.
' 
'  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
'  TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
'  THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
'  CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
'  DEALINGS IN THE SOFTWARE.
*/

using System.Data;
using DotNetNuke.Framework;

namespace DotNetNuke.Modules.Store.Providers.Tax.CountryTaxProvider
{
	/// <summary>
	/// Summary description for DataProvider.
	/// </summary>
	public abstract class DataProvider
	{
		#region Private Members

		private static DataProvider _provider; 

		#endregion

		#region Constructors

		static DataProvider() 
		{ 
			CreateProvider(); 
		} 

		private static void CreateProvider() 
		{
            _provider = (DataProvider)Reflection.CreateObject("data", "DotNetNuke.Modules.Store.Providers.Tax.CountryTaxProvider", "DotNetNuke.Modules.Store.Providers.Tax.CountryTaxProvider");
		} 

		public static DataProvider Instance() 
		{ 
			return _provider; 
		}

		#endregion

		#region Abstract Methods

		public abstract IDataReader GetTaxRates(int portalID);
        public abstract void UpdateTaxRates(int portalID, decimal defaultTaxRate, bool showTax, string countryTaxRates);

		#endregion
	}
}