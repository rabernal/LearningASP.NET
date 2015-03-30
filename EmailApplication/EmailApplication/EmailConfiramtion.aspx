﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailConfiramtion.aspx.cs" Inherits="EmailApplication.EmailConfiramtion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #header {
            background-color: black;
            color: white;
            text-align: center;
            padding: 5px;
        }

        #nav {
            line-height: 30px;
            background-color: #eeeeee;
            height: 300px;
            width: 100px;
            float: left;
            padding: 5px;
        }

        #section {
            width: 350px;
            float: left;
            padding: 10px;
        }

        #footer {
            background-color: black;
            color: white;
            clear: both;
            text-align: center;
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header id="header">
            <h1>City Gallery</h1>
        </header>

        <nav id="nav">
            <a href="#">London</a><br />
            <a href="#">Paris</a><br />
            <a href="#">Tokyo</a><br />
            <input id="Submit1" type="submit" onclick="<%EmailApplication.MailingClass.SendEmail();%>" value="submit" />
        </nav>

        <section id="section">
            <h1>London</h1>
            <p>
                I am testing to see how this email will show in different formats. 
                London is the capital city of England. It is the most populous city in the United Kingdom,
                with a metropolitan area of over 13 million inhabitants.
            </p>
            <p>
                Standing on the River Thames, London has been a major settlement for two millennia,
                its history going back to its founding by the Romans, who named it Londinium.
            </p>
        </section>

        <footer id="footer">
            Copyright © RafaelTechnologies
            Copyright 
        </footer>

    </form>
</body>
</html>
