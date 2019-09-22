const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chat")
    .build();

connection.start().catch(err => console.error(err.toString()));

connection.on('Send', (nick, message) => {
    appendLine(nick, message);
});

document.getElementById('frm-send-message').addEventListener('submit', event => {
    let message = $('#message').val();
    let nick = $('#spn-nick').text();

    $('#message').val('');

    connection.invoke('Send', nick, message);
    event.preventDefault();
});

function appendLine(nick, message, color) {
    let nameElement = document.createElement('strong');
    nameElement.innerText = `${nick}:`;

    let msgElement = document.createElement('em');
    msgElement.innerText = ` ${message}`;

    let li = document.createElement('li');
    li.appendChild(nameElement);
    li.appendChild(msgElement);

    $('#messages').append(li);
};