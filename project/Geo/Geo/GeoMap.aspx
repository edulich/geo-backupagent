<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GeoMap.aspx.cs" Inherits="Geo.GeoMap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
	<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false" ></script> 
	<script src="JS/jquery-1.8.1.min.js" type="text/javascript"></script>
	<script src="JS/GeoMap.js"  type="text/javascript"></script>
	<script src="JS/jquery.js"  type="text/javascript"></script>
	<script src="JS/spin.js" type="text/javascript"></script>
	<style type="text/css">
		.square 
		{
			width: 180px;
			height: 160px;
			float: left;
			margin:15% 0 0 30%;
			padding: 10px 20px;
			color: #000;
			position: absolute;
			z-index: 100;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
	<script type="text/javascript">
		var geocoder;
		var map;
		var spinner;
		$(document).ready(function () 
		{
			initialize();
		});
	</script>
	<h2>BackupAgent GeoMap</h2>
	<div  class="square" id="_loader" style="position: absolute; padding: 20px; display: none; z-index:3000; block: none;"></div>
	<div id="map" style="height: 500px;"></div>

	<input id="address" type="textbox" value="Sydney, NSW">
	<input type="button" value="Encode" onclick="codeAddress()">

	<input id="adressesValue" type="textbox" visibility="hidden" value="Kyiv,Delft,Dnipropetrovsk,Toronto,Abuja,Accra,Adamstown,Algiers,Alofi,Amman,Amsterdam,Ankara,Antananarivo,Apia,Ashgabat,Asmara,Astana,Asunción,Athens,Baghdad,Baku,Bamako,Bangkok,Bangui,Banjul,Basseterre,Beijing,Beirut,Belgrade,Belmopan">
	<input type="button" value="Encode several" onclick="multiCodeAddress()">

</asp:Content>
