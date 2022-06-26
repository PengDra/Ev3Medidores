<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AgregarLecturas.aspx.cs" Inherits="Ev3Medidores.AgregarLecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeslbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="form-group">
                    <label for="medidoresDdl">Medidores</label>
                    <asp:DropDownList runat="server" ID="medidoresDdl" CssClass="form-select">
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <div class="col-lg-6">
                        <asp:Calendar ID="calendar" runat="server" OnSelectionChanged="calendar_SelectionChanged"></asp:Calendar>
                        <asp:TextBox ID="calendarTxt" readonly="true" runat="server"></asp:TextBox>
                        <div class="row mx-auto">
                            <asp:TextBox ID="horaTxt" runat="server" type="number" CssClass="form-control" Placeholder="Hora"></asp:TextBox>
                            <asp:RangeValidator ErrorMessage="Debes ingresar una hora valida!" ControlToValidate="horaTxt" runat="server" MinimumValue="0" MaximumValue="23" />
                            <asp:TextBox ID="minutosTxt" runat="server" type="Integer" CssClass="form-control" Placeholder="Minutos"></asp:TextBox>
                            <asp:RangeValidator ErrorMessage="Debes ingresar una hora valida" ControlToValidate="minutosTxt" runat="server" MaximumValue="60" MinimumValue="0" />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="consumoTxt" runat="server" type="number" CssClass="form-control" Placeholder="Consumo"></asp:TextBox>
                    <asp:RangeValidator ErrorMessage="El valor de consumo debe ser entre 0 y 600" ControlToValidate="consumoTxt" runat="server" MinimumValue="0" MaximumValue="600" />
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                        Text="Agregar" CssClass="btn btn-primary " />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
