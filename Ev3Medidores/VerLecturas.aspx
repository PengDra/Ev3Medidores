<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Ev3Medidores.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="form-group">
                    <asp:Button runat="server" ID="restartBtn" OnClick="restartBtn_Click"
                        Text="Reiniciar Filtro" CssClass="btn btn-primary " />
                     <asp:Button runat="server" ID="Filtrar" OnClick="Filtrar_Click"
                        Text="Filtrar Por Id" CssClass="btn btn-primary " />
                </div>
            <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>           
                </div>
            <div class="card-body">
                <div class="form-group">
                    <label for="medidoresDdl">Medidores</label>
                    <asp:DropDownList runat="server" ID="medidoresDdl" OnSelectedIndexChanged="medidoresDdl_SelectedIndexChanged" CssClass="form-select">
                    
                    </asp:DropDownList>
                </div>
                <asp:GridView CssClass="table table-hover table-bordered mt-5"
                    AutoGenerateColumns="false"
                    EmptyDataText="No hay Lecturas"
                    ShowHeader="true"
                    runat="server" ID="grillaLecturas">
                    <Columns>
                        <asp:BoundField DataField="Idmedidor" HeaderText="ID" />
                        <asp:BoundField DataField="Fecha" HeaderText="FECHA" />
                        <asp:BoundField DataField="Consumo" HeaderText="CONSUMO" />

                    </Columns>
                </asp:GridView>
            </div>
        </div>
   </div>



</asp:Content>
