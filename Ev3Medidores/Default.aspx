<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ev3Medidores.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeslbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="idMedidorTxt">Id Medidor</label>
                        <asp:TextBox ID="idMedidorTxt" CssClass="form-control" runat="server" type="number" min="0"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" id="reqId" controltovalidate="idMedidorTxt" errormessage="Ingresa un id de medidor!" />
                        <asp:CustomValidator runat="server" id="validatorID" controltovalidate="idMedidorTxt" onservervalidate="ValidatorID_ServerValidate" errormessage="Ya existe un medidor con dicho id" />
                    </div>
                    <div class="form-group">
                        <label for="tipoDdl">Tipo de Medidor</label>
                        <asp:DropDownList runat="server" ID="tipoDdl" CssClass="form-select">

                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                            Text="Agregar" CssClass="btn btn-primary " />
                    </div>
                </div>
                </div>
            </div>
        </div>
    
</asp:Content>
