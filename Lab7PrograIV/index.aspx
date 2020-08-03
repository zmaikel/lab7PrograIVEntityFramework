<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lab7PrograIV.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server" ID="upd1">
                <ContentTemplate>
                    <asp:Label Text="Pais" runat="server" />
                    <asp:DropDownList ID="cmbPais"  runat="server">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label Text="Habitantes" runat="server" />
                    <asp:TextBox ID="txtHabitantes" runat="server" />
                    <br />
                    <br />
                    <asp:Label Text="Idioma" runat="server" />
                    <asp:DropDownList  ID="cmbIdioma" runat="server">
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label Text="PIB" runat="server" />
                    <asp:TextBox ID="txtPIB" runat="server" />
                    <br />
                    <br />
                    <asp:Label Text="Superficie" runat="server" />
                    <asp:TextBox ID="txtSUPERFICIE" runat="server" />
                    <br />
                    <br />
                    <asp:Label Text="Riesgo Seguridad" runat="server" />
                    <asp:RadioButtonList ID="radioRiesgo" runat="server" RepeatLayout="Flow">
                        <asp:ListItem Value="A">Alto</asp:ListItem>
                        <asp:ListItem Value="M">Medio</asp:ListItem>
                        <asp:ListItem Value="B">Bajo</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
                    <asp:Label Text="Sujeto a Prestamo" runat="server" />
                    <asp:CheckBox ID="checkPrestamo" runat="server" />
                    <br />
                    <br />
                    <asp:Button ID="btnActualizar" Text="Actualizar" runat="server" onClick="btnActualizar_Click"/>
                    <asp:Button id="btnBorrar" Text="Borrar" runat="server" onclick="btnBorrar_Click"/>
                    <asp:Button id="btnRegistra" Text="Registrar" runat="server" onclick="btnRegistra_Click"/>
                    <br />
                    <br />
                    <asp:GridView ID="gridPrestamo" runat="server" DataKeyNames="TGP_ID" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        <Columns>
                                    <asp:BoundField DataField="TGP_PAIS_ID" HeaderText="Pais" />
                                    <asp:BoundField DataField="TGP_HABITANTES" HeaderText="Habitantes" />
                                    <asp:BoundField DataField="TGP_IDIOMA" HeaderText="Idioma" />
                                    <asp:BoundField DataField="TGP_PIB" HeaderText="PIB" />
                                    <asp:BoundField DataField="TGP_SUPERFICIE" HeaderText="Superficie" />
                                    <asp:BoundField DataField="TGP_RIESGO_SEGURIDAD" HeaderText="Riesgo" />
                                    <asp:BoundField DataField="TGP_ABLE" HeaderText="Prestamo" />

                                </Columns>
                    </asp:GridView>
                    <br />

                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
