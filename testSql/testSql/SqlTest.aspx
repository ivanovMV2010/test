<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlTest.aspx.cs" Inherits="testSql.SqlTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 71%;
        }
        .auto-style2 {
            width: 268px;
        }
        .auto-style3 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HiddenField ID ="hfPeopleID" runat ="server" ></asp:HiddenField >
        <table cellspacing="10" class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Фамилия"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFamily" runat="server" Width="249px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Имя"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="245px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Отчество"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSurname" runat="server" Width="244px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Дата рождения"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server" Width="244px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Тип (спортсмен или тренер)"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtType" runat="server" Width="242px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="ИД клуба"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIDClube" runat="server" Width="241px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="ButtonSave" runat="server" style="text-align: center" Text="Сохранить" OnClick="ButtonSave_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonDelete" runat="server" Text="Удалить" />
                    <asp:Button ID="ButtonClear" runat="server" style="margin-left: 205px" Text="Очистить" OnClick="ButtonClear_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
        <br/./>

        <asp:GridView ID ="gvPeople" runat="server" AutoGenerateColumns ="false" Width="856px">
            <Columns>
                <asp:BoundField DataField ="Family" HeaderText="Фамилия" />
                 <asp:BoundField DataField ="Name" HeaderText="Имя" />
                 <asp:BoundField DataField ="Surname" HeaderText="Отчество" />
                <asp:BoundField DataField ="Date_Burh" HeaderText="Дата" />
                <asp:BoundField DataField ="Type" HeaderText="Тип" />
                <asp:BoundField DataField ="ID_clube" HeaderText="ИДКлуба" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Text="Select" ID ="lnkSelect" CommandArgument ='<%Eval(ID_People) %>' runat ="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
