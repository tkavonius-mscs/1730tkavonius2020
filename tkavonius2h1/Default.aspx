﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="tkavonius2h1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6">
            <h2>DateTime Methods</h2>
            <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="1) DateTime.Now"></asp:Label>
                <asp:TextBox ID="TextBox1aResult" runat="server" Enabled="False"></asp:TextBox>
           
                <asp:TextBox ID="TextBox1bResult" runat="server" Enabled="False"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="2) Datetime.Today"></asp:Label>
                  <asp:TextBox ID="TextBox2aResult" runat="server" Enabled="False"></asp:TextBox>
           
                <asp:TextBox ID="TextBox2bResult" runat="server" Enabled="False"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="3) DateTime.Today:"></asp:Label>
                <asp:TextBox ID="TextBox3aResult" runat="server" Enabled="False" Width="40px"></asp:TextBox>
           <asp:TextBox ID="TextBox3bResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
                <asp:TextBox ID="TextBox3cResult" runat="server" Enabled="False" Width="30px"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="4) DateTime.AddDays()"></asp:Label>
                <asp:TextBox ID="TextBox4Result" runat="server" Enabled="False"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="5)DateTime.AddMonths()"></asp:Label>
                               <asp:TextBox ID="TextBox5Result" runat="server" Enabled="False"></asp:TextBox>
           
            
           
            </div> <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="6) DateTime (y, m, d)"></asp:Label>
                <asp:TextBox ID="TextBox6a" runat="server" Width="40px"></asp:TextBox>
           
                <asp:TextBox ID="TextBox6b" runat="server" Width="40px"></asp:TextBox>
           
                <asp:TextBox ID="TextBox6c" runat="server" Width="40px"></asp:TextBox>
           
                               <asp:TextBox ID="TextBox6Result" runat="server" Enabled="False"></asp:TextBox>
           
            
           
            </div> <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="7) DateTime.Parse()"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
           
                               <asp:TextBox ID="TextBox7Result" runat="server" Enabled="False"></asp:TextBox>
           
            
           
            </div> <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="8) DateTime.TryParse()"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
           
                               <asp:TextBox ID="TextBox8Result" runat="server" Enabled="False"></asp:TextBox>
           
            
           
            </div> <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="9) DateA - DateB"></asp:Label>
                <asp:TextBox ID="TextBox9a" runat="server" Width="70px"></asp:TextBox>
           
                <asp:TextBox ID="TextBox9b" runat="server" Width="70px"></asp:TextBox>
           
                               <asp:TextBox ID="TextBox9Result" runat="server" Enabled="False"></asp:TextBox>
           
            
           
            </div> <div class="form-group">
            <asp:Label ID="Label10" runat="server" Text="10) DateA &gt; DateB"></asp:Label>
                <asp:TextBox ID="TextBox10a" runat="server" Width="70px"></asp:TextBox>

                <asp:TextBox ID="TextBox10b" runat="server" Width="70px"></asp:TextBox>
           
                               <asp:TextBox ID="TextBox10Result" runat="server" Enabled="False"></asp:TextBox>
           
            
           
           </div> 
           <div> 
           <asp:Button ID="Button1" runat="server" Text="Date Calculation" Width="176px" OnClick="Button1_Click" />
               
            </div>

             
           
            </div>
        <div class="col-md-6">
            <h2>String Methods</h2>
                 <div class="form-group">
            <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
           
            </div> <div class="form-group">
            <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
           
            </div>
             
        </div>
    </div>

</asp:Content>
