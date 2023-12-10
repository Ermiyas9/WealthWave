﻿<%@ Page Language="C#" Title="Loan Account" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoanAccount.aspx.cs" Inherits="BankApplication1.LoanAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="text-center" style="margin-top: 50px; margin-bottom: 50px;">
 
        <h1 class="display-4">Loan Account [AccountNumber]</h1>
    </div>

    <div class="form-group "  style="margin-top: 100px; margin-bottom: 50px;">
        <label for="lblAccountNumber">Account Number:</label>
    <asp:Label ID="lblAccountNumber" runat="server" Text="123456789" />
    </div>

    <div>
        <label for="lblBalance">Statement Balance:</label>
        <asp:Label ID="lblBalance" runat="server" Text="$1,000.00" />
    </div>
       <div class="bodyTitles" style="position: fixed; top: 300px; right: 100px;">
            <ul>
                <li><asp:HyperLink NavigateUrl="Deposit.aspx" Text="Deposit" runat="server" /></li>
                <li><asp:HyperLink NavigateUrl="Withdraw.aspx" Text="Withdraw" runat="server" /></li>
                <li><asp:HyperLink NavigateUrl="SettingAndPrivacy.aspx" Text="Setting and Privacy" runat="server" /></li>
                <li><asp:HyperLink NavigateUrl="ContactAndSupport.aspx" Text="Contact and Support" runat="server" /></li>
            </ul>
        </div>

<div class="form-group" style="margin-top: 100px; margin-bottom: 50px;">
    <ul class="form-group-labels">
        <li><label for="lblLastPayment">Last Payment:</label></li>
        <li><label for="lblCurrentMinPayment">Current Minimum Payment:</label></li>
        <li><label for="lblOverLimitPayment">Over Limit Payment:</label></li>
        <li><label for="lblTotalPayment">Total Owed Balance:</label></li>
        <li><label for="lblDetailPayment">Detail Loan Transactions:</label></li>
    </ul>
</div>


</asp:Content>