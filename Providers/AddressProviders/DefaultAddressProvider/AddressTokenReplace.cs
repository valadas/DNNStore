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

using DotNetNuke.Modules.Store.Core.Providers.Address;

namespace DotNetNuke.Modules.Store.Providers.Address.DefaultAddressProvider
{
    public sealed class AddressTokenReplace : BaseCustomTokenReplace
    {
        #region Contructor

        public AddressTokenReplace(string tokenObjectName, IAddressInfo address)
        {
            if (string.IsNullOrEmpty(tokenObjectName) == false && address != null)
            {
                PropertySource[tokenObjectName.ToLower()] = address;
                CurrentAccessLevel = Scope.NoSettings;
            }
            else
                throw new Exception("TokenObjectName and Address parameters cannot be null!");
        }

        #endregion

        #region Public Methods

        public string ReplaceAddressTokens(string source)
        {
            return ReplaceTokens(source);
        }

        #endregion
    }
}
