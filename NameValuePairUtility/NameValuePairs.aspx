<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NameValuePairs.aspx.cs" Inherits="NameValuePairUtility.NameValuePairs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Forms Test - Just for fun</title>
    <link href="simplegrid.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="grid grid-pad">
            <div class="col-3-12">
                <div class="content">
                    <span>Name Value Pair</span> <br />
                    <asp:TextBox runat="server" ID="txtNameValuePair" Width="210" />
                    <br /> <br />
                    <div>
                        <span>Name Value Pair List</span> <br />
                        <asp:ListBox ID="ListBox1" runat="server" Width="210" Height="100" 
                            DataTextField="Value" DataValueField="Key"></asp:ListBox>
                    </div>
		        </div>
	        </div>
             <div class="col-3-12">
                <div class="content">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="bottonClickAction" /> <br />
                    <asp:Button ID="btnFilter" runat="server" Text="Filter" /> <br />
                    <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" /> <br />
                    <asp:Button ID="btnSortByName" runat="server" Text="Sort By Name" /> <br />
                    <asp:Button ID="btnSortByValue" runat="server" Text="Sort By Value" /> <br />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" 
                        onclick="bottonClickAction" />
		        </div>
	        </div>
            <div class="col-3-12">
                <div class="content">
                    <asp:Label ID="errorLabel" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
