<%@ Control language="c#" CodeBehind="DefaultAddressCheckout.ascx.cs" Inherits="DotNetNuke.Modules.Store.Providers.Address.DefaultAddressProvider.DefaultAddressCheckout" AutoEventWireup="True" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnnstore" TagName="address" Src="StoreAddress.ascx" %>
<fieldset class="StoreAccountCheckoutBillingAddress">
    <legend>
        <asp:Label id="lblBillingAddressTitle" runat="server" resourcekey="lblBillingAddressTitle">Billing Address</asp:Label>
    </legend>
    <table id="rowListBillAddress" runat="server" class="StoreAccountCheckoutSelectBillingAddress">
	    <tr>
		    <td class="StoreAddressLabel">
			    <dnn:label id="lblBillAddress" controlname="lstBillAddress" runat="server"></dnn:label>
		    </td>
		    <td class="StoreAddressField">
			    <asp:dropdownlist id="lstBillAddress" runat="server" CssClass="NormalTextBox" AutoPostBack="true" onselectedindexchanged="lstBillAddress_SelectedIndexChanged"></asp:dropdownlist>
		    </td>
	    </tr>
    </table>
    <dnnstore:address id="addressBilling" runat="server" StartTabIndex="3"></dnnstore:address>
</fieldset>
<fieldset ID="fsShippingAddress" class="StoreAccountCheckoutShippingAddress" runat="server">
    <legend>
        <asp:Label id="lblShippingAddressTitle" runat="server" resourcekey="lblShippingAddressTitle">Shipping Address</asp:Label>
    </legend>
    <table class="StoreAccountCheckoutSelectShippingAddress">
	    <tr>
		    <td>
			    <dnn:label id="lblShipAddressOptions" controlname="radBilling" runat="server"></dnn:label>
		    </td>
		    <td>
			    <asp:radiobutton id="radNone" tabIndex="20" runat="server" autopostback="True" groupname="radShipAddress" oncheckedchanged="radNone_CheckedChanged" Text="none" ResourceKey="lblNone"></asp:radiobutton><br />
			    <asp:radiobutton id="radBilling" tabIndex="21" runat="server" autopostback="True" groupname="radShipAddress" oncheckedchanged="radBilling_CheckedChanged" Text="billing" ResourceKey="lblUseBillingAddress"></asp:radiobutton><br />
			    <asp:radiobutton id="radShipping" tabIndex="22" runat="server" autopostback="True" groupname="radShipAddress" oncheckedchanged="radShipping_CheckedChanged" Text="billing" ResourceKey="lblUseShippingAddress"></asp:radiobutton>
		    </td>
	    </tr>
	    <tr id="rowListShipAddress" runat="server" >
		    <td class="StoreAddressLabel">
			    <dnn:label id="lblShipAddress" controlname="lstShipAddress" runat="server"></dnn:label>
		    </td>
		    <td class="StoreAddressField">
			    <asp:dropdownlist id="lstShipAddress" tabIndex="23" runat="server" CssClass="NormalTextBox" autopostback="True" onselectedindexchanged="lstShipAddress_SelectedIndexChanged"></asp:dropdownlist>
		    </td>
	    </tr>
    </table>
    <dnnstore:address id="addressShipping" runat="server" StartTabIndex="24"></dnnstore:address>
</fieldset>
