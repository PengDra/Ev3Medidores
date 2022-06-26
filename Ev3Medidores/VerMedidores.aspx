<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="Ev3Medidores.VerMedidores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card-header bg-danger text-white">
                <h3>Ver Medidores</h3>
            </div>
            <div class="card-body">
                <div class="form-group">
                    <label for="filtrarxIdDdl">Filtrar por id</label>
                    <asp:DropDownList AutoPostBack="true" runat="server" ID="filtrarXIdDdl" OnSelectedIndexChanged="filtrarXTipoDdl_SelectedIndexChanged">
                        <asp:ListItem Value="Medidor de Agua" Text="Medidor de Agua"></asp:ListItem>
                        <asp:ListItem Value="Medidor de Gas" Text="Medidor de Gas"></asp:ListItem>
                        <asp:ListItem Value="Medidor de Luz" Text="Medidor de Luz"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:GridView CssClass="table table-hover table-bordered mt-5"
                    AutoGenerateColumns="false"
                    EmptyDataText="No hay Medidores"
                    ShowHeader="true"
                    runat="server" ID="grillaMedidores">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="Tipo" HeaderText="TIPO DE MEDIDOR" />

                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
