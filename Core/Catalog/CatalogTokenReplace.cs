/*
'  DNN (formerly DotNetNuke) - http://www.dnnsoftware.com
'  Copyright (c) 2002-2018
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

using System;

using DotNetNuke.Services.Tokens;

using DotNetNuke.Modules.Store.Core.Admin;
using DotNetNuke.Modules.Store.Core.Components;

namespace DotNetNuke.Modules.Store.Core.Catalog
{
    /// <summary>
    /// Used to replace tokens in a source string by corresponding values from the specified properties.
    /// </summary>
    public class CatalogTokenReplace : BaseCustomConditionalTokenReplace
    {
        #region Contructor

        public CatalogTokenReplace()
        {
            CurrentAccessLevel = Scope.NoSettings;
        }

        #endregion

        #region Properties

        public StoreInfo StoreSettings { get; set; }

        public CategoryInfo Category { get; set; }

        public ProductInfo Product { get; set; }

        #endregion

        #region Public Methods

        public string ReplaceCatalogTokens(string source)
        {
            if (StoreSettings != null)
                PropertySource["store"] = StoreSettings;
            else
                throw new Exception("StoreSettings property cannot be null!");

            if (Category != null)
                PropertySource["category"] = Category;

            if (Product != null)
                PropertySource["product"] = Product;

            return base.ReplaceTokens(source);
        }

        #endregion
    }
}
