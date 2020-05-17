<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Base_Form.aspx.cs" Inherits="ContadorDePalabras.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word Counter</title>
    <style type="text/css">
        .area-cuadro-texto {
            width: 80%;
            height: 240px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Word counter online</h1>
            <br />
        </div>
        <div class="form-group">

            <asp:TextBox ID="TxtBox" runat="server" class="area-cuadro-texto" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="WordsLbl" runat="server" Text="Word number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="CharLbl" runat="server" Text="Char number: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="CharLblWS" runat="server" Text="Char number without spaces: "></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="Submit" />
    </form>
</body>
</html>
