"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/ChatHub").build();

//Disable send button until connection is established
document.getElementById("sendBtn").disabled = true;

connection.on("ReceiveMessage", function (username, message, datetime, color) {
    

    var msg = message;
//  var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");


    //Félkövér név létrehozása
    var nameB = document.createElement("b");
    nameB.textContent = username + ": ";
    //Üzenet létrehozása
    var messageP = document.createElement("p");
    console.log(color);
    nameB.style.color = color;
    messageP.appendChild(nameB);
    messageP.append(msg);
    messageP.title = new Date(datetime).toUTCString();

    //Üzenet hozzáadása a listához
    document.getElementById("messageList").appendChild(messageP);
});

connection.start().then(function () {
    document.getElementById("sendBtn").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendBtn").addEventListener("click", function (event) {
    //Név és üzenet kiolvasása a szövegmezőkből
    var username = document.getElementById("usernameInput").value;
    var message = document.getElementById("messageInput").value;

    //Üzenet küldése a szervernek (SendMessage függvény meghívása)
    connection.invoke("SendMessage", username, message, document.querySelector('#colorPicker').value).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});